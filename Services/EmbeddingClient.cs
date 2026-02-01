using System;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using StardewModdingAPI;

namespace StardewGPT.Services
{
    /// <summary>Client for Cloudflare Workers AI Embedding API.</summary>
    public class EmbeddingClient
    {
        private readonly HttpClient httpClient;
        private readonly ModConfig config;
        private readonly IMonitor monitor;

        public EmbeddingClient(ModConfig config, IMonitor monitor)
        {
            this.config = config;
            this.monitor = monitor;
            this.httpClient = new HttpClient
            {
                Timeout = TimeSpan.FromSeconds(30)
            };
        }

        /// <summary>Get embedding vector from Cloudflare Workers AI.</summary>
        /// <param name="text">The text to embed.</param>
        /// <returns>1024-dimensional embedding vector from bge-m3.</returns>
        public async Task<float[]> GetEmbeddingAsync(string text)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(text))
                {
                    throw new ArgumentException("Text cannot be empty", nameof(text));
                }

                // Cloudflare Workers AI endpoint for bge-m3 (multilingual, 1024 dimensions)
                string embeddingUrl = $"https://api.cloudflare.com/client/v4/accounts/{this.config.CloudflareAccountId}/ai/run/@cf/baai/bge-m3";

                // Prepare request payload
                var requestBody = new
                {
                    text = new[] { text }
                };

                string jsonRequest = JsonConvert.SerializeObject(requestBody);
                this.monitor.Log($"Requesting Cloudflare embedding for text (length: {text.Length})", LogLevel.Debug);

                // Create HTTP request
                var request = new HttpRequestMessage(HttpMethod.Post, embeddingUrl)
                {
                    Content = new StringContent(jsonRequest, Encoding.UTF8, "application/json")
                };
                request.Headers.Add("Authorization", $"Bearer {this.config.ApiKey}");

                // Send request
                HttpResponseMessage response = await this.httpClient.SendAsync(request);
                string responseContent = await response.Content.ReadAsStringAsync();

                if (!response.IsSuccessStatusCode)
                {
                    this.monitor.Log($"Cloudflare API error: {response.StatusCode} - {responseContent}", LogLevel.Error);

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

                    throw new Exception($"Cloudflare API request failed: {response.StatusCode}");
                }

                // Parse response
                JObject responseJson = JObject.Parse(responseContent);
                JArray? embeddingArray = responseJson["result"]?["data"]?[0] as JArray;

                if (embeddingArray == null || embeddingArray.Count != 1024)
                {
                    throw new Exception($"Invalid embedding response: expected 1024 dimensions, got {embeddingArray?.Count ?? 0}");
                }

                // Convert to float array
                float[] embedding = new float[1024];
                for (int i = 0; i < 1024; i++)
                {
                    embedding[i] = embeddingArray[i].Value<float>();
                }

                this.monitor.Log("Successfully received Cloudflare embedding", LogLevel.Debug);
                return embedding;
            }
            catch (Exception ex)
            {
                this.monitor.Log($"Error calling Cloudflare API: {ex.Message}", LogLevel.Error);
                throw;
            }
        }

        /// <summary>Get 1024-dimensional embedding for query.</summary>
        /// <param name="query">The query text.</param>
        /// <returns>1024-dimensional embedding vector.</returns>
        public async Task<float[]> GetQueryEmbeddingAsync(string query)
        {
            return await this.GetEmbeddingAsync(query);
        }
    }
}
