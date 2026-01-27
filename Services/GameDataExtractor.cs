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

        /// <summary>Extract all relevant game data as a formatted string.</summary>
        public string ExtractGameData()
        {
            if (!Context.IsWorldReady || Game1.player == null)
            {
                return "No game data available (not in game).";
            }

            var sb = new StringBuilder();

            try
            {
                // Player basic info
                sb.AppendLine("=== PLAYER INFO ===");
                sb.AppendLine($"Name: {Game1.player.Name}");
                sb.AppendLine($"Farm Name: {Game1.player.farmName}");
                sb.AppendLine($"Money: {Game1.player.Money}g");
                sb.AppendLine($"Total Earnings: {Game1.player.totalMoneyEarned}g");
                sb.AppendLine();

                // Date and season
                sb.AppendLine("=== DATE & SEASON ===");
                sb.AppendLine($"Season: {Game1.currentSeason}");
                sb.AppendLine($"Day: {Game1.dayOfMonth}");
                sb.AppendLine($"Year: {Game1.year}");
                sb.AppendLine($"Day of Week: {Game1.shortDayNameFromDayOfSeason(Game1.dayOfMonth)}");
                sb.AppendLine($"Weather: {this.GetWeatherDescription()}");
                sb.AppendLine();

                // Skills
                sb.AppendLine("=== SKILLS ===");
                sb.AppendLine($"Farming: Level {Game1.player.farmingLevel}");
                sb.AppendLine($"Fishing: Level {Game1.player.fishingLevel}");
                sb.AppendLine($"Foraging: Level {Game1.player.foragingLevel}");
                sb.AppendLine($"Mining: Level {Game1.player.miningLevel}");
                sb.AppendLine($"Combat: Level {Game1.player.combatLevel}");
                sb.AppendLine();

                // Inventory (top items)
                sb.AppendLine("=== INVENTORY (Top 10 Items) ===");
                var inventoryItems = Game1.player.Items
                    .Where(item => item != null)
                    .Take(10)
                    .ToList();

                if (inventoryItems.Any())
                {
                    foreach (var item in inventoryItems)
                    {
                        sb.AppendLine($"- {item.DisplayName} x{item.Stack}");
                    }
                }
                else
                {
                    sb.AppendLine("(Empty)");
                }
                sb.AppendLine();

                // Friendships
                sb.AppendLine("=== FRIENDSHIPS (Top 10) ===");
                var friendships = Game1.player.friendshipData.Pairs
                    .OrderByDescending(f => f.Value.Points)
                    .Take(10)
                    .ToList();

                foreach (var friendship in friendships)
                {
                    int hearts = friendship.Value.Points / 250;
                    sb.AppendLine($"- {friendship.Key}: {hearts} hearts ({friendship.Value.Points} points)");
                }
                sb.AppendLine();

                // Completed quests count
                sb.AppendLine("=== QUESTS ===");
                sb.AppendLine($"Completed Quests: {Game1.player.questLog.Count(q => q.completed.Value)}");
                sb.AppendLine($"Active Quests: {Game1.player.questLog.Count(q => !q.completed.Value)}");
                sb.AppendLine();

                // Farm info
                sb.AppendLine("=== FARM INFO ===");
                if (Game1.getFarm() is Farm farm)
                {
                    sb.AppendLine($"Farm Type: {Game1.whichFarm}");

                    // Count buildings
                    int coops = farm.buildings.Count(b => b.buildingType.Value.Contains("Coop"));
                    int barns = farm.buildings.Count(b => b.buildingType.Value.Contains("Barn"));
                    int silos = farm.buildings.Count(b => b.buildingType.Value.Contains("Silo"));

                    sb.AppendLine($"Coops: {coops}");
                    sb.AppendLine($"Barns: {barns}");
                    sb.AppendLine($"Silos: {silos}");
                    sb.AppendLine($"Total Buildings: {farm.buildings.Count}");

                    // Count crops
                    int cropCount = 0;
                    foreach (var terrainFeature in farm.terrainFeatures.Values)
                    {
                        if (terrainFeature is HoeDirt dirt && dirt.crop != null)
                        {
                            cropCount++;
                        }
                    }
                    sb.AppendLine($"Growing Crops: {cropCount}");
                }
                sb.AppendLine();

                // Community Center progress
                sb.AppendLine("=== COMMUNITY CENTER ===");
                sb.AppendLine($"Community Center Complete: {Game1.MasterPlayer.hasCompletedCommunityCenter()}");
                if (Game1.locations.OfType<CommunityCenter>().FirstOrDefault() is CommunityCenter cc)
                {
                    int totalBundles = cc.bundles.Count();
                    int completedBundles = cc.bundles.Pairs.Count(b => b.Value[0] == true);
                    sb.AppendLine($"Bundles Completed: {completedBundles}/{totalBundles}");
                }
                sb.AppendLine();

                // Achievements
                sb.AppendLine("=== ACHIEVEMENTS ===");
                sb.AppendLine($"Total Achievements: {Game1.player.achievements.Count}");
                sb.AppendLine();

            }
            catch (Exception ex)
            {
                this.monitor.Log($"Error extracting game data: {ex.Message}", LogLevel.Error);
                sb.AppendLine($"Error extracting some game data: {ex.Message}");
            }

            return sb.ToString();
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
            string lowerQuestion = question.ToLower();

            try
            {
                // Always include basic context
                sb.AppendLine($"Current Season: {Game1.currentSeason}, Day {Game1.dayOfMonth}, Year {Game1.year}");
                sb.AppendLine($"Player: {Game1.player.Name}, Money: {Game1.player.Money}g");
                sb.AppendLine();

                // Check for specific topics
                if (lowerQuestion.Contains("skill") || lowerQuestion.Contains("level"))
                {
                    sb.AppendLine("Player Skills:");
                    sb.AppendLine($"- Farming: Level {Game1.player.farmingLevel}");
                    sb.AppendLine($"- Fishing: Level {Game1.player.fishingLevel}");
                    sb.AppendLine($"- Foraging: Level {Game1.player.foragingLevel}");
                    sb.AppendLine($"- Mining: Level {Game1.player.miningLevel}");
                    sb.AppendLine($"- Combat: Level {Game1.player.combatLevel}");
                    sb.AppendLine();
                }

                if (lowerQuestion.Contains("inventory") || lowerQuestion.Contains("item") || lowerQuestion.Contains("have"))
                {
                    sb.AppendLine("Current Inventory:");
                    var items = Game1.player.Items.Where(item => item != null).Take(15);
                    foreach (var item in items)
                    {
                        sb.AppendLine($"- {item.DisplayName} x{item.Stack}");
                    }
                    sb.AppendLine();
                }

                if (lowerQuestion.Contains("friend") || lowerQuestion.Contains("relationship") || lowerQuestion.Contains("villager") || lowerQuestion.Contains("heart"))
                {
                    sb.AppendLine("Friendships:");
                    var friendships = Game1.player.friendshipData.Pairs.OrderByDescending(f => f.Value.Points).Take(10);
                    foreach (var friendship in friendships)
                    {
                        int hearts = friendship.Value.Points / 250;
                        sb.AppendLine($"- {friendship.Key}: {hearts} hearts");
                    }
                    sb.AppendLine();
                }

                if (lowerQuestion.Contains("crop") || lowerQuestion.Contains("farm") || lowerQuestion.Contains("plant"))
                {
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
                }

                if (lowerQuestion.Contains("quest"))
                {
                    sb.AppendLine("Quests:");
                    sb.AppendLine($"- Active: {Game1.player.questLog.Count(q => !q.completed.Value)}");
                    sb.AppendLine($"- Completed: {Game1.player.questLog.Count(q => q.completed.Value)}");
                    sb.AppendLine();
                }

            }
            catch (Exception ex)
            {
                this.monitor.Log($"Error extracting relevant data: {ex.Message}", LogLevel.Error);
            }

            return sb.ToString();
        }
    }
}
