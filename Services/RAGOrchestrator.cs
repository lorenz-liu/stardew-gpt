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
        private readonly LocalKnowledgeLoader localKnowledgeLoader;
        private readonly IMonitor monitor;
        private readonly ITranslationHelper i18n;

        public RAGOrchestrator(
            AIClient aiClient,
            GameDataExtractor gameDataExtractor,
            LocalKnowledgeLoader localKnowledgeLoader,
            IMonitor monitor,
            ITranslationHelper i18n)
        {
            this.aiClient = aiClient;
            this.gameDataExtractor = gameDataExtractor;
            this.localKnowledgeLoader = localKnowledgeLoader;
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

                // Retrieve relevant context
                string context = await this.RetrieveContextAsync(question);

                // Generate response using LLM
                string systemPrompt = this.BuildSystemPrompt();
                string response = await this.aiClient.GetChatCompletionAsync(
                    systemPrompt,
                    question,
                    context
                );

                this.monitor.Log("Successfully generated response", LogLevel.Debug);
                return response;
            }
            catch (InvalidApiKeyException)
            {
                this.monitor.Log("Invalid API key detected", LogLevel.Error);
                return this.i18n.Get("error.invalid_api_key");
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

                // Search local knowledge base for relevant information
                this.monitor.Log("Searching local knowledge base...", LogLevel.Debug);
                var knowledgeEntries = await this.localKnowledgeLoader.SearchAsync(question, maxResults: 3);
                if (knowledgeEntries.Count > 0)
                {
                    string knowledgeContext = this.localKnowledgeLoader.GetFormattedContext(knowledgeEntries);
                    contextBuilder.AppendLine(knowledgeContext);
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
            string nonStardewResponse = this.i18n.Get("error.non_stardew");

            return $@"You are a helpful and knowledgeable farmer from Stardew Valley. You have lived in the valley for many years and know everything about farming, villagers, seasons, crops, fishing, mining, and all aspects of life in Stardew Valley.

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
7. IMPORTANT: Respond in only plain text without any formatting such as markdown, html, or latex
8. If the question is NOT about Stardew Valley, politely respond: ""{nonStardewResponse}""

Example responses:
- ""Based on your current skills, I'd recommend focusing on fishing to level up. You're at level 3, so you'll unlock crab pots at level 4!""
- ""Haley's birthday is Spring 14, which is coming up soon! She loves Sunflowers and Coconuts.""
- ""You have 5 growing crops on your farm right now. For summer, I'd suggest planting Blueberries - they produce every 4 days and are very profitable!""

Remember: You're a farmer in Stardew Valley helping another farmer. Be helpful, specific, and friendly!";
        }
    }
}
