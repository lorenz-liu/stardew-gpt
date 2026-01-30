using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Newtonsoft.Json;
using StardewModdingAPI;

namespace StardewGPT.Services
{
    /// <summary>Loads and searches local knowledge base using TF-IDF.</summary>
    public class LocalKnowledgeLoader
    {
        private readonly IMonitor monitor;
        private readonly string knowledgeBasePath;
        private readonly string indexCachePath;
        private readonly Dictionary<string, List<WikiSearchResult>> searchCache;

        private Dictionary<string, IndexedDocument> documentIndex;
        private Dictionary<string, int> documentFrequency;
        private int totalDocuments;
        private bool isInitialized;

        // Common English stop words to filter out
        private static readonly HashSet<string> StopWords = new HashSet<string>
        {
            "the", "a", "an", "and", "or", "but", "in", "on", "at", "to", "for",
            "of", "with", "by", "from", "as", "is", "was", "are", "were", "be",
            "been", "being", "have", "has", "had", "do", "does", "did", "will",
            "would", "should", "could", "may", "might", "can", "this", "that",
            "these", "those", "it", "its", "you", "your", "i", "we", "they", "them"
        };

        public LocalKnowledgeLoader(IMonitor monitor, string modDirectory)
        {
            this.monitor = monitor;
            this.knowledgeBasePath = Path.Combine(modDirectory, "KnowledgeBase");
            this.indexCachePath = Path.Combine(modDirectory, "IndexCache");
            this.searchCache = new Dictionary<string, List<WikiSearchResult>>();
            this.documentIndex = new Dictionary<string, IndexedDocument>();
            this.documentFrequency = new Dictionary<string, int>();
            this.totalDocuments = 0;
            this.isInitialized = false;

            // Create cache directory if it doesn't exist
            if (!Directory.Exists(this.indexCachePath))
            {
                Directory.CreateDirectory(this.indexCachePath);
            }
        }

        /// <summary>Initialize and build the knowledge base index.</summary>
        public async Task InitializeAsync()
        {
            if (this.isInitialized)
                return;

            try
            {
                this.monitor.Log("Initializing local knowledge base...", LogLevel.Info);

                // Check if knowledge base directory exists
                if (!Directory.Exists(this.knowledgeBasePath))
                {
                    this.monitor.Log($"Knowledge base directory not found: {this.knowledgeBasePath}", LogLevel.Error);
                    return;
                }

                // Try to load cached index first
                bool cacheLoaded = await this.LoadIndexCacheAsync();

                if (!cacheLoaded)
                {
                    // Build index from scratch
                    await Task.Run(() => this.BuildIndex());

                    // Save index to cache
                    await this.SaveIndexCacheAsync();
                }

                this.isInitialized = true;
                this.monitor.Log($"Knowledge base initialized with {this.totalDocuments} documents", LogLevel.Info);
            }
            catch (Exception ex)
            {
                this.monitor.Log($"Error initializing knowledge base: {ex.Message}", LogLevel.Error);
            }
        }

        /// <summary>Build the document index from markdown files.</summary>
        private void BuildIndex()
        {
            this.monitor.Log("Building knowledge base index...", LogLevel.Info);

            var files = Directory.GetFiles(this.knowledgeBasePath, "*.md");
            this.totalDocuments = files.Length;

            // First pass: Index all documents and calculate term frequencies
            var documents = new List<IndexedDocument>();

            foreach (var filePath in files)
            {
                try
                {
                    var doc = this.IndexDocument(filePath);
                    if (doc != null)
                    {
                        documents.Add(doc);
                        this.documentIndex[doc.FileName] = doc;
                    }
                }
                catch (Exception ex)
                {
                    this.monitor.Log($"Error indexing {Path.GetFileName(filePath)}: {ex.Message}", LogLevel.Warn);
                }
            }

            // Second pass: Calculate document frequencies (IDF)
            foreach (var doc in documents)
            {
                var uniqueTerms = new HashSet<string>(doc.TermFrequencies.Keys);
                foreach (var term in uniqueTerms)
                {
                    if (!this.documentFrequency.ContainsKey(term))
                    {
                        this.documentFrequency[term] = 0;
                    }
                    this.documentFrequency[term]++;
                }
            }

            this.monitor.Log($"Indexed {documents.Count} documents with {this.documentFrequency.Count} unique terms", LogLevel.Debug);
        }

        /// <summary>Index a single document.</summary>
        private IndexedDocument? IndexDocument(string filePath)
        {
            string content = File.ReadAllText(filePath);

            if (string.IsNullOrWhiteSpace(content))
                return null;

            var doc = new IndexedDocument
            {
                FilePath = filePath,
                FileName = Path.GetFileNameWithoutExtension(filePath),
                Content = content
            };

            // Extract title (first # heading)
            var titleMatch = Regex.Match(content, @"^#\s+(.+)$", RegexOptions.Multiline);
            doc.Title = titleMatch.Success ? titleMatch.Groups[1].Value.Trim() : doc.FileName;

            // Check if this is a redirect file
            var lines = content.Split('\n').Take(5).ToList();
            if (lines.Any(l => l.Contains("Redirect to:", StringComparison.OrdinalIgnoreCase)))
            {
                doc.IsRedirect = true;
                var redirectMatch = Regex.Match(content, @"\[([^\]]+)\]\(([^\)]+)\)");
                if (redirectMatch.Success)
                {
                    doc.RedirectTarget = redirectMatch.Groups[1].Value;
                }
                return doc;
            }

            // Tokenize and calculate term frequencies
            var tokens = this.Tokenize(content);
            doc.WordCount = tokens.Count;

            var termCounts = new Dictionary<string, int>();
            foreach (var token in tokens)
            {
                if (!termCounts.ContainsKey(token))
                {
                    termCounts[token] = 0;
                }
                termCounts[token]++;
            }

            // Calculate term frequency (TF)
            doc.TermFrequencies = new Dictionary<string, double>();
            foreach (var kvp in termCounts)
            {
                doc.TermFrequencies[kvp.Key] = (double)kvp.Value / doc.WordCount;
            }

            return doc;
        }

        /// <summary>Tokenize text into searchable terms.</summary>
        private List<string> Tokenize(string text)
        {
            if (string.IsNullOrWhiteSpace(text))
                return new List<string>();

            // Convert to lowercase
            text = text.ToLower();

            // Remove markdown syntax
            text = this.RemoveMarkdownSyntax(text);

            // Split on non-alphanumeric characters
            var tokens = Regex.Split(text, @"[^a-z0-9]+")
                .Where(t => t.Length > 2) // Filter short tokens
                .Where(t => !StopWords.Contains(t)) // Remove stop words
                .ToList();

            return tokens;
        }

        /// <summary>Remove markdown syntax from text.</summary>
        private string RemoveMarkdownSyntax(string text)
        {
            // Remove links: [text](/url "title") -> text
            text = Regex.Replace(text, @"\[([^\]]+)\]\([^\)]+\)", "$1");

            // Remove images: ![alt](/url) -> ""
            text = Regex.Replace(text, @"!\[[^\]]*\]\([^\)]+\)", "");

            // Remove bold/italic: **text** or *text* -> text
            text = Regex.Replace(text, @"\*+([^\*]+)\*+", "$1");

            // Remove headers: # text -> text
            text = Regex.Replace(text, @"^#+\s*", "", RegexOptions.Multiline);

            // Remove HTML tags
            text = Regex.Replace(text, @"<[^>]+>", "");

            // Remove tables (simple approach - remove lines with |)
            text = Regex.Replace(text, @"^[^\n]*\|[^\n]*$", "", RegexOptions.Multiline);

            // Remove code blocks
            text = Regex.Replace(text, @"```[^`]*```", "", RegexOptions.Singleline);
            text = Regex.Replace(text, @"`[^`]+`", "");

            return text;
        }

        /// <summary>Search the knowledge base for relevant documents.</summary>
        public async Task<List<WikiSearchResult>> SearchAsync(string query, int maxResults = 3)
        {
            if (!this.isInitialized)
            {
                await this.InitializeAsync();
            }

            if (string.IsNullOrWhiteSpace(query))
                return new List<WikiSearchResult>();

            try
            {
                // Check cache first
                string cacheKey = query.ToLower().Trim();
                if (this.searchCache.ContainsKey(cacheKey))
                {
                    this.monitor.Log($"Using cached result for: {query}", LogLevel.Debug);
                    return this.searchCache[cacheKey];
                }

                this.monitor.Log($"Searching knowledge base for: {query}", LogLevel.Debug);

                // Tokenize query
                var queryTerms = this.Tokenize(query).ToArray();

                if (queryTerms.Length == 0)
                    return new List<WikiSearchResult>();

                // Calculate TF-IDF scores for all documents
                var scoredDocs = new List<(IndexedDocument doc, double score)>();

                foreach (var doc in this.documentIndex.Values)
                {
                    // Skip redirect files
                    if (doc.IsRedirect)
                        continue;

                    double score = this.CalculateTFIDF(queryTerms, doc);

                    // Apply boosts
                    score = this.ApplyScoreBoosts(query, doc, score);

                    if (score > 0)
                    {
                        scoredDocs.Add((doc, score));
                    }
                }

                // Sort by score and take top results
                var topDocs = scoredDocs
                    .OrderByDescending(x => x.score)
                    .Take(maxResults)
                    .ToList();

                // Convert to WikiSearchResult
                var results = new List<WikiSearchResult>();
                for (int i = 0; i < topDocs.Count; i++)
                {
                    var (doc, score) = topDocs[i];

                    var result = new WikiSearchResult
                    {
                        Title = doc.Title,
                        Content = this.ExtractRelevantSnippet(doc.Content, queryTerms),
                        Url = $"file://{doc.FilePath}",
                        Relevance = score
                    };

                    results.Add(result);
                }

                // Cache results
                if (results.Count > 0)
                {
                    this.searchCache[cacheKey] = results;

                    // Limit cache size
                    if (this.searchCache.Count > 100)
                    {
                        var toRemove = this.searchCache.Keys.Take(this.searchCache.Count - 100).ToList();
                        foreach (var key in toRemove)
                        {
                            this.searchCache.Remove(key);
                        }
                    }
                }

                return results;
            }
            catch (Exception ex)
            {
                this.monitor.Log($"Error searching knowledge base: {ex.Message}", LogLevel.Error);
                return new List<WikiSearchResult>();
            }
        }

        /// <summary>Calculate TF-IDF score for a document given query terms.</summary>
        private double CalculateTFIDF(string[] queryTerms, IndexedDocument doc)
        {
            double score = 0.0;

            foreach (var term in queryTerms)
            {
                if (!doc.TermFrequencies.ContainsKey(term))
                    continue;

                // Term Frequency (TF)
                double tf = doc.TermFrequencies[term];

                // Inverse Document Frequency (IDF)
                double idf = 0.0;
                if (this.documentFrequency.ContainsKey(term))
                {
                    idf = Math.Log((double)this.totalDocuments / this.documentFrequency[term]);
                }

                // TF-IDF score
                score += tf * idf;
            }

            return score;
        }

        /// <summary>Apply score boosts based on matches in title, filename, etc.</summary>
        private double ApplyScoreBoosts(string query, IndexedDocument doc, double baseScore)
        {
            double score = baseScore;
            string queryLower = query.ToLower();

            // Exact filename match: +50%
            if (doc.FileName.ToLower() == queryLower)
            {
                score *= 1.5;
            }
            // Partial filename match: +30%
            else if (doc.FileName.ToLower().Contains(queryLower))
            {
                score *= 1.3;
            }

            // Title match: +30%
            if (doc.Title.ToLower().Contains(queryLower))
            {
                score *= 1.3;
            }

            // First paragraph match: +20%
            var firstParagraph = doc.Content.Split(new[] { "\n\n" }, StringSplitOptions.RemoveEmptyEntries).FirstOrDefault() ?? "";
            if (firstParagraph.ToLower().Contains(queryLower))
            {
                score *= 1.2;
            }

            return score;
        }

        /// <summary>Extract relevant snippet from document content.</summary>
        private string ExtractRelevantSnippet(string content, string[] queryTerms)
        {
            const int maxLength = 2000; // Increased from 500 to allow more context
            const int shortDocumentThreshold = 1500; // Return full content for short documents

            // Return full content for short documents
            if (content.Length <= shortDocumentThreshold)
            {
                return this.CleanMarkdown(content).Trim();
            }

            // Split into paragraphs
            var paragraphs = content.Split(new[] { "\n\n" }, StringSplitOptions.RemoveEmptyEntries);

            if (paragraphs.Length == 0)
                return "";

            // Score all paragraphs based on relevance
            var scoredParagraphs = paragraphs
                .Select(p => new
                {
                    Text = p,
                    Score = this.ScoreParagraphRelevance(p, queryTerms)
                })
                .OrderByDescending(p => p.Score)
                .ToList();

            // Take top 3-5 paragraphs (multi-paragraph extraction)
            var topParagraphs = scoredParagraphs
                .Take(5)
                .Where(p => p.Score > 0)
                .ToList();

            // Build snippet from top paragraphs
            var snippetBuilder = new System.Text.StringBuilder();

            foreach (var para in topParagraphs)
            {
                string cleanedPara = this.CleanMarkdown(para.Text).Trim();

                if (!string.IsNullOrWhiteSpace(cleanedPara))
                {
                    snippetBuilder.AppendLine(cleanedPara);
                    snippetBuilder.AppendLine(); // Add spacing between paragraphs
                }

                // Stop if we've reached a good length
                if (snippetBuilder.Length >= maxLength)
                    break;
            }

            string snippet = snippetBuilder.ToString().Trim();

            // Truncate if still too long
            if (snippet.Length > maxLength)
            {
                snippet = snippet.Substring(0, maxLength);

                // Try to end at a sentence
                int lastPeriod = snippet.LastIndexOf('.');
                if (lastPeriod > maxLength / 2)
                {
                    snippet = snippet.Substring(0, lastPeriod + 1);
                }
                else
                {
                    snippet += "...";
                }
            }

            return snippet;
        }

        /// <summary>Score a paragraph's relevance based on query terms and structure.</summary>
        private double ScoreParagraphRelevance(string paragraph, string[] queryTerms)
        {
            double score = 0.0;
            string lowerPara = paragraph.ToLower();

            // Base score: count of query term matches
            foreach (var term in queryTerms)
            {
                int matches = Regex.Matches(lowerPara, Regex.Escape(term)).Count;
                score += matches;
            }

            // Prioritize structured data (tables) - give massive boost
            if (paragraph.Contains("|") && paragraph.Split('\n').Count(line => line.Contains("|")) >= 3)
            {
                score *= 3.0; // Triple score for tables
            }

            // Boost for paragraphs with location/spawn keywords
            if (lowerPara.Contains("floor") || lowerPara.Contains("spawn") ||
                lowerPara.Contains("found") || lowerPara.Contains("location") ||
                lowerPara.Contains("mine") || lowerPara.Contains("level"))
            {
                score *= 1.5;
            }

            // Boost for paragraphs with specific numbers (often indicate floors/levels)
            if (Regex.IsMatch(paragraph, @"\b\d+-\d+\b")) // Patterns like "41-79"
            {
                score *= 1.3;
            }

            return score;
        }

        /// <summary>Clean markdown formatting from text.</summary>
        private string CleanMarkdown(string text)
        {
            if (string.IsNullOrEmpty(text))
                return "";

            // Remove wiki markup
            text = Regex.Replace(text, @"\[\[([^\]|]+\|)?([^\]]+)\]\]", "$2"); // [[link|text]] -> text
            text = Regex.Replace(text, @"\[([^\]]+)\]\([^\)]+\)", "$1"); // [text](url) -> text
            text = Regex.Replace(text, @"\{\{[^}]+\}\}", ""); // Remove templates
            text = Regex.Replace(text, @"<[^>]+>", ""); // Remove HTML tags
            text = Regex.Replace(text, @"\*\*([^\*]+)\*\*", "$1"); // Bold
            text = Regex.Replace(text, @"\*([^\*]+)\*", "$1"); // Italic
            text = Regex.Replace(text, @"^#+\s*", "", RegexOptions.Multiline); // Headers
            text = Regex.Replace(text, @"\n\n+", "\n"); // Multiple newlines
            text = Regex.Replace(text, @"!\[[^\]]*\]\([^\)]+\)", ""); // Images
            text = text.Trim();

            return text;
        }

        /// <summary>Synchronous search wrapper.</summary>
        public List<WikiSearchResult> Search(string query, int maxResults = 5)
        {
            return this.SearchAsync(query, maxResults).GetAwaiter().GetResult();
        }

        /// <summary>Get formatted context from search results.</summary>
        public string GetFormattedContext(List<WikiSearchResult> results)
        {
            if (!results.Any())
                return "";

            var sb = new StringBuilder();
            sb.AppendLine("=== STARDEW VALLEY KNOWLEDGE BASE ===");

            foreach (var result in results)
            {
                sb.AppendLine($"\n{result.Title}:");
                sb.AppendLine(result.Content);
            }

            return sb.ToString();
        }

        /// <summary>Load index cache from disk.</summary>
        private async Task<bool> LoadIndexCacheAsync()
        {
            try
            {
                string cacheFile = Path.Combine(this.indexCachePath, "index_cache.json");

                if (!File.Exists(cacheFile))
                    return false;

                // Check if cache is stale (older than knowledge base files)
                var cacheTime = File.GetLastWriteTime(cacheFile);
                var kbFiles = Directory.GetFiles(this.knowledgeBasePath, "*.md");

                if (kbFiles.Any(f => File.GetLastWriteTime(f) > cacheTime))
                {
                    this.monitor.Log("Index cache is stale, rebuilding...", LogLevel.Debug);
                    return false;
                }

                string json = await File.ReadAllTextAsync(cacheFile);
                var cache = JsonConvert.DeserializeObject<IndexCache>(json);

                if (cache != null)
                {
                    this.documentIndex = cache.DocumentIndex;
                    this.documentFrequency = cache.DocumentFrequency;
                    this.totalDocuments = cache.TotalDocuments;

                    this.monitor.Log($"Loaded index cache with {this.totalDocuments} documents", LogLevel.Debug);
                    return true;
                }
            }
            catch (Exception ex)
            {
                this.monitor.Log($"Error loading index cache: {ex.Message}", LogLevel.Warn);
            }

            return false;
        }

        /// <summary>Save index cache to disk.</summary>
        private async Task SaveIndexCacheAsync()
        {
            try
            {
                var cache = new IndexCache
                {
                    DocumentIndex = this.documentIndex,
                    DocumentFrequency = this.documentFrequency,
                    TotalDocuments = this.totalDocuments
                };

                string cacheFile = Path.Combine(this.indexCachePath, "index_cache.json");
                string json = JsonConvert.SerializeObject(cache);
                await File.WriteAllTextAsync(cacheFile, json);

                this.monitor.Log("Saved index cache to disk", LogLevel.Debug);
            }
            catch (Exception ex)
            {
                this.monitor.Log($"Error saving index cache: {ex.Message}", LogLevel.Warn);
            }
        }

        /// <summary>Represents an indexed document.</summary>
        private class IndexedDocument
        {
            public string FilePath { get; set; } = "";
            public string FileName { get; set; } = "";
            public string Title { get; set; } = "";
            public string Content { get; set; } = "";
            public bool IsRedirect { get; set; }
            public string? RedirectTarget { get; set; }
            public Dictionary<string, double> TermFrequencies { get; set; } = new Dictionary<string, double>();
            public int WordCount { get; set; }
        }

        /// <summary>Cache structure for serialization.</summary>
        private class IndexCache
        {
            public Dictionary<string, IndexedDocument> DocumentIndex { get; set; } = new Dictionary<string, IndexedDocument>();
            public Dictionary<string, int> DocumentFrequency { get; set; } = new Dictionary<string, int>();
            public int TotalDocuments { get; set; }
        }
    }
}
