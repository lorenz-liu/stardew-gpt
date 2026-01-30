using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Newtonsoft.Json;
using StardewGPT.DataTypes;
using StardewModdingAPI;

namespace StardewGPT.Services
{
    /// <summary>Manages chat history persistence to local JSON file.</summary>
    public class ChatHistoryManager
    {
        private readonly string historyFilePath;
        private readonly IMonitor monitor;
        private List<ChatMessage> chatHistory;
        private const int MaxHistoryMessages = 50; // Limit history to prevent token overflow

        public ChatHistoryManager(string modDirectory, IMonitor monitor)
        {
            this.monitor = monitor;
            this.historyFilePath = Path.Combine(modDirectory, "chat_history.json");
            this.chatHistory = new List<ChatMessage>();
            this.LoadHistory();
        }

        /// <summary>Load chat history from JSON file.</summary>
        private void LoadHistory()
        {
            try
            {
                if (File.Exists(this.historyFilePath))
                {
                    string json = File.ReadAllText(this.historyFilePath);

                    // Handle empty file case
                    if (string.IsNullOrWhiteSpace(json))
                    {
                        this.chatHistory = new List<ChatMessage>();
                        this.monitor.Log("Chat history file is empty, starting fresh.", LogLevel.Debug);
                        return;
                    }

                    this.chatHistory = JsonConvert.DeserializeObject<List<ChatMessage>>(json) ?? new List<ChatMessage>();
                    this.monitor.Log($"Loaded {this.chatHistory.Count} messages from chat history.", LogLevel.Debug);
                }
                else
                {
                    this.monitor.Log("No chat history file found, starting fresh.", LogLevel.Debug);
                }
            }
            catch (Exception ex)
            {
                this.monitor.Log($"Error loading chat history: {ex.Message}. Starting with empty history.", LogLevel.Warn);
                this.chatHistory = new List<ChatMessage>();
            }
        }

        /// <summary>Save chat history to JSON file.</summary>
        private void SaveHistory()
        {
            try
            {
                string json = JsonConvert.SerializeObject(this.chatHistory, Formatting.Indented);
                File.WriteAllText(this.historyFilePath, json);
                this.monitor.Log($"Saved {this.chatHistory.Count} messages to chat history.", LogLevel.Debug);
            }
            catch (Exception ex)
            {
                this.monitor.Log($"Error saving chat history: {ex.Message}", LogLevel.Error);
            }
        }

        /// <summary>Add a user message to the history.</summary>
        public void AddUserMessage(string content)
        {
            this.chatHistory.Add(new ChatMessage("user", content));
            this.TrimHistory();
            this.SaveHistory();
        }

        /// <summary>Add an assistant message to the history.</summary>
        public void AddAssistantMessage(string content)
        {
            this.chatHistory.Add(new ChatMessage("assistant", content));
            this.TrimHistory();
            this.SaveHistory();
        }

        /// <summary>Get all chat messages for API request.</summary>
        public List<ChatMessage> GetHistory()
        {
            return new List<ChatMessage>(this.chatHistory);
        }

        /// <summary>Get recent chat history (last N messages).</summary>
        public List<ChatMessage> GetRecentHistory(int count)
        {
            return this.chatHistory.Skip(Math.Max(0, this.chatHistory.Count - count)).ToList();
        }

        /// <summary>Clear all chat history.</summary>
        public void ClearHistory()
        {
            this.chatHistory.Clear();
            this.SaveHistory();
            this.monitor.Log("Chat history cleared.", LogLevel.Info);
        }

        /// <summary>Trim history to prevent it from growing too large.</summary>
        private void TrimHistory()
        {
            if (this.chatHistory.Count > MaxHistoryMessages)
            {
                // Keep only the most recent messages
                int toRemove = this.chatHistory.Count - MaxHistoryMessages;
                this.chatHistory.RemoveRange(0, toRemove);
                this.monitor.Log($"Trimmed {toRemove} old messages from history.", LogLevel.Debug);
            }
        }

        /// <summary>Get the count of messages in history.</summary>
        public int GetMessageCount()
        {
            return this.chatHistory.Count;
        }
    }
}
