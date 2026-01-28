# Targeted Bait

|  |  |
| --- | --- |
| Targeted Bait | |
| [Pink Bait.png](/File:Pink_Bait.png) | |
| Increases your chance to catch [fish name]. | |
| Information | |
| Source | [Bait Maker](/Bait_Maker "Bait Maker") • [Fish Shop](/Fish_Shop "Fish Shop") |
| Energy | *Inedible* |
| Sell Price | 0.1 × [Fish](/Fish "Fish") Price |
| Crafting | |
| Equipment | Bait Maker.png [Bait Maker](/Bait_Maker "Bait Maker") |
| Processing Time | Time Icon.png ≤10m |
| Ingredients | Any [fish](/Fish "Fish") (1) |
| Produces | 5-10 Targeted Bait |

**Targeted Bait** is a specialized type of [bait](/Bait "Bait") which increases the chance of hooking a specific fish in a given area *provided the fish can be caught in that area at that time, weather, and season.* The bite rate for any targeted bait is the same as for [standard bait](/Bait_(item) "Bait (item)") (reduces the delay before a nibble by 50%).[[1]](#cite_note-fishbitetime-1)

It can be obtained from a [Bait Maker](/Bait_Maker "Bait Maker") after putting in any fish, which will result in 5-10 "[Fish Name] Bait." It will be finished crafting when the clock ticks over to the next 10-minute interval. The player can also purchase [8-12 targeted bait of a specific fish per day](#Fish_Shop_Stock) from the [Fish Shop](/Fish_Shop "Fish Shop") for double the sell price (0.2 x [Fish](/Fish "Fish") price).

Using targeted bait made from a [Legendary Fish](/Fish#Legendary_Fish "Fish") the player has already caught does not allow them to catch another one.

Targeted Bait cannot be used with the [Training Rod](/Training_Rod "Training Rod") or the [Bamboo Pole](/Bamboo_Pole "Bamboo Pole"). Only the [Fiberglass Rod](/Fiberglass_Rod "Fiberglass Rod"), the [Iridium Rod](/Iridium_Rod "Iridium Rod"), and the [Advanced Iridium Rod](/Advanced_Iridium_Rod "Advanced Iridium Rod") can use bait.

## Effects

When using targeted bait, the Locational Chance[[2]](#cite_note-GetChance-2) and Spawn Rate for the targeted fish are both multiplied by 1.66, after applying any relevant modifiers.[[3]](#cite_note-Spawn_Rate-3) These chances are capped at 1, so in most cases the Locational Chance adjustment will have no effect as most fish have a Locational Chance of 1. However, the Spawn Rate normally has a cap of 0.9, so this adjustment can guarantee a fish passing that check, assuming that a different item is not hooked first. In addition, when choosing from the list of possible catches for the area, the game will look at the first three items to pass both the Spawn Rate and Location-based checks. If the targeted fish is among them, the player will hook the targeted fish. Otherwise, the player will hook the third item, whatever it may be. If the game reaches the end of the list of possible catches before three items have passed both checks, it will loop back to the beginning of the list and check each item a second time.[[4]](#cite_note-Targeted_Bait_Loop-4) If it reaches the end of the list a second time, the player will hook [trash](/Trash "Trash").[[5]](#cite_note-Trash_Reason-5)

### Notes

* Some fish, such as the [Legendary Fish](/Fish#Legendary_Fish "Fish"), [Extended Family](/Fish#Legendary_Fish_II "Fish"), and [Submarine fish](/Night_Market#Fishing_Submarine "Night Market") ignore Spawn Rate completely giving them an effective 100% Spawn Rate, regardless of the 1.66x multiplier. However, they still benefit from all other effects, including the Locational Chance multiplier and extra hook attempts.
  + The [Legendary Fish](/Fish#Legendary_Fish "Fish") and [Extended Family](/Fish#Legendary_Fish_II "Fish") have earlier Precedence[[6]](#cite_note-Legendary_Precedence-6) than all other items in their locations, and so are always attempted on the first loop, regardless of Targeted Bait. This significantly reduces the impact of the extra hook attempts, as the second attempt only occurs under the highly unlikely circumstance that less than 3 items pass their random checks on the first loop (including Trash, which is guaranteed to pass). Thus, the chance of hooking a specific Legendary Fish or Legendary Fish II is multiplied by at least 1.66 with Targeted Bait.
* [Mines](/The_Mines "The Mines") fish, other than [Ghostfish](/Ghostfish "Ghostfish"), do not make use of the standard fishing algorithm at all, and so are unaffected by the usual effects of Targeted Bait. Instead, Targeted Bait provides a flat bonus to their hook chance. This is 10% for [Stonefish](/Stonefish "Stonefish"), 9% for [Ice Pip](/Ice_Pip "Ice Pip"), and 8% for [Lava Eel](/Lava_Eel "Lava Eel").[[7]](#cite_note-Mines_Fishing-7)
* [Goby](/Goby "Goby") is also unaffected by the usual effects of Targeted Bait. Instead, Targeted Bait provides a flat 20% increase to its Locational Chance. It also ignores Spawn Rate completely like with Legendary Fish. However, Goby still benefits from the extra hook attempts. This results in Goby Bait increasing the chance of hooking a Goby by at least 20%.[[8]](#cite_note-Goby-8)
* As a consequence of the Targeted Bait mechanics, if the player uses targeted bait for a fish that cannot be caught in the area at the given time, weather, and season, the chances of hooking trash increase significantly.

### In Crab Pots

Targeted Bait also works with [Crab Pots](/Crab_Pot "Crab Pot"), provided the player does not have the Mariner profession. Its effect depends on the base chance of the targeted fish, which is the chance to hook the fish provided all of the fish listed earlier in `Data\Fish.xnb` wasn't selected first. Specifically:[[9]](#cite_note-Crab_Pots-9)

* [Lobster](/Lobster "Lobster") chance is quadrupled.
* [Clam](/Clam "Clam"), [Crab](/Crab "Crab"), and [Oyster](/Oyster "Oyster") chances are tripled.
* All other Crab Pot fish chances are doubled.

Targeted Bait has no effect if the player has the Mariner profession.[[9]](#cite_note-Crab_Pots-9)

Below is the table detailing the chances for obtaining items with Crab Pot Targeted Bait (in saltwater) without the Mariner profession:

| Image | Name | % Lobster Bait | % Crab Bait | % Oyster Bait | % Clam Bait | % Shrimp Bait | % Cockle Bait | % Mussel Bait |
| --- | --- | --- | --- | --- | --- | --- | --- | --- |
| [Lobster.png](/File:Lobster.png) | [Lobster](/Lobster "Lobster") | 18.0% | 4.5% | 4.5% | 4.5% | 4.5% | 4.5% | 4.5% |
| [Crab.png](/File:Crab.png) | [Crab](/Crab "Crab") | 7.2% | 25.7% | 8.6% | 8.6% | 8.6% | 8.6% | 8.6% |
| [Oyster.png](/File:Oyster.png) | [Oyster](/Oyster "Oyster") | 9.7% | 9.0% | 34.6% | 11.5% | 11.5% | 11.5% | 11.5% |
| [Clam.png](/File:Clam.png) | [Clam](/Clam "Clam") | 8.3% | 7.6% | 6.3% | 29.4% | 9.8% | 9.8% | 9.8% |
| [Shrimp.png](/File:Shrimp.png) | [Shrimp](/Shrimp "Shrimp") | 9.4% | 8.6% | 7.2% | 7.2% | 22.2% | 11.1% | 11.1% |
| [Cockle.png](/File:Cockle.png) | [Cockle](/Cockle "Cockle") | 11.2% | 10.4% | 8.6% | 8.6% | 10.0% | 26.7% | 13.3% |
| [Mussel.png](/File:Mussel.png) | [Mussel](/Mussel "Mussel") | 9.2% | 8.5% | 7.1% | 7.1% | 8.2% | 6.2% | 21.8% |
| [Trash (item).png](/File:Trash_(item).png) | [Trash](/Trash "Trash") | 27.0% | 25.7% | 23.1% | 23.1% | 25.2% | 21.6% | 19.3% |

Below is the table detailing the chances for obtaining items with Crab Pot Targeted Bait (in freshwater) without the Mariner profession:

| Image | Name | % Snail Bait | % Crayfish Bait | % Periwinkle Bait |
| --- | --- | --- | --- | --- |
| [Snail.png](/File:Snail.png) | [Snail](/Snail "Snail") | 45.0% | 22.5% | 22.5% |
| [Crayfish.png](/File:Crayfish.png) | [Crayfish](/Crayfish "Crayfish") | 15.8% | 47.3% | 23.6% |
| [Periwinkle.png](/File:Periwinkle.png) | [Periwinkle](/Periwinkle "Periwinkle") | 16.1% | 11.1% | 43.9% |
| [Trash (item).png](/File:Trash_(item).png) | [Trash](/Trash "Trash") | 23.2% | 19.1% | 10.0% |

## Fish Shop Stock

Each day, Willy sells a limited quantity (8-12) of one Targeted Bait (*e.g.* Catfish Bait, Sardine Bait) for double the bait's sell price. The type of bait Willy sells depends on the season. Below is the list of all targeted bait Willy can sell in each season.

| Season | Possible Targeted Bait Sold |
| --- | --- |
| Spring.png [Spring](/Spring "Spring") | [Anchovy](/Anchovy "Anchovy") Bait, [Sardine](/Sardine "Sardine") Bait, [Bream](/Bream "Bream") Bait, [Largemouth Bass](/Largemouth_Bass "Largemouth Bass") Bait, [Smallmouth Bass](/Smallmouth_Bass "Smallmouth Bass") Bait, [Catfish](/Catfish "Catfish") Bait, [Eel](/Eel "Eel") Bait, [Flounder](/Flounder "Flounder") Bait, [Stonefish](/Stonefish "Stonefish") Bait |
| Summer.png [Summer](/Summer "Summer") | [Pufferfish](/Pufferfish "Pufferfish") Bait, [Tuna](/Tuna "Tuna") Bait, [Sardine](/Sardine "Sardine") Bait, [Bream](/Bream "Bream") Bait, [Largemouth Bass](/Largemouth_Bass "Largemouth Bass") Bait, [Rainbow Trout](/Rainbow_Trout "Rainbow Trout") Bait, [Pike](/Pike "Pike") Bait, [Red Mullet](/Red_Mullet "Red Mullet") Bait, [Octopus](/Octopus "Octopus") Bait, [Super Cucumber](/Super_Cucumber "Super Cucumber") Bait, [Flounder](/Flounder "Flounder") Bait, [Sturgeon](/Sturgeon "Sturgeon") Bait, [Dorado](/Dorado "Dorado") Bait, [Tilapia](/Tilapia "Tilapia") Bait, [Ice Pip](/Ice_Pip "Ice Pip") Bait |
| Fall.png [Fall](/Fall "Fall") | [Anchovy](/Anchovy "Anchovy") Bait, [Sardine](/Sardine "Sardine") Bait, [Bream](/Bream "Bream") Bait, [Largemouth Bass](/Largemouth_Bass "Largemouth Bass") Bait, [Smallmouth Bass](/Smallmouth_Bass "Smallmouth Bass") Bait, [Salmon](/Salmon "Salmon") Bait, [Octopus](/Octopus "Octopus") Bait, [Catfish](/Catfish "Catfish") Bait, [Eel](/Eel "Eel") Bait, [Midnight Carp](/Midnight_Carp "Midnight Carp") Bait, [Tilapia](/Tilapia "Tilapia") Bait, [Albacore](/Albacore "Albacore") Bait, [Lava Eel](/Lava_Eel "Lava Eel") Bait |
| Winter.png [Winter](/Winter "Winter") | [Tuna](/Tuna "Tuna") Bait, [Sardine](/Sardine "Sardine") Bait, [Bream](/Bream "Bream") Bait, [Largemouth Bass](/Largemouth_Bass "Largemouth Bass") Bait, [Walleye](/Walleye "Walleye") Bait, [Perch](/Perch "Perch") Bait, [Catfish](/Catfish "Catfish") Bait, [Pike](/Pike "Pike") Bait, [Red Mullet](/Red_Mullet "Red Mullet") Bait, [Squid](/Squid "Squid") Bait, [Super Cucumber](/Super_Cucumber "Super Cucumber") Bait, [Midnight Carp](/Midnight_Carp "Midnight Carp") Bait, [Sturgeon](/Sturgeon "Sturgeon") Bait, [Albacore](/Albacore "Albacore") Bait, [Lingcod](/Lingcod "Lingcod") Bait, [Stonefish](/Stonefish "Stonefish") Bait, [Ice Pip](/Ice_Pip "Ice Pip") Bait, [Lava Eel](/Lava_Eel "Lava Eel") Bait |

## Use

Requires: ![Fiberglass Rod.png](/mediawiki/images/thumb/5/5e/Fiberglass_Rod.png/24px-Fiberglass_Rod.png) [Fiberglass Rod](/Fiberglass_Rod "Fiberglass Rod"), ![Iridium Rod.png](/mediawiki/images/thumb/0/05/Iridium_Rod.png/24px-Iridium_Rod.png) [Iridium Rod](/Iridium_Rod "Iridium Rod"), or ![Advanced Iridium Rod.png](/mediawiki/images/thumb/f/f1/Advanced_Iridium_Rod.png/24px-Advanced_Iridium_Rod.png) [Advanced Iridium Rod](/Advanced_Iridium_Rod "Advanced Iridium Rod").

Each cast uses one piece of bait or one magnet. When all bait is used up, the game pops up a notification saying "You've used your last piece of bait."

To attach bait to a [fishing rod](/Tools#Fishing_Poles "Tools"), open the [inventory](/Inventory "Inventory"), click on the bait ([![Left-Click.png](/mediawiki/images/thumb/b/bb/Left-Click.png/24px-Left-Click.png)](/File:Left-Click.png) left-click or [![Right-Click.png](/mediawiki/images/thumb/e/e2/Right-Click.png/24px-Right-Click.png)](/File:Right-Click.png) right-click, depending on how many bait will be used), and then [![Right-Click.png](/mediawiki/images/thumb/e/e2/Right-Click.png/24px-Right-Click.png)](/File:Right-Click.png) on the rod. To remove bait, [![Right-Click.png](/mediawiki/images/thumb/e/e2/Right-Click.png/24px-Right-Click.png)](/File:Right-Click.png) on the rod.

On an Xbox controller, press [![360 A.png](/mediawiki/images/thumb/b/b2/360_A.png/24px-360_A.png)](/File:360_A.png) on the bait to select the whole stack (or [![360 X.png](/mediawiki/images/thumb/a/a6/360_X.png/24px-360_X.png)](/File:360_X.png) to pick up a single one), then [![360 X.png](/mediawiki/images/thumb/a/a6/360_X.png/24px-360_X.png)](/File:360_X.png) to attach to the rod.

On a PS4 controller, press [![PS4 Cross.png](/mediawiki/images/thumb/6/6b/PS4_Cross.png/24px-PS4_Cross.png)](/File:PS4_Cross.png) on the bait to select the whole stack (or [![PS4 Square.png](/mediawiki/images/thumb/e/ec/PS4_Square.png/24px-PS4_Square.png)](/File:PS4_Square.png) to pick up a single one), then [![PS4 Square.png](/mediawiki/images/thumb/e/ec/PS4_Square.png/24px-PS4_Square.png)](/File:PS4_Square.png) to attach to the rod.

On a Nintendo Switch Controller, Press [![Switch A.png](/mediawiki/images/thumb/0/07/Switch_A.png/24px-Switch_A.png)](/File:Switch_A.png) on the bait to select the whole stack (Or [![Switch Y.png](/mediawiki/images/thumb/3/3b/Switch_Y.png/24px-Switch_Y.png)](/File:Switch_Y.png) to pick up a single one), then [![Switch Y.png](/mediawiki/images/thumb/3/3b/Switch_Y.png/24px-Switch_Y.png)](/File:Switch_Y.png) to attach to the rod.

Bait can be detached by pressing [![PS4 Cross.png](/mediawiki/images/thumb/6/6b/PS4_Cross.png/24px-PS4_Cross.png)](/File:PS4_Cross.png) on either Controller. ([![Switch Y.png](/mediawiki/images/thumb/3/3b/Switch_Y.png/24px-Switch_Y.png)](/File:Switch_Y.png) on Nintendo Switch)

For the mobile version, bait can be added to the fishing rod by opening the inventory, then dragging the bait and dropping it on top of the rod. Bait cannot be conventionally removed on mobile but one type of bait may be switched out for another, which will move the bait previously on the rod back to the inventory.

## Bundles

Targeted Bait is not used in any [bundles](/Bundles "Bundles").

## Gifting

| Villager Reactions | |
| --- | --- |
| Hate | [Abigail Icon.png](/Abigail "Abigail") [Abigail](/Abigail "Abigail") • [Alex Icon.png](/Alex "Alex") [Alex](/Alex "Alex") • [Caroline Icon.png](/Caroline "Caroline") [Caroline](/Caroline "Caroline") • [Clint Icon.png](/Clint "Clint") [Clint](/Clint "Clint") • [Demetrius Icon.png](/Demetrius "Demetrius") [Demetrius](/Demetrius "Demetrius") • [Dwarf Icon.png](/Dwarf "Dwarf") [Dwarf](/Dwarf "Dwarf") • [Elliott Icon.png](/Elliott "Elliott") [Elliott](/Elliott "Elliott") • [Emily Icon.png](/Emily "Emily") [Emily](/Emily "Emily") • [Evelyn Icon.png](/Evelyn "Evelyn") [Evelyn](/Evelyn "Evelyn") • [George Icon.png](/George "George") [George](/George "George") • [Gus Icon.png](/Gus "Gus") [Gus](/Gus "Gus") • [Haley Icon.png](/Haley "Haley") [Haley](/Haley "Haley") • [Harvey Icon.png](/Harvey "Harvey") [Harvey](/Harvey "Harvey") • [Jas Icon.png](/Jas "Jas") [Jas](/Jas "Jas") • [Jodi Icon.png](/Jodi "Jodi") [Jodi](/Jodi "Jodi") • [Kent Icon.png](/Kent "Kent") [Kent](/Kent "Kent") • [Krobus Icon.png](/Krobus "Krobus") [Krobus](/Krobus "Krobus") • [Leah Icon.png](/Leah "Leah") [Leah](/Leah "Leah") • [Leo Icon.png](/Leo "Leo") [Leo](/Leo "Leo") • [Lewis Icon.png](/Lewis "Lewis") [Lewis](/Lewis "Lewis") • [Linus Icon.png](/Linus "Linus") [Linus](/Linus "Linus") • [Marnie Icon.png](/Marnie "Marnie") [Marnie](/Marnie "Marnie") • [Maru Icon.png](/Maru "Maru") [Maru](/Maru "Maru") • [Pam Icon.png](/Pam "Pam") [Pam](/Pam "Pam") • [Penny Icon.png](/Penny "Penny") [Penny](/Penny "Penny") • [Pierre Icon.png](/Pierre "Pierre") [Pierre](/Pierre "Pierre") • [Robin Icon.png](/Robin "Robin") [Robin](/Robin "Robin") • [Sam Icon.png](/Sam "Sam") [Sam](/Sam "Sam") • [Sandy Icon.png](/Sandy "Sandy") [Sandy](/Sandy "Sandy") • [Sebastian Icon.png](/Sebastian "Sebastian") [Sebastian](/Sebastian "Sebastian") • [Shane Icon.png](/Shane "Shane") [Shane](/Shane "Shane") • [Vincent Icon.png](/Vincent "Vincent") [Vincent](/Vincent "Vincent") • [Willy Icon.png](/Willy "Willy") [Willy](/Willy "Willy") • [Wizard Icon.png](/Wizard "Wizard") [Wizard](/Wizard "Wizard") |

## Quests

Targeted Bait is not used in any [quests](/Quests "Quests").

## References

1. [↑](#cite_ref-fishbitetime_1-0) See `FishingRod::calculateTimeUntilFishingBite` in the game code.
2. [↑](#cite_ref-GetChance_2-0) See `SpawnFishData::GetChance` in the game code. The multiplier is applied after all modifiers except Luck, most notably applying after any Curiosity Lure buff, by far the most common modifier to Location chance.
3. [↑](#cite_ref-Spawn_Rate_3-0) See `GameLocation::GetGenericFishRequirements` in the game code. The 1.66x multiplier is applied after distance from land, fishing level, and curiosity lure modifiers, and the 0.9 cap.
4. [↑](#cite_ref-Targeted_Bait_Loop_4-0) See `GameLocation::GetFishFromLocationData` in the game code. If a fish passes both random checks, it is hooked if either: there no targeted fish, it is the targeted fish, or at least two items in the list have already passed both checks.
5. [↑](#cite_ref-Trash_Reason_5-0) Since Trash exists at precedence 2000 in all areas, and is guaranteed to pass both checks, the only way to reach the end of the list twice is if Trash was the only item hooked on both loops. Therefore, the only items that can be hooked from this condition are Trash items.
6. [↑](#cite_ref-Legendary_Precedence_6-0) See `Data\Locations.xnb` in the game files for Precedence values.
7. [↑](#cite_ref-Mines_Fishing_7-0) See `MineShaft::GetFish` in the game code.
8. [↑](#cite_ref-Goby_8-0) See `Data\Locations.xnb` in the game files.
9. ↑ [9.0](#cite_ref-Crab_Pots_9-0) [9.1](#cite_ref-Crab_Pots_9-1) See `CrabPot::DayUpdate` in the game code.

## History

* [1.6](/Version_History#1.6 "Version History"): Introduced.
* [1.6.3](/Version_History#1.6.3 "Version History"): Fixed bug where other types of bait could act as targeted bait for no fish, which resulted in excess trash fished.

| Equipment | | |
| --- | --- | --- |
| [Artisan](/Crafting#Artisan_Equipment "Crafting") | | [Bee House](/Bee_House "Bee House") • [Cask](/Cask "Cask") • [Cheese Press](/Cheese_Press "Cheese Press") • [Dehydrator](/Dehydrator "Dehydrator") • [Fish Smoker](/Fish_Smoker "Fish Smoker") • [Keg](/Keg "Keg") • [Loom](/Loom "Loom") • [Mayonnaise Machine](/Mayonnaise_Machine "Mayonnaise Machine") • [Oil Maker](/Oil_Maker "Oil Maker") • [Preserves Jar](/Preserves_Jar "Preserves Jar") |
| [Refining](/Crafting#Refining_Equipment "Crafting") | | [Bait Maker](/Bait_Maker "Bait Maker") • [Bone Mill](/Bone_Mill "Bone Mill") • [Charcoal Kiln](/Charcoal_Kiln "Charcoal Kiln") • [Crystalarium](/Crystalarium "Crystalarium") • [Deluxe Worm Bin](/Deluxe_Worm_Bin "Deluxe Worm Bin") • [Furnace](/Furnace "Furnace") • [Geode Crusher](/Geode_Crusher "Geode Crusher") • [Heavy Furnace](/Heavy_Furnace "Heavy Furnace") • [Heavy Tapper](/Heavy_Tapper "Heavy Tapper") • [Lightning Rod](/Lightning_Rod "Lightning Rod") • [Mushroom Log](/Mushroom_Log "Mushroom Log") • [Ostrich Incubator](/Ostrich_Incubator "Ostrich Incubator") • [Recycling Machine](/Recycling_Machine "Recycling Machine") • [Seed Maker](/Seed_Maker "Seed Maker") • [Slime Egg-Press](/Slime_Egg-Press "Slime Egg-Press") • [Slime Incubator](/Slime_Incubator "Slime Incubator") • [Solar Panel](/Solar_Panel "Solar Panel") • [Tapper](/Tapper "Tapper") • [Wood Chipper](/Wood_Chipper "Wood Chipper") • [Worm Bin](/Worm_Bin "Worm Bin") |
| [Farming](/Farming "Farming") | [Fertilizer](/Fertilizer "Fertilizer") | [Basic Fertilizer](/Basic_Fertilizer "Basic Fertilizer") • [Basic Retaining Soil](/Basic_Retaining_Soil "Basic Retaining Soil") • [Deluxe Fertilizer](/Deluxe_Fertilizer "Deluxe Fertilizer") • [Deluxe Retaining Soil](/Deluxe_Retaining_Soil "Deluxe Retaining Soil") • [Deluxe Speed-Gro](/Deluxe_Speed-Gro "Deluxe Speed-Gro") • [Hyper Speed-Gro](/Hyper_Speed-Gro "Hyper Speed-Gro") • [Quality Fertilizer](/Quality_Fertilizer "Quality Fertilizer") • [Quality Retaining Soil](/Quality_Retaining_Soil "Quality Retaining Soil") • [Speed-Gro](/Speed-Gro "Speed-Gro") • [Tree Fertilizer](/Tree_Fertilizer "Tree Fertilizer") |
| [Sprinklers](/Crafting#Sprinklers "Crafting") | [Iridium Sprinkler](/Iridium_Sprinkler "Iridium Sprinkler") • [Quality Sprinkler](/Quality_Sprinkler "Quality Sprinkler") • [Sprinkler](/Sprinkler "Sprinkler") |
| Other | [Deluxe Scarecrow](/Deluxe_Scarecrow "Deluxe Scarecrow") • [Garden Pot](/Garden_Pot "Garden Pot") • [Rarecrow](/Scarecrow#Rarecrows "Scarecrow") • [Scarecrow](/Scarecrow "Scarecrow") |
| [Fishing](/Fishing "Fishing") | [Bait](/Bait "Bait") | [Bait](/Bait_(item) "Bait (item)") • [Challenge Bait](/Challenge_Bait "Challenge Bait") • [Deluxe Bait](/Deluxe_Bait "Deluxe Bait") • [Magic Bait](/Magic_Bait "Magic Bait") • [Magnet](/Magnet "Magnet") • Targeted Bait • [Wild Bait](/Wild_Bait "Wild Bait") |
| [Tackle](/Tackle "Tackle") | [Barbed Hook](/Barbed_Hook "Barbed Hook") • [Cork Bobber](/Cork_Bobber "Cork Bobber") • [Curiosity Lure](/Curiosity_Lure "Curiosity Lure") • [Dressed Spinner](/Dressed_Spinner "Dressed Spinner") • [Lead Bobber](/Lead_Bobber "Lead Bobber") • [Quality Bobber](/Quality_Bobber "Quality Bobber") • [Sonar Bobber](/Sonar_Bobber "Sonar Bobber") • [Spinner](/Spinner "Spinner") • [Trap Bobber](/Trap_Bobber "Trap Bobber") • [Treasure Hunter](/Treasure_Hunter "Treasure Hunter") |
| Other | [Crab Pot](/Crab_Pot "Crab Pot") |
| [Bombs](/Crafting#Bombs "Crafting") | | [Bomb](/Bomb "Bomb") • [Cherry Bomb](/Cherry_Bomb "Cherry Bomb") • [Mega Bomb](/Mega_Bomb "Mega Bomb") |
| [Fences](/Crafting#Fences "Crafting") | | [Gate](/Gate "Gate") • [Hardwood Fence](/Hardwood_Fence "Hardwood Fence") • [Iron Fence](/Iron_Fence "Iron Fence") • [Stone Fence](/Stone_Fence "Stone Fence") • [Wood Fence](/Wood_Fence "Wood Fence") |
| [Storage](/Crafting#Storage_Equipment "Crafting") | | [Big Chest](/Big_Chest "Big Chest") • [Big Stone Chest](/Big_Stone_Chest "Big Stone Chest") • [Chest](/Chest "Chest") • [Junimo Chest](/Junimo_Chest "Junimo Chest") • [Mini-Fridge](/Mini-Fridge "Mini-Fridge") • [Stone Chest](/Stone_Chest "Stone Chest") |
| [Signs](/Crafting#Signs "Crafting") | | [Dark Sign](/Dark_Sign "Dark Sign") • [Stone Sign](/Stone_Sign "Stone Sign") • [Text Sign](/Text_Sign "Text Sign") • [Wood Sign](/Wood_Sign "Wood Sign") |
| [Misc](/Crafting#Misc "Crafting") | | [Anvil](/Anvil "Anvil") • [Coffee Maker](/Coffee_Maker "Coffee Maker") • [Cookout Kit](/Cookout_Kit "Cookout Kit") • [Deconstructor](/Deconstructor "Deconstructor") • [Fairy Dust](/Fairy_Dust "Fairy Dust") • [Farm Computer](/Farm_Computer "Farm Computer") • [Hopper](/Hopper "Hopper") • [Mini-Forge](/Mini-Forge "Mini-Forge") • [Mini-Jukebox](/Mini-Jukebox "Mini-Jukebox") • [Mini-Shipping Bin](/Mini-Shipping_Bin "Mini-Shipping Bin") • [Sewing Machine](/Sewing_Machine "Sewing Machine") • [Staircase](/Staircase "Staircase") • [Statue Of Blessings](/Statue_Of_Blessings "Statue Of Blessings") • [Statue Of The Dwarf King](/Statue_Of_The_Dwarf_King "Statue Of The Dwarf King") • [Telephone](/Telephone "Telephone") • [Tent Kit](/Tent_Kit "Tent Kit") • [Tools](/Tools "Tools") • [Workbench](/Workbench "Workbench") |