# StardewGPT

> This project includes scraped data from [Stardew Valley Wiki](https://stardewvalleywiki.com/Stardew_Valley_Wiki), which is licensed under Attribution-NonCommercial-ShareAlike 3.0 Unported (CC BY-NC-SA 3.0). Consequently, this software and its source code are also licensed under CC BY-NC-SA 3.0. The source code is open sources at [GitHub](https://github.com/lorenz-liu/stardew-gpt).

StardewGPT is an in-game chatbot for Stardew Valley, built with vector-based semantic search. It can answer questions about the game and provide personalized advice based on your current game state.

## Quick Start

**Important: Configure your Cloudflare API credentials in `config.json`!**

```json
{
  "CloudflareAccountId": "YOUR_CLOUDFLARE_ACCOUNT_ID",
  "ApiKey": "YOUR_CLOUDFLARE_API_TOKEN",
  "ApiEndpoint": "https://api.cloudflare.com/client/v4/accounts/{account_id}/ai/run/@cf/meta/llama-3.1-8b-instruct",
  "Model": "@cf/meta/llama-3.1-8b-instruct",
  "MaxTokens": 800,
  "Temperature": 0.3,
  "OpenChatKey": "K"
}
```

### How to Get Cloudflare API Credentials (Free!)

1. **Sign up for Cloudflare**: Go to [dash.cloudflare.com](https://dash.cloudflare.com/sign-up) and create a free account
2. **Get your Account ID**:
   - Go to [Workers & Pages](https://dash.cloudflare.com/?to=/:account/workers-and-pages)
   - Your Account ID is shown on the right side of the page
3. **Create an API Token**:
   - Go to [API Tokens](https://dash.cloudflare.com/profile/api-tokens)
   - Click "Create Token"
   - Use the "Edit Cloudflare Workers" template or create a custom token with "Workers AI" permissions
   - Copy the token (you won't be able to see it again!)

**Why Cloudflare?**
- ✅ **Free tier**: 10,000 requests per day
- ✅ **Global availability**: Works in China and worldwide
- ✅ **Single API key**: One token for both LLM and embeddings
- ✅ **Fast**: Powered by Cloudflare's global network

## Example Questions

* "Do I have anything in my inventory that matches Abigail's taste of gift?"
* "What are the most lucrative crops to farm in Summer?"
* "How to catch pufferfishes?"
* "When can I harvest my hops?"
* "Where to find dust sprites?"

or simply:
* "What should I do today?"

## Project Structure

```
├── ModEntry.cs              # Main mod entry point, initializes services
├── ModConfig.cs             # Configuration model for mod settings
├── manifest.json            # SMAPI mod manifest
├── config.json.example      # Example API configuration template
├── StardewGPT.csproj        # C# project file
├── knowledge.db             # Merged vector database (CN+EN)
├── knowledge_cn.db          # Chinese wiki vector database
├── knowledge_en.db          # English wiki vector database
├── Services/                # Core service implementations
│   ├── AIClient.cs          # Cloudflare AI API client
│   ├── EmbeddingClient.cs   # Text embedding generation
│   ├── VectorDatabaseService.cs  # SQLite vector search
│   ├── RAGOrchestrator.cs   # RAG pipeline coordinator
│   ├── GameDataExtractor.cs # Extracts current game state
│   ├── ChatHistoryManager.cs # Manages conversation context
│   └── SQLiteNative.cs      # Native SQLite bindings
├── UI/
│   └── ChatTab.cs           # In-game chat interface
├── DataTypes/
│   └── ChatMessage.cs       # Chat message data model
├── MAKEDB/                  # Database building tools
│   ├── scrape_wiki_en.py    # Scrapes English wiki
│   ├── scrape_wiki_cn.py    # Scrapes Chinese wiki
│   ├── build_database.py    # Builds vector database
│   ├── merge_db.py          # Merges CN+EN databases
│   ├── build_en.sh          # Build script for EN
│   ├── build_cn.sh          # Build script for CN
│   └── config.env.example   # Environment config template
├── i18n/                    # Localization files
│   ├── default.json         # English translations
│   └── zh.json              # Chinese translations
└── runtimes/                # Native SQLite libraries
```

---

# 中文

StardewGPT 是《星露谷物语》的游戏内聊天机器人，基于向量语义搜索构建。它可以回答关于游戏的问题，并根据你当前的游戏数据及状态提供个性化建议。

## 快速开始

**重要：在 `config.json` 中配置你的 Cloudflare API 凭证！**

```json
{
  "CloudflareAccountId": "你的_CLOUDFLARE_账户ID",
  "ApiKey": "你的_CLOUDFLARE_API令牌",
  "ApiEndpoint": "https://api.cloudflare.com/client/v4/accounts/{account_id}/ai/run/@cf/meta/llama-3.1-8b-instruct",
  "Model": "@cf/meta/llama-3.1-8b-instruct",
  "MaxTokens": 800,
  "Temperature": 0.3,
  "OpenChatKey": "K"
}
```

### 如何获取 Cloudflare API 凭证（免费！）

1. **注册 Cloudflare**：访问 [dash.cloudflare.com](https://dash.cloudflare.com/sign-up) 创建免费账户
2. **获取账户 ID**：
   - 进入 [Workers & Pages](https://dash.cloudflare.com/?to=/:account/workers-and-pages)
   - 你的账户 ID 显示在页面右侧
3. **创建 API 令牌**：
   - 进入 [API Tokens](https://dash.cloudflare.com/profile/api-tokens)
   - 点击 "Create Token"（创建令牌）
   - 使用 "Edit Cloudflare Workers" 模板或创建具有 "Workers AI" 权限的自定义令牌
   - 复制令牌（之后无法再次查看！）

**为什么选择 Cloudflare？**
- ✅ **免费额度**：每天 10,000 次请求
- ✅ **全球可用**：在中国和全球都能使用
- ✅ **单一密钥**：一个令牌同时用于 LLM 和向量嵌入
- ✅ **速度快**：由 Cloudflare 全球网络提供支持

## 示例问题

* "我的背包里有阿比盖尔喜欢的东西吗？"
* "夏天种什么最赚钱？"
* "怎么钓河豚？"
* "我的啤酒花什么时候能收获？"
* "在哪里能找到灰尘精灵？"

或者直接：
* "我今天该做什么？"
