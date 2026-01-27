using System;
using System.Text;
using System.Threading.Tasks;
using StardewModdingAPI;

namespace StardewGPT.Services
{
    /// <summary>Orchestrates the RAG (Retrieval-Augmented Generation) system.</summary>
    public class RAGOrchestrator
    {
        private readonly AIClient aiClient;
        private readonly GameDataExtractor gameDataExtractor;
        private readonly WikiDataLoader wikiDataLoader;
        private readonly IMonitor monitor;
        private readonly ITranslationHelper i18n;

        public RAGOrchestrator(
            AIClient aiClient,
            GameDataExtractor gameDataExtractor,
            WikiDataLoader wikiDataLoader,
            IMonitor monitor,
            ITranslationHelper i18n)
        {
            this.aiClient = aiClient;
            this.gameDataExtractor = gameDataExtractor;
            this.wikiDataLoader = wikiDataLoader;
            this.monitor = monitor;
            this.i18n = i18n;
        }

        /// <summary>Process a user question and generate a response.</summary>
        /// <param name="question">The user's question.</param>
        /// <returns>The AI's response.</returns>
        public async Task<string> ProcessQuestionAsync(string question)
        {
            try
            {
                this.monitor.Log($"Processing question: {question}", LogLevel.Debug);

                // Step 1: Check if the question is Stardew Valley related
                bool isStardewRelated = await this.aiClient.IsStardewRelatedAsync(question);

                if (!isStardewRelated)
                {
                    this.monitor.Log("Question is not Stardew Valley related", LogLevel.Debug);
                    return this.i18n.Get("error.non_stardew");
                }

                // Step 2: Retrieve relevant context
                string context = await this.RetrieveContextAsync(question);

                // Step 3: Generate response using LLM
                string systemPrompt = this.BuildSystemPrompt();
                string response = await this.aiClient.GetChatCompletionAsync(
                    systemPrompt,
                    question,
                    context
                );

                this.monitor.Log("Successfully generated response", LogLevel.Debug);
                return response;
            }
            catch (Exception ex)
            {
                this.monitor.Log($"Error processing question: {ex.Message}", LogLevel.Error);
                return this.i18n.Get("error.api");
            }
        }

        /// <summary>Retrieve relevant context for the question.</summary>
        private async Task<string> RetrieveContextAsync(string question)
        {
            var contextBuilder = new StringBuilder();

            try
            {
                // Get relevant game data
                this.monitor.Log("Extracting game data...", LogLevel.Debug);
                string gameData = this.gameDataExtractor.ExtractRelevantData(question);
                if (!string.IsNullOrWhiteSpace(gameData))
                {
                    contextBuilder.AppendLine("=== PLAYER'S CURRENT GAME STATE ===");
                    contextBuilder.AppendLine(gameData);
                    contextBuilder.AppendLine();
                }

                // Search wiki for relevant information
                this.monitor.Log("Searching wiki data...", LogLevel.Debug);
                var wikiEntries = await this.wikiDataLoader.SearchAsync(question, maxResults: 3);
                if (wikiEntries.Count > 0)
                {
                    string wikiContext = this.wikiDataLoader.GetFormattedContext(wikiEntries);
                    contextBuilder.AppendLine(wikiContext);
                }

                this.monitor.Log($"Retrieved context length: {contextBuilder.Length} characters", LogLevel.Debug);
            }
            catch (Exception ex)
            {
                this.monitor.Log($"Error retrieving context: {ex.Message}", LogLevel.Warn);
            }

            return contextBuilder.ToString();
        }

        /// <summary>Build the system prompt for the LLM.</summary>
        private string BuildSystemPrompt()
        {
            return @"You are a helpful and knowledgeable farmer from Stardew Valley. You have lived in the valley for many years and know everything about farming, villagers, seasons, crops, fishing, mining, and all aspects of life in Stardew Valley.

Your personality:
- Friendly and warm, like a wise old farmer
- Patient and helpful
- You speak from experience living in Stardew Valley
- You give practical, actionable advice

Guidelines:
1. Answer questions based on the provided context (game state and wiki information)
2. If the player's current game state is relevant, reference it in your answer
3. Be specific and helpful - include numbers, dates, and concrete details
4. If you don't have enough information, say so honestly
5. Keep responses concise but informative (2-4 sentences usually)
6. Use a warm, conversational tone
7. ONLY answer questions about Stardew Valley - you should not reach this point with non-Stardew questions

Example responses:
- ""Based on your current skills, I'd recommend focusing on fishing to level up. You're at level 3, so you'll unlock crab pots at level 4!""
- ""Haley's birthday is Spring 14, which is coming up soon! She loves Sunflowers and Coconuts.""
- ""You have 5 growing crops on your farm right now. For summer, I'd suggest planting Blueberries - they produce every 4 days and are very profitable!""

Remember: You're a farmer in Stardew Valley helping another farmer. Be helpful, specific, and friendly!";
        }
    }
}
