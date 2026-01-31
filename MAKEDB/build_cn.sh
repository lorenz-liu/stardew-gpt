#!/bin/bash
# Quick start script for building the Chinese vector database

set -e

echo "==================================="
echo "StardewGPT 中文向量数据库构建器"
echo "==================================="
echo ""

# Check if Python is installed
if ! command -v python3 &> /dev/null; then
    echo "Error: Python 3 is not installed"
    exit 1
fi

# Check if config file exists
if [ ! -f "config.env" ]; then
    echo "Creating config.env template..."
    cat > config.env << 'EOF'
# Cloudflare API Configuration
CLOUDFLARE_ACCOUNT_ID=your_account_id_here
CLOUDFLARE_API_KEY=your_api_key_here
EOF
    echo "Please edit config.env with your Cloudflare credentials"
    exit 1
fi

# Load configuration
source config.env

if [ "$CLOUDFLARE_ACCOUNT_ID" = "your_account_id_here" ] || [ "$CLOUDFLARE_API_KEY" = "your_api_key_here" ]; then
    echo "Error: Please configure your Cloudflare credentials in config.env"
    exit 1
fi

# Install dependencies
echo "Installing Python dependencies..."
pip3 install -r requirements.txt

# Step 1: Scrape Chinese wiki data
if [ ! -f "wiki_data_cn/wiki_data_cn.json" ]; then
    echo ""
    echo "Step 1: Scraping Stardew Valley Chinese Wiki..."
    python3 scrape_wiki_cn.py --output-dir wiki_data_cn --output-file wiki_data_cn.json
else
    echo ""
    echo "Step 1: Chinese wiki data already exists (wiki_data_cn/wiki_data_cn.json)"
    read -p "Do you want to re-scrape? (y/N): " -n 1 -r
    echo
    if [[ $REPLY =~ ^[Yy]$ ]]; then
        python3 scrape_wiki_cn.py --output-dir wiki_data_cn --output-file wiki_data_cn.json
    fi
fi

# Step 2: Build Chinese database
echo ""
echo "Step 2: Building Chinese vector database with bge-m3..."
python3 build_database.py \
    --account-id "$CLOUDFLARE_ACCOUNT_ID" \
    --api-key "$CLOUDFLARE_API_KEY" \
    --source wiki_data_cn/wiki_data_cn.json \
    --output knowledge_cn.db \
    --batch-size 100

# Step 3: Copy to parent directory
echo ""
echo "Step 3: Copying Chinese database to mod directory..."
cp knowledge_cn.db ../knowledge_cn.db
echo "Chinese database copied to ../knowledge_cn.db"

echo ""
echo "==================================="
echo "Chinese database build complete!"
echo "==================================="
echo ""
echo "Next steps:"
echo "1. Rebuild the StardewGPT mod"
echo "2. The new Chinese database will be used automatically"
echo ""
