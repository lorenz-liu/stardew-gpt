using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using StardewModdingAPI;

namespace StardewGPT.Services
{
    /// <summary>Loads and manages Stardew Valley Wiki data.</summary>
    public class WikiDataLoader
    {
        private readonly IMonitor monitor;
        private readonly string wikiDataPath;
        private readonly HttpClient httpClient;
        private readonly Dictionary<string, WikiSearchResult> searchCache;

        private const string WIKI_API_URL = "https://stardewvalleywiki.com/mediawiki/api.php";
        private const string WIKI_SEARCH_URL = "https://stardewvalleywiki.com/mediawiki/index.php";

        public WikiDataLoader(IMonitor monitor, string modDirectory)
        {
            this.monitor = monitor;
            this.wikiDataPath = Path.Combine(modDirectory, "WikiData");
            this.searchCache = new Dictionary<string, WikiSearchResult>();
            this.httpClient = new HttpClient
            {
                Timeout = TimeSpan.FromSeconds(10)
            };
            this.httpClient.DefaultRequestHeaders.Add("User-Agent", "StardewGPT-Mod/1.0");

            // Create wiki data directory if it doesn't exist
            if (!Directory.Exists(this.wikiDataPath))
            {
                Directory.CreateDirectory(this.wikiDataPath);
            }
        }

        /// <summary>Initialize and load wiki data.</summary>
        public async Task InitializeAsync()
        {
            try
            {
                this.monitor.Log("Wiki loader initialized (using live search)", LogLevel.Info);

                // Load search cache if exists
                await this.LoadSearchCacheAsync();
            }
            catch (Exception ex)
            {
                this.monitor.Log($"Error initializing wiki loader: {ex.Message}", LogLevel.Error);
            }
        }

        /// <summary>Search Stardew Valley Wiki for information.</summary>
        /// <param name="query">The search query.</param>
        /// <param name="maxResults">Maximum number of results to return.</param>
        /// <returns>List of wiki search results.</returns>
        public async Task<List<WikiSearchResult>> SearchAsync(string query, int maxResults = 3)
        {
            if (string.IsNullOrWhiteSpace(query))
                return new List<WikiSearchResult>();

            try
            {
                // Check cache first
                string cacheKey = query.ToLower().Trim();
                if (this.searchCache.ContainsKey(cacheKey))
                {
                    this.monitor.Log($"Using cached result for: {query}", LogLevel.Debug);
                    return new List<WikiSearchResult> { this.searchCache[cacheKey] };
                }

                this.monitor.Log($"Searching wiki for: {query}", LogLevel.Debug);

                // Use MediaWiki API to search
                var searchResults = await this.SearchWikiAPIAsync(query, maxResults);

                // Cache the first result
                if (searchResults.Count > 0)
                {
                    this.searchCache[cacheKey] = searchResults[0];
                    await this.SaveSearchCacheAsync();
                }

                return searchResults;
            }
            catch (Exception ex)
            {
                this.monitor.Log($"Error searching wiki: {ex.Message}", LogLevel.Error);
                return new List<WikiSearchResult>();
            }
        }

        /// <summary>Search using MediaWiki API.</summary>
        private async Task<List<WikiSearchResult>> SearchWikiAPIAsync(string query, int maxResults)
        {
            var results = new List<WikiSearchResult>();

            try
            {
                // First, search for page titles
                string searchUrl = $"{WIKI_API_URL}?action=opensearch&search={Uri.EscapeDataString(query)}&limit={maxResults}&format=json";

                string searchResponse = await this.httpClient.GetStringAsync(searchUrl);
                JArray searchData = JArray.Parse(searchResponse);

                if (searchData.Count < 2)
                    return results;

                JArray titles = (JArray)searchData[1];
                JArray descriptions = searchData.Count > 2 ? (JArray)searchData[2] : new JArray();
                JArray urls = searchData.Count > 3 ? (JArray)searchData[3] : new JArray();

                // Get content for each page
                for (int i = 0; i < Math.Min(titles.Count, maxResults); i++)
                {
                    string title = titles[i].ToString();
                    string description = i < descriptions.Count ? descriptions[i].ToString() : "";
                    string url = i < urls.Count ? urls[i].ToString() : "";

                    // Get page extract (summary)
                    string extractUrl = $"{WIKI_API_URL}?action=query&prop=extracts&exintro=1&explaintext=1&titles={Uri.EscapeDataString(title)}&format=json";
                    string extractResponse = await this.httpClient.GetStringAsync(extractUrl);
                    JObject extractData = JObject.Parse(extractResponse);

                    string content = "";
                    var pages = extractData["query"]?["pages"];
                    if (pages != null)
                    {
                        var firstPage = pages.First?.First;
                        content = firstPage?["extract"]?.ToString() ?? description;
                    }

                    // Clean up content
                    content = this.CleanWikiText(content);

                    // Limit content length
                    if (content.Length > 500)
                    {
                        content = content.Substring(0, 500) + "...";
                    }

                    results.Add(new WikiSearchResult
                    {
                        Title = title,
                        Content = content,
                        Url = url,
                        Relevance = 1.0 - (i * 0.2) // Higher relevance for earlier results
                    });
                }
            }
            catch (Exception ex)
            {
                this.monitor.Log($"Error in wiki API search: {ex.Message}", LogLevel.Warn);
            }

            return results;
        }

        /// <summary>Clean wiki text by removing markup and formatting.</summary>
        private string CleanWikiText(string text)
        {
            if (string.IsNullOrEmpty(text))
                return "";

            // Remove wiki markup
            text = Regex.Replace(text, @"\[\[([^\]|]+\|)?([^\]]+)\]\]", "$2"); // [[link|text]] -> text
            text = Regex.Replace(text, @"\{\{[^}]+\}\}", ""); // Remove templates
            text = Regex.Replace(text, @"<[^>]+>", ""); // Remove HTML tags
            text = Regex.Replace(text, @"'''([^']+)'''", "$1"); // Bold
            text = Regex.Replace(text, @"''([^']+)''", "$1"); // Italic
            text = Regex.Replace(text, @"\n\n+", "\n"); // Multiple newlines
            text = text.Trim();

            return text;
        }

        /// <summary>Load search cache from disk.</summary>
        private async Task LoadSearchCacheAsync()
        {
            try
            {
                string cacheFile = Path.Combine(this.wikiDataPath, "search_cache.json");
                if (File.Exists(cacheFile))
                {
                    string json = await File.ReadAllTextAsync(cacheFile);
                    var cache = JsonConvert.DeserializeObject<Dictionary<string, WikiSearchResult>>(json);
                    if (cache != null)
                    {
                        foreach (var kvp in cache)
                        {
                            this.searchCache[kvp.Key] = kvp.Value;
                        }
                        this.monitor.Log($"Loaded {cache.Count} cached wiki searches", LogLevel.Debug);
                    }
                }
            }
            catch (Exception ex)
            {
                this.monitor.Log($"Error loading search cache: {ex.Message}", LogLevel.Warn);
            }
        }

        /// <summary>Save search cache to disk.</summary>
        private async Task SaveSearchCacheAsync()
        {
            try
            {
                // Only keep the most recent 100 searches
                if (this.searchCache.Count > 100)
                {
                    var toRemove = this.searchCache.Keys.Take(this.searchCache.Count - 100).ToList();
                    foreach (var key in toRemove)
                    {
                        this.searchCache.Remove(key);
                    }
                }

                string cacheFile = Path.Combine(this.wikiDataPath, "search_cache.json");
                string json = JsonConvert.SerializeObject(this.searchCache, Formatting.Indented);
                await File.WriteAllTextAsync(cacheFile, json);
            }
            catch (Exception ex)
            {
                this.monitor.Log($"Error saving search cache: {ex.Message}", LogLevel.Warn);
            }
        }

        /// <summary>Search wiki data (compatibility method).</summary>
        public List<WikiSearchResult> Search(string query, int maxResults = 5)
        {
            // Synchronous wrapper for async search
            return this.SearchAsync(query, maxResults).GetAwaiter().GetResult();
        }

        /// <summary>Get formatted context from wiki search results.</summary>
        public string GetFormattedContext(List<WikiSearchResult> results)
        {
            if (!results.Any())
                return "";

            var sb = new StringBuilder();
            sb.AppendLine("=== STARDEW VALLEY WIKI INFORMATION ===");

            foreach (var result in results)
            {
                sb.AppendLine($"\n{result.Title}:");
                sb.AppendLine(result.Content);
                if (!string.IsNullOrEmpty(result.Url))
                {
                    sb.AppendLine($"Source: {result.Url}");
                }
            }

            return sb.ToString();
        }
    }

    /// <summary>Represents a wiki search result.</summary>
    public class WikiSearchResult
    {
        public string Title { get; set; } = "";
        public string Content { get; set; } = "";
        public string Url { get; set; } = "";
        public double Relevance { get; set; } = 1.0;
    }

    /// <summary>Legacy wiki entry class for compatibility.</summary>
    [Obsolete("Use WikiSearchResult instead")]
    public class WikiEntry
    {
        public string Title { get; set; } = "";
        public string Category { get; set; } = "";
        public string Content { get; set; } = "";
    }
}
