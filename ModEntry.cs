using StardewModdingAPI;
using StardewModdingAPI.Events;
using StardewValley;
using StardewValley.Menus;
using StardewGPT.UI;

namespace StardewGPT
{
    /// <summary>The mod entry point.</summary>
    public class ModEntry : Mod
    {
        private ModConfig? Config;
        internal static IMonitor? ModMonitor;
        internal static IModHelper? ModHelper;
        internal static ITranslationHelper? I18n;

        /// <summary>The mod entry point, called after the mod is first loaded.</summary>
        /// <param name="helper">Provides simplified APIs for writing mods.</param>
        public override void Entry(IModHelper helper)
        {
            ModMonitor = this.Monitor;
            ModHelper = helper;
            I18n = helper.Translation;

            // Load config
            this.Config = helper.ReadConfig<ModConfig>();

            // Register events
            helper.Events.Input.ButtonPressed += this.OnButtonPressed;
            helper.Events.Display.MenuChanged += this.OnMenuChanged;

            this.Monitor.Log("Stardew GPT initialized!", LogLevel.Info);
        }

        /// <summary>Raised after the player presses a button on the keyboard, controller, or mouse.</summary>
        private void OnButtonPressed(object? sender, ButtonPressedEventArgs e)
        {
            // Check if player pressed the configured key (default: E)
            if (!Context.IsWorldReady || !Context.IsPlayerFree)
                return;

            // The game menu is opened by E key by default, we'll add our tab when menu opens
        }

        /// <summary>Raised after a game menu is opened, closed, or replaced.</summary>
        private void OnMenuChanged(object? sender, MenuChangedEventArgs e)
        {
            // Check if the new menu is the game menu (opened with E key)
            if (e.NewMenu is GameMenu gameMenu)
            {
                // Add our custom tab to the game menu
                var chatTab = new ChatTab(
                    xPositionOnScreen: gameMenu.xPositionOnScreen,
                    yPositionOnScreen: gameMenu.yPositionOnScreen,
                    width: gameMenu.width,
                    height: gameMenu.height
                );

                // Get the pages list and add our tab
                var pages = this.Helper!.Reflection.GetField<List<IClickableMenu>>(gameMenu, "pages").GetValue();
                pages.Add(chatTab);

                // Get the tabs list and add our tab button
                var tabs = this.Helper.Reflection.GetField<List<ClickableComponent>>(gameMenu, "tabs").GetValue();

                int tabIndex = pages.Count - 1;
                int tabX = gameMenu.xPositionOnScreen + Game1.tileSize * 12;
                int tabY = gameMenu.yPositionOnScreen + IClickableMenu.tabYPositionRelativeToMenuY + Game1.tileSize * (tabIndex - 7);

                tabs.Add(new ClickableComponent(
                    new Microsoft.Xna.Framework.Rectangle(tabX, tabY, Game1.tileSize, Game1.tileSize),
                    "stardewgpt-tab",
                    I18n!.Get("tab.name")
                ));

                this.Monitor.Log("Added Stardew GPT tab to game menu", LogLevel.Debug);
            }
        }
    }
}
