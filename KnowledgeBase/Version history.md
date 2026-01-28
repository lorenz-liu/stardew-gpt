# Version History

Stardew Valley was released on 26 February 2016 for Windows PC after almost four years of closed development. Linux and macOS compatibility was released in a free update on 29 July 2016.

*For a detailed breakdown of changes specific to console versions of the game see [Console Version History](/Console_Version_History "Console Version History").*
  
*For a detailed breakdown of changes specific to the mobile version of the game see [Mobile Version History](/Mobile_Version_History "Mobile Version History").*

## 1.6.15

Stardew Valley 1.6.15 was [released](https://store.steampowered.com/news/app/413150/view/517448731263500640) on 20 December 2024.

Balance changes
:   * Legendary fish ponds now produce roe much more often and have a higher average daily value.

Quality of life changes
:   * Performance optimizations.
    * Added the Junimo bundle button to fridge and mini-fridge UIs.
    * Fixed debris able to spread under giant crops.
    * Fixed bad-word filtering added to some extra text boxes in 1.6. Those are now only filtered on platforms that require it, as originally intended.

Gameplay fixes
:   * Fixed Krobus' shop not accessible on Fridays for Japanese players.
    * Fixed some achievements not unlocked retroactively in some cases.
    * Fixed some things being less random than intended.
    * Fixed new-game data corruption issue, where viewing the load screen before creating a new save in rare cases would incorrectly copy data from one of the load slots into the new save.
    * Fixed some older items in the lost & found not correctly retrieveable.
    * Fixed crash when collecting empty crab pots.
    * Fixed crash when farm animals somehow end up in multiple locations.
    * Fixed crash when failing to play/resume/pause/stop sound effects.
    * Fixed crash in raccoon menu if you have a base flavored item in your inventory.
    * Fixed crash if a shop somehow has a null item from a player to sell.
    * Fixed rare crash in Calico Jack minigame.
    * Fixed error loading pre-1.6 saves with case-sensitive stat key conflicts; conflicting stats are now merged.
    * Fixed selected tool lost in some cases when obtaining a stardrop.

Multiplayer fixes
:   * Fixed some mail getting re-sent to farmhands every day.
    * Fixed unable to join a server whose invite code contains a bad word.
    * Fixed issue where the host's mine levels could be frozen in time.
    * Fixed crash in WeGame version.
    * Fixed crash when a farmhand passes out while warping between locations.
    * Fixed `/unlinkPlayer` and other multiplayer chat commands sometimes using the first player instead of the intended one.
    * Fixed co-op menu scroll not reset when switching tab.

Display text and localization fixes
:   * Improved Hungarian, Japanese, and Russian translations.
    * Fixed a missing period in the shears description.
    * Fixed some item tooltips on the collection tab in some languages showing a raw `{1}` token.
    * Fixed gray box behind Russian railroad sign.
    * Fixed Robin's start-construction message showing the general building name inconsistently.
    * Fixed a few translated dialogues with broken dialogue commands.

Cosmetic fixes
:   * Fixed Alex's hand in one of his portraits.
    * Fixed butterflies spawned by statue of blessings glitching out in summer.

Changes for modded players
:   * Fixed support for fridges with a larger capacity.
    * Fixed buildings visually matching the calendar season even if their location has a different season.
    * Fixed interior doors not working if you wake up in their location.
    * Fixed crash on powers tab hover if a mod added an entry with no display name.
    * Added logs to track game load timing.

Changes for mod authors
:   * See [mod author notes on the wiki](/Modding:Migrate_to_Stardew_Valley_1.6.9#1.6.15 "Modding:Migrate to Stardew Valley 1.6.9").

## 1.6.14

Stardew Valley 1.6.14 was [released](https://store.steampowered.com/news/app/413150/view/4443457735847051443) on 12 November 2024.

New content & features
:   * Added a few extra spouse reactions when interacting with them without dialogue.

Gameplay fixes
:   * You no longer lose a fish if you pass out while holding it, or pass out while fishing into a fish pond.
    * Fixed animal products always harvesting with base quality.
    * Fixed chimney duplication when creating a new 1.6.9+ save.
    * Fixed players inside farm buildings mis-positioned on the world map.
    * Fixed spouses sometimes facing the wrong direction after an interaction.
    * Fixed rare crash when obtaining stardrops with stowed tools.
    * Fixed rare crash when updating Robin's construction animation.
    * Fixed roommates requiring two house upgrades instead of one (like marriage candidates).
    * Made geode menu more stable if you resize the window during geode opening.

Multiplayer fixes
:   * Fixed spouses being warped to 0,0 for farmhands.
    * Fixed crash when homeless farmhands remain after deleting cabins.

Display text and localization fixes
:   * Improved Russian translations.

Technical fixes
:   * Improved efficiency of playing sound effects.

Changes for modded players
:   * Fixed crash when mods add too many streamed `.ogg` sound effects.

## 1.6.13

Stardew Valley 1.6.13 was [released](https://store.steampowered.com/news/app/413150/view/4443457735847051347) on 08 November 2024.

Balance changes
:   * Fixed legendary fish in fish ponds being more profitable than intended.

Cosmetic changes
:   * Signs placed on legendary fish ponds no longer show a "1" under the fish.

Bug fixes
:   * Added support for more controller types.
    * Fixed NPCs not being able to walk over the beach bridge.
    * Fixed controller rumble being disabled after 1.6.9.
    * Fixed all phone calls being redirected to Robin after 1.6.12.

Technical changes
:   * Updated SDL from 2.30.4 to 2.30.9 (used for input and windowing).

Changes for mod authors
:   * Added `tool.PlayUseSounds` field, which allows disabling sound effects for a particular tool.

## 1.6.12

Stardew Valley 1.6.12 was [released](https://store.steampowered.com/news/app/413150/view/4443457735847051310) on 07 November 2024.

Balance changes
:   * Increased foraging experience from digging up special dirt spots, panning, harvesting ginger, and chopping twigs & stumps & trees.
    * Sandy now sells basic pants in her shop.

Bug fixes
:   * Fixed bug where you could harvest unusual quantities of items from crab pots.
    * Fixed secret gift recipient hint no longer showing up on the skills tab.
    * Fixed rare crash when making a call using the telephone.
    * Fixed sound effects sounding different when using headphones after 1.6.11.
    * Fixed crash when trying to connect to an improperly formatted IP address.
    * Fixed rare crash in LAN multiplayer when not connected to a server.
    * Fixed some minor visual issues with Cyrillic characters.

Changes for modded players
:   * Fixed rare crash when streaming `.ogg` sounds.

## 1.6.11

Stardew Valley 1.6.11 was [released](https://store.steampowered.com/news/app/413150/view/4443457735847051273) on 06 November 2024.

Bug fixes
:   * Potentially fixed farm animals disappearing in rare cases.
    * Fixed NPCs not responding the first time you talk to them.
    * Fixed being unable to grab furniture from walls with a controller.
    * Updated OpenAL to the latest version to fix a rare crash.

Changes for modded players
:   * When you enter the `/unlinkPlayer` chat command, it'll now write technical info to the log.
    * Disabled '*light source ... already exists*' warnings.

## 1.6.10

Stardew Valley 1.6.10 was [released](https://store.steampowered.com/news/app/413150/view/4445708897933590775) on 04 November 2024.

Bug fixes & changes
:   * Improved some French and Russian translations.
    * Fixed crash when the lost items shop sells Penny's 14-heart event items.
    * Fixed chickens disappearing on newly created Meadowlands farms in 1.6.9.
    * Fixed rare crash when transitioning between mine locations in multiplayer.

Fixes for mod authors
:   * Reverted changes to how map tilesheets are loaded in 1.6.9 to resolve mod issues.
    * Fixed crash in some cases when creating furniture from an invalid item ID.

## 1.6.9

Stardew Valley 1.6.9 was [released](https://www.stardewvalley.net/stardew-valley-1-6-9-changelog/) on 04 November 2024.

New content & features
:   * If you lost an item that can't be found again, a [new friend appears in the secret woods](/Secret_Woods#Lost_Items_Shop "Secret Woods") who can get it back (for a price).
    * You can now put legendary fish in fish ponds. These are limited to one per pond and produce legendary fish roe. Each fish has a unique water color.
    * You can now place beds and sleep inside any constructed buildings that allow furniture.
    * Items dropped in water now float for a short time, so you can collect them if you're quick or have a magnet ring.
    * Sam and Shane now have work portraits while working at JojaMart.
    * Slightly tweaked some dialogues.
    * Added new Easter eggs.
    * Added [hidden cheat commands](/Multiplayer#Cheat_commands "Multiplayer").

Balance changes
:   * Blue grass no longer grows slower than normal grass.
    * Fruit tree growth is no longer blocked by grass and seed spots.
    * Pine trees now drop one extra wood when chopped down.
    * The initiation quest now counts wild slimes killed on the farm.
    * Thorns ring damage now stacks if you equip two of them, and monsters killed by a thorns ring now drop loot like regular kills.
    * With the Gatherer skill, the chance to double harvested forage now applies when using an iridium scythe too.
    * Son of Crimsonfish can now be caught during the night market.
    * Robin no longer constructs buildings during green rain in year 1.
    * Placing a bomb and then switching to a weapon no longer applies its enchantments to the bomb damage.
    * Added some items to shops:
      + Adventurer's Guild: Rusty Sword, Femur, Elf Blade, Steel Smallsword, Crystal Dagger, Obsidian Edge, and Work Boots. These unlock after you reach a certain mine level, regardless of whether you found them in a mine chest.
      + Marnie's shop: Cow Decal.
      + Hat mouse: Sports Cap.
      + Willy's shop: Advanced Iridium Rod.
    * Passing trains are now more likely to happen multiple times in the same session, but can no longer appear on consecutive days.
    * Willy's shop now opens on spring 2 in the first year even if you didn't read his letter.
    * Fixed Queen of Sauce reruns being affected by the recipes needed by unclaimed farmhands in empty cabins.
    * Fixed being able to receive monster damage while jumping down a mine shaft before the screen fades to black.
    * Fixed spa not fully recovering energy when a max-energy buff is active.
    * Fixed sleeping late while exhausted not reducing stamina as intended.
    * Fixed the [catalogue](/Catalogue "Catalogue") and [furniture catalogue](/Furniture_Catalogue "Furniture Catalogue") selling items from themed catalogues like [Retro Catalogue](/Retro_Catalogue "Retro Catalogue").
    * Fixed exploit where a fish pond with a golden cracker could produce unlimited output. Fish pond output bonuses are now applied once when the output is created.
    * Fixed exploit where you could cancel cow milking and still get the friendship boost.
    * Fixed unintended extra chance of spontaneous green rain trees when loading a save in fall.
    * Fixed skill buffs affecting shop item requirements in 1.6.
    * Fixed sturdy ring no longer halving debuff times in 1.6.
    * Fixed lower chance of catching lava eels in caldera after 1.6.
    * Fixed forage crops harvested from garden pots always being low-quality and providing no XP.
    * Fixed iridium scythe with forage crops not giving XP or applying the forage level quality boost.
    * Fixed some weapons never dropping from crates when legacy randomization is enabled.

Quality of life changes
:   * The game now recovers most saves automatically if they're broken, corrupted, or missing the SaveGameInfo file.
    * The game now resends most achievements, recipes, and important mail if you somehow missed them. For PlayStation/Xbox players, [missed trophies are readded when perform a specific action instead](/Achievements#Retroactive_Achievements "Achievements").
    * Fish ponds now show the number of roe or other output items to collect.
    * The wedding event now replays if you exit & reload the day.
    * The tailoring UI is now a bit more intuitive: slots that can't accept the held item are now disabled, and you can no longer pick up some items that can't be tailored.
    * Colored items like flowers now also sort by color. That avoids items being reordered randomly each time you sort your inventory.
    * You can now only sell books to the bookseller via the book purchase menu, not the trade-in menu. This reduces the chance of accidentally selling a book when trying to trade it in.
    * The collections tab now shows artifacts, gems, and minerals once they're donated to the museum (not as soon as you find it).
    * Clint now refills your watering can when upgrading it.
    * Tweaked save process to reduce the chance of corruption.
    * Anvils no longer accept parrot eggs if you can't re-roll their level yet.
    * Improved chatbox commands:
      + Chat commands are now case-insensitive.
      + Changed /help format to make room for more commands.
      + Added /help descriptions for /emote, /mapScreenshot, and /unbanAll.
      + Added consistent messages when you can't use a multiplayer-only or host-only command.
    * Performance optimizations.

Technical changes
:   * Migrated from FAudio to OpenAL, which should improve performance when playing audio.
    * Updated SDL from 2.0.x to 2.30.4 (used for input and windowing).
    * Fixed compatibility with newer Windows systems when using some older GPUs.

Gameplay fixes
:   * You can no longer swap a chest's type if the new type is too small to store its current items.
    * Fixed NPC issues:
      + NPCs no longer avoid passable terrain features like flooring and grass when pathfinding.
      + Fixed kicking Krobus out of the house triggering divorce dialogues.
      + Fixed Leo following his island schedule after moving to the mainland.
      + Fixed a Lewis schedule where he would overlap Marnie.
      + Fixed a Penny resort dialogue when married that was never shown.
      + Fixed Pierre sometimes showing a closed-on-Wednesday dialogue after his shop hours are extended.
      + Fixed mom or dad sending duplicate mail if you change gender later.
      + Fixed some dialogue based on location + heart level only being shown if you have 10 or more hearts with the NPC.
      + Fixed special NPC gift reaction dialogue sometimes not matching their gift taste (e.g. Willy giving a positive dialogue for triple shot espresso).
      + Fixed unable to talk to Robin after accepting a house upgrade.
      + Fixed incorrectly split dialogue in Linus' first heart event.
      + Fixed NPCs unable to pathfind through tiles that had a tent at the start of the day.
      + Fixed NPCs not loading their green rain dialogue if you started the day on the island.
      + Fixed NPCs saying "..." in 1.6 if they bought an item you sold to a shop but they don't have a relevant dialogue for it.
      + Fixed your spouse sometimes saying "..." instead of the intended neutral dialogue.
      + Fixed your fiancée/spouse reacting to a mermaid's pendant as if you're engaged/married to someone else.
    * Fixed UI issues:
      + Fixed world map not always showing players at the right spot when they're inside a constructed building.
      + Fixed links in credits no longer opening a browser page.
      + Fixed able to interact with HUD elements like the toolbar when they're hidden (e.g. when the game is paused).
      + Fixed issues when resizing the game window:
        - advanced game options layout being messed up;
        - collections page losing its selected tab and page;
        - social page losing its scroll position.
      + Fixed themed catalogues not having category tabs.
      + Fixed forge UI destroying any item held by the cursor after unforging.
      + Fixed museum menu clicks on the OK button sometimes grabbing the artifact behind it instead.
      + Fixed tailoring menu letting you trash some non-trashable items.
      + Fixed organize button in inventory UIs letting you put any item in special chests like enrichers.
      + Fixed issue where phoning Robin to get building prices and then resizing the window would enable the build/demolish/etc options as if you'd visited the shop directly.
    * Fixed specific items and machines:
      + Fixed chest color getting reset when you swap chest type.
      + Fixed crab pots not producing double catches correctly with wild bait.
      + Fixed crab pots duplicating bait when loaded by a hopper.
      + Fixed crab pots not applying deluxe bait and wild bait bonuses in some cases.
      + Fixed fences destroyed on click when surrounded by impassable objects on three sides (above + left + right) instead of four as intended.
      + Fixed geode crushers incrementing the 'geodes crushed' stat when hovering, which allowed unintended RNG manipulation.
      + Fixed magic quiver trinket sometimes doing nothing if both a valid and invalid target are in range.
      + Fixed mannequins losing their clothes if they're moved into storage to make space (e.g. for an event). They now re-equip their previous clothes when they're put back down.
      + Fixed tents not blocking item placement.
      + Fixed watering cans with bottomless enchantment sometimes shown with a half-empty meter. Bottomless watering cans are now always full.
    * Fixed building upgrades not placing interior items (like the coop incubator) if...
      + furniture is in the way. The furniture is now moved just like other objects.
      + an item blocking placement can't be moved. It's now moved into the lost & found in that case.
    * Fixed cases where the Pirate's Wife quest chain could lock you out:
      + If you have the quest but lost the required item, you now get a new War Memento overnight.
      + If the quest was cancelled, you can now talk to Birdie to restart it.
      + NPCs can no longer mistakenly accept the quest items as gifts or refuse to accept their quest item.
    * Fixed location/map issues:
      + Fixed screen viewport at wrong position right after warping on horseback in some cases.
      + Fixed wilderness farm not pre-building the first cabin in separate-cabins mode.
      + Fixed grass in Marnie's cow field never regrowing.
      + Fixed Willy's bait barrel missing during night market.
      + Fixed some missing map tiles which let you walk off-screen.
      + Fixed able to leave Stardew Valley Fair's festival area in odd years.
      + Fixed weed/stone debris spawning on top of placed paths in some cases.
      + Fixed able to dig up buried treasure from non-diggable tiles in some cases.
      + Fixed forest fish no longer catchable on the four corners farm.
      + Fixed bug where using the standard farm's wallpaper/flooring in farmhouses of another farm type would reset them to that farm's themed defaults.
    * Fixed pre-1.6 saves sometimes losing the Dwarvish Translation Guide. The fix is retroactive for affected players.
    * Fixed pre-1.6 farmhand stats not migrated correctly. The fix is retroactive for affected farmhands.
    * Fixed pre-1.6 tubs o' flowers never blooming again if their first day in 1.6 was in fall or winter.
    * Fixed raccoon bundle accepting anything for preserve items.
    * Fixed level requirement for farmer titles lowered by one in 1.6.
    * Fixed fish ponds accepting multiple golden crackers before the first one lands in the water. They now register the first golden cracker immediately (but still delay the visual change until it lands).
    * Fixed two Desert Festival makeover outfits that applied male shirts to female players.
    * Fixed strange behavior of shop items with both a stock limit and stack size (e.g. items in several desert festival shops).
    * Fixed edge cases where viewing a previous year's secret santa letter in the collections tab would show the current year's secret santa in the game menu during the Feast of the Winter Star week.
    * Fixed the throw-item-into-shipping-bin animation drawing the base uncolored sprite for colored items like roe.
    * Fixed error loading mobile saves on other platforms.
    * Fixed crash when loading a save file in some rare cases.
    * Fixed crash when using a tent on Ginger Island during a night event.
    * Fixed some cat gifts applying fishing bonuses from the main player's equipped fishing rod.
    * Fixed movie theater scene failing in some cases when players have previously unequipped trinkets.
    * Fixed Junimo harvesters losing the item color when dropping a crop on the ground due to their hut being full.
    * Fixed rare edge case where a Junimo hut output chest has too many item slots.

Multiplayer fixes
:   * Added an /unlinkPlayer [name] chat command, which lets the host player release a farmhand so it can be reclaimed by the next person who connects.
    * Fixed being able to steal another player's roommate.
    * Fixed farmhands able to claim multiple Desert Festival fishing quests per day.
    * Fixed crash when reconnecting later in the day after leaving a festival.
    * Fixed host crash if a farmhand disconnects while they're between locations.
    * Fixed NPC duplication in multiplayer fish derbies.
    * Fixed crab pots & farm animals owned by an offline farmhand checking the main player's professions instead.
    * Fixed crab pots with no owner checking professions from the main player instead of the player adding bait.
    * Fixed farmhands sometimes not seing the message when they can't enter an NPC's bedroom.
    * Fixed Marlon's desert festival quests not displaying the Calico Egg reward to farmhands.
    * Fixed some multiplayer logic not handling an offline/invalid player correctly.
    * Fixed some potential 'null reference exception' crashes in multiplayer code.
    * Fixed crab pots with no owner checking the Mariner profession instead of Luremaster for the bait requirement in some cases.
    * Fixed Willy not sending fishing rod mail to farmhands who join after spring 2.
    * Fixed 'waiting for players' check including disconnecting players.
    * Fixed trains not playing chugga chugga sounds for farmhands.

Display text and localization fixes
:   * In the credits, replaced the Reddit/Twitter links with a "News & Community" link.
    * Fixed a huge number of translation issues for non-English players, and added automated tests to keep translations more in sync going forward. For example, this fixes...
      + dialogue/event changes in 1.6 which weren't applied in some languages;
      + missing dialogues and event actions;
      + missing, outdated, or incorrect translations;
      + missing event preconditions (e.g. Leah's 10-heart event could play on a rainy day in some languages);
      + events playing the wrong music, not being skippable, or placing players or NPCs at the wrong spot;
      + translations having different dialogue portraits/breaks/etc;
      + conversation topics not started when something happens;
      + text being shown with one word per dialogue box;
      + improved grammar (e.g. gender conjugation);
      + various errors and typos;
      + and many other issues.
    * Many improvements and fixes to translations and sprites, including [some re-translated item names](/Modding:Migrate_to_Stardew_Valley_1.6.9#Name_translation_changes_for_wiki_maintainers "Modding:Migrate to Stardew Valley 1.6.9").
    * Renamed "cranberries jelly/juice/wine" to "cranberry jelly/juice/wine".
    * Fixed some bad words being produced by the random name generator.
    * Fixed NPC text signs and some chat/UI messages in multiplayer not always shown in your language.
    * Fixed flavored items in some chat/UI messages not shown correctly (like "\_Player put 'Smoked' into the potluck soup\_").
    * Fixed various typos in English text.
    * Fixed special order objectives not re-translated when the language changes. (This fix only applies to new special orders going forward.)
    * Fixed Robin showing the wrong number of hardwood required for a house upgrade in some languages.
    * Fixed some languages showing Willy's back room invite mail as "???" in the collections tab.
    * Fixed some languages having inconsistent hat hair behavior.
    * Fixed some languages producing items with a different internal name.
    * Fixed French players not seeing prismatic effect for Magic Cowboy Hat and Magic Turban.
    * Fixed French and Japanese showing a 'needs 5 coal' message for the dehydrator.
    * Fixed Russian club coin and slots offset issues.
    * Fixed Russian Joja movie theater tilesheet not showing up.
    * Fixed Russian tool tooltips having overlapped names.
    * Fixed Spanish jukebox showing blank name for 'Ginger Island' song.
    * Fixed buy-ticket messages showing an unformatted price (like \_1000g\_ instead of \_1,000g\_).

Cosmetic fixes
:   * Added lights to Marcello's book stand.
    * Sam now changes uniform when he enters JojaMart, instead of only when he reaches his work tile.
    * Fixed many bugs related to light sources (e.g. lights stuck on screen, shown in the wrong location, removed before they should be, etc).
    * Fixed issues with the golden walnut & Qi gem drop-down display:
      + Added support for showing both at once (e.g. another player finds a golden walnut while you're in the Qi gem shop).
      + Fixed display sometimes stuck on screen permanently.
      + Fixed display showing the wrong type in some cases.
      + Fixed display sometimes appearing in multiplayer when the value didn't change.
    * Fixed line wrapping for movie concession description tooltips.
    * Fixed visual glitch during the even-year Spirit's Eve if you have the Joja movie theater.
    * Fixed issue with padding on the edge of maximized game windows on Windows.
    * Fixed a shirt that looked weird.
    * Fixed tooltip display issues, like an empty space for edible items that don't recover any stamina/health (like sweet pea and crocus) or an unintended double space in tooltip buff names.
    * Fixed missing shadows behind some colored items (like wine) in menus.
    * Fixed texture wrapping issue with Joja door.
    * Fixed glitched hidden emote animations in NPC profile menu in some cases. NPCs now use always their default sprite in the profile view.
    * Fixed red slime item sprite drawn one pixel lower than other colors.
    * Fixed missing pixels in anvil sprite's outline.
    * Fixed stray pixel in dried mushroom color mask.
    * Fixed Krobus showing a gift icon for the void ghost pendant when he can't accept it.
    * Fixed the item-received message cutting off part of the item name if it contains a # character (like 'Tropical Fish #173').
    * Fixed the item-received message sometimes showing no count or a wrong count.
    * Fixed some farm animals having double shadows.
    * Fixed stardrop tooltips showing incorrect health/energy recovery amounts.
    * Fixed timing of Easter egg in summit event.

Gamepad fixes
:   * Fixed various issues/crashes with gamepad support.
    * When buying animals or buildings with a gamepad, you can now use the D-pad to move the cursor.
    * In the community center bundle UI, using gamepad triggers to move to donation slots and back now returns you to the same spot.
    * Added a small delay before you can cancel a waiting-for-players dialogue using a gamepad, to prevent accidentally closing it immediately after pressing the OK button.
    * Fixed gamepad issues on the new game screen.
    * Fixed dresser tabs not selectable with a gamepad.

Changes for modded players
:   * Added a [Content/ContentHashes.json file](/Modding:Migrate_to_Stardew_Valley_1.6.9#Content_hashes "Modding:Migrate to Stardew Valley 1.6.9") containing the MD5 hash for every vanilla content asset. This can be used by SMAPI and other tools to detect corrupted or modified game files.
    * [Improved debug console commands](/Modding:Migrate_to_Stardew_Valley_1.6.9#Debug_command_changes "Modding:Migrate to Stardew Valley 1.6.9").
    * When you leave a horse/mount in a temporary location, it now returns home when that location is removed.
    * Fixed 'Jewels Of The Sea' book producing roe for custom fishing catches that normally don't have roe.
    * Fixed forage crops outside the farm being removed each week.
    * Fixed meteorite, strange capsule, and stone owl only appearing in the top-left 64x64 tile area on large custom farm maps.
    * Fixed pagination in powers tab when mods add more powers.
    * Fixed edge cases throughout the game code related to items whose stacks can't be reduced to zero (e.g. tools).
    * Fixed various errors when custom items have no name.
    * Fixed error when mods apply audio changes if there's no audio device available.
    * Fixed error if there are no movies available due to a mod bug. The game will now log a warning and choose from the full list of movies instead.
    * Fixed crash if a farm animal is in a broken building or location.
    * Fixed crash if a smoked fish's original fish data no longer exists. You now get a delicious smoked Error Item instead.
    * Fixed crash when custom sounds loaded from a mod's .ogg files are paused/resumed many times.
    * Fixed map tilesheet crash in some cases when playing split-screen mode with mods.
    * Fixed issues when the game's whichFarm and whichModFarm fields are out of sync.
    * Fixed 'light source already exists' and 'changing net field parent' warnings in some cases.
    * Fixed mod data getting reset on chest type swap.
    * Fixed berry bushes showing wrong sprite in locations where seeds can be planted in any season.
    * Fixed stardrop gift reaction dialogue for custom NPCs defaulting to some raw data instead of their loved dialogue.
    * Fixed able to enter the Adventurer's Guild back room without meeting the requirement if the door is open after a custom event.
    * Fixed triggered actions being logged twice.

Changes for mod authors
:   * See the [1.6.9 mod author migration guide](/Modding:Migrate_to_Stardew_Valley_1.6.9 "Modding:Migrate to Stardew Valley 1.6.9") for new APIs, dialogue keys, game state queries, debug commands, map properties, C# constants/fields/methods, data fields, and many other technical changes.

## 1.6.8

Stardew Valley 1.6.8 was [released](https://store.steampowered.com/news/app/413150/view/4175475797747007861) on 28 April 2024.

Bug fixes
:   * Fixes a game-breaking crash introduced in [1.6.7](#1.6.7) where the game would crash if [NPC's](/Villagers "Villagers") reach the [island resort changing room](/Ginger_Island#Beach_Resort "Ginger Island").

## 1.6.7

Stardew Valley 1.6.7 was [released](https://store.steampowered.com/news/app/413150/view/4175475797747007861) on 27 April 2024.

Bug fixes
:   * Fixes a bug preventing players from giving [Pierre](/Pierre "Pierre") the [Missing Stock List](/Pierre%27s_Missing_Stocklist "Pierre's Missing Stocklist")
    * Fixed some machines and [desert festival](/Desert_Festival "Desert Festival") logic not working for Linux/macOS players using the compatibility branch.

## 1.6.6

Stardew Valley 1.6.6 was [released](https://store.steampowered.com/news/app/413150/view/4175475797742551480) on 26 April 2024.

Balance and Gameplay changes
:   * [Bee houses](/Bee_House "Bee House") now work with flowers in [garden pots](/Garden_Pot "Garden Pot").
    * “Minecart depot” alternative layout now only appears in the upper or lava mine areas.
    * You can now turn the [gold clock](/Gold_Clock "Gold Clock") on or off
    * Added [coal](/Coal "Coal") -> [mahogany seed](/Mahogany_Seed "Mahogany Seed") trade at [raccoons](/Giant_Stump#Raccoon_Wife.27s_Shop "Giant Stump")
    * 50% [mastery XP](/Mastery_Cave#Masteries "Mastery Cave") now only applies to [farming](/Farming "Farming"), as originally intended.

Translation changes
:   * Reverted Chinese text to 1.6.3
    * Reverted Chinese default font to the original
    * Added an option to use the smooth font introduced in 1.6.4
    * Added a dialogue font size slider for Chinese
    * Added complete Russian translated movie & desert festival sprites
    * Added option for Russian to use the “old” font

Bug fixes
:   * Fixed a case where [Mr. raccoon](/Giant_Stump "Giant Stump") could disappear during the raccoon cutscene in [multiplayer](/Multiplayer "Multiplayer")
    * Fixed being able to trash [Pierre's Missing Stocklist](/Pierre%27s_Missing_Stocklist "Pierre's Missing Stocklist"), or give it away at the [Feast of the Winter Star](/Feast_of_the_Winter_Star "Feast of the Winter Star").
    * Fixed being able to give a [wilted bouquet](/Wilted_Bouquet "Wilted Bouquet") to your spouse.
    * Fixed issue causing only 1 [omni geode](/Omni_Geode "Omni Geode") to be produced from the [skull cavern chest](/Skull_Cavern#Treasure_Rooms "Skull Cavern").
    * Fixed crash when a save contains some invalid animal home data.
    * Fixed a crash when talking to [Penny](/Penny "Penny") in French.
    * Fixed a malformed [Willy](/Willy "Willy") farm event in German.
    * Fixed an incorrectly blocking map tile in the [Forest Farm map](/Farm_Maps#Forest "Farm Maps").
    * Fixed some machines and some [desert festival](/Desert_Festival "Desert Festival") logic not working for Linux/macOS players using the compatibility branch.
    * Fixed a case where an area was inaccessible in the [volcano dungeon](/Volcano_Dungeon "Volcano Dungeon")
    * Fixed [sewer](/The_Sewers "The Sewers") event in German
    * Fixed cases where you’d see Mayor [Lewis](/Lewis "Lewis")’ giftbox note again when collecting 15 [parsnips](/Parsnip "Parsnip") from a different chest.
    * Fixed [emily](/Emily "Emily") makeover event from being hard to skip
    * Fixed Calico Egg Rating prize edge cases for farmhands
    * Fixed prismatic hat effects not working in French.
    * Fixed being able to “advance” the ready check menu by pressing Y, which lead to many issues.
    * Fixed island outfits not being loaded for farmhands
    * Minor optimizations.

Fixes for modded players
:   * Fixed error showing non-flavored [roe](/Roe "Roe") items.
    * Fixed error if a mod sets an [NPC’s](/Villagers "Villagers") ‘friends and family’ data to null.
    * Fixed error loading a save containing enchanted [weapons](/Weapons "Weapons") whose ID changed or data was removed.
    * Fixed soft lock when watching weather [TV](/Television "Television") channel if tomorrow’s weather is custom.
    * Fixed temporary maps that aren’t part of a location not using seasonal tilesheets.
    * Fixed [summit cutscene](/The_Summit#Cutscene "The Summit") showing custom [fish](/Fish "Fish") with wrong sprites.

Changes for mod authors
:   * In `Data/Objects`, added two new fields: `CanBeGivenAsGift` and `CanBeTrashed`. Setting `CanBeGivenAsGift: false` adds the `not_giftable` context tag automatically.

## 1.6.5

Stardew Valley 1.6.5 was [released](https://store.steampowered.com/news/app/413150/view/4176601063666391194) on 20 April 2024.

Bug fixes
:   * Fixed crash when loading dark mine levels in some cases.
    * Broken villager NPCs (usually due to a removed mod) are now deleted on load. They'll respawn when they're re-added to the data.

## 1.6.4

Stardew Valley 1.6.4 was [released](https://store.steampowered.com/news/app/413150/view/4176601063663111285) on 18 April 2024. A hotfix was applied on 19 April 2024.

New content & features
:   * Added 20 new 'alternate' mine layouts, which can start appearing after reaching the bottom of [the mines](/The_Mines "The Mines").
    * Added 20 new volcano mines layouts, which can appear after you've unlocked the shortcut between the [caldera](/Forge "Forge") and the [volcano entrance](/Volcano_Dungeon "Volcano Dungeon").
    * Added [fish frenzies](/Fishing#Fish_Frenzies "Fishing").
    * Added a special cutscene after you've helped your new neighbors grow their family to the max.
    * Added 4 new [fairy styles](/Fairy_Box "Fairy Box").
    * You can now place 8 additional non-fish items into [fish tanks](/Fish_Tank "Fish Tank").
    * Raccoon shop now includes a trade for [mystery boxes](/Mystery_Box "Mystery Box") and [golden mystery boxes](/Golden_Mystery_Box "Golden Mystery Box").
    * [Vinegar](/Vinegar "Vinegar") can now be poured onto [trees](/Trees "Trees") to stop them from ever growing [moss](/Moss "Moss").
    * Shaving enchantment now causes tree-specific drops ([Type 3](/Green_Rain_Trees "Green Rain Trees") → [fiddlehead fern](/Fiddlehead_Fern "Fiddlehead Fern"), [mushroom](/Mushroom_Tree "Mushroom Tree") → [red mushroom](/Red_Mushroom "Red Mushroom"), [mahogany](/Mahogany_Tree "Mahogany Tree") → [hardwood](/Hardwood "Hardwood")).

Visual improvements
:   * [Qi club coins](/Casino "Casino") now show up in the shop menu.
    * Various map edits and fixes.
    * Removed [Maru](/Maru "Maru")'s glasses from all beach portraits for consistency.

Translation changes
:   * Many edits and improvements to the Chinese version.
    * Edits to the Russian, Portuguese, Hungarian, Turkish, and Korean translations.
    * Changed the Chinese fonts to make them more appealing and readable.
    * Changed Hungarian number spacing character from a comma to a period.
    * Some improvements to Russian font.

Balance changes
:   * When you load a save, you'll now unlock missed Steam achievements if needed (e.g. achievements gained while playing offline).
    * Added [mini-shipping bin](/Mini-Shipping_Bin "Mini-Shipping Bin") as an expensive [Qi gem shop purchase](/Qi%27s_Walnut_Room#Stock "Qi's Walnut Room").
    * Added more variety, and improvements, to [Skull Cave treasure chests](/Skull_Cavern#Treasure_Rooms "Skull Cavern").
    * [Life elixirs](/Life_Elixir "Life Elixir") now only restores [health](/Health "Health"), and [energy tonics](/Energy_Tonic "Energy Tonic") now only restore [energy](/Energy "Energy").
    * [Wild seed spots](/Seed_Spot "Seed Spot") are now rarer, but yield more seeds.
    * Doubled the [Iridium Golem](/Iridium_Golem "Iridium Golem")'s chance to drop [iridium](/Iridium_Ore "Iridium Ore").
    * The [monsters](/Monsters "Monsters") in the volcano entry level are now randomized each day.
    * Using a [treasure totem](/Treasure_Totem "Treasure Totem") indoors no longer works.
    * Going down a level in the mines now makes you invulnerable for 1 second.
    * Increased raccoon [mystery box](/Mystery_Box "Mystery Box") reward from 4 to 5.
    * [Farming](/Farming "Farming") experience now contributes to [mastery experience](/Mastery_Cave#Masteries "Mastery Cave") at a 50% rate.
    * [Ice orb](/Ice_Rod "Ice Rod") will no longer freeze a [spider](/Spider "Spider") while it is in the air jumping.
    * Removed [red snapper](/Red_Snapper "Red Snapper") from winter fishing quest pool, and [sardines](/Sardine "Sardine") from the summer quest pool.
    * You will no longer get calico rating points from going down the [normal mines](/The_Mines "The Mines").
    * [Golden mystery boxes](/Golden_Mystery_Box "Golden Mystery Box") now have a small chance to yield an [auto petter](/Auto-Petter "Auto-Petter").
    * Slightly reduced chance to find [mystery boxes](/Mystery_Box "Mystery Box").
    * Mine barrels and coal carts will now "refresh" at the start of each year.
    * The order of mystery box rewards is now randomized per-player instead of per-save.

Quality of life changes
:   * Added a 1.2-second delay after dropping an item, before it's picked back up by the same player.
    * [Napalm rings](/Napalm_Ring "Napalm Ring") are now non-destructive on the farm and inside the [slime hutch](/Slime_Hutch "Slime Hutch") (i.e. the explosion will only damage [monsters](/Monsters "Monsters")).
    * Added ctrl + right-click as an alternate toolbar drop hotkey.
    * Receiving a "special notification" (e.g. first [geode](/Geode "Geode") message) will no longer cancel out player actions such as eating or warping.
    * Flopping [fish](/Fish "Fish") no longer fall back into [fish ponds](/Fish_Pond "Fish Pond").
    * [Crab pots](/Crab_Pot "Crab Pot") now have a short time period after harvesting from them during which they can't be removed (750ms).
    * The Junimo [bundle](/Bundles "Bundles") menu now only highlights items that can actually be placed in the selected bundle.

Other changes
:   * Minor optimizations.
    * Added two inappropriate names to the list to exclude from the name generator.
    * You can no longer give gifts to NPC's during [green rain](/Weather#Green_Rain "Weather") year 1 (prevents incongruous attitudes). This also prevents a portrait issue with [Demetrius](/Demetrius "Demetrius").

Gameplay fixes
:   * Fishing splash zones and ore pan points are now removed overnight.
    * The prize ticket machine now consumes your ticket when you get the reward, rather than when you first press the button.
    * For the purposes of perfection, the level 100 stardrop now has a more robust way to check if it's been acquired. This solves a problem where the flag for eating the lvl 100 stardrop could be missing.
    * Fixed Monster Compendium not actually doubling all loot.
    * Fixed geodes no longer dropping on the farm in normal circumstances.
    * Fixed rare crash when spawning items overnight.
    * Fixed crash when a certain mine level is chosen (`_dark_dark` crash).
    * Fixed player colliding with stuff during event cutscenes.
    * Fixed pre-1.6 forged weapons having reduced stats.
    * Fixed not being able to put a torch on the sprinkler you get as a CC reward.
    * Fixed disappearing pets bug.
    * Fixed various bugs/crashes related to building a cabin.
    * Fixed wild seeds in garden pots putting their final crop in the top-left corner of the map instead of the pot.
    * Fixed "lost and found" chests (from night market and elsewhere) not working anymore in 1.6.
    * Fixed a duplication bug with the "lost and found" chests.
    * Fixed slime hutch floors reverting to the default after reloading a game.
    * Fixed malformed casino shop red fireworks ID.
    * Fixed pet adoption catch-all case only working with the animal catalogue, and only applying in year 2 specifically, rather than for any year 2 or beyond.
    * Fixed 'use legacy randomization' option applied inconsistently when loading a save, which caused weird issues like broken green rain days.
    * Fixed the case where you could permanently miss the ancient seed recipe if you grabbed the ancient seed packet but not the associated recipe, and then closed the museum rewards menu. Missing recipes will also be restored upon loading a file.
    * Fixed issue with duplicated animals & building interiors from pre ~1.3 saves.
    * Fixed end tables not being rotateable.
    * Fixed an issue where empty barns/coops could not be removed by Robin on old saves.
    * Fixed slime egg incubators letting you reclaim the egg before it hatches.
    * Fixed farmhouse placement bounds to match the object placement restrictions around it.

Multiplayer fixes
:   * Synced some NPC Gift data in other languages.
    * Fixed fireworks (and possibly other sprites) drawing behind stuff in multiplayer.
    * Fixed "Build a Silo" quest not being completed for farmhands.
    * Fixed Raccoon quest not being removed for all players.
    * Fixed double trinket issue when a farmhand disconnects/reconnects.
    * Fixed double and/or missing derby participants sprite issue in multiplayer.

Display text and localization fixes
:   * Many edits and fixes in translation text.
    * Fixed a text parsing error for Asian languages which caused them to incorrectly wrap in some cases.
    * Fixed spacing issues in Asian languages.
    * Fixed several localization issues (day time money box extra space in Chinese, missing Elliott sentence opener, Fizz name untranslated, birthday string de-hardcoded, etc).
    * Fixed Russian line break issue.
    * Fixed an issue with the perfection tracker display in Chinese, Korean, and Japanese.
    * Fixed events not consistently handling gender-dependent text.

Cosmetic fixes
:   * Adjusted basic object layer depth anchor point so it's more centered rather than on the bottom.
    * Placeable grass now offsets vertically a little if it would clip through a front-layer tile.
    * Fixed seasonal world map not working for non-English players.
    * Fixed flying monsters not being draw above things on the farm & volcano.
    * Fixed reward icon in completed quest menu being visually offset.
    * Fixed george's TV clipping with farmer during green rain.
    * Fixed movies not showing layered sprites (e.g. the eyeball in Mysterium).
    * Fixed Qi club coins drawn below the lightmap.
    * Fixed Qi coin overlay drawn during minigames.
    * Fixed crane game audio not stopping when the game is forcefully closed.
    * Fixed some tooltip padding issues.
    * Fixed movie theater display issues on the world map.
    * Fixed repeated dialogue selection sound if a control was plugged in but you are using a mouse.
    * Fixed quest reward icon input offset issue.
    * Fixed Joja Warehouse roof drawing above the weather (and possibly other similar cases).
    * Fixed various map tile issues.
    * Fixed a visual issue with a shadow in the farm house.
    * Fixed able to swap two chests of the same type.
    * Fixed machines sometimes wobbling when they're not processing anything.

Changes for modded players
:   * Improved debug commands:
      + Added debug commands to change pet types/breeds, to allow migrating older saves (`setPreferredPet` and `changePet`). This replaces the former `toggleCatPerson` command.
      + The `filterLoadMenu <search>` command now keeps the original save slot numbers.
      + Combined `removeNpc` and `killNpc` commands. The unified command removes all instances of an NPC, to help fix duplicate NPCs.

Changes for mod authors
:   * C# mods can now hide specific animals from the animal social menu (e.g. animals owned by NPCs) via the `FarmAnimal.hideFromAnimalSocialMenu` field.
    * In `Data/Buildings`, you can now add furniture via `IndoorItems`.
    * In `Data/FarmAnimals`, added fields to set the sleep sprite and whether they eat golden crackers.
    * In `Data/Locations`, added fields to set effect of fish-specific bait and whether fish can be caught using a training rod.
    * In `Data/Machines`, added option to only let the machine complete overnight.
    * In `Data/Powers`, added `CustomFields` field.
    * Added missing `Id` fields in `Data/FarmAnimals` and `Data/Pets`.
    * Added a warning when a farm animal's spritesheet size is invalid, which would previously lead to the animal silently freezing.
    * You can now use tokenizable strings in event scripts and dialogue text.
    * De-hardcoded forest waterfall fish into `Data/Locations`.

Fixes for modded players
:   * Fixed some wallpapers and flooring not appearing in mod item lists.
    * Fixed pre-1.6 farm maps having broken warps to the bus stop.
    * Fixed errors and crashes due to mods adding items without a name.
    * Fixed softlock when a warp leads to an invalid location.
    * Fixed crash when playing events that use the `replaceWithClones` command.
    * Fixed crash if an NPC has invalid temporary dialogue.
    * Fixed world map showing a glitched texture for custom farm types which don't override it.
    * Fixed another case of NPC duplication involving the movie theater.
    * Fixed crash when loading a save if a farm Junimo wasn't properly removed before saving.
    * Fixed crash if the lost & found contains null items.
    * Fixed disconnect for Steam players when using mods that send messages before a farmhand has been approved.
    * Fixed crash on save if shipping bin has empty slots.
    * Fixed riding the bus to the desert instantly warping you back if mods added warps on the desert road.
    * Fix multiplayer crash if some players don't have the same NPC textures.

Fixes for mod authors
:   * Fixed farmhands' cellars not applying cellar data from `Data/Locations`.
    * Fixed crash if a farm animal has no entry in `Data/FarmAnimals`.
    * Fixed festivals ignoring year suffixes for `<setup>_additionalCharacters` and `name` fields.
    * Fixed issues with farm animals which have a custom home building.
    * Fixed hardcoded assumptions about farm animal spritesheets which could cause counter-intuitive behavior with custom animals.

Further changes were later released without changing the version number:

19 April 2024 "hotfix #1" ([Steam announcement](https://store.steampowered.com/news/app/413150/view/4176601063665061439?l=english))

:   * Fixes issue when dropping a big chest into a small chest
    * Quarry mine level can no longer be an alternate layout
    * Prevents the player from running through barriers in certain transit cutscenes
    * Mine levels 45 and 85 are now also refreshed at the beginning of the year

## 1.6.3

Stardew Valley 1.6.3 was [released](https://store.steampowered.com/news/app/413150/view/4206998459074597475) on 27 March 2024.

New content & features
:   * You can now access [Clint's shop and geode service](/Blacksmith "Blacksmith") while your tool is being upgraded.
    * Added [Krobus portrait](/Krobus_Portrait "Krobus Portrait").
    * Added [minecart shortcut](/Minecart "Minecart") to year 1 [Spirit's Eve](/Spirit%27s_Eve "Spirit's Eve") festival.
    * You can now paint the new cabins (at third upgrade level).

Balance changes
:   * Increased [raccoon](/Giant_Stump "Giant Stump") bug meat and bat wing request amount.
    * Harvesting [moss](/Moss "Moss") now grants 1 foraging exp per moss.
    * The Infinite Power achievement is now more generous with how it activates, allowing pre-1.6 saves to trigger the achievement.
    * You now have to collect (not just donate) the four prismatic shards for the ["Four Precious Stones" Qi quest](/Quests#List_of_Mr._Qi.27s_Special_Orders "Quests").
    * The Junimo Kart Qi quest now rewards 20 [Qi gems](/Qi_Gem "Qi Gem") (up from 10).
    * Adult mossy green rain trees boost the moss growth rate of nearby trees.
    * Moss now grows more slowly on sunny summer days, and recovers more slowly after harvest.
    * Reduced meteorite prismatic shard chance (100% -> 25%).
    * [Ancient seed](/Ancient_Seeds "Ancient Seeds") packets can no longer be sold at the [traveling cart](/Traveling_Cart "Traveling Cart").

Quality of life changes
:   * Waterfall and some other ambient positional sounds now fade out more smoothly.
    * If you don't have a pet in year two, you can now start adopting them from Marnie's shop.

Bug fixes
:   * Added the new cabin styles to the multiplayer starter layouts.
    * Starter cabins now appear in the actual order intended.
    * If a journal quest title is too wide, the clock icon and the rest of the text will be shifted down to make room.
    * You can now press the Escape or menu button to "go back" on a shipping menu category page.
    * Made berry bush state consistent overnight and on load (both at 20% plus a small new random bonus chance).
    * Minor graphical fixes.
    * Fixed glitch where farming speed is changed depending on the player's direction.
    * Fixed several translation errors and missing translations.
    * Fixed large character sprites having a visual glitch (e.g. bear, island frog, or Clint when hammering).
    * Fixed a visual error in the shop menu if an item's name was longer than the width of the menu.
    * Fixed a crash related to the new festival.
    * Fixed a bug that caused excess trash to be fished.
    * Fixed bug preventing Emily's 10-heart mail and event from triggering.
    * Fixed graphics issues with the shipping menu.
    * Fixed several more cases of out-of-bounds spawning.

Changes for mod authors
:   * Fixed items able to have a null `Name` or `DisplayName` in 1.6. They now default to the qualified item ID and "*Unnamed Item (<id>)*" respectively.
    * The `${...}$` gender-switch syntax now works in events.
    * The `character.EventActor` flag is now synced in multiplayer.
    * Added paint masks for the new cabins style.
    * The `debug whereis` command now lists event actors too.
    * Fixed pet license name delimiter conflicting with unique string ID format.
    * Fixed NPC duplication bug with movie theater.
    * Fixed fruit trees above growth stage 4 no longer producing fruit.
    * Fixed current location's building interiors not being actively synced.
    * Fixed error processing a machine with no `Data/Machines` entry.
    * Fixed broken fruit tree sprite if it's synced from another player and has a custom texture in `Data/FruitTrees`.

## 1.6.2

Stardew Valley 1.6.2 was [released](https://store.steampowered.com/news/app/413150/view/4143947429353685596) on 21 March 2024.

Balance changes
:   * Added scaling edibility to [juice](/Juice "Juice"), jellies, [wine](/Wine "Wine"), and pickles.
    * [Void egg](/Void_Egg "Void Egg") is now poisonous.

Bug fixes
:   * Fixed an issue with Willy's rod.
    * Fixed for invisible tea sprites.
    * Fixed an error in the [Luau](/Luau "Luau") event in Portuguese.
    * Fixed visual error with pre-1.6 basic wines.
    * Fixed a soft-lock if you charged a tool and then strafed to a warp spot, and released the tool while warping.
    * Fixed inedible ingredients being poisonous after turning into [jelly or pickles](/Jellies_and_Pickles "Jellies and Pickles").
    * Fixed [Volcano dwarf](/Volcano_Dungeon#Shop "Volcano Dungeon") [bombs](/Crafting#Bombs "Crafting") not matching regular dwarf bombs.
    * Fixed [adventure guild](/Adventurer%27s_Guild "Adventurer's Guild") open hours on map.
    * Fixed various translation issues.

## 1.6.1

Stardew Valley 1.6.1 was [released](https://steamcommunity.com/games/413150/announcements/detail/4143947429349868720) on 19 March 2024.

Bug fixes

:   * Improved cases where the quest title could go off the edge of the quest log.
    * Fixed botched German egg quest text (for new players going forward).
    * Fixed animal page crash when clicking on the scroll bar when there are a low number of animals.
    * Fixed Junimo harvester in save crash.
    * Fixed Meadowlands farm quest persisting if the farm icon was selected, but then another farm was started.
    * Fixed the telephone Robin house upgrade question being malformed.
    * Fixed eyebrow accessory looking weird when fishing.
    * Fixed errors due to clipboard being set to a null string.
    * Fixed crash when farmhand reconnects to town during green rain (and potentially other related crashes).
    * Fixed several map tile issues and places where forage could spawn out of bounds.

## 1.6

Stardew Valley 1.6.0 was [released on 19 March 2024](https://www.stardewvalley.net/stardew-valley-1-6-update-is-out-now-on-pc/).

New content & features
:   * Added new festivals and events:
      + The [Desert Festival](/Desert_Festival "Desert Festival") is a three-day event in spring which can be accessed after the bus is repaired.
      + Two mini fishing festivals: [Trout Derby](/Trout_Derby "Trout Derby") and [SquidFest](/SquidFest "SquidFest").
      + A new environmental "event" in summer.
    * Added a [mastery](/Skills#Mastery "Skills") system, accessed via a new area, which grants powerful perks and items…
    * Added a new [farm type](/Farm_Maps "Farm Maps"): Meadowlands Farm. It has a chewy blue grass that animals love. You also start with a [coop](/Coop "Coop") and 2 [chickens](/Chicken "Chicken").
    * Added many new NPC dialogues. That includes...
      + custom gift reactions;
      + dynamic dialogues which react to things that happened;
      + custom flower dance acceptance dialogue;
      + restored missing dialogue (like [Emily](/Emily "Emily") and [Shane](/Shane "Shane")'s [flower dance](/Flower_Dance "Flower Dance") custom accept-dance dialogues when married to the player, Shane's dialogue when browsing [the Saloon](/The_Stardrop_Saloon "The Stardrop Saloon") vending machine, [Lewis](/Lewis "Lewis") congratulating female farmers after their wedding, a line in [Maru](/Maru "Maru")'s 14-heart event, three dialogues from [Sam](/Sam "Sam") related to [Kent](/Kent "Kent"), two randomized dialogues when an NPC buys an item you sold to a shop, two speech bubbles from [Marnie](/Marnie "Marnie") and [Robin](/Robin "Robin") when you enter their shop building, and a fortune teller dialogue for your potential spouse);
      + and more.
    * You can now get multiple pets (after getting max hearts with your starter pet).
    * Added a world map for [Ginger Island](/Ginger_Island "Ginger Island"), visible when visiting the island.
    * The world map now shows your actual position within the world in real-time (instead of showing you at a fixed point for each location). In multiplayer, you'll see other players' positions in real-time too.
    * Pets that love you will sometimes give you gifts.
    * NPCs now have winter outfits.
    * Festivals now have map and dialogue changes every second year (except the night market and desert festival).
    * Added a golden Joja parrot, which you can pay to find all remaining [golden walnuts](/Golden_Walnut "Golden Walnut") on Ginger Island.
    * Added perfection waivers, a new Joja way to bypass [perfection](/Perfection "Perfection") challenges.
    * Added a prize machine in [Lewis](/Lewis "Lewis")' house. You can collect prize tickets as a reward for completing quests and special orders, and from repeated egg/ice festival wins.
    * A [bookseller](/Bookseller "Bookseller") now comes to town twice a season.
    * Added [mystery boxes](/Mystery_Box "Mystery Box").
    * Added a [Big Tree](/Big_Tree "Big Tree"), with a quest line which ultimately gives you some new neighbors.
    * Added four new crops ([carrots](/Carrot "Carrot"), [summer squash](/Summer_squash "Summer squash"), [broccoli](/Broccoli "Broccoli"), and [powdermelon](/Powdermelon "Powdermelon")) which can't be purchased at the store, and two new giant crops.
    * Added four new home renovations: dining room, attic, expanded corner room, and cubby.
    * Added new items:
      + [Big Chest](/Big_Chest "Big Chest"), which has almost double the size of a regular chest. It can also be placed "onto" a regular chest to upgrade it.
      + [Dehydrator](/Dehydrator "Dehydrator"), which turns fruit into dried fruit and mushroom into dried mushrooms.
      + [Mushroom Log](/Mushroom_Log "Mushroom Log"), which produces mushrooms and interacts with nearby trees.
      + [Bait Maker](/Bait_Maker "Bait Maker"), which can produce fish-specific baits.
      + [Heavy Furnace](/Heavy_Furnace "Heavy Furnace"), which can process more bars at a time, and yield bonus bars.
      + [Fish Smoker](/Fish_Smoker "Fish Smoker"), which produces [smoked fish](/Smoked_Fish "Smoked Fish"), doubling the value of the fish. You get one by default when starting a new [riverlands farm](/Farm_Maps#Riverland "Farm Maps").
      + [Text Signs](/Text_Sign "Text Sign"), which can be written on.
      + [Anvil](/Anvil "Anvil"), which allows you to re-roll trinkets.
      + [Mini-Forge](/Forge#Mini-Forge "Forge"), which acts as a Dwarvish [Forge](/Forge "Forge").
      + [Statue Of Blessings](/Statue_Of_Blessings "Statue Of Blessings"), which grants a random blessing each day.
      + [Statue Of The Dwarf King](/Statue_Of_The_Dwarf_King "Statue Of The Dwarf King"), which allows you to select one of two mining buffs for the day.
      + [Tent Kits](/Tent_Kit "Tent Kit"), which allow you to build a tent which can be slept in for one night.
      + [Treasure Totems](/Treasure_Totem "Treasure Totem"), which spawn a ring of diggable spots.
      + [Mystic Tree Seeds](/Mystic_Tree_Seed "Mystic Tree Seed"), which grow a unique tree which can be tapped.
      + [Mystic Syrup](/Mystic_Syrup "Mystic Syrup"), a valuable tapper product.
      + [Deluxe Bait](/Deluxe_Bait "Deluxe Bait"), gets fish biting faster than regular [bait](/Bait_(item) "Bait (item)").
      + [Challenge Bait](/Challenge_Bait "Challenge Bait"), which allows for up to 3 fish to be caught at once, but loses 1 each time a fish leaves the bobber bar.
      + [Deluxe Worm Bin](/Deluxe_Worm_Bin "Deluxe Worm Bin"), which upgrades the regular [worm bin](/Worm_Bin "Worm Bin") to produce [deluxe bait](/Deluxe_Bait "Deluxe Bait").
      + 19 unique [Books](/Books "Books") Of Power, which grant special perks.
      + Skill Books, which grant experience in a skill.
      + Book Of Stars, which grants experience in all skills.
      + [Moss](/Moss "Moss"), a new resource type which grows on old trees.
      + [Mixed Flower Seeds](/Mixed_Flower_Seeds "Mixed Flower Seeds").
      + [Sonar Bobber](/Sonar_Bobber "Sonar Bobber"), which shows the fish on your line before you catch it.
      + [Raisins](/Raisins "Raisins"), which have a special use.
      + [Sea Jelly](/Sea_Jelly "Sea Jelly"), [River Jelly](/River_Jelly "River Jelly"), and [Cave Jelly](/Cave_Jelly "Cave Jelly"), a new item that you can fish.
      + 7 [Trinkets](/Trinkets "Trinkets"), which grant powers related to combat.
      + Red, Purple, and Green Fireworks.
      + [Stardrop Tea](/Stardrop_Tea "Stardrop Tea"), which makes an excellent gift for anyone.
      + 25 new hats.
      + 280 new furnitures.
      + New unique furniture catalogues, which contain themed furniture sets.
      + 41 new floor styles.
      + 24 new wallpaper styles.
      + [Golden Animal Crackers](/Golden_Animal_Cracker "Golden Animal Cracker").
      + [Mannequins](/Mannequins "Mannequins"), which can be dressed.
      + Spouse [Portraits](/Traveling_Cart#Spouse_Portraits "Traveling Cart") which can be purchased after reaching 14 hearts.
      + [Butterfly Powder](/Butterfly_Powder "Butterfly Powder"), which allows you to remove pets...
      + [Blue Grass Starter](/Blue_Grass_Starter "Blue Grass Starter").
      + [Moss Soup](/Moss_Soup "Moss Soup").
      + Secret items.
    * Added [Goby](/Goby "Goby") fish.
    * Added some new remix bundles.
    * You can now place hats on cats and dogs.
    * You can now upgrade the [copper pan](/Pans "Pans") into steel, gold, and iridium pans.
    * You can now enchant pans with Archaeologist, Generous, Fisher, and Reaching.
    * Added a "Special Items & Powers" tab to replace the wallet. The wallet area now tracks a selection of progress markers.
    * Added an animals tab that shows all your pets & animals.
    * You can now build pet bowls in [Robin's Shop](/Carpenter%27s_Shop "Carpenter's Shop"), with three variants.
    * The farmhouse and pet bowl can now be moved through Robin's menu.
    * The [farm computer](/Farm_Computer "Farm Computer") can now be used anywhere to see a summary of that location, instead of only the farm.
    * The [mini-jukebox](/Mini-Jukebox "Mini-Jukebox") can now be used on the [Ginger Island](/Ginger_Island "Ginger Island") farm.
    * Added a new interaction with your horse.
    * Added a new side-tunnel to the [Quarry Mine](/Quarry_Mine "Quarry Mine").
    * The [Community Center](/Community_Center "Community Center") fish tank now becomes an actual fish tank when you complete it.
    * Added more secrets & easter eggs.
    * Added two new cat and dog breeds.
    * Added turtle pets.
    * Added 8 new achievements.
    * Added 4 new [cabin](/Cabin "Cabin") variants.
    * Added a few more accessory options in character creation.
    * Added a new bobber machine in Willy's shop, with 39 bobber styles to choose from. New styles unlock by catching new kinds of fish.
    * Added a cameo appearance to Maru's 14-heart event.
    * Emily has a new rare "socialize" daily quest if you've completed the introduction quest.
    * You can now add [anchors](/Anchor "Anchor"), [treasure chests](/Treasure_Chest "Treasure Chest"), and [pearls](/Pearl "Pearl") to [fish tanks](/Fish_Tank "Fish Tank").
    * Pierre now sells a few random items at the winter star booth (at a markup!).
    * Added a jingling sound when running with the [cinderclown](/Cinderclown_Shoes "Cinderclown Shoes") shoes on.
    * Baby toss now has a chance to crit.
    * Added a skull cavern statue that can be used to toggle hard mode in the skull cave (after completing Qi's challenge).
    * Added additional chests to Skull Cavern levels 200 and 300.
    * Added unique skull cavern chest appearance for level 100, 200, and 300 chests.
    * Added a high note (C5) to flute block.
    * Added [Meowmere](/Meowmere "Meowmere") from Terraria crossover
    * Added iridium golem to wilderness farm.
    * See [changes for mod authors](/Modding:Migrate_to_Stardew_Valley_1.6 "Modding:Migrate to Stardew Valley 1.6").

Visual improvements around the valley
:   * Added waterfalls.
    * Added more holiday decorations in winter.
    * Added more pathstones to various maps.
    * Added jack-o-lanterns after the Stardew Valley Fair in fall.
    * Added seasonal world map variants.
    * Added a new rare ambient critter.
    * Added some rare summer butterfly variants.
    * Added an uncommon little brown bird variant.
    * Redrew the world map to better match the in-game locations and be more detailed.
    * Boat journey textures are now seasonal and reflect the latest valley map.
    * The bus stop now has a wider map, though the distance to traverse it is the same. (This is to prevent black bars from appearing at the sides of the screen.)
    * Jelly, pickles, wines, and juices are now colored based on the ingredient item.
    * Many town trees are now actual tree objects, though you can't cut them down.
    * Slight adjustment to the way items pop out when dug from the ground.
    * Updated volcano gold ore node sprite.
    * Maple and Oak trees have a chance to turn into [Green Rain Trees](/Green_Rain_Trees "Green Rain Trees") and lose their leaves in the fall.
    * Riverbanks and lakeshores in the mountain, town, and forest areas are now less jagged in some places.
    * Graphical improvements to building interiors.
    * Improved the art of George & Evelyn's roof.
    * If you destroy a mines chest, it now shows some graphics debris.
    * Added special backplates to fortune teller TV show if you get a perfectly good or perfectly bad luck day.
    * Lighting changes:
      + It now gets dark an hour earlier in winter.
      + Night tiles (e.g. town lamps) now activate an hour earlier in all seasons.
      + Indoor daytime lighting now smoothly transitions to night lighting over the course of two hours.
      + Night lighting in non-farmhouse indoor locations is now slightly darker.
      + Farmhouse lighting on rainy days is now slightly moody, and lights stay on all day.
      + TVs and trees of the Winter Star now give off light at night.
      + Added light sources to window light glows so there are no more "dark but lit" windows.
      + Made some improvements to the intro bus drive cutscene.
      + At night, hats are now drawn at the night-time color in the game menu portraits.
      + Removed lighting quality option. It's now permanently set to ultra quality.
    * The submerged [fishing](/Fishing "Fishing") bobber is now recolored automatically to match the water.

Multiplayer changes
:   * You can now have up to 8 players on PC.
    * Many improvements for multiplayer performance and stability. That includes:
      + Steam players will now use Steam multiplayer authentication, potentially improving connection issues significantly.
      + Large multiplayer packets are now compressed, reducing bandwidth usage and latency.
      + Internal optimizations to data syncing.
    * You now need the same build number (in addition to version) to join a multiplayer server. This prevents crashes due to game changes between builds.
    * Accepting a Qi challenge that increases mine difficulty now only kicks other players out of the affected mine type, not all mines.
    * Purple shorts no longer show a chat message when placed into the Luau soup.
    * Jump down mineshaft sound now plays for all players in the level rather than just the jumper.

Balance changes
:   * Added a box with three tent kits to the Ginger Island jungle.
    * Weapons found in the wild now have a chance to come with a basic "innate enchantment". You can re-roll "innate enchantments" (if the weapon could have one) at the forge using a dragon tooth.
    * [Slime hutches](/Slime_Hutch "Slime Hutch") are now significantly smaller (11x6 → 7x4).
    * Farm animals now gain a little happiness if you close the animal door behind them at night.
    * Grass now survives in the winter, though it won't spread. However, cutting grass during winter is much less effective.
    * The mushroom cave now comes with a free Dehydrator.
    * Changed recipe skill requirements for:
      + charcoal kiln (foraging 4→2);
      + cookout kit (foraging 9→3);
      + survival burger (foraging level 2→8);
      + tapper (foraging 3→4);
      + and worm bin (fishing level 8→4).
    * Price changes:
      + Most [home renovations](/Carpenter%27s_Shop#House_Renovations "Carpenter's Shop") now cost money, which is refunded if you undo the renovation. (The game knows whether you bought it though, so refunding a pre-1.6 renovation won't give you free money.)
      + Reduced fairy dust sell price (500g → 300g).
      + Reduced tea sapling sell price (500g → 250g).
      + Reduced life elixir sell price (500g → 250g).
      + Building cabins no longer requires materials, only the 100g price.
      + Raised price of second house upgrade (50,000g → 65,000g), but reduced number of hardwood needed (150 → 100).
      + Reduced worm bin's hardwood needed (25 → 15).
      + Increased cost of [warp totem: farm](/Warp_Totem:_Farm "Warp Totem: Farm") in casino (500 → 1000)
      + Raised price of bombs in dwarf shop.
      + Raised some hat prices from Hat Mouse.
    * Shop changes:
      + Put limits on some casino stock.
      + You can now buy all brazier recipes in Robin's shop at once instead of in sequence.
    * Item drop changes:
      + Chopping down a fruit tree now yields the appropriate fruit sapling. If the tree is mature (i.e. the fruit quality is > basic), it will yield a sapling with the same quality as its fruit. The higher the quality, the faster the sapling will mature.
      + Chopping down a tea bush now gives back a tea sapling.
      + There's now a small chance to find cosmetic items and other goodies while doing random tasks.
      + Snake vertebrae are now easier to get.
      + Train cars which carry wood can now drop hardwood.
      + Santa's train car can now drop gifts.
      + Reduced prismatic shard drop rate from iridium nodes (4% → 3.5%).
      + Rare yellow slimes now drop money.
      + Brown slimes now drop wood (doesn't affect the copper slimes in the quarry mine).
      + Botanist perk now applies to items dropped from trees (e.g. coconuts).
      + Reduced chance of fishing void mayonnaise at the witch swamp.
    * Gift taste changes:
      + Adjusted gift tastes for several NPCs.
      + Treasure chests are now a universally liked gift... except by Linus.
    * Skill XP changes:
      + Mushroom Logs and Mushroom Boxes now grant 5 foraging XP on harvest.
      + Harvesting berry bushes now grants 1 foraging XP per berry.
      + Harvesting forage crops from wild seeds now give much less foraging experience, but grant some farming experience.
      + Monsters on the farm now give combat experience, but it's 1/3 of normal value. This excludes slime hutch slimes.
    * Adjusted combat:
      + Extended the area of effect of downward facing melee attacks (and slightly extended the side attack of daggers).
      + Topaz ring now gives +1 defense, rather than the unused precision stat.
      + Raised insect head's damage (10-20 → 20-30).
      + Raised kudgel's critical attack power (+4 → +50).
      + Bombs now affect terrain features (like trees and crops) within the round explosion radius rather than a square area.
      + Slightly increased rate at which skeletons throw bones or shoot spells.
    * Adjusted [Junimo Kart](/Junimo_Kart "Junimo Kart"):
      + Added [grace jumps](https://en.wikipedia.org/wiki/Coyote_time "wikipedia:Coyote time") in Junimo Kart: when you run off the track, you can still jump for a short time to recover.
      + Your score is now saved if the minigame forcibly exits while playing endless mode.
      + Noxious gas emitting mushrooms no longer appear in pairs.
      + Reduced bubble spawn rate on whale level.
    * Adjusted machines:
      + Worm bins now need a lower fishing level (level 8→4) and produce more bait (2–5 → 4–5).
      + Loom now has a higher chance of double cloth when processing quality wool.
      + Fish ponds now have a chance to produce extra roe whenever they produce roe.
      + Geode Crushers no longer require coal to operate.
    * Adjusted penalties when knocked unconscious:
      + You can no longer lose the [Golden Scythe](/Golden_Scythe "Golden Scythe"), [Infinity weapons](/Galaxy_Soul#Forge_recipes "Galaxy Soul"), or [tools](/Tools "Tools").
      + You can no longer lose more than three items.
      + The amount of money lost now scales to how much you have. It's now less punishing if you don't have much money, but more punishing if you have a lot. This also raises the maximum lost from 5000g to 15000g.
    * Adjusted food buffs:
      + Joja cola now gives a very short speed buff.
      + Green tea now gives +0.5 speed.
    * Mine and dungeon changes:
      + Added coal nodes to the volcano dungeon.
      + Barrels now spawn on skull cavern levels divisible by 5.
      + Reduced the maximum possible effect a bad luck day can have on finding a prismatic slime.
      + Reduced number of bugs to kill for monster slayer goal from 125 to 80.
    * Bundle changes:
      + Made remixed specialty fish bundle (and analogues) reward 5 Dish O' The Sea, to make it consistent with the classic bundle.
      + River fish bundle now gives deluxe bait.
      + Improved some community center rewards.
    * Adjusted crafting recipes:
      + [speed gro](/Speed-Gro "Speed-Gro") now requires 5 Moss instead of 1 Clam .
      + [deluxe speed-gro](/Deluxe_Speed-Gro "Deluxe Speed-Gro") now requires 5 bone fragments instead of 1 coral.
      + [quality fertilizer](/Quality_Fertilizer "Quality Fertilizer") now requires 4 sap instead of 2, but produces 2 per craft (still only requires 1 fish).
    * Spouse changes:
      + Spouses now have a seven-day "honeymoon" period after marriage which prevents them from laying in bed all day due to being upset.
      + Kissing your spouse, and giving them a gift on the previous day, each reduce the "minimum heart level threshold" for a bed-ridden day by one heart (12→10 if you do both).
      + Friendship gain and loss is reduced by 34% for spouses.
    * Rebalanced the [crop fairy](/Random_Events#The_Crop_Fairy "Random Events") event: the chance no longer depends on the number of planted crops, it can no longer happen on the last day of the season (to avoid growing crops that might die overnight), and it can no longer choose dead crops to grow.
    * Increased the [shaving enchantment](/Forge#Enchantments "Forge")'s effect on [giant crops](/Crops#Giant_Crops "Crops").  
      Each giant crop now has a 60% chance of dropping an extra six crops while the shaving enchantment is equipped, spread across the number of hits needed to break it. For example, a base axe which breaks the giant crop in three hits gets three 20% chances of dropping 2 crops.
    * The [mushroom cave](/The_Cave "The Cave") now provides mushrooms every second day. It was unintentionally changed to daily in Stardew Valley 1.5.
    * You can no longer plant trees in the beach farm tunnel.
    * Randomization no longer produces simple repeating patterns in many cases (e.g. clay farming, mushroom level prediction, crab pot fish offset, etc).  
      (You can enable "Use Legacy Randomization" in the advanced save options to use the old randomization, though some specific patterns may still change due to the underlying changes. That option is mainly intended for speedrunners; most players should keep it disabled for the intended experience.)
    * Spreading [weeds](/Weeds "Weeds") can no longer destroy [artifact spots](/Artifact_Spot "Artifact Spot").
    * Increased the number of monsters that daily monster quests will ask you to slay (in some cases). Added more custom quantities, for example Dust Spirits will ask for 10-20 kills.
    * Tilled dirt on the island farm now decays in the same way as the regular farm.
    * Slightly increased time you have to push against farm animals before passing through them.
    * Slightly boosted quarry output. Daily quarry output now increases each year, up to a limit.
    * You can no longer plant trees in town.
    * Secret notes are no longer created during festivals (except passive festivals like the night market and desert festival).
    * Adjusted fish variety in ice fishing festival.

Quality of life changes
:   * Performance improvements.
    * NPCs now shove [chests](/Chest "Chest") out of their way instead of destroying them.
    * If Pam won't be coming to the bus for any reason, she now leaves a sign informing you and you can drive yourself to the desert.

:   * Audio changes:
      + Made more sounds positional (mainly players, tools, and machines).
      + Positional sounds now fade with distance when off-screen, instead of cutting off abruptly.
      + Softened the bomb fuse sound.
      + The music now "ducks out" and then resumes when certain sounds are played, instead of stopping.
    * You can now "strafe" while charging a watering can or hoe, allowing you to reposition your tool hit area without changing your facing direction.
    * You can now refill slingshot ammo by right-clicking it with the same ammo. Previously that would just swap the item stacks.
    * Planting [cactus seeds](/Cactus_Seeds "Cactus Seeds") on the farm now fails with a message, instead of the seeds dying overnight.
    * Holding a [tea sapling](/Tea_Sapling "Tea Sapling") or [seed](/Crops "Crops") over a [garden pot](/Garden_Pot "Garden Pot") now shows the green/red placement tile.
    * You can no longer pick up rugs if there's something on it.
    * Checking a pet bowl will now show a text bubble with the pet's name.
    * Added a new post-fishing sparkling text to indicate when you've caught something for the first time.
    * Torches can now be placed on sprinklers.
    * You can now sit in chairs during festivals.
    * You can now move filled chests by hitting them twice with a heavy tool (previously only with bare hands). The chests will shift one space at a time.
    * You can now place flooring underneath most buildings.
    * Crystalariums now have to be removed and replaced before a different gem can be put inside, to help avoid wasting gems accidentally.
    * Daily billboard quests now have a more informative tracker notification when you make progress on them.
    * Added a small checkmark icon on special orders you've completed before (only on town special orders board).
    * You can now skip the pet adoption scene, which causes you to adopt the pet.
    * Reduced the amount of time you need to push against a pet before they start shaking and then let you pass through them (1.5 → .75 seconds).
    * Reduced time for mini-obelisk warp (750ms faster).
    * Male farmers are no longer forced into wedding clothes on their wedding day, so you can choose your own outfit for the wedding.
    * Emptying a fish pond with fish still in it will cause the remaining fish to flop out of the pond.
    * Slime hutch changes:
      + You can now change the flooring of the slime hutch.
      + You can now remove the starter incubator in the slime hutch.
      + Slime balls no longer appear on crafted flooring.
    * UI improvements:
      + Added an hourglass cursor shown when you're waiting for something to load on the title screen.
      + Notification messages in the bottom-left corner now last 50% longer before going away.
      + "Sound in the night" events now show an icon on the screen to indicate that a sound is playing.
      + Dialogue question selectors no longer remain selected when you hover away from them, to reduce accidental selections.
      + Robin's building menu now shows how many days a building will take.
      + If an item menu exits while you're holding an item, the item is now always retrieved. (Previously only some item menus like chests would do it.)
      + [Marnie's animal shop](/Marnie%27s_Ranch "Marnie's Ranch") now centers the camera on an appropriate building when purchasing an animal.
      + Marnie's animal shop now shows prices in the tooltip, in case the tooltip covers the price display.
      + The achievement menu now lists all potential achievements. Hidden achievements you haven't unlocked yet are shown as "???".
      + The museum reward menu now prevents picking up a reward that won't fit in your inventory.
      + The museum reward menu now lets you exit while holding a reward. It'll be added to your inventory if possible, otherwise it'll drop at your feet.
      + The save creation farm selector now has two columns instead of one, and no longer overlaps the back button on small screens.
      + The shipping menu category pages no longer take up the whole screen, as long as the screen is beyond a minimum size.
      + Inventory tooltips for food that gives a buff now shows the buff duration in the tooltip.
      + The map now closes when you press the map button again.
      + Exiting the Junimo Note menu from within the game menu now returns to where you were in the game menu rather than exit the menu.
      + Shops now truncate item names which would overflow the menu width.
      + Shops now have a slight delay before you can buy/sell items, to help avoid double-clicks doing it accidentally.
      + Deleting a save on PC is now much faster.
    * Significantly reduced save loading time when there are many custom locations.
    * If a default farm building (like the [greenhouse](/Greenhouse "Greenhouse")) is somehow removed, it'll now be rebuilt next time you load the save.
    * "Menu background" is now a drop down option, which includes "Standard", "Graphical", or "None".
    * Attempting to put something in a machine but failing will no longer cause you to try and consume or activate the object you're holding.
    * Kent intro event and Robin flute block event are now skippable.
    * (PC) You can now shift + right-click an item on the toolbar to throw it out of your inventory (if possible).
    * (PC) You can now press the Y or N key to confirm or cancel the "leave festival" confirmation box.
    * (PC) Holding left-shift + left-ctrl + 1 when buying from a shop will attempt to buy a stack of 999.

Other changes
:   * Adventure guild now stays open until 2am, though the music will not play after midnight.
    * Gender-specific clothing variants can now be worn by any gender.
    * If you have 12 hearts or more with your spouse, the chance they'll say a neutral dialogue in the afternoon (which sometimes comes across as negative) is significantly lower (25% → 5% chance).
    * Penny's forest picnic event and Leah's forest picnic event now only happen if it's sunny.
    * NPCs now try to avoid walking through trees and other terrain features.
    * Cabins have been combined into one entry in Robin's menu.
    * Replaced pet icons on the inventory tab with the current date.
    * The “Organize” button now sorts items in a more intelligent way.
    * You can now drink mayonnaise and jelly, and eat pickles.
    * Some colored objects now count as their color for qi quest and dye menu.
    * Clam is now considered a "fish" just like all the other shellfish.
    * Added more descriptive titles to daily quests.
    * Added Cyrillic sprite text and some translated world pixel art text.
    * Adjusted the date/time/money box in Chinese.
    * The about page now shows the build number.
    * The [Skull Cavern](/Skull_Cavern "Skull Cavern") now have a chance to also play music from the upper mines.
    * Changed parrot flap sound to be different from bat flaps.
    * Pans now have a chance to yield bone fragments.
    * Made the character randomization a little less random, and added some of the newer hairstyles and accessories to the mix.
    * Pan no longer yields the same thing if you pan in the same spot twice in a day.
    * The about page no longer hides the version if a tip message is shown.
    * The order that you'll get forge enchantments is now unique per player rather than per farm.
    * The [Ginger Island shrine](/Ginger_Island#Gem_Birds "Ginger Island") item pedestals are now normal items. Modded players can spawn them to display items decoratively (though they're not obtainable in vanilla currently).
    * Map no longer closes if you click on an area of interest.
    * Fixed some NPC schedules that weren't previously applied:
      + [Lewis](/Lewis "Lewis") visiting the library on winter Sundays;
      + [Maru](/Maru "Maru") and [Penny](/Penny "Penny") hanging out on summer Sundays;
      + [Maru](/Maru "Maru") tinkering on summer Mondays;
      + After reaching six hearts with some NPCs, they won't visit their rival love interest anymore. This affects [Alex](/Alex "Alex") visiting [Haley](/Haley "Haley"), [Elliott](/Elliott "Elliott") visiting [Leah](/Leah "Leah"), and Haley visiting Alex.

Gameplay fixes
:   * [Fishing](/Fishing "Fishing") fixes:
      + If you're fishing when the pirate cave changes to pirate mode, you will catch your fish.
      + Fixed [artifacts](/Artifacts "Artifacts") found in [fishing chests](/Fishing#Treasure_Chests "Fishing") not counting for the collection tab.
      + Fixed fishing crash if a treasure chest appears while the player has a large number of stacked fishing buffs.
    * Buff fixes:
      + Fixed a range of bugs like attribute drift and double-debuff.
      + Fixed food/drink buffs discarded if they have a balanced total of effects (e.g. +2 attack and -2 speed).
      + Fixed negative custom buffs shown with a double-negative (e.g. "--2 speed").
      + Fixed Squid Ink Ravioli buff not remaining active if another food buff is added later (although the buff icon was still shown).
      + Fixed Squid Ink Ravioli not resetting the buff duration when you eat another one, unlike other food buffs.
      + Fixed Squid Ink Ravioli description having an extra blank line.
      + Fixed Burnt not showing the -3 Attack effect.
    * Festival fixes:
      + Fixed unable to leave the [Festival of Ice](/Festival_of_Ice "Festival of Ice") until it ends.
      + Fixed two-second pause when entering the Stardew Valley Fair.
    * Item fixes:
      + Fixed dropped tools not recovered if they're inside a constructed building.
      + Fixed potted [tea bushes](/Tea_Bush "Tea Bush") planted in town not being harvestable.
      + Fixed [bee house](/Bee_House "Bee House") dropping a generic "Honey" item when you break it, instead of the flavored honey it would produce when harvested normally.
      + Fixed [farm computer](/Farm_Computer "Farm Computer") counting [fiber crops](/Fiber_Seeds "Fiber Seeds") as unwatered.
      + Fixed [geode](/Geode "Geode") and [lost book](/Lost_Books "Lost Books") message not shown if your first one is from a fishing chest.
      + Fixed [magic bait](/Magic_Bait "Magic Bait") disabling some fish area checks (e.g. so you could catch river fish in the forest pond).
      + Fixed [heavy tappers](/Heavy_Tapper "Heavy Tapper") not tracked correctly. That caused issues like heavy-tapped trees not ignored when creating [mushroom trees](/Mushroom_Tree "Mushroom Tree") in fall.
      + Fixed [rain totem](/Rain_Totem "Rain Totem") used during a storm incorrectly making the next day stormy instead of rainy.
      + Fixed [secret note #2](/Secret_Notes "Secret Notes") not revealing [Kent](/Kent "Kent")'s gift taste if he hasn't returned yet.
      + Fixed [wedding rings](/Wedding_Ring "Wedding Ring") being giftable to NPCs.
      + Fixed [watering can](/Watering_Cans "Watering Cans")'s water left and capacity resetting on right-click into chest.
      + Fixed [wilted bouquet](/Wilted_Bouquet "Wilted Bouquet") not cancelling the wedding if it hasn't happened yet.
      + Fixed various cases where item-received logic wasn't applied consistently.
    * Combat fixes:
      + You can now kill any slime for the "Initiation" quest, not just green slimes.
      + Fixed player stuck in swimsuit if they collapse from damage while wearing it.
      + Fixed broken event if the player is defeated in the mines and their name contains a slash.
      + Fixed issue where you could clear a forest-themed [mine level](/The_Mines "The Mines") without finding a ladder.
      + Fixed Magma Sparker's debuff ignoring squid ink ravioli's protection.
    * Controller fixes:
      + Pressing the trigger buttons on a gamepad while in the junimo bundle menu now snaps the cursor to the ingredients slot or back.
      + Improved controller navigation on the Junimo bundle page and world map.
      + Fixed issue which could cause Junimo Kart to be unplayable with a controller, if you had rebound keys to certain values.
      + Fixed issue where viewing a letter with multiple pages and positioning the cursor directly above the skip button could cause the next viewed event to be skipped when the `A` button is pressed to progress text.
    * UI fixes:
      + Fixed issue where clicking an item attached to a letter could exit the letter if your inventory was full.
      + Fixed items from dialogue being lost if your inventory was full. You'll now see a menu to collect them when the dialogue closes.
    * Fixed gates popping off when opening or closing them while the player overlaps the tile.
    * Fixed random seeds on [Ginger Island](/Ginger_Island "Ginger Island") being based on the valley's season.
    * Fixed exploit where you could keep temporary items like Qi Fruit by selling them to Pierre and buying them back later.
    * Fixed fruit trees being plantable on stone tiles outside the greenhouse.
    * Fixed tree stumps dropping seeds like full-grown trees.
    * Fixed riding an orphaned horse (e.g. spawned using [debug commands](/Modding:Debug_commands "Modding:Debug commands")) preventing you from owning or riding other horses.
    * Fixed some mail not received on the intended day if you don't leave the farmhouse that day.
    * Fixed bug where it was faster to harvest left-to-right than right-to-left.
    * Fixed some spots where forage could appear out-of-bounds.
    * Fixed spot where you could run into the water on the beach farm.
    * Fixed minecarts unlocked before you've seen the cutscene.
    * Fixed able to place things underneath the traveling merchant cart and pig.
    * Fixed some undiggable tiles in Ginger Island dig site.
    * Fixed geode crusher "off-by-one" bug/exploit.
    * Fixed speed of Taro growth when grown with agriculturist and hyper speed gro (and generally fixed issues with negative phase durations).
    * Fixed invisible menu preventing you from moving after closing out of the bulletin board Junimo note, if you were holding a useable object.

NPC fixes
:   * Dialogue fixes:
      + Fixed NPCs not having custom dialogue when accepting a movie invite for non-English players.
      + Fixed Abigail showing both default and custom item delivery dialogue.
      + Fixed Lewis skipping his final dialogue at the [Festival of Ice](/Festival_of_Ice "Festival of Ice") on subsequent player wins.
      + Fixed the [fortune teller](/Stardew_Valley_Fair "Stardew Valley Fair") nearly always showing the text for your combat skill, instead of your highest skill.
      + Fixed issue where an NPC who bought an iridium-quality item you sold to a shop could show a low-item-quality dialogue for it.
      + Fixed issue where NPC dialogue could reveal gift tastes for an invalid item.
      + Fixed [monster grave text](/Abigail#Fourteen_Hearts "Abigail") only shown in English.
      + Fixed wrong message shown when placing indoors-only furniture outside.
    * Fixed the Krobus vs Dwarf event able to happen on Fridays.
    * Fixed giving a gift not counting toward socialization quests.
    * Fixed invisible spouses asking to have children.
    * Fixed able to invite Leo to the movies before he moves to the valley.
    * Fixed able to interact with NPCs during the ice fishing event.
    * Fixed NPC spouse chores sometimes not applied on the intended day (e.g. saying they filled the pet water bowl but it's not filled).
    * Fixed NPC spouses watering crops that don't need it (e.g. fiber seeds or already watered), and almost never showing the crops-were-already-watered dialogue.
    * Fixed NPCs sometimes not reacting to dumpster diving if the horse is nearby.
    * Fixed Penny losing items when redecorating if they were placed on a [stone slab](/Stone_Slab "Stone Slab") (or a custom table without *Table* in the name).

Multiplayer fixes
:   * Mitigated potential remote code execution issue.
    * Possibly fixed frequent disconnections for some players.
    * Fixed old/incorrect Steam display names being shown in some cases.
    * Fixed phantom action cursor over backwoods gravestone if the current player hasn't seen [the related event](/Abigail#Fourteen_Hearts "Abigail") yet.
    * Fixed copy & paste for invite codes on some Linux/macOS platforms.
    * Fixed issue where the mines were checking for the luck level of players in the host's current location, rather than players in the mines.
    * Fixed global chat info messages (like "*Abigail caught PlayerName digging through the trash*") sometimes showing text in the sender's language instead of yours.
    * Fixed [egg festival](/Egg_Festival "Egg Festival") requiring 12 eggs to win if there are 5+ players. It now applies the four-player requirement to any player count beyond that.
    * Fixed farmhands sometimes able to walk out of bounds at festivals.
    * Fixed farmhands who disconnected while fishing sometimes stuck frozen on reconnect.
    * Fixed farmhands who disconnected while playing a minigame (like Journey of the Prairie King) still hearing the music on the title screen.
    * Fixed farmhands who disconnected while in the building placement view being invisible on rejoin.
    * Fixed farmhands seeing spouse's outdoor area in the wrong spot on the beach farm.
    * Fixed farmhands experiencing latency able to click a horse, walk to a different location, then get teleported out of bounds.
    * Fixed farmhands able to collect multiple [statues of perfection](/Statue_Of_Perfection "Statue Of Perfection").
    * Fixed farmhands unable to enter a movie without all players.
    * Fixed farmhands' local effects sometimes based on host data (e.g. the host's equipped rings).
    * Fixed farmhands' prismatic shards sometimes spawning at the host's location instead.
    * Fixed farmhands' rings leaving lights behind when they disconnect.
    * Fixed farmhand crash while fishing in rare cases.
    * Fixed farmhand crash when they warp just as certain things happen (e.g. pet sounds).
    * Fixed farmhand crash if train approaches while they're mid-warp.
    * Fixed other players seeing a farmhand's old spouse room if they divorced and remarried in the same session.
    * Fixed dinos being able to hurt the host when they aren't in the same location.
    * Fixed monster drops for farmhands sometimes applying the host's ring effects and secret note.
    * Fixed various visual glitches with other players' tool/fishing animations.
    * Fixed crash when displaying a player status list which is missing a connected player.
    * Fixed dialogue being interrupted if another player starts a broadcast event; the event will now start for you when you finish the current dialogue instead.
    * Fixed enemy projectiles targeted at farmhands able to hit the host player in a different location.
    * Fixed monsters not taking damage from some hits if multiple players are attacking them at once.
    * Fixed projectiles causing damage multiple times in multiplayer.
    * Fixed various cases where values weren't correctly synced between players.
    * Fixed watered dirt edges not updated for farmhands when they change overnight.
    * Fixed 'caught snooping' chat message not triggered when Marnie sees the player searching her trash bin.
    * Fixed cleared-landslide mail only sent to the main player.
    * Fixed [watering can](/Watering_Cans "Watering Cans")'s water left and capacity not synced in multiplayer.
    * Fixed the local player's step/fishing stats being incremented by other players walking or fishing.
    * Fixed players sometimes seeing slightly different daily quests or [crop fairy event](/Random_Events#The_Crop_Fairy "Random Events").
    * Fixed issue where a farmhand donating the 60th museum artifact wouldn't grant the [rusty key](/Rusty_Key "Rusty Key").
    * Fixed issue where reading another player's secret notes or journal scraps could lock them out of perfection.
    * Fixed issue where the host pausing the game while it's raining and a farmhand is moving would cause the frozen rain to slide across the screen.
    * Fixed exploit where a farmhand would have full energy after passing out if they disconnected while sleeping earlier in the day.

Display text and localization fixes
:   * Spanish prices are now formatted like *15o* instead of *15g* to match the translated term (*oro* instead of *gold*).
    * Fixed unlocalized text shown for...
      + the building paint menu's region names (like "Roof" or "Trim");
      + NPC names in some movie theater dialogue;
      + NPC names in the spouse pregnancy question;
      + Professor Snail's name after his first event;
      + Leo's name in his introductory event for some languages;
      + fish names for some languages in certain cases;
      + the 'Miss' text when an attack misses.
    * Fixed Lewis' letter for Feast of the Winter Star saying it starts at 10am instead of 9am.
    * Fixed [dust sprites](/Dust_Sprite "Dust Sprite") called *dust spirits* in Clint's special order and the summit cutscene.
    * Fixed various typos, broken tokens, translations that don't match the original, etc.
    * Fixed NPC name translations applied to horses/pets that share a name with that NPC.
    * Fixed random name generator able to produce words similar to certain slurs.
    * Fixed world map tooltip for Pierre's shop still showing "closed on Wednesdays" after he extends his business hours.
    * Fixed some recipe names not matching the items they produce.
    * Fixed the hats added in 1.5 translating their internal name instead of setting the display name in some languages.
    * Fixed museum item descriptions not having an intended newline.
    * Fixed French formatting times past midnight like "26h" instead of "02h" (e.g. on the fishing TV channel).
    * Fixed French and Turkish showing broken dialogues about another NPC's gift tastes.
    * Fixed French-only display text bugs related to the `^` dialogue token.
    * Fixed German truncating Professor Snail's name in his intro event.
    * Fixed Japanese and Korean formatting buff effects inconsistently.
    * Fixed some broken Japanese movie reaction dialogue.
    * Fixed Korean credit line missing in other languages.
    * Fixed Russian event for Professor Snail's intro freezing.

Cosmetic fixes
:   * UI fixes:
      + The perfection tracker now paginates better to fit the current screen size.
      + Moved "?" icon on dialogue question boxes.
      + Removed phantom action cursor over island farmhouse drawer.
      + Fixed toolbar drawn behind the time/money box.
      + Fixed cursor over NPCs sometimes showing a gift icon when they won't accept or react to the held item.
      + Fixed some in-game error messages not having an error icon.
      + Fixed inventory & crafting menus misaligned if you resize the window while they're open.
      + Fixed flashing tooltips when hovering between elements in the cooking page and collections tab.
      + Fixed cosmetic issues with the title & shipping screens for higher-resolution displays.
      + Fixed calendar tooltip when a modded festival and birthday occur on the same day.
      + Fixed calendar drawing child NPCs lower than intended.
      + Fixed the `!` fish bite icon not shown when fishing in the [Stardew Valley Fair](/Stardew_Valley_Fair "Stardew Valley Fair") and [Festival of Ice](/Festival_of_Ice "Festival of Ice").
      + Fixed [quality fertilizer](/Quality_Fertilizer "Quality Fertilizer") showing a green tile on sprouted crops, even though it can't be placed there.
      + Fixed perfection tracker not skipping the typing effect when it's paginated.
      + Fixed the [forge](/Forge "Forge") preview always showing soul level one for a [galaxy soul](/Galaxy_Soul "Galaxy Soul") forge.
      + Fixed [advanced save option](/Options "Options") tooltips being able to extend off-screen, and not shown for some field labels.
      + Fixed clothing/tools sometimes showing the item-received notification on unequip.
      + Fixed HUD messages sometimes overlapping.
      + Fixed fonts sometimes having a 'thin' look.
      + Fixed world map tooltip for JojaMart disappearing when the movie theater is built.
      + Fixed stack numbers not drawn for machine output when the stack is > 1.
      + Fixed animal purchase menu having unnecessary padding on the right.
      + Fixed wiggling bottom of energy bar.
    * Placed object fixes:
      + Crab pots no longer appear during the moonlight jellies.
      + Tub o' flowers now shows the correct sprite on the day it is placed, and now always blooms indoors.
      + Fixed beds or chests that were hidden for an event not reappearing afterwards.
      + Fixed furniture drawn over sitting players if it has no front texture.
      + Fixed bombs being invisible when placed on [the summit](/The_Summit "The Summit").
      + Fixed bombs able to remove [stick bugs](/Stick_Bug "Stick Bug")' sticks.
      + Fixed colored objects not drawn correctly when placed on tables or eaten.
      + Fixed prismatic hats not displayed properly on alien rarecrows.
      + Fixed lanterns and other furniture lights not turning on after save/load if they are on a table.
    * Possibly fixed clumping issue for weather debris like the spring petals.
    * Fixed layering issues with seagulls and Willy's house.
    * Fixed fruit tree leaves not rustling in winter even if they're in a non-seasonal location like the [greenhouse](/Greenhouse "Greenhouse").
    * Fixed barren trees having a leafy shadow.
    * Fixed weeds being less varied than intended in summer.
    * Fixed weeds able to grow on top of buildings on spring 1.
    * Fixed intro cutscene position not adjusted when the farmhouse is moved by a mod.
    * Fixed pre-built cabins sometimes placed on top of a bush or log.
    * Fixed many things on [Ginger Island](/Ginger_Island "Ginger Island") applying the valley's season or weather (including [fiber seeds](/Fiber_Seeds "Fiber Seeds"), [seasonal decor](/Seasonal_Decor "Seasonal Decor"), [seasonal plants](/Seasonal_Plant "Seasonal Plant"), [tea bushes](/Tea_Bush "Tea Bush"), and [tubs o' flowers](/Tub_o%27_Flowers "Tub o' Flowers")).
    * Fixed Elliott appearing twice during the [egg hunt](/Egg_Festival "Egg Festival").
    * Fixed Lewis' saloon drinking animation having an incorrect frame.
    * Fixed bombed objects becoming tiny and sometimes showing wrong sprite index while they flash before removal.
    * Fixed building placement visual/sound effects playing even for players who are nowhere near it.
    * Fixed speech bubbles sometimes shown over invisible NPCs.
    * Fixed [crane minigame](/Movie_Theater#Crane_Game "Movie Theater")'s music sometimes continuing a few seconds after the minigame ends.
    * Fixed 'you received X' message & animation showing wrong item if you switch held item right as it's triggered.
    * Fixed some events fading in after a scene change before they're fully ready, which caused issues like NPCs visibly warping into place or mid-fade flashes.
    * Fixed ginger showing a watered dirt tile if you water it. This incorrectly implied that ginger needs to be watered.
    * Fixed missing explosion tiles in mega bomb explosions.
    * Fixed town festivals not showing the right version of Pam's house and community center.
    * Fixed an incorrect frame in Lewis' saloon drinking animation.
    * Fixed layering draw issue in the fishing fair minigame.

Fixes for modded players
:   * Festivals now only set sunny weather in their location context. (For example, a custom festival in the desert no longer changes weather in the valley.)
    * Monsters no longer [spawn at night](/Options#Advanced_Game_Options "Options") by default on custom farm types.
    * Non-binary NPCs can now pathfind through any gendered route (e.g. men's or women's locker room), instead of defaulting to female routes.
    * Fixed crashes when...
      + loading a save with unknown locations or farm type, NPCs with no sprite texture, or null world objects.
      + the farm map has no grass spawn tile and you walk through crops or grass.
      + the data for an item, animal, tree, etc no longer exists.
      + [painting a building](/Carpenter%27s_Shop#Painting "Carpenter's Shop") if its sprite changed to a smaller one since it was last painted.
      + playing audio which doesn't exist (it now logs an error and plays a default 'quiet click' sound instead).
      + a farmhand warps to a location which doesn't exist locally yet.
      + an NPC can't parse its dialogue (it now logs the error and defaults to "..." instead).
      + a [special order](/Quests#List_of_Special_Orders "Quests")'s data can't be parsed.
      + a [mini-jukebox](/Mini-Jukebox "Mini-Jukebox") has an invalid track selected (it now turns off instead).
      + a [mini-shipping bin](/Mini-Shipping_Bin "Mini-Shipping Bin") has null items.
      + a [statue of endless fortune](/Statue_Of_Endless_Fortune "Statue Of Endless Fortune") tries to produce a gift for an NPC whose first loved gift is a category or context tag (it now now chooses the first valid gift taste, and falls back to a non-birthday gift if none was found);
      + a farm animal warps home in rare cases;
      + the player's NPC spouse no longer exists (e.g. the mod which added it was removed).
    * Fixed calendar support for multiple events on the same day (including multiple weddings, multiple birthdays, birthdays on a festival day, etc).
    * Fixed horses in indoor locations or [mine](/The_Mines "The Mines")/[volcano](/Volcano_Dungeon "Volcano Dungeon") levels unable to return home.
    * Fixed event setup not allowing more than 9 players.
    * Fixed events not exiting correctly if they crash before the first script command.
    * Fixed event errors not logged to the console.
    * Fixed potential event crash if a custom NPC name contains 'farmer'.
    * Fixed save loading very slowly if it has a broken outdoors location in some cases.
    * Fixed some items being unremovable when spawned by players. This affects [incubators](/Incubator "Incubator"), [mushroom boxes](/The_Cave#Mushrooms "The Cave"), [slime balls](/Slime_Ball "Slime Ball"), and three unused items (locked doors and alternate [wicked statues](/Wicked_Statue "Wicked Statue")).
    * Fixed issue when warping to [Sandy](/Sandy "Sandy") early using mods where she could give daily quests as soon as you met her, but didn't accept items until you fixed the bus.
    * Fixed issue where sleeping in a location where an event starts the next day would skip overnight events and soft-lock the game.
    * Fixed invalid game state when the day of month increases past 28 due to a mod issue. Any day past 28 is now treated as the last day of the season.

Other bug fixes
:   * Fixed crash when taking a screenshot on macOS if the `~/.local` folder doesn't exist.
    * Fixed crash when removing light glows in rare cases.
    * Fixed window resize on character creation resetting profit margins & starting cabins, and desyncing the 'skip intro' checkbox.
    * Fixed able to equip a [staircase](/Staircase "Staircase") as pants to obtain [trimmed lucky purple shorts](/Secrets#Lucky_Purple_Shorts "Secrets").
    * Fixed being able to place a [yellow couch](/Yellow_Couch "Yellow Couch") in a [loom](/Loom "Loom").
    * Fixed wilderness farm spawning a stone in water.
    * Fixed hill-top farm spawning grass inside of stumps.
    * Fixed [Trash Bear](/Trash_Bear "Trash Bear") treated as a villager (e.g. it could theoretically be picked for quests).
    * Fixed save folder collision if you set the save's name & seed to the same value as an existing save.
    * Fixed selecting small buildings in the construction menu's farm view. This fixes the gap above the shipping bin where it can't be selected, and fixes small buildings selectable by hovering three tiles above them.
    * Fixed the build number not set on Linux/macOS.
    * Fixed unable to write vanilla error logs for players with special characters in their name.

## 1.5.6

Stardew Valley 1.5.6 was [released](https://www.stardewvalley.net/1-5-6-out-now-on-steam-gog/) on 21 December 2021. Hotfixes were applied on 22 December 2021 (twice) and 18 January 2022.

Quality of life changes
:   * On multi-monitor setups, the game now remembers and restores on the last used monitor.

Bug fixes
:   * Possibly fixed a random crash that could occur at the end of the night.
    * Fixed issue where some farm types' [wallpapers](/Wallpaper "Wallpaper") and [floors](/Flooring "Flooring") weren't applied when starting a new game.
    * Fixed pressing ESC to dismiss the level up screen also skipping the level up itself, causing it to reappear every night.
    * Fixed tilled dirt still decaying under forage items on the farm. This means that dirt under [freshly grown seasonal forage seeds](/Crafting#Seeds "Crafting") can no longer disappear randomly.
    * Fixed [grass](/Grass "Grass") placed indoors dying when the season changes to [Winter](/Winter "Winter").
    * Fixed unable to harvest [tea saplings](/Tea_Sapling "Tea Sapling") placed in [garden pots](/Garden_Pot "Garden Pot") on [Ginger Island](/Ginger_Island "Ginger Island").
    * Fixed the Z key unbindable after resetting controls to the default.
    * Fixed map screenshots not working on Linux.
    * Fixed [modding issues](/User:Pathoschild/Modding_wishlist/Completed#Done_in_Stardew_Valley_1.5.6 "User:Pathoschild/Modding wishlist/Completed").

Internal changes
:   * Updated Steamworks.NET to 20.0.0.

Further changes were later released without changing the version number:

22 December 2021 ([announcement](https://twitter.com/ConcernedApe/status/1473385614133239808))
:   * Fixed crash when starting the game on the compatibility branch on macOS.
    * Fixed unable to move the game window from one desktop to another in some monitor configurations.
    * Fixed issue that prevented selecting a profession using a gamepad. You should be able to re-select any missed professions the next day.
    * Fixed [garden pots](/Garden_Pot "Garden Pot") automatically harvesting when moused over.
    * Fixed [Emily](/Emily "Emily")'s patio decorations being one tile above where they should be.

22 December 2021
:   * Fixed issue initializing Steam SDK in 1.5.6.

18 January 2022 "Hotfix #3" (appended to [1.5.6 announcement](https://store.steampowered.com/news/app/413150/view/4451243368885879000))
:   * The version shown on the title screen `?` menu now reflects hotfixes.
    * Changed how the Stardew valley logo is scaled on the title screen for resolutions with lower heights.
    * Removed the numeric hotkey displays along the top of the inventory screen menu when playing on a controller.
    * Fixed player/horse placement issues after triggering an event on the farm while on horseback (including an issue that could cause a farmhand to become stuck in a wall after viewing Leah's 6-heart event).
    * Fixed Korean/English dialogue line swapped for collapsed-in-Volcano scene.
    * Fixed exclusive fullscreen mode being off-center or incorrectly sized when Window's zoom isn't set to 100% on main-branch builds.
    * Added failsafe when maximizing/windowing from the title screen to clamp to the upper-right corner of the current display in fullscreen mode.

## 1.5.5

Stardew Valley 1.5.5 was released to the Steam beta branch on 17 August 2021 for mod authors, [announced in the forums](https://forums.stardewvalley.net/threads/stardew-valley-1-5-5-technical-update-beta.8893/) on 07 September 2021, and [released to all players](https://www.stardewvalley.net/stardew-valley-1-5-5-released-on-pc/) on 30 November 2021. Hotfixes were applied on 3 December 2021, 5 December 2021, and 7 December 2021.

Architectural changes
:   * Added support for Xbox Game Pass.  
      *This migrates the game on Windows from .NET Framework 4.5.2 to .NET 5. You may need to launch the vanilla game once through Steam/GOG to install the new dependencies.*
    * Added internal changes for mod authors (see [mod author migration guide](/Modding:Migrate_to_Stardew_Valley_1.5.5 "Modding:Migrate to Stardew Valley 1.5.5") and [completed modding wishlist items](/User:Pathoschild/Modding_wishlist/Completed#Done_in_Stardew_Valley_1.5.5 "User:Pathoschild/Modding wishlist/Completed")).

Quality of life changes
:   * Holding Control + Shift now lets you purchase or craft stacks of 25 items at a time.
    * Many in-game settings now remember their last value when you start a new save. (Some settings like zoom level, gamepad mode, and multiplayer server privacy aren't copied over.)
    * You can now build or move farm buildings onto artifact spots (which will destroy the artifact spots).
    * You can now nudge pets out of the way while building/moving a building by clicking on them.
    * You can now buy back items accidentally sold in the same shopping session.
    * The in-game time is now shown on the upper-right hand corner of the screen when playing Journey of the Prairie King in multiplayer.
    * [Grass](/Grass "Grass") placed using [grass starters](/Grass_Starter "Grass Starter") during winter no longer disappears when the game is reloaded (but it still won't grow or spread). Grass that's outdoors in winter now takes on the appearance of the grass found in the frost section of [the mines](/The_Mines "The Mines").
    * Added `/printdiag` chat command which prints some diagnostic info to the chat window.

Localization fixes
:   * Fixed [Shane](/Shane "Shane")'s 6-heart event soft-locking in the Hungarian translation.
    * Fixed incorrect '`\`' characters in various events in the Hungarian localization.
    * Fixed typos in the French localization.
    * Fixed a typo in [Livin' Off The Land](/Livin%27_Off_The_Land "Livin' Off The Land") that incorrectly states that [super cucumber](/Super_Cucumber "Super Cucumber") can be caught in [Winter](/Winter "Winter").

Cosmetic fixes
:   * Added commas to the price display on [Robin](/Robin "Robin") and the [Wizard](/Wizard "Wizard")'s building menus.
    * Adjusted collisions on the desert map to avoid sorting issue on the top-left edge of raised cliffside.
    * Fixed issue where Sebastian's sprite would shift into an invalid position at 1:00 PM when he's working on his bike on the farm.

General fixes
:   * After completing the Cryptic Note [quest](/Quests "Quests"), reaching floor 100 of the [Skull Cavern](/Skull_Cavern "Skull Cavern") again will guarantee a chest.
    * Fixed issue where [the harder Mines](/The_Mines#Shrine_of_Challenge "The Mines") could become permanently enabled and unable to change back.
    * Fixed [radioactive bars](/Radioactive_Bar "Radioactive Bar") not affected by the Blacksmith profession.
    * Fixed explosion radius not centered when dislodging flooring and certain other types of items.
    * Fixed [garden pots](/Garden_Pot "Garden Pot") clearing their fertilizers when a crop is harvested.
    * Fixed placing a garden pot on [Ginger Island](/Ginger_Island "Ginger Island") on a rainy day not watering its dirt.
    * Fixed multiplayer hosts registering their lobbies before fully loading a save, causing the games not to appear in the multiplayer games list.
    * Fixed moving a cabin with a cellar causing the stairs to the cellar to warp the players out of bounds for the rest of the play session.
    * Fixed a case where entering the Farm from the south on horseback and triggering an event could cause the player to get stuck in a wall.
    * Fixed various invisible tiles preventing certain spots in the Mountain lake from spawning fish activity bubbles.
    * Fixed the tile holding the plant on [Elliott](/Elliott "Elliott")'s table not being passable.
    * Fixed some tiles on the left side of the [beach farm](/Farm_Maps "Farm Maps") being unbuildable.

Further changes were later released without changing the version number:

3 December 2021 ([announcement](https://twitter.com/ConcernedApe/status/1466910416106582020), release notes appended to [1.5.5 post](https://www.stardewvalley.net/stardew-valley-1-5-5-released-on-pc/))
:   * Fixed widescreen and UHD displays not handled correctly.
    * Fixed crash in the French localization for the "It Howls In The Rain" [movie](/Movie_Theater "Movie Theater").
    * Fixed GOG builds not optimized for release, which caused errors with some mods.
    * Fixed gamepad issues on Linux and macOS with the main 64-bit branch.

5 December 2021
:   * Reverted gamepad fix in the previous update, which caused crashes for some players.

7 December 2021 (see announcement for [release](https://twitter.com/ConcernedApe/status/1468380233871069193), [revert](https://twitter.com/ConcernedApe/status/1468412645594189824), and [re-release](https://twitter.com/ConcernedApe/status/1468446544122707970))
:   * Fixed a memory leak related to sound effects.
    * Fixed an issue where quitting the game in exclusive fullscreen would revert to windowed borderless upon reloading the game.
    * Fixed an issue where the last-used volume levels weren't properly applied when starting a new game.
    * Fixed [special orders](/Quests#List_of_Special_Orders "Quests") board appearing distorted during festivals.
    * *(Modding)* Fixed `[HOURS_24_00]` not properly zero padded.

## 1.5.4

Stardew Valley 1.5.4 was [released](https://www.stardewvalley.net/stardew-valley-1-5-4-patch-out-now-on-pc/) on 22 January 2021. A hotfix was applied on 2 June 2021.

Changes

:   * [Pam](/Pam "Pam") no longer visits the [Island](/Ginger_Island "Ginger Island") resort on [Sandy](/Sandy "Sandy")'s birthday.
    * The [Stardew Valley Fair](/Stardew_Valley_Fair "Stardew Valley Fair") shop no longer sells multiples of the randomly chosen items.
    * The Stardew Valley Fair shop now sells [triple shot espresso](/Triple_Shot_Espresso "Triple Shot Espresso") instead of [tea sapling](/Tea_Sapling "Tea Sapling").

Multiplayer fixes

:   * Fixed a rare crash that could occur when watching an event in multiplayer as the clock hits midnight or 1am.
    * Fixed the sound of fiber crops being harvested being audible when you're in another area.

General fixes

:   * Items related to Qi challenges and special orders are now properly removed from both [Marlon's Item Recovery Service](/Adventurer%27s_Guild#Item_Recovery_Service "Adventurer's Guild"), and items requested to be recovered are now removed from the mailbox once the quest expires.
    * Fixed [perfection](/Perfection "Perfection") check not accounting for games where the farm switched to the Joja route partway through a Community Center playthrough.
    * Fixed [lucky rings](/Lucky_Ring "Lucky Ring") losing their luck bonus overnight.
    * Fixed softlock when fishing with multiple rods in your inventory after catching a treasure and casting from a different rod. This fixes the common fishing rod softlock next to Willy's house and during the [Festival of Ice](/Festival_of_Ice "Festival of Ice").
    * Fixed exploit where entering the [Skull Cavern](/Skull_Cavern "Skull Cavern") would immediately unlock all 120 floors for the elevator in [The Mines](/The_Mines "The Mines").
    * Fixed exploit where you could find [lost books](/Lost_Books "Lost Books") by storing and retrieving certain wallpapers in chests.
    * Fixed a rare issue where a charged [hoe](/Hoes "Hoes") could dislodge a non-empty chest and destroying its contents if it was placed in a specific configuration next to other chests.
    * Fixed issue where the buttons in the [CalicoJack](/CalicoJack "CalicoJack") and [Calico Spin](/Slot_Machine "Slot Machine") minigames wouldn't respond to controller input if the UI scale setting didn't match zoom level setting.
    * Fixed issue where bombing certain floor tiles in the [quarry](/Quarry "Quarry") would spawn items.
    * Fixed palm trees in [the desert](/The_Desert "The Desert") producing [golden coconuts](/Golden_Coconut "Golden Coconut").
    * Fixed being able to interact with objects while warping with the [return scepter](/Return_Scepter "Return Scepter").
    * Fixed trees able to grow on top of placed furniture items.
    * Fixed a minor graphical inconsistency with the quality indicator on procedurally-colored objects such as flowers.
    * Fixed [Leo](/Leo "Leo")'s first event unable to complete when playing in the Korean localization.
    * Fixed the special order board being invisible during summer in the Korean localization.
    * Various localization corrections.

Further changes were later released without changing the version number:

2 June 2021 ([announcement](https://twitter.com/ConcernedApe/status/1411025886090989568))
:   * Adjusted the randomization of the [mummified bat](/Mummified_Bat "Mummified Bat") drop.
    * Fixed multiplayer issues on macOS.
    * Fixed text wrapping issue on the Special Orders board in the Korean localization.
    * Fixed some [stardrops](/Stardrop "Stardrop") not always counted for the [perfection](/Perfection "Perfection") score. Reaching max stamina now counts as having found all stardrops.

## 1.5.3

Stardew Valley 1.5.3 was [released](https://www.stardewvalley.net/stardew-valley-1-5-3-patch-out-now-on-pc/) on 15 January 2021. A hotfix was applied on 16 January 2021.

Balance changes

:   * The [stone owl](/Random_Events#Stone_Owl "Random Events") is now rarer.
    * The [strange capsule](/Random_Events#Strange_Capsule "Random Events") now only spawns once per game.
    * [Prismatic slimes](/Slimes#Prismatic_Slime "Slimes") are now more common (0.8% chance to 1.2% chance), and their spawn rate is now affected by [daily luck](/Luck "Luck").
    * Fixed exploit where [Qi beans](/Qi_Bean "Qi Bean")/[fruit](/Qi_Fruit "Qi Fruit") weren't removed from machines/craftables after the challenge expires.
    * You can no longer catch Qi Beans when fishing during festivals.

Minor changes

:   * Adjusted [Leo](/Leo "Leo")'s gift tastes.
    * Tweaked stone owl sprite.
    * [Penny](/Penny "Penny")'s 14 heart event now places your existing bed in a chest rather than replacing it.
    * [Furniture](/Furniture "Furniture") is no longer visible and can no longer block movement during events that take place outside of the farm.

Multiplayer fixes

:   * [Crab pots](/Crab_Pot "Crab Pot") now check the professions of the player who refilled them. This fixes a case in multiplayer where a player's profession (such as Mariner) would appear to not work because the crab pot was originally placed in the water by someone else.
    * Fixed the summit event not triggered if the player is married to another player.
    * Fixed the menu backgrounds option displayed incorrectly when playing in [split-screen mode](/Multiplayer "Multiplayer") on a rainy day.
    * Fixed incorrect button mapping shown on Local Coop Join screen.

General fixes

:   * Experimentally fixed rendering on ultra-wide displays.
    * Potentially fixed various cases where the player could get stuck or softlocked in an animation after using a tool (including the the [horse flute](/Horse_Flute "Horse Flute") softlock and possibly [fishing](/Fishing "Fishing") softlocks).
    * The Farmer no longer blinks while charging a tool. This was causing a minor visual issue.
    * Fixed [summit](/The_Summit "The Summit") event being repeatable if its music wasn't marked as heard. The music is now saved as soon as the event is started.
    * Fixed issue where a character could spawn on the upper-left corner of the island map when skipping the [Ginger Island](/Ginger_Island "Ginger Island") departure event while the character is still pathing.
    * Fixed [Leo](/Leo "Leo") using the wrong schedule on Wednesdays after his six-heart event.
    * Fixed issue where the [quality bobber](/Quality_Bobber "Quality Bobber") wasn't applying its bonus.
    * Fixed [magic bait](/Magic_Bait "Magic Bait") not working to catch [Night Market](/Night_Market "Night Market") fish in the southwest corner of the beach.
    * Fixed issue where you could get softlocked if you hooked a fish just as the [pirate cave](/Ginger_Island#Pirate_Cove "Ginger Island") event begins.
    * Fixed some minor data entry issues on normal [bundles](/Bundles "Bundles") that also appear in remixed bundles (Animal Bundle requiring a small brown egg instead of a large white egg, and normal cheese not being an option in the Artisan Bundle).
    * Fixed bug preventing prismatic slimes from not dropping [prismatic jelly](/Prismatic_Jelly "Prismatic Jelly") in rare cases.
    * Fixed bug where the [strange capsule](/Random_Events#Strange_Capsule "Random Events") would leave a residual light glow.
    * Fixed overnight lost & found tool logic not checking the island farmhouse fridge.
    * Fixed crash that could occur if a [dust sprite](/Dust_Sprite "Dust Sprite")'s stone-breaking move would cause a Qi Bean to spawn.
    * Fixed a long delay after talking to [Gourmand](/Ginger_Island#Gourmand_Frog "Ginger Island") when you've got the crop he's requested growing, but it's not yet fully grown.
    * Fixed the daytime music from [Ginger Island](/Ginger_Island "Ginger Island") not being playable on the [Saloon jukebox](/The_Stardrop_Saloon#Jukebox "The Stardrop Saloon").
    * Fixed a crash when using a [warp totem](/Warp_Totem "Warp Totem") while the mermaid show is playing.
    * Fixed issue where you couldn't go back to sleep immediately after waking up after passing out.
    * Fixed item duplication glitches related to moving [rings](/Rings "Rings") around in certain menus.
    * Fixed certain gemstones appearing on the daily quest board before they're actually accessible in-game.
    * Fixed various localization issues.
    * (Modding) A randomized bundle containing an invalid item now shows a more detailed error message.
    * (Modding) Fixed big craftables losing mod data when picked up.
    * (Modding) Fixed issue where going from one floor to another on horseback [inside the Volcano](/Volcano_Dungeon "Volcano Dungeon") would position the player incorrectly on the next floor.

Further changes were later released without changing the version number:

16 January 2021 ([announcement](https://twitter.com/ConcernedApe/status/1350373110386606086))
:   * Fixed exploit where Qi beans/fruit weren't removed from [Marlon's item recovery service](/Adventurer%27s_Guild#Item_Recovery_Service "Adventurer's Guild") after the challenge expires.
    * Fixed a multiplayer fishing softlock added in 1.5.3.

## 1.5.2

Stardew Valley 1.5.2 was [released](https://www.stardewvalley.net/stardew-valley-1-5-2-patch-out-now-on-pc/) on 8 January 2021.

Feature changes

:   * You can now dismiss the level-up menu by pressing the ESC key.

Balance changes

:   * [Qi fruit](/Qi_Fruit "Qi Fruit") can now be grown on the farm during winter.
    * Tools now track the previous two enchantments applied to them so they're not reselected when you [reapply an enchantment](/Forge "Forge").
    * Coral and other aquatic forage items are now included for the "Botanist" profession.
    * Added [dark cowboy hat](/Dark_Cowboy_Hat "Dark Cowboy Hat") to [Skull Cavern](/Skull_Cavern "Skull Cavern") chest loot table.
    * You can no longer increase speed buffs using [Qi seasoning](/Qi_Seasoning "Qi Seasoning").
    * Buff durations from [Qi seasoned](/Qi_Seasoning "Qi Seasoning") food/drinks are now 50% longer.
    * You can no longer complete the "Danger In The Deep" Qi Challenge by visiting the Skull Cavern.
    * Reduced price when selling [cookout kits](/Cookout_Kit "Cookout Kit") from 3000g to 80g.
    * Reduced price when selling [ducks](/Duck "Duck") from 4000g to 1200g.
    * Fixed ducks not selling for the appropriate price.

[Ginger Island](/Ginger_Island "Ginger Island") fixes

:   * Adjusted a [journal scrap](/Journal_Scraps "Journal Scraps") treasure map to better represent the in-game location.
    * Added failsafe to prevent players from warping to the upper-left corner of the southern island map.
    * Passing out in Qi's secret room no longer causes you to wake up on the mainland.
    * Fixed Junimos not harvesting crops if you spent the night on the island or when you're not physically present.
    * Fixed unable to place [mini-fridges](/Mini-Fridge "Mini-Fridge") in the Island farmhouse.
    * Fixed unable to collect honey from [bee houses](/Bee_House "Bee House") on the island farm in winter.
    * Fixed [garden pots](/Garden_Pot "Garden Pot") on the island farm becoming watered on days when it's raining in the valley.
    * Fixed forage crops disappearing overnight on the island farm on Saturdays/Sundays.

Multiplayer fixes

:   * Fixed most minigames appearing misaligned in split-screen mode.
    * Fixed a crash that could occur in the [mermaid show](/Night_Market "Night Market") in split-screen mode.
    * Fixed farmhands getting stuck if two split-screen players choose the same farmhand at the same time.
    * Fixed a crash when crab pots are removed by a farmhand.

General fixes

:   * You can no longer sit on chairs if the game is currently pausing your character due to an animation (such as using a tool or kissing your spouse).
    * You can no longer instantly kill Fector as a zombie in [Journey of the Prairie King](/Journey_of_the_Prairie_King "Journey of the Prairie King").
    * Adjusted the rendering of very wide furniture items so that they do not extend too far past an inventory slot.
    * Fixed issue preventing 100% perfection score in the Joja route.
    * Fixed graphical issues with the post-perfection event.
    * Fixed coral not considered *red* instead of *pale violet red* for dyes, etc.
    * Fixed hearts dropped during Qi's Hungry Challenge not collectable if the inventory is full.
    * Fixed the level-up screen's OK button positioned offscreen in some cases.
    * Fixed the Key to the City not allowing you into Pierre's shop if you completed the game through the Joja route.
    * Fixed issue where large amounts of [beets](/Beet "Beet") placed in a mill wouldn't produce the proper amount of sugar.
    * Fixed gifting-related special order objectives not correctly checking the minimum liked value of gifted items.
    * Fixed special order-related items stored in Junimo chests not properly removed once the special order expires.
    * Fixed fruit tree saplings and seeds sold at festivals not properly reflecting the profit margins setting.
    * Fixed sign items no longer showing their placement indicator once a fish pond had been built on the farm.
    * Fixed combined rings only showing the stat buffs from their first component ring.
    * Fixed combined rings not properly using their localized name.
    * Fixed a ring duplication glitch in the dye pot menu.
    * Fixed a crash and other issues related to obtaining the Iridium Krobus item.
    * Potentially fixed a random crash that occurs when going to bed.
    * Potentially fixed a crash in the mines.
    * Fixed a crash when fishing from the pond on your farm using magic bait.
    * Fixed a bug causing cheese cauliflower to not display in the collections tab.
    * Fixed breaking open geodes and artifact troves incorrectly counted as two item collects in the collections tab.
    * Fixed a crash that could occur when clicking in the scrollbar region of a shop menu when there are less than four items available.
    * Fixed issue where placing a bomb and sleeping could cause the fuse sound to play indefinitely.
    * Fixed issue where weeds could appear as batteries.
    * Fixed weapon cooldown timers no longer displaying on weapons in the shop menu.
    * (Modding) Fixed order/naming of tilesheets on the beach farm inconsistent with the other farm types.

Localization fixes

:   * Fixed a missing event in Willy's shop from the Hungarian localization.
    * Fixed an issue with Leo's six-Heart event in the German localization. This fix is applied retroactively.
    * Fixed an issue where some weapons added in 1.5 would display an incorrect weapon name in the German localization.
    * Fixed crashes related to Lewis' phone call in various localizations.
    * Fixed various minor typos.
    * Various localization fixes.

## 1.5.1

Stardew Valley 1.5.1 was [released](https://steamcommunity.com/games/413150/announcements/detail/2926742382063004963) on 24 December 2020.

Feature changes

:   * The crystal cave puzzle now gradually gets easier after repeated misses.
    * Spouses no longer stand around looking at rug-type furniture items. This fixes a case where a spouse might stare at a floor divider, which could cause them to block the player's way through a narrow hallway.

Multiplayer fixes

:   * Fixed exploit where you could regain stamina in bed in multiplayer even if the game was paused.
    * Fixed rare issue where the host player would warp to an invalid position if a farmhand had just completed a [Community Center](/Community_Center "Community Center") bundle.

Localization fixes

:   * Various localization fixes and changes.
    * Fixed a crash when bombing the cave entrance next to the Field Office when playing in Spanish.
    * Fixed issues with Lewis's phone call in various localizations.
    * Fixed bug in the Spanish translations preventing Birdie's introduction event from completing.
    * Fixed bug in the German translations preventing male characters from completing Birdie's quest.

General fixes

:   * When dismissing the [forge](/Forge "Forge") menu, items that can't fit in your inventory are now dropped downward instead of upward to avoid items being dropped into the lava.
    * Fixed pets sometimes warping out of bounds.
    * Fixed being able to place objects in some parts of the void in the farmhouse.
    * Fixed "spawn monsters on the farm" advanced game option resetting when you choose a different farm type after changing it.
    * Fixed redeeming a stack of items at the [Stardew Valley Fair](/Stardew_Valley_Fair "Stardew Valley Fair") granting a single item, instead of the whole stack.
    * Fixed an issue related to having a child named Leo or Kent, where existing friendship points for these characters would be transferred over to your children.
    * Fixed some new hairstyles clipping through hats.
    * Fixed issue where purchasing the master slingshot would give the player a normal slingshot.
    * Fixed unable to select the Beach Farm on the new game screen when playing with a controller at minimum resolution.
    * Fixed Leo available as secret santa if he's not in town.
    * Fixed being able to place objects in certain tiles that block player movement such as the landslide that blocks the path to the Mines.
    * Fixed issue where killing big slimes carrying hearts during Qi's Hungry Challenge, while wearing the burglar's ring, would cause the hearts to be collectable in the player's inventory.
    * Fixed a crash that occurs when demolishing cabins.
    * Fixed a crash that could occur overnight if you place the Auto-Petter anywhere that isn't a coop or a barn.
    * Fixed Maru standing on the wrong tile outside the farm on Saturdays if you're married to her.
    * Fixed hair #56 accidentally replaced.
    * Fixed Birdie's item trade quest removing all stacks of an item when they're given to their intended recipient.
    * (Modding) Fixed the [return scepter](/Return_Scepter "Return Scepter") not returning to overwritten farmhouse entry positions.

## 1.5

Stardew Valley 1.5.0 was [released](https://www.stardewvalley.net/stardew-valley-1-5-update-out-now-on-pc/) on 21 December 2020. Hotfixes were applied on 21 December 2020, 22 December 2020, and 23 December 2020.

New world area
:   1.5 adds an entire new region of the world, [Ginger Island](/Ginger_Island "Ginger Island") in the [Fern Islands](/Setting#Fern_Islands "Setting"):

:   * Added new locations, dialogue, events, minigames, puzzles, and a quest line involving multiple NPCs.
    * Added [Leo](/Leo "Leo"), a new NPC with his own backstory, plot line, events, etc.
    * Added new secondary NPCs: [Birdie](/Birdie "Birdie"), [Gourmand Frog](/Ginger_Island#Gourmand_Frog "Ginger Island"), and [Professor Snail](/Professor_Snail "Professor Snail").
    * Added a [volcano dungeon](/Volcano_Dungeon "Volcano Dungeon") which changes each time you visit it similar to the mines.
    * Added [Qi challenges](/Quests "Quests") which unlock rare or unique items.
    * Added an unlockable island farm and farmhouse area, where you can plant crops in any season but can't construct buildings.
    * Added an unlockable resort you can open to let villagers visit the islands, including new beach attire and schedules.
    * Added hidden pages of a [lost sailor's journal](/Journal_Scraps "Journal Scraps") to uncover his story and learn about the islands.
    * Added [golden walnuts](/Golden_Walnut "Golden Walnut") hidden throughout the islands, which can be used to unlock new areas and content.
    * Added [golden coconuts](/Golden_Coconut "Golden Coconut"), which Clint can crack open to find rare island items.
    * Added secrets and puzzles to discover around the island.
    * Added new enemies:
      + [dwarvish sentry](/Dwarvish_Sentry "Dwarvish Sentry");
      + [false magma cap](/False_Magma_Cap "False Magma Cap");
      + [hot head](/Hot_Head "Hot Head");
      + [lava lurk](/Lava_Lurk "Lava Lurk");
      + [magma sprite](/Magma_Sprite "Magma Sprite");
      + [magma sparker](/Magma_Sparker "Magma Sparker");
      + [magma duggy](/Magma_Duggy "Magma Duggy");
      + [stick bug](/Stick_Bug "Stick Bug");
      + [tiger slime](/Slimes "Slimes").

* Added new cosmetic critters: crabs, caldera monkeys, overhead parrots, marsupial, and tropical butterflies.
* Added new [island obelisk](/Island_Obelisk "Island Obelisk") building.

New farm features

:   * Added a new beach [farm layout](/Farm_Maps "Farm Maps").
    * Added [ostrich](/Ostrich "Ostrich") as a farm animal.
    * The immovable dressers found in Farmhands’ cabins have been removed.
    * Added [home renovations](/Carpenter%27s_Shop#House_Renovations "Carpenter's Shop"), which let you further expand and adjust the farmhouse after it's fully upgraded.
    * Beds are now normal furniture you can pick up, move around, and replace. (You can even have a house with no bed, but your spouse might have something to say about that.)
    * Once unlocked, the [greenhouse](/Greenhouse "Greenhouse") can now be moved at Robin's shop.
    * The default [shipping bin](/Shipping "Shipping") can now be moved or demolished at Robin's shop.
    * Added advanced game options, which can be used to customize a new game:
      + set seed value used in randomization;
      + choose default vs randomized community center bundles;
      + choose default vs randomized mine chests;
      + make [red cabbage seeds](/Red_Cabbage_Seeds "Red Cabbage Seeds") guaranteed to sell at least once at the travelling cart in year one, so it's always possible to finish the community center in the first year;
      + change profit margins and cabin-related options that were previously inaccessible when creating a single-player farm.
      + can toggle monsters spawning.
    * You can now apply cosmetic paints to the farmhouse and buildings.
    * Ducks can now swim in water, and certain coop animals will now follow adults around.
    * Slimes now drink from slime hutch troughs in random order.

Other new content and features

:   * Added [tool and weapon enchanting](/Forge "Forge").
    * Added [ability to combine two rings into one](/Forge "Forge").
    * Added [special orders](/Quests#List_of_Special_Orders "Quests"), more dynamic late-game quests which let you help villagers with their personal projects through a special orders board in town. These can include more varied goals and rewards, temporary world changes (like new enemies for the duration of the quest), permanent changes (*e.g.,* new shop inventory), and post-completion events.
    * Added a second [community upgrade](/Carpenter%27s_Shop#Community_Upgrades "Carpenter's Shop").
    * Added a more difficult version of [the mines](/The_Mines "The Mines") and the [Skull Cavern](/Skull_Cavern "Skull Cavern"), which includes new and more powerful monsters along with better drops. These can be accessed late-game, and can optionally be toggled permanently using the [Shrine of Challenge](/The_Mines#Shrine_of_Challenge "The Mines").
    * Added new enemies which appear in the difficult mines:
      + [shadow sniper](/Shadow_Sniper "Shadow Sniper");
      + [skeleton mage](/Skeleton_Mage "Skeleton Mage");
      + [spider](/Spider "Spider") (jumps, often found near webs that can trap players and dust sprites);
      + [prismatic slime](/Slimes#Prismatic_Slime "Slimes") (quest only);
      + [putrid ghost](/Putrid_Ghost "Putrid Ghost") (causes nauseated [debuff](/Buffs "Buffs"));
      + [blue squid](/Blue_Squid "Blue Squid");
      + [royal serpent](/Royal_Serpent "Royal Serpent");
      + [slime](/Slime "Slime") variants ('cool' and stacked).
    * Added new fishing [TV channel](/Television "Television").
    * Added new crops and trees:
      + [mahogany tree](/Mahogany_Tree "Mahogany Tree") (drops hardwood)
      + [mahogany seed](/Mahogany_Seed "Mahogany Seed");
      + [fiber seeds](/Fiber_Seeds "Fiber Seeds");
      + [ginger](/Ginger "Ginger") (forage);
      + [banana](/Banana "Banana");
      + [mango](/Mango "Mango");
      + [pineapple](/Pineapple "Pineapple");
      + [taro root](/Taro_Root "Taro Root") (paddy crop);
      + New [palm tree](/Palm_Tree "Palm Tree") variant;
      + [Qi fruit](/Qi_Fruit "Qi Fruit") (available during special Qi quest).
    * Festival changes:
      + added new even-numbered year dialogues for [Egg Festival](/Egg_Festival "Egg Festival");
      + added shops to the [Dance of the Moonlight Jellies](/Dance_of_the_Moonlight_Jellies "Dance of the Moonlight Jellies"), [Feast of the Winter Star](/Feast_of_the_Winter_Star "Feast of the Winter Star"), [Festival of Ice](/Festival_of_Ice "Festival of Ice"), and [Luau](/Luau "Luau");
      + added new items to various festival shops;
      + Children now attend [festivals](/Festivals "Festivals").
    * You can now change your name and gender in the Wizard's basement shrine.
    * You now have a [perfection](/Perfection "Perfection") rating which tracks the percentage of game content you've completed. Reaching full completion lets you buy [golden chickens](/Golden_Chicken "Golden Chicken"), adds a random [Golden Witch](/Random_Events#The_Witch "Random Events") event, unlocks access to [the Summit](/The_Summit "The Summit") with a new event, and adds new bird critters.
    * You can now further customize sprinklers with attachments:
      + [enricher](/Enricher "Enricher") automatically applies loaded fertilizer while planting seeds nearby;
      + [pressure nozzle](/Pressure_Nozzle "Pressure Nozzle") increases watering range.
    * Added new craftable items and machines:
      + [auto-petter](/Auto-Petter "Auto-Petter") auto-pets animals in a coop or barn (this keeps your animals content, but can't replace the full benefit of human touch);
      + [bone mill](/Bone_Mill "Bone Mill") turns bone items into [fertilizer](/Fertilizer "Fertilizer");
      + [coffee maker](/Coffee_Maker "Coffee Maker") brews a fresh cup every morning;
      + [cookout kit](/Cookout_Kit "Cookout Kit") lets you cook on the go;
      + [dark sign](/Dark_Sign "Dark Sign") displays an item without consuming it;
      + [deconstructor](/Deconstructor "Deconstructor") destroys [crafted items](/Crafting "Crafting"), but salvages their most valuable material;
      + [farm computer](/Farm_Computer "Farm Computer") scans [the farm](/The_Farm "The Farm") and displays useful information;
      + [geode crusher](/Geode_Crusher "Geode Crusher") consumes [coal](/Coal "Coal") to break open [geodes](/Minerals#Geodes "Minerals").
      + [heavy tapper](/Heavy_Tapper "Heavy Tapper") works twice as fast as a normal [tapper](/Tapper "Tapper");
      + [hopper](/Hopper "Hopper") auto-loads items placed inside into the machine in front of it;
      + [Junimo chests](/Junimo_Chest "Junimo Chest") are linked to a global shared stash;
      + [mini-obelisks](/Mini-Obelisk "Mini-Obelisk") let you warp between two obelisks when placed on the farm;
      + [mini-shipping bins](/Mini-Shipping_Bin "Mini-Shipping Bin") is a smaller shipping bin that can be placed outside the farm;
      + [ostrich incubator](/Ostrich_Incubator "Ostrich Incubator") when placed in a [barn](/Barn "Barn"), hatches [ostrich eggs](/Ostrich_Egg "Ostrich Egg") into baby [ostriches](/Ostrich "Ostrich");
      + [solar panel](/Solar_Panel "Solar Panel") slowly generates [battery packs](/Battery_Pack "Battery Pack") when left in the sun;
      + [statue of true perfection](/Statue_Of_True_Perfection "Statue Of True Perfection") produces a [prismatic shard](/Prismatic_Shard "Prismatic Shard") each day;
      + [stone chest](/Stone_Chest "Stone Chest") is a variant of [chest](/Chest "Chest") crafted with stone instead of wood;
      + [telephone](/Telephone "Telephone") calls stores to check hours and inventory, and occasionally receive random phone calls (no effect on gameplay);
      + [warp totem: island](/Warp_Totem:_Island "Warp Totem: Island") warps to the Fern Islands.
    * Added new food items:
      + [bug steak](/Bug_Steak "Bug Steak");
      + [banana pudding](/Banana_Pudding "Banana Pudding");
      + [ginger](/Ginger "Ginger");
      + [ginger ale](/Ginger_Ale "Ginger Ale");
      + [mango sticky rice](/Mango_Sticky_Rice "Mango Sticky Rice");
      + [piña colada](/Pi%C3%B1a_Colada "Piña Colada");
      + [poi](/Poi "Poi");
      + [taro root](/Taro_Root "Taro Root");
      + [tropical curry](/Tropical_Curry "Tropical Curry");
      + [squid ink ravioli](/Squid_Ink_Ravioli "Squid Ink Ravioli") (temporarily prevents [debuffs](/Buffs "Buffs")).
    * Added new fertilizers:
      + [deluxe fertilizer](/Deluxe_Fertilizer "Deluxe Fertilizer") increases chance of higher-quality crops;
      + [deluxe retaining soil](/Deluxe_Retaining_Soil "Deluxe Retaining Soil") always keeps soil watered overnight;
      + [hyper speed-gro](/Hyper_Speed-Gro "Hyper Speed-Gro") increases growth rate by at least 33%.
    * Added new items:
      + [bone fragment](/Bone_Fragment "Bone Fragment");
      + Fossilized Skull, Spine, Tail, Legs, and Ribs and [snake skull](/Snake_Skull "Snake Skull"), [snake vertebrae](/Snake_Vertebrae "Snake Vertebrae");
      + [cinder shard](/Cinder_Shard "Cinder Shard");
      + [dragon tooth](/Dragon_Tooth "Dragon Tooth");
      + [tiger slime egg](/Slime_Egg "Slime Egg");
      + [fairy dust](/Fairy_Dust "Fairy Dust") can used on a machine to have it finish processing;
      + [golden walnut](/Golden_Walnut "Golden Walnut");
      + [magma cap](/Magma_Cap "Magma Cap");
      + [monster musk](/Monster_Musk "Monster Musk") causes more monsters to spawn;
      + [mummified bat](/Mummified_Bat "Mummified Bat") and [mummified frog](/Mummified_Frog "Mummified Frog");
      + [ostrich egg](/Ostrich_Egg "Ostrich Egg");
      + [Qi gem](/Qi_Gem "Qi Gem");
      + [Qi seasoning](/Qi_Seasoning "Qi Seasoning") increases quality of cooked recipes;
      + [radioactive ore](/Radioactive_Ore "Radioactive Ore") and [radioactive bar](/Radioactive_Bar "Radioactive Bar");
      + [taro tuber](/Taro_Tuber "Taro Tuber");
      + [horse flute](/Horse_Flute "Horse Flute") summons your horse when outside;
      + [mushroom tree seed](/Mushroom_Tree_Seed "Mushroom Tree Seed").
    * Added new fishing tackle:
      + [curiosity lure](/Curiosity_Lure "Curiosity Lure") increases the chance to catch rare fish;
      + [quality bobber](/Quality_Bobber "Quality Bobber") increases fish quality;
      + [magic bait](/Magic_Bait "Magic Bait") catches fish from any season/time/weather for a given location.
    * Added new [quest items](/Quests#List_of_Quest_Items "Quests"):
      + Advanced TV Remote
      + Arctic Shard
      + [Ectoplasm](/Ectoplasm "Ectoplasm")
      + Gourmet Tomato Salt
      + [Pierre's Missing Stocklist](/Pierre%27s_Missing_Stocklist "Pierre's Missing Stocklist")
      + Pirate's Locket
      + [Prismatic Jelly](/Prismatic_Jelly "Prismatic Jelly")
      + Stardew Valley Rose
      + War Momento
      + Wriggling Worm
    * Added new rings:
      + [glowstone ring](/Glowstone_Ring "Glowstone Ring") provides both light and increased item collection radius;
      + [hot java ring](/Hot_Java_Ring "Hot Java Ring") increases your chance to find coffee drinks when slaying monsters;
      + [immunity band](/Immunity_Band "Immunity Band") reduces chance of status [debuffs](/Buffs "Buffs") by 40%;
      + [lucky ring](/Lucky_Ring "Lucky Ring") increases luck by +1;
      + [phoenix ring](/Phoenix_Ring "Phoenix Ring") restores some health after being knocked out once per day.
      + [protection ring](/Protection_Ring "Protection Ring") keeps you invincible longer after taking damage;
      + [soul sapper ring](/Soul_Sapper_Ring "Soul Sapper Ring") restores a bit of energy after slaying a monster;
      + [thorns ring](/Thorns_Ring "Thorns Ring") damages enemies when they attack you.
    * Added new [hats](/Hats "Hats"):
      + [???](/%3F%3F%3F_(hat) "??? (hat)");
      + [dark cowboy hat](/Dark_Cowboy_Hat "Dark Cowboy Hat");
      + [deluxe pirate hat](/Deluxe_Pirate_Hat "Deluxe Pirate Hat");
      + [forager's hat](/Forager%27s_Hat "Forager's Hat");
      + [goggles](/Goggles "Goggles");
      + [golden helmet](/Golden_Helmet "Golden Helmet");
      + [Mr. Qi's hat](/Mr._Qi%27s_Hat "Mr. Qi's Hat");
      + [pink bow](/Pink_Bow "Pink Bow");
      + [Qi mask](/Qi_Mask "Qi Mask") (secret);
      + [radioactive goggles](/Radioactive_Goggles "Radioactive Goggles");
      + [star helmet](/Star_Helmet "Star Helmet");
      + [sunglasses](/Sunglasses "Sunglasses");
      + [swashbuckler hat](/Swashbuckler_Hat "Swashbuckler Hat");
      + [tiger hat](/Tiger_Hat "Tiger Hat");
      + [warrior helmet](/Warrior_Helmet "Warrior Helmet").
    * Added new [clothing](/Clothing "Clothing"):
      + banana shirt;
      + ginger overalls;
      + hot pink shirt;
      + island bikini;
      + magenta shirt;
      + tropical sunrise shirt;
      + yellow suit.
    * Added new shoes:
      + [cinderclown shoes](/Cinderclown_Shoes "Cinderclown Shoes");
      + [mermaid boots](/Mermaid_Boots "Mermaid Boots");
      + [dragonscale boots](/Dragonscale_Boots "Dragonscale Boots");
      + [crystal shoes](/Crystal_Shoes "Crystal Shoes").
    * Added new [weapons](/Weapons "Weapons"):
      + [dwarf sword](/Dwarf_Sword "Dwarf Sword"), [dwarf hammer](/Dwarf_Hammer "Dwarf Hammer"), and [dwarf dagger](/Dwarf_Dagger "Dwarf Dagger");
      + [dragontooth cutlass](/Dragontooth_Cutlass "Dragontooth Cutlass"), [dragontooth club](/Dragontooth_Club "Dragontooth Club"), and [dragontooth shiv](/Dragontooth_Shiv "Dragontooth Shiv");
      + [infinity blade](/Infinity_Blade "Infinity Blade"), [infinity dagger](/Infinity_Dagger "Infinity Dagger"), and [infinity gavel](/Infinity_Gavel "Infinity Gavel");
      + [iridium needle](/Iridium_Needle "Iridium Needle");
      + [ossified blade](/Ossified_Blade "Ossified Blade");
      + some previously inaccessible items have also been made accessible.
    * Added new fish:
      + [stingray](/Stingray "Stingray");
      + [lionfish](/Lionfish "Lionfish");
      + [blue discus](/Blue_Discus "Blue Discus");
      + legendary fish:
        - [Glacierfish Jr.](/Glacierfish_Jr. "Glacierfish Jr.");
        - [Legend II](/Legend_II "Legend II");
        - [Ms. Angler](/Ms._Angler "Ms. Angler");
        - [Radioactive Carp](/Radioactive_Carp "Radioactive Carp");
        - [Son of Crimsonfish](/Son_of_Crimsonfish "Son of Crimsonfish").
    * Added new furniture:
      + 35 paintings (many only found in festival shops or while fishing certain locations);
      + 14 bed variants;
      + ten rugs:
        - [blossom rug](/Blossom_Rug "Blossom Rug");
        - [funky rug](/Funky_Rug "Funky Rug");
        - [icy rug](/Icy_Rug "Icy Rug");
        - [large cottage rug](/Large_Cottage_Rug "Large Cottage Rug");
        - [large green rug](/Large_Green_Rug "Large Green Rug");
        - [large red rug](/Large_Red_Rug "Large Red Rug");
        - [light green rug](/Light_Green_Rug "Light Green Rug");
        - [modern rug](/Modern_Rug "Modern Rug");
        - [oceanic rug](/Oceanic_Rug "Oceanic Rug");
        - [old world rug](/Old_World_Rug "Old World Rug");
      + eight 'floor divider' rugs that can be placed between rooms to join visually different floor types;
      + five [fish tanks](/Fish_Tank "Fish Tank") you can put fish in (including an [Easter egg involving hats](/Secrets#Hats "Secrets"));
      + [decorative trash can](/Decorative_Trash_Can "Decorative Trash Can");
      + [gourmand statue](/Gourmand_Statue "Gourmand Statue");
      + [iridium krobus](/Iridium_Krobus "Iridium Krobus");
      + [large brown couch](/Large_Brown_Couch "Large Brown Couch");
      + [plain torch](/Plain_Torch "Plain Torch") and [stump torch](/Stump_Torch "Stump Torch");
      + [squirrel figurine](/Squirrel_Figurine "Squirrel Figurine");
      + [tropical chair](/Tropical_Chair "Tropical Chair").
    * Added a new '[sconce](/Wall_Sconce "Wall Sconce")' furniture type with seven options.
    * Added new flooring:
      + [rustic plank floor](/Rustic_Plank_Floor "Rustic Plank Floor");
      + [stone walkway floor](/Stone_Walkway_Floor "Stone Walkway Floor").
    * Added new [debuffs](/Buffs "Buffs") from enemies:
      + burnt (Speed -2, Defense -3);
      + darkness (dims lighting, making it harder to see in caves);
      + frozen (speed -8);
      + nauseated (prevents you from eating or drinking anything);
      + weakness (-20 Attack).
    * Added 17 new hair styles.
    * Added mail from Krobus with his own stationary.
    * Added new decorations and tweaks to many maps.
    * Added new Easter eggs:
      + [Easter egg when you change your name](/Secrets#Shrine_of_Illusions "Secrets") at [the Shrine of Illusions](/The_Shrine_of_Illusions "The Shrine of Illusions") to include item spawn codes;
      + [title screen 'happy face' secret](/Secrets#Title_Screen "Secrets");
      + [new lucky purple shorts secret](/Secrets#Lucky_Purple_Shorts "Secrets");
      + [new strange capsule secret](/Secrets#Strange_Capsule "Secrets").
    * Emily now visits Sandy on her birthday.
    * Clicking the pigs at the [Festival of Ice](/Festival_of_Ice "Festival of Ice") now plays a pig sound.

Quality of life changes

:   * Added lost & found box in Mayor Lewis' house. This can be used to retrieve items donated to failed special orders, lost quest items and tools, items from offline players, hats from children that have been turned into doves, and items left behind in the Stardew Valley Fair grange display.
    * You can now sit on chairs (both placed furniture and chairs that are part of the map).
    * You can now place most furniture outside.
    * You can now talk to people while mounted on a horse.
    * You can now donate items of different qualities for the same community bundle ingredient.
    * You can no longer plant fruit trees on tiles they won't be able to grow on.
    * Improved game menus and HUD:
      + The social tab now shows whether you talked to an NPC today.
      + The cooking tab now shows the recipe for an item when you hover over it.
      + The cooking tab now fades icons for recipes you know but haven't made yet.
      + The cooking/crafting tooltips now show the number produced.
      + The inventory menu's organize button now combines partial item stacks.
      + The inventory menu for a chest now shows the Community Center button.
      + The shipment screen now shows the unit price of shipped items instead of displaying the shipped quantity twice.
      + The quest log now shows an arrow in the morning when you have pending completed quests.
      + Buff icons now subtly pulse when they're close to expiring.
    * Improved shop menus:
      + You can now press `ESC` or controller `B` to move the held item to your inventory (or drop it if you have no more inventory room).
      + While holding a purchase, the inventory now highlights items you can stack it with.
    * Improved sprinklers:
      + Sprinklers can now water slime hutch troughs.
      + Hoes no longer remove sprinklers.
    * Improved [Journey of the Prairie King](/Journey_of_the_Prairie_King "Journey of the Prairie King"):
      + Progress can now be saved and resumed, so it can be completed in multiple sessions.
      + You now also replay the original difficulty even if you've already completed it. (Previously it would increase difficulty automatically, which is now a New Game+ mode.)
    * Improved game options:
      + added option to choose between multiple fish-bite chime sounds;
      + added option to mute farm animals and pets;
      + you can now scale the UI independently of the view zoom;
      + increased maximum zoom from 120% to 200%.
    * Improved various items:
      + The [jukebox](/The_Stardrop_Saloon#Jukebox "The Stardrop Saloon") now has a "Random" setting.
      + Removing a [crystalarium](/Crystalarium "Crystalarium") that isn't ready for harvest will now drop the gem that was placed in it.
      + You can now push chests containing items by holding the interact button on them with no tool equipped (the same way you could previously remove empty chests without using a tool).
    * Improved inventory sorting:
      + no longer changes tool order;
      + now sorts by quality too;
      + now sorts names in alphabetical instead of reverse alphabetical order.
    * Improved museum donation interactions:
      + Clicking an item now grabs one instead of the whole stack.
      + Pressing back while placing an item now returns to the inventory instead of closing the whole UI.
      + Other minor improvements.
    * Improved HUD:
      + Added a notification when you enter a farm building if an incubator is ready but the building is at max capacity.
      + The "infestation" indicator in the mines is now drawn alongside the floor number, rather than replacing it.

Balance changes

:   * Combat changes:
      + [Immunity](/Immunity "Immunity") now reduces the chance of status [debuffs](/Buffs "Buffs").
      + Changed special move cooldowns on daggers (6→3 seconds) and clubs (4→6 seconds).
      + The dagger special attack now pins the target in place until the last stab (which then knocks them back), so dagger hits are less likely to miss.
      + Reduced desperado profession's damage bonus from 3x to 2x.
      + Slightly improved dagger critical hit chance.
    * Crafting changes:
      + Changed [skull brazier](/Skull_Brazier "Skull Brazier") recipe (was 10 [hardwood](/Hardwood "Hardwood") + [solar essence](/Solar_Essence "Solar Essence") + [coal](/Coal "Coal"); now 10 [bone fragments](/Bone_Fragment "Bone Fragment")).
      + Repairing a fence now restores full fence health, instead of half the health of a new fence.
    * Farming changes:
      + Lowered the cost of ducks (2000→600g).
      + Doubled the value of [duck feathers](/Duck_Feather "Duck Feather").
      + Slightly increased the duck feather spawn rate.
    * Fishing changes:
      + Fishing rod tackle no longer loses endurance when catching junk.
      + Catching a non-fish item no longer triggers the minigame.
      + Reaching an effective fishing level of 15+ now increases the rod casting range by one tile.
    * Mining changes:
      + Gem nodes now provide mining XP and can drop diamonds.
      + Gem node drops are no longer limited by mine level.
    * Item drop changes:
      + Stumps and hollow logs now have a 10% chance of dropping [mahogany seeds](/Mahogany_Seed "Mahogany Seed").
      + Any monster in the [Secret Woods](/Secret_Woods "Secret Woods") now has a 10% chance of dropping mahogany seeds.
      + [Skeletons](/Skeleton "Skeleton") now have 4% chance of dropping a [bone sword](/Bone_Sword "Bone Sword").
      + [Wilderness golems](/Wilderness_Golem "Wilderness Golem") now drop [rice shoots](/Rice_Shoot "Rice Shoot") more often.
      + Some Skull Cavern monsters now have a small chance of dropping [red cabbage seeds](/Red_Cabbage_Seeds "Red Cabbage Seeds").
      + Pure-white [slimes](/Slimes "Slimes") now drop diamonds and refined quartz.
      + Some containers now drop better items after reaching the bottom of the mines at least once.
      + Different drops now unlock on mine levels 60/80/100 and the first level of the Skull Cavern.
      + Reduced chance of [lead rod](/Lead_Rod "Lead Rod") drops on mine levels 60–79 (or Skull Cavern level 40+ before the previous fix), and added chance for [shadow dagger](/Shadow_Dagger "Shadow Dagger") and [wood mallet](/Wood_Mallet "Wood Mallet").
      + Mine wood barrels can now drop [basic retaining soil](/Basic_Retaining_Soil "Basic Retaining Soil") instead of [sap](/Sap "Sap").
      + Mine frost barrels can now drop [quality retaining soil](/Quality_Retaining_Soil "Quality Retaining Soil") instead of [sap](/Sap "Sap").
      + Reduced chance of frost barrels dropping aquamarine, frozen geode, hardwood, jade, or equipment from 35% to 26%.
    * Shop changes:
      + Pierre will now sell his seasonal items year-round once you complete a certain new quest.
      + Added two more items to the [Stardew Valley Fair](/Stardew_Valley_Fair "Stardew Valley Fair") star token shop.
      + [Coconuts](/Coconut "Coconut") can be purchased from [Sandy](/Sandy "Sandy") on Monday. This is now limited to ten per day.
      + The [slingshot](/Slingshot "Slingshot") and [master slingshot](/Master_Slingshot "Master Slingshot") are now sold at the [Adventurer's Guild](/Adventurer%27s_Guild "Adventurer's Guild").
      + Reduced [workbench](/Workbench "Workbench") price (3000→2000g).
      + Reduced [earth obelisk](/Earth_Obelisk "Earth Obelisk") and [water obelisk](/Water_Obelisk "Water Obelisk") prices (1000000→500000g).
    * Machine changes:
      + Some machines' processing time was previously affected by the time of day. These have been standardized so they're always ready when the morning starts: [bee house](/Bee_House "Bee House") (every 4 days), [mushroom box](/The_Cave "The Cave") (every day), [strange capsule](/Random_Events#Strange_Capsule "Random Events") (3 days), Tapper (depends on input), and [worm bin](/Worm_Bin "Worm Bin") (every morning).
    * Doubled star token rewards for the slingshot and fishing minigames at the [Stardew Valley Fair](/Stardew_Valley_Fair "Stardew Valley Fair").
    * Fertilizer in the greenhouse no longer disappears on season change in some cases.
    * The random stone owl and strange capsule night events are now much less rare.

Multiplayer changes

:   * Added local split-screen [multiplayer](/Multiplayer "Multiplayer") mode.
    * The join co-op screen now remembers the last IP you entered.
    * Farmhands can now move buildings through Robin's menu. The host can configure how this works (disabled, enabled, or only for a player's own cabin).
    * Using the [return scepter](/Return_Scepter "Return Scepter") now returns farmhands to their cabin's front door instead of the host's farmhouse.
    * Added various new chat messages when a player does something.
    * When viewing a shared event in multiplayer (such as the [Community Center](/Community_Center "Community Center") event, or [Morris](/Morris "Morris")' introduction), you are no longer forcibly warped to the event location.
    * When the host player sees the year 3 event, Grandpa's Theme is now added to all players' jukeboxes even if they weren't in-game at the time.

Interaction changes

:   * Reworked slingshot controls: it now aims at the cursor position, and is fired by holding and releasing the mouse/gamepad fire button. The previous mode (where you'd hold the button and pull back on the cursor to aim) can be re-enabled in the options menu if desired.
    * To simplify bulk actions like harvesting, holding down a button while moving will no longer repeat weapon special attacks, open/close barn/coop doors, or interact with boulders, chests, furniture, hollow logs, meteorites, shipping bins, or scarecrows.
    * Constructed shipping bins now have a click-to-ship hitbox that better matches the original map-based shipping bin's hitbox.
    * Flooring can now be applied by clicking on the tile the farmer is standing on. Previously, flooring had to be applied to a tile next to the farmer.
    * Purchasing recipes with a full inventory no longer shows a message that the inventory is full.
    * Clicking an empty tile right above an interactive element (like a machine or chest) now activates the element, similar to clicking below it in previous versions.
    * Trees chopped from above or below will now take into consideration the player’s horizontal position when falling to the left or right.
    * Clicking near the bottom-left corner of the screen no longer brings up the chat box.
    * You can no longer open the quest log by pressing the on-screen journal button if you're currently doing something.
    * You can now use the "Y" key to answer dialogue boxes for holes and exit ladders in the mines.
    * Controller improvements:
      + When buying/betting tokens in the Stardew Valley Festival with a controller, holding the number selection button now causes the amount to increase faster.
      + Events can now be skipped on the controller even if a dialogue box is on-screen.
      + Pressing B on a controller while on a specific quest page now returns to the quest list instead of closing the menu.
      + Pressing B on a controller while an item is held on the crafting menu now snaps to the trash can (similar to the inventory screen).

Other changes

:   * Save names are now based on the farm name instead of the player name. (Saves originally created before 1.5 will continue using the player name.)
    * [Penny](/Penny "Penny") and the [Dwarf](/Dwarf "Dwarf") now like artifacts, all other [NPCs](/Villagers "Villagers") dislike (instead of hate) them as gifts.
    * Improved dinosaur sleep sprites.
    * Characters now face you when you talk to them instead of when the dialogue box closes (in singleplayer).
    * On the final day of a tracked quest, the timer now says "final day" instead of "1 day" for clarity.
    * Added many changes for modders; see [completed wishlist items](/User:Pathoschild/Modding_wishlist#Done_in_Stardew_Valley_1.5 "User:Pathoschild/Modding wishlist") and [mod migration guide](/Modding:Migrate_to_Stardew_Valley_1.5 "Modding:Migrate to Stardew Valley 1.5") for details.
    * Cosmetic tweaks to various sprites.

Fixes for multiplayer

:   * Fixed an issue where fences would degrade faster in Multiplayer.
    * Fixed issue where a farmhand crashing while completing the final bundle could permanently prevent the unlock from properly triggering. It is now unlocked the next time a character enters the area.
    * Farmhands are now properly positioned under the elevator instead of the ladder when using it to navigate the mines.
    * Fixed an issue where other farmers’ emotes would not playback properly if you were watching an event.
    * Fixed a minor issue where multiple players getting the free coffee gift at the Night Market at the same time could prevent anyone from receiving it.
    * Fixed the note from Grandpa reappearing for farmhands.
    * Fixed issue where cows in Haley's photoshoot event could be seen sliding around for farmhands. (Non-actor characters in events are now controlled by the host.)

Fixes for player interaction

:   * Fixed rare controller and mouse input drops.
    * Fixed being unable to remount a horse after dismounting it behind a shipping bin.
    * Fixed issue where it would sometimes be impossible to name an animal with a controller because the onscreen keyboard would appear and disappear in the same frame.
    * Fixed character customization screen's hair color slider not properly updating when hair color is randomized.
    * Fixed some farm tiles incorrectly preventing buildings from being placed on them.

Fixes for visual or cosmetic issues

:   * Adjusted the sorting of item ready indicators for tappers.
    * Unified when night tiles get applied to fix inconsistencies when windows change from light to dark.
    * The critters list is now cleared out overnight. This fixes an issue where having a Butterfly Hutch in your house and repeatedly sleeping without leaving would spawn endless butterflies in the house.
    * Improved various text:
      + Fixed some localizations using inches for fish measurements to reference centimeters.
      + Fixed mill description not mentioning rice.
      + Fixed typos in dialogue and events.
      + Fixed missing characters in Chinese and Korean fonts.
      + Fixed credits not showing localizer names correctly if the current language's font doesn't have the needed characters.
      + Improved many translations.
    * Fixed various cosmetic/layering issues with character shadows.
    * Fixed characters in events snapping to strange animation frames when skipping an event.
    * Fixed various instances where the camera would pan unnecessarily after changing locations.
    * Fixed greenhouse trees taking on seasonal appearances.
    * Fixed tooltip for purchasing edible but non-health-restoring items (like [crocus](/Crocus "Crocus")) showing price outside of the tooltip.
    * Fixed a single-frame flicker in Haley’s 10-heart event.
    * Fixed a single frame flicker of the farm when starting a new game.
    * Fixed stamina bar showing sweat particles when fishing during the fishing competition.
    * Fixed the scythe showing the weapon ability cooldown effects.
    * Fixed the erroneous door tile visible on the south end of the standard farm during winter.
    * Fixed issue where unlocking multiple community center bundles at once would make the screen pan to the same room multiple times.
    * Fixed various issues related to the Festival of Ice map, like being able to escape the festival bounds or prematurely end the festival from certain tiles, and minor visual fixes.
    * Fixed terrain features showing an "interact" cursor when mousing over their tiles during festivals.
    * Fixed options page scrollbar sometimes going past the end of the scrollbar region.
    * Fixed various text overflow issues on the options page.
    * Fixed chests spawned on certain [Skull Cavern](/Skull_Cavern "Skull Cavern") floors being shifted down by 4 tiles.
    * Fixed tiling of…
      + floor tiles in the farmhouse so applied flooring in adjacent rooms appear contiguous instead of having hard edges;
      + wall tiles in the farmhouse to fix sorting of certain objects that extend outside normal tile boundaries (*e.g.,* grass starter).
      + the fountain so that it has a more consistent appearance throughout the seasons;
      + Pierre's stand at the Egg Festival to fix layering issues.

Other bug fixes

:   * Fixed crash when resizing game window in some cases.
    * Fixed rare crash on launch due to invalid game window size options.
    * Fixed Iridium Bat kills not counting towards Adventurer's Guild bat eradication goal.
    * Fixed an issue where the Mermaid Show reward was delayed incorrectly.
    * Fixed some events showing a dark blue screen after fading out when viewed during rainy days.
    * Fixed museum-related rarecrows not sold at the Night Market after being unlocked.
    * Fixed issue where non-wooden gates would revert to wooden gates after saving & loading a game.
    * Fixed being able to add staircases to the Luau.
    * Fixed an item duplication exploit related to chest organization.
    * Fixed a minor desync in character pathfinding that could happen when characters pathed to the JojaMart on modded games.
    * Fixed Penny walking through walls on rainy days if you've completed the community upgrade.
    * Fixed Penny's 4-heart event not accessible once you finish the community upgrade.
    * Fixed fences not collected correctly after a divorce or Penny's 14-heart event.
    * Fixed characters greeting you when you enter a location when they're not present.
    * Fixed characters you divorced still greeting you when you enter a location.
    * Fixed issue where an NPC spouse fails to pathfind when a player/NPC is blocking the front door when they check, causing them to stand in place instead.
    * Fixed crops sometimes growing a day slower than they should.
    * Fixed applying flooring for the first time in an upgraded house sometimes causing the flooring in the kitchen to switch to the default wooden flooring.
    * Fixed issue where riding a horse while travelling from one location to another diagonally would repeatedly warp back and forth between the two locations.
    * Fixed watered slime hutch troughs emptied when you load a save. (This mainly affects loading a mid-day save on mobile.)
    * Fixed the community center not properly loading the refurbished map variant on game load. This caused characters like Maru to path incorrectly in them if the player had not visited the Community Center during that playthrough.
    * Fixed the weekly friendship boost for giving an NPC two gifts not applied if you also gave them a third gift for their birthday.
    * Fixed overnight lightning not randomized correctly, so either every overnight lightning would strike or none of them would.
    * Fixed issue where stones, wood, and weeds could spawn on top of terrain features when a new year begins.

Further changes were later released without changing the version number:

21 December 2020 (appended to [1.5.1 post](https://steamcommunity.com/games/413150/announcements/detail/2926742382063004963))
:   * Fixed a crash when interacting with the Junimo notes in the Community center when playing in non-English.

22 December 2020 (appended to [1.5.1 post](https://steamcommunity.com/games/413150/announcements/detail/2926742382063004963))
:   * Fixed malformed item data causing the game to crash when playing in Turkish.

23 December 2020 (appended to [1.5.1 post](https://steamcommunity.com/games/413150/announcements/detail/2926742382063004963))
:   * Players can now choose another player's character in local multiplayer. This allows players continuing multiplayer farms in local multiplayer to resume their old farmers.
    * Fixed shared events in multiplayer potentially putting players out of bounds.
    * Fixed the am/pm display not displayed properly in non-English languages.
    * Various localization fixes and changes.

## 1.4.5

Stardew Valley 1.4.5 was [released](https://www.stardewvalley.net/new-update-for-android-and-hotfix-patch-for-pc/) on 11 February 2020.

Bug fixes

:   * Fixed an issue on Windows where the game would initialize incorrectly and start without audio.
    * Fixed an issue where passable objects, such as torches, could block you from attacking enemies that are standing nearby.
    * You can now reclaim the ancient seed crafting recipe from Gunther if you donated an Ancient Seed artifact and collected only the seed and not the recipe.
    * Fixed an issue that would allow animals to walk on certain water tiles alongside some bridges.
    * Wallpapers can no longer be used in place of items to be processed into artisan goods.
    * Fixed the Lewis statue letter not granting its reward in the Simplified Chinese localization.

## 1.4.4

Stardew Valley 1.4.4 was [released](https://www.stardewvalley.net/patch-1-4-4-available-now-for-pc-consoles/) on 31 January 2020.

Changes

:   * Adjusted dropped item pickups so that they're more responsive for clients in multiplayer and will "rubber band back" to their previous locations less frequently.
    * Adjusted item collection code so that machines tucked in corners can be refilled without using cursor mode.
    * Fixed Elliott's 14-heart not properly working in non-English languages.
    * Fixed a data entry issue that caused some fish ponds to use incorrect data.
    * Fixed the Shrimp Enthusiast Shirt applying the wrong shirt artwork.
    * Fixed a soft-lock when watching the 2nd Fall movie in a non-English languages.
    * Fixed the cursor not appearing in the level up profession selector if the Controller Style Menus option is toggled off while using a controller.
    * Unsuccessfully crafting an unstackable item while already holding an item on your cursor no longer grants you credit for crafting it.
    * Fixed an issue where garden pots would consume seeds without planting them if they were planted from more than a tile away.
    * Fixed the color selector sliders on the farmhand creation screen having incorrect navigation on controller.
    * Fixed the logic for fruit tree obstruction checking the wrong tile.
    * Fixed the dagger swipe sound effect repeating an extra time in multiplayer if another player is in the same area.
    * [Krobus](/Krobus "Krobus") will no longer get jealous if you gift characters you're dating after he moves in.
    * [Penny](/Penny "Penny") now leaves [garden pots](/Garden_Pot "Garden Pot") alone in her 14 heart event.
    * Fixed an issue that could cause [Sam](/Sam "Sam")'s 6 heart event to soft-lock.
    * The game now re-issues the player the Qi's Challenge quest if they had previously opened the mail, but dismissed it without accepting the quest.
    * Items placed in an ex's room are now collected and placed in a chest after divorce.
    * You can no longer give away quest items or non-giftable items during the [Feast of the Winter Star](/Feast_of_the_Winter_Star "Feast of the Winter Star").
    * Adjusted some NPC gift reactions ([Vincent](/Vincent "Vincent") and [Jas](/Jas "Jas") now hate [triple shot espresso](/Triple_Shot_Espresso "Triple Shot Espresso"), the [Dwarf](/Dwarf "Dwarf") now loves [lemon stone](/Lemon_Stone "Lemon Stone"), and Sam now likes concession stand Joja Cola).
    * Adjusted [Desert](/The_Desert "The Desert") map so that [crab pots](/Crab_Pot "Crab Pot") placed in the water no longer render incorrectly, and objects can no longer be placed on top of the [Desert Trader](/Desert_Trader "Desert Trader").
    * Removed [catfish](/Catfish "Catfish") from [Willy](/Willy "Willy")'s fishing quests during [Winter](/Winter "Winter"), as it's impossible to catch one without a [rain totem](/Rain_Totem "Rain Totem").
    * Fixed a crash that could occur on the host when a client connects to a game that was set to Friends or Invite Only that is now being hosted on a platform that doesn't support those online modes.
    * Fixed incorrectly looping ambient noise in the [Deep Woods](/Secret_Woods "Secret Woods") at night.
    * Fixed an issue where the Japanese localization's dialogue for a spouse watering your crops would incorrectly show both gender variants of the text.
    * Fixed the Simplified Chinese localization incorrectly showing [sunflower seeds](/Sunflower_Seeds "Sunflower Seeds") as a Fall only crop.
    * Removed the ‘<‘ from the Simplified Chinese localization of the "Pet loves you" dialogue.
    * Fixed an issue where Junimos would show an empty text bubble when bringing a bundle to the [Junimo hut](/Junimo_Hut "Junimo Hut") after completing a bundle in Simplified Chinese or Korean.
    * Fixed an issue where viewing the Junimo note before learning to read it would cause certain text to permanently display much larger in the Simplified Chinese, Japanese, and Korean localizations.
    * Filled in some missing characters in the Korean fonts. This fixes some instances where an asterisk appears instead of a Korean character.
    * Fixed a minor typo in [Grandpa](/Grandpa "Grandpa")'s note in the Korean localization.

## 1.4.3

Stardew Valley 1.4.3 was [released](https://www.stardewvalley.net/1-4-3-bug-fix-patch-for-pc/) on 13 December 2019.

Bug fixes

:   * Fixed an issue where you could collect multiples of a [bundles](/Bundles "Bundles") reward in the [Community Center](/Community_Center "Community Center") if you closed the menu without collecting them.
    * Fixed an issue where naming your [pet](/Animals#Cat_or_Dog "Animals") the name of an NPC could have your pet appear on the calendar on that NPC’s birthday.
    * Fixed an item duplication exploit when using the add to existing stacks button on an inventory with a full stack.
    * Made some fixes to the Turkish localization.
    * Fixed a bug in the crafting menu that could cause extra resources to be consumed in certain situations.
    * Adjusted the Four Corners farm map to fix layering issue with buildings.
    * Fixed a bug where you could enter the [Wizard's Tower](/Wizard%27s_Tower "Wizard's Tower") before unlocking the Community Center.
    * Taking a map screenshot while the option to show menu backgrounds is on will no longer render the menu in the screenshot.
    * Fixed an issue causing certain [wallpapers](/Wallpaper "Wallpaper") to grant a Lost Book when selected in the [catalogue](/Catalogue "Catalogue").
    * Fixed an issue where you could get your grange score immediately after asking Lewis to judge your grange during the [Stardew Valley Fair](/Stardew_Valley_Fair "Stardew Valley Fair").

## 1.4.2

Stardew Valley 1.4.2 was [released](https://www.stardewvalley.net/1-4-2-bug-fix-patch-on-pc/) on 4 December 2019.

Changes

:   * Reverted placement rules introduced in 1.4.1 which prevented players from placing [flooring](/Flooring "Flooring") or [torches](/Torch "Torch") on their spouse's porch tiles. Instead, spouses now ignore flooring and will "pop off" any torches that are placed on those tiles when they move there in the morning.

Bug fixes

:   * Fixed the crane game crashing when it loads on Mac.
    * Fixed [workbenches](/Workbench "Workbench") not pulling items from [chests](/Chest "Chest") that are on rugs.
    * Fixed [Robin](/Robin "Robin") staying in bed if she was upgrading certain buildings on game load.
    * Fixed a bug where buying a [magic rock candy](/Magic_Rock_Candy "Magic Rock Candy"), exiting to title, and then reloading the game would cause the candy to not re-appear in the shop.
    * Fixed a crash when mashing the dialogue advance buttons while transitioning between maps during an event.
    * Fixed another way the club smash could cause the player to get "stuck" holding out a weapon.
    * Fixed some issues where non-user-initiated mouse movements could cause changes in mouse button states to not register.
    * Fixed a potential soft-lock if you passed out on another player's bed.
    * Fixed the screen being partially faded out when [Demetrius](/Demetrius "Demetrius") comes to ask about the farm cave.
    * Fixed an issue where characters would greet you via speech bubble even if they weren't in the same location (*e.g.,* Elliot welcoming you into his shack even though he's standing at the beach).
    * Fixed being able to perform certain actions (like using a return scepter) during overnight farm events.
    * Fixed farmers who are knocked out while holding an item not properly showing the knocked-out animation.
    * Fixed an issue where the tool being upgraded at [Clint](/Clint "Clint")'s could be set to an invalid value, causing [Lewis](/Lewis "Lewis") to incorrectly send you a set of tools every night.
    * Clicking the emoji menu toggle button on gamepad no longer shows the onscreen keyboard.
    * Adjusted rumble on third-party controllers. This may not fully solve issues on certain third-party controllers, but will at least prevent states where the rumble is stuck on.

## 1.4.1

Stardew Valley 1.4.1 (previously known as 1.4.0.1, but renamed for compatibility with SMAPI) was [released](https://www.stardewvalley.net/1-4-bugfix-patch/) on 2 December 2019.

New features

:   * Added Gamepad Mode to the options menu. This has three values: "auto" (default) switches between keyboard/mouse depending on the last input; "force on" forces the game to use gamepad logic, similar to earlier versions of Stardew Valley; and "force off" disables the gamepad and can be used if you only play the game using keyboard/mouse.
    * You can now buy the [museum](/Museum "Museum") [rarecrows](/Scarecrow#Rarecrows "Scarecrow") from the [Night Market](/Night_Market "Night Market") after you've unlocked them.
    * Some non-spouse NPC's now have custom movie ticket acceptance dialogue (in English only).

Balance changes

:   * [Explosive ammo](/Explosive_Ammo "Explosive Ammo") now costs 300g each in the [Adventurer's Guild](/Adventurer%27s_Guild "Adventurer's Guild"), won't appear until you've unlocked the crafting recipe, and now only explodes with a 2-tile radius instead of 3.
    * You can now only buy one piece of [magic rock candy](/Magic_Rock_Candy "Magic Rock Candy") per Thursday at the [Desert Trader](/Desert_Trader "Desert Trader").
    * [Iridium ore](/Iridium_Ore "Iridium Ore") abundance now increases much more slowly beyond level 100 of the [Skull Cavern](/Skull_Cavern "Skull Cavern").
    * Weapon cooldowns now only happen if game time should pass.

Other changes

:   * You can now buy recipes with a full inventory.
    * [Penny](/Penny "Penny")'s 14-heart event no longer removes placed dressers. Furniture that was supposed to be placed in an occupied tile is now added to the same chests Penny puts your objects in.
    * [Vincent](/Vincent "Vincent") now loves [snails](/Snail "Snail").
    * Adjusted shorts easter egg to give precedence to any normal interactions with the NPCs it affects (gifting, completing a quest, etc).
    * Slightly optimized debris code.

Bug fixes

:   * Fixed farmhands' separate wallets resetting to 500g if the host was playing on Linux or Mac.
    * Fixed the incorrect ordering of NPC gift tastes, so tastes should now match 1.3.
    * Fixed trash bear appearing on festival days (which could cause a potential crash).
    * Fixed an issue where reclaiming the [insect head](/Insect_Head "Insect Head"), [Neptune's glaive](/Neptune%27s_Glaive "Neptune's Glaive"), [forest sword](/Forest_Sword "Forest Sword"), or [carving knife](/Carving_Knife "Carving Knife") from [Marlon](/Marlon "Marlon") would cause [Clint](/Clint "Clint") to appear to be upgrading that weapon, losing any tool already being upgraded.
    * Fixed problem harvesting crops with the [golden scythe](/Golden_Scythe "Golden Scythe").
    * Fixed being able to warp into the sewer on your [horse](/Animals#Horse "Animals"), causing you to warp into the void.
    * Fixed an issue allowing [torches](/Torch "Torch") and [flooring](/Flooring "Flooring") to be placed on the spouses's porch position, so they couldn't come outside.
    * Fixed the [golden scythe](/Golden_Scythe "Golden Scythe") still appearing on the reaper after you've already received it.
    * Fixed a minor issue where players who have connected to a game and are creating a character while an [achievement](/Achievements "Achievements") triggers would send a message saying "- has earned the '(Achievement Name)' achievement."
    * Fixed a hole in the refurbished saloon room, which let players walk out of the map boundaries.
    * Fixed an issue where a farmhand entering a freshly built [cabin](/Cabin "Cabin") could cause the farmhand that owns it to spawn in the upper-left corner of the main farmer's farmhouse.
    * Fixed [fish pond](/Fish_Pond "Fish Pond") silhouettes being incorrect after clearing the pond in multiplayer.
    * Fixed a typo causing plant [seeds](/Crops "Crops") being removed from the inventory when unsuccessfully attempting to plant them outside of the farm.
    * Fixed pre-1.4 untyped "[Honey](/Honey "Honey")" items that were misnamed "Wild Honey"; they're now just converted to "Wild Honey" that stacks with other "Wild Honey" items.
    * Fixed a crash when [tree fertilizer](/Tree_Fertilizer "Tree Fertilizer") recipe is added to a save that already has it.
    * Fixed the dove subplot enemy leaving visual trails on the host's machine regardless of the location they were in.
    * Fixed non-synchronization of items recovered from [Marlon](/Marlon "Marlon") at the [Adventurer's Guild](/Adventurer%27s_Guild "Adventurer's Guild").
    * Fixed the display name of [flounder](/Flounder "Flounder") in Russian being the same as [halibut](/Halibut "Halibut").
    * Fixed a botched after-movie dialogue from [Evelyn](/Evelyn "Evelyn").
    * Fixed the direction of the fold on the Gi clothing items.
    * Fixed [tea saplings](/Tea_Sapling "Tea Sapling") not being placeable on certain tiles on the farm.
    * Fixed a crash when checking the calendar while engaged to another farmer that is currently disconnected from the game.
    * Fixed problem where you could soft-lock a shop menu in an edge case scenario.
    * Controller fixes:
      + Fixed some inconsistencies with cursor placement when item stowing is on.
      + Fixed an issue where using the trigger buttons to swap pages in the Junimo Bundle menu while holding an item would cause it to be lost.
      + Fixed an issue in the quest log where if you moved the cursor right from the "back" button when viewing a quest description on the second or higher page of the quest log, the cursor would move to an invalid position.
      + Highlighting a dropdown menu option in the options screen on the controller now snaps to the drop down button, no longer obscuring the text.
      + When a dialogue question is asked, the first selectable option is now selected by default in controller mode, regardless of whether the controller-style menus option is enabled.
    * Corrected the fix for the [Stardew Valley Fair](/Stardew_Valley_Fair "Stardew Valley Fair") festival's petting zoo area appearing incorrectly if certain post-game conditions had been unlocked.
    * Added a graceful fail state to the function that gets a [wedding](/Marriage#The_Wedding "Marriage") for the day in case there's a completely invalid farmer ID in the farmers list (potentially from a removed cabin).
    * Players that could have missed increases to their max health, crafting recipes due to skipping combat skill levels will now earn them on level load.
    * Pending level-ups are now removed from characters as they are applied, instead of all at once at the end of the night. That ensures that a character who gets disconnected/crashes during a level-up can now reapply their level-ups the next time they are connected.
    * Adjusted the requirements to be able to respec a skill at the [Statue of Uncertainty](/The_Sewers#Statue_Of_Uncertainty "The Sewers") to allow users who have "missed levels" to reclaim their missed perks levels using it.
    * Potential fix for switching over to the [scythe](/Scythe "Scythe") after using the club slam repeat quirk causing the next used tool to soft-lock the player in place.
    * Fixed various typos.
    * Fixed crash if a location no longer exists in the game, for players with residual mod data in their save file.
    * Fixed the `/friendAll` debug command granting friendships to NPCs that aren't friendable, which could possibly cause issues on any game mechanics that randomly select a friend (*e.g.,* daily quests).

## 1.4

Stardew Valley 1.4.0 was [released](https://www.stardewvalley.net/the-stardew-valley-1-4-content-update-is-now-available-on-steam-gog/) on 26 November 2019.

New content and features

:   * Added [movie theater](/Movie_Theater "Movie Theater") unlocked in late game, with related content and features.
    * Added 14-heart events for every spouse.
    * Added new events and dialogue (including a new heart event for Caroline).
    * Added [clothing](/Clothing "Clothing") items equipped on the player (replaces former clothing appearance options).
    * Added clothes [tailoring](/Tailoring "Tailoring") and dyeing.
    * Added 24 new hair styles, including bald heads.
    * Added Four Corners [farm map](/Farm_Maps "Farm Maps") (meant for co-op, divides the land into four areas with their own perks).
    * Added [fish ponds](/Fish_Pond "Fish Pond") to breed fish and produce items.
    * Added new items:
      + 181 shirts;
      + 35 hats;
      + 14 pants (including dresses, skirts, and shorts);
      + 2 boots;
      + 38 decorative items obtained in various ways (*e.g.,* new events);
      + 17 new flooring options;
      + 2 new [secret notes](/Secret_Notes "Secret Notes");
      + two fish: [flounder](/Flounder "Flounder") and [midnight carp](/Midnight_Carp "Midnight Carp");
      + two rings: [crabshell ring](/Crabshell_Ring "Crabshell Ring") and [napalm ring](/Napalm_Ring "Napalm Ring");
      + [artifact troves](/Artifact_Trove "Artifact Trove") (can be broken open by Clint to yield artifacts);
      + [caviar](/Caviar "Caviar"), [roe](/Roe "Roe"), and aged roe;
      + [dark sword](/Dark_Sword "Dark Sword");
      + [deluxe scarecrow](/Deluxe_Scarecrow "Deluxe Scarecrow") (recipe given when you collect all [rarecrows](/Scarecrow#Rarecrows "Scarecrow"), has double the radius);
      + [dinosaur mayonnaise](/Dinosaur_Mayonnaise "Dinosaur Mayonnaise") (processed from [dinosaur eggs](/Dinosaur_Egg "Dinosaur Egg"));
      + [golden scythe](/Golden_Scythe "Golden Scythe");
      + [grass starter](/Grass_Starter "Grass Starter") recipe (purchased from Pierre);
      + [magic rock candy](/Magic_Rock_Candy "Magic Rock Candy");
      + [mini-jukebox](/Mini-Jukebox "Mini-Jukebox") (place anywhere on the farm or in farm buildings to play previously-heard music);
      + [mini-fridges](/Mini-Fridge "Mini-Fridge") (place inside to extend your fridge capacity);
      + [rice crop](/Unmilled_Rice "Unmilled Rice");
      + [seafoam pudding](/Seafoam_Pudding "Seafoam Pudding") (fishing level 9 cooking recipe);
      + [shrimp cocktail](/Shrimp_Cocktail "Shrimp Cocktail") (recipe learned from the Queen of Sauce episode on Winter 28 Y2);
      + [squid ink](/Squid_Ink "Squid Ink");
      + sunflower [honey](/Honey "Honey") (produced by beehouses);
      + [tea bushes](/Tea_Sapling "Tea Sapling"), [tea leaves](/Tea_Leaves "Tea Leaves") and [green tea](/Green_Tea "Green Tea");
      + [training rod](/Training_Rod "Training Rod") (easier fishing but only catches common fish);
      + [tree fertilizer](/Tree_Fertilizer "Tree Fertilizer") (non-fruit trees grow more quickly);
      + [triple shot espresso](/Triple_Shot_Espresso "Triple Shot Espresso");
      + [void ghost pendant](/Void_Ghost_Pendant "Void Ghost Pendant");
      + [warp totem: desert](/Warp_Totem:_Desert "Warp Totem: Desert");
      + [wilted bouquet](/Wilted_Bouquet "Wilted Bouquet") (crafted from a [bouquet](/Bouquet "Bouquet")), which lets you break up with NPCs you're dating;
      + [workbench](/Workbench "Workbench") (lets you craft with ingredients in adjacent chests);
      + [wood chipper](/Wood_Chipper "Wood Chipper") (breaks hardwood and driftwood into wood).
    * Added new mine content:
      + a quarry mineshaft dungeon with new [haunted skull](/Haunted_Skull "Haunted Skull") and [sludge](/Slimes "Slimes") monsters, and a Golden Scythe;
      + prehistoric floors in the Skull Cavern with a new [pepper rex](/Pepper_Rex "Pepper Rex") monster;
      + rare alternative floors in the 1-120 mines after unlocking the quarry similar to the quarry mineshaft dungeon.
    * Added shed upgrade (doubles the interior size).
    * Added cat/dog breeds selectable from the new-character customisation menu or [the Shrine of Illusions](/The_Shrine_of_Illusions "The Shrine of Illusions").
    * Added Krobus as a potential roommate if you're unmarried.
    * Added a [desert trader](/Desert_Trader "Desert Trader") that sells new items.
    * Added Trash Bear to clean up trash around town in year 3+.
    * Added 4 new monster eradication goals & prizes.
    * Added 4 new museum reward levels (for donating 35, 70, 80, and 90 items).
    * Added [trash can](/Trash_Cans "Trash Cans") upgrades purchasable from Clint (gives 15-60% of trashed items' value as money).
    * Added a new sunroom in Pierre and Caroline's house.
    * Added the ability to perform various emotes through a new menu (default key is `Y`).
    * Added a new farm building: [desert obelisk](/Desert_Obelisk "Desert Obelisk").
    * Added winter flooring sprites.
    * Added hidden subplot if you've turned children into doves. (Spoilers: check the television on Fall 26, then visit the Witch's Hut for a recurring effect and fish on the Four Corners farm for a one-time effect.)
    * Added experimental support for letting farmhands move buildings. Use the `/movebuildingpermission` command to toggle between `on` (farmhands can move any building), `owned` (they can move their own cabins or buildings they've built themselves), or `off` (default).
    * Added a new trash bin in front of JojaMart.
    * Added map export feature (except on 32-bit Linux), accessed via a button in the options menu or the `/mapscreenshot` chat command. Screenshots are saved in the appdata folder on Windows, and ~/.local/share/StardewValley/Screenshots/ on Linux; click a button in the options screen to open it. When using the command, you can optionally specify a filename and percentage size like `/mapscreenshot test 25`.
    * Added VSync option. Disabling VSync may improve overall framerate at the expense of frame rate stability.
    * Added an NPC gift log accessed through the social tab (tracks birthdays, their liked/disliked gifts as you discover them in-game, etc).
    * Added 'advanced crafting info' option which shows more info on the crafting menu (including number of times crafted and the number of each ingredient available).
    * Added OST files for new music tracks.
    * Added new easter egg on the title screen.
    * [Junimo Kart](/Junimo_Kart "Junimo Kart") has been completely redone and is now actually fun.
    * Dressers can now be used to store clothing, hats, shoes, and rings.
    * When you catch a silver or gold-quality fish, a 'perfect' catch now increases the quality by one. (This is the only way to get iridium-quality fish.)
    * You can now put hats on your children (once they can walk).
    * You can now play Elliott's piano.
    * You can now put gemstones in Junimo huts to affect the color of new Junimos.
    * Divorced spouses no longer attend your wedding.
    * Divorced spouses no longer treat their exes normally during Festivals.
    * Auto-Grabbers now work in the coop too.
    * Successfully parrying a slime attack now prevents the slimed debuff.
    * Seaweed can now be foraged along the bottom shore of the tidal pool beach.
    * The adventurer's guild now sells any boots you already found in mine chests.
    * You can no longer load saves created in a newer version of the game than you have. (This will only affect future versions of the game.)

Multiplayer changes

:   * Added optional separate money in multiplayer.
    * Added support for private chat messages.
    * Added more multiplayer "server messages".
    * Added a `/ping` chat command which prints the current ping to the host (for farmhands) or to each farmhand (for the host).
    * Added a `/kick <farmer name>` chat command.
    * Added `/ban` and `/unban` chat commands. Bans are per-farm, and the command can be called with a farmer name, user ID, or IP address. in all cases it will ban the user, not the farmhand character.
    * Added multiplayer synchronization for…
      + daily luck;
      + bulletin board quests (in most cases);
      + trains;
      + lightning bolts;
      + mine fog events;
      + lost book collection;
      + merchants' limited stock;
      + drum/flute blocks;
      + adjustments to the fishing bobber's position while it's midair;
      + the animation when a player has a fish on the line.
    * When creating a new multiplayer form, the Starting Cabins option now defaults to 1 instead of None.
    * Each player now has a separate mailbox and spouse porch area.
    * Each player can now build a separate cellar.
    * When a player drops an item in multiplayer, other nearby players now have priority for picking it up.
    * You can now see other players' scores during certain festivals in Multiplayer.
    * Quests in multiplayer now set difficulty based on the highest-level player.
    * In the Skull Cavern, mine shafts now drop players to the same level in multiplayer.
    * In multiplayer, many random checks now use the team's average luck instead of only the host's luck.
    * If connecting to a multiplayer server fails, the game will now retry internally before giving up.
    * The reward for completing the Bulletin Board bundle is now applied to all players in multiplayer.
    * Moving a Shipping Bin no longer leaves behind its lid for other players on a multiplayer farm.

Quality of life changes

:   * Added ability to rearrange the museum artifacts (without donating a new one).
    * Added ability to reread received letters anytime via the collections tab.
    * Added ability to rotate the toolbar (using Tab and Ctrl+Tab by default).
    * Added ability to fill existing stacks in a chest from your inventory.
    * Added notification when a tool being upgraded is ready.
    * Added tabs to the Catalogue and Furniture Catalogue.
    * Added current Qi coin balance to [Calico Jack](/CalicoJack "CalicoJack") minigame UI.
    * Added support on Linux for pasting invite codes via an onscreen button (requires xclip).
    * Added upcoming weddings to in-game calendar.
    * All events should now be skippable.
    * Gates can now be attached to one piece of fencing (instead of needing fences on both sides), which allows for double-width gates.
    * The hallway to the spouse's room in a two-story farmhouse now matches the bedroom flooring.
    * Changed interaction cursor when pointing at farm animals you haven't pet today.
    * Giving datable NPCs a gift no longer makes your spouse jealous unless you're currently dating them.
    * You can now construct/move farm buildings onto tilled dirt and tree seeds.
    * Trying to construct/move farm buildings onto an animal now poke them out of the way.
    * Collapsing in the mines no longer makes you forget levels.
    * After collapsing in the mines and losing items, a list of lost items is now shown and you can pay Marlon to recover one of them.
    * You can now remove horse hats (by interacting with the horse while holding another hat).
    * You can now trash copper pans and slingshots.
    * You can now buy copper pans from Willy's shop after receiving the first one.
    * You can now stack craftable items in inventories (like kegs or furnaces).
    * You can now attach baits, tackles, etc. to your fishing rods directly from a treasure chest.
    * You can now shift-click items to move them out of the toolbar.
    * You can now hold down the interact button without retriggering the eat item prompt. That lets players quickly refill rows of kegs/preserves jars without being interrupted by the prompt.
    * You can now go to sleep while holding an item.
    * You can now pause Junimo Kart by pressing `Enter` or `P`.
    * You can now play Junimo Kart entirely with the keyboard.
    * You can no longer place iridium-quality items in casks.
    * Made it easier to collect milk/wool from farm animals. Animals now have a larger hitbox, and using shears/pail while facing multiple animals now finds the best match instead of the first one.
    * Interacting with a Mill that only has one type of item in it now automatically collects the item instead of opening a chest menu.
    * Pointing at an inventory item needed for a bundle now makes the Junimo bundle button pulsate.
    * Pointing at an item to sell in the shop menus now shows the "Gunther can tell you more" text if the item hasn't been donated yet.
    * Mushroom tree sprouts are now distinguishable from other trees.
    * Wild Bait now provides a chance to catch two fish at once.
    * Pets no longer spawn in positions that block the farmhouse door or corridors.
    * When exiting a Junimo bundle menu, the cursor highlights the bundle that was exited.
    * Farm animals standing on crops no longer prevent the crop from being harvested.
    * A message now appears when fruit tree growth is prevented by a surrounding obstruction.
    * When an NPC walks over a chest, it will now dump its contents out instead of destroying them.
    * When viewing a bundle, inventory items for completed slots are now grayed out.
    * Jumping down a mineshaft just above level 100 will no longer drop you below level 100 in the Skull Cavern.
    * Players can now "push" through NPCs at festivals, to avoid getting trapped in some cases.
    * Queen of Sauce reruns will now choose an already-aired recipe that a player doesn't know.
    * The animation played when finding a new lost book is now only played once per player.
    * Unclaimed bundle rewards can now be picked up from a Junimo bag in the Community Center.
    * Wild tree seeds can now be placed in any diggable tile outside of the farm without needing to hoe it first.
    * When you dismiss the map by clicking on it, you're now returned to the previous menu tab (if any).
    * Wilted trellis crops no longer block movement.
    * The Hat Mouse now sells hats you've won in festival competitions.
    * Moving the cursor over a crab pot while holding the action button no longer picks it up.
    * Moving the cursor over a farm animal while holding the action button no longer opens the inspection menu (so it's easier to pet animals).
    * Moving the cursor over a scarecrow while holding the action button no longer checks it (so it's easier to harvest large fields).
    * Improved the 'Organize Inventory' logic. Now properly handles empty spaces on Linux, and sorts stacks from highest to lowest quantity.
    * Changed processing time of tapped mushroom trees so that they're harvestable in the morning (instead of midway through the day).
    * Obelisks now have a 3x2 footprint instead of 3x3. (Their sprites are unaffected.)
    * Dropping an item when collecting rewards from Gunther now throws the item downwards instead of upwards, to prevent players without magnet rings from dropping items into out-of-reach positions.

Balance changes

:   * Fruit trees no longer need the surrounding tiles to be empty to increase in quality once fully grown.
    * Fruit trees are no longer blocked from growing by non-colliding objects (notably artifact spots).
    * Mushroom trees no longer drop wood (and debris chunks are now white instead of brown).
    * You can now increase friendship by talking with NPCs at festivals.
    * Trains now drop more items.
    * Some items no longer appear in random shop stocks: void eggs, void mayonnaise, and sweet gem berries.
    * The quarry now spawns oak & maple trees.
    * Charcoal kilns now require 2 copper bars (instead of a gold bar).
    * Cheese now sells for more.
    * Cloth now drops more often from mummies.
    * Dressers now cost more.
    * Looms can now produce multiple cloths when higher-quality items are input.
    * Pancakes can no longer be bought from Krobus before winter Y1.
    * Sturdy ring is now easier to craft.
    * Journey of the Prairie King has been rebalanced.
    * Calico Jack and slot machines in the casino now statistically favor the player. (Previously the player was more likely to lose.)
    * The Forester profession now causes 25% more wood to drop from trees/stumps/logs, instead of raising the value of wood by 50%.
    * Speed-gro and retaining soil can now be applied to crops anytime.
    * Basic and quality fertilizers can be applied to seeds (but can't be applied once a seed has sprouted).
    * Rebalanced the frequency that secret notes are dropped.
    * Fishing tackle now sells for less once damaged, depending on its remaining durability.
    * Sweet gem berry can no longer be bought from the traveling cart (you can only buy the seeds).
    * Bean hotpot now grants max energy +30 and magnetism +32, instead of showing "max energy +2" but granting nothing.
    * Spring onions quality is now determined at the start of the day.
    * The Legend can now only be caught once.
    * Made bottom edge of fishing bobber bar slightly more generous.
    * The effect of fishing level on fish size no longer caps at 10.
    * Debris now respawns at the start of spring in Cindersap Forest, Town, and the Railroad.
    * Reduced cases of items splashing into water when they're visually on dry land.
    * Lightning rods are now always harvestable immediately the day after being struck.
    * Wheat now has a 40% chance to also drop hay on harvest.
    * Wild bait can now be obtained from fishing treasure chests if you know the crafting recipe.
    * Fixed the burglar's ring not affecting some monster loot items (those added programmatically).
    * Reduced recipe prices in the Stardrop Saloon.

Improved controller support

:   * Added an on-screen keyboard to type into chat or text fields using the controller.
    * Added ability to stow an item when playing with the controller, freeing up your hands to interact with NPCs without accidentally gifting them items.
    * Added a left/right bumper hotkey in inventory menus. when the new 'add to existing stacks' button is available, pressing the hotkey will automatically snap to that button for easier inventory consolidation.
    * You can now highlight the list of required items in the Junimo bundle screen while using a controller, so you can see a tooltip with the item's description.
    * Improved controller navigation/use in…
      + the museum donation screen;
      + the Load Game and Join/Host Coop Game menus;
      + the bundle screen (no longer need to scroll all the way to the right to access the second row);
      + chest and item grab screens;
      + crafting menu.
    * Improved switching between keyboard/mouse and controller mode. For example, having a controller plugged in no longer snaps mouse input to buttons.
    * Improved placement logic with a controller (planting seeds, placing furniture, etc).
    * You can now direct your fishing casts with a controller.
    * The buffs display tooltip is now hidden if the mouse cursor isn't visible.
    * Fixed cursor snapping to upper-left item when clicking the organize items buttons on the controller.
    * Fixed D-Pad not correctly selecting dialogue options.
    * Fixed an issue making the animal pregnancy disable option unselectable with a controller.
    * Fixed navigation of the languages menu using a controller.
    * Fixed an issue where rearranging artifacts in the museum didn't work with controller-style menus.
    * Fixed various issues related to selecting dialogue choices with a controller.
    * Fixed being able to move the cursor on the shipment screen after the screen is dismissed with the OK button on a controller.
    * Fixed cursor slightly misaligned on the skills screen when you first enter it using a controller.
    * Fixed various issues related to the display of the cursor in the level up screens with a controller.
    * Fixed some issues with controller navigation of the items in the wallet section of the skills tab.
    * Fixed controller navigation of dropdown lists in the options screen.
    * Fixed an issue where the controller's left thumbstick was moving the mouse cursor around while playing minigames.
    * Fixed an issue where using the face buttons to aim shots in Journey of the Prairie King on the controller would sometimes cause the shots to go in the wrong direction and cause the player to get stuck shooting.
    * Fixed chest color picker buttons being selectable if the color picker isn't shown.

Other changes

:   * Various copyediting, improved text, tweaked sprites, and tweaked map tiles.
    * Made some optimizations that may improve performance on some machines/platforms or in some cases.
    * Improved many translations and fixed missing font characters in Korean.
    * Changed midnight from 12:00 to 0:00 in Japanese.
    * Added an open sprite to the fridge.
    * Adjusted the mail received after collapsing to more accurately reflect timeline changes in the game.
    * Adjusted a dialogue option in Penny's 2-heart event to be more considerate of George's perspective.
    * Removed the Junimo Note/Community Center Button from non-inventory screens.
    * Improved Elliott's cabin interior design a bit.
    * Items found in the trash now pop out of the trash instead of going directly into your inventory.
    * Updated credits.
    * In single-player, the mines now reset as soon as you leave instead of waiting for the next 10-minute update.
    * NPCs now destroy trees in their path (and will trample wild tree seeds underfoot).
    * NPCs now close their eyes and do a sleep pose when they go to bed.
    * Players now close their eyes when they go to bed.
    * Penny no longer randomly reveals Pam's taste for alcoholic items.
    * Fish sold to Willy are now resold in his own shop (fish are no longer sold at Pierre's).
    * Tweaked hoed dirt color on the beach in fall.
    * Made David's cage look more appropriate for guinea pigs.
    * Reduced splash effect of small cosmetic debris to make it easier to distinguish splash of actual items.
    * Added animation when digging through trash.
    * Adjusted sound made when picking up forageables, eggs, etc.
    * Added [changes for modders](/User:Pathoschild/Modding_wishlist#Done_in_Stardew_Valley_1.4 "User:Pathoschild/Modding wishlist").
    * Added log for unexpected network disconnects (in a separate `DisconnectLogs` folder).
    * The ordering of the items on the collections page is now consistent between languages.

Fixes for gameplay

:   * Dismissing a letter with unclaimed items now automatically picks up the items.
    * You can no longer activate the Statue of Uncertainty if you haven't met the level requirements.
    * You no longer take damage from monsters while passing out at 2am.
    * Fixed various exploits, including…
      + opening the journal while fishing paused time but still caught fish;
      + opening the journal while dying skipped the death event and prevented losing items;
      + you could use an incorrect item in some cases (like using a wallpaper to obtain the galaxy sword, incubate a dinosaur egg, or when crafting);
      + you could predict the mushroom level pattern in the mines;
      + you couldn't be damaged while the eat confirmation prompt was up in multiplayer;
      + the invincibility timer after taking damage didn't decrease in multiplayer if a menu was open;
      + right-clicking a fishing rod attachment in the inventory reset its durability;
      + using glitches to leave the spa while in swimming mode would result in infinite energy/health regen;
      + you could obtain up to 109 statues of perfection by storing each one in a cabin's inventory chest;
      + items of different qualities could be combined into one stack when buying from Pierre;
      + you could sell items to Pierre's at an upgraded price (*e.g.,* salmonberries with the Bear's Knowledge perk) and buy them back at their normal price. He now resells them at the same price he paid.
    * Fixed players getting stuck…
      + if you cast a fishing rod just after opening a treasure chest in the mines;
      + in the blocking pose when you use a sword's special ability in rare cases;
      + on top of a mine ladder if multiple ladders were spawned;
      + in the traveling merchant's cart when dismounting from a horse in some cases (or getting your horse stuck that way);
      + on top of Abigail when playing the minigame in her two-heart event.
    * Fixed rare issue where no ladder would spawn on a mine floor.
    * Fixed monsters spawning too close to the start of a floor in the mines.
    * Fixed mummies dealing damage while downed.
    * Fixed invisible, interactable elevators on treasure floors of the Skull Cavern.
    * Fixed various issues where using bombs could cause items to spawn at the main player's current location instead of the location where the bomb was placed (*e.g.,* artifacts found via secret notes, fruit tree items, giant crops, mystic rocks, hardwood, crystals, and cave grass).
    * Fixed issue where weeds could be spawned on the tile directly beneath the elevator in the mines.
    * Fixed objects on the farm sometimes skipping their daily updates, which could cause issues like crops surviving a day into Winter or batches of crops not maturing at the same rate.
    * Fixed various cases where an entire stack of held items was incorrectly consumed.
    * Fixed certain artifacts not spawning as intended.
    * Fixed cooking ingredients spread between your inventory and fridge not correctly counted together.
    * Fixed issue where leveling up would incorrectly affect the related skill for the rest of the day (*i.e.,* common trees wouldn't drop seeds after leveling up foraging).
    * Fixed artifacts appearing on grass after winter turns to spring.
    * Fixed bug when getting a JojaMart membership shortly after completing the Community Center.
    * Fixed weed item obtained from breaking a mushroom seed or shaking a mushroom tree.
    * Fixed Livin' Off the Land announcing the start of blackberry season on the wrong date.
    * Fixed certain placeable items being placeable on tiles occupied by other furniture.
    * Fixed a few missing boundary tiles in certain areas, including in the Stardew Valley Fair.
    * Fixed player's fishing level and bait not taken into account for the wait time if the first nibble was missed.
    * Fixed Tiller profession bonus sometimes not applied to combined foraged and grown grape stacks.
    * Fixed Prospector profession not applied to rocks destroyed in the mines.
    * Fixed forage sometimes spawning out of bounds.
    * Fixed removing tappers from trees in certain ways making them become un-choppable.
    * Fixed fishing cast distance not determined when the bobber hits the water (previously set at the end of the cast).
    * Fixed TV weather forecast not always matching actual weather.
    * Fixed Queen of Sauce sometimes airing a new recipe on the Wednesday before it's scheduled on the following Sunday.
    * Fixed Queen of Sauce repeatedly airing the Stir Fry episode at the end of year 2 and the beginning of year 3.
    * Fixed players playing a minigame at 2am not properly quitting the minigame and passing out.
    * Fixed players able to continue fishing or charging tools past 2am.
    * Fixed giant crops growing in a noticeable pattern.
    * Fixed discrepancy between an item's shown health recovery and the actual recovery when consumed.
    * Fixed the chicken statue furniture being stackable with the chicken statue artifact.
    * Fixed issue where players could still take damage and die while warping with an obelisk or return scepter.
    * Fixed issue where ore/mineral veins destroyed with a bomb outside of the mine would only drop stone.
    * Fixed issue where going to bed early caused machines to process more quickly overnight. (Machines previously processed 100 minutes per hour slept; they now only do so between 2am and 6am, and the remaining time slept will be processed at the normal daytime rate of 60 mins/hour.)
    * Fixed issue where harvesting a tapped mushroom tree in winter would cause it to not produce again until mid-Spring, rather than Spring 1.
    * Fixed issue where snow yams and winter root could be dug up in the desert in winter.
    * Fixed lopsided bee house flower range.
    * Fixed some Witch Swamp and Mutant Bug Lair water tiles not correctly marked as water, causing inconsistent fish quality in those areas.
    * Fixed issue where entering a house the moment an NPC passes through a door would close the door on top of the NPC, causing them to get stuck.
    * Fixed issue where fruit trees wouldn't grow if there was a monster or other NPC near them overnight.
    * Fixed issue where closing a mine chest with the OK button while your inventory was full destroyed the item; instead the item is now dropped.
    * Fixed issue where a player at the Stardew Valley Fair would get their score calculated based on the contents of the Grange upon closing the minigame (instead of when Lewis had actually finished his judging), letting that player have a different score than intended.
    * Fixed minor issue where zero shots fired at the Stardew Valley Fair slingshot shooting gallery would give a large negative calculated accuracy.
    * The Cookie recipe will be sold at the Saloon if Evelyn's 4-heart event has been seen but the recipe wasn't obtained.

Fixes for player interaction

:   * You can now collect lost books even if your inventory is full.
    * Fixed horses being unmountable if they're very close to a pet.
    * Fixed being able to trash items from the crafting menu even though the trash can is invisible.
    * Fixed answering dialogues on a small screen causing the cursor to interact with the toolbar.
    * Fixed interacting with objects in the world while holding an item sometimes causing both the interaction and object to be used at the same time.
    * Fixed interacting with a fireplace sometimes not toggling it.
    * Fixed interacting with objects so that objects behind the character are longer interacted when the character is facing upwards.
    * Fixed interacting with a trash can on horseback simultaneously dismounting the horse and searching the trash (now just dismounts).
    * Fixed issue where players couldn't harvest or pick up items by clicking and holding the tool button with a melee weapon or scythe in hand.
    * Fixed issue where attempting to charge an upgraded watering can to the left of a body of water on the farm would prevent the farmer from charging it.
    * Fixed unable to fill water can from the left side of the water trough in the greenhouse.
    * Fixed issue where depositing ore into two nearby furnaces could activate both of them.
    * Fixed large rotated furniture being placeable on top of tables, causing them to disappear.
    * Fixed issue where players could move while warping out of the Witch's Swamp.
    * Fixed issue where players couldn't push through farm animals in some cases if they were offset by half a tile.
    * Fixed issue where interactable furniture like fireplaces couldn't be picked up with left-click when standing close to them and holding a non-tool item.
    * Fixed issue where it was hard to click on NPCs if you went into a festival while holding a placeable item.
    * Fixed crawling-stage babies in the crib not being interactable.
    * Fixed minor issue where you could cause the farmer to stop shaking during a tool charge by pressing a movement key.
    * Fixed being able to interact with NPCs when your farmer is set to be immobile. (For example, this prevents you from trying to gift your spouse a second gift immediately after kissing them and getting stuck in an erroneous animation frame.)
    * Fixed opened gates orphaned by destroying the fence post they're attached to not blocking movement.
    * Fixed wild tree seed placement cursor not accounting for seed-placeable rules.
    * Fixed crab pot placement cursor always green, even if an invalid placement tile is selected.
    * Fixed palm trees not shaking and dropping leaf debris when interacted in winter.
    * Fixed the "Warrior" option not being selectable during Sebastian's 6-heart event in Korean.
    * Fixed being able to use the dagger while bathing.
    * Fixed museum reward collection menu not dismissible using the exit hotkey.
    * Fixed museum donation screen issue where panning the camera would cause the cursor to scroll off of UI elements.
    * Fixed issue where watering a small tree sapling played a scythe sound.
    * Fixed issue where hitting a fence that has a torch on it would destroy the torch instead of dropping it.
    * Fixed invisible blocking tile front of Lewis's house during the Stardew Valley Fair.
    * Fixed blank or whitespace-only chat messages being sendable.

Fixes for festivals, events, and quests

:   * Dismissing a quest letter no longer discards the quest. (It's now added to your quest log to avoid permanently missing out on quests.)
    * You can no longer place objects at the beach while the Night Market is occurring.
    * Removed invisible trees from festivals.
    * Fixed exploit where you could pause time when the Night Market submarine was ascending/descending to skip the wait time.
    * Fixed exploit where you could watch the Night Market Mermaid Show while time was paused (the show now pauses too).
    * Fixed exploit where you could fulfill the requirements for a gathering quest by taking items out of a chest one-by-one.
    * Fixed players getting stuck on doors or placed objects during cutscenes in some cases.
    * Fixed players getting stuck in Harvey's 8-heart event if it was triggered when leaving his bedroom.
    * Fixed players getting stuck in Harvey's 10-heart event if a train came by.
    * Fixed introductions quest not considering Willy done after you meet him to receive the fishing rod.
    * Fixed Mr. Qi's Challenge not considered complete if you fulfilled the conditions before getting his letter.
    * Fixed the egg in Lewis' truck not being accessible during the egg hunt.
    * Fixed time not passing for machines inside of farm buildings during festivals.
    * Fixed players getting trapped in the hospital until the festival starts if they were knocked out for the first time on a festival day.
    * Fixed time passing during festivals not reflecting when the player(s) started the festivals.
    * Fixed some out-of-season items appearing as targets for "Help Wanted" quests.
      + Removed strawberry from Summer quests, catfish from Winter quests, and sardine from Summer quests.
    * Fixed bug limiting which NPC would request gathering, slay monsters, or fishing quests.
    * Fixed Help Wanted quests not reflecting that they pay 3x the market value, instead of 2x.
    * Fixed occasional spacing issues with the messages on the daily quest board.
    * Fixed Robin sometimes thanking you for the wrong item when completing a billboard quest.
    * Fixed winning festival events not counting towards farm's total earnings.
    * Fixed Penny's 6-heart event not triggering after purchasing the Community Upgrade.
    * Fixed Sam's 8-heart event being silent if you skipped his 2-heart event.
    * Fixed "A Winter Mystery" quest not triggering if exiting the farm from the bottom tile of the exit to the bus stop.

Fixes for shops and shipping

:   * Fixed merchants refilling limited-stock items when you reopen their shops.
    * Fixed traveling merchant sometimes having the same item for sale for two different prices.
    * Fixed items bought from shops being sellable at a different price than produced/grown versions.
    * Fixed issue where honey would sometimes sell for more than expected.
    * Fixed pressing `Alt` + `Enter` while buying from Pierre destroying the held item.
    * Fixed selling animals not counting towards farm's total earnings.
    * Fixed issue where you couldn't buy animals while Robin was upgrading the pertinent building.

Fixes for NPCs

:   * Fixed several cases where NPC dialogues were out of sync with the actual state of the game world (*e.g.,* saying the wrong dialogue in bed).
    * Fixed issue where villagers could get stuck doing their daily schedules late into the night after a festival.
    * Fixed issue where Vincent could get stuck on a flower barrel during the flower dance.
    * Fixed issue that prevented some villagers from hanging out with one another in town on certain days.
    * Fixed various issues related to naming horses.
    * Fixed various bugs caused by giving a villager's name to a horse, pet, or child.
    * Fixed friendship-related achievements not properly triggering as soon as the conditions are met.
    * Fixed various friendship-related bugs and inconsistencies, including 10-heart events being unlockable without a bouquet.
    * Fixed NPCs reacting incorrectly to certain gifted items.
    * Fixed issue where gifts couldn't be given to the dwarf if their dialogue was exhausted for the day.
    * Fixed Abigail visiting the farmer on the same day as her 8-heart event.
    * Fixed Bouncer just saying "Hi." instead of his unique line.
    * Fixed Bouncer not accepting the club card if you've already exhausted his dialogue for the day.
    * Fixed Demetrius plowing through bushes by the fountain in summer.
    * Fixed Dwarf always responding negatively to items it feels neutral about.
    * Fixed Dwarf not liking cave carrots, despite having dialogue which suggests otherwise.
    * Fixed Emily's four-heart event unlockable at night.
    * Fixed Gus offering Bread, Pizza, Salad, and Spaghetti as dish of the day (he already sells them as part of his normal shop stock).
    * Fixed Henchman dialogue box showing a friendship jewel.
    * Fixed Krobus secret note event not triggered if riding a horse.
    * Fixed Krobus not keeping silent on Fridays when accepting gifts.
    * Fixed Leah's summer schedule causing her to walk into the water and get stuck there for the rest of the day.
    * Fixed Penny not having her own introductory line.
    * Fixed Penny talking about the sound of rain on the roof of her trailer after the community upgrade is built.
    * Fixed Penny talking about living in a trailer after the community upgrade is built.
    * Fixed Pierre talking about time off after the Community Center has been restored.
    * Fixed Shane sending two recipes at 3 hearts. (The second is now sent at 7 hearts as intended.)
    * Fixed Welwick saying two different things on the same day.
    * Fixed free gift at the Night Market being available every ten minutes instead of once a day.
    * Fixed buggy interaction with Mayor Lewis when getting a Joja membership before starting the Community Center.
    * Fixed townsfolk sending players the wrong cooking recipes for their current friendship level.
    * Fixed villagers you're already dating still accepting bouquets from you.
    * Fixed a rare crash when attacking "slimes in love".
    * Fixed attacking a rock crab with a pickaxe not dealing damage after its shell is broken.
    * Fixed issue where villagers that respond differently depending on their current location will no longer say those location specific lines when talked to again later.
    * Fixed spouse continuing their ongoing dialogue after being interrupted with giving you a Stardrop.
    * Fixed most cases of crawling-stage babies waking up in the crib at the start of the day. (They'll now spend longer trying to find a non-crib position before giving up.)
    * Fixed NPCs sometimes detecting players rummaging through their trash or private possessions from a different location.
    * Fixed NPCs saying something upon entering an area (*e.g.,* Pam entering the Saloon) doing so if you're watching an event.

Fixes for multiplayer

:   * Farmhands' spouses now move around, run their daily schedules, and react to their spouses like they should.
    * Farmhands now return to their own porches after a festival, instead of the main farmer's porch.
    * Players can no longer give quest items as gifts to other players.
    * You can now connect to the host via IP while they're in the process of loading the game.
    * Fixed an issue where if a server was shut down on the same day a remote player had leveled up overnight, the level up would not be applied until the following night upon save load.
    * Fixed rearranging the museum in multiplayer showing a message that the player donated a new item.
    * Fixed farmhands not seeing the notification that a train is approaching.
    * Fixed players stuck if a bundle is completed while they're on a tile that becomes unwalkable after the room gets renovated.
    * Fixed issue where a spouse could get stuck in a farmhand's cabin after divorce. Save files that already have this issue will be fixed after the first night.
    * Fixed bundles button visible on the inventory screen for farmhands that had missed a bundle completion cutscene.
    * Fixed issue where you couldn't interact with something behind another player (*e.g.,* to talk to an NPC).
    * Fixed farmhands seeing bundles for completed areas when looking at the bundles menu.
    * Fixed farmhands unable to pick up lost books if the host has a menu open.
    * Fixed married NPCs saying marriage-specific lines to players who aren't their spouse while they're on their married schedules.
    * Fixed the door frame from Robin's construction animation not properly removed for remote clients after construction is done.
    * Fixed messages like the one about spreading weeds only shown for the host player.
    * Fixed Kent sometimes missing from clients' festivals.
    * Fixed players that collapse in multiplayer seeing the screen briefly flash, showing them in bed.
    * Fixed fishing rod cast sound affected by other players' casts.
    * Fixed fishing rod animation not properly synchronized when clicking and holding to recast.
    * Fixed issue where Lupini would only stop selling a painting if the host player was the one to buy it.
    * Fixed issue where horses could lose their hats in multiplayer.
    * Fixed issue where farmhands couldn't activate the Dark Shrine of Night Terrors.
    * Fixed issue where monsters wouldn't move while host was watching an event or getting knocked out.
    * Fixed various issues related to child placement and multiplayer synchronization.
    * Fixed issue where light sources from disconnected farmhands wouldn't get cleaned up.
    * Fixed issue where animals in barns built by farmhands in multiplayer were unable to breed.
    * Fixed issue where completing a Vault bundle wouldn't send a global chat message in multiplayer.
    * Fixed issue where the Witch event would create a void egg for each logged-in player.
    * Fixed issue where items shipped, minerals found, recipes cooked, fish caught, and artifacts found during a multiplayer session could be forgotten if a client disconnected before the end of the day.
    * Fixed several bugs relating to Mummy behavior and multiplayer sync.
    * Fixed sleep stamina recovery being based on the last player who went to bed (now tracked separately for each player).
    * Fixed baby slimes in the mines destroying rocks on contact if a non-host player killed the big slime.
    * Fixed various multiplayer data sync issues.
    * Fixed time slowing for all players when the host is in the mine (no longer slows at all in multiplayer).
    * Fixed missing tools in multiplayer not always being recovered.
    * Fixed various issues related to pets in multiplayer.
    * Fixed remote players not properly showing jump/jitter animations during emotes or horse mounting/dismounting.
    * Fixed the host player seeing flashes or feeling controller rumbles from bombs in other locations.
    * Fixed explosion flashes not showing up on farmhand machines.
    * Fixed player getting stuck on the "Waiting for players" check after a festival if another player joined at the same time.
    * Fixed Joja purchase form not reflecting upgrades bought by other players.
    * Fixed issue where getting killed while paused in multiplayer could leave you in a perpetual getting-knocked-unconscious state; this now unpauses instead.

Fixes for visual or cosmetic issues

:   * Items that come in various colors (like tulips) now show their proper color in the item received pop-up.
    * The mouse cursor is now hidden in scenes that lock user input.
    * The lighting in the Secret Woods now changes more consistently with the rest of the world as time passes through the day.
    * Lit furniture placed on top of tables will now properly light upon nightfall.
    * Fixed various visual map issues, including…
      + various tile issues in the Mines and Skull Cavern;
      + glow from certain lamps in the town interiors tilemap bleeding into adjacent tiles in the tilesheet;
      + incorrect corner edge tile used inside the walls in mine level 6;
      + incorrect grass tiling under the fence on the bottom of the mountain path to town, and missing tile on the tree near that location;
      + incorrect tiles in the Flower Festival;
      + a missing stone tile under the JojaMart sign in town;
      + visual issue with the kitchen floor tile;
      + visual bugs with the eyes of the statue in the secret woods;
      + visual issues with hat mouse's house;
      + artwork of the Bulletin Board in the Community Center not lining up with the walls around it;
      + mismatched walls behind the plant and picture frame in the hallway between Alex and George and Evelyn's rooms;
      + mismatched wall with the power outlet for George's TV;
      + look of the carpet under Sam's bed;
      + incorrect shadowing on some tiles in the mines on floor 7 and 14;
      + Secret Woods statue eyes staying red after activation until the season changes or you reload the save.
    * Fixed various text display issues, including…
      + various typos;
      + various line wrapping issues in dialogue boxes;
      + line wrapping issue when leaving the feast of the winter star;
      + line wrapping issue in tooltips for boots, rings, and melee weapons with long names;
      + extra space at the bottom of tooltips for edible items that don't grant any health;
      + sizing issues in carpenter menu for non-English languages;
      + spacing issues in bulletin board request text;
      + one of Haley's lines having a blank dialogue page;
      + certain items with long names causing tooltips to word wrap incorrectly;
      + stardrop message easter eggs incorrectly appending the favorite thing after the special text.
    * Fixed various sprite issues, including…
      + layering issues (*e.g.,* when the farmer is facing upwards while using some tools, or bushes drawn over chests);
      + character sprite coloration issues;
      + some monsters having two shadows (affected Ghosts, Dust Sprites, and Bugs);
      + Bouncer trying to face the player in some cases, resulting in an invalid sprite;
      + Linus starting some days slightly clipped into a wall;
      + Maru reverting to her plain clothes after her event in the clinic;
      + Penny's hair missing some pixels when she's sitting on the bench in town;
      + player hat rendered incorrectly in the inventory at night time;
      + player with an item raised above their head rendering with hands lowered in some specific cases;
      + player sprite rendered incorrectly after collapsing while in a bathing suit;
      + player sprite facing upwards after interacting with a child or festival NPC from above;
      + player 'wiggling nose' animation issue when casting or reeling in a fish;
      + player eye color drawn incorrectly when reeling in a fish;
      + player sprite flickering to invalid animation frame when tapping a movement key while aiming the fishing rod;
      + kissing your spouse in multiplayer sometimes showing an incorrect idle frame (sometimes facing the wrong direction);
      + various issues related to animations played as part of an NPC's daily schedule;
      + the light halo overlay on outdoor lamps sorting incorrectly at some positions;
      + health bar not fully consistent with stamina bar.
    * Fixed Penny washing dishes too far from the sink.
    * Fixed issue where rebinding keys would cause the game to display a blank options screen instead of properly prompting the player to press a key.
    * Fixed switching toolbars causing incorrect animations to play in multiplayer.
    * Fixed various issues related to the frogs that sometimes spawn on rainy days.
    * Fixed ancient seed not visible in inventory.
    * Fixed edible items that don't grant energy displaying the poisonous icon in tooltip.
    * Fixed being able to click title menu buttons before they're visible.
    * Fixed visual issues when swapping toolbars away or onto light sources.
    * Fixed some dialogue boxes being positioned incorrectly.
    * Fixed issue where hovering over the dialogue friendship jewel would show a friendship level tooltip, even if the jewel wasn't currently visible (*e.g.,* when answering a question).
    * Fixed visual seams appearing in Junimo Kart.
    * Fixed visual bug in the character's health bar when their health is low.
    * Fixed screen fading out twice when using Robin's building related functions.
    * Fixed resizing the window below the minimum size causing black bars on screen.
    * Fixed resizing the window or adjusting zoom resetting the scrollbar position on the options screen.
    * Fixed social tab showing one gift given if you gave two gifts that week plus a birthday present.
    * Fixed minor visual bug when switching between the "Host" and "Join" tabs in the co-op screen.
    * Fixed non-centered text alignment in the header of Robin's build menu.
    * Fixed the host player seeing light sources from Ghosts in the mines, even while not in the mines.
    * Fixed purchasing stacks of player-sold items from Pierre not visibly reducing the stack available.
    * Fixed lighting in the mine changed as soon as you start going down a ladder, instead of after loading the next level.
    * Fixed screen briefly fading to black during Grandpa's evaluation.
    * Fixed players sometimes getting stuck on a black screen during weddings.
    * Fixed pulling the last piece of hay out of a hopper not making it display as empty.
    * Fixed several issues with weather debris displaying incorrectly.
    * Fixed issue where white or black customization colors would cause the HSV sliders to show invalid numbers upon using the Shrine of Illusion.
    * Fixed visual issues with the cutscenes while riding the bus.
    * Fixed issue where holding 'up' while taking the bus back from the desert would cause the camera to pan during the cutscene.
    * Fixed trees planted in the desert showing their snow-covered sprites in winter.
    * Fixed issue where player animations weren't properly looping during events.
    * Fixed issue where Journey of the Prairie King showed -1 lives after losing all of your lives.
    * Fixed issue in Robin's menu where the Deluxe Barn's description overlapped the materials list.
    * Fixed minigames / cutscenes not always centered when the game is zoomed out.
    * Fixed the order of recipes in the Collections menu and the kitchen stove menu not matching.
    * Fixed weather debris clumped up after playing a minigame.
    * Fixed alignment of several UI elements in Calico Jack minigame.
    * Fixed falling leaves in the Secret Woods not showing their seasonal variants in fall.
    * Fixed campfire lighting misaligned.
    * Fixed map showing the player in the mines when they're in the Skull Cavern.
    * Fixed menu backgrounds not shown in the Community Center bundles menu.
    * Fixed the map's location label partly rendered off-screen in some cases.
    * Fixed white borders sometimes drawn on pieces of debris/dropped items.
    * Fixed mouse cursor not showing gift icon when gifting items to an NPC you're meeting for the first time.
    * Fixed mouse cursor showing "talk to" when hovering over NPCs during non-interactable events.
    * Fixed issue where harvesting from a crab pot while your inventory was full would result in multiple 'inventory full' messages without the red 'X'.
    * Fixed crab pots positioned/rendered over tiles they should be being drawn behind.
    * Fixed issue where opening a door would briefly show a ghost door.
    * Fixed windows in barns, coops, and spouse rooms providing light on rainy days or when it's dark out.
    * Fixed inconsistent particle effect when you right-click vs left-click to sell in the shop.
    * Fixed digging up an artifact spot in the rain leaving a dry spot.
    * Fixed hoeing in the desert when it's raining elsewhere leaving a wet spot.
    * Fixed outdoor garden pots not showing watered sprite when it's raining.
    * Fixed the health bar 'bleeding' at low health values if the health bar isn't currently being drawn or if the screen is currently fading.
    * Fixed double cursor in the Stardew Valley Fair slingshot minigame, and disabled drawing of it when playing with controller.

Other bug fixes

:   * All mine songs now show up in the Jukebox list.
    * Fixed crash on startup if no audio output device is detected.
    * Fixed resolution issues for some players.
    * Fixed music not properly playing at the start of a new day.
    * Fixed Junimos not behaving properly after completing the community center.
    * Fixed issue where other players could affect the music that's playing in the mines.
    * Fixed various bugs caused by simultaneous buffs and debuffs.
    * Improved confusing error if certain game files are missing.
    * Fixed issue where players wouldn't get museum achievements until the next time they donated something themselves.
    * Fixed Master Angler achievement awarded before catching all fish.
    * Fixed issue where the music in Leah's house didn't stop after leaving her house.
    * Fixed issue where the wallpaper and flooring would shift rooms as you upgraded your house.
    * Fixed skipping an event sometimes making the player wait on a black screen for a while.
    * Fixed placing a bomb and leaving the screen before it explodes causing a buggy sound effect.
    * Fixed placing a bomb that destroys weeds and leaving the area before the explosion happens still playing the weed destruction sounds.
    * Fixed options menu being scrollable while a dropdown list is active.
    * Fixed an issue where a female character's pants could have their color changed to black during a wedding ceremony.
    * Fixed issue where you'd need to click twice to clear the dialogue that appeared after falling down a mineshaft.
    * Fixed issue where hotkeys (like opening the inventory) triggered after sending a chat message.
    * Fixed issue where dialogue couldn't be advanced using keyboard inputs.
    * Fixed issue where the music would sometimes briefly play again after you had turned the volume down.
    * Fixed issue where rebinding the menu key closed the options menu.
    * Fixed Prairie King game over screen only accepting input every 1.5 seconds.
    * Fixed Prairie King music overlapping if you use the zombie powerup multiple times in quick succession.
    * Fixed mouse repositioned when clicking HUD zoom buttons, making it harder to zoom in/out multiple times.
    * Fixed issue where loading a save would play the furnace and fireplace sounds.
    * Fixed volume levels not properly applied when connecting to a game as a farmhand.
    * Fixed rare crash or invisible grass caused by grass sizes becoming invalid.
    * Fixed clicking without dragging with the slingshot consuming ammo but firing nothing.
    * Fixed crash after eating a Maki Roll while playing in French.
    * Fixed Prehistoric Tibia and Amphibian Fossil not appearing in the forest (or anywhere) while playing in Spanish.
    * Fixed Wild Plums listed as forage instead of fruit in non-English languages.

## 1.3.36

Stardew Valley 1.3.36 was [posted to the beta channel](https://www.reddit.com/r/StardewValley/comments/ajf8jd/beta_branch_v1335_bugsdiscussion_new_languages/) on 24 January 2019 and released on 1 March 2019.

Changes

:   * Added [French](https://fr.stardewvalleywiki.com/Stardew_Valley_Wiki "fr:Stardew Valley Wiki"), [Korean](https://ko.stardewvalleywiki.com/Stardew_Valley_Wiki "ko:Stardew Valley Wiki"), [Italian](https://it.stardewvalleywiki.com/Stardew_Valley_Wiki "it:Stardew Valley Wiki"), [Hungarian](https://hu.stardewvalleywiki.com/Stardew_Valley_Wiki "hu:Stardew Valley Wiki"), and [Turkish](https://tr.stardewvalleywiki.com/Stardew_Valley_Wiki "tr:Stardew Valley Wiki") language support
    * Added a new Credits menu to replace the "About" menu on the title screen, and removed the `/credits` chat command.
    * Removed unneeded tilesheet files under `Content`.
    * Removed translated map files under `Content/Maps` (translated tilesheets are now loaded automatically).
    * Centered [shed](/Shed "Shed") door.

Bug fixes

:   * Fixed bug where music doesn't correctly play in the morning.
    * Fixed bug where giving a gift to an NPC caused the gift action to happen twice in rapid succession.
    * Fixed furniture rotation bug for "stools".
    * Fixed Junimos not disappearing after the final goodbye.

| **Beta Versions (1.3.35–1.3.36)** |
| --- |
| 1.3.36 beta (26 February 2019)  * Fixed bug where music doesn't correctly play in the morning. * Fixed bug where giving a gift to an NPC caused the gift action to happen twice in rapid succession. * Fixed furniture rotation bug for "stools". * Fixed Junimos not disappearing after the final goodbye.  1.3.35 beta (2 February 2019, didn't change version)  * Added Hungarian language. * Improved Korean font.  1.3.35 beta ([24 January 2019](https://www.reddit.com/r/StardewValley/comments/ajf8jd/beta_branch_v1335_bugsdiscussion_new_languages/))  * Added French, Italian, Korean, and Turkish languages. * Added a new Credits menu to replace the "About" menu on the title screen, and removed the `/credits` chat command. * Removed unneeded tilesheet files under `Content`. * Removed translated map files under `Content/Maps` (translated tilesheets are now loaded automatically). |

## 1.3.33

Stardew Valley 1.3.33 was posted to the beta channel on 18 December 2018 and [released](https://steamcommunity.com/games/413150/announcements/detail/1696068721461656021) on 8 January 2019.

Changes

:   * Improved performance in locations with lots of light sources (*e.g.,* torches).
    * Improved performance on farms with lots of animals.
    * Tweaked new "H" health icon.

Bug fixes

:   * Fixed multiplayer visual glitch when another player uses a tool and then starts moving in a new direction.
    * Fixed "fishing stance" visual glitches in multiplayer.

## 1.3.32

Stardew Valley 1.3.32 was released on 19 November 2018. (Versions 1.3.29–1.3.32 were all posted on the [beta channel](https://stardewvalley.net/stardew-valley-v1-3-beta/), and are included in 1.3.32.)

Changes

:   * Optimised network performance.
    * Added more ways for the host to unpause the server (by pressing ESC, B, Back).
    * Added alternative way to show the chat box (press right stick button on a controller).
    * Added [internal changes for modders](/User:Pathoschild/Modding_wishlist#Done_in_Stardew_Valley_1.3.32 "User:Pathoschild/Modding wishlist") (should have no effect on vanilla gameplay).

Bug fixes

:   * Fixed slimes not pouncing correctly.
    * Fixed items-crafted stat being 0 after loading a file until you craft something again.
    * Fixed rabbit's foot not affecting the breakup scene in non-English language modes.
    * Fixed some rare tool-related crashes in multiplayer.
    * Fixed an audio-related crash often caused when using bombs.
    * Fixed Junimos dropping crops on the floor instead of collecting them.
    * Fixed NPCs walking through the saloon doors.
    * Fixed a few rare-ish crashes that can occur when connecting to another player's game.
    * Fixed eye color being reset to brown after reloading.
    * Fixed inability to use rod / slingshot in festival minigames.
    * Fixed the title menu back button being hidden behind submenus.
    * Fixed inability to move after receiving a gift at the [Feast of the Winter Star](/Feast_of_the_Winter_Star "Feast of the Winter Star").
    * Fixed crash when saving after the game adds Lewis' shorts to Marnie's house.
    * Fixed crash viewing the map when another player is in certain events.
    * Fixed "double sound" when using singing stone.
    * Fixed a Geneva Convention violation (by replacing red crosses in graphics).
    * Fixed clicks on the chatbox not being registered when the game is paused.
    * Fixed players sometimes walking off in a straight line through all terrain when they get disconnected.
    * Fixed babies sometimes spawning in houses that don't belong to the parents.
    * Fixed the potential for overnight events to cancel or skip a wedding event.
    * Fixed a desync that could occur if a player tried to get into the casino after a different player has removed the bouncer.
    * Fixed players able to simultaneously build overlapping farm buildings.
    * Fixed only one player being able to get the dark talisman.
    * Fixed the inability to place donated items on the bottom two rows of the museum.
    * Fixed farmhands being unable to pick up items they dropped in festivals.
    * Fixed Pam's upgraded house interior event not happening.
    * Fixed visual glitches caused by triggering a shared event simultaneously with the return scepter.
    * Fixed softlock caused by mistaken ability to use daggers during events.
    * Fixed players all receiving the same personal overnight events on the same day (*e.g.,* spouse asking if you want a baby).
    * Fixed attempting to demolish cabins of abnormally disconnected farmhands causing the cabin to be destroyed after you leave the buildings menu.
    * Fixed farmers getting stuck in the fishing casting animation after picking up someone else's rod.
    * Fixed host sometimes appearing stuck using tool in shared events.
    * Fixed soft-lock when you play the Journey of the Prairie King past 2am.
    * Fixed glitched chest lid appearing when you destroy a cabin.
    * Fixed duplicate songs in the jukebox.
    * Fixed only one player's glow ring working at a time.
    * Fixed farmhands not being able to see each others' bundle changes.
    * Fixed bug causing some players to become married to two other players in 3-4 player farms.
    * Fixed player sometimes getting stuck in bed after another player got in and then got back out.

| **Beta Versions (1.3.29–1.3.32)** |
| --- |
| 1.3.32 beta ([14 November 2018](https://community.playstarbound.com/threads/stardew-valley-multiplayer-known-issues-fixes.147892/page-15#post-3316063))  * Added more ways for the host to unpause the server (by pressing ESC, B, Back). * Added alternative way to show the chat box (press right stick button on a controller). * Added [internal changes for modders](/User:Pathoschild/Modding_wishlist#Done_in_Stardew_Valley_1.3.32 "User:Pathoschild/Modding wishlist") (should have no effect on vanilla gameplay). * Fixed some GOG users unable to use invite codes (beta-only bug). * Fixed crash when saving after the game adds Lewis's shorts to Marnie's house. * Fixed crash viewing the map when another player is in certain events. * Fixed "double sound" when using singing stone. * Fixed a Geneva Convention violation (by replacing red crosses in graphics). * Fixed clicks on the chatbox not being registered when the game is paused. * Fixed players sometimes walking off in a straight line through all terrain when they get disconnected. * Fixed babies sometimes spawning in houses that don't belong to the parents. * Fixed the potential for overnight events to cancel or skip a wedding event. * Fixed a desync that could occur if a player tried to get into the casino after a different player has removed the bouncer. * Fixed players able to simultaneously build overlapping farm buildings. * Fixed only one player being able to get the dark talisman. * Fixed the inability to place donated items on the bottom two rows of the museum. * Fixed farmhands being unable to pick up items they dropped in festivals. * Fixed Pam's upgraded house interior event not happening. * Fixed visual glitches caused by triggering a shared event simultaneously with the return scepter. * Fixed softlock caused by mistaken ability to use daggers during events. * Fixed players all receiving the same personal overnight events on the same day (*e.g.,* spouse asking if you want a baby). * Fixed attempting to demolish cabins of abnormally disconnected farmhands causing the cabin to be destroyed after you leave the buildings menu. * Fixed farmers getting stuck in the fishing casting animation after picking up someone else's rod. * Fixed host sometimes appearing stuck using tool in shared events. * Fixed softlock when you play the Journey of the Prairie King past 2am. * Fixed glitched chest lid appearing when you destroy a cabin. * Fixed duplicate songs in the jukebox. * Fixed only one player's glow ring working at a time. * Fixed farmhands not being able to see each others' bundle changes. * Fixed bug causing some players to become married to two other players in 3-4 player farms. * Fixed player sometimes getting stuck in bed after another player got in and then got back out.  1.3.31 beta (25 September 2018)  * Fixed junimos dropping crops on the floor instead of collecting them. * Fixed NPCs walking through the saloon doors. * Fixed a few rare-ish crashes that can occur when connecting to another player's game. * Fixed eye color being reset to brown after reloading. * Fixed inability to use rod / slingshot in festival minigames. * Fixed the title menu back button being hidden behind submenus. * Fixed inability to move after receiving a gift at the [Feast of the Winter Star](/Feast_of_the_Winter_Star "Feast of the Winter Star").  1.3.30 beta (18 September 2018)  * Fixed path and floor tiles rendering as 1x1 tiles instead of joining up in 1.3.29. * Fixed double fade-in when the day starts in 1.3.29. * Fixed some rare tool-related crashes in multiplayer. * Fixed an audio-related crash often caused when using bombs.  1.3.29 beta (21 August 2018)  * Experimental optimisations (might affect stability - expect 1.3.29 to be slightly less stable than other recent patches). * Fixed slimes not pouncing correctly. * Fixed items-crafted stat being 0 after loading a file until you craft something again. * Fixed rabbit's foot not affecting the breakup scene in non-English language modes. |

## 1.3.28

Stardew Valley 1.3.28 was posted to the beta channel on 10 August 2018 and to the main channel on 14 August 2018.

* Fixed bug preventing buildings from being placed where there would be a path/flooring tile in front of the door.
* Fixed music not playing at the Luau festival and in town.
* Fixed clients occasionally crashing in rainy weather.
* Fixed server crash when there are no available network adapters.
* Fixed the load menu showing 'no saved games' while searching for files.
* Fixed crash that occurred if you collided with a monster on the first frame you entered a new location.
* Fixed Robin forgetting that she's meant to upgrade a farmhand cabin if the farmhand disconnects abnormally.
* Fixed farmhands not being able to set the next day's weather with rain totems.
* Fixed farmhands 'swimming' inside their cabins if they're disconnected while swimming in the spa.
* Fixed swimming-related visual bugs in on farmers' faces.
* Fixed furniture rotation graphical glitch.
* Fixed a crash that occurs if you try to copy an invite code while remotely logged into the machine the game is running on.
* Fixed a German localization issue with '%Farm' appearing in text instead of the farm's name.
* Fixed spouse NPCs not kissing farmers.
* Various internal changes requested on the modding wishlist.

## 1.3.27

Stardew Valley 1.3.27 was [released](https://stardewvalley.net/stardew-valley-1-3-multiplayer-update-is-now-available/) on 1 August 2018. (Versions 1.3.3–1.3.26 were only posted on the beta channel, and are included in 1.3.27.)

New content

:   * Added [multiplayer](/Multiplayer "Multiplayer") over GOG, Steam, or LAN. This includes chat with custom emotes, and new [cabin](/Cabin "Cabin") buildings.
    * Added [Night Market](/Night_Market "Night Market") event.
    * Added Community Upgrade to [carpenter's shop](/Carpenter%27s_Shop "Carpenter's Shop").
    * Added buildable shipping bins to Carpenter's Shop.
    * Added [Abigail](/Abigail "Abigail") encounter at level 20 in [the mines](/The_Mines "The Mines").
    * Added new heart events for [Jas](/Jas "Jas"), [Linus](/Linus "Linus"), [Pam](/Pam "Pam"), [Vincent](/Vincent "Vincent"), and [Willy](/Willy "Willy").
    * Added new heart events when player has given a [bouquet](/Bouquet "Bouquet") to all bachelors or bachelorettes.
    * Added rare treasure chest rooms in [Skull Cavern](/Skull_Cavern "Skull Cavern").
    * Added new monsters in the [Skull Cavern](/Skull_Cavern "Skull Cavern"): [carbon ghost](/Carbon_Ghost "Carbon Ghost"), [iridium bat](/Bats "Bats"), and [iridium crab](/Iridium_Crab "Iridium Crab").
    * Added [secret notes](/Secret_Notes "Secret Notes") and related quests.
    * Added new items: [auto-grabber](/Auto-Grabber "Auto-Grabber"), [cactus seeds](/Cactus_Seeds "Cactus Seeds"), [garden pot](/Garden_Pot "Garden Pot"), [wood sign](/Wood_Sign "Wood Sign") and [stone sign](/Stone_Sign "Stone Sign"), [solid gold Lewis](/Solid_Gold_Lewis "Solid Gold Lewis") statue, [pearl](/Pearl "Pearl"), [wedding ring](/Wedding_Ring "Wedding Ring"), [new paintings](/Furniture#Night_Market_Paintings "Furniture"), and decorative items sold at shops and festivals throughout the year.
    * Added [bear's knowledge](/Bear%27s_Knowledge "Bear's Knowledge"), [special charm](/Special_Charm "Special Charm"), [spring onion mastery](/Spring_Onion_Mastery "Spring Onion Mastery").
    * Added [Statue Of Uncertainty](/The_Sewers#Statue_Of_Uncertainty "The Sewers") to change professions.
    * Added different stationery for letters from [Sandy](/Sandy "Sandy") and the [Wizard](/Wizard "Wizard").
    * Added horse [hats](/Hats "Hats").

Balance changes

:   * Increased purchase price of wood, stone, ores, and coal in the year 2+. The gold received for selling them is unchanged.
    * Reduced price of [tub o' flowers](/Tub_o%27_Flowers "Tub o' Flowers") from 1000g to 250g, and recipe from 2000g to 1000g.
    * Breaking small tree stumps now provides +1 foraging XP.
    * Once the player reaches the mine bottom...
      + [prismatic shards](/Prismatic_Shard "Prismatic Shard") and [diamonds](/Diamond "Diamond") may rarely drop from any monster;
      + gems and [purple mushrooms](/Purple_Mushroom "Purple Mushroom") may be found when searching trash bins;
      + gems and purple mushrooms may be requested in NPC quests;
      + some monsters will be stronger.

Other changes

:   * Once the player reaches the mine bottom, the [Dwarf](/Dwarf "Dwarf") will attend weddings.
    * [Golden pumpkin](/Golden_Pumpkin "Golden Pumpkin") is now a universal love (instead of universal hate).
    * Tweaked several seed packet sprites.
    * Tweaked Mr. Qi dialogue portrait.
    * You can now add Mayor Lewis' shorts to the [Luau](/Luau "Luau") soup.
    * You can now put [fire quartz](/Fire_Quartz "Fire Quartz") in the [furnace](/Furnace "Furnace") to produce [refined quartz](/Refined_Quartz "Refined Quartz").
    * You can now refill a Watering Can at the kitchen sink.
    * Fireplaces are now furniture, so you can move them around and buy different fireplaces.
    * Fruit Trees cannot be planted on top of decorations in the [greenhouse](/Greenhouse "Greenhouse") border, or in the corners of the Greenhouse.
    * Replaced gold display on player menu from "g" to "金" in Chinese.
    * Improve Chinese translations:

| **Item name changes** |
| --- |
| * [angler](/Angler "Angler") from "安康鱼" to "鮟鱇鱼". * [burglar's ring](/Burglar%27s_Ring "Burglar's Ring") from "窃贼戒指" to "潜行者戒指". * [Dark Shrine of Memory](/Dark_Shrine_of_Memory "Dark Shrine of Memory") from "黑暗神殿的记忆" to "记忆之黑暗神殿". * [Dark Shrine of Night Terrors](/Dark_Shrine_of_Night_Terrors "Dark Shrine of Night Terrors") from "夜间恐怖的黑暗神殿" to "夜惊之黑暗神殿". * [Dark Shrine of Selfishness](/Dark_Shrine_of_Selfishness "Dark Shrine of Selfishness") from "私欲的黑暗神殿" to "私欲之黑暗神殿". * [error item](/Error_Item "Error Item") from "错误项目" to "错误物品". * [fried egg](/Fried_Egg "Fried Egg") from "煎鸡蛋" to "荷包蛋". * [frozen geode](/Frozen_Geode "Frozen Geode") from "冰封晶洞" to "冰封晶球". * [geode](/Geode "Geode") from "晶洞" to "晶球". * [J. Cola Light](/J._Cola_Light "J. Cola Light") from "JOJA可乐灯" to "乔家可乐灯". * [Joja Cola](/Joja_Cola "Joja Cola") from "JOJA可乐" to "乔家可乐". * [Joja Community Development Form](/Joja_Community_Development_Form "Joja Community Development Form") from "JOJA社区发展申请书" to "乔家社区发展申请书". * [magma geode](/Magma_Geode "Magma Geode") from "巨大晶洞" to "岩浆晶球". * [omni geode](/Omni_Geode "Omni Geode") from "万象晶石" to "万象晶球". * [poppy](/Poppy "Poppy") from "罂粟" to "虞美人". * [poppy seeds](/Poppy_Seeds "Poppy Seeds") from "罂粟种子" to "虞美人种子". * [poppyseed muffin](/Poppyseed_Muffin "Poppyseed Muffin") from "罂粟籽松糕" to "虞美人籽松糕". * [sloth skeleton](/Sloth_Skeleton "Sloth Skeleton") L from "左倾树懒骷髅" to "左倾树懒骨头". * [sloth skeleton](/Sloth_Skeleton "Sloth Skeleton") M from "中树懒骷髅" to "中树懒骨头". * [sloth skeleton](/Sloth_Skeleton "Sloth Skeleton") R from "右树懒骷髅" to "右树懒骨头". * [vegetable medley](/Vegetable_Medley "Vegetable Medley") from "混合蔬菜" to "蔬菜杂烩". |

:   * Item description changes:

| **Items Changed** |
| --- |
| [bait](/Bait_(item) "Bait (item)"), [bean hotpot](/Bean_Hotpot "Bean Hotpot"), [broken CD](/Broken_CD "Broken CD"), [coffee](/Coffee "Coffee"), [copper bar](/Copper_Bar "Copper Bar"), [dwarf gadget](/Dwarf_Gadget "Dwarf Gadget"), [fried egg](/Fried_Egg "Fried Egg"), [fried mushroom](/Fried_Mushroom "Fried Mushroom"), [frozen geode](/Frozen_Geode "Frozen Geode"), [geode](/Geode "Geode"). [gold bar](/Gold_Bar "Gold Bar"), [iridium bar](/Iridium_Bar "Iridium Bar"), [iridium ore](/Iridium_Ore "Iridium Ore"), [iron bar](/Iron_Bar "Iron Bar"), [Joja Cola](/Joja_Cola "Joja Cola"), [large goat milk](/Large_Goat_Milk "Large Goat Milk"), [legend](/Legend "Legend"), [magma geode](/Magma_Geode "Magma Geode"), [miner's treat](/Miner%27s_Treat "Miner's Treat"), [omni geode](/Omni_Geode "Omni Geode"), [poppy](/Poppy "Poppy"), [sashimi](/Sashimi "Sashimi"), [skeletal tail](/Skeletal_Tail "Skeletal Tail"), [slime incubator](/Slime_Incubator "Slime Incubator"), [slimejack](/Slimejack "Slimejack"), [small magnet ring](/Small_Magnet_Ring "Small Magnet Ring"), [sunflower seeds](/Sunflower_Seeds "Sunflower Seeds"), [trap bobber](/Trap_Bobber "Trap Bobber"), [tulip](/Tulip "Tulip"), [vampire ring](/Vampire_Ring "Vampire Ring"), [void salmon](/Void_Salmon "Void Salmon"), [wicked statue](/Wicked_Statue "Wicked Statue"), and [worm bin](/Worm_Bin "Worm Bin"). |

Bug fixes

:   * Fixed crops harvested with a [scythe](/Scythe "Scythe") not giving XP.
    * Fixed [bee houses](/Bee_House "Bee House") always giving wild honey when used on custom farms.
    * Fixed seeds planted out of season disappearing.
    * Fixed player collapse being cancelled when they open the journal.
    * Fixed animal mood & happiness bugs.
    * Fixed crystalarium item swap exploit.
    * Fixed furniture being usable to complete bundles.
    * Fixed some recipes allowing Milk, but not Large Milk.
    * Fixed crash that occurred after 596 hours of gameplay.
    * Fixed staircase being spawned on [mine](/The_Mines "The Mines") level 120 when a placed object is destroyed.
    * Several grammar/spelling fixes.
    * Fixed [wheat seeds](/Wheat_Seeds "Wheat Seeds") and [bok choy seeds](/Bok_Choy_Seeds "Bok Choy Seeds") descriptions in Brazilian-Portugese.
    * Fixed spring sign on bathhouse in Chinese.

| **Beta Versions (1.3.0–1.3.27)** |
| --- |
| The above list shows changes compared to the previous 1.2.33 stable release. Here are the changes in individual beta builds: 1.3.27 beta (26 July 2018)  * Fixed changes to the NetList events we added for modding * Fixed gift limits not resetting sometimes in single-player  1.3.26 beta (24 July 2018)  * Fixed game freeze when Grandpa's event and witch event happen simultaneously. * Fixed full house [achievement](/Achievements "Achievements") not working for player/player child births. * Fixed black screen until you click after player/player child birth. * Fixed children not appearing in farmhouse for player/player marriage. * Fixed buildings evaluating current position as ineligible move space. * Fixed prismatic shard rate too high after reaching bottom of mines. * Fixed spouse stardrop not rewarded in player/player marriages. * Fixed instantly brewing wine. * Fixed horse duplication bug. * Fixed typo in Krobus winter event quest. * Fixed crash when entering railroad area. * Fixed disconnect issues reported in 1.3.25. * Fixed fishing rod crash bug. * Fixed farmhands unable to get rid of children at dark shrine. * Fixed museum duplication issues. * Fixed players able to donate/rearrange the museum simultaneously. * Fixed spouse NPCs not kissing back in multiplayer. * Fixed farmhands talking to NPCs playing unique animations causing them to stop animating. * Fixed lack of spouse patio animations. * Fixed host seeing spouse dialogue for farmhand spouses. * Fixed being able to mount horse while farmer is playing an animation (*e.g.,* picking up an item). * Fixed animals eating twice as much if they're outside while the player sleeps. * Added `ValueAdded`/`ValueRemoved` events to `NetList` for SMAPI.  1.3.25 beta (16 July 2018)  * Experimental network usage optimizations * Fixed infinite ingredient use exploit when cooking in the kitchen * Fixed NPC marriage dialogue appearing for non-spouse players * Fixed crops harvested with a [scythe](/Scythe "Scythe") not giving XP * Fixed inability to cancel moving a building * Fixed game occasionally locking up on a black screen at 2am  1.3.24 beta (10 July 2018)  * Fixed players stuck on "Connecting to online services..." screen * Fixed crystalarium item swap exploit * Fixed furniture able to be used to complete bundles * Fixed milk requirements for certain cooking recipes (now can accept either Milk or Large Milk) * Fixed summer weather forecast bug * Fixed furniture duplication bug * Fixed long tool use animation bug * Fixed warp tile player & shadow animation bug * Fixed "Cloud Country" not being added to the jukebox if you create a game via the co-op menu * Fixed cooking food in the kitchen using ingredients from the wrong fridge * Fixed item debris duplication bug  1.3.23 beta (5 July 2018)  * Fixed `timesReachedMineBottom` flag never updated. This enables previously-inactive features once the player reaches the mine bottom:   + [prismatic shards](/Prismatic_Shard "Prismatic Shard") and [diamonds](/Diamond "Diamond") may rarely drop from any monster;   + gems and [purple mushrooms](/Purple_Mushroom "Purple Mushroom") may be found when searching trash bins;   + gems and purple mushrooms may be requested in NPC quests;   + the [Dwarf](/Dwarf "Dwarf") will attend weddings;   + some monsters will be stronger. * Fixed farmhands being warped to the wrong version of Marnie's house after purchasing animals * Fixed crash when player/player child is born and one of the parents is offline * Fixed multiple spouses standing in same space on farm * Fixed using a weapon after eating nullifying the food effects * Fix to walk around (instead of through) Pam when getting on the bus (after purchasing ticket from north side of ticket vendor) * Fixed toddlers not moving inside cabins * Fix to stop fly buzzing sound when it dies  1.3.22 beta (3 July 2018)  * Fixed crash that occurred after 596 hours of gameplay * Fixed mistranslated Chinese co-op button on the main menu * Fixed divorced status not being carried over from 1.2 saves * Fixed post-6pm animal mood drain * Fixed animal happiness overflowing * Fixed spa not regenerating stamina when a menu is open in multiplayer * Fixed second player-player parent pregnancy causing crashes * Fixed farmhands being able to retrieve the last item shipped after it has been sold * Fixed lighting detaching from sources when upgrading the house * Fixed players losing cursor slot items when they are disconnected while managing the inventory * Fixed farmhands being unable to enter the wizard's tower if they join after the [Community Center](/Community_Center "Community Center") is completed * Fixed armored bugs not being invincible * Fixed wrong fish appearing in fishing minigame tent * Fixed slingshot minigame crash * Fixed broken skull cavern level 100 event in Russian * Fixed cave carrot quest crash * Fixed buffs not clearing when farmhands log out * Fixed farmhands being unable to open Junimo huts * Fixed goblin problem quest still showing in the log for other players after the quest is completed * Fixed new songs on Jukebox showing wrong names * Fixed duplicate songs in the Jukebox menu  1.3.21 beta (21 June 2018)  * Fixed animal sounds playing outside of map * Fixed player icons overlapping on the map page * Fixed fishing rod casting temp sprites during the fall mini game * Fixed unsynced exhausted state and passing out * Fixed remote characters not blinking * Fixed grubs invincible to host while retreating * Fixed floating lamp sprite in mines * Fixed secret notes fished up spawning without a note number * Fixed beer sprite overlapped by counter in Clint 3 heart event * Fixed secret note #4 description fix  1.3.20 beta (19 June 2018)  * Fixed fish splash points not properly syncing * Fixed missing elevator dings for clients * Fixed objects broken by weapons breaking twice when there is latency * Fixed glitched chest object in inventory UI * Fixed horse missing sounds/animation for clients * Fixed crash when trying to display dialogue for NPCs without any dialogue left * Fixed players hidden from view when local player uses a return scepter * Fixed all players teleported when return scepter used * Fixed structures can be placed where players would get stuck exiting them * Fix to allow players to walk out of resources (stumps/rocks) if they become stuck inside * Fixed Grandpa's candles not lighting * Fixed freeze up when all players are not in bed at 2am * Fixed farmhands not seeing giant mushroom trees until they relog * Translation fixes * Fixed door/footstep sounds being heard mapwide * Fixed item duplication if farmhands login while their inventory is open * Fixed [stamina](/Energy "Energy") resetting to max when you leave/rejoin * Fixed trash items respawning when player travels to a different location * Fixed crash after blowing up a rock crab * Fixed fishing treasure chest causing a new cast * Fixed filled chests breaking when they're next to an empty chest * Clicking on the [journal](/Quests "Quests") icon no longer allows the player to stay awake past 2am  1.3.19 beta (14 June 2018)  * Fixed client crashing when joining game due to null quest * Fixed Beach Bridge not updating for other players when one repairs it * Fixed controls locking up inside fishing tent * Fixed loss of 'Dating' friendship status when upgrading from 1.2 to 1.3 * Fixed wedding ring not appearing in crafting list in SMAPI * Fixed deepestMineLevel stat only updating when they go deeper then any other player * Fixed seasonal tileset / SMAPI compatibility issue * Fixed farmhands unable to enter Pierre's on Wednesday after Community center completion * Fixed rain totems not working in multiplayer * Fixed no blue chickens in multiplayer * Fixed Gus walking through walls in Community Center * Fixed some animations playing at double speed inside buildings * Fixed Pam disappearing (potential fix)  1.3.18 beta (12 June 2018)  * Fixed active players unable to cancel new player creation for farmhands * Fixed mouseover hover missing for buffs * Fixed horse footsteps using wrong sounds * Fixed crash whenever Marlon's name is used * Fixed NPCs end of route animation playing at double speed for clients * Fixed NPC positions not syncing at end of route animations (multiple NPCs) * Fixed extra tools spawning overnight if another player has them * Fixed gift giving not properly resetting after upgrading from 1.2 to 1.3 * Fixed mistranslated pt-br seed disc saying to plant in winter * Fixed spa sign in English while playing in Chinese * Fixed proposals unable to be canceled * Fixed fishing rod event not triggering for farmhand * Fixed machines producing 'empty' products  1.3.17 beta (7 June 2018)  * Fixed farmhands not being able to interact with bundles inside community center * Fixed farmhand tools disappearing after logging out while being upgraded * Fixed museum donations disappearing   + This also fixed the description of museum items not changing after donating for farmhands * Fixed farmhand profession sale bonuses not applying * Fixed artifact donation message appearing in English for all languages * Fixed profit margin mistranslation in German * Fixed character names appearing in English while playing non-English character languages * Fixed inability to walk through animals while inside a building * Fixed bug which could make farm animals disappear * Fixed baby gender assignment issue for player/player newborns * Added feature: Invite code now copyable to clipboard  1.3.16 beta (5 June 2018)  * Fixed 'introductions' quest tracking the wrong number of villagers for farmhands. * Fixed cabin fridges emptying when host reloads. * Fixed Secret Santa assignments changing. * Fixed items missing from festival shops when playing in Chinese. * Fixed traded fishing tackle breaking after one use. * Fixed tree seeds not being harvestable in multiplayer. * Fixed spouse position issues. * Fixed players stuck in wall after Emily's 10-heart event. * Fixed wallpapers/floors vanishing and resetting. * Fixed spawned mine ladders/shafts not being synced correctly in multiplayer. * Fixed slimes aggroing player during secret woods event. * Fixed horses becomes unmountable after entering a new location. * Fixed horses vanishing when warping between two quickly.  1.3.15 beta (30 May 2018)  * Break-up event is now less harsh. * Fixed issue where farmhands only saw the first Junimo bundles page when accessed outside of the community center. * Fixed crash upon returning to a level of the mines with a chest, after having just been in it. * Fixed machines sometimes breaking when you're near torches. * Fixed crash when attempting to load a quest that hasn't been localized yet. * Fixed monster cries being heard outside of the mines.  1.3.14 beta (25 May 2018)  * Added a quest to hint at the magnifying lens. * Re-enabled moving & demolishing buildings in multiplayer (although only the host can do it). * Fixed bug allowing players to spawn a staircase on the bottom mine level. * Fixed mermaid show not playing if volume is muted. * Fixed crash when selling many items to Pierre or through the shipping bin.  1.3.13 beta (24 May 2018)  * Added separate chests in the mines for each player. * Fixed controls locking up in Stardew Valley Fair fishing tent. * Fixed duplicate cursors in minigames. * Fixed crashes buying furniture. * Fixed freezes when fishing during events. * Fixed crash caused by ordering a building construction the day before a festival. * Fixed crash breaking certain objects in the skull cavern. * Fixed horse-related bugs with movement between screens/clipping.  1.3.12 beta (22 May 2018)  * Fixed all players seeing milking messages. * Fixed object desync on farm between players. * Fixed lighting issue in spa. * Fixed clocks becoming de-synced from server latency (now will disconnect player). * Fixed high network usage when NPCs moving. * Fixed delay when using bombs. * Fixed hidden mines ladder to skull cavern. * Fixed erroneous thunderstorm weather forecast in summer.  1.3.11 beta (16 May 2018)  * Fixed beds regenerating energy in single player. * Fixed bomb framerate/delay issues (testing some). * Fixed farmhand crash when junimo is out at the farm. * Fixed inability to use emojis while chatting when menu was up. * Fixed fishing tackle breaking after one use. * Fixed Winter 8 festival overwriting first item when playing in Chinese. * Fixed forgetting level ups when disconnected. * Fixed lost stardrop [stamina](/Energy "Energy") after disconnect. * Fixed crafting recipes vanishing when disconnected. * Fixed non-slime monsters being tracked in "Initiation" quest. * Fixed quests breaking or not tracking properly when disconnected. * Fixed weather report always sunny after reload.  1.3.10 beta (9 May 2018)  * Fixed only LAN option being available at join screen. * Fixed torch & debris related lag issues. * Fixed crash after upgrading the community center. * Fixed object at (0, 0) causing machines to be destroyed when harvesting (thanks @MysticTempest!). * Fixed forage items spawning in inaccessible places. * Fixed travelling cart 'out of stock' message. * Fixed inability to get coffee at Night Market. * Fixed crashes related to Invisible Doors. * Fixed unable to reassign farm animals to other buildings. * Fixed startup\_preferences permission crash. * Fixed objects pulse briefly when player enters map. * Fixed town map graphic inconsistencies with festivals. * Fixed treasure chests not appearing every 10 levels in mines. * Fixed spouse disappearing. * Fixed blocked path for secret note 20. * Fixed obsolescence of secret note 20 after purchasing "community upgrade". * Fixed slimes not applying "slimed" debuff. * Fixed freeze if all players are not in bed by 2am.  1.3.9 beta (4 May 2018)  * Visual C++ redistributable update to partially fix the "LAN Only" connection issue. * Fixed furniture/wallpaper/flooring getting removed from sheds. * Fixed crash when interacting with farm animals left outside.  1.3.8 beta (4 May 2018)  * Fixed glitching crab pot graphic. * Fixed lack of proper fish in underground lakes. * Fixed sprite glitch when placing wallpaper on tables or floors. * Fixed extreme lag when machines are working (using the scaling animation). * Fixed lighting related latency after 6PM. * Fixed butterfly bow position on horse. * Fixed inability to get Craft Master achievement in single player.  1.3.7 beta (3 May 2018)  * Fixed the floor appearance being set to default and becoming unchangeable. * Fixed connection issues forcing host to be inside player cabin.  1.3.6 beta (3 May 2018)  * Fixed wallpaper disappearing and not applicable. * Fixed incorrect "you have found" message display. * Fixed cabins not being movable (other buildings will be fixed in a later update). * Fixed inaccurate weather reports for connected players. * Fixed speech bubble cursor over pets/horses/children/Junimos. * Fixed Farmhands can't use hoe inside mines. * Fixed crash passing between maps while another player is on a loading screen.  1.3.5 beta (2 May 2018)  * Fixed moving cabins/buildings causing issues *in singleplayer only*. (This feature was temporarily disabled in multiplayer to troubleshoot issues.) * Fixed issue loading festivals with SMAPI installed. * Fixed the map being cut off screen. * Fixed a crash fighting flying monsters. * Fixed the bug buzzing outside mines. * Fixed the crash when swapping from tool to food and quickly eating. * Fixed the crash after leaving game at earning screen.  1.3.4 beta (1 May 2018)  * Fixed the eating prompt appearing when placing an item on a sign. * Fixed teleport obelisks not properly working. * Fixed the formatting for some Harvey dialogue. * Fixed the player getting stuck in a wall after pet adoption event. * Fixed an issue with no water in underground lakes. * Fixed an issue with building construction not completing if you exit during construction. * Fixed a crash speaking to Emily in exercise class. * Fixed a crash when speaking to Demetrius while he's dancing with Robin. * Fixed a crash at Grandpa's shrine. * Fixed a crash in certain situations if player name is within brackets. * Fixed a crash just after getting out of bed. * Fixed a crash when speaking to Traveling Merchant. * Fixed a crash on Journey of the Prairie King. * Fixed a crash when striking a ready-to-harvest cask with a tool.  1.3.3 beta (30 April 2018)  * First public 1.3 beta. |

## 1.2.33

Stardew Valley 1.2.33 was a small bugfix patch released on 10 July 2017.

Changes

:   * Fixed Linux/Mac builds distributing with MonoGame-built content instead of XNA-built content (which made modding more difficult).

## 1.2.32

Stardew Valley 1.2.32 was a small bugfix patch released on 10 July 2017.

Bug fixes

:   * [Fixed Linux install failing due to broken symlink in 1.2.31](http://community.playstarbound.com/threads/linux-steam-disk-write-error-fix.135256/).
    * Fixed save files potentially getting overwritten if you start a new file after using exit to title.

## 1.2.31

Stardew Valley 1.2.31 was a small bugfix patch released on 7 July 2017.

Bug fixes

:   * Fixed crashes related to use of slot machines.
    * Fixed some potential sources of unnecessarily increased memory usage.
    * Fixed some options in dialogue not being usable with a controller.

Localization fixes

:   * Fixed the 'loading...' message on loading screens wrapping incorrectly in some languages.
    * English: fixed grammar in [Luau](/Luau "Luau") community soup text.
    * [Portuguese](https://pt.stardewvalleywiki.com/ "pt:"): fixed some dialogue options in Linus' 0 heart event being missing.
    * [Portuguese](https://pt.stardewvalleywiki.com/ "pt:"): fixed the cut-off 'level up' title.
    * [Russian](https://ru.stardewvalleywiki.com/ "ru:"): added more space for the '(single)' text on the social page.

## 1.2.30

Stardew Valley 1.2.30 was released on 12 May 2017.

Changes

:   * The window mode preference is now shared between all save files.

Bug fixes

:   * Fixed crash when the game switches window mode while loading a save.

## 1.2.29

Stardew Valley 1.2.29 was released on 02 May 2017. (Versions 1.2.27–1.2.28 were only posted to the Steam beta channel, and are included in 1.2.29.)

Bug fixes

:   * Fixed crashes while loading save files.
    * Fixed crashes when going fullscreen.
    * Fixed crashes while saving due to slay-monster quest.

## 1.2.26

Stardew Valley 1.2.26 was [released](https://stardewvalley.net/stardew-valley-1-2-is-here/) on 24 April 2017 with in-game support for six new languages. Beta versions were [posted to the Steam beta channel](https://stardewvalley.net/stardew-valley-localization-feedback/) starting 07 February 2017.

Changes

:   * Translations for [German](https://de.stardewvalleywiki.com/ "de:"), [Spanish](https://es.stardewvalleywiki.com/ "es:"), [Brazilian Portuguese](https://pt.stardewvalleywiki.com/ "pt:"), [Russian](https://ru.stardewvalleywiki.com/ "ru:"), [Japanese](https://ja.stardewvalleywiki.com/ "ja:") and [Simplified Chinese](https://zh.stardewvalleywiki.com/ "zh:").
    * When using a controller, the cursor will snap between menu buttons by default. If you disable that, the cursor will instead accelerate while moving.
    * When using a controller, pressing the back button will skip events that are skippable.
    * "Show sharper digits" on Options menu removed.
    * Exit to Title has returned.
    * Added [panda hat](/Panda_Hat "Panda Hat") (TGP only).

Bug fixes

:   * Fixed lighting shader not covering the whole screen on Mac and Linux.
    * Switching from "Windowed Borderless" to "Fullscreen" should now go straight to fullscreen instead of Windowed mode.
    * Wallpapers and floors no longer have a tile placement indicator showing a random object.
    * Increased stability of preference-saving code. This should fix infrequent crashes that require the player to delete startup\_preferences.
    * Fixed a crash that can happen when a pig tries to spawn a truffle but there’s no space for it.
    * Fixed a couple of rare crashes that could have occurred at any time during the game.
    * Fixed a typo of the word ‘pronounce’ in the marriage event.
    * Fixed the player not getting the recipe for [Cookies](/Cookies "Cookies") if they skip [Evelyn](/Evelyn "Evelyn")'s event.
    * Fixed [farm animals](/Animals "Animals") not producing goods at high happiness.
    * Farming level now affects crop yield prior to level 10.

| **Beta Versions (1.2.0–1.2.25)** |
| --- |
| The above list shows changes compared to the previous 1.11 stable release. Here are the changes in individual beta builds: 1.2.26 beta  * Left/right gamepad controls can be used to move the color picker now (using triggers for this was unintuitive) * Fixed certain items (*e.g.,* tulips and blue jazz) having their counts rendered with an unbordered font * Fixed lack of space for energy information on certain items, including Sweet Pea * Audio is loaded earlier on in initialization now, which might resolve some startup crashes  1.2.25 beta  * Fixed broken macOS app directory structure causing crashes on launch * Reverted the change to the ordering of Steam SDK initialization and audio loading, which is believed to have caused an increase in crashes on launch for some players  1.2.21–24 beta (1.2.21–23 weren't released separately)  * Fix snappy menu controls breaking the grange display menu * Fixed a few minor issues with shop menus * Fixed the player not getting the recipe for Cookies if they skip Evelyn's event * Fixed a typo of the word 'pronounce' in the marriage event * Increased stability of preference-saving code. This should fix infrequent crashes that require the player to delete startup\_preferences * Fixed a crash that can happen when a pig tries to spawn a truffle but there's no space for it * Fixed a couple of rare crashes that could have occurred at any time during the game  1.2.19–20 beta (1.2.19 wasn't released separately)  * Fixed a few more situations where the cursor would show up unnecessarily when using a gamepad * Made the links in the about menu selectable with the gamepad * Fixed the shipping bin menu not allowing the cursor to move up within the inventory grid * The skip event button doesn't show if you're using a gamepad (use the back button to skip) * A few Chinese translation fixes  1.2.18 beta  * Fixed an issue where if you were using a gamepad and used Exit to Title, the cursor could get stuck off-screen. * Added translations for the new "use gamepad-style menus" option  1.2.17 beta  * ~7000 more characters have been added to the Chinese fonts. These aren't needed for the text in the game itself, but are expected to be relatively common in text input (*e.g.,* in the names you give your farmer, farm, animals, etc.) * Switching from "Windowed Borderless" to "Fullscreen" should now go straight to fullscreen instead of Windowed mode * Wallpapers and floors no longer have a tile placement indicator showing a random object  1.2.16 beta  * Some translation fixes for German and Chinese * Made the back button on the load game screen accessible with the new snappy gamepad cursor functionality * Fixed a minor graphical issue in the Backwoods  1.2.15 beta  * More translation fixes. * A couple more attributions have been added to the about box * Fixed the issue causing dialogue to be obscured by the cursor (when playing with a gamepad)  1.2.14 beta  * More translation fixes * Fixed duplicate tool issue when using a gamepad to buy a tool upgrade from Clint * Fixed invisible mouse cursor during some dialogs * Fixed missing poisonous food tooltips  1.2.13 beta  * Translation fixes * Improved text on main menu buttons for German, Spanish and Portuguese * Fixed event skip button not being clickable (if you've zoomed in/out far enough) * Fixed issue causing the date to be temporarily misplaced while saving (if you've zoomed in/out) * Small internal change for [Pathoschild](/User:Pathoschild "User:Pathoschild"), to help with SMAPI  1.2.12 beta  * Farming level now affect crop yield prior to level 10 * Many translation fixes in every language  1.2.11 beta  * Fixed the issue with the 'e' key backing out of menus * Some German language translation fixes * Quest text fixes * Fix the issue with the adventure guild 'Initiation' quest requiring rock crabs instead of slimes.  1.2.10 beta  * Fixed blank tooltips on animal purchase menu. * Fixed a crash when buying an animal. * Potential fix for a crash one user reported while loading a save file, as the game switched to fullscreen mode. * Fixed a threading issue that was the cause of:   + 'Waking up' in the farm house between entering bed and shipping items / saving.   + Probably the one or two crashes when sleeping / saving that people have reported * Gamepad control changes:   + Mouse cursor replaced with gloved hand when using the new snappy controls option   + Typing no longer moves the cursor around between widgets in character customization menu   + Pressing the back button organizes your inventory in the menu and in chests   + Pressing the back button skips events   + Pressing X to take an item out of a chest will no longer move the cursor back to the first item  1.2.9 beta  * New translations have been added (fixing the "Looking for Saved Games" message on the load menu always being English) * Eric's new gamepad control improvements, which make the cursor snap between buttons & other interactive components  1.2.8 beta  * Fixed missing border around item counts drawn on recipe tooltips. * Fixed a crash that sometimes occurred overnight that was dependent on your friendship levels with the NPCs. * Fixed the crash during Maru's 10 heart event. * The title screen on the Prairie King minigame no longer requires a button press. * Various internal changes.  1.2.7 beta  * Further Russian font fixes.  1.2.6 beta  * Updated Russian fonts for legibility (thanks for the feedback, it was really useful) * Fixed '+' plus signs appearing in fonts as smileys. * Reduced the size of text in some places to avoid running out of space. * Chinese title screen has 'Stardew Valley' written in Simplified Chinese. * Some Russian translation fixes.  1.2.5 beta  * Fix for misplaced text on the "help wanted" billboard * Fix for bundle pages not being closeable via the close button * Fix for the heart character not showing in some languages (in for instance "<pet name> loves you. ?") * Some minor translation fixes in Portuguese and Spanish * New fonts for Spanish, German, Portuguese and Russian (Eric added the characters we needed to his font). A few notes:   + Please provide feedback about legibility!   + Plus ('+') signs appear as smiley faces for now. We know about this and are fixing it.   + We've noticed text overlaps UI and runs out of space in a few places in German and Russian. We're working on it, but please let us know where you see this happen.  1.2.4 beta  * NPCs in Portuguese now have the same names as in English. Please be on the lookout for use of the wrong name in dialogue, UI, etc.  1.2.3 beta  * Fixed day/time/money box & buff icon positioning * Potential fix for the crash in shop interfaces * A few internal changes also happened to get us ready for more translations to come in... you probably won't notice this though ;)  1.2.2 beta  * Zoom buttons work now * Main menu no longer messed up after modifying zoom and using Exit to Title * Fixed the issue where music would play on the main menu even when muted after Exit to Title * Fixed missing 'Loading...' text in some languages * Fixed lighting shader not covering the screen on Mac and Linux  1.2.1 beta  * Fixed some instances of English text appearing instead of translated text * Fixed the issue where save files would not load if your system's language was set to something other than English (this might fix some crashes too)  1.2.0 beta  * Translations for [German](https://de.stardewvalleywiki.com/ "de:"), [Spanish](https://es.stardewvalleywiki.com/ "es:"), [Brazilian Portuguese](https://pt.stardewvalleywiki.com/ "pt:"), [Russian](https://ru.stardewvalleywiki.com/ "ru:"), [Japanese](https://ja.stardewvalleywiki.com/ "ja:") and [Simplified Chinese](https://zh.stardewvalleywiki.com/ "zh:") (and [official wiki support for these languages](http://community.playstarbound.com/threads/new-wiki-language-support.130059/)) * Exit to Title has returned * A few gamepad tweaks, *e.g.,* cursor acceleration, which were made for console versions * Many bug fixes and optimizations that were made for console versions |

## 1.11

Stardew Valley 1.11 was [released](https://steamcommunity.com/games/413150/announcements/detail/814414713570054190) 06 October 2016, with a beta [posted to the Steam beta channel](https://www.reddit.com/r/StardewValley/comments/55wswl/post11_bugs_thread/) on 05 October 2016.

Minor changes

:   * All the new farms now provide some kind of fishing opportunity, although the [riverland farm](/Farm_Maps#Riverland "Farm Maps") is still superior.
    * The riverland farm now has the potential to spawn splashing [fish](/Fish "Fish") nodes and [ore](/Blacksmith "Blacksmith") panning nodes.
    * You can place [buildings](/Carpenter%27s_Shop#Farm_Buildings "Carpenter's Shop") on most grass areas.
    * On the riverland and [forest farm maps](/Farm_Maps#Forest "Farm Maps"), some bushes can be destroyed with an upgraded [axe](/Axes "Axes").
    * [Digging spots](/Artifacts "Artifacts") now appear on [the farm](/The_Farm "The Farm"), although less frequent as elsewhere. The [hill-top quarry](/Farm_Maps#Hilltop "Farm Maps") also has a chance of spawning them.
    * The [forage](/Foraging "Foraging") berry bushes are now affected by the [Botanist](/Foraging#Foraging_Skill "Foraging") perk.
    * [Slime egg](/Slime_Egg "Slime Egg") prices increased.
    * Placing a [wicked statue](/Wicked_Statue "Wicked Statue") in a [slime hutch](/Slime_Hutch "Slime Hutch") prevents the [witch](/Random_Events#The_Witch "Random Events") from visiting it.
    * On the forest farm map, [forage](/Foraging "Foraging") items have a chance to spawn on any grassy area, not just in the west.
    * [Spouses](/Marriage "Marriage") will now speak to you when they come home on Friday nights.

Bug fixes

:   * Price of [galaxy dagger](/Galaxy_Dagger "Galaxy Dagger") has been corrected to 35,000g (it was at 350,000g).
    * The [Artisan](/Farming#Farming_Skill "Farming") Perk description has been corrected to reflect the actual bonus (it's 40% now, but the description still says 50%).
    * [Weeds](/Weeds "Weeds") in the [Mutant Bug Lair](/Mutant_Bug_Lair "Mutant Bug Lair") no longer change with the season (and no longer turn to [battery packs](/Battery_Pack "Battery Pack") in the [winter](/Winter "Winter")).
    * The Mutant Bug Lair now replenishes itself a bit each day.
    * [Monsters](/Monsters "Monsters") in the Mutant Bug Lair will now always be mutant... not revert to the standard grub/fly after saving and reloading.
    * [Meteorites](/Random_Events#Meteorite "Random Events") can no longer land on top of stumps or [boulders](/Boulder "Boulder").
    * You can once again place [buildings](/Carpenter%27s_Shop#Farm_Buildings "Carpenter's Shop") in the little-shaded strip right below cliffs.
    * Fixed some tiles on the farm maps.
    * Fixed problem with forage spawning under stumps.
    * [Spring onions](/Spring_Onion "Spring Onion") can be iridium quality with the [botanist](/Foraging#Foraging_Skill "Foraging") perk.
    * [Truffles](/Truffle "Truffle") should no longer spawn in the water.
    * [Pets](/Animals#Cat_or_Dog "Animals") should no longer be able to walk down the cellar stairs into the void.
    * The Outlaw boss in [Journey of the Prairie King](/Journey_of_the_Prairie_King "Journey of the Prairie King") will warp back to the center of the map if he happens to run too far off screen in either direction.
    * [Coop](/Coop "Coop") animals can now actually produce higher quality produce like they were supposed to.
    * Can no longer fill your [watering can](/Watering_Cans "Watering Cans") at a [well](/Well "Well") that isn't fully constructed or in construction.
    * [Trees](/Trees "Trees") can no longer spread off the map into the void, causing the game to start getting slower with each day. The new patch will retroactively remove these problem trees as well.
    * You should now properly see the final Joja cutscene, even if you switched to [JojaMart](/JojaMart "JojaMart") after completing most of the [Community Center](/Community_Center "Community Center").
    * [Forage](/Foraging "Foraging") items shouldn't spawn in inaccessible places anymore.
    * Fixed issue where [lightning](/Weather#Storm "Weather") that struck an object on the farm would cause that object to "pop" into the current map when the current map was not the farm.
    * When you reach level 5 or 10 in a skill, but haven't slept yet, it no longer shows your new profession as "[Desperado](/Combat#Combat_Skill "Combat")".
    * Minor convenience adjustments and bug fixes.

## 1.1

Stardew Valley 1.1 was [released](https://stardewvalley.net/stardew-valley-v1-1-changelog/) 3 October 2016, with a beta [posted to the Steam beta branch](http://community.playstarbound.com/threads/1-1-beta-thread.124827/) on 29 September 2016.

[Marriage candidates](/Marriage "Marriage")

:   * Marriage candidates now have an outdoor area on the farm that is unique for most spouses, and sometimes spend time out there, usually doing a unique behavior.
      + [Sam](/Sam "Sam") has a little halfpipe and he does skateboard tricks.
      + [Maru](/Maru "Maru") has a little gadget that she works on.
      + [Abigail](/Abigail "Abigail") plays her flute.
      + [Leah](/Leah "Leah") has a sculpture to carve.
      + [Sebastian](/Sebastian "Sebastian") works on his bike.
      + [Alex](/Alex "Alex") lifts weights.
      + [Penny](/Penny "Penny"), [Harvey](/Harvey "Harvey"), and [Elliott](/Elliott "Elliott") read a book in a little potted plant garden.
      + [Emily](/Emily "Emily") meditates in a crystal garden.
      + [Haley](/Haley "Haley") takes pictures between two potted palm trees.
      + [Shane](/Shane "Shane") has a little chicken hutch, and he stands by it holding his chicken "Charlie".
    * [Shane](/Shane "Shane") can be married and has new dialogue, scheduling and heart events. There's a new door for [Shane](/Shane "Shane") in [Marnie](/Marnie "Marnie")'s shop which is locked. Shane's "spouse room" is a mess, with a mini-fridge and a muddy path of footprints leading up to it.
    * [Emily](/Emily "Emily") can be married and has new dialogue, scheduling and heart events.

[Buildings](/Carpenter%27s_Shop#Farm_Buildings "Carpenter's Shop")

:   * Robin has a few new [buildings](/Carpenter%27s_Shop#Farm_Buildings "Carpenter's Shop") available for sale.
      + [shed](/Shed "Shed"): an empty room which players can do whatever they like with. They can decorate it the same way as their house.
      + [mill](/Mill "Mill"): lets players place [wheat](/Wheat "Wheat") in it to make [flour](/Wheat_Flour "Wheat Flour"), or [beets](/Beet "Beet") to make [sugar](/Sugar "Sugar"). One [wheat](/Wheat "Wheat") makes one [flour](/Wheat_Flour "Wheat Flour"). One [beet](/Beet "Beet") makes 3 [sugars](/Sugar "Sugar"). When they place [wheat](/Wheat "Wheat") or [beets](/Beet "Beet") inside, the [flour](/Wheat_Flour "Wheat Flour") or [sugar](/Sugar "Sugar") will be ready the next morning. The little box on the right side of the mill acts like a chest and it will contain any product that has been milled the previous day.
    * The wizard now offers [new farm buildings](/Wizard%27s_Tower "Wizard's Tower") after completing a quest line. These buildings are very expensive and intended for end-game. They'll appear instantly after purchase, unlike [Robin](/Robin "Robin")'s buildings which require construction.
      + [Junimo hut](/Junimo_Hut "Junimo Hut"): [Junimos](/Junimos "Junimos") will come out to harvest any mature [crops](/Crops "Crops") within a certain distance of the hut. The [Junimos](/Junimos "Junimos") will place the [crops](/Crops "Crops") they harvest in the hut for players to grab at their leisure.
      + [Water obelisk](/Water_Obelisk "Water Obelisk"): when interacted with, it warps players to [the beach](/The_Beach "The Beach"), exactly like the beach warp totem. It's basically an infinite totem that lives on the farm.
      + [Earth obelisk](/Earth_Obelisk "Earth Obelisk"): just like the water obelisk except it warps players to the mountains.
      + [Gold clock](/Gold_Clock "Gold Clock"): prevents debris from appearing on your farm. Keeps fences from decaying.

[Farm maps](/Farm_Maps "Farm Maps")

:   * There are now five farm maps to choose from when starting a new game. The basic map that exists currently, as well as a new map themed around each "[skill](/Skills "Skills")". Each special map has a feature that makes it a little different, and each map also comes with unique decorations inside the players house.
      + Riverlands: lots of water on this map... limiting your farm space. Looks nice. [Fishing](/Fishing "Fishing") is actually viable on this farm... In fact, players can catch the same [fish](/Fish "Fish") that are available in [town](/Pelican_Town "Pelican Town").
      + Forest: the forest encroaches on the land, limiting farming space. However, there are renewable stumps on the east edge of the map, and seasonal [forage](/Foraging "Foraging") items spawn there as well. Also, there is a new type of "weed" that spawns on the farm, which looks unique and will always drop [mixed seeds](/Mixed_Seeds "Mixed Seeds") when cut.
      + Hill-top: lots of cliffs... and there is a special [mining](/Mining "Mining") area in the southwest where ore will spawn, as well as unique [geode](/Geode "Geode")-bearing stones.
      + Wilderness: lots of space to farm, looks a little more interesting than the basic farm with a large lake in the southwest corner, and a cliff along the east and south. On this map, [bats](/Bats "Bats") and golems will come out at night. There is a new monster called a [wilderness golem](/Wilderness_Golem "Wilderness Golem") which is unique to this map. It behaves just like the [stone golem](/Stone_Golem "Stone Golem"), but has different drops. Its stats scale with player [combat](/Combat "Combat") level.

Farm

:   * Added [coffee beans](/Coffee_Bean "Coffee Bean"), which can be used to brew [coffee](/Coffee "Coffee").
    * Added a new [farmhouse](/Farmhouse "Farmhouse") upgrade which adds a [cellar](/Farmhouse#Upgrades "Farmhouse").
    * Added [casks](/Cask "Cask"), which can be used to age alcohol and cheese to higher quality and value. This includes a new iridium quality, which doubles the value of the base item.
    * Fruit trees can now produce iridium-quality fruit. The fruit trees increase quality by 1 star per year of age after reaching maturity.

Divorce

:   * Players can now divorce their spouse by filing in a little book inside the mayor's house.
    * After divorce, your spouse moves out and returns to their old life, but any children will stay.
    * After divorce, ex-spouses are less friendly toward the player and have unique 'rejected' dialogue.
    * Using the Dark Shrine of Memory in the [Witch's Hut](/Witch%27s_Hut "Witch's Hut") will erase the ex-spouses memory, making it seem like you had never been married.

Other new content

:   * [Return scepter](/Return_Scepter "Return Scepter") now sold by Krobus in the sewer for 2,000,000g. This item acts like a permanent warp totem to the farm. You can use it any time to warp back to the farm.
    * Two new fish can be caught in the wild: [slimejack](/Slimejack "Slimejack") ([Mutant Bug Lair](/Mutant_Bug_Lair "Mutant Bug Lair")) and [void salmon](/Void_Salmon "Void Salmon") ([Witch's Swamp](/Witch%27s_Swamp "Witch's Swamp")).
    * Inside a new building, the [Witch's Hut](/Witch%27s_Hut "Witch's Hut") there are three new shrines:
      + Dark Shrine of Memory - Will erase a divorced spouse's memory, making it seem like you had never been married.
      + Dark Shrine of Selfishness - Allows you to turn your children into doves (Gets rid of them) in exchange for a [prismatic shard](/Prismatic_Shard "Prismatic Shard").
      + Dark Shrine of Night Terrors - Allows you to toggle having monsters spawn on your farm in exchange for a [strange bun](/Strange_Bun "Strange Bun").
    * There are two new [quests](/Quests "Quests") available which unlock the new [Wizard](/Wizard "Wizard") farm buildings (available after completing either the [Community Center](/Community_Center "Community Center") or [JojaMart](/JojaMart "JojaMart") goals).
      + [Dark Talisman](/Quests#Dark_Talisman "Quests") - Sends the player to a new area, the [Mutant Bug Lair](/Mutant_Bug_Lair "Mutant Bug Lair") to retrieve a powerful magical artifact.
      + [Goblin Problem](/Quests#Goblin_Problem "Quests") - Sends the player to a new area, the [Witch's Swamp](/Witch%27s_Swamp "Witch's Swamp").
    * [honey](/Honey "Honey") can now be placed inside [kegs](/Keg "Keg") to make [mead](/Mead "Mead").
    * [casks](/Cask "Cask") can now be crafted to age alcohol and cheese which increases quality.
    * [void mayonnaise](/Void_Mayonnaise "Void Mayonnaise") can now be crafted from [void eggs](/Void_Egg "Void Egg").
    * [catalogue](/Catalogue "Catalogue") - Sold by [Pierre](/Pierre%27s_General_Store "Pierre's General Store"), this expensive furniture piece allows players to purchase [wallpaper](/Wallpaper "Wallpaper") and [flooring](/Flooring "Flooring") from their home.
    * [furniture catalogue](/Furniture_Catalogue "Furniture Catalogue") - Sold by [Robin](/Robin "Robin"). Like the [catalogue](/Catalogue "Catalogue"), this can be placed at the farm and players can interact with it to purchase [furniture](/Furniture "Furniture").
    * New furniture - [anchor](/Anchor_(furniture) "Anchor (furniture)"), [bamboo mat](/Bamboo_Mat "Bamboo Mat"), [boarded window](/Boarded_Window "Boarded Window"), [bonsai tree](/Bonsai_Tree "Bonsai Tree"), [burlap rug](/Burlap_Rug "Burlap Rug"), [candle lamp](/Candle_Lamp "Candle Lamp"), [carved window](/Carved_Window "Carved Window"), [ceiling flags](/Ceiling_Flags "Ceiling Flags"), [decorative lantern](/Decorative_Lantern "Decorative Lantern"), [floor TV](/Floor_TV "Floor TV"), [green cottage rug](/Green_Cottage_Rug "Green Cottage Rug"), [hanging shield](/Hanging_Shield "Hanging Shield"), [Junimo plush](/Junimo_Plush "Junimo Plush"), [l. light string](/L._Light_String "L. Light String"), [metal window](/Metal_Window "Metal Window"), [miner's crest](/Miner%27s_Crest "Miner's Crest"), [monster danglers](/Monster_Danglers "Monster Danglers"), [monster rug](/Monster_Rug "Monster Rug"), [mystic rug](/Mystic_Rug "Mystic Rug"), [nautical rug](/Nautical_Rug "Nautical Rug"), [ornate lamp](/Ornate_Lamp "Ornate Lamp"), [ornate window](/Ornate_Window "Ornate Window"), [porthole window](/Porthole "Porthole"), [s. pine](/S._Pine "S. Pine"), [small crystal](/Small_Crystal "Small Crystal"), [tree column](/Tree_Column "Tree Column"), [woodcut rug](/Woodcut_Rug "Woodcut Rug"), [world map](/World_Map "World Map").
    * [Galaxy swords](/Galaxy_Sword "Galaxy Sword"), [galaxy daggers](/Galaxy_Dagger "Galaxy Dagger") and [galaxy hammers](/Galaxy_Hammer "Galaxy Hammer") are now purchasable from [Marlon](/Marlon "Marlon") once you have obtained a [galaxy sword](/Galaxy_Sword "Galaxy Sword").

Minor changes

:   * New mail messages after the player passes out from exhaustion or dies. They'll sometimes end up at [Harvey's clinic](/Harvey%27s_Clinic "Harvey's Clinic") after passing out.
    * [Strange bun](/Strange_Bun "Strange Bun") had its price and cooking ingredients adjusted.
    * Giving someone a gift on their birthday will never make your spouse jealous.
    * You can now wallpaper the little hallways in your upgraded house.
    * When you beat [Journey of the Prairie King](/Journey_of_the_Prairie_King "Journey of the Prairie King"), you can now start over in a harder mode, keeping your upgrades and coins.
    * 2 new "Lost Books" to collect for the [library](/Museum "Museum").
    * You can now choose to color your [chests](/Chest "Chest") with one of 20 color options.
    * NPC's now appreciate quality level in gifts, but it only has an effect on gifts they "like" or "love".
    * You can now move your buildings via [Robin](/Robin "Robin")'s construction menu.
    * [Krobus](/Krobus "Krobus") now sells [void eggs](/Void_Egg "Void Egg").
    * [Slime balls](/Slime_Ball "Slime Ball") now have a chance to drop [petrified slime](/Petrified_Slime "Petrified Slime").
    * When paused, the time now blinks from black to gray, to black.
    * Added a graphics option to display "sharper" stack number digits.
    * [Kegs](/Keg "Keg") no longer require [clay](/Clay "Clay") to craft.
    * You can once again plant fruit trees around the edge of the [greenhouse](/Greenhouse "Greenhouse") interior.
    * After seeing [Shane](/Shane "Shane")'s 8-heart event, each chicken you purchase from [Marnie](/Marnie "Marnie") has a 25% chance of being blue. Aside from appearance, the [blue chicken](/Chicken#Blue_Chickens "Chicken") is identical to the white chicken.
    * [Sunflower seeds](/Sunflower_Seeds "Sunflower Seeds") can now be purchased and planted in [summer](/Summer "Summer") in addition to [fall](/Fall "Fall").

Balance changes

:   * All [animal](/Animals "Animals") products are increased in value by 25% (rounded up to the nearest 5g)
    * The [Rancher](/Farming#Farming_Skill "Farming") profession now increases the value of animal products by 20%, up from 10%
    * The [Artisan](/Farming#Farming_Skill "Farming") profession now increases the value of Artisan goods by 40%, down from 50%
    * The [Blacksmith](/Skills "Skills") profession now increases the value of metal bars by 50%, up from 25%
    * The value of [blueberry](/Blueberry "Blueberry") is now 50g, down from 80g
    * The value of [starfruit](/Starfruit "Starfruit") is now 750g, down from 800g
    * The value of [cranberry](/Cranberries "Cranberries") is now 75g, down from 130g
    * The value of [ancient fruit](/Ancient_Fruit "Ancient Fruit") is now 550g, down from 750g
    * [Cranberry sauce](/Cranberry_Sauce "Cranberry Sauce") has had its value reduced to 120g
    * [Stuffing](/Stuffing "Stuffing") has had its value reduced to 165g
    * [Cranberry candy](/Cranberry_Candy "Cranberry Candy") has had its value reduced to 175g
    * [Blueberry tart](/Blueberry_Tart "Blueberry Tart") has had its value reduced to 150g
    * [Fruit salad](/Fruit_Salad "Fruit Salad") has had its value reduced to 450g
    * Reduced sell price of [cranberry seeds](/Cranberry_Seeds "Cranberry Seeds") to 60g

Bug fixes

:   * [Wild plums](/Wild_Plum "Wild Plum") are now labeled as [fruit](/Fruits "Fruits").
    * [Grandpa's Shrine](/The_Farm#Grandpa.27s_Shrine "The Farm") should now always properly give the reward for reaching 4 candles.
    * Fixed issue where gathering an item with the "[botanist](/Foraging#Foraging_Skill "Foraging")" profession would fail if the inventory was full, even though the gold-level item was present in the inventory.
    * [Slime charmer ring](/Slime_Charmer_Ring "Slime Charmer Ring") should now protect against [giant slimes](/Slimes#Big_Slimes "Slimes").
    * You can no longer tap a stump.
    * Fixed [Joja Warehouse](/Joja_Warehouse "Joja Warehouse") graphic issue in winter.
    * "Check action"-mapped keys should now work to attach bait to a rod.
    * Rain ambient sound should no longer play in Sandy's [Oasis](/Oasis "Oasis") under any conditions.
    * Your baby should now be properly born, even if you pass out in the mines on the eve of the birth.
    * [Moonlight Jellies](/Dance_of_the_Moonlight_Jellies "Dance of the Moonlight Jellies") engagement crash.
    * [Galaxy sword](/Galaxy_Sword "Galaxy Sword") should now be truly unloseable.
    * You can no longer lose [hay](/Animals#Food "Animals") to a hopper because you have no [silo](/Silo "Silo").
    * You can no longer plant fruit trees off the farm.
    * Typo fixes

## 1.07a

Stardew Valley 1.07a was [released](https://stardewvalley.net/stardew-valley-now-available-for-mac-linux/) on 29 July 2016.

Changes

* Added macOS and Linux compatibility.

## 1.07

Stardew Valley 1.07 was [released](http://steamcommunity.com/games/413150/announcements/detail/820027557812026939) 04 April 2016, with a beta [posted to the Steam beta channel](https://www.reddit.com/r/StardewValley/comments/4c93ns/v107_beta_branch_bugsdiscussion/) on 31 March 2016.

Gameplay

:   * Spouses now say unique dialogues during [festivals](/Festivals "Festivals") (most of the time), rather than the generic handful of dialogues.
    * Spouse stands next to you at the [Dance of the Moonlight Jellies](/Dance_of_the_Moonlight_Jellies "Dance of the Moonlight Jellies").
    * In-law dialogue... when you marry someone, their parents/relatives dialogues will change slightly to account for the change.
    * [Sam](/Sam "Sam"), [Sebastian](/Sebastian "Sebastian"), and [Abigail](/Abigail "Abigail") now go to [the saloon](/The_Stardrop_Saloon "The Stardrop Saloon") on Fridays after you marry them.
    * Spouses won't leave on rainy days, unless they have to go to work.
    * Fruit trees produce higher quality fruit as they age. (once per year, up to gold star).
    * Fruit tree harvesting now involves shaking the tree to drop the fruit.
    * Lightning strikes now have a unique effect on fruit trees.
    * Lightning is more likely to strike trees and crops, but lightning rods now have a very good chance of intercepting lightning strikes (if they aren't already processing a lightning bolt).
    * [Charcoal kiln](/Charcoal_Kiln "Charcoal Kiln") now requires 10 wood to produce 1 coal, down from 20.
    * Maxed-out friendship levels will no longer decay.
    * Added another digit to the shipping menu money counters.
    * Dying in [the mines](/The_Mines "The Mines") is less harsh: money lost caps at 5000g, rate of item loss reduced, can't lose rings or the [galaxy sword](/Galaxy_Sword "Galaxy Sword").
    * Your assigned movement keys are now used within [Journey of the Prairie King](/Journey_of_the_Prairie_King "Journey of the Prairie King").
    * You can now retrieve powerups and coins that drop on the edge of the map in [Journey of the Prairie King](/Journey_of_the_Prairie_King "Journey of the Prairie King").
    * The last two hearts are now greyed-out for marriage candidates until you give them the bouquet.
    * [Willy](/Willy "Willy") now likes most fish dishes.
    * [Adventurer's Guild](/Adventurer%27s_Guild "Adventurer's Guild") now sells monster slayer rewards after you've unlocked them (you still get the free reward).
    * Hardware mouse cursor option.

Bug fixes

:   * [Tools](/Tools "Tools") left in chests within farm buildings won't count as "missing".
    * [Poppy](/Poppy "Poppy") properly consumed in [poppyseed muffin](/Poppyseed_Muffin "Poppyseed Muffin") recipe.
    * Can no longer incorrectly "consume" trap bobbers (click to make them disappear with strange sound).
    * [Agriculturist](/Skills "Skills") profession no longer causes an extra 25% growth rate when speed-gro isn't present. Speed increase effects should now properly apply to very slow-growing crops.
    * Fixed [sunflower](/Sunflower "Sunflower") seed price at [JojaMart](/JojaMart "JojaMart").
    * Chests should no longer appear on top of your in bed after upgrading your house.
    * Item placement with the gamepad improved, and there is now an option to show an item placement indicator.
    * [Snow yams](/Snow_Yam "Snow Yam") shouldn't appear in the desert anymore.
    * [Sea cucumber](/Sea_Cucumber "Sea Cucumber") should properly appear in the fishing tab of the Shipping menu.
    * [Farm animals](/Animals "Animals") should no longer get stuck on fences placed directly to the right of the barn door.
    * Various minor bug fixes.
    * Minor changes/fixes to dialogue.

## 1.06

Stardew Valley 1.06 was [released](http://steamcommunity.com/games/413150/announcements/detail/822278032384212096) 20 March 2016.

Changes

:   * Added unique dialogues for all spouses.
    * Spouses now leave the house on Mondays.
    * Value of most animal products increased.
    * Holly is now poisonous.
    * Missing events problem shouldn't happen anymore.
    * Minor bug/grammar/graphics fixes.

## 1.051b

Stardew Valley 1.051b was [released](http://steamcommunity.com/games/413150/announcements/detail/842542556770852896) 17 March 2016.

Changes

:   * Fixed disappearing item problem. (items can still be destroyed by farm debris).
    * [Kegs](/Keg "Keg") now require [oak resin](/Oak_Resin "Oak Resin") to [craft](/Crafting "Crafting").
    * [Bee houses](/Bee_House "Bee House") now require [maple syrup](/Maple_Syrup "Maple Syrup") to craft.
    * [Tortilla](/Tortilla "Tortilla") price changed from 75g to 50g.
    * [Nautilus shell](/Nautilus_Shell "Nautilus Shell") (artifact) renamed to [nautilus fossil](/Nautilus_Fossil "Nautilus Fossil").

## 1.051

Stardew Valley 1.051 was [released](http://steamcommunity.com/games/413150/announcements/detail/842542556770852896) 12 March 2016.

Changes

:   * Fixed weird rectangle lighting problem.
    * Flooring can now be removed by bombs.
    * You can press a "menu" button (Esc or E by default) to close out of yes/no dialogues.
    * If no other function is mapped to it, the Y key will choose "yes" in a yes/no dialogue.
    * You can use the trigger buttons on a gamepad to navigate through the Community Center menu.
    * Minor fixes.
    * More secrets.

## 1.05

Stardew Valley 1.05 was [released](http://steamcommunity.com/games/413150/announcements/detail/842542556770852896) 9 March 2016, with a beta posted to the Steam beta channel on 4 March 2016.

Gameplay changes

:   * Only read if you've gotten to year 3: [Grandpa](/Grandpa "Grandpa")'s had a change of heart... he feels he's been a little too harsh with his judgements. He no longer mentions "great honors", and his dialogue is a lot softer. If he's already visited you, check his shrine for a new opportunity...
    * Restored a "lost" [Shane](/Shane "Shane") event.
    * Changed earthquake to Summer 3rd... to make it clear that it's the season change that kills crops.
    * Increased opportunities for iridium. The chance to find iridium in the [Skull Cavern](/Skull_Cavern "Skull Cavern") increases significantly every ten levels.
    * Added a zoom in/out feature to the options tab.
    * Added volume sliders for ambient sounds and footstep sounds.
    * Added snow transparency slider.
    * Added option to turn off flash effects.
    * Added lighting quality option.
    * Added [quest](/Quests "Quests") (Rat Problem) to make it clearer that you have to investigate the Community Center.

Bug fixes

:   * [Leah](/Leah "Leah")'s schedule has been fixed.
    * Spouses who have jobs won't get stuck in the bus area anymore.
    * Upgrading a house with crafted flooring should no longer cause a mess.
    * Restored more advanced NPC end-point behavior.
    * "Secret" NPC's should no longer show up on calendar until you meet them.
    * Escargot, chowder, etc. should now properly give fishing buff.
    * You now truly cannot pass the bouncer.
    * You can no longer get stuck trying to board the bus.
    * Fixed issue with invisible trees preventing interaction with tiles.
    * Dead flowers no longer affect honey.
    * You can now dance with your spouse at the Flower Dance.
    * Game should now properly pause when steam overlay is active.
    * Fixed issue where inactive window was still responding to input.
    * Fixed fertilizer prices in Pierre's shop.
    * Fixed [Fector's Challenge](/Achievements "Achievements").
    * You can now press the toolbar shortcut keys (1, 2, 3, etc. by default) to change the active slot while the inventory menu is up.
    * Iron ore nodes can no longer be removed, only destroyed.
    * The dog or cat should no longer sit on chests...
    * Spouses less likely to run away into the dark abyss.
    * Naming your child after an NPC should no longer cause issues.
    * Fixed issue where recipes would sometimes consume more ingredients than they should.
    * Fixed crashes in certain cutscenes, when certain dialogue options were chosen.
    * Many small bug and typo fixes.

## 1.04

Stardew Valley 1.04 was [released](http://steamcommunity.com/games/413150/announcements/detail/842542556760634979) 1 March 2016.

Gameplay changes

:   * Added a randomize character button to the character creation screen.
    * [Robin](/Robin "Robin") now sells crafting recipes for [wood floor](/Wood_Floor "Wood Floor"), [stone floor](/Stone_Floor "Stone Floor"), and [stepping stone path](/Stepping_Stone_Path "Stepping Stone Path").
    * Added a secret new way to modify a rare item.
    * Increased grass growth rate.
    * Increased [forage](/Foraging "Foraging") spawn possibilities, and made it much less likely for forage to spawn behind trees.
    * Reduced value of honey from 200g to 100g.
    * Raised [Clint](/Clint "Clint")'s ore prices.
    * Inventory menus now indicate which slot is the "active slot".
    * Made the [meteorite](/Random_Events#Meteorite "Random Events") look snazzier.

Bug fixes

:   * Fixed problem with swinging sword while riding a horse.
    * Fixed strange lighting behavior when holding torches.
    * Fixed problem where stone fence was spawning debris.
    * Spouse should no longer get stuck on their way to town.
    * Wild seeds now produce the proper produce when in the [greenhouse](/Greenhouse "Greenhouse").
    * Secret gift exchange should now work properly.
    * All scarecrows now give reports on their crow-scaring activity.
    * [Bouncer](/Bouncer "Bouncer") is now truly impassable.
    * Trees no longer grow directly in front of warp statues.
    * [Willy](/Willy "Willy")'s shop no longer counts as water.
    * The [meteorite](/Random_Events#Meteorite "Random Events") should no longer appear in the pond or buildings.
    * If an object is ever directly underneath you, preventing you from moving, right click to remove it.
    * [Mariner](/Fishing "Fishing") and [Luremaster](/Fishing "Fishing") professions should now work properly.
    * Tappers are now properly destroyed by bombs.
    * Fixed bathing hairstyle inconsistency.
    * Fixed various item duplication and stacking issues.
    * [Poppyseed muffin](/Poppyseed_Muffin "Poppyseed Muffin") now actually looks like a muffin.
    * Quest items should no longer disappear when you die.
    * You can no longer give quest items to the wrong person.
    * The [Skull Cavern](/Skull_Cavern "Skull Cavern") quest can no longer be completed before receiving the actual journal entry.

## 1.03

Stardew Valley 1.03 was [released](http://steamcommunity.com/games/413150/announcements/detail/842541922570612288) 28 February 2016.

Gameplay changes

:   * The [cooking](/Cooking "Cooking") menu now looks for items in your refrigerator as well as your inventory.
    * [Scarecrow](/Scarecrow "Scarecrow") range reduced to an 8 tiles radius.
    * The price of mayonnaise and other artisan animal products now increased by the rancher profession.
    * Once you [befriend](/Friendship "Friendship") someone to 2 hearts, their room is permanently unlocked, even if you go below 2 hearts again.
    * The 'auto run' option is now enabled by default.

Bug fixes

:   * Fixed duplicate item issue in the mines.
    * Ladders should no longer spawn underneath the player, locking them in place.
    * Fixed problems with the [Community Center](/Community_Center "Community Center") menu. You can now throw items down and delete them (Delete key) in the Community Center menu.
    * Fixed item quality exploit.
    * You can now throw items down while in the crafting menu.
    * If you destroy the stable, you can now rebuild it.
    * [Spa](/Spa "Spa") won't recharge you while the game is paused (*e.g.,* steam overlay up).
    * Fixed problems with the [Stardew Valley Fair](/Stardew_Valley_Fair "Stardew Valley Fair") fishing game.
    * Various stability fixes.

## 1.02

Stardew Valley 1.02 was [released](http://steamcommunity.com/games/413150/announcements/detail/842541922567273515) 27 February 2016.

Changes

:   * If you never received your pet, you will now have another opportunity.
    * When you go to sleep, the game now checks if any of your essential tools are missing. If so, they will appear next to your bed in the morning.
    * The game now properly saves on level-up nights.
    * Eating skill food and then going to bed on a level-up night works properly now.
    * Fixed problem where completing the Crafts Room while standing in certain locations causes your character to get stuck.
    * Player character should now walk correctly while in a cutscene after drinking coffee.
    * Removed an item duplication exploit.
    * Forage items should no longer spawn in the woods above the beach.
    * Fixed [crab pot](/Crab_Pot "Crab Pot") problem (again).
    * Fixed exploding armchair bug.
    * Relaxing in the spa with your menu up no longer restores energy.
    * Removed [Leah](/Leah "Leah")'s doppelganger.
    * Debris should no longer spawn in the pathway between farm & forest.
    * Fixed disappearing tapper problem.
    * Fixed a few minor graphics problems & dialogue typos.
    * Other minor issues (spoilers).
    * Tools being upgraded no longer erroneously considered "missing".
    * Clay duplication bug fixed.
    * Pet cutscene won't refer to the "cat" as a "dog" anymore.
    * [Leah](/Leah "Leah")'s 10-heart event fixed.
    * Pepper Popper recipe now requires cheese.

## 1.01

Stardew Valley 1.01 was [released](http://steamcommunity.com/games/413150/announcements/detail/842541922563290719) 26 February 2016.

Changes

:   * Fixed random crash when going to sleep after getting your pet.
    * Sound effect volume now properly applied on load.
    * The [error item](/Error_Item "Error Item") should no longer appear for sale in [the saloon](/The_Stardrop_Saloon "The Stardrop Saloon").
    * Z key is now bind-able.
    * No longer possible to exit the [Community Center](/Community_Center "Community Center") menus while holding an item.
    * Finding your first artifact from a [geode](/Minerals#Geodes "Minerals") no longer destroys remaining held geodes.
    * Mature wild crops no longer disappear on day of load.
    * [Crab pots](/Crab_Pot "Crab Pot") can now be placed and removed without issue.
    * Fixed crash when inspecting [chests](/Chest "Chest") in [the mines](/The_Mines "The Mines").
    * You can no longer place chests in the mines.
    * Tree seeds no longer incorrectly show a "Wrong Season" message.
    * Fixed some map issues.

## 1.0

Stardew Valley 1.0 was [released](https://stardewvalley.net/stardew-valley-is-now-available/) on 26 February 2016.