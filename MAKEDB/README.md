# Vector Database Builder for StardewGPT

This directory contains tools to rebuild the vector database using the **bge-m3** model from Cloudflare Workers AI, which provides multilingual support with 1024-dimensional embeddings.

## Overview

The original database used `bge-base-en-v1.5` (768 dimensions, English-only). This rebuild uses `@cf/baai/bge-m3` (1024 dimensions, multilingual) for better semantic search across multiple languages.

### Key Changes

- **Model**: `@cf/baai/bge-base-en-v1.5` → `@cf/baai/bge-m3`
- **Dimensions**: 768 → 1024 (no dimension reduction)
- **Language Support**: English-only → Multilingual
- **Vector Storage**: 1024 bytes → 4096 bytes per entry

## Prerequisites

1. **Python 3.8+**
2. **Cloudflare Account** with Workers AI enabled
3. **API Credentials**:
   - Cloudflare Account ID
   - Cloudflare API Key

## Installation

Install Python dependencies:

```bash
pip install -r requirements.txt
```

## Usage

### Step 1: Scrape Wiki Data

Download Stardew Valley Wiki content:

```bash
python scrape_wiki.py --output-dir wiki_data --output-file wiki_data.json
```

**Options**:
- `--mode all`: Scrape all wiki pages (default)
- `--mode categories`: Scrape specific categories
- `--categories`: List of categories to scrape (for categories mode)

**Example (specific categories)**:
```bash
python scrape_wiki.py \
  --mode categories \
  --categories "Crops" "NPCs" "Fishing" "Mining" "Cooking" \
  --output-file wiki_data.json
```

**Output**: `wiki_data/wiki_data.json`

### Step 2: Build Vector Database

Generate embeddings and build the database:

```bash
python build_database.py \
  --account-id YOUR_CLOUDFLARE_ACCOUNT_ID \
  --api-key YOUR_CLOUDFLARE_API_KEY \
  --source wiki_data/wiki_data.json \
  --output knowledge.db \
  --batch-size 100
```

**Options**:
- `--account-id`: Cloudflare account ID (required)
- `--api-key`: Cloudflare API key (required)
- `--source`: Source data path (JSON file or markdown directory)
- `--output`: Output database path (default: `knowledge.db`)
- `--batch-size`: Batch size for database inserts (default: 100)
- `--source-type`: Source data type - `json` or `markdown` (default: `json`)

**Example (from markdown files)**:
```bash
python build_database.py \
  --account-id YOUR_ACCOUNT_ID \
  --api-key YOUR_API_KEY \
  --source ../KnowledgeBase \
  --source-type markdown \
  --output knowledge.db
```

### Step 3: Replace Database

Copy the new database to the mod directory:

```bash
cp knowledge.db ../knowledge.db
```

Or for the build output:

```bash
cp knowledge.db ../bin/Debug/net6.0/knowledge.db
```

## Database Schema

```sql
CREATE TABLE wiki_data (
    id INTEGER PRIMARY KEY AUTOINCREMENT,
    title TEXT NOT NULL,
    content TEXT NOT NULL,
    vector BLOB NOT NULL  -- 1024 floats = 4096 bytes
);

CREATE INDEX idx_title ON wiki_data(title);
```

## Source Data Format

### JSON Format

```json
[
  {
    "title": "Parsnip",
    "content": "Parsnip is a crop in Stardew Valley..."
  },
  {
    "title": "Haley",
    "content": "Haley is a villager who lives in Pelican Town..."
  }
]
```

### Markdown Format

Place `.md` files in a directory. The filename (without extension) will be used as the title, and the file content as the content.

```
KnowledgeBase/
├── Parsnip.md
├── Haley.md
└── Fishing.md
```

## Performance Considerations

### Embedding Generation

- **Rate Limiting**: 0.1 second delay between requests
- **Retry Logic**: 3 attempts with exponential backoff
- **Batch Processing**: Configurable batch size for database inserts

### Estimated Time

For 170,000 wiki entries:
- Scraping: ~2-3 hours (with rate limiting)
- Embedding generation: ~5-6 hours (0.1s per entry)
- Database optimization: ~5-10 minutes

### Cost Estimation

Cloudflare Workers AI pricing (as of 2026):
- Free tier: 10,000 requests/day
- Paid tier: $0.011 per 1,000 requests

For 170,000 entries:
- Free tier: ~17 days
- Paid tier: ~$1.87

## Troubleshooting

### API Rate Limiting

If you encounter rate limiting errors:
1. Increase the delay in `get_embeddings_batch()` (line 62 in `build_database.py`)
2. Reduce batch size with `--batch-size` parameter

### Memory Issues

For large datasets:
1. Process in smaller batches
2. Split source data into multiple files
3. Build multiple databases and merge them

### Invalid Embeddings

If embeddings have incorrect dimensions:
1. Verify the model name: `@cf/baai/bge-m3`
2. Check API response format
3. Ensure Cloudflare Workers AI supports bge-m3

## Integration with StardewGPT

After building the database, update the following files:

1. **Services/EmbeddingClient.cs**: Change model to `@cf/baai/bge-m3`
2. **Services/VectorDatabaseService.cs**: Update vector dimension to 1024

See the main README for detailed integration instructions.

## License

This tool is for educational purposes. Stardew Valley Wiki content is licensed under CC BY-NC-SA 3.0.

## References

- [Cloudflare Workers AI Documentation](https://developers.cloudflare.com/workers-ai/)
- [BGE-M3 Model](https://huggingface.co/BAAI/bge-m3)
- [Stardew Valley Wiki](https://stardewvalleywiki.com/)
