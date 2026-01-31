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
        /// <returns>768-dimensional embedding vector from bge-base-en-v1.5.</returns>
        public async Task<float[]> GetEmbeddingAsync(string text)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(text))
                {
                    throw new ArgumentException("Text cannot be empty", nameof(text));
                }

                // Cloudflare Workers AI endpoint
                string embeddingUrl = $"https://api.cloudflare.com/client/v4/accounts/{this.config.CloudflareAccountId}/ai/run/@cf/baai/bge-base-en-v1.5";

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
                    throw new Exception($"Cloudflare API request failed: {response.StatusCode}");
                }

                // Parse response
                JObject responseJson = JObject.Parse(responseContent);
                JArray? embeddingArray = responseJson["result"]?["data"]?[0] as JArray;

                if (embeddingArray == null || embeddingArray.Count != 768)
                {
                    throw new Exception($"Invalid embedding response: expected 768 dimensions, got {embeddingArray?.Count ?? 0}");
                }

                // Convert to float array
                float[] embedding = new float[768];
                for (int i = 0; i < 768; i++)
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

        /// <summary>Reduce 768-dimensional vector to 256 dimensions.</summary>
        /// <param name="fullVector">The full 768-dimensional vector.</param>
        /// <returns>Reduced 256-dimensional vector.</returns>
        public float[] ReduceDimensions(float[] fullVector)
        {
            if (fullVector.Length != 768)
            {
                throw new ArgumentException($"Expected 768 dimensions, got {fullVector.Length}", nameof(fullVector));
            }

            float[] reducedVector = new float[256];
            Array.Copy(fullVector, 0, reducedVector, 0, 256);
            return reducedVector;
        }

        /// <summary>Get reduced 256-dimensional embedding for query.</summary>
        /// <param name="query">The query text.</param>
        /// <returns>256-dimensional embedding vector.</returns>
        public async Task<float[]> GetQueryEmbeddingAsync(string query)
        {
            float[] fullVector = await this.GetEmbeddingAsync(query);
            return this.ReduceDimensions(fullVector);
        }
    }
}
