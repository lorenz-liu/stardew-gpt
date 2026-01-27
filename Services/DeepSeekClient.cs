using System;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using StardewModdingAPI;

namespace StardewGPT.Services
{
    /// <summary>Client for communicating with DeepSeek API.</summary>
    public class DeepSeekClient
    {
        private readonly HttpClient httpClient;
        private readonly ModConfig config;
        private readonly IMonitor monitor;

        public DeepSeekClient(ModConfig config, IMonitor monitor)
        {
            this.config = config;
            this.monitor = monitor;
            this.httpClient = new HttpClient
            {
                Timeout = TimeSpan.FromSeconds(30)
            };
        }

        /// <summary>Send a chat completion request to DeepSeek.</summary>
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
                    stream = false
                };

                string jsonRequest = JsonConvert.SerializeObject(requestBody);
                this.monitor.Log($"Sending request to DeepSeek API", LogLevel.Debug);

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
                    this.monitor.Log($"DeepSeek API error: {response.StatusCode} - {responseContent}", LogLevel.Error);
                    throw new Exception($"API request failed: {response.StatusCode}");
                }

                // Parse response
                JObject responseJson = JObject.Parse(responseContent);
                string? aiResponse = responseJson["choices"]?[0]?["message"]?["content"]?.ToString();

                if (string.IsNullOrEmpty(aiResponse))
                {
                    throw new Exception("Empty response from API");
                }

                this.monitor.Log($"Received response from DeepSeek API", LogLevel.Debug);
                return aiResponse;
            }
            catch (Exception ex)
            {
                this.monitor.Log($"Error calling DeepSeek API: {ex.Message}", LogLevel.Error);
                throw;
            }
        }

        /// <summary>Check if a question is related to Stardew Valley.</summary>
        /// <param name="question">The user's question.</param>
        /// <returns>True if the question is Stardew Valley related, false otherwise.</returns>
        public async Task<bool> IsStardewRelatedAsync(string question)
        {
            try
            {
                string systemPrompt = @"You are a classifier that determines if a question is related to Stardew Valley (the video game).
Respond with ONLY 'YES' if the question is about Stardew Valley (farming, characters, items, gameplay, locations, etc.).
Respond with ONLY 'NO' if the question is completely unrelated to Stardew Valley.";

                var requestBody = new
                {
                    model = this.config.Model,
                    messages = new[]
                    {
                        new { role = "system", content = systemPrompt },
                        new { role = "user", content = question }
                    },
                    max_tokens = 10,
                    temperature = 0.0f,
                    stream = false
                };

                string jsonRequest = JsonConvert.SerializeObject(requestBody);

                var request = new HttpRequestMessage(HttpMethod.Post, this.config.ApiEndpoint)
                {
                    Content = new StringContent(jsonRequest, Encoding.UTF8, "application/json")
                };
                request.Headers.Add("Authorization", $"Bearer {this.config.ApiKey}");

                HttpResponseMessage response = await this.httpClient.SendAsync(request);
                string responseContent = await response.Content.ReadAsStringAsync();

                if (!response.IsSuccessStatusCode)
                {
                    this.monitor.Log($"Classification API error: {response.StatusCode}", LogLevel.Warn);
                    return true; // Default to allowing the question if classification fails
                }

                JObject responseJson = JObject.Parse(responseContent);
                string? classification = responseJson["choices"]?[0]?["message"]?["content"]?.ToString()?.Trim().ToUpper();

                return classification?.Contains("YES") ?? true;
            }
            catch (Exception ex)
            {
                this.monitor.Log($"Error classifying question: {ex.Message}", LogLevel.Warn);
                return true; // Default to allowing the question if classification fails
            }
        }
    }
}
