using System;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
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

                if (!response.IsSuccessStatusCode)
                {
                    this.monitor.Log($"API error: {response.StatusCode} - {responseContent}", LogLevel.Error);

                    // Check for invalid API key error
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

                    throw new Exception($"API request failed: {response.StatusCode}");
                }

                // Parse response
                JObject responseJson = JObject.Parse(responseContent);
                string? aiResponse = responseJson["choices"]?[0]?["message"]?["content"]?.ToString();

                if (string.IsNullOrEmpty(aiResponse))
                {
                    throw new Exception("Empty response from API");
                }

                this.monitor.Log($"Received response from API", LogLevel.Debug);
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
