using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using StardewValley;
using StardewValley.Buildings;
using StardewValley.Characters;
using StardewValley.Locations;
using StardewValley.Objects;
using StardewValley.TerrainFeatures;
using StardewModdingAPI;

namespace StardewGPT.Services
{
    /// <summary>Extracts relevant game data for RAG context.</summary>
    public class GameDataExtractor
    {
        private readonly IMonitor monitor;

        public GameDataExtractor(IMonitor monitor)
        {
            this.monitor = monitor;
        }

        /// <summary>Get a description of the current weather.</summary>
        private string GetWeatherDescription()
        {
            if (Game1.isRaining)
            {
                if (Game1.isLightning)
                    return "Stormy";
                return "Rainy";
            }
            if (Game1.isSnowing)
                return "Snowy";
            if (Game1.isDebrisWeather)
                return "Windy";

            return "Sunny";
        }

        /// <summary>Extract specific data based on the user's question.</summary>
        /// <param name="question">The user's question.</param>
        /// <returns>Relevant game data for the question.</returns>
        public string ExtractRelevantData(string question)
        {
            if (!Context.IsWorldReady || Game1.player == null)
            {
                return "No game data available.";
            }

            var sb = new StringBuilder();

            try
            {
                // Always include basic context
                sb.AppendLine($"Current Season: {Game1.currentSeason}, Day {Game1.dayOfMonth}, Year {Game1.year}");
                sb.AppendLine($"Player: {Game1.player.Name}, Money: {Game1.player.Money}g");
                sb.AppendLine();

                // Player Skills
                sb.AppendLine("Player Skills:");
                sb.AppendLine($"- Farming: Level {Game1.player.farmingLevel}");
                sb.AppendLine($"- Fishing: Level {Game1.player.fishingLevel}");
                sb.AppendLine($"- Foraging: Level {Game1.player.foragingLevel}");
                sb.AppendLine($"- Mining: Level {Game1.player.miningLevel}");
                sb.AppendLine($"- Combat: Level {Game1.player.combatLevel}");
                sb.AppendLine();

                // Current Inventory
                sb.AppendLine("Current Inventory:");
                var items = Game1.player.Items.Where(item => item != null);
                foreach (var item in items)
                {
                    sb.AppendLine($"- {item.DisplayName} x{item.Stack}");
                }
                sb.AppendLine();

                // Friendships
                sb.AppendLine("Friendships:");
                var friendships = Game1.player.friendshipData.Pairs.OrderByDescending(f => f.Value.Points);
                foreach (var friendship in friendships)
                {
                    int hearts = friendship.Value.Points / 250;
                    sb.AppendLine($"- {friendship.Key}: {hearts} hearts");
                }
                sb.AppendLine();

                // Farm Info
                if (Game1.getFarm() is Farm farm)
                {
                    int cropCount = 0;
                    foreach (var terrainFeature in farm.terrainFeatures.Values)
                    {
                        if (terrainFeature is HoeDirt dirt && dirt.crop != null)
                        {
                            cropCount++;
                        }
                    }
                    sb.AppendLine($"Farm Info:");
                    sb.AppendLine($"- Growing Crops: {cropCount}");
                    sb.AppendLine($"- Buildings: {farm.buildings.Count}");
                    sb.AppendLine();
                }

                // Quests
                sb.AppendLine("Quests:");
                sb.AppendLine($"- Active: {Game1.player.questLog.Count(q => !q.completed.Value)}");
                sb.AppendLine($"- Completed: {Game1.player.questLog.Count(q => q.completed.Value)}");
                sb.AppendLine();

            }
            catch (Exception ex)
            {
                this.monitor.Log($"Error extracting relevant data: {ex.Message}", LogLevel.Error);
            }

            return sb.ToString();
        }
    }
}
