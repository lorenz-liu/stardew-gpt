# Statue Of The Dwarf King

|  |  |
| --- | --- |
| Statue Of The Dwarf King | |
| [Statue Of The Dwarf King.png](/File:Statue_Of_The_Dwarf_King.png) | |
| Choose from two mining-related powers each day. | |
| Information | |
| Source | [Crafting](/Crafting "Crafting") |
| Sell Price | *Cannot be sold* |
| Crafting | |
| Recipe Source | Mastery Icon.png [Mining Mastery](/Mastery_Cave#Masteries "Mastery Cave") |
| Ingredients | Iridium Bar.png [Iridium Bar](/Iridium_Bar "Iridium Bar") (20) |

The **Statue Of The Dwarf King** grants unique powers to the player each day. It can be [crafted](/Crafting "Crafting") after claiming [Mining Mastery](/Mastery_Cave#Masteries "Mastery Cave").

## Powers

Every day, the Statue will offer two of its five available powers, listed below, for the player to choose from. The player can only choose one. All powers last for the duration of the in-game day.

Although the options the player can choose from are random, they are pre-determined at the start of the day. Therefore there is no benefit to crafting multiple statues or restarting the day as the player will just receive the same options to choose from.

| Image | Powers |
| --- | --- |
| [Dwarf Statue Ore.png](/File:Dwarf_Statue_Ore.png) | +1 ore when mining [nodes](/Mining#Mining_Nodes "Mining"). |
| [Dwarf Statue Geodes.png](/File:Dwarf_Statue_Geodes.png) | Greater chance to find [geodes](/Minerals#Geodes "Minerals"). |
| [Dwarf Statue Coal.png](/File:Dwarf_Statue_Coal.png) | Greater chance to find [coal](/Coal "Coal"). |
| [Dwarf Statue Ladders.png](/File:Dwarf_Statue_Ladders.png) | Greater chance to find ladders and shafts. |
| [Dwarf Statue Bombs.png](/File:Dwarf_Statue_Bombs.png) | [Bombs](/Crafting#Bombs "Crafting") cannot damage you. |

### +1 ore when mining nodes

When this power is active, certain [ore nodes](/Mining#Mining_Nodes "Mining") destroyed inside or outside the mines will drop one extra ore.[[1]](#cite_note-ore-1) Affected nodes are:

| Node | Drop |
| --- | --- |
| [Stone Index670.png](/File:Stone_Index670.png)[Stone Index668.png](/File:Stone_Index668.png)[Stone Index845.png](/File:Stone_Index845.png)[Stone Index846.png](/File:Stone_Index846.png)[Stone Index847.png](/File:Stone_Index847.png) | Stone.png [Stone](/Stone "Stone") Coal.png [Coal](/Coal "Coal") |
| [Coal Node Quarry 01.png](/File:Coal_Node_Quarry_01.png)[Coal Node Quarry 02.png](/File:Coal_Node_Quarry_02.png)[Coal Node Volcano 01.png](/File:Coal_Node_Volcano_01.png)[Coal Node Volcano 02.png](/File:Coal_Node_Volcano_02.png) | Coal.png [Coal](/Coal "Coal") |
| [Copper Node.png](/File:Copper_Node.png)[Copper Node Volcano.png](/File:Copper_Node_Volcano.png) | Copper Ore.png [Copper Ore](/Copper_Ore "Copper Ore") |
| [Iron Node.png](/File:Iron_Node.png)[Iron Node Volcano.png](/File:Iron_Node_Volcano.png) | Iron Ore.png [Iron Ore](/Iron_Ore "Iron Ore") |
| [Gold Node.png](/File:Gold_Node.png)[Gold Node Volcano.png](/File:Gold_Node_Volcano.png) | Gold Ore.png [Gold Ore](/Gold_Ore "Gold Ore") |
| [Iridium Node.png](/File:Iridium_Node.png) | Iridium Ore.png [Iridium Ore](/Iridium_Ore "Iridium Ore") |
| [Cinder Shard Node 1.png](/File:Cinder_Shard_Node_1.png)[Cinder Shard Node 2.png](/File:Cinder_Shard_Node_2.png) | Cinder Shard.png [Cinder Shard](/Cinder_Shard "Cinder Shard") |
| [Radioactive Node.png](/File:Radioactive_Node.png) | Radioactive Ore.png [Radioactive Ore](/Radioactive_Ore "Radioactive Ore") |
| [Bone Node 1.png](/File:Bone_Node_1.png)[Bone Node 2.png](/File:Bone_Node_2.png) | Bone Fragment.png [Bone Fragment](/Bone_Fragment "Bone Fragment") |
| [Clay Node.png](/File:Clay_Node.png) | Clay.png [Clay](/Clay "Clay") |

### Greater chance to find geodes

When this power is active, [geodes](/Minerals#Geodes "Minerals") found inside and outside of the mines have a (multiplicative) 25% higher chance of spawning when a rock is broken, either by hand or with [bombs](/Crafting#Bombs "Crafting").[[2]](#cite_note-geode-2)

### Greater chance to find coal

When this power is active rocks broken in the mines have a (multiplicative) 40% higher chance to drop coal, or 20% if the player has the [Prospector](/Skills#Mining "Skills") profession.[[3]](#cite_note-coalmine-3)
Outside, rocks not in the quarry are 3% more likely to drop coal. Rocks anywhere outside have a 2.5% chance to drop an additional coal. This will be on top of the higher chance to find coal that the player could have from the [Prospector](/Skills#Mining "Skills") profession.[[4]](#cite_note-coaloutdoors-4)

### Greater chance to find ladders and shafts

When this power is active, ladders and shafts will have a (multiplicative) 25% higher chance of dropping from rocks in [The Mines](/The_Mines "The Mines") or [Skull Cavern](/Skull_Cavern "Skull Cavern"). They will also have a 22% chance of dropping from [monsters](/Monsters "Monsters") in these locations, increased from the usual 15%.[[5]](#cite_note-ladder-5)

### Bombs cannot damage you

When this power is active, the player is immune to all damage from [Cherry Bombs](/Cherry_Bomb "Cherry Bomb"), [Bombs](/Bomb "Bomb"), [Mega Bombs](/Mega_Bomb "Mega Bomb")[[6]](#cite_note-bomb-6), and [Explosive Ammo](/Explosive_Ammo "Explosive Ammo") inside and outside of the mines. The player is also immune to explosive damage from [Hot Heads](/Hot_Head "Hot Head") in the [Volcano Dungeon](/Volcano_Dungeon "Volcano Dungeon").

## References

1. [↑](#cite_ref-ore_1-0) See `GameLocation::breakStone` in the game code.
2. [↑](#cite_ref-geode_2-0) See `GameLocation::onStoneDestroyed` and `MineShaft::checkStoneForItems` in the game code.
3. [↑](#cite_ref-coalmine_3-0) See `MineShaft::checkStoneForItems` in the game code.
4. [↑](#cite_ref-coaloutdoors_4-0) See `GameLocation::OnStoneDestroyed` and `GameLocation::BreakStone` in the game code.
5. [↑](#cite_ref-ladder_5-0) See `MineShaft::checkStoneForItems` and `MineShaft::monsterDrop` in the game code.
6. [↑](#cite_ref-bomb_6-0) See `GameLocation::performDamagePlayers` in the game code.

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
| [Misc](/Crafting#Misc "Crafting") | | [Anvil](/Anvil "Anvil") • [Coffee Maker](/Coffee_Maker "Coffee Maker") • [Cookout Kit](/Cookout_Kit "Cookout Kit") • [Deconstructor](/Deconstructor "Deconstructor") • [Fairy Dust](/Fairy_Dust "Fairy Dust") • [Farm Computer](/Farm_Computer "Farm Computer") • [Hopper](/Hopper "Hopper") • [Mini-Forge](/Mini-Forge "Mini-Forge") • [Mini-Jukebox](/Mini-Jukebox "Mini-Jukebox") • [Mini-Shipping Bin](/Mini-Shipping_Bin "Mini-Shipping Bin") • [Sewing Machine](/Sewing_Machine "Sewing Machine") • [Staircase](/Staircase "Staircase") • [Statue Of Blessings](/Statue_Of_Blessings "Statue Of Blessings") • Statue Of The Dwarf King • [Telephone](/Telephone "Telephone") • [Tent Kit](/Tent_Kit "Tent Kit") • [Tools](/Tools "Tools") • [Workbench](/Workbench "Workbench") |