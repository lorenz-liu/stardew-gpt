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
        private readonly ClickableTextureComponent sendButton;
        private readonly List<ChatMessage> chatHistory;
        private int scrollOffset = 0;
        private bool isWaitingForResponse = false;

        // UI Layout constants
        private const int Padding = 32;
        private const int InputBoxHeight = 48;
        private const int ButtonWidth = 100;
        private const int MessageSpacing = 12;
        private const int MessagePadding = 12;

        public ChatTab(int xPositionOnScreen, int yPositionOnScreen, int width, int height)
            : base(xPositionOnScreen, yPositionOnScreen, width, height, showUpperRightCloseButton: true)
        {
            this.chatHistory = new List<ChatMessage>();

            // Create input text box
            int inputBoxWidth = width - Padding * 2 - ButtonWidth - 16;
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

            // Create send button
            int buttonX = inputBoxX + inputBoxWidth + 16;
            int buttonY = inputBoxY;

            this.sendButton = new ClickableTextureComponent(
                bounds: new Rectangle(buttonX, buttonY, ButtonWidth, InputBoxHeight),
                texture: Game1.mouseCursors,
                sourceRect: new Rectangle(128, 256, 64, 64),
                scale: 1f
            )
            {
                myID = 101,
                name = "SendButton"
            };

            // Add welcome message
            this.AddMessage(ModEntry.I18n!.Get("chat.welcome"), isUser: false);

            // Auto-focus the text box
            this.inputTextBox.Selected = true;
        }

        /// <summary>Add a message to the chat history.</summary>
        private void AddMessage(string text, bool isUser)
        {
            this.chatHistory.Add(new ChatMessage
            {
                Text = text,
                IsUser = isUser,
                Timestamp = DateTime.Now
            });

            // Auto-scroll to bottom
            int totalHeight = this.CalculateTotalMessagesHeight();
            int messageAreaHeight = this.height - Padding * 2 - InputBoxHeight - MessageSpacing;
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
                }
                else
                {
                    // Remove loading message
                    this.chatHistory.RemoveAt(this.chatHistory.Count - 1);

                    // Show error if RAG system is not initialized
                    this.AddMessage("RAG system not initialized. Please check your configuration.", isUser: false);
                    ModEntry.ModMonitor?.Log("RAG orchestrator is null", StardewModdingAPI.LogLevel.Error);
                }
            }
            catch (Exception ex)
            {
                // Remove loading message
                this.chatHistory.RemoveAt(this.chatHistory.Count - 1);

                // Show error
                this.AddMessage($"Error: {ex.Message}", isUser: false);
                ModEntry.ModMonitor?.Log($"Error sending message: {ex}", StardewModdingAPI.LogLevel.Error);
            }
            finally
            {
                this.isWaitingForResponse = false;
            }
        }

        public override void receiveLeftClick(int x, int y, bool playSound = true)
        {
            base.receiveLeftClick(x, y, playSound);

            // Check if send button was clicked
            if (this.sendButton.containsPoint(x, y))
            {
                if (playSound)
                    Game1.playSound("bigDeSelect");
                this.SendMessage();
            }

            // Focus text box if clicked
            this.inputTextBox.Selected = new Rectangle(this.inputTextBox.X, this.inputTextBox.Y, this.inputTextBox.Width, this.inputTextBox.Height).Contains(x, y);
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
            int messageAreaHeight = this.height - Padding * 2 - InputBoxHeight - MessageSpacing;
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
            int messageAreaY = this.yPositionOnScreen + Padding;
            int messageAreaWidth = this.width - Padding * 2;
            int messageAreaHeight = this.height - Padding * 2 - InputBoxHeight - MessageSpacing;
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
                // Calculate message dimensions
                string wrappedText = this.WrapText(message.Text, bubbleMaxWidth - MessagePadding * 2, Game1.smallFont);
                Vector2 textSize = Game1.smallFont.MeasureString(wrappedText);
                int bubbleHeight = (int)textSize.Y + MessagePadding * 2;
                int bubbleWidth = Math.Min(bubbleMaxWidth, (int)textSize.X + MessagePadding * 2);

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

            // Draw send button
            this.sendButton.draw(b);

            // Draw scroll indicator if needed
            int totalMessagesHeight = this.CalculateTotalMessagesHeight();
            int visibleAreaHeight = this.height - Padding * 2 - InputBoxHeight - MessageSpacing;
            if (totalMessagesHeight > visibleAreaHeight)
            {
                float scrollPercentage = (float)this.scrollOffset / (totalMessagesHeight - visibleAreaHeight);
                string scrollText = $"↑↓ {(int)(scrollPercentage * 100)}%";
                Utility.drawTextWithShadow(
                    b,
                    scrollText,
                    Game1.smallFont,
                    new Vector2(this.xPositionOnScreen + this.width - Padding - 80, this.yPositionOnScreen + Padding),
                    Color.Gray
                );
            }

            // Draw mouse cursor
            this.drawMouse(b);
        }

        /// <summary>Wrap text to fit within a specified width.</summary>
        private string WrapText(string text, int maxWidth, SpriteFont font)
        {
            string[] words = text.Split(' ');
            StringBuilder result = new StringBuilder();
            StringBuilder currentLine = new StringBuilder();

            foreach (string word in words)
            {
                string testLine = currentLine.Length == 0 ? word : $"{currentLine} {word}";
                if (font.MeasureString(testLine).X > maxWidth)
                {
                    if (currentLine.Length > 0)
                    {
                        result.AppendLine(currentLine.ToString());
                        currentLine.Clear();
                    }
                    currentLine.Append(word);
                }
                else
                {
                    if (currentLine.Length > 0)
                        currentLine.Append(" ");
                    currentLine.Append(word);
                }
            }

            if (currentLine.Length > 0)
                result.Append(currentLine.ToString());

            return result.ToString();
        }

        /// <summary>Calculate the total height of all messages.</summary>
        private int CalculateTotalMessagesHeight()
        {
            int totalHeight = 0;
            int messageAreaWidth = this.width - Padding * 2;
            int bubbleMaxWidth = messageAreaWidth / 2 - MessageSpacing;

            foreach (var message in this.chatHistory)
            {
                string wrappedText = this.WrapText(message.Text, bubbleMaxWidth - MessagePadding * 2, Game1.smallFont);
                Vector2 textSize = Game1.smallFont.MeasureString(wrappedText);
                int bubbleHeight = (int)textSize.Y + MessagePadding * 2;

                totalHeight += bubbleHeight + MessageSpacing;
            }

            return totalHeight;
        }
    }

    /// <summary>Represents a chat message.</summary>
    public class ChatMessage
    {
        public string Text { get; set; } = "";
        public bool IsUser { get; set; }
        public DateTime Timestamp { get; set; }
    }
}
