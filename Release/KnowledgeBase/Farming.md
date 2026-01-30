# Farming

**Farming** is the [skill](/Skills "Skills") associated with planting, growing, and harvesting [crops](/Crops "Crops") on [the farm](/The_Farm "The Farm"), and also the care of [farm animals](/Animals "Animals"). It's one of the main income sources for the game, and provides most of the ingredients for [cooking](/Cooking "Cooking").

## [Farming Skill Icon.png](/File:Farming_Skill_Icon.png) Farming Skill

The farming skill level can be viewed in the skill tab of the pause menu. Each level grants +1 [proficiency](/Skills#Proficiency "Skills") to the [Hoe](/Hoes "Hoes") and [Watering Can](/Watering_Cans "Watering Cans"), which reduces the energy cost of using the tools. Higher farming skill also increases the chance to obtain quality crops.

To level up farming skill requires experience points, which are gained by harvesting crops, petting farm animals, milking cows or goats, shearing sheep, picking up animal products inside a coop, or reading the [Stardew Valley Almanac](/Stardew_Valley_Almanac "Stardew Valley Almanac") or [Book Of Stars](/Book_Of_Stars "Book Of Stars").

| Level 1 | Level 2 | Level 3 | Level 4 | Level 5 | |
| --- | --- | --- | --- | --- | --- |
| *Crafting Recipes:* | *Crafting Recipes:* | *Crafting / Cooking Recipes:* | *Crafting Recipes:* | *Choose a Profession:* | |
| Scarecrow.png [Scarecrow](/Scarecrow "Scarecrow") Basic Fertilizer.png [Basic Fertilizer](/Basic_Fertilizer "Basic Fertilizer") | Mayonnaise Machine.png [Mayonnaise Machine](/Mayonnaise_Machine "Mayonnaise Machine")  Stone Fence.png [Stone Fence](/Stone_Fence "Stone Fence") Sprinkler.png [Sprinkler](/Sprinkler "Sprinkler") | Bee House.png [Bee House](/Bee_House "Bee House")  Speed-Gro.png [Speed-Gro](/Speed-Gro "Speed-Gro")  Farmer's Lunch.png [Farmer's Lunch](/Farmer%27s_Lunch "Farmer's Lunch") | Preserves Jar.png [Preserves Jar](/Preserves_Jar "Preserves Jar")  Basic Retaining Soil.png [Basic Retaining Soil](/Basic_Retaining_Soil "Basic Retaining Soil")  Iron Fence.png [Iron Fence](/Iron_Fence "Iron Fence") | Rancher.png **Rancher** [Animal](/Animals "Animals") products worth 20% more. | Tiller.png **Tiller** [Crops](/Crops "Crops") worth 10% more.  (Bonus applies to all [Vegetables](/Vegetables "Vegetables") and [Flowers](/Flowers "Flowers"), plus any [Fruit](/Fruits "Fruits") that has not been [foraged](/Foraging "Foraging")) |
|  | | | | | |
| Level 6 | Level 7 | Level 8 | Level 9 | Level 10 | |
| *Crafting Recipes:* | *Crafting Recipes:* | *Crafting Recipes:* | *Crafting Recipes:* | *Rancher:* | *Tiller:* |
| Cheese Press.png [Cheese Press](/Cheese_Press "Cheese Press")  Hardwood Fence.png [Hardwood Fence](/Hardwood_Fence "Hardwood Fence")  Quality Sprinkler.png [Quality Sprinkler](/Quality_Sprinkler "Quality Sprinkler") | Loom.png [Loom](/Loom "Loom") Quality Retaining Soil.png [Quality Retaining Soil](/Quality_Retaining_Soil "Quality Retaining Soil") | Oil Maker.png [Oil Maker](/Oil_Maker "Oil Maker") Keg.png [Keg](/Keg "Keg") Deluxe Speed-Gro.png [Deluxe Speed-Gro](/Deluxe_Speed-Gro "Deluxe Speed-Gro") | Seed Maker.png [Seed Maker](/Seed_Maker "Seed Maker")  Iridium Sprinkler.png [Iridium Sprinkler](/Iridium_Sprinkler "Iridium Sprinkler")  Quality Fertilizer.png [Quality Fertilizer](/Quality_Fertilizer "Quality Fertilizer") | Coopmaster.png **Coopmaster** Befriend [coop animals](/Animals#Coop_Animals "Animals") quicker. Incubation time (for [Incubator](/Incubator "Incubator"), [Ostrich Incubator](/Ostrich_Incubator "Ostrich Incubator"), and [Slime Incubator](/Slime_Incubator "Slime Incubator")) cut in half.  (Also improves coop product quality, see details [here](/Farming#Effect_of_Coopmaster_and_Shepherd_on_Animal_Product_Quality_Frequency "Farming")) | Artisan.png **Artisan** [Artisan goods](/Artisan_Goods "Artisan Goods") (wine, cheese, oil, etc.) worth 40% more.  (Note that [oil](/Oil "Oil") does not actually benefit from the Artisan Profession) |
| Shepherd.png **Shepherd** Befriend [barn animals](/Animals#Barn_Animals "Animals") quicker. [Sheep](/Sheep "Sheep") produce wool faster.  (Also improves barn product quality, see details [here](/Farming#Effect_of_Coopmaster_and_Shepherd_on_Animal_Product_Quality_Frequency "Farming")) | Agriculturist.png **Agriculturist** All [crops](/Crops "Crops") grow 10% faster. |

### Effect of Coopmaster and Shepherd on Animal Product Quality Frequency

On top of the ability in the skill description of befriending the relevant animal type faster (+30 friendship when petted instead of the base +15) and either halving incubation time or increasing wool production from sheep, the Coopmaster and Shepherd professions have a hidden benefit that isn't stated anywhere in the game. They each add 0.333 to the score used to calculate product quality for the animal type relevant to the skill. This results in substantially higher rates of iridium quality products. To illustrate, below is a table showing average frequency of iridium, gold and silver products with and without the Shepherd/Coopmaster professions for an animal with max friendship (1000, ie. 5 hearts) and max mood (255):

| Profession | % Iridium quality | % Gold quality | % Silver quality | Average price (% of base price) |
| --- | --- | --- | --- | --- |
| No (or other) Profession | 56.665% | 24.556% | 18.779% | 173.638% |
| Coopmaster or Shepherd | 73.315% | 19.564% | 7.121% | 184.877% |

#### Complete Formula

| Details |
| --- |
| The game normally calculates animal product quality using a **score** for each animal with the following formula: `((Friendship/1000) - (1 - (Mood/225))` (interestingly, the game doesn't factor in daily luck in this calculation) For example, an animal with 1000 Friendship and 255 Mood (max friendship and mood) would be calculated thus:  `=((1000/1000) - (1 - (255/225))`  `=1 - (1 - 1.1333...)`  `=1 + 0.1333...`  `=1.1333...`  The game will begin checking what quality to create by first seeing if the **whole score** is above 0.95. If it is, the **score divided by 2** will be compared against a random number between 0-1. If the **score divided by 2** is greater than the random number, the item will be Iridium quality. If the score is below 0.95 or the check fails, the **score divided by 2** will then be compared against a random number between 0-1. If the **score divided by 2** is greater than the random number, the item will be Gold quality. If that check also fails, the **whole score** will then be compared against a random number between 0-1. If it is greater than the random number, the item will be Silver quality. Finally, if that check also fails, the item will be normal quality (though in the example above, the score is higher than 1, so a check for silver quality will always succeed if the two prior fail).  *(Note that the 0.333 bonus to the score by the Coopmaster and Shepherd professions is applied to the whole score, not the halved score.)*  Since the score is above 1 and the odds of normal quality produce can be ignored, the odds in this example without the bonus 0.333 can be calculated as:  `1.1333 / 2 = 0.56665 = 56.665% iridium`  `(1 - 0.56665) × (1.1333 / 2) = 0.24556 = 24.556% gold`  `1 - 0.56665 - 0.24556 = 0.18779 = 18.779% silver`  Since iridium products are worth 2× base price, gold products are worth 1.5× base price, and silver products are worth 1.25× base price, we can then calculate the percentage of base price in profits this results in:  `=(0.56665 × 2) + (0.24556 × 1.5) + (0.18779 × 1.25)`  `= 1.13330 + 0.36834 + 0.23474`  `= 1.73638 = 173.638%` |

### Crop Quality Frequency

Quality is determined when the crop is harvested, and not when it is planted. For crops that produce multiples at harvest (*i.e.,* [Coffee Bean](/Coffee_Bean "Coffee Bean"), [Blueberry](/Blueberry "Blueberry"), [Cranberries](/Cranberries "Cranberries")), [Basic](/Basic_Fertilizer "Basic Fertilizer") and [Quality](/Quality_Fertilizer "Quality Fertilizer") fertilizers affect only the first crop produced.

First the game tests if the crop gets gold quality, if it doesn't it tries again with silver quality. If both fail the crop is normal quality. Quality is also dependent on the use of [Fertilizer](/Fertilizer "Fertilizer").

The basic formula for finding a gold quality crop (not including fertilizer) is 1% + 2% per farming level. The basic formula for finding a silver quality crop is 2% + 4% per level, though the game must first fail to award a gold quality crop before it will check to award a silver quality crop, so the chances for a silver quality are slightly reduced. The tables below show the probabilities of harvesting each quality of crop. Note that it is possible to reach Farming level 11-14 with buffs from [Food](#Food).

#### Normal soil

| [Farming level](/Farming#Farming_Skill "Farming") | % Regular quality | % Silver quality | % Gold quality | Average price |
| --- | --- | --- | --- | --- |
| 0 | 97% | 2% | 1% | 1.01 |
| 1 | 91% | 6% | 3% | 1.03 |
| 2 | 85% | 10% | 5% | 1.05 |
| 3 | 80% | 13% | 7% | 1.07 |
| 4 | 75% | 16% | 9% | 1.09 |
| 5 | 69% | 20% | 11% | 1.10 |
| 6 | 64% | 23% | 13% | 1.12 |
| 7 | 60% | 25% | 15% | 1.14 |
| 8 | 55% | 28% | 17% | 1.16 |
| 9 | 50% | 31% | 19% | 1.17 |
| 10 | 46% | 33% | 21% | 1.19 |
| 11 | 42% | 35% | 23% | 1.20 |
| 12 | 38% | 37% | 25% | 1.22 |
| 13 | 34% | 39% | 27% | 1.23 |
| 14 | 30% | 41% | 29% | 1.25 |

#### Soil with Basic Fertilizer

| [Farming level](/Farming#Farming_Skill "Farming") | % Regular quality | % Silver quality | % Gold quality | Average price |
| --- | --- | --- | --- | --- |
| 0 | 88% | 8% | 4% | 1.04 |
| 1 | 77% | 15% | 8% | 1.08 |
| 2 | 68% | 20% | 12% | 1.11 |
| 3 | 59% | 26% | 15% | 1.14 |
| 4 | 50% | 31% | 19% | 1.17 |
| 5 | 42% | 35% | 23% | 1.20 |
| 6 | 35% | 39% | 26% | 1.23 |
| 7 | 28% | 42% | 30% | 1.25 |
| 8 | 22% | 44% | 34% | 1.28 |
| 9 | 16% | 47% | 37% | 1.30 |
| 10 | 15% | 44% | 41% | 1.32 |
| 11 | 14% | 41% | 45% | 1.33 |
| 12 | 13% | 39% | 48% | 1.34 |
| 13 | 12% | 36% | 52% | 1.35 |
| 14 | 11% | 33% | 56% | 1.36 |

#### Soil with Quality Fertilizer

| [Farming level](/Farming#Farming_Skill "Farming") | % Regular quality | % Silver quality | % Gold quality | Average price |
| --- | --- | --- | --- | --- |
| 0 | 78% | 14% | 8% | 1.07 |
| 1 | 64% | 23% | 13% | 1.12 |
| 2 | 52% | 30% | 18% | 1.17 |
| 3 | 40% | 36% | 24% | 1.21 |
| 4 | 30% | 41% | 29% | 1.25 |
| 5 | 21% | 45% | 34% | 1.28 |
| 6 | 15% | 45% | 40% | 1.31 |
| 7 | 14% | 41% | 45% | 1.33 |
| 8 | 13% | 37% | 50% | 1.34 |
| 9 | 11% | 33% | 56% | 1.36 |
| 10 | 10% | 29% | 61% | 1.38 |
| 11 | 9% | 25% | 66% | 1.39 |
| 12 | 7% | 21% | 72% | 1.41 |
| 13 | 6% | 17% | 77% | 1.43 |
| 14 | 4% | 13% | 82% | 1.44 |

#### Soil with Deluxe Fertilizer

Normal quality crops cannot be produced when using Deluxe Fertilizer.

| [Farming level](/Farming#Farming_Skill "Farming") | % Silver quality | % Gold quality | % Iridium Quality | Average price |
| --- | --- | --- | --- | --- |
| 0 | 84% | 10% | 6% | 1.32 |
| 1 | 75% | 16% | 9% | 1.36 |
| 2 | 66% | 22% | 13% | 1.40 |
| 3 | 57% | 27% | 16% | 1.44 |
| 4 | 49% | 31% | 20% | 1.47 |
| 5 | 42% | 35% | 23% | 1.51 |
| 6 | 35% | 39% | 27% | 1.55 |
| 7 | 28% | 42% | 30% | 1.58 |
| 8 | 22% | 45% | 34% | 1.61 |
| 9 | 16% | 47% | 37% | 1.64 |
| 10 | 11% | 48% | 41% | 1.67 |
| 11 | 7% | 49% | 44% | 1.70 |
| 12 | 3% | 50% | 47% | 1.73 |
| 13 | 0% | 49% | 51% | 1.76 |
| 14 | 0% | 46% | 55% | 1.77 |

#### Complete Formula

The probability that a crop's quality increases is linear with respect to your farming level and the soil fertilizer quality (0 for normal soil, 1 for [Basic Fertilizer](/Basic_Fertilizer "Basic Fertilizer"), 2 for [Quality Fertilizer](/Quality_Fertilizer "Quality Fertilizer"), and 3 for [Deluxe Fertilizer](/Deluxe_Fertilizer "Deluxe Fertilizer")). That is, the probability increases the same amount with each level for the same fertilizer quality, and with each fertilizer quality for the same farming level.

The formulas used in the game's code are as follows [[1]](#cite_note-qualitycrops-1):

| Quality | Formula |
| --- | --- |
| [Gold Quality.png](/File:Gold_Quality.png) Gold | `0.2 * (farming level / 10) + 0.2 * (fertilizer level) * ((farming level + 2) / 12) + 0.01` |
| [Silver Quality.png](/File:Silver_Quality.png) Silver | `2 * chance for gold quality` (capped at 75%) |
| [Iridium Quality.png](/File:Iridium_Quality.png) Iridium | `chance for gold quality / 2` |

Additionally, if the fertilizer is deluxe or better, then silver is the guaranteed minimum quality, and iridium is made possible.

The game checks each formula in the order iridium, gold, and silver. Note the probability calculation must take that into account: for instance on a soil without deluxe fertilizer, silver quality can be selected only if gold has not been chosen, and then the global chance for silver is equal to `(1 - chance for gold quality) * (minimum between (0.75) and (2 * chance for gold quality))`.

## Experience Points

The amount of experience gained from harvesting crops varies from crop to crop, with more expensive crops giving more experience upon harvest. Crops with multiple harvests give experience for every harvest. Crops that yield multiple produce per harvest, such as [blueberry](/Blueberry "Blueberry"), [cranberry](/Cranberries "Cranberries"), or [potato](/Potato "Potato"), only reward experience for the first product and do not offer any extra experience for the multiples.

Petting a farm [animal](/Animal "Animal"), [milking](/Milk_Pail "Milk Pail") a [cow](/Cow "Cow") or [goat](/Goat "Goat"), [shearing](/Shears "Shears") a [sheep](/Sheep "Sheep"), or picking up an animal product inside a [coop](/Coop "Coop") gives 5 experience points each. (Picking up [Truffles](/Truffle "Truffle") gives [Foraging](/Foraging "Foraging") experience rather than Farming experience.)

250 Farming XP is gained for reading a copy of the [Stardew Valley Almanac](/Stardew_Valley_Almanac "Stardew Valley Almanac") or [Book Of Stars](/Book_Of_Stars "Book Of Stars").

To level up farming from level 0 to 1, it takes 13 parsnips, or 8 potatoes, or 5 cauliflowers. From level 0 to 2, it takes about 48 parsnips, or 28 potatoes, or 17 cauliflowers.

| Spring | |
| --- | --- |
| Crop | XP |
| Coffee Bean.png [Coffee Bean](/Coffee_Bean "Coffee Bean") | 4 |
| Tulip.png [Tulip](/Tulip "Tulip") | 7 |
| Unmilled Rice.png [Unmilled Rice](/Unmilled_Rice "Unmilled Rice") | 7 |
| Carrot.png [Carrot](/Carrot "Carrot") | 8 |
| Parsnip.png [Parsnip](/Parsnip "Parsnip") | 8 |
| Green Bean.png [Green Bean](/Green_Bean "Green Bean") | 9 |
| Blue Jazz.png [Blue Jazz](/Blue_Jazz "Blue Jazz") | 10 |
| Garlic.png [Garlic](/Garlic "Garlic") | 12 |
| Potato.png [Potato](/Potato "Potato") | 14 |
| Kale.png [Kale](/Kale "Kale") | 17 |
| Strawberry.png [Strawberry](/Strawberry "Strawberry") | 18 |
| Cauliflower.png [Cauliflower](/Cauliflower "Cauliflower") | 23 |
| Rhubarb.png [Rhubarb](/Rhubarb "Rhubarb") | 26 |
| Ancient Fruit.png [Ancient Fruit](/Ancient_Fruit "Ancient Fruit") | 38 |
| Cactus Fruit.png [Cactus Fruit](/Cactus_Fruit "Cactus Fruit") | 14 |

| Summer | |
| --- | --- |
| Crop | XP |
| Coffee Bean.png [Coffee Bean](/Coffee_Bean "Coffee Bean") | 4 |
| Hops.png [Hops](/Hops "Hops") | 6 |
| Wheat.png [Wheat](/Wheat "Wheat") | 6 |
| Hot Pepper.png [Hot Pepper](/Hot_Pepper "Hot Pepper") | 9 |
| Summer Squash.png [Summer Squash](/Summer_Squash "Summer Squash") | 9 |
| Blueberry.png [Blueberry](/Blueberry "Blueberry") | 10 |
| Corn.png [Corn](/Corn "Corn") | 10 |
| Tomato.png [Tomato](/Tomato "Tomato") | 12 |
| Sunflower.png [Sunflower](/Sunflower "Sunflower") | 5[[2]](#cite_note-sunflower-2) |
| Radish.png [Radish](/Radish "Radish") | 15 |
| Summer Spangle.png [Summer Spangle](/Summer_Spangle "Summer Spangle") | 15 |
| Poppy.png [Poppy](/Poppy "Poppy") | 20 |
| Melon.png [Melon](/Melon "Melon") | 27 |
| Red Cabbage.png [Red Cabbage](/Red_Cabbage "Red Cabbage") | 28 |
| Starfruit.png [Starfruit](/Starfruit "Starfruit") | 43 |
| Ancient Fruit.png [Ancient Fruit](/Ancient_Fruit "Ancient Fruit") | 38 |
| Cactus Fruit.png [Cactus Fruit](/Cactus_Fruit "Cactus Fruit") | 14 |
| Taro Root.png [Taro Root](/Taro_Root "Taro Root") | 16 |
| Pineapple.png [Pineapple](/Pineapple "Pineapple") | 30 |

| Fall | |
| --- | --- |
| Crop | XP |
| Wheat.png [Wheat](/Wheat "Wheat") | 6 |
| Corn.png [Corn](/Corn "Corn") | 10 |
| Eggplant.png [Eggplant](/Eggplant "Eggplant") | 12 |
| Broccoli.png [Broccoli](/Broccoli "Broccoli") | 13 |
| Bok Choy.png [Bok Choy](/Bok_Choy "Bok Choy") | 14 |
| Cranberries.png [Cranberries](/Cranberries "Cranberries") | 14 |
| Grape.png [Grape](/Grape "Grape") | 14 |
| Sunflower.png [Sunflower](/Sunflower "Sunflower") | 5[[2]](#cite_note-sunflower-2) |
| Beet.png [Beet](/Beet "Beet") | 16 |
| Amaranth.png [Amaranth](/Amaranth "Amaranth") | 21 |
| Artichoke.png [Artichoke](/Artichoke "Artichoke") | 22 |
| Yam.png [Yam](/Yam "Yam") | 22 |
| Fairy Rose.png [Fairy Rose](/Fairy_Rose "Fairy Rose") | 29 |
| Pumpkin.png [Pumpkin](/Pumpkin "Pumpkin") | 31 |
| Ancient Fruit.png [Ancient Fruit](/Ancient_Fruit "Ancient Fruit") | 38 |
| Sweet Gem Berry.png [Sweet Gem Berry](/Sweet_Gem_Berry "Sweet Gem Berry") | 64 |
| Cactus Fruit.png [Cactus Fruit](/Cactus_Fruit "Cactus Fruit") | 14 |

| Winter | |
| --- | --- |
| Crop | XP |
| Powdermelon.png [Powdermelon](/Powdermelon "Powdermelon") | 12 |

The experience points awarded are calculated using the formula `XP=||16 × ln(0.018 × PRICE + 1)||` where PRICE is the base sell price of the crop (listed in [Data/Objects.xnb](/Modding:Objects "Modding:Objects")). High quality crops grant the same amount of XP as normal-quality crops.

Harvesting forage plants grown from [Wild Seeds](/Crafting#Seeds "Crafting") grants 3 Farming experience points and 2 [Foraging](/Foraging "Foraging") experience points per plant.

Experience level is increased immediately upon harvesting, but the "level up" window doesn't appear until after going to sleep.

| Lvl | Total Lifetime Parsnips Harvested | Experience |
| --- | --- | --- |
| 1 | 13 | 100 |
| 2 | 48 | 380 |
| 3 | 97 | 770 |
| 4 | 163 | 1300 |
| 5 | 269 | 2150 |
| 6 | 413 | 3300 |
| 7 | 600 | 4800 |
| 8 | 863 | 6900 |
| 9 | 1250 | 10000 |
| 10 | 1875 | 15000 |

## Food

Certain [cooked dishes](/Cooking "Cooking") will temporarily increase farming level. [Qi Seasoning](/Qi_Seasoning "Qi Seasoning") can be applied to further increase the stat buff for dishes cooked by the player.

| Image | Name | Description | Ingredients | Energy / Health | Buff(s) | Buff Duration | Recipe Source(s) | Sell Price |
| --- | --- | --- | --- | --- | --- | --- | --- | --- |
| [Complete Breakfast.png](/File:Complete_Breakfast.png) | [Complete Breakfast](/Complete_Breakfast "Complete Breakfast") | You'll feel ready to take on the world! | Fried Egg.png [Fried Egg](/Fried_Egg "Fried Egg") (1)Milk.png [Milk](/Milk "Milk") (1)Hashbrowns.png [Hashbrowns](/Hashbrowns "Hashbrowns") (1)Pancakes.png [Pancakes](/Pancakes "Pancakes") (1) | Energy.png 200 Health.png 90 | Farming.png Farming (+2)Max Energy.png [Max Energy](/Energy "Energy") (+50) | Time Icon.png 7m | |  |  | | --- | --- | | Cooking Channel.png | [The Queen of Sauce](/The_Queen_of_Sauce "The Queen of Sauce") | | 21 Spring, Year 2 | | data-sort-value="350">Gold.png350g |
| [Hashbrowns.png](/File:Hashbrowns.png) | [Hashbrowns](/Hashbrowns "Hashbrowns") | Crispy and golden-brown! | Potato.png [Potato](/Potato "Potato") (1)Oil.png [Oil](/Oil "Oil") (1) | Energy.png 90 Health.png 40 | Farming.png Farming (+1) | Time Icon.png 5m 35s | |  |  | | --- | --- | | Cooking Channel.png | [The Queen of Sauce](/The_Queen_of_Sauce "The Queen of Sauce") | | 14 Spring, Year 2 |     Gus Icon.png [Stardrop Saloon](/The_Stardrop_Saloon#Menu "The Stardrop Saloon") for data-sort-value="50">Gold.png50g | data-sort-value="120">Gold.png120g |
| [Pepper Poppers.png](/File:Pepper_Poppers.png) | [Pepper Poppers](/Pepper_Poppers "Pepper Poppers") | Spicy breaded peppers filled with cheese. | Hot Pepper.png [Hot Pepper](/Hot_Pepper "Hot Pepper") (1)Cheese.png [Cheese](/Cheese "Cheese") (1) | Energy.png 130 Health.png 58 | Farming.png Farming (+2)Speed.png [Speed](/Speed "Speed") (+1) | Time Icon.png 7m | Shane Icon.png [Shane](/Shane "Shane") (Mail - 3+ HeartIconLarge.png) | data-sort-value="200">Gold.png200g |
| [Tom Kha Soup.png](/File:Tom_Kha_Soup.png) | [Tom Kha Soup](/Tom_Kha_Soup "Tom Kha Soup") | These flavors are incredible! | Coconut.png [Coconut](/Coconut "Coconut") (1)Shrimp.png [Shrimp](/Shrimp "Shrimp") (1)Common Mushroom.png [Common Mushroom](/Common_Mushroom "Common Mushroom") (1) | Energy.png 175 Health.png 78 | Farming.png Farming (+2)Max Energy.png [Max Energy](/Energy "Energy") (+30) | Time Icon.png 7m | Sandy Icon.png [Sandy](/Sandy "Sandy") (Mail - 7+ HeartIconLarge.png) | data-sort-value="250">Gold.png250g |
| [Farmer's Lunch.png](/File:Farmer%27s_Lunch.png) | [Farmer's Lunch](/Farmer%27s_Lunch "Farmer's Lunch") | This'll keep you going. | Omelet.png [Omelet](/Omelet "Omelet") (1)Parsnip.png [Parsnip](/Parsnip "Parsnip") (1) | Energy.png 200 Health.png 90 | Farming.png Farming (+3) | Time Icon.png 5m 35s | Farming Skill Icon.png Farming Level 3 | data-sort-value="150">Gold.png150g |
| [Maple Bar.png](/File:Maple_Bar.png) | [Maple Bar](/Maple_Bar "Maple Bar") | It's a sweet doughnut topped with a rich maple glaze. | Maple Syrup.png [Maple Syrup](/Maple_Syrup "Maple Syrup") (1)Sugar.png [Sugar](/Sugar "Sugar") (1)Wheat Flour.png [Wheat Flour](/Wheat_Flour "Wheat Flour") (1) | Energy.png 225 Health.png 101 | Farming.png Farming (+1)Fishing.png [Fishing](/Fishing "Fishing") (+1)Mining.png [Mining](/Mining "Mining") (+1) | Time Icon.png 16m 47s | |  |  | | --- | --- | | Cooking Channel.png | [The Queen of Sauce](/The_Queen_of_Sauce "The Queen of Sauce") | | 14 Summer, Year 2 | | data-sort-value="300">Gold.png300g |

## Crops

| [Crops](/Crops "Crops") | |
| --- | --- |
| [Spring](/Spring#Crops "Spring") | [Blue Jazz](/Blue_Jazz "Blue Jazz") • [Carrot](/Carrot "Carrot") • [Cauliflower](/Cauliflower "Cauliflower") • [Coffee Bean](/Coffee_Bean "Coffee Bean") • [Garlic](/Garlic "Garlic") • [Green Bean](/Green_Bean "Green Bean") • [Kale](/Kale "Kale") • [Parsnip](/Parsnip "Parsnip") • [Potato](/Potato "Potato") • [Rhubarb](/Rhubarb "Rhubarb") • [Strawberry](/Strawberry "Strawberry") • [Tulip](/Tulip "Tulip") • [Unmilled Rice](/Unmilled_Rice "Unmilled Rice") |
| [Summer](/Summer#Crops "Summer") | [Blueberry](/Blueberry "Blueberry") • [Coffee Bean](/Coffee_Bean "Coffee Bean") • [Corn](/Corn "Corn") • [Hops](/Hops "Hops") • [Hot Pepper](/Hot_Pepper "Hot Pepper") • [Melon](/Melon "Melon") • [Poppy](/Poppy "Poppy") • [Radish](/Radish "Radish") • [Red Cabbage](/Red_Cabbage "Red Cabbage") • [Starfruit](/Starfruit "Starfruit") • [Summer Spangle](/Summer_Spangle "Summer Spangle") • [Summer Squash](/Summer_Squash "Summer Squash") • [Sunflower](/Sunflower "Sunflower") • [Tomato](/Tomato "Tomato") • [Wheat](/Wheat "Wheat") |
| [Fall](/Fall#Crops "Fall") | [Amaranth](/Amaranth "Amaranth") • [Artichoke](/Artichoke "Artichoke") • [Beet](/Beet "Beet") • [Bok Choy](/Bok_Choy "Bok Choy") • [Broccoli](/Broccoli "Broccoli") • [Corn](/Corn "Corn") • [Cranberries](/Cranberries "Cranberries") • [Eggplant](/Eggplant "Eggplant") • [Fairy Rose](/Fairy_Rose "Fairy Rose") • [Grape](/Grape "Grape") • [Pumpkin](/Pumpkin "Pumpkin") • [Sunflower](/Sunflower "Sunflower") • [Wheat](/Wheat "Wheat") • [Yam](/Yam "Yam") |
| [Winter](/Winter#Crops "Winter") | [Powdermelon](/Powdermelon "Powdermelon") |
| Special | [Ancient Fruit](/Ancient_Fruit "Ancient Fruit") • [Cactus Fruit](/Cactus_Fruit "Cactus Fruit") • [Pineapple](/Pineapple "Pineapple") • [Qi Fruit](/Qi_Fruit "Qi Fruit") • [Sweet Gem Berry](/Sweet_Gem_Berry "Sweet Gem Berry") • [Taro Root](/Taro_Root "Taro Root") • [Tea Leaves](/Tea_Leaves "Tea Leaves") |

## References

1. [↑](#cite_ref-qualitycrops_1-0) See `Crop::harvest` in the game code.
2. ↑ [2.0](#cite_ref-sunflower_2-0) [2.1](#cite_ref-sunflower_2-1) In `Crop::harvest`, Sunflower Seeds are substituted for Sunflowers before XP is calculated. Therefore, the price of Sunflower Seeds is used.

## History

* [1.0](/Version_History#1.0 "Version History"): Introduced.
* [1.1](/Version_History#1.1 "Version History"): Adjusted Rancher bonus to 20%, up from 10%, Artisan now increases the value of [Artisan Goods](/Artisan_Goods "Artisan Goods") by 40%, down from 50%.
* [1.2.26](/Version_History#1.2.26 "Version History"): Farming level now affects crop yield prior to level 10.
* [1.3.27](/Version_History#1.3.27 "Version History"): Fixed bug that prevented farming XP being granted when harvesting with Scythe.
* [1.6](/Version_History#1.6 "Version History"): Farming Experience can now be gained by reading the [Stardew Valley Almanac](/Stardew_Valley_Almanac "Stardew Valley Almanac") or [Book Of Stars](/Book_Of_Stars "Book Of Stars"). Harvesting [Wild Seeds](/Wild_Seeds "Wild Seeds") now gives 3 Farming XP.

| [Skills](/Skills "Skills") & Stats | |
| --- | --- |
| [Skills](/Skills "Skills") | Farming • [Mining](/Mining "Mining") • [Foraging](/Foraging "Foraging") • [Fishing](/Fishing "Fishing") • [Combat](/Combat "Combat") |
| Stats | [Attack](/Attack "Attack") • [Crit. Chance](/Crit._Chance "Crit. Chance") • [Crit. Power](/Crit._Power "Crit. Power") • [Defense](/Defense "Defense") • [Immunity](/Immunity "Immunity") • [Luck](/Luck "Luck") • [Magnetism](/Magnetism "Magnetism") • [Speed](/Speed "Speed") • [Weight](/Weight "Weight") |