# Grass

|  |  |
| --- | --- |
| Grass | |
| [Wild Grass Screenshot.png](/File:Wild_Grass_Screenshot.png) | |
|  | |
| Information | |
| Seed | Grass Starter.png [Grass Starter](/Grass_Starter "Grass Starter") |
| Growth Time | Varies |
| Season | * Spring.png [Spring](/Spring "Spring") * Summer.png [Summer](/Summer "Summer") * Fall.png [Fall](/Fall "Fall") |

**Grass** is a naturally-occurring dynamic resource on the player's [farm](/The_Farm "The Farm"). Many unconfined fields of grass can be found there at the start of the game. Each day, it is likely that existing grass will expand and grow into adjacent unoccupied tiles. And occasionally, grass spawns randomly on any unoccupied tile on the farm. The player can choose to plant a new tile with [Grass Starter](/Grass_Starter "Grass Starter") also, creating a fully grown patch of new grass. Grass continues to sprout and grow throughout the [spring](/Spring "Spring"), [summer](/Summer "Summer"), and [fall](/Fall "Fall") seasons. In [winter](/Winter "Winter"), it goes dormant until the next spring.

Grass can be cut using a scythe, sword, or dagger. If the player has built a [Silo](/Silo "Silo"), each patch of grass cut with the basic [Scythe](/Scythe "Scythe") has a 50% chance of producing [Hay](/Hay "Hay"), which is automatically added to the contents of the silo. With a [Golden Scythe](/Golden_Scythe "Golden Scythe"), there's a 75% chance, and with an [Iridium Scythe](/Iridium_Scythe "Iridium Scythe"), there's a 100% chance. During winter, hay chances for all scythes are reduced by 67%.[[1]](#cite_note-trydropitems-1) Once all the farm's silos are full, no more hay is produced or stored until there is available room. Cutting grass with a sword or dagger does not produce hay at any time.

Storing enough hay to feed all the farm's [animals](/Animals "Animals") for all 28 days of winter can save money or extra labor, since cutting grass in winter produces less hay than in the growing seasons. No new grass grows in winter, so it could run out entirely. Hay can be purchased at [Marnie's Ranch](/Marnie%27s_Ranch "Marnie's Ranch") for data-sort-value="50">![Gold.png](/mediawiki/images/thumb/1/10/Gold.png/18px-Gold.png)50g each. [Marnie](/Marnie "Marnie") occasionally sends a gift of 30 hay in the mail, at any [friendship](/Friendship "Friendship") level greater than 0 points.

## Blue Grass

[![](/mediawiki/images/thumb/3/3d/Blue_Grass.png/300px-Blue_Grass.png)](/File:Blue_Grass.png)

Blue Grass

Blue Grass appears naturally on [Meadowlands farms](/Farm_Maps#Meadowlands "Farm Maps"). A recipe for [Blue Grass Starter](/Blue_Grass_Starter "Blue Grass Starter") can be purchased in [Qi's Walnut Room](/Qi%27s_Walnut_Room "Qi's Walnut Room") for data-sort-value="40">![Qi Gem.png](/mediawiki/images/thumb/7/78/Qi_Gem.png/24px-Qi_Gem.png) 40, which allows Blue Grass to be placed on other farm types.

Animals eating Blue Grass gain twice as much friendship as from eating normal Grass (16 instead of 8).[[2]](#cite_note-animaleat-2) If successfully cut with a Scythe, Blue Grass will produce two pieces of hay, instead of the usual one.[[1]](#cite_note-trydropitems-1)

Animals eat half the amount of tufts of Blue Grass compared to normal Grass (Coop animals 1 instead of 2 tufts, Barn animals 2 instead of 4 tufts).[[3]](#cite_note-grassreduceby-3)

## Tips

* Grass will only naturally spread to tillable soil tiles. It will not naturally spread on green, 'grassy' tiles.
* Most paths, fences, closed gates, or pieces of furniture (such as chests or braziers) prevent the spread of grass through the tile it occupies.
* It is possible to exploit this by sectioning off patches of grass in animal enclosures, preventing them from eating all the grass in the area. This allows the grass to regrow more quickly, stemming from the fenced-off source patch.
* Placing a fence on any type of grass will prevent [Animals](/Animals "Animals") from eating it.
* [Animals](/Animals "Animals") love Blue Grass, so it's helpful to keep some near your farm buildings.
  + Note that Blue Grass does not spontaneously spawn on any [Farm Maps](/Farm_Maps "Farm Maps") except for the Meadowlands Farm.

## Notes

* Grass has a -1 [Speed](/Speed#Player_Speed "Speed") penalty, unless the player has read the [Ol' Slitherlegs](/Ol%27_Slitherlegs "Ol' Slitherlegs") book, which reduces the penalty to -0.33. There is no speed penalty when riding a [horse](/Animals#Horse "Animals") through grass.

## Propagation

Each fully grown grass tile consists of 4 tufts of grass. Each day, every individual tile containing normal Grass will grow 1-3 tufts (randomly determined).[[4]](#cite_note-grassdayupdate-4) Additionally every tile containing normal or Blue Grass has a 65% chance of growing. If the tile containing grass has less than 4 tufts and succeeds a growth check, it will grow 0-2 additional tufts of grass (randomly determined). If a fully grown grass tile succeeds a growth check, it will check all 4 adjacent tiles. If they are tillable, there is a 25% chance for each tile for 1-2 tufts of grass to grow.[[5]](#cite_note-growweedgrass-5)

On the 1st of spring in year 2+ there will be 40 iterations of growth checks of all grass tiles.[[6]](#cite_note-handlegrassgrowth-6)

## References

1. ↑ [1.0](#cite_ref-trydropitems_1-0) [1.1](#cite_ref-trydropitems_1-1)  See `Grass::TryDropItemsOnCut` in the game code.
2. [↑](#cite_ref-animaleat_2-0)  See `FarmAnimal::Eat` in the game code.
3. [↑](#cite_ref-grassreduceby_3-0)  See `Grass::reduceBy` in the game code.
4. [↑](#cite_ref-grassdayupdate_4-0)  See `Grass::dayUpdate` in the game code.
5. [↑](#cite_ref-growweedgrass_5-0)  See `GameLocation::growWeedGrass` in the game code.
6. [↑](#cite_ref-handlegrassgrowth_6-0)  See `GameLocation::HandleGrassGrowth` in the game code.

## History

* [1.0](/Version_History#1.0 "Version History"): Introduced standard green grass.
* [1.5.6](/Version_History#1.5.6 "Version History"): Grass grown inside (such as inside the [Greenhouse](/Greenhouse "Greenhouse")) no longer disappears on the first day of [Winter](/Winter "Winter").
* [1.6](/Version_History#1.6 "Version History"): Grass grown outside no longer disappears on the first day of [Winter](/Winter "Winter"), but goes dormant until [Spring](/Spring "Spring"). Added Blue Grass and [Blue Grass Starter](/Blue_Grass_Starter "Blue Grass Starter") on [Meadowlands Farm](/Farm_Maps "Farm Maps"). Reading [Ol' Slitherlegs](/Ol%27_Slitherlegs "Ol' Slitherlegs") now reduces the speed penalty from -1 to -0.33.
* [1.6.9](/Version_History#1.6.9 "Version History"): Blue Grass now spreads at the same rate as normal grass. Fixed bug where [Villagers](/Villagers "Villagers") would avoid tiles containing grass.