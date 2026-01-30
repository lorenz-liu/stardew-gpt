# Mobile Saves

:   *For save file locations, methods of saving on PC and consoles, and save file editing documentation see [Saves](/Saves "Saves").*
:   *To find mobile saves, see [android saves](/Saves#Mobile_.28Android.29 "Saves") or [iOS saves](/Saves#Mobile_.28iOS.29 "Saves").*

On mobile, Stardew Valley's save method is based upon the system used for computers, but with some additions to make it more suited to mobile devices.

The game creates a folder on the device for each saved game. In that folder, there are three different kinds of save files which can appear - Standard Saves, Emergency Saves and Backup saves.

## Standard Saves

Standard Saves are the same format found on the PC version of the game. The PC version only allows saving when going to sleep, so standard saves retain this system. A standard save always starts at 6am in the morning when loaded. These saves are compatible with PC, and can be transferred back and forth.

When a standard save happens, the mobile version (like PC) keeps your previous standard save, using the suffix ‘\_old’. Occasionally, save files might encounter problems. If this happens, players can swap between the most recent standard save and the previous backup by pressing the ‘Swap to previous save’ button on the Options page.

## Emergency Saves

Unlike a PC, a mobile device can sometimes interrupt the game - for example, if a phone call happens mid-game. Also, players may change to another app, and want to resume where they left off in the game later on. When the app is no longer shown on the screen, it is classed as being a ‘background’ app. If the phone or tablet is running low on resources, it might automatically unload any background apps, losing any unsaved progress.

If the game moves into the background, and then resumed, if the app hasn’t been unloaded by the phone/tablet, it will continue where it left off. If the game has been unloaded, however, the game will be reloaded, and will then need to load a save in order to carry on where it left off. To allow this, the game does an ‘emergency save’ when it goes into the background (for example, when you press the home button on an iPhone). Because of the complexity of Stardew Valley, this save takes a few seconds. If you ‘kill’ the app before this save is completed (by swiping it away from the list of background apps), the game will not complete its emergency save.

Note: If the game time is less than 6:20am, no emergency saves are created because the standard 6am save is assumed to be sufficient.

When the game loads up, it checks to see if there’s a file called EMERGENCY\_SAVE present. If there is, it looks in that file to find the location of the most recent emergency save. If it finds one, the player is asked "Would you like to restore from where you previously left off?" when the main menu loads, allowing the player to load the emergency save.

The game does not delete emergency saves once they've been loaded. Instead, the emergency saves will be deleted only when the game saves either a standard or backup save. Only one emergency save exists per device (*i.e.,* the emergency save is not associated with a specific game ID / character).

## Backup Saves

At any time (other than during certain festivals, cutscenes and other events), players can manually save the game with the ‘Save Backup’ button on the options page. This saves progress as a backup file, using the same format as an emergency save, except associated with a specific game ID. The game time in a backup save is always the start of the next ten-minute interval.

When selecting a game to load, if a backup file exists the player is asked "Would you like to restore from where you previously left off?". Selecting "Yes" causes the backup file to be loaded; selecting "No" loads the standard 6am save.

Only one backup save can exist per game ID; a new backup save overwrites any previous backup for that game ID. Backup saves are automatically deleted when a new standard save is created for the game ID (*i.e.,* overnight, after any level up dialogs and shipping reports). They are not deleted, however, when an emergency save is created.

In order to maintain compatibility with the PC version, the game needs to keep the standard save to be the 6am morning save. But, the PC version isn’t compatible with the concept of loading/saving anywhere/any time, so that's why these multiple systems are supported.

## Notes

Some game details are not stored in Backup Saves or Emergency Saves, leading to slight differences in game play after reloading from one of these saves. Known differences include:

* Any unaccepted quest at the [Help Wanted](/Quests#Help_Wanted_Quests "Quests") board is lost.
* Any active Fishing [Bubbles](/Fishing#Bubbles "Fishing") or [Panning](/Pans "Pans") locations are lost. However, ones that were scheduled to start later in the day will still happen.
* Active [buffs](/Buffs "Buffs") are always lost.
* All water troughs in [Slime Hutches](/Slime_Hutch "Slime Hutch") are emptied, preventing [Slime Balls](/Slime_Ball "Slime Ball") from spawning the next day.

## History

* [1.6](/Version_History#1.6 "Version History"): Fixed all unintended bugs with buffs caused by loading a save.