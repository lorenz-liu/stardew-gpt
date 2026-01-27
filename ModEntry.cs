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
        private WikiDataLoader? wikiDataLoader;

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

                // Create service instances
                this.aiClient = new AIClient(this.Config!, this.Monitor);
                this.gameDataExtractor = new GameDataExtractor(this.Monitor);
                this.wikiDataLoader = new WikiDataLoader(this.Monitor, this.Helper.DirectoryPath);

                // Create RAG orchestrator
                RagOrchestrator = new RAGOrchestrator(
                    this.aiClient,
                    this.gameDataExtractor,
                    this.wikiDataLoader,
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
            try
            {
                // Initialize wiki data asynchronously
                if (this.wikiDataLoader != null)
                {
                    await this.wikiDataLoader.InitializeAsync();
                }
            }
            catch (System.Exception ex)
            {
                this.Monitor.Log($"Error loading wiki data: {ex.Message}", LogLevel.Error);
            }
        }

        /// <summary>Raised after the player presses a button on the keyboard, controller, or mouse.</summary>
        private void OnButtonPressed(object? sender, ButtonPressedEventArgs e)
        {
            // Suppress ALL input if chat menu is open, EXCEPT ESC (to close) and Enter (to send)
            if (Game1.activeClickableMenu is ChatTab)
            {
                if (e.Button != SButton.Escape && e.Button != SButton.Enter)
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
