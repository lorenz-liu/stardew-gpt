#!/usr/bin/env python3
"""
Vector Database Builder for StardewGPT
Uses Cloudflare Workers AI with bge-m3 model for multilingual embeddings.
"""

import os
import sys
import json
import sqlite3
import struct
import time
import argparse
from pathlib import Path
from typing import List, Tuple, Optional
import requests
from tqdm import tqdm


class BGEm3EmbeddingClient:
    """Client for Cloudflare Workers AI using bge-m3 model (1024 dimensions)."""

    def __init__(self, account_id: str, api_key: str):
        self.account_id = account_id
        self.api_key = api_key
        self.model = "@cf/baai/bge-m3"
        self.dimension = 1024
        self.base_url = f"https://api.cloudflare.com/client/v4/accounts/{account_id}/ai/run/{self.model}"
        self.session = requests.Session()
        self.session.headers.update({
            "Authorization": f"Bearer {api_key}",
            "Content-Type": "application/json"
        })

    def get_embedding(self, text: str, retry_count: int = 3) -> Optional[List[float]]:
        """Get 1024-dimensional embedding from bge-m3 model."""
        # Preprocess text
        text = self._preprocess_text(text)

        if not text:
            print("Warning: Empty text after preprocessing")
            return None

        for attempt in range(retry_count):
            try:
                payload = {"text": [text]}
                response = self.session.post(self.base_url, json=payload, timeout=30)

                if response.status_code == 200:
                    data = response.json()
                    embedding = data.get("result", {}).get("data", [[]])[0]

                    if len(embedding) != self.dimension:
                        print(f"Warning: Expected {self.dimension} dimensions, got {len(embedding)}")
                        return None

                    return embedding
                else:
                    print(f"API Error (attempt {attempt + 1}/{retry_count}): {response.status_code} - {response.text[:200]}")
                    if attempt < retry_count - 1:
                        time.sleep(2 ** attempt)  # Exponential backoff

            except Exception as e:
                print(f"Exception (attempt {attempt + 1}/{retry_count}): {str(e)}")
                if attempt < retry_count - 1:
                    time.sleep(2 ** attempt)

        return None

    def _preprocess_text(self, text: str) -> str:
        """Preprocess text for embedding."""
        # Remove null bytes and other problematic characters
        text = text.replace('\x00', '').replace('\r', ' ')

        # Normalize whitespace
        text = ' '.join(text.split())

        # Truncate to max length (bge-m3 supports up to 8192 tokens, ~32k chars)
        # Use conservative limit of 10k chars to be safe
        max_chars = 10000
        if len(text) > max_chars:
            text = text[:max_chars] + "..."

        return text.strip()

    def get_embeddings_batch(self, texts: List[str], batch_size: int = 10) -> List[Optional[List[float]]]:
        """Get embeddings for multiple texts with rate limiting."""
        embeddings = []

        for i in tqdm(range(0, len(texts), batch_size), desc="Generating embeddings"):
            batch = texts[i:i + batch_size]

            for text in batch:
                embedding = self.get_embedding(text)
                embeddings.append(embedding)
                time.sleep(0.1)  # Rate limiting

        return embeddings


class VectorDatabaseBuilder:
    """Builds SQLite vector database with bge-m3 embeddings."""

    def __init__(self, db_path: str, embedding_client: BGEm3EmbeddingClient):
        self.db_path = db_path
        self.embedding_client = embedding_client
        self.conn = None

    def initialize_database(self):
        """Create database and table schema."""
        self.conn = sqlite3.connect(self.db_path)
        cursor = self.conn.cursor()

        # Drop existing table if it exists
        cursor.execute("DROP TABLE IF EXISTS wiki_data")

        # Create table with 1024-dimensional vector storage
        cursor.execute("""
            CREATE TABLE wiki_data (
                id INTEGER PRIMARY KEY AUTOINCREMENT,
                title TEXT NOT NULL,
                content TEXT NOT NULL,
                vector BLOB NOT NULL
            )
        """)

        # Create index on title for faster lookups
        cursor.execute("CREATE INDEX idx_title ON wiki_data(title)")

        self.conn.commit()
        print(f"Database initialized at {self.db_path}")

    def vector_to_blob(self, vector: List[float]) -> bytes:
        """Convert float vector to binary blob (1024 floats = 4096 bytes)."""
        return struct.pack(f'{len(vector)}f', *vector)

    def insert_entry(self, title: str, content: str, vector: List[float]):
        """Insert a single entry into the database."""
        if len(vector) != 1024:
            raise ValueError(f"Expected 1024-dimensional vector, got {len(vector)}")

        cursor = self.conn.cursor()
        vector_blob = self.vector_to_blob(vector)

        cursor.execute(
            "INSERT INTO wiki_data (title, content, vector) VALUES (?, ?, ?)",
            (title, content, vector_blob)
        )

    def insert_entries_batch(self, entries: List[Tuple[str, str, List[float]]]):
        """Insert multiple entries in a batch."""
        cursor = self.conn.cursor()

        data = []
        for title, content, vector in entries:
            if vector is None or len(vector) != 1024:
                print(f"Skipping entry '{title}' due to invalid vector")
                continue

            vector_blob = self.vector_to_blob(vector)
            data.append((title, content, vector_blob))

        cursor.executemany(
            "INSERT INTO wiki_data (title, content, vector) VALUES (?, ?, ?)",
            data
        )
        self.conn.commit()
        print(f"Inserted {len(data)} entries")

    def finalize(self):
        """Finalize database and close connection."""
        if self.conn:
            cursor = self.conn.cursor()
            cursor.execute("SELECT COUNT(*) FROM wiki_data")
            count = cursor.fetchone()[0]
            print(f"Database finalized with {count} entries")

            # Optimize database
            cursor.execute("VACUUM")
            self.conn.commit()
            self.conn.close()
            print(f"Database optimized and saved to {self.db_path}")


def load_wiki_data_from_json(json_path: str) -> List[Tuple[str, str]]:
    """Load wiki data from JSON file."""
    with open(json_path, 'r', encoding='utf-8') as f:
        data = json.load(f)

    entries = []
    for item in data:
        title = item.get('title', '').strip()
        content = item.get('content', '').strip()

        if title and content:
            entries.append((title, content))

    print(f"Loaded {len(entries)} entries from {json_path}")
    return entries


def load_wiki_data_from_markdown(markdown_dir: str) -> List[Tuple[str, str]]:
    """Load wiki data from markdown files."""
    markdown_path = Path(markdown_dir)
    entries = []

    for md_file in markdown_path.rglob("*.md"):
        try:
            with open(md_file, 'r', encoding='utf-8') as f:
                content = f.read().strip()

            # Use filename (without extension) as title
            title = md_file.stem

            if content:
                entries.append((title, content))

        except Exception as e:
            print(f"Error reading {md_file}: {str(e)}")

    print(f"Loaded {len(entries)} entries from {markdown_dir}")
    return entries


def main():
    parser = argparse.ArgumentParser(description="Build vector database with bge-m3 embeddings")
    parser.add_argument("--account-id", required=True, help="Cloudflare account ID")
    parser.add_argument("--api-key", required=True, help="Cloudflare API key")
    parser.add_argument("--source", required=True, help="Source data path (JSON file or markdown directory)")
    parser.add_argument("--output", default="knowledge.db", help="Output database path")
    parser.add_argument("--batch-size", type=int, default=100, help="Batch size for database inserts")
    parser.add_argument("--source-type", choices=["json", "markdown"], default="json", help="Source data type")

    args = parser.parse_args()

    # Initialize embedding client
    print("Initializing bge-m3 embedding client...")
    embedding_client = BGEm3EmbeddingClient(args.account_id, args.api_key)

    # Load source data
    print(f"Loading source data from {args.source}...")
    if args.source_type == "json":
        entries = load_wiki_data_from_json(args.source)
    else:
        entries = load_wiki_data_from_markdown(args.source)

    if not entries:
        print("No entries found in source data!")
        sys.exit(1)

    # Initialize database
    print("Initializing database...")
    db_builder = VectorDatabaseBuilder(args.output, embedding_client)
    db_builder.initialize_database()

    # Process entries in batches
    print(f"Processing {len(entries)} entries...")
    batch = []

    for i, (title, content) in enumerate(entries):
        # Show progress
        print(f"[{i + 1}/{len(entries)}] Processing: {title} ({len(content)} chars)")

        # Generate embedding
        embedding = embedding_client.get_embedding(content)

        if embedding:
            batch.append((title, content, embedding))
            print(f"  ✓ Embedding generated successfully")
        else:
            print(f"  ✗ Failed to generate embedding for '{title}'")

        # Insert batch when full
        if len(batch) >= args.batch_size:
            db_builder.insert_entries_batch(batch)
            batch = []

        # Progress update
        if (i + 1) % 100 == 0:
            print(f"Processed {i + 1}/{len(entries)} entries")

    # Insert remaining entries
    if batch:
        db_builder.insert_entries_batch(batch)

    # Finalize database
    db_builder.finalize()
    print("Database build complete!")


if __name__ == "__main__":
    main()
