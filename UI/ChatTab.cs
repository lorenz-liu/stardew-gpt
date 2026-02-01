using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using StardewValley;
using StardewValley.Menus;
using StardewValley.BellsAndWhistles;
using System;
using System.Collections.Generic;
using System.Text;

namespace StardewGPT.UI
{
    /// <summary>The chat tab in the game menu.</summary>
    public class ChatTab : IClickableMenu
    {
        private readonly TextBox inputTextBox;
        private readonly List<UIChatMessage> chatHistory;
        private readonly ClickableTextureComponent clearHistoryButton;
        private int scrollOffset = 0;
        private bool isWaitingForResponse = false;

        // UI Layout constants
        private const int Padding = 32;
        private const int TopPadding = 96; // Extra padding for dialogue box border
        private const int InputBoxHeight = 48;
        private const int MessageSpacing = 12;
        private const int MessagePadding = 12;
        private const int ButtonSize = 64;

        public ChatTab(int xPositionOnScreen, int yPositionOnScreen, int width, int height)
            : base(xPositionOnScreen, yPositionOnScreen, width, height, showUpperRightCloseButton: true)
        {
            this.chatHistory = new List<UIChatMessage>();

            // Create input text box (full width now, no button next to it)
            int inputBoxWidth = width - Padding * 2;
            int inputBoxX = xPositionOnScreen + Padding;
            int inputBoxY = yPositionOnScreen + height - Padding - InputBoxHeight;

            this.inputTextBox = new TextBox(
                textBoxTexture: Game1.content.Load<Texture2D>("LooseSprites\\textBox"),
                null,
                Game1.smallFont,
                Game1.textColor
            )
            {
                X = inputBoxX,
                Y = inputBoxY,
                Width = inputBoxWidth,
                Height = InputBoxHeight
            };

            // Create clear history button in top-right corner (inside the content area)
            // Use the same padding as the message area for consistent positioning
            int buttonX = xPositionOnScreen + width - ButtonSize - Padding; // Align with content area
            int buttonY = yPositionOnScreen + TopPadding + 15; // Just inside the top content area
            this.clearHistoryButton = new ClickableTextureComponent(
                new Rectangle(buttonX, buttonY, ButtonSize, ButtonSize),
                Game1.mouseCursors,
                new Rectangle(564, 102, 18, 26), // Dustbin/trash can icon
                2.5f
            )
            {
                myID = 101,
                name = "ClearHistory"
            };

            // Load persisted chat history
            this.LoadChatHistory();

            // If no history, add welcome message
            if (this.chatHistory.Count == 0)
            {
                this.AddMessage(ModEntry.I18n!.Get("chat.welcome"), isUser: false);
            }

            // Auto-focus the text box
            this.inputTextBox.Selected = true;
        }

        /// <summary>Load chat history from the persistent storage.</summary>
        private void LoadChatHistory()
        {
            try
            {
                if (ModEntry.RagOrchestrator != null)
                {
                    // Get the chat history manager through a new public method
                    var persistedHistory = ModEntry.RagOrchestrator.GetChatHistory();

                    // Convert persisted messages to UI messages
                    foreach (var msg in persistedHistory)
                    {
                        bool isUser = msg.Role == "user";
                        this.chatHistory.Add(new UIChatMessage
                        {
                            Text = msg.Content,
                            IsUser = isUser,
                            Timestamp = msg.Timestamp
                        });
                    }

                    // Auto-scroll to bottom if there's history
                    if (this.chatHistory.Count > 0)
                    {
                        int totalHeight = this.CalculateTotalMessagesHeight();
                        int messageAreaHeight = this.height - TopPadding - Padding - InputBoxHeight - MessageSpacing;
                        this.scrollOffset = Math.Max(0, totalHeight - messageAreaHeight);
                    }

                    ModEntry.ModMonitor?.Log($"Loaded {this.chatHistory.Count} messages from history", StardewModdingAPI.LogLevel.Debug);
                }
            }
            catch (Exception ex)
            {
                ModEntry.ModMonitor?.Log($"Error loading chat history: {ex.Message}", StardewModdingAPI.LogLevel.Warn);
            }
        }

        /// <summary>Add a message to the chat history.</summary>
        private void AddMessage(string text, bool isUser)
        {
            this.chatHistory.Add(new UIChatMessage
            {
                Text = text,
                IsUser = isUser,
                Timestamp = DateTime.Now
            });

            // Auto-scroll to bottom
            int totalHeight = this.CalculateTotalMessagesHeight();
            int messageAreaHeight = this.height - TopPadding - Padding - InputBoxHeight - MessageSpacing;
            this.scrollOffset = Math.Max(0, totalHeight - messageAreaHeight);
        }

        /// <summary>Handle sending a message.</summary>
        private async void SendMessage()
        {
            string message = this.inputTextBox.Text.Trim();
            if (string.IsNullOrEmpty(message) || this.isWaitingForResponse)
                return;

            // Add user message to chat
            this.AddMessage(message, isUser: true);
            this.inputTextBox.Text = "";

            // Play sound when message is sent
            Game1.playSound("shwip");

            // Show loading indicator
            this.isWaitingForResponse = true;
            this.AddMessage(ModEntry.I18n!.Get("chat.thinking"), isUser: false);

            try
            {
                // Call RAG system to process the question
                if (ModEntry.RagOrchestrator != null)
                {
                    string response = await ModEntry.RagOrchestrator.ProcessQuestionAsync(message);

                    // Remove loading message
                    this.chatHistory.RemoveAt(this.chatHistory.Count - 1);

                    // Add AI response
                    this.AddMessage(response, isUser: false);

                    // Play sound when response is received
                    Game1.playSound("newRecipe");
                }
                else
                {
                    // Remove loading message
                    this.chatHistory.RemoveAt(this.chatHistory.Count - 1);

                    // Show error if RAG system is not initialized
                    this.AddMessage("RAG system not initialized. Please check your configuration.", isUser: false);
                    ModEntry.ModMonitor?.Log("RAG orchestrator is null", StardewModdingAPI.LogLevel.Error);

                    // Play sound when response is received
                    Game1.playSound("newRecipe");
                }
            }
            catch (Exception ex)
            {
                // Remove loading message
                this.chatHistory.RemoveAt(this.chatHistory.Count - 1);

                // Show error
                this.AddMessage($"Error: {ex.Message}", isUser: false);
                ModEntry.ModMonitor?.Log($"Error sending message: {ex}", StardewModdingAPI.LogLevel.Error);

                // Play sound when response is received
                Game1.playSound("newRecipe");
            }
            finally
            {
                this.isWaitingForResponse = false;
            }
        }

        public override void receiveLeftClick(int x, int y, bool playSound = true)
        {
            // Check if clear history button was clicked BEFORE calling base
            if (this.clearHistoryButton.containsPoint(x, y))
            {
                this.ClearChatHistory();
                Game1.playSound("trashcan");
                return;
            }

            base.receiveLeftClick(x, y, playSound);

            // Focus text box if clicked
            this.inputTextBox.Selected = new Rectangle(this.inputTextBox.X, this.inputTextBox.Y, this.inputTextBox.Width, this.inputTextBox.Height).Contains(x, y);
        }

        /// <summary>Clear the chat history.</summary>
        private void ClearChatHistory()
        {
            // Clear UI chat history
            this.chatHistory.Clear();

            // Clear persistent chat history
            if (ModEntry.RagOrchestrator != null)
            {
                ModEntry.RagOrchestrator.ClearHistory();
            }

            // Add welcome message back
            this.AddMessage(ModEntry.I18n!.Get("chat.welcome"), isUser: false);

            // Reset scroll
            this.scrollOffset = 0;

            ModEntry.ModMonitor?.Log("Chat history cleared", StardewModdingAPI.LogLevel.Info);
        }

        public override void performHoverAction(int x, int y)
        {
            base.performHoverAction(x, y);

            // Update button scale on hover
            this.clearHistoryButton.scale = this.clearHistoryButton.containsPoint(x, y) ? 2.8f : 2.5f;
        }

        public override void receiveKeyPress(Keys key)
        {
            // Handle Enter key to send message
            if (key == Keys.Enter && this.inputTextBox.Selected)
            {
                this.SendMessage();
                return;
            }

            base.receiveKeyPress(key);
        }

        public override void receiveScrollWheelAction(int direction)
        {
            base.receiveScrollWheelAction(direction);

            // Scroll chat history
            int totalHeight = this.CalculateTotalMessagesHeight();
            int messageAreaHeight = this.height - TopPadding - Padding - InputBoxHeight - MessageSpacing;
            int maxScroll = Math.Max(0, totalHeight - messageAreaHeight);

            if (direction > 0)
            {
                this.scrollOffset = Math.Max(0, this.scrollOffset - 40);
            }
            else if (direction < 0)
            {
                this.scrollOffset = Math.Min(maxScroll, this.scrollOffset + 40);
            }
        }

        public override void draw(SpriteBatch b)
        {
            // Draw background
            Game1.drawDialogueBox(
                this.xPositionOnScreen,
                this.yPositionOnScreen,
                this.width,
                this.height,
                false,
                true
            );

            // Draw chat messages
            int messageAreaX = this.xPositionOnScreen + Padding;
            int messageAreaY = this.yPositionOnScreen + TopPadding;
            int messageAreaWidth = this.width - Padding * 2;
            int messageAreaHeight = this.height - TopPadding - Padding - InputBoxHeight - MessageSpacing;
            int bubbleMaxWidth = messageAreaWidth / 2 - MessageSpacing;

            // Create a scissor rectangle to clip messages outside the area
            Rectangle scissorRect = new Rectangle(
                messageAreaX,
                messageAreaY,
                messageAreaWidth,
                messageAreaHeight
            );

            var originalScissorRect = b.GraphicsDevice.ScissorRectangle;
            var originalRasterizerState = b.GraphicsDevice.RasterizerState;

            b.End();
            b.Begin(SpriteSortMode.Deferred, BlendState.AlphaBlend, SamplerState.PointClamp, null, new RasterizerState { ScissorTestEnable = true });
            b.GraphicsDevice.ScissorRectangle = scissorRect;

            int currentY = messageAreaY - this.scrollOffset;

            foreach (var message in this.chatHistory)
            {
                // Calculate message dimensions (cached)
                var (wrappedText, bubbleHeight, bubbleWidth) = this.GetMessageDimensions(message, bubbleMaxWidth - MessagePadding * 2);
                bubbleWidth = Math.Min(bubbleMaxWidth, bubbleWidth);

                // Position bubble (user messages on right, AI on left)
                int bubbleX = message.IsUser
                    ? messageAreaX + messageAreaWidth - bubbleWidth
                    : messageAreaX;

                // Only draw if visible in the message area
                if (currentY + bubbleHeight > messageAreaY && currentY < messageAreaY + messageAreaHeight)
                {
                    // Draw bubble background
                    Color bubbleColor = message.IsUser
                        ? new Color(100, 150, 255, 200)
                        : new Color(200, 200, 200, 200);

                    IClickableMenu.drawTextureBox(
                        b,
                        Game1.menuTexture,
                        new Rectangle(0, 256, 60, 60),
                        bubbleX,
                        currentY,
                        bubbleWidth,
                        bubbleHeight,
                        bubbleColor,
                        1f,
                        false
                    );

                    // Draw message text
                    Utility.drawTextWithShadow(
                        b,
                        wrappedText,
                        Game1.smallFont,
                        new Vector2(bubbleX + MessagePadding, currentY + MessagePadding),
                        Game1.textColor
                    );
                }

                currentY += bubbleHeight + MessageSpacing;
            }

            b.End();
            b.GraphicsDevice.ScissorRectangle = originalScissorRect;
            b.Begin(SpriteSortMode.Deferred, BlendState.AlphaBlend, SamplerState.PointClamp, null, originalRasterizerState);

            // Draw input box
            this.inputTextBox.Draw(b);

            // Draw clear history button
            this.clearHistoryButton.draw(b);

            // Draw button hover text
            if (this.clearHistoryButton.containsPoint(Game1.getMouseX(), Game1.getMouseY()))
            {
                IClickableMenu.drawHoverText(
                    b,
                    ModEntry.I18n!.Get("chat.clear_history"),
                    Game1.smallFont
                );
            }

            // Draw mouse cursor
            this.drawMouse(b);
        }

        /// <summary>Wrap text to fit within a specified width.</summary>
        private string WrapText(string text, int maxWidth, SpriteFont font)
        {
            StringBuilder result = new StringBuilder();
            StringBuilder currentLine = new StringBuilder();

            // Split by spaces first to handle English words
            string[] segments = text.Split(' ');

            for (int i = 0; i < segments.Length; i++)
            {
                string segment = segments[i];
                bool isLastSegment = i == segments.Length - 1;

                // If segment is empty, skip it
                if (string.IsNullOrEmpty(segment))
                    continue;

                // Try to add the whole segment with space
                string testLine = currentLine.Length == 0 ? segment : $"{currentLine} {segment}";
                float testWidth = font.MeasureString(testLine).X;

                if (testWidth <= maxWidth)
                {
                    // Segment fits, add it
                    if (currentLine.Length > 0)
                        currentLine.Append(" ");
                    currentLine.Append(segment);
                }
                else
                {
                    // Segment doesn't fit
                    // If current line has content, start a new line
                    if (currentLine.Length > 0)
                    {
                        result.AppendLine(currentLine.ToString());
                        currentLine.Clear();
                    }

                    // Check if the segment itself is too long and needs character-by-character wrapping
                    if (font.MeasureString(segment).X > maxWidth)
                    {
                        // Break segment character by character
                        foreach (char c in segment)
                        {
                            string testChar = currentLine.ToString() + c;
                            if (font.MeasureString(testChar).X > maxWidth && currentLine.Length > 0)
                            {
                                result.AppendLine(currentLine.ToString());
                                currentLine.Clear();
                            }
                            currentLine.Append(c);
                        }
                    }
                    else
                    {
                        // Segment fits on its own line
                        currentLine.Append(segment);
                    }
                }
            }

            if (currentLine.Length > 0)
                result.Append(currentLine.ToString());

            return result.ToString();
        }

        /// <summary>Calculate message dimensions with caching.</summary>
        private (string wrappedText, int height, int width) GetMessageDimensions(UIChatMessage message, int maxWidth)
        {
            // Return cached values if available
            if (message.CachedWrappedText != null && message.CachedMaxWidth == maxWidth)
            {
                return (message.CachedWrappedText, message.CachedHeight, message.CachedWidth);
            }

            // Calculate and cache
            string wrappedText = this.WrapText(message.Text, maxWidth, Game1.smallFont);
            Vector2 textSize = Game1.smallFont.MeasureString(wrappedText);
            int height = (int)textSize.Y + MessagePadding * 2;
            // Ensure width never exceeds maxWidth + padding
            int width = maxWidth + MessagePadding * 2;

            message.CachedWrappedText = wrappedText;
            message.CachedHeight = height;
            message.CachedWidth = width;
            message.CachedMaxWidth = maxWidth;

            return (wrappedText, height, width);
        }

        /// <summary>Calculate the total height of all messages.</summary>
        private int CalculateTotalMessagesHeight()
        {
            int totalHeight = 0;
            int messageAreaWidth = this.width - Padding * 2;
            int bubbleMaxWidth = messageAreaWidth / 2 - MessageSpacing;

            foreach (var message in this.chatHistory)
            {
                var (_, height, _) = this.GetMessageDimensions(message, bubbleMaxWidth - MessagePadding * 2);
                totalHeight += height + MessageSpacing;
            }

            return totalHeight;
        }
    }

    /// <summary>Represents a chat message in the UI.</summary>
    public class UIChatMessage
    {
        public string Text { get; set; } = "";
        public bool IsUser { get; set; }
        public DateTime Timestamp { get; set; }

        // Cache for wrapped text and dimensions
        internal string? CachedWrappedText { get; set; }
        internal int CachedHeight { get; set; }
        internal int CachedWidth { get; set; }
        internal int CachedMaxWidth { get; set; }
    }
}
