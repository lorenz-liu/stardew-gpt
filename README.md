# Stardew GPT

An AI-powered assistant mod for Stardew Valley that answers your questions about the game using RAG (Retrieval-Augmented Generation) and DeepSeek LLM.

## Features

- **In-Game Chat Interface**: Press `E` to open the game menu, then navigate to the AI Assistant tab
- **Stardew Valley Expert**: Ask questions about farming, villagers, items, quests, and more
- **Multi-Language Support**: Automatically uses your game's language setting (English and Chinese supported)
- **Smart Context**: Uses RAG to retrieve relevant information from your game data and the Stardew Valley Wiki
- **Focused Responses**: Only answers Stardew Valley-related questions

## Installation

### Prerequisites

1. [SMAPI](https://smapi.io/) 3.18.0 or later
2. Stardew Valley 1.6 or later
3. .NET 6.0 SDK (for building from source)
4. DeepSeek API key

### Building from Source

1. Clone this repository:
   ```bash
   git clone https://github.com/yourusername/stardew-gpt.git
   cd stardew-gpt
   ```

2. Build the project:
   ```bash
   dotnet build
   ```

3. The compiled mod will be in `bin/Debug/net6.0/`

4. Copy the mod folder to your Stardew Valley `Mods` directory

### Configuration

1. After first launch, a `config.json` file will be created in the mod folder
2. Edit the config file and add your DeepSeek API key:
   ```json
   {
     "ApiEndpoint": "https://api.deepseek.com/v1/chat/completions",
     "ApiKey": "your-api-key-here",
     "Model": "deepseek-chat",
     "MaxTokens": 500,
     "Temperature": 0.7
   }
   ```

3. Get your API key from [DeepSeek](https://platform.deepseek.com/)

## Usage

1. Launch Stardew Valley with SMAPI
2. Press `E` to open the game menu
3. Click on the "AI Assistant" tab (rightmost tab)
4. Type your question in the text box and press Enter or click Send
5. The AI will respond with information about Stardew Valley

### Example Questions

- "When is Haley's birthday?"
- "How do I make a Quality Sprinkler?"
- "What crops are best for summer?"
- "Where can I find copper ore?"
- "How do I increase my friendship with villagers?"

### Non-Stardew Questions

If you ask a question unrelated to Stardew Valley (e.g., "Write me a quicksort algorithm"), the AI will politely decline and remind you it only knows about Stardew Valley.

## Development Status

### Completed
- ✅ Basic SMAPI mod structure
- ✅ Custom game menu tab
- ✅ Chat interface with input/output
- ✅ Multi-language support (English, Chinese)
- ✅ UI layout and design

### In Progress
- 🚧 RAG system integration
- 🚧 Game data extraction
- 🚧 Stardew Valley Wiki scraping
- 🚧 DeepSeek API integration
- 🚧 Context filtering for non-Stardew questions

### Planned
- 📋 Vector database for efficient retrieval
- 📋 Caching system for common questions
- 📋 More language support
- 📋 Custom icon and assets

## Technical Details

### Architecture

```
StardewGPT/
├── ModEntry.cs           # Main mod entry point
├── ModConfig.cs          # Configuration model
├── UI/
│   └── ChatTab.cs        # Chat interface UI
├── RAG/                  # (To be implemented)
│   ├── VectorStore.cs
│   ├── GameDataExtractor.cs
│   └── WikiScraper.cs
├── Services/             # (To be implemented)
│   └── DeepSeekClient.cs
└── i18n/
    ├── default.json      # English translations
    └── zh.json           # Chinese translations
```

### Technologies

- **SMAPI**: Stardew Valley modding framework
- **DeepSeek**: Large language model for generating responses
- **RAG**: Retrieval-Augmented Generation for accurate, context-aware answers
- **.NET 6.0**: Modern C# development

## Contributing

Contributions are welcome! Please feel free to submit issues or pull requests.

## License

See [LICENSE](LICENSE) file for details.

## Credits

- Developed by Lorenz Liu
- Powered by [DeepSeek](https://www.deepseek.com/)
- Built with [SMAPI](https://smapi.io/)
- Data from [Stardew Valley Wiki](https://stardewvalleywiki.com/)

## Disclaimer

This is a fan-made mod and is not affiliated with or endorsed by ConcernedApe or Stardew Valley.

