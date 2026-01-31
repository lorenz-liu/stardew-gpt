#!/usr/bin/env python3
"""
Database Merger for StardewGPT
Merges knowledge_en.db and knowledge_cn.db into a single knowledge.db
"""

import os
import sys
import sqlite3
import argparse
from pathlib import Path


def merge_databases(db_en_path: str, db_cn_path: str, output_path: str):
    """Merge two SQLite databases into one."""

    # Check if input databases exist
    if not os.path.exists(db_en_path):
        print(f"Error: English database not found at {db_en_path}")
        sys.exit(1)

    if not os.path.exists(db_cn_path):
        print(f"Error: Chinese database not found at {db_cn_path}")
        sys.exit(1)

    print("=" * 50)
    print("StardewGPT Database Merger")
    print("=" * 50)
    print()

    # Remove output database if it exists
    if os.path.exists(output_path):
        print(f"Removing existing output database: {output_path}")
        os.remove(output_path)

    # Create new merged database
    print(f"Creating merged database: {output_path}")
    conn_out = sqlite3.connect(output_path)
    cursor_out = conn_out.cursor()

    # Create table schema
    cursor_out.execute("""
        CREATE TABLE wiki_data (
            id INTEGER PRIMARY KEY AUTOINCREMENT,
            title TEXT NOT NULL,
            content TEXT NOT NULL,
            vector BLOB NOT NULL
        )
    """)

    # Create index
    cursor_out.execute("CREATE INDEX idx_title ON wiki_data(title)")
    conn_out.commit()
    print("Created table schema")
    print()

    # Copy data from English database
    print(f"Copying data from English database: {db_en_path}")
    conn_en = sqlite3.connect(db_en_path)
    cursor_en = conn_en.cursor()

    cursor_en.execute("SELECT COUNT(*) FROM wiki_data")
    en_count = cursor_en.fetchone()[0]
    print(f"  Found {en_count} records in English database")

    cursor_en.execute("SELECT title, content, vector FROM wiki_data")
    en_records = cursor_en.fetchall()

    cursor_out.executemany(
        "INSERT INTO wiki_data (title, content, vector) VALUES (?, ?, ?)",
        en_records
    )
    conn_out.commit()
    print(f"  ✓ Copied {len(en_records)} records from English database")
    conn_en.close()
    print()

    # Copy data from Chinese database
    print(f"Copying data from Chinese database: {db_cn_path}")
    conn_cn = sqlite3.connect(db_cn_path)
    cursor_cn = conn_cn.cursor()

    cursor_cn.execute("SELECT COUNT(*) FROM wiki_data")
    cn_count = cursor_cn.fetchone()[0]
    print(f"  Found {cn_count} records in Chinese database")

    cursor_cn.execute("SELECT title, content, vector FROM wiki_data")
    cn_records = cursor_cn.fetchall()

    cursor_out.executemany(
        "INSERT INTO wiki_data (title, content, vector) VALUES (?, ?, ?)",
        cn_records
    )
    conn_out.commit()
    print(f"  ✓ Copied {len(cn_records)} records from Chinese database")
    conn_cn.close()
    print()

    # Verify merged database
    cursor_out.execute("SELECT COUNT(*) FROM wiki_data")
    total_count = cursor_out.fetchone()[0]

    print("=" * 50)
    print("Merge Summary")
    print("=" * 50)
    print(f"English records:  {en_count}")
    print(f"Chinese records:  {cn_count}")
    print(f"Total records:    {total_count}")
    print()

    # Optimize database
    print("Optimizing database...")
    cursor_out.execute("VACUUM")
    conn_out.commit()

    # Get file size
    file_size = os.path.getsize(output_path) / (1024 * 1024)  # Convert to MB
    print(f"Database size: {file_size:.2f} MB")
    print()

    conn_out.close()

    print("=" * 50)
    print("Database merge complete!")
    print("=" * 50)
    print(f"Merged database saved to: {output_path}")
    print()


def main():
    parser = argparse.ArgumentParser(description="Merge English and Chinese knowledge databases")
    parser.add_argument(
        "--en-db",
        default="../knowledge_en.db",
        help="Path to English database (default: ../knowledge_en.db)"
    )
    parser.add_argument(
        "--cn-db",
        default="../knowledge_cn.db",
        help="Path to Chinese database (default: ../knowledge_cn.db)"
    )
    parser.add_argument(
        "--output",
        default="../knowledge.db",
        help="Output path for merged database (default: ../knowledge.db)"
    )

    args = parser.parse_args()

    merge_databases(args.en_db, args.cn_db, args.output)


if __name__ == "__main__":
    main()
