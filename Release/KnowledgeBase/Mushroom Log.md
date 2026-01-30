# Mushroom Log

|  |  |
| --- | --- |
| Mushroom Log | |
| [Mushroom Log.png](/File:Mushroom_Log.png)   [Mushroom Log Ready.png](/File:Mushroom_Log_Ready.png) | |
| Grows mushrooms every so often. The more wild trees are nearby, the better it works. | |
| Information | |
| Source | [Crafting](/Crafting "Crafting") |
| Crafting | |
| Recipe Source | Foraging Skill Icon.png [Foraging](/Foraging "Foraging") (Level 4) |
| Ingredients | Hardwood.png [Hardwood](/Hardwood "Hardwood") (10)Moss.png [Moss](/Moss "Moss") (10) |
| Produces | Chanterelle.png [Chanterelle](/Chanterelle "Chanterelle")Common Mushroom.png [Common Mushroom](/Common_Mushroom "Common Mushroom")Morel.png [Morel](/Morel "Morel")Red Mushroom.png [Red Mushroom](/Red_Mushroom "Red Mushroom")Purple Mushroom.png [Purple Mushroom](/Purple_Mushroom "Purple Mushroom") |

The **Mushroom Log** is a [crafted item](/Crafting "Crafting") that produces [mushrooms](/Category:Mushrooms "Category:Mushrooms"). The recipe is earned at [foraging](/Foraging "Foraging") level 4. 4 Mushroom Logs may be rewarded as the seventh prize from the [Prize Machine](/Mayor%27s_Manor#Prize_Machine "Mayor's Manor") (33% chance).
Mushroom Logs grant 5 [foraging](/Foraging "Foraging") XP on harvest.

## Mechanic

The Mushroom Log produces mushrooms every 4 days, rainy days will cause this to take a day less. Produces mushrooms in all seasons.

### Quantity

The quantity of mushrooms produced increases with the amount of [Wild Trees](/Trees "Trees")—that is, non-fruit trees—in the 7×7 square around the log, including immature trees. The amount of mushrooms generated, limited to between 1 and 5, is calculated by finding the number of nearby trees and divide this by two rounded down and multiplying this randomly by 1 or 2.[[1]](#cite_note-code-1) Therefore, the number of nearby trees needed to always gain the maximum amount of 5 is 10.

### Type

The type of mushrooms produced depends on the type of trees nearby. The game code creates a list of possible mushrooms based on nearby trees, and then selects one at random from that list.

* First the game finds how many trees are in the 7×7 square around it, including immature trees. That number is multiplied by 3/4, rounded down, and that many mushrooms (at least one) are added to the list, randomly chosen between [Purple Mushrooms](/Purple_Mushroom "Purple Mushroom") (5%), [Red Mushrooms](/Red_Mushroom "Red Mushroom") (14.25%), and [Common Mushrooms](/Common_Mushroom "Common Mushroom") (80.75%).
* Then, one more mushroom is added for each *mature* tree. If the tree is an [Oak Tree](/Oak_Tree "Oak Tree") then the mushroom added will always be a [Morel](/Morel "Morel"). The same goes for [Pine Tree](/Pine_Tree "Pine Tree") with [Chanterelle](/Chanterelle "Chanterelle"), and for [Mystic Tree](/Mystic_Tree "Mystic Tree") with [Purple Mushroom](/Purple_Mushroom "Purple Mushroom"). [Maple Trees](/Maple_Tree "Maple Tree") have a 10% chance to give a [Purple Mushroom](/Purple_Mushroom "Purple Mushroom") and a 90% chance to give a [Red Mushroom](/Red_Mushroom "Red Mushroom"). If the mature tree is none of these types, the same distribution as in step 1 is used.
* Finally, a random mushroom from the second list is generated.[[1]](#cite_note-code-1)

This process makes it impossible to guarantee a single type of mushroom, as every tree added contributes not only to the chance of its own associated mushroom, but also the chance of [red](/Red_Mushroom "Red Mushroom"), [common](/Common_Mushroom "Common Mushroom"), and [purple](/Purple_Mushroom "Purple Mushroom") mushrooms. Due to the rounding on the number of trees in step 1, adding more trees will not always increase the chance of the associated mushroom.

A table is given below for the chance of getting each mushroom type if the Mushroom Log is surrounded by a single type of tree. Mixing trees will result in more complex distributions that need to be individually calculated. As immature trees contribute to the number of basic distribution mushrooms, but not the number of special mushrooms, these values are only accurate once all trees are fully grown.

| Mushroom Probabilities with a Single Tree Type | | | | | | | | | | | | | | | | | | |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| Number of Modifying   Mature Trees | Number of Basic   Distribution Mushrooms | % [Common Mushroom](/Common_Mushroom "Common Mushroom") [Common Mushroom.png](/File:Common_Mushroom.png) | % [Red Mushroom](/Red_Mushroom "Red Mushroom") [Red Mushroom.png](/File:Red_Mushroom.png)  (Not [Maple Tree](/Maple_Tree "Maple Tree")) | % [Purple Mushroom](/Purple_Mushroom "Purple Mushroom") [Purple Mushroom.png](/File:Purple_Mushroom.png)  (Not [Maple](/Maple_Tree "Maple Tree") or [Mystic](/Mystic_Tree "Mystic Tree") Tree) | % [Morel](/Morel "Morel") [Morel.png](/File:Morel.png)  ([Oak Tree](/Oak_Tree "Oak Tree")) | % [Chanterelle](/Chanterelle "Chanterelle") [Chanterelle.png](/File:Chanterelle.png)  ([Pine Tree](/Pine_Tree "Pine Tree")) | % [Red Mushroom](/Red_Mushroom "Red Mushroom") [Red Mushroom.png](/File:Red_Mushroom.png)  ([Maple Tree](/Maple_Tree "Maple Tree")) | % [Purple Mushroom](/Purple_Mushroom "Purple Mushroom") [Purple Mushroom.png](/File:Purple_Mushroom.png)  ([Maple Tree](/Maple_Tree "Maple Tree")) | % [Purple Mushroom](/Purple_Mushroom "Purple Mushroom") [Purple Mushroom.png](/File:Purple_Mushroom.png)  ([Mystic Tree](/Mystic_Tree "Mystic Tree")) |
| 0 | 1 | 80.75% | 14.25% | 5.00% | N/A | N/A | N/A | N/A | N/A |
| 1 | 1 | 40.38% | 7.12% | 2.50% | 50.00% | 50.00% | 52.13% | 7.50% | 52.50% |
| 2 | 1 | 26.92% | 4.75% | 1.67% | 66.67% | 66.67% | 64.75% | 8.33% | 68.33% |
| 3 | 2 | 32.30% | 5.70% | 2.00% | 60.00% | 60.00% | 59.70% | 8.00% | 62.00% |
| 4 | 3 | 34.61% | 6.11% | 2.14% | 57.14% | 57.14% | 57.54% | 7.86% | 59.29% |
| 5 | 3 | 30.28% | 5.34% | 1.88% | 62.50% | 62.50% | 61.59% | 8.13% | 64.38% |
| 6 | 4 | 32.30% | 5.70% | 2.00% | 60.00% | 60.00% | 59.70% | 8.00% | 62.00% |
| 7 | 5 | 33.65% | 5.94% | 2.08% | 58.33% | 58.33% | 58.44% | 7.92% | 60.42% |
| 8 | 6 | 34.61% | 6.11% | 2.14% | 57.14% | 57.14% | 57.54% | 7.86% | 59.29% |
| 9 | 6 | 32.30% | 5.70% | 2.00% | 60.00% | 60.00% | 59.70% | 8.00% | 62.00% |
| 10 | 7 | 33.25% | 5.87% | 2.06% | 58.82% | 58.82% | 58.81% | 7.94% | 60.88% |
| 11 | 8 | 34.00% | 6.00% | 2.11% | 57.89% | 57.89% | 58.11% | 7.89% | 60.00% |
| 12 | 9 | 34.61% | 6.11% | 2.14% | 57.14% | 57.14% | 57.54% | 7.86% | 59.29% |
| 13 | 9 | 33.03% | 5.83% | 2.05% | 59.09% | 59.09% | 59.01% | 7.95% | 61.14% |
| 14 | 10 | 33.65% | 5.94% | 2.08% | 58.33% | 58.33% | 58.44% | 7.92% | 60.42% |
| 15 | 11 | 34.16% | 6.03% | 2.12% | 57.69% | 57.69% | 57.95% | 7.88% | 59.81% |
| 16 | 12 | 34.61% | 6.11% | 2.14% | 57.14% | 57.14% | 57.54% | 7.86% | 59.29% |

### Quality

The quality of the mushrooms produced can vary, but is not affected by the [Botanist](/Foraging#Foraging_Skill "Foraging") Profession. Instead, the quality is calculated based on the number of nearby trees, including immature trees, and how many of them have moss on them. Each nearby tree is counted, with mossy trees counted twice. This number is then divided by 40 and is used as the chance for the quality to upgrade. This chance occurs repeatedly until it fails or reaches iridium quality.[[1]](#cite_note-code-1) So for example if the count is 20 then the chance is 0.5, meaning there is a 50% chance of regular quality, a 25% chance of silver quality, a 12.5% chance of gold quality, and a 12.5% chance of iridium quality. A complete table of probabilities for each quality of mushroom, depending on the amount of trees and moss, is given below, along with the expected multiplier on sell price.

| Probabilities for each Quality | | | | | |
| --- | --- | --- | --- | --- | --- |
| Tree & Moss Count | % Base quality | % Silver quality | % Gold quality | % Iridium quality | Average Price Multiplier |
| 0 | 100.00% | 0.00% | 0.00% | 0.00% | 100.00% |
| 1 | 97.50% | 2.44% | 0.06% | 0.00% | 100.64% |
| 2 | 95.00% | 4.75% | 0.24% | 0.01% | 101.32% |
| 3 | 92.50% | 6.94% | 0.52% | 0.04% | 102.04% |
| 4 | 90.00% | 9.00% | 0.90% | 0.10% | 102.80% |
| 5 | 87.50% | 10.94% | 1.37% | 0.20% | 103.61% |
| 6 | 85.00% | 12.75% | 1.91% | 0.34% | 104.48% |
| 7 | 82.50% | 14.44% | 2.53% | 0.54% | 105.41% |
| 8 | 80.00% | 16.00% | 3.20% | 0.80% | 106.40% |
| 9 | 77.50% | 17.44% | 3.92% | 1.14% | 107.46% |
| 10 | 75.00% | 18.75% | 4.69% | 1.56% | 108.59% |
| 11 | 72.50% | 19.94% | 5.48% | 2.08% | 109.81% |
| 12 | 70.00% | 21.00% | 6.30% | 2.70% | 111.10% |
| 13 | 67.50% | 21.94% | 7.13% | 3.43% | 112.48% |
| 14 | 65.00% | 22.75% | 7.96% | 4.29% | 113.96% |
| 15 | 62.50% | 23.44% | 8.79% | 5.27% | 115.53% |
| 16 | 60.00% | 24.00% | 9.60% | 6.40% | 117.20% |
| 17 | 57.50% | 24.44% | 10.39% | 7.68% | 118.98% |
| 18 | 55.00% | 24.75% | 11.14% | 9.11% | 120.87% |
| 19 | 52.50% | 24.94% | 11.85% | 10.72% | 122.87% |
| 20 | 50.00% | 25.00% | 12.50% | 12.50% | 125.00% |
| 21 | 47.50% | 24.94% | 13.09% | 14.47% | 127.25% |
| 22 | 45.00% | 24.75% | 13.61% | 16.64% | 129.63% |
| 23 | 42.50% | 24.44% | 14.05% | 19.01% | 132.15% |
| 24 | 40.00% | 24.00% | 14.40% | 21.60% | 134.80% |
| 25 | 37.50% | 23.44% | 14.65% | 24.41% | 137.60% |
| 26 | 35.00% | 22.75% | 14.79% | 27.46% | 140.54% |
| 27 | 32.50% | 21.94% | 14.81% | 30.75% | 143.64% |
| 28 | 30.00% | 21.00% | 14.70% | 34.30% | 146.90% |
| 29 | 27.50% | 19.94% | 14.45% | 38.11% | 150.32% |
| 30 | 25.00% | 18.75% | 14.06% | 42.19% | 153.91% |
| 31 | 22.50% | 17.44% | 13.51% | 46.55% | 157.66% |
| 32 | 20.00% | 16.00% | 12.80% | 51.20% | 161.60% |
| 33 | 17.50% | 14.44% | 11.91% | 56.15% | 165.72% |
| 34 | 15.00% | 12.75% | 10.84% | 61.41% | 170.02% |
| 35 | 12.50% | 10.94% | 9.57% | 66.99% | 174.51% |
| 36 | 10.00% | 9.00% | 8.10% | 72.90% | 179.20% |
| 37 | 7.50% | 6.94% | 6.42% | 79.15% | 184.09% |
| 38 | 5.00% | 4.75% | 4.51% | 85.74% | 189.18% |
| 39 | 2.50% | 2.44% | 2.38% | 92.69% | 194.48% |
| 40+ | 0.00% | 0.00% | 0.00% | 100.00% | 200.00% |

## References

1. ↑ [1.0](#cite_ref-code_1-0) [1.1](#cite_ref-code_1-1) [1.2](#cite_ref-code_1-2) See `Object::OutputMushroomLog` in the game code.

## History

* [1.6](/Version_History#1.6 "Version History"): Introduced.

| Equipment | | |
| --- | --- | --- |
| [Artisan](/Crafting#Artisan_Equipment "Crafting") | | [Bee House](/Bee_House "Bee House") • [Cask](/Cask "Cask") • [Cheese Press](/Cheese_Press "Cheese Press") • [Dehydrator](/Dehydrator "Dehydrator") • [Fish Smoker](/Fish_Smoker "Fish Smoker") • [Keg](/Keg "Keg") • [Loom](/Loom "Loom") • [Mayonnaise Machine](/Mayonnaise_Machine "Mayonnaise Machine") • [Oil Maker](/Oil_Maker "Oil Maker") • [Preserves Jar](/Preserves_Jar "Preserves Jar") |
| [Refining](/Crafting#Refining_Equipment "Crafting") | | [Bait Maker](/Bait_Maker "Bait Maker") • [Bone Mill](/Bone_Mill "Bone Mill") • [Charcoal Kiln](/Charcoal_Kiln "Charcoal Kiln") • [Crystalarium](/Crystalarium "Crystalarium") • [Deluxe Worm Bin](/Deluxe_Worm_Bin "Deluxe Worm Bin") • [Furnace](/Furnace "Furnace") • [Geode Crusher](/Geode_Crusher "Geode Crusher") • [Heavy Furnace](/Heavy_Furnace "Heavy Furnace") • [Heavy Tapper](/Heavy_Tapper "Heavy Tapper") • [Lightning Rod](/Lightning_Rod "Lightning Rod") • Mushroom Log • [Ostrich Incubator](/Ostrich_Incubator "Ostrich Incubator") • [Recycling Machine](/Recycling_Machine "Recycling Machine") • [Seed Maker](/Seed_Maker "Seed Maker") • [Slime Egg-Press](/Slime_Egg-Press "Slime Egg-Press") • [Slime Incubator](/Slime_Incubator "Slime Incubator") • [Solar Panel](/Solar_Panel "Solar Panel") • [Tapper](/Tapper "Tapper") • [Wood Chipper](/Wood_Chipper "Wood Chipper") • [Worm Bin](/Worm_Bin "Worm Bin") |
| [Farming](/Farming "Farming") | [Fertilizer](/Fertilizer "Fertilizer") | [Basic Fertilizer](/Basic_Fertilizer "Basic Fertilizer") • [Basic Retaining Soil](/Basic_Retaining_Soil "Basic Retaining Soil") • [Deluxe Fertilizer](/Deluxe_Fertilizer "Deluxe Fertilizer") • [Deluxe Retaining Soil](/Deluxe_Retaining_Soil "Deluxe Retaining Soil") • [Deluxe Speed-Gro](/Deluxe_Speed-Gro "Deluxe Speed-Gro") • [Hyper Speed-Gro](/Hyper_Speed-Gro "Hyper Speed-Gro") • [Quality Fertilizer](/Quality_Fertilizer "Quality Fertilizer") • [Quality Retaining Soil](/Quality_Retaining_Soil "Quality Retaining Soil") • [Speed-Gro](/Speed-Gro "Speed-Gro") • [Tree Fertilizer](/Tree_Fertilizer "Tree Fertilizer") |
| [Sprinklers](/Crafting#Sprinklers "Crafting") | [Iridium Sprinkler](/Iridium_Sprinkler "Iridium Sprinkler") • [Quality Sprinkler](/Quality_Sprinkler "Quality Sprinkler") • [Sprinkler](/Sprinkler "Sprinkler") |
| Other | [Deluxe Scarecrow](/Deluxe_Scarecrow "Deluxe Scarecrow") • [Garden Pot](/Garden_Pot "Garden Pot") • [Rarecrow](/Scarecrow#Rarecrows "Scarecrow") • [Scarecrow](/Scarecrow "Scarecrow") |
| [Fishing](/Fishing "Fishing") | [Bait](/Bait "Bait") | [Bait](/Bait_(item) "Bait (item)") • [Challenge Bait](/Challenge_Bait "Challenge Bait") • [Deluxe Bait](/Deluxe_Bait "Deluxe Bait") • [Magic Bait](/Magic_Bait "Magic Bait") • [Magnet](/Magnet "Magnet") • [Targeted Bait](/Targeted_Bait "Targeted Bait") • [Wild Bait](/Wild_Bait "Wild Bait") |
| [Tackle](/Tackle "Tackle") | [Barbed Hook](/Barbed_Hook "Barbed Hook") • [Cork Bobber](/Cork_Bobber "Cork Bobber") • [Curiosity Lure](/Curiosity_Lure "Curiosity Lure") • [Dressed Spinner](/Dressed_Spinner "Dressed Spinner") • [Lead Bobber](/Lead_Bobber "Lead Bobber") • [Quality Bobber](/Quality_Bobber "Quality Bobber") • [Sonar Bobber](/Sonar_Bobber "Sonar Bobber") • [Spinner](/Spinner "Spinner") • [Trap Bobber](/Trap_Bobber "Trap Bobber") • [Treasure Hunter](/Treasure_Hunter "Treasure Hunter") |
| Other | [Crab Pot](/Crab_Pot "Crab Pot") |
| [Bombs](/Crafting#Bombs "Crafting") | | [Bomb](/Bomb "Bomb") • [Cherry Bomb](/Cherry_Bomb "Cherry Bomb") • [Mega Bomb](/Mega_Bomb "Mega Bomb") |
| [Fences](/Crafting#Fences "Crafting") | | [Gate](/Gate "Gate") • [Hardwood Fence](/Hardwood_Fence "Hardwood Fence") • [Iron Fence](/Iron_Fence "Iron Fence") • [Stone Fence](/Stone_Fence "Stone Fence") • [Wood Fence](/Wood_Fence "Wood Fence") |
| [Storage](/Crafting#Storage_Equipment "Crafting") | | [Big Chest](/Big_Chest "Big Chest") • [Big Stone Chest](/Big_Stone_Chest "Big Stone Chest") • [Chest](/Chest "Chest") • [Junimo Chest](/Junimo_Chest "Junimo Chest") • [Mini-Fridge](/Mini-Fridge "Mini-Fridge") • [Stone Chest](/Stone_Chest "Stone Chest") |
| [Signs](/Crafting#Signs "Crafting") | | [Dark Sign](/Dark_Sign "Dark Sign") • [Stone Sign](/Stone_Sign "Stone Sign") • [Text Sign](/Text_Sign "Text Sign") • [Wood Sign](/Wood_Sign "Wood Sign") |
| [Misc](/Crafting#Misc "Crafting") | | [Anvil](/Anvil "Anvil") • [Coffee Maker](/Coffee_Maker "Coffee Maker") • [Cookout Kit](/Cookout_Kit "Cookout Kit") • [Deconstructor](/Deconstructor "Deconstructor") • [Fairy Dust](/Fairy_Dust "Fairy Dust") • [Farm Computer](/Farm_Computer "Farm Computer") • [Hopper](/Hopper "Hopper") • [Mini-Forge](/Mini-Forge "Mini-Forge") • [Mini-Jukebox](/Mini-Jukebox "Mini-Jukebox") • [Mini-Shipping Bin](/Mini-Shipping_Bin "Mini-Shipping Bin") • [Sewing Machine](/Sewing_Machine "Sewing Machine") • [Staircase](/Staircase "Staircase") • [Statue Of Blessings](/Statue_Of_Blessings "Statue Of Blessings") • [Statue Of The Dwarf King](/Statue_Of_The_Dwarf_King "Statue Of The Dwarf King") • [Telephone](/Telephone "Telephone") • [Tent Kit](/Tent_Kit "Tent Kit") • [Tools](/Tools "Tools") • [Workbench](/Workbench "Workbench") |