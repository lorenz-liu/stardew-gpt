using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.IO;
using System.Linq;
using StardewModdingAPI;

namespace StardewGPT.Services
{
    /// <summary>Represents a search result from the vector database.</summary>
    public class VectorSearchResult
    {
        public string Title { get; set; } = "";
        public string Content { get; set; } = "";
        public double Similarity { get; set; }
    }

    /// <summary>Service for searching the vector database using cosine similarity.</summary>
    public class VectorDatabaseService
    {
        private readonly IMonitor monitor;
        private readonly string databasePath;
        private SQLiteConnection? connection;

        public VectorDatabaseService(IMonitor monitor, string modDirectory)
        {
            this.monitor = monitor;
            this.databasePath = Path.Combine(modDirectory, "knowledge.db");
        }

        /// <summary>Initialize the database connection.</summary>
        public void Initialize()
        {
            try
            {
                if (!File.Exists(this.databasePath))
                {
                    throw new FileNotFoundException($"Vector database not found at: {this.databasePath}");
                }

                string connectionString = $"Data Source={this.databasePath};Version=3;Read Only=True;";
                this.connection = new SQLiteConnection(connectionString);
                this.connection.Open();

                // Verify database structure
                using (var cmd = new SQLiteCommand("SELECT COUNT(*) FROM wiki_data", this.connection))
                {
                    long count = (long)cmd.ExecuteScalar();
                    this.monitor.Log($"Vector database initialized with {count} records", LogLevel.Info);
                }
            }
            catch (Exception ex)
            {
                this.monitor.Log($"Error initializing vector database: {ex.Message}", LogLevel.Error);
                throw;
            }
        }

        /// <summary>Search for similar vectors using cosine similarity.</summary>
        /// <param name="queryVector">The 256-dimensional query vector.</param>
        /// <param name="topK">Number of top results to return.</param>
        /// <returns>List of search results ordered by similarity.</returns>
        public List<VectorSearchResult> Search(float[] queryVector, int topK = 3)
        {
            if (this.connection == null)
            {
                throw new InvalidOperationException("Database not initialized. Call Initialize() first.");
            }

            if (queryVector.Length != 256)
            {
                throw new ArgumentException($"Query vector must be 256-dimensional, got {queryVector.Length}", nameof(queryVector));
            }

            try
            {
                this.monitor.Log($"Searching vector database for top {topK} results", LogLevel.Debug);

                var results = new List<VectorSearchResult>();

                // Query all records (we'll compute similarity in-memory)
                // For large databases, consider using a vector index like FAISS or implementing approximate search
                string query = "SELECT id, title, content, vector FROM wiki_data";

                using (var cmd = new SQLiteCommand(query, this.connection))
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        string title = reader.GetString(1);
                        string content = reader.GetString(2);
                        byte[] vectorBytes = (byte[])reader["vector"];

                        // Convert byte array to float array (256 floats = 1024 bytes)
                        float[] dbVector = ByteArrayToFloatArray(vectorBytes);

                        // Calculate cosine similarity
                        double similarity = CosineSimilarity(queryVector, dbVector);

                        results.Add(new VectorSearchResult
                        {
                            Title = title,
                            Content = content,
                            Similarity = similarity
                        });
                    }
                }

                // Sort by similarity (descending) and take top K
                var topResults = results
                    .OrderByDescending(r => r.Similarity)
                    .Take(topK)
                    .ToList();

                this.monitor.Log($"Found {topResults.Count} results, top similarity: {topResults.FirstOrDefault()?.Similarity:F4}", LogLevel.Debug);

                return topResults;
            }
            catch (Exception ex)
            {
                this.monitor.Log($"Error searching vector database: {ex.Message}", LogLevel.Error);
                throw;
            }
        }

        /// <summary>Convert byte array to float array.</summary>
        private static float[] ByteArrayToFloatArray(byte[] bytes)
        {
            if (bytes.Length != 1024) // 256 floats * 4 bytes per float
            {
                throw new ArgumentException($"Expected 1024 bytes, got {bytes.Length}");
            }

            float[] floats = new float[256];
            Buffer.BlockCopy(bytes, 0, floats, 0, 1024);
            return floats;
        }

        /// <summary>Calculate cosine similarity between two vectors.</summary>
        private static double CosineSimilarity(float[] vectorA, float[] vectorB)
        {
            if (vectorA.Length != vectorB.Length)
            {
                throw new ArgumentException("Vectors must have the same length");
            }

            double dotProduct = 0.0;
            double magnitudeA = 0.0;
            double magnitudeB = 0.0;

            for (int i = 0; i < vectorA.Length; i++)
            {
                dotProduct += vectorA[i] * vectorB[i];
                magnitudeA += vectorA[i] * vectorA[i];
                magnitudeB += vectorB[i] * vectorB[i];
            }

            magnitudeA = Math.Sqrt(magnitudeA);
            magnitudeB = Math.Sqrt(magnitudeB);

            if (magnitudeA == 0.0 || magnitudeB == 0.0)
            {
                return 0.0;
            }

            return dotProduct / (magnitudeA * magnitudeB);
        }

        /// <summary>Close the database connection.</summary>
        public void Dispose()
        {
            if (this.connection != null)
            {
                this.connection.Close();
                this.connection.Dispose();
                this.connection = null;
                this.monitor.Log("Vector database connection closed", LogLevel.Debug);
            }
        }
    }
}
