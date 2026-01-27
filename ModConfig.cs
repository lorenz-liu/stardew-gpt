using StardewModdingAPI;

namespace StardewGPT
{
    /// <summary>The mod configuration.</summary>
    public class ModConfig
    {
        /// <summary>The API endpoint.</summary>
        public string ApiEndpoint { get; set; } = "https://api.groq.com/openai/v1/chat/completions";

        /// <summary>The API key.</summary>
        public string ApiKey { get; set; } = "your-api-key-here";

        /// <summary>The model to use.</summary>
        public string Model { get; set; } = "openai/gpt-oss-120b";

        /// <summary>Maximum tokens for response.</summary>
        public int MaxTokens { get; set; } = 500;

        /// <summary>Temperature for response generation.</summary>
        public float Temperature { get; set; } = 0.7f;

        /// <summary>Reasoning effort for o1 models (low, medium, high).</summary>
        public string? ReasoningEffort { get; set; } = "medium";

        /// <summary>The keybind to open the chat menu.</summary>
        public SButton OpenChatKey { get; set; } = SButton.K;
    }
}
