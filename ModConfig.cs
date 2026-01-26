namespace StardewGPT
{
    /// <summary>The mod configuration.</summary>
    public class ModConfig
    {
        /// <summary>The DeepSeek API endpoint.</summary>
        public string ApiEndpoint { get; set; } = "https://api.deepseek.com/v1/chat/completions";

        /// <summary>The DeepSeek API key.</summary>
        public string ApiKey { get; set; } = "your-api-key-here";

        /// <summary>The model to use.</summary>
        public string Model { get; set; } = "deepseek-chat";

        /// <summary>Maximum tokens for response.</summary>
        public int MaxTokens { get; set; } = 500;

        /// <summary>Temperature for response generation.</summary>
        public float Temperature { get; set; } = 0.7f;
    }
}
