# StardewGPT

> This project includes scraped data from [Stardew Valley Wiki](https://stardewvalleywiki.com/Stardew_Valley_Wiki), which is licensed under Attribution-NonCommercial-ShareAlike 3.0 Unported (CC BY-NC-SA 3.0). Consequently, this software and its source code are also licensed under CC BY-NC-SA 3.0. The source code is open sources at [GitHub](https://github.com/lorenz-liu/stardew-gpt).

StardewGPT is an in-game AI assistant for Stardew Valley, built with vector-based semantic search and powered by Cloudflare Workers AI. It can answer questions about the game and provide personalized advice based on your current game state. 

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

## Features

- 🤖 **Smart AI Assistant**: Powered by Llama 3.1 8B via Cloudflare Workers AI
- 🔍 **Semantic Search**: 170K+ wiki entries with vector-based retrieval
- 🎮 **Game-Aware**: Reads your current game state (inventory, skills, relationships, etc.)
- 💬 **Conversation History**: Remembers context across multiple questions
- 🌍 **Global Access**: Works worldwide

---

# 中文

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

## 功能特性

- 🤖 **智能 AI 助手**：由 Cloudflare Workers AI 提供的 Llama 3.1 8B 驱动
- 🔍 **语义搜索**：170K+ 维基条目，基于向量的检索
- 🎮 **游戏感知**：读取你当前的游戏状态（背包、技能、好感度等）
- 💬 **对话历史**：跨多个问题记住上下文
- 🌍 **全球访问**：全球直连可用，包括中国大陆
