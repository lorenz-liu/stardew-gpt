using StardewModdingAPI;

namespace StardewGPT
{
    /// <summary>The mod configuration.</summary>
    public class ModConfig
    {
        /// <summary>The Cloudflare account ID.</summary>
        public string CloudflareAccountId { get; set; } = "your-cloudflare-account-id";

        /// <summary>The Cloudflare API token (used for both LLM and embeddings).</summary>
        public string ApiKey { get; set; } = "your-cloudflare-api-token";

        /// <summary>The API endpoint for chat completions.</summary>
        public string ApiEndpoint { get; set; } = "https://api.cloudflare.com/client/v4/accounts/{account_id}/ai/run/@cf/meta/llama-3.1-8b-instruct";

        /// <summary>The model to use for chat completions.</summary>
        public string Model { get; set; } = "@cf/meta/llama-3.1-8b-instruct";

        /// <summary>Maximum tokens for response.</summary>
        public int MaxTokens { get; set; } = 800;

        /// <summary>Temperature for response generation.</summary>
        public float Temperature { get; set; } = 0.3f;

        /// <summary>Reasoning effort for o1 models (low, medium, high).</summary>
        public string? ReasoningEffort { get; set; } = "medium";

        /// <summary>The keybind to open the chat menu.</summary>
        public SButton OpenChatKey { get; set; } = SButton.K;
    }
}
