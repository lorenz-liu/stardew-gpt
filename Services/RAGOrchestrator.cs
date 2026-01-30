using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using StardewGPT.DataTypes;
using StardewModdingAPI;

namespace StardewGPT.Services
{
    /// <summary>Orchestrates the RAG (Retrieval-Augmented Generation) system.</summary>
    public class RAGOrchestrator
    {
        private readonly AIClient aiClient;
        private readonly GameDataExtractor gameDataExtractor;
        private readonly LocalKnowledgeLoader localKnowledgeLoader;
        private readonly ChatHistoryManager chatHistoryManager;
        private readonly IMonitor monitor;
        private readonly ITranslationHelper i18n;

        public RAGOrchestrator(
            AIClient aiClient,
            GameDataExtractor gameDataExtractor,
            LocalKnowledgeLoader localKnowledgeLoader,
            ChatHistoryManager chatHistoryManager,
            IMonitor monitor,
            ITranslationHelper i18n)
        {
            this.aiClient = aiClient;
            this.gameDataExtractor = gameDataExtractor;
            this.localKnowledgeLoader = localKnowledgeLoader;
            this.chatHistoryManager = chatHistoryManager;
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

                // Get recent chat history (last 10 messages only for API context)
                var recentHistory = this.chatHistoryManager.GetRecentHistory(10);

                // Generate response using LLM with conversation history
                string systemPrompt = this.BuildSystemPrompt();
                string response = await this.aiClient.GetChatCompletionWithHistoryAsync(
                    systemPrompt,
                    recentHistory,
                    question,
                    context
                );

                // Save user message and assistant response to history
                this.chatHistoryManager.AddUserMessage(question);
                this.chatHistoryManager.AddAssistantMessage(response);

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

        /// <summary>Clear the conversation history.</summary>
        public void ClearHistory()
        {
            this.chatHistoryManager.ClearHistory();
            this.monitor.Log("Conversation history cleared", LogLevel.Info);
        }

        /// <summary>Get the current message count in history.</summary>
        public int GetHistoryMessageCount()
        {
            return this.chatHistoryManager.GetMessageCount();
        }

        /// <summary>Get the full chat history.</summary>
        public List<ChatMessage> GetChatHistory()
        {
            return this.chatHistoryManager.GetHistory();
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
1. CRITICAL: Answer questions ONLY using information from the provided context (game state and wiki information)
2. NEVER make up or guess specific details like floor numbers, locations, or statistics
3. If the provided context contains the answer, use those EXACT details (numbers, locations, etc.)
4. If the player's current game state is relevant, reference it in your answer
5. Be specific and helpful - include numbers, dates, and concrete details FROM THE CONTEXT
6. If the context doesn't contain enough information to answer accurately, say so honestly
7. Keep responses concise but informative (2-4 sentences usually)
8. Use a warm, conversational tone
9. IMPORTANT: Respond in only plain text without any formatting such as markdown, html, or latex
10. If the question is NOT about Stardew Valley, politely respond: ""{nonStardewResponse}""
11. You have access to the conversation history - use it to understand follow-up questions and maintain context
12. When the user asks follow-up questions like ""what about that?"" or ""tell me more"", refer to the previous conversation

Example responses:
- ""Based on your current skills, I'd recommend focusing on fishing to level up. You're at level 3, so you'll unlock crab pots at level 4!""
- ""Haley's birthday is Spring 14, which is coming up soon! She loves Sunflowers and Coconuts.""
- ""You have 5 growing crops on your farm right now. For summer, I'd suggest planting Blueberries - they produce every 4 days and are very profitable!""

Remember: You're a farmer in Stardew Valley helping another farmer. Be helpful, specific, and friendly! Always use the exact information from the provided context - never guess or make up details.";
        }
    }
}
