using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using StardewGPT.DataTypes;
using StardewModdingAPI;

namespace StardewGPT.Services
{
    /// <summary>Exception thrown when an invalid API key is used.</summary>
    public class InvalidApiKeyException : Exception
    {
        public InvalidApiKeyException(string message) : base(message) { }
    }

    /// <summary>Client for communicating with LLM API (Groq/OpenAI compatible).</summary>
    public class AIClient
    {
        private readonly HttpClient httpClient;
        private readonly ModConfig config;
        private readonly IMonitor monitor;

        public AIClient(ModConfig config, IMonitor monitor)
        {
            this.config = config;
            this.monitor = monitor;
            this.httpClient = new HttpClient
            {
                Timeout = TimeSpan.FromSeconds(30)
            };
        }

        /// <summary>Check for API errors and throw appropriate exceptions.</summary>
        private void CheckForApiErrors(HttpResponseMessage response, string responseContent)
        {
            if (response.IsSuccessStatusCode)
                return;

            this.monitor.Log($"API error: {response.StatusCode} - {responseContent}", LogLevel.Error);

            // Check for invalid API key error (401 Unauthorized)
            if (response.StatusCode == System.Net.HttpStatusCode.Unauthorized)
            {
                try
                {
                    JObject errorJson = JObject.Parse(responseContent);
                    string? errorCode = errorJson["error"]?["code"]?.ToString();
                    string? errorType = errorJson["error"]?["type"]?.ToString();

                    if (errorCode == "invalid_api_key" || errorType == "invalid_request_error")
                    {
                        throw new InvalidApiKeyException("Invalid API key");
                    }
                }
                catch (JsonException)
                {
                    // If JSON parsing fails, fall through to generic error
                }
            }

            // Check for Cloudflare-specific errors (404 NotFound with error code 7003)
            // This indicates invalid account ID or missing Workers AI permissions
            if (response.StatusCode == System.Net.HttpStatusCode.NotFound)
            {
                try
                {
                    JObject errorJson = JObject.Parse(responseContent);
                    JArray? errors = errorJson["errors"] as JArray;
                    if (errors != null && errors.Count > 0)
                    {
                        int? errorCode = errors[0]?["code"]?.Value<int>();
                        if (errorCode == 7003)
                        {
                            throw new InvalidApiKeyException("Invalid Cloudflare configuration");
                        }
                    }
                }
                catch (JsonException)
                {
                    // If JSON parsing fails, fall through to generic error
                }
                catch (InvalidApiKeyException)
                {
                    throw; // Re-throw InvalidApiKeyException
                }
            }

            throw new Exception($"API request failed: {response.StatusCode}");
        }

        /// <summary>Parse AI response from various API response formats.</summary>
        private string ParseAiResponse(string responseContent)
        {
            JObject responseJson = JObject.Parse(responseContent);

            // Try multiple response formats
            string? aiResponse = null;

            // Format 1: Cloudflare Workers AI format: result.response
            aiResponse = responseJson["result"]?["response"]?.ToString();

            // Format 2: OpenAI-compatible format nested in result: result.choices[0].message.content
            if (string.IsNullOrEmpty(aiResponse))
            {
                aiResponse = responseJson["result"]?["choices"]?[0]?["message"]?["content"]?.ToString();
            }

            // Format 3: OpenAI format: choices[0].message.content
            if (string.IsNullOrEmpty(aiResponse))
            {
                aiResponse = responseJson["choices"]?[0]?["message"]?["content"]?.ToString();
            }

            // Format 4: Direct response field
            if (string.IsNullOrEmpty(aiResponse))
            {
                aiResponse = responseJson["response"]?.ToString();
            }

            // Format 5: Result.text or result.generated_text
            if (string.IsNullOrEmpty(aiResponse))
            {
                aiResponse = responseJson["result"]?["text"]?.ToString();
            }

            if (string.IsNullOrEmpty(aiResponse))
            {
                aiResponse = responseJson["result"]?["generated_text"]?.ToString();
            }

            // Format 6: Text field directly
            if (string.IsNullOrEmpty(aiResponse))
            {
                aiResponse = responseJson["text"]?.ToString();
            }

            if (string.IsNullOrEmpty(aiResponse))
            {
                this.monitor.Log($"Could not find response in API output. Full response: {responseContent}", LogLevel.Error);
                this.monitor.Log($"Response JSON keys: {string.Join(", ", responseJson.Properties().Select(p => p.Name))}", LogLevel.Error);
                if (responseJson["result"] != null)
                {
                    this.monitor.Log($"Result keys: {string.Join(", ", ((JObject)responseJson["result"]!).Properties().Select(p => p.Name))}", LogLevel.Error);
                }
                throw new Exception("Empty response from API");
            }

            return aiResponse;
        }

        /// <summary>Send a chat completion request to the LLM API.</summary>
        /// <param name="systemPrompt">The system prompt to set context.</param>
        /// <param name="userMessage">The user's message.</param>
        /// <param name="context">Optional context from RAG retrieval.</param>
        /// <returns>The AI's response text.</returns>
        public async Task<string> GetChatCompletionAsync(string systemPrompt, string userMessage, string? context = null)
        {
            try
            {
                // Build the full user message with context if provided
                string fullUserMessage = context != null
                    ? $"Context:\n{context}\n\nQuestion: {userMessage}"
                    : userMessage;

                // Prepare the request payload
                var requestBody = new
                {
                    model = this.config.Model,
                    messages = new[]
                    {
                        new { role = "system", content = systemPrompt },
                        new { role = "user", content = fullUserMessage }
                    },
                    max_tokens = this.config.MaxTokens,
                    temperature = this.config.Temperature,
                    reasoning_effort = this.config.ReasoningEffort,
                    stream = false
                };

                string jsonRequest = JsonConvert.SerializeObject(requestBody);
                this.monitor.Log($"Sending request to API", LogLevel.Debug);

                // Create HTTP request
                var request = new HttpRequestMessage(HttpMethod.Post, this.config.ApiEndpoint)
                {
                    Content = new StringContent(jsonRequest, Encoding.UTF8, "application/json")
                };
                request.Headers.Add("Authorization", $"Bearer {this.config.ApiKey}");

                // Send request
                HttpResponseMessage response = await this.httpClient.SendAsync(request);
                string responseContent = await response.Content.ReadAsStringAsync();

                this.monitor.Log($"API Response Status: {response.StatusCode}", LogLevel.Debug);
                this.monitor.Log($"API Response Content (first 500 chars): {responseContent.Substring(0, Math.Min(500, responseContent.Length))}", LogLevel.Debug);

                // Log full response for debugging (especially for new models)
                if (responseContent.Length <= 2000)
                {
                    this.monitor.Log($"Full API Response: {responseContent}", LogLevel.Debug);
                }

                this.CheckForApiErrors(response, responseContent);

                // Parse response
                string aiResponse = this.ParseAiResponse(responseContent);

                this.monitor.Log($"Received response from API (length: {aiResponse.Length})", LogLevel.Debug);
                return aiResponse;
            }
            catch (Exception ex)
            {
                this.monitor.Log($"Error calling API: {ex.Message}", LogLevel.Error);
                throw;
            }
        }

        /// <summary>Send a chat completion request with full conversation history.</summary>
        /// <param name="systemPrompt">The system prompt to set context.</param>
        /// <param name="chatHistory">The full conversation history.</param>
        /// <param name="userMessage">The current user message.</param>
        /// <param name="context">Optional context from RAG retrieval.</param>
        /// <returns>The AI's response text.</returns>
        public async Task<string> GetChatCompletionWithHistoryAsync(
            string systemPrompt,
            List<ChatMessage> chatHistory,
            string userMessage,
            string? context = null)
        {
            try
            {
                // Build the full user message with context if provided
                string fullUserMessage = context != null
                    ? $"Context:\n{context}\n\nQuestion: {userMessage}"
                    : userMessage;

                // Build messages array: system + history + current message
                var messagesList = new List<object>();

                // Add system message
                messagesList.Add(new { role = "system", content = systemPrompt });

                // Add chat history (excluding the current message if it's already in history)
                foreach (var msg in chatHistory)
                {
                    messagesList.Add(new { role = msg.Role, content = msg.Content });
                }

                // Add current user message
                messagesList.Add(new { role = "user", content = fullUserMessage });

                // Prepare the request payload
                var requestBody = new
                {
                    model = this.config.Model,
                    messages = messagesList.ToArray(),
                    max_tokens = this.config.MaxTokens,
                    temperature = this.config.Temperature,
                    reasoning_effort = this.config.ReasoningEffort,
                    stream = false
                };

                string jsonRequest = JsonConvert.SerializeObject(requestBody);
                this.monitor.Log($"Sending request to API with {chatHistory.Count} history messages", LogLevel.Debug);

                // Create HTTP request
                var request = new HttpRequestMessage(HttpMethod.Post, this.config.ApiEndpoint)
                {
                    Content = new StringContent(jsonRequest, Encoding.UTF8, "application/json")
                };
                request.Headers.Add("Authorization", $"Bearer {this.config.ApiKey}");

                // Send request
                HttpResponseMessage response = await this.httpClient.SendAsync(request);
                string responseContent = await response.Content.ReadAsStringAsync();

                this.monitor.Log($"API Response Status: {response.StatusCode}", LogLevel.Debug);

                // Log full response for debugging (especially for new models)
                if (responseContent.Length <= 2000)
                {
                    this.monitor.Log($"Full API Response: {responseContent}", LogLevel.Debug);
                }

                this.CheckForApiErrors(response, responseContent);

                // Parse response
                JObject responseJson = JObject.Parse(responseContent);

                // Try multiple response formats
                string? aiResponse = null;

                // Format 1: Cloudflare Workers AI format: result.response
                aiResponse = responseJson["result"]?["response"]?.ToString();

                // Format 2: OpenAI-compatible format nested in result: result.choices[0].message.content
                if (string.IsNullOrEmpty(aiResponse))
                {
                    aiResponse = responseJson["result"]?["choices"]?[0]?["message"]?["content"]?.ToString();
                }

                // Format 3: OpenAI format: choices[0].message.content
                if (string.IsNullOrEmpty(aiResponse))
                {
                    aiResponse = responseJson["choices"]?[0]?["message"]?["content"]?.ToString();
                }

                // Format 4: Direct response field
                if (string.IsNullOrEmpty(aiResponse))
                {
                    aiResponse = responseJson["response"]?.ToString();
                }

                // Format 5: Result.text or result.generated_text
                if (string.IsNullOrEmpty(aiResponse))
                {
                    aiResponse = responseJson["result"]?["text"]?.ToString();
                }

                if (string.IsNullOrEmpty(aiResponse))
                {
                    aiResponse = responseJson["result"]?["generated_text"]?.ToString();
                }

                // Format 6: Text field directly
                if (string.IsNullOrEmpty(aiResponse))
                {
                    aiResponse = responseJson["text"]?.ToString();
                }

                if (string.IsNullOrEmpty(aiResponse))
                {
                    this.monitor.Log($"Could not find response in API output", LogLevel.Error);
                    this.monitor.Log($"Response JSON keys: {string.Join(", ", responseJson.Properties().Select(p => p.Name))}", LogLevel.Error);
                    if (responseJson["result"] != null)
                    {
                        this.monitor.Log($"Result keys: {string.Join(", ", ((JObject)responseJson["result"]!).Properties().Select(p => p.Name))}", LogLevel.Error);
                    }
                    throw new Exception("Empty response from API");
                }

                this.monitor.Log($"Received response from API (length: {aiResponse.Length})", LogLevel.Debug);
                return aiResponse;
            }
            catch (Exception ex)
            {
                this.monitor.Log($"Error calling API: {ex.Message}", LogLevel.Error);
                throw;
            }
        }
    }
}
