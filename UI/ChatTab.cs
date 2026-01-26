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
        private readonly int maxVisibleMessages = 8;
        private int scrollOffset = 0;
        private bool isWaitingForResponse = false;

        // UI Layout constants
        private const int Padding = 32;
        private const int InputBoxHeight = 48;
        private const int ButtonWidth = 100;
        private const int MessageSpacing = 16;
        private const int MessageHeight = 80;

        public ChatTab(int xPositionOnScreen, int yPositionOnScreen, int width, int height)
            : base(xPositionOnScreen, yPositionOnScreen, width, height, showUpperRightCloseButton: false)
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
            this.scrollOffset = Math.Max(0, this.chatHistory.Count - this.maxVisibleMessages);
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
                // TODO: Call RAG system here
                // For now, just show a placeholder response
                await System.Threading.Tasks.Task.Delay(1000); // Simulate API call

                // Remove loading message
                this.chatHistory.RemoveAt(this.chatHistory.Count - 1);

                // Add AI response
                string response = "This is a placeholder response. RAG system will be implemented next.";
                this.AddMessage(response, isUser: false);
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
            this.inputTextBox.Selected = this.inputTextBox.bounds.Contains(x, y);
        }

        public override void receiveKeyPress(Keys key)
        {
            // Handle Enter key to send message
            if (key == Keys.Enter && this.inputTextBox.Selected)
            {
                this.SendMessage();
                return;
            }

            // Pass other keys to text box
            if (this.inputTextBox.Selected)
            {
                this.inputTextBox.RecieveTextInput(key);
            }

            base.receiveKeyPress(key);
        }

        public override void receiveScrollWheelAction(int direction)
        {
            base.receiveScrollWheelAction(direction);

            // Scroll chat history
            if (direction > 0)
            {
                this.scrollOffset = Math.Max(0, this.scrollOffset - 1);
            }
            else if (direction < 0)
            {
                this.scrollOffset = Math.Min(
                    Math.Max(0, this.chatHistory.Count - this.maxVisibleMessages),
                    this.scrollOffset + 1
                );
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

            // Draw title
            string title = ModEntry.I18n!.Get("tab.title");
            SpriteText.drawStringHorizontallyCenteredAt(
                b,
                title,
                this.xPositionOnScreen + this.width / 2,
                this.yPositionOnScreen + Padding
            );

            // Draw chat messages
            int messageY = this.yPositionOnScreen + Padding + 64;
            int messageAreaHeight = this.height - Padding * 3 - InputBoxHeight - 64;
            int visibleMessages = Math.Min(this.maxVisibleMessages, this.chatHistory.Count);

            for (int i = 0; i < visibleMessages; i++)
            {
                int messageIndex = this.scrollOffset + i;
                if (messageIndex >= this.chatHistory.Count)
                    break;

                var message = this.chatHistory[messageIndex];
                int currentY = messageY + i * (MessageHeight + MessageSpacing);

                // Draw message bubble
                Color bubbleColor = message.IsUser ? new Color(100, 150, 255, 200) : new Color(200, 200, 200, 200);
                int bubbleX = message.IsUser
                    ? this.xPositionOnScreen + this.width / 2
                    : this.xPositionOnScreen + Padding;
                int bubbleWidth = this.width / 2 - Padding * 2;

                // Draw bubble background
                IClickableMenu.drawTextureBox(
                    b,
                    Game1.menuTexture,
                    new Rectangle(0, 256, 60, 60),
                    bubbleX,
                    currentY,
                    bubbleWidth,
                    MessageHeight,
                    bubbleColor,
                    1f,
                    false
                );

                // Draw message text (word-wrapped)
                string wrappedText = this.WrapText(message.Text, bubbleWidth - 16, Game1.smallFont);
                Utility.drawTextWithShadow(
                    b,
                    wrappedText,
                    Game1.smallFont,
                    new Vector2(bubbleX + 8, currentY + 8),
                    Game1.textColor
                );
            }

            // Draw input box
            this.inputTextBox.Draw(b);

            // Draw send button
            this.sendButton.draw(b);

            // Draw button label
            string buttonText = ModEntry.I18n!.Get("chat.send");
            Utility.drawTextWithShadow(
                b,
                buttonText,
                Game1.smallFont,
                new Vector2(
                    this.sendButton.bounds.X + (this.sendButton.bounds.Width - Game1.smallFont.MeasureString(buttonText).X) / 2,
                    this.sendButton.bounds.Y + (this.sendButton.bounds.Height - Game1.smallFont.MeasureString(buttonText).Y) / 2
                ),
                this.isWaitingForResponse ? Color.Gray : Game1.textColor
            );

            // Draw scroll indicator if needed
            if (this.chatHistory.Count > this.maxVisibleMessages)
            {
                string scrollText = $"↑↓ {this.scrollOffset + 1}-{Math.Min(this.scrollOffset + this.maxVisibleMessages, this.chatHistory.Count)}/{this.chatHistory.Count}";
                Utility.drawTextWithShadow(
                    b,
                    scrollText,
                    Game1.smallFont,
                    new Vector2(this.xPositionOnScreen + this.width - Padding - 100, this.yPositionOnScreen + Padding),
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
    }

    /// <summary>Represents a chat message.</summary>
    public class ChatMessage
    {
        public string Text { get; set; } = "";
        public bool IsUser { get; set; }
        public DateTime Timestamp { get; set; }
    }
}
