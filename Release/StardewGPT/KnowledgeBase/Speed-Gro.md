# Speed-Gro

|  |  |
| --- | --- |
| Speed-Gro | |
| [Speed-Gro.png](/File:Speed-Gro.png) | |
| Stimulates leaf production. Guaranteed to increase growth rate by at least 10%. Mix into tilled soil. | |
| Information | |
| Source | [Pierre's](/Pierre%27s_General_Store "Pierre's General Store") • [Crafting](/Crafting "Crafting") • [Bone Mill](/Bone_Mill "Bone Mill") |
| Sell Price | data-sort-value="20">Gold.png20g |
| Recipe | |
| Recipe Source(s) | Farming Skill Icon.png [Farming](/Farming "Farming") Level 3 |
| Ingredients | Pine Tar.png [Pine Tar](/Pine_Tar "Pine Tar") (1)Moss.png [Moss](/Moss "Moss") (5) |
| Produces | 5 Speed-Gro per craft |

**Speed-Gro** is a [Fertilizer](/Fertilizer "Fertilizer") that speeds crop growth by 10% (or a total of 20% with the [Agriculturist Profession](/Skills#Farming "Skills"))[[1]](#cite_note-speedincrease-1). It can be [crafted](/Crafting "Crafting"), obtained from a [Bone Mill](/Bone_Mill "Bone Mill"), or purchased from [Pierre's](/Pierre%27s_General_Store "Pierre's General Store") for data-sort-value="100">![Gold.png](/mediawiki/images/thumb/1/10/Gold.png/18px-Gold.png)100g starting on Spring 15th of year 1.[[2]](#cite_note-unlock-2) Twenty Speed-Gro is the reward for completing the ![Bundle Green.png](/mediawiki/images/thumb/b/b3/Bundle_Green.png/24px-Bundle_Green.png) [Spring Crops Bundle](/Bundles#Spring_Crops_Bundle "Bundles") in the [Pantry](/Bundles#Pantry "Bundles").

Speed-Gro can be placed on tilled soil *before or after* planting a seed, or at any stage of crop growth. It does not reduce time between harvests for multi-harvest crops.

Applying Speed-Gro days after planting a seed still decreases the time it takes to fully grow, but it reduces a fixed amount of days per stage for each crop regardless of the day it's applied, and the reduction in stages that the crop has already passed will not retroactively apply. Combined with the fact that the reduction disproportionately affects earlier stages more, this means that its reduction to the rest of the growth time is much lower than the advertised percentage of 10%.[[3]](#cite_note-speedincrease2-3).

## Gifting

| Villager Reactions | |
| --- | --- |
| Dislike | [Abigail Icon.png](/Abigail "Abigail") [Abigail](/Abigail "Abigail") • [Alex Icon.png](/Alex "Alex") [Alex](/Alex "Alex") • [Caroline Icon.png](/Caroline "Caroline") [Caroline](/Caroline "Caroline") • [Clint Icon.png](/Clint "Clint") [Clint](/Clint "Clint") • [Demetrius Icon.png](/Demetrius "Demetrius") [Demetrius](/Demetrius "Demetrius") • [Dwarf Icon.png](/Dwarf "Dwarf") [Dwarf](/Dwarf "Dwarf") • [Elliott Icon.png](/Elliott "Elliott") [Elliott](/Elliott "Elliott") • [Emily Icon.png](/Emily "Emily") [Emily](/Emily "Emily") • [Evelyn Icon.png](/Evelyn "Evelyn") [Evelyn](/Evelyn "Evelyn") • [George Icon.png](/George "George") [George](/George "George") • [Gus Icon.png](/Gus "Gus") [Gus](/Gus "Gus") • [Haley Icon.png](/Haley "Haley") [Haley](/Haley "Haley") • [Harvey Icon.png](/Harvey "Harvey") [Harvey](/Harvey "Harvey") • [Jas Icon.png](/Jas "Jas") [Jas](/Jas "Jas") • [Jodi Icon.png](/Jodi "Jodi") [Jodi](/Jodi "Jodi") • [Kent Icon.png](/Kent "Kent") [Kent](/Kent "Kent") • [Krobus Icon.png](/Krobus "Krobus") [Krobus](/Krobus "Krobus") • [Leah Icon.png](/Leah "Leah") [Leah](/Leah "Leah") • [Leo Icon.png](/Leo "Leo") [Leo](/Leo "Leo") • [Lewis Icon.png](/Lewis "Lewis") [Lewis](/Lewis "Lewis") • [Linus Icon.png](/Linus "Linus") [Linus](/Linus "Linus") • [Marnie Icon.png](/Marnie "Marnie") [Marnie](/Marnie "Marnie") • [Maru Icon.png](/Maru "Maru") [Maru](/Maru "Maru") • [Pam Icon.png](/Pam "Pam") [Pam](/Pam "Pam") • [Penny Icon.png](/Penny "Penny") [Penny](/Penny "Penny") • [Pierre Icon.png](/Pierre "Pierre") [Pierre](/Pierre "Pierre") • [Robin Icon.png](/Robin "Robin") [Robin](/Robin "Robin") • [Sam Icon.png](/Sam "Sam") [Sam](/Sam "Sam") • [Sandy Icon.png](/Sandy "Sandy") [Sandy](/Sandy "Sandy") • [Sebastian Icon.png](/Sebastian "Sebastian") [Sebastian](/Sebastian "Sebastian") • [Shane Icon.png](/Shane "Shane") [Shane](/Shane "Shane") • [Vincent Icon.png](/Vincent "Vincent") [Vincent](/Vincent "Vincent") • [Willy Icon.png](/Willy "Willy") [Willy](/Willy "Willy") • [Wizard Icon.png](/Wizard "Wizard") [Wizard](/Wizard "Wizard") |

## Bundles

Speed-Gro is not used in any bundles, but 20 Speed-Gro is the reward for completing the ![Bundle Green.png](/mediawiki/images/thumb/b/b3/Bundle_Green.png/24px-Bundle_Green.png) [Spring Crops Bundle](/Bundles#Spring_Crops_Bundle "Bundles") in the [Pantry](/Bundles#Pantry "Bundles").

## Tailoring

Speed-Gro can be used in the spool of the [Sewing Machine](/2_Willow_Lane#Sewing_Machine "2 Willow Lane") to create the dyeable [High-Waisted Shirt](/Tailoring "Tailoring"). [![Shirt174.png](/mediawiki/images/thumb/6/65/Shirt174.png/24px-Shirt174.png)](/File:Shirt174.png) It can be used in [dyeing](/Dyeing "Dyeing"), serving as an orange dye at the dye pots, located in [Emily](/Emily "Emily")'s and [Haley](/Haley "Haley")'s house, [2 Willow Lane](/2_Willow_Lane "2 Willow Lane").

## Quests

Speed-Gro is not used in any [quests](/Quests "Quests").

## References

1. [↑](#cite_ref-speedincrease_1-0) See `StardewValley.TerrainFeatures.HoeDirt::applySpeedIncreases` in the game code.
2. [↑](#cite_ref-unlock_2-0) See `SeedShop::shopStock` in the game code.
3. [↑](#cite_ref-speedincrease2_3-0) The change in phaseDays in `HoeDirt::applySpeedIncreases` is static regardless of the date of fertilizer application relative to the date of planting. This means that applying fertilizer after planting only affects the current stage and any stages thereafter, in the same way that applying at the same day as planting affects those stages.

## History

* [1.4](/Version_History#1.4 "Version History"): Speed-Gro now has an effect if used after planting a seed. Can now be used in [Tailoring](/Tailoring "Tailoring").
* [1.6](/Version_History#1.6 "Version History"): Now requires 5 [Moss](/Moss "Moss") instead of 1 [Clam](/Clam "Clam") to craft.

| Equipment | | |
| --- | --- | --- |
| [Artisan](/Crafting#Artisan_Equipment "Crafting") | | [Bee House](/Bee_House "Bee House") • [Cask](/Cask "Cask") • [Cheese Press](/Cheese_Press "Cheese Press") • [Dehydrator](/Dehydrator "Dehydrator") • [Fish Smoker](/Fish_Smoker "Fish Smoker") • [Keg](/Keg "Keg") • [Loom](/Loom "Loom") • [Mayonnaise Machine](/Mayonnaise_Machine "Mayonnaise Machine") • [Oil Maker](/Oil_Maker "Oil Maker") • [Preserves Jar](/Preserves_Jar "Preserves Jar") |
| [Refining](/Crafting#Refining_Equipment "Crafting") | | [Bait Maker](/Bait_Maker "Bait Maker") • [Bone Mill](/Bone_Mill "Bone Mill") • [Charcoal Kiln](/Charcoal_Kiln "Charcoal Kiln") • [Crystalarium](/Crystalarium "Crystalarium") • [Deluxe Worm Bin](/Deluxe_Worm_Bin "Deluxe Worm Bin") • [Furnace](/Furnace "Furnace") • [Geode Crusher](/Geode_Crusher "Geode Crusher") • [Heavy Furnace](/Heavy_Furnace "Heavy Furnace") • [Heavy Tapper](/Heavy_Tapper "Heavy Tapper") • [Lightning Rod](/Lightning_Rod "Lightning Rod") • [Mushroom Log](/Mushroom_Log "Mushroom Log") • [Ostrich Incubator](/Ostrich_Incubator "Ostrich Incubator") • [Recycling Machine](/Recycling_Machine "Recycling Machine") • [Seed Maker](/Seed_Maker "Seed Maker") • [Slime Egg-Press](/Slime_Egg-Press "Slime Egg-Press") • [Slime Incubator](/Slime_Incubator "Slime Incubator") • [Solar Panel](/Solar_Panel "Solar Panel") • [Tapper](/Tapper "Tapper") • [Wood Chipper](/Wood_Chipper "Wood Chipper") • [Worm Bin](/Worm_Bin "Worm Bin") |
| [Farming](/Farming "Farming") | [Fertilizer](/Fertilizer "Fertilizer") | [Basic Fertilizer](/Basic_Fertilizer "Basic Fertilizer") • [Basic Retaining Soil](/Basic_Retaining_Soil "Basic Retaining Soil") • [Deluxe Fertilizer](/Deluxe_Fertilizer "Deluxe Fertilizer") • [Deluxe Retaining Soil](/Deluxe_Retaining_Soil "Deluxe Retaining Soil") • [Deluxe Speed-Gro](/Deluxe_Speed-Gro "Deluxe Speed-Gro") • [Hyper Speed-Gro](/Hyper_Speed-Gro "Hyper Speed-Gro") • [Quality Fertilizer](/Quality_Fertilizer "Quality Fertilizer") • [Quality Retaining Soil](/Quality_Retaining_Soil "Quality Retaining Soil") • Speed-Gro • [Tree Fertilizer](/Tree_Fertilizer "Tree Fertilizer") |
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