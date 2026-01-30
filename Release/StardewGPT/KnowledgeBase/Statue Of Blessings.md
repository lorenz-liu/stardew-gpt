# Statue Of Blessings

|  |  |
| --- | --- |
| Statue Of Blessings | |
| [Statue Of Blessings.png](/File:Statue_Of_Blessings.png) | |
| Touching the statue gives a unique blessing every day. | |
| Information | |
| Source | [Crafting](/Crafting "Crafting") |
| Sell Price | *Cannot be sold* |
| Crafting | |
| Recipe Source | Mastery Icon.png [Farming Mastery](/Mastery_Cave#Masteries "Mastery Cave") |
| Ingredients | Sap.png [Sap](/Sap "Sap") (999)Fiber.png [Fiber](/Fiber "Fiber") (999)Stone.png [Stone](/Stone "Stone") (999)Moss.png [Moss](/Moss "Moss") (333) |

The **Statue of Blessings** grants a blessing to [the Player](/The_Player "The Player") every day upon touching. It can be [crafted](/Crafting "Crafting") after claiming [Farming Mastery](/Mastery_Cave#Masteries "Mastery Cave").

## List of Blessings

Every day, the Statue will grant a random blessing to the player from the list below. All blessings except for the Blessing Of The Butterfly and the Blessing Of Waters lasts for the duration of the in-game day.

Although the blessing the player will receive on a given day is random, it is pre-determined at the start of the day. Therefore there is no benefit to crafting multiple statues or restarting the day as the player will just receive the same blessing.

| Image | Name | Description |
| --- | --- | --- |
| [Blessing Of The Butterfly.png](/File:Blessing_Of_The_Butterfly.png) | Blessing Of The Butterfly | Spawns a Prismatic Butterfly. |
| [Blessing Of Energy.png](/File:Blessing_Of_Energy.png) | Blessing Of Energy | Grants infinite energy. |
| [Blessing Of Fangs.png](/File:Blessing_Of_Fangs.png) | Blessing Of Fangs | Crit. Chance.png [Crit. Chance](/Crit._Chance "Crit. Chance") (+10%). |
| [Blessing Of Friendship.png](/File:Blessing_Of_Friendship.png) | Blessing Of Friendship | Increases the amount of Friendship gained when speaking with people. |
| [Blessing Of Speed.png](/File:Blessing_Of_Speed.png) | Blessing Of Speed | Speed.png [Speed](/Speed "Speed") (+0.5). |
| [Blessing Of Waters.png](/File:Blessing_Of_Waters.png) | Blessing Of Waters | The first three fish you hook today will be much easier. |
| [Blessing Of Luck.png](/File:Blessing_Of_Luck.png) | Blessing Of Luck | Luck.png [Luck](/Luck "Luck") (+1). |

### Blessing Of The Butterfly

The Blessing of the Butterfly spawns a Prismatic Butterfly somewhere in the valley (specifically in one of [Cindersap Forest](/Cindersap_Forest "Cindersap Forest"), [Pelican Town](/Pelican_Town "Pelican Town"), [the Beach](/The_Beach "The Beach"), [the Mountain](/The_Mountain "The Mountain"), the [Secret Woods](/Secret_Woods "Secret Woods"), [Bus Stop](/Bus_Stop "Bus Stop"), or [Backwoods](/Backwoods "Backwoods")). The butterfly randomly moves in a wide area around where it spawns, so it's possible that a Prismatic Butterfly in an unreachable location will move somewhere that the player can reach. Once the player finds it, the butterfly provides an amount of gold equal to 0.5% of the player's total earnings so far. However, the amount of gold earned cannot be less than data-sort-value="100">![Gold.png](/mediawiki/images/thumb/1/10/Gold.png/18px-Gold.png)100g and cannot be greater than data-sort-value="50000">![Gold.png](/mediawiki/images/thumb/1/10/Gold.png/18px-Gold.png)50,000g. There's a chance (equal to approximately `0.05 + Daily Luck`) that it will also drop a ![Prismatic Shard.png](/mediawiki/images/thumb/5/56/Prismatic_Shard.png/24px-Prismatic_Shard.png) [Prismatic Shard](/Prismatic_Shard "Prismatic Shard").[[1]](#cite_note-butterfly-1)

The Blessing of the Butterfly cannot be given in rainy [weather](/Weather "Weather") or on [festival](/Festivals "Festivals") days.

The Prismatic Butterfly cannot spawn after 5 pm. This means that if it has reached 5 pm, the player has not found the butterfly yet, and they are not on the map where the butterfly is, they will be unable to find it. The Prismatic Butterfly disappears at the end of the day if it is not found.

In [Multiplayer](/Multiplayer "Multiplayer"), each player can get the blessing. They each get their own separate butterfly to find in different locations.

### Blessing Of Energy

When this blessing is active, players cannot lose energy by any means. If the player receives this blessing when their energy is not full, their energy will remain what it was before.

### Blessing of Fangs

When this blessing is active, an additive 10% crit is granted. This is [added before calculations](/Combat#Critical_hit_chance "Combat") from [Scout Profession](/Combat#Combat_Skill "Combat").[[2]](#cite_note-critChanceCalc-2)

### Blessing Of Friendship

When this blessing is active, talking to people will give the player 60 [friendship](/Friendship "Friendship") points, rather than the usual 20. This means that talking to a villager when the blessing is active will give three days' worth of talking friendship points in one day. This is roughly equivalent to giving a gold quality liked gift with no additional bonuses (such as a birthday).

### Blessing Of Speed

When this blessing is active, the player receives a +0.5 ![Speed.png](/mediawiki/images/thumb/9/94/Speed.png/24px-Speed.png) [Speed](/Speed "Speed") buff. This stacks with all other Speed buffs.

### Blessing Of Waters

When this blessing is active, the difficulty of Legendary fish decreases by 25% and the difficulty of non-Legendary fish (with the exception of [Carp](/Carp "Carp")) decreases by 50%. In addition, for all fish, the progress bar decreases 50% slower. This stacks multiplicatively with the [Trap Bobber](/Trap_Bobber "Trap Bobber") for a total of a 67% decrease with one Trap Bobber equipped and 75% with two.[[3]](#cite_note-waters-3)

Catching anything that is not considered a fish (such as Algae, Jelly, [Seaweed](/Seaweed "Seaweed"), and [Trash](/Trash "Trash")) does not count towards the blessing. But any fish hooked will count as part of the blessing even if the player lets the fish escape. If multiple fish are caught at once with the use of [Challenge Bait](/Challenge_Bait "Challenge Bait") or [Wild Bait](/Wild_Bait "Wild Bait"), it only counts as one fish for the blessing.

### Blessing Of Luck

When this blessing is active, the player receives a +1 ![Luck.png](/mediawiki/images/thumb/f/f0/Luck.png/24px-Luck.png) [Luck](/Luck "Luck") buff. This stacks with all other Luck buffs.

## Bugs

* Occasionally, the Prismatic Butterfly will spawn in an area of the map that is unreachable by the player (*e.g.* the ocean).

## References

1. [↑](#cite_ref-butterfly_1-0) See `Butterfly::update` in the game code.
2. [↑](#cite_ref-critChanceCalc_2-0) See `GameLocation::damageMonster` in the game code.
3. [↑](#cite_ref-waters_3-0) See `BobberBar::BobberBar` in the game code.

## History

* [1.6](/Version_History#1.6 "Version History"): Introduced.

| Equipment | | |
| --- | --- | --- |
| [Artisan](/Crafting#Artisan_Equipment "Crafting") | | [Bee House](/Bee_House "Bee House") • [Cask](/Cask "Cask") • [Cheese Press](/Cheese_Press "Cheese Press") • [Dehydrator](/Dehydrator "Dehydrator") • [Fish Smoker](/Fish_Smoker "Fish Smoker") • [Keg](/Keg "Keg") • [Loom](/Loom "Loom") • [Mayonnaise Machine](/Mayonnaise_Machine "Mayonnaise Machine") • [Oil Maker](/Oil_Maker "Oil Maker") • [Preserves Jar](/Preserves_Jar "Preserves Jar") |
| [Refining](/Crafting#Refining_Equipment "Crafting") | | [Bait Maker](/Bait_Maker "Bait Maker") • [Bone Mill](/Bone_Mill "Bone Mill") • [Charcoal Kiln](/Charcoal_Kiln "Charcoal Kiln") • [Crystalarium](/Crystalarium "Crystalarium") • [Deluxe Worm Bin](/Deluxe_Worm_Bin "Deluxe Worm Bin") • [Furnace](/Furnace "Furnace") • [Geode Crusher](/Geode_Crusher "Geode Crusher") • [Heavy Furnace](/Heavy_Furnace "Heavy Furnace") • [Heavy Tapper](/Heavy_Tapper "Heavy Tapper") • [Lightning Rod](/Lightning_Rod "Lightning Rod") • [Mushroom Log](/Mushroom_Log "Mushroom Log") • [Ostrich Incubator](/Ostrich_Incubator "Ostrich Incubator") • [Recycling Machine](/Recycling_Machine "Recycling Machine") • [Seed Maker](/Seed_Maker "Seed Maker") • [Slime Egg-Press](/Slime_Egg-Press "Slime Egg-Press") • [Slime Incubator](/Slime_Incubator "Slime Incubator") • [Solar Panel](/Solar_Panel "Solar Panel") • [Tapper](/Tapper "Tapper") • [Wood Chipper](/Wood_Chipper "Wood Chipper") • [Worm Bin](/Worm_Bin "Worm Bin") |
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
| [Misc](/Crafting#Misc "Crafting") | | [Anvil](/Anvil "Anvil") • [Coffee Maker](/Coffee_Maker "Coffee Maker") • [Cookout Kit](/Cookout_Kit "Cookout Kit") • [Deconstructor](/Deconstructor "Deconstructor") • [Fairy Dust](/Fairy_Dust "Fairy Dust") • [Farm Computer](/Farm_Computer "Farm Computer") • [Hopper](/Hopper "Hopper") • [Mini-Forge](/Mini-Forge "Mini-Forge") • [Mini-Jukebox](/Mini-Jukebox "Mini-Jukebox") • [Mini-Shipping Bin](/Mini-Shipping_Bin "Mini-Shipping Bin") • [Sewing Machine](/Sewing_Machine "Sewing Machine") • [Staircase](/Staircase "Staircase") • Statue Of Blessings • [Statue Of The Dwarf King](/Statue_Of_The_Dwarf_King "Statue Of The Dwarf King") • [Telephone](/Telephone "Telephone") • [Tent Kit](/Tent_Kit "Tent Kit") • [Tools](/Tools "Tools") • [Workbench](/Workbench "Workbench") |