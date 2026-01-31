using StardewModdingAPI;
using StardewModdingAPI.Events;
using StardewValley;
using StardewValley.Menus;
using StardewGPT.UI;
using StardewGPT.Services;
using System.Collections.Generic;

namespace StardewGPT
{
    /// <summary>The mod entry point.</summary>
    public class ModEntry : Mod
    {
        private ModConfig? Config;
        internal static IMonitor? ModMonitor;
        internal static IModHelper? ModHelper;
        internal static ITranslationHelper? I18n;
        internal static RAGOrchestrator? RagOrchestrator;

        private AIClient? aiClient;
        private GameDataExtractor? gameDataExtractor;
        private EmbeddingClient? embeddingClient;
        private VectorDatabaseService? vectorDatabase;
        private ChatHistoryManager? chatHistoryManager;

        /// <summary>The mod entry point, called after the mod is first loaded.</summary>
        /// <param name="helper">Provides simplified APIs for writing mods.</param>
        public override void Entry(IModHelper helper)
        {
            ModMonitor = this.Monitor;
            ModHelper = helper;
            I18n = helper.Translation;

            // Load config
            this.Config = helper.ReadConfig<ModConfig>();

            // Initialize RAG system components
            this.InitializeRAGSystem();

            // Register events
            helper.Events.Input.ButtonPressed += this.OnButtonPressed;
            helper.Events.GameLoop.SaveLoaded += this.OnSaveLoaded;

            this.Monitor.Log("Stardew GPT initialized!", LogLevel.Info);
        }

        /// <summary>Initialize the RAG system components.</summary>
        private void InitializeRAGSystem()
        {
            try
            {
                this.Monitor.Log("Initializing RAG system...", LogLevel.Info);

                // Replace {account_id} placeholder in API endpoint
                if (this.Config!.ApiEndpoint.Contains("{account_id}"))
                {
                    this.Config.ApiEndpoint = this.Config.ApiEndpoint.Replace("{account_id}", this.Config.CloudflareAccountId);
                }

                // Detect language from game locale
                string language = this.Helper.Translation.Locale;
                this.Monitor.Log($"Detected game language: {language}", LogLevel.Info);

                // Create service instances
                this.aiClient = new AIClient(this.Config!, this.Monitor);
                this.gameDataExtractor = new GameDataExtractor(this.Monitor);
                this.embeddingClient = new EmbeddingClient(this.Config!, this.Monitor);
                this.vectorDatabase = new VectorDatabaseService(this.Monitor, this.Helper.DirectoryPath, language);
                this.chatHistoryManager = new ChatHistoryManager(this.Helper.DirectoryPath, this.Monitor);

                // Initialize vector database
                this.vectorDatabase.Initialize();

                // Create RAG orchestrator
                RagOrchestrator = new RAGOrchestrator(
                    this.aiClient,
                    this.gameDataExtractor,
                    this.embeddingClient,
                    this.vectorDatabase,
                    this.chatHistoryManager,
                    this.Monitor,
                    this.Helper.Translation
                );

                this.Monitor.Log("RAG system initialized successfully", LogLevel.Info);
            }
            catch (System.Exception ex)
            {
                this.Monitor.Log($"Error initializing RAG system: {ex.Message}", LogLevel.Error);
            }
        }

        /// <summary>Raised after the player loads a save.</summary>
        private async void OnSaveLoaded(object? sender, SaveLoadedEventArgs e)
        {
            // Vector database is already initialized in InitializeRAGSystem
            // No additional async initialization needed
            this.Monitor.Log("Save loaded, RAG system ready", LogLevel.Debug);
        }

        /// <summary>Raised after the player presses a button on the keyboard, controller, or mouse.</summary>
        private void OnButtonPressed(object? sender, ButtonPressedEventArgs e)
        {
            // Suppress keyboard input if chat menu is open, but allow mouse clicks for UI interaction
            if (Game1.activeClickableMenu is ChatTab)
            {
                // Allow ESC (to close), Enter (to send), and all mouse buttons (for UI interaction)
                if (e.Button != SButton.Escape &&
                    e.Button != SButton.Enter &&
                    e.Button != SButton.MouseLeft &&
                    e.Button != SButton.MouseRight &&
                    e.Button != SButton.MouseMiddle)
                {
                    this.Helper!.Input.Suppress(e.Button);
                }
                return;
            }

            // Check if player pressed the configured key to open chat
            if (!Context.IsWorldReady || !Context.IsPlayerFree)
                return;

            if (e.Button == this.Config!.OpenChatKey)
            {
                // Open the chat menu as a standalone menu
                Game1.activeClickableMenu = new ChatTab(
                    xPositionOnScreen: (Game1.uiViewport.Width - 1280) / 2,
                    yPositionOnScreen: (Game1.uiViewport.Height - 720) / 2,
                    width: 1280,
                    height: 720
                );
            }
        }
    }
}
