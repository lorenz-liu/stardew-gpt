using System;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using StardewModdingAPI;

namespace StardewGPT.Services
{
    /// <summary>Client for Jina AI Embedding API.</summary>
    public class EmbeddingClient
    {
        private readonly HttpClient httpClient;
        private readonly ModConfig config;
        private readonly IMonitor monitor;

        private const string JINA_API_URL = "https://api.jina.ai/v1/embeddings";

        public EmbeddingClient(ModConfig config, IMonitor monitor)
        {
            this.config = config;
            this.monitor = monitor;
            this.httpClient = new HttpClient
            {
                Timeout = TimeSpan.FromSeconds(30)
            };
        }

        /// <summary>Get embedding vector from Jina API.</summary>
        /// <param name="text">The text to embed.</param>
        /// <param name="taskType">Task type: "retrieval.query" or "retrieval.passage".</param>
        /// <returns>1024-dimensional embedding vector.</returns>
        public async Task<float[]> GetEmbeddingAsync(string text, string taskType = "retrieval.query")
        {
            try
            {
                if (string.IsNullOrWhiteSpace(text))
                {
                    throw new ArgumentException("Text cannot be empty", nameof(text));
                }

                // Prepare request payload
                var requestBody = new
                {
                    model = "jina-embeddings-v3",
                    task = taskType,
                    dimensions = 1024,
                    late_chunking = false,
                    embedding_type = "float",
                    input = new[] { text }
                };

                string jsonRequest = JsonConvert.SerializeObject(requestBody);
                this.monitor.Log($"Requesting Jina embedding for text (length: {text.Length})", LogLevel.Debug);

                // Create HTTP request
                var request = new HttpRequestMessage(HttpMethod.Post, JINA_API_URL)
                {
                    Content = new StringContent(jsonRequest, Encoding.UTF8, "application/json")
                };
                request.Headers.Add("Authorization", $"Bearer {this.config.JinaApiKey}");

                // Send request
                HttpResponseMessage response = await this.httpClient.SendAsync(request);
                string responseContent = await response.Content.ReadAsStringAsync();

                if (!response.IsSuccessStatusCode)
                {
                    this.monitor.Log($"Jina API error: {response.StatusCode} - {responseContent}", LogLevel.Error);
                    throw new Exception($"Jina API request failed: {response.StatusCode}");
                }

                // Parse response
                JObject responseJson = JObject.Parse(responseContent);
                JArray? embeddingArray = responseJson["data"]?[0]?["embedding"] as JArray;

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

                this.monitor.Log("Successfully received Jina embedding", LogLevel.Debug);
                return embedding;
            }
            catch (Exception ex)
            {
                this.monitor.Log($"Error calling Jina API: {ex.Message}", LogLevel.Error);
                throw;
            }
        }

        /// <summary>Reduce 1024-dimensional vector to 256 dimensions.</summary>
        /// <param name="fullVector">The full 1024-dimensional vector.</param>
        /// <returns>Reduced 256-dimensional vector.</returns>
        public float[] ReduceDimensions(float[] fullVector)
        {
            if (fullVector.Length != 1024)
            {
                throw new ArgumentException($"Expected 1024 dimensions, got {fullVector.Length}", nameof(fullVector));
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
            float[] fullVector = await this.GetEmbeddingAsync(query, "retrieval.query");
            return this.ReduceDimensions(fullVector);
        }
    }
}
