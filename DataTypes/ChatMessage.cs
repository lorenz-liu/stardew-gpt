using System;

namespace StardewGPT.DataTypes
{
    /// <summary>Represents a single message in the chat history.</summary>
    public class ChatMessage
    {
        /// <summary>The role of the message sender (user, assistant, or system).</summary>
        public string Role { get; set; }

        /// <summary>The content of the message.</summary>
        public string Content { get; set; }

        /// <summary>Timestamp when the message was created.</summary>
        public DateTime Timestamp { get; set; }

        public ChatMessage(string role, string content)
        {
            this.Role = role;
            this.Content = content;
            this.Timestamp = DateTime.Now;
        }

        // Parameterless constructor for JSON deserialization
        public ChatMessage()
        {
            this.Role = "";
            this.Content = "";
            this.Timestamp = DateTime.Now;
        }
    }
}
