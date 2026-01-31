using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
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
        private IntPtr db = IntPtr.Zero;
        private static IntPtr libraryHandle = IntPtr.Zero;

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

                // Load native library if not already loaded
                if (libraryHandle == IntPtr.Zero)
                {
                    this.LoadNativeLibrary();
                }

                // Open database
                int rc = SQLiteNative.sqlite3_open_v2(
                    this.databasePath,
                    out this.db,
                    SQLiteNative.SQLITE_OPEN_READONLY,
                    IntPtr.Zero);

                if (rc != SQLiteNative.SQLITE_OK)
                {
                    string error = SQLiteNative.PtrToStringUTF8(SQLiteNative.sqlite3_errmsg(this.db));
                    throw new Exception($"Failed to open database: {rc} - {error}");
                }

                // Verify database structure
                IntPtr stmt;
                rc = SQLiteNative.sqlite3_prepare_v2(
                    this.db,
                    "SELECT COUNT(*) FROM wiki_data",
                    -1,
                    out stmt,
                    IntPtr.Zero);

                if (rc != SQLiteNative.SQLITE_OK)
                {
                    string error = SQLiteNative.PtrToStringUTF8(SQLiteNative.sqlite3_errmsg(this.db));
                    throw new Exception($"Failed to prepare statement: {rc} - {error}");
                }

                rc = SQLiteNative.sqlite3_step(stmt);
                if (rc == SQLiteNative.SQLITE_ROW)
                {
                    long count = SQLiteNative.sqlite3_column_int64(stmt, 0);
                    this.monitor.Log($"Vector database initialized with {count} records", LogLevel.Info);
                }

                SQLiteNative.sqlite3_finalize(stmt);
            }
            catch (Exception ex)
            {
                this.monitor.Log($"Error initializing vector database: {ex.Message}", LogLevel.Error);
                throw;
            }
        }

        /// <summary>Load the native SQLite library.</summary>
        private void LoadNativeLibrary()
        {
            try
            {
                string modDirectory = Path.GetDirectoryName(this.databasePath)!;
                string runtimesPath = Path.Combine(modDirectory, "runtimes");
                string libraryPath = "";

                if (RuntimeInformation.IsOSPlatform(OSPlatform.OSX))
                {
                    string arch = RuntimeInformation.ProcessArchitecture == Architecture.Arm64 ? "arm64" : "x64";
                    libraryPath = Path.Combine(runtimesPath, $"osx-{arch}", "native", "libe_sqlite3.dylib");

                    if (!File.Exists(libraryPath))
                    {
                        libraryPath = Path.Combine(runtimesPath, "osx-x64", "native", "libe_sqlite3.dylib");
                    }
                }
                else if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
                {
                    string arch = Environment.Is64BitProcess ? "x64" : "x86";
                    libraryPath = Path.Combine(runtimesPath, $"win-{arch}", "native", "e_sqlite3.dll");
                }
                else if (RuntimeInformation.IsOSPlatform(OSPlatform.Linux))
                {
                    libraryPath = Path.Combine(runtimesPath, "linux-x64", "native", "libe_sqlite3.so");
                }

                if (!File.Exists(libraryPath))
                {
                    throw new FileNotFoundException($"Native SQLite library not found at: {libraryPath}");
                }

                this.monitor.Log($"Loading native SQLite library from: {libraryPath}", LogLevel.Debug);

                // Set up DllImport resolver before loading
                NativeLibrary.SetDllImportResolver(typeof(SQLiteNative).Assembly, (libraryName, assembly, searchPath) =>
                {
                    if (libraryName == "sqlite3")
                    {
                        if (libraryHandle == IntPtr.Zero)
                        {
                            libraryHandle = NativeLibrary.Load(libraryPath);
                            this.monitor.Log($"Loaded SQLite library: {libraryPath}", LogLevel.Info);
                        }
                        return libraryHandle;
                    }
                    return IntPtr.Zero;
                });

                // Trigger the resolver by calling a SQLite function
                libraryHandle = NativeLibrary.Load(libraryPath);
                this.monitor.Log("Native SQLite library loaded successfully", LogLevel.Info);
            }
            catch (Exception ex)
            {
                this.monitor.Log($"Error loading native library: {ex.Message}", LogLevel.Error);
                throw;
            }
        }

        /// <summary>Search for similar vectors using cosine similarity.</summary>
        public List<VectorSearchResult> Search(float[] queryVector, int topK = 3)
        {
            if (this.db == IntPtr.Zero)
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

                // Prepare query
                IntPtr stmt;
                int rc = SQLiteNative.sqlite3_prepare_v2(
                    this.db,
                    "SELECT title, content, vector FROM wiki_data",
                    -1,
                    out stmt,
                    IntPtr.Zero);

                if (rc != SQLiteNative.SQLITE_OK)
                {
                    string error = SQLiteNative.PtrToStringUTF8(SQLiteNative.sqlite3_errmsg(this.db));
                    throw new Exception($"Failed to prepare query: {rc} - {error}");
                }

                // Iterate through results
                while (SQLiteNative.sqlite3_step(stmt) == SQLiteNative.SQLITE_ROW)
                {
                    string title = SQLiteNative.PtrToStringUTF8(SQLiteNative.sqlite3_column_text(stmt, 0));
                    string content = SQLiteNative.PtrToStringUTF8(SQLiteNative.sqlite3_column_text(stmt, 1));

                    // Get vector blob
                    IntPtr blobPtr = SQLiteNative.sqlite3_column_blob(stmt, 2);
                    int blobSize = SQLiteNative.sqlite3_column_bytes(stmt, 2);

                    if (blobSize != 1024) // 256 floats * 4 bytes
                    {
                        continue;
                    }

                    // Convert to float array
                    float[] dbVector = new float[256];
                    Marshal.Copy(blobPtr, dbVector, 0, 256);

                    // Calculate cosine similarity
                    double similarity = CosineSimilarity(queryVector, dbVector);

                    results.Add(new VectorSearchResult
                    {
                        Title = title,
                        Content = content,
                        Similarity = similarity
                    });
                }

                SQLiteNative.sqlite3_finalize(stmt);

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
            if (this.db != IntPtr.Zero)
            {
                SQLiteNative.sqlite3_close(this.db);
                this.db = IntPtr.Zero;
                this.monitor.Log("Vector database connection closed", LogLevel.Debug);
            }
        }
    }
}
