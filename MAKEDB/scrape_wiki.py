#!/usr/bin/env python3
"""
Stardew Valley Wiki Scraper
Downloads wiki pages and saves them as JSON for embedding.
"""

import os
import json
import time
import argparse
from pathlib import Path
from typing import List, Dict
import requests
from bs4 import BeautifulSoup
from tqdm import tqdm


class StardewWikiScraper:
    """Scraper for Stardew Valley Wiki."""

    def __init__(self, output_dir: str = "wiki_data"):
        self.base_url = "https://stardewvalleywiki.com"
        self.api_url = f"{self.base_url}/mediawiki/api.php"
        self.output_dir = Path(output_dir)
        self.output_dir.mkdir(exist_ok=True)
        self.session = requests.Session()
        self.session.headers.update({
            "User-Agent": "StardewGPT-WikiScraper/1.0 (Educational Purpose)"
        })

    def get_all_pages(self) -> List[str]:
        """Get list of all wiki pages using MediaWiki API."""
        pages = []
        apcontinue = None

        print("Fetching list of all wiki pages...")

        while True:
            params = {
                "action": "query",
                "list": "allpages",
                "aplimit": 500,
                "format": "json"
            }

            if apcontinue:
                params["apcontinue"] = apcontinue

            try:
                response = self.session.get(self.api_url, params=params, timeout=30)
                data = response.json()

                if "query" in data and "allpages" in data["query"]:
                    for page in data["query"]["allpages"]:
                        pages.append(page["title"])

                # Check for continuation
                if "continue" in data and "apcontinue" in data["continue"]:
                    apcontinue = data["continue"]["apcontinue"]
                else:
                    break

                time.sleep(0.1)  # Rate limiting

            except Exception as e:
                print(f"Error fetching page list: {str(e)}")
                break

        print(f"Found {len(pages)} wiki pages")
        return pages

    def get_page_content(self, title: str) -> Dict[str, str]:
        """Get page content using MediaWiki parse API."""
        params = {
            "action": "parse",
            "page": title,
            "prop": "text",
            "format": "json"
        }

        try:
            response = self.session.get(self.api_url, params=params, timeout=30)
            data = response.json()

            # Check for errors
            if "error" in data:
                return None

            # Extract HTML content
            if "parse" in data and "text" in data["parse"]:
                html_content = data["parse"]["text"]["*"]

                # Parse HTML and extract text
                soup = BeautifulSoup(html_content, 'html.parser')

                # Remove script and style elements
                for script in soup(["script", "style"]):
                    script.decompose()

                # Get text and clean it up
                text = soup.get_text()

                # Clean up whitespace
                lines = (line.strip() for line in text.splitlines())
                chunks = (phrase.strip() for line in lines for phrase in line.split("  "))
                text = ' '.join(chunk for chunk in chunks if chunk)

                if text:
                    return {
                        "title": title,
                        "content": text
                    }

        except Exception as e:
            print(f"Error fetching page '{title}': {str(e)}")

        return None

    def scrape_all_pages(self, output_file: str = "wiki_data.json"):
        """Scrape all wiki pages and save to JSON."""
        pages = self.get_all_pages()

        if not pages:
            print("No pages found!")
            return

        wiki_data = []
        failed_pages = []

        print(f"Scraping {len(pages)} pages...")

        for title in tqdm(pages, desc="Scraping pages"):
            page_data = self.get_page_content(title)

            if page_data and page_data["content"]:
                wiki_data.append(page_data)
            else:
                failed_pages.append(title)

            time.sleep(0.1)  # Rate limiting

        # Save to JSON
        output_path = self.output_dir / output_file
        with open(output_path, 'w', encoding='utf-8') as f:
            json.dump(wiki_data, f, ensure_ascii=False, indent=2)

        print(f"Scraped {len(wiki_data)} pages successfully")
        print(f"Failed to scrape {len(failed_pages)} pages")
        print(f"Data saved to {output_path}")

        # Save failed pages list
        if failed_pages:
            failed_path = self.output_dir / "failed_pages.txt"
            with open(failed_path, 'w', encoding='utf-8') as f:
                f.write('\n'.join(failed_pages))
            print(f"Failed pages list saved to {failed_path}")

    def scrape_specific_categories(self, categories: List[str], output_file: str = "wiki_data.json"):
        """Scrape pages from specific categories."""
        all_pages = []

        for category in categories:
            print(f"Fetching pages from category: {category}")
            pages = self.get_category_pages(category)
            all_pages.extend(pages)

        # Remove duplicates
        all_pages = list(set(all_pages))
        print(f"Found {len(all_pages)} unique pages across all categories")

        # Scrape pages
        wiki_data = []
        for title in tqdm(all_pages, desc="Scraping pages"):
            page_data = self.get_page_content(title)

            if page_data and page_data["content"]:
                wiki_data.append(page_data)

            time.sleep(0.1)

        # Save to JSON
        output_path = self.output_dir / output_file
        with open(output_path, 'w', encoding='utf-8') as f:
            json.dump(wiki_data, f, ensure_ascii=False, indent=2)

        print(f"Scraped {len(wiki_data)} pages from categories")
        print(f"Data saved to {output_path}")

    def get_category_pages(self, category: str) -> List[str]:
        """Get all pages in a category."""
        pages = []
        cmcontinue = None

        while True:
            params = {
                "action": "query",
                "list": "categorymembers",
                "cmtitle": f"Category:{category}",
                "cmlimit": 500,
                "format": "json"
            }

            if cmcontinue:
                params["cmcontinue"] = cmcontinue

            try:
                response = self.session.get(self.api_url, params=params, timeout=30)
                data = response.json()

                if "query" in data and "categorymembers" in data["query"]:
                    for page in data["query"]["categorymembers"]:
                        pages.append(page["title"])

                if "continue" in data and "cmcontinue" in data["continue"]:
                    cmcontinue = data["continue"]["cmcontinue"]
                else:
                    break

                time.sleep(0.1)

            except Exception as e:
                print(f"Error fetching category '{category}': {str(e)}")
                break

        return pages


def main():
    parser = argparse.ArgumentParser(description="Scrape Stardew Valley Wiki")
    parser.add_argument("--output-dir", default="wiki_data", help="Output directory")
    parser.add_argument("--output-file", default="wiki_data.json", help="Output JSON file name")
    parser.add_argument("--mode", choices=["all", "categories"], default="all", help="Scraping mode")
    parser.add_argument("--categories", nargs="+", help="Categories to scrape (for categories mode)")

    args = parser.parse_args()

    scraper = StardewWikiScraper(args.output_dir)

    if args.mode == "all":
        scraper.scrape_all_pages(args.output_file)
    elif args.mode == "categories":
        if not args.categories:
            print("Error: --categories required for categories mode")
            return
        scraper.scrape_specific_categories(args.categories, args.output_file)


if __name__ == "__main__":
    main()
