# Saves

:   *For information about how the game saves progress on mobile devices, see [Mobile Saves](/Mobile_Saves "Mobile Saves").*

The game **saves** progress when the [in-game day](/Day_Cycle "Day Cycle") ends, *i.e.,* when the farmer goes to bed, collapses from exhaustion, or collapses at 2am. All progress during a day is lost if the player quits the game without ending the day. In [multiplayer](/Multiplayer "Multiplayer"), the game saves after all players click through the prompts at end of day and wake up in the morning.

Save files are tagged with the version of the game that last saved the file (*e.g.,* `<gameVersion>1.6.15</gameVersion>`). An older version of the game is not able to load a newer save file, but a *newer* version can load an older save. Once a newer version saves over an older save file (*e.g.,* when you save for the first time after the game itself was updated to a new version), the save file will be tagged with the newer version number.

A save file may be transferred to a different device family (*e.g.,* from mobile to PC) as long as the game version on the receiving device is not older than the save file's version tag. For example, a save file from a mobile device running version 1.5 can be transferred to and used on a PC running 1.6.15, but a 1.6.15 PC save file will not run on a mobile device with version 1.5.

## Save format

The saves are stored as XML files on your computer or mobile device. They're stored separately from your game, so you can safely reinstall or update the game without losing them. On PC, they're shared between different copies of the game (*e.g.,* if you buy it from both GOG and Steam).

Each save has a folder like `JonSnow_123456789`, with two main files inside it: `JonSnow_123456789` and `SaveGameInfo`. Both files are needed to load the save.

## Find your save files

Note: in multiplayer, the save is only on the main player's computer.

### Windows

1. Press Windows + R to show a 'run' dialogue box.
2. Paste this exact text:

   ```
   %appdata%\StardewValley\Saves
   ```
3. Click 'OK' to open the folder.

### Linux

The root directory for save files is specified by the XDG\_CONFIG\_HOME environment variable, which defaults to `~/.config/`

1. From *Files*, click *Go » Enter Location*.
2. Enter this exact text:

   ```
   ~/.config/StardewValley/Saves
   ```
3. Submit to open the folder.   
   If you're using the Steam flatpak, it might be at `~/.var/app/com.valvesoftware.Steam/.config/StardewValley/Saves` instead.   
   If you are using the Heroic launcher, you may find your saves at `~/.var/app/com.heroicgameslauncher.hgl/config/StardewValley/Saves/`.

### Mac

1. From *Finder*, click *Go » Go to Folder*.
2. Enter this exact text:

   ```
   ~/.config/StardewValley/Saves
   ```
3. Submit to open the folder.

### Mobile (Android)

1. Open your device's file explorer app. If your device does not come with a file explorer, you will need one that allows navigation of the internal storage, not just searching for a specific file.
2. Select the `Android/data/com.chucklefish.stardewvalley/files/saves` (version 1.5 or later) or `StardewValley` (before 1.5) folder.
3. Each subfolder inside with a name in the format of `JonSnow_123456789` is a save slot.

### Mobile (iOS)

:   1. Open the Files app.
    2. On iPhone, tap the *Browse* button on the bottom-right side of the screen. On iPad, tap the top-left button if needed to show the left sidebar menu.
    3. Under the Locations section, tap *On My iPhone/iPad*.
    4. Select the *Stardew Valley* folder.
    5. Each subfolder inside with a name like `JonSnow_123456789` is a save slot.

On iOS 12 or earlier:

Devices still on iOS 12 or earlier will need to be connected to a Mac or Windows computer to access your save files.

:   1. On Mac, Open the Finder. On Windows, [download iTunes](https://support.apple.com/en-us/HT210384) and open it. (If your device is on macOS 10.14 or earlier, open iTunes instead of the Finder.)
    2. Attach your iOS device via USB.
    3. In the Finder/iTunes, click on the device icon in the top toolbar. (If the icon isn't shown, try disconnecting and reconnecting the USB cable.) The device's page should appear.
    4. Click *File Sharing* in the menu on the left.
    5. Click *Stardew Valley* in the app list that appears.
    6. The *Stardew Valley Documents* panel shows which save files are already on your iOS device. (They appear as folders, but you can't navigate into the folders directly.)

### PS Vita

Note: Access to the Vita filesystem requires custom firmware (CFW)

1. Navigate to `ux0:/user/00/savedata/` in Vita Shell.
2. Highlight the PCSE01235 folder and press triangle.
3. Select "Open decrypted" at the top of the list.

### Nintendo Switch

Note: Access to a Switch's saves requires custom firmware (CFW)

1. Download and install [JKSV](https://github.com/J-D-K/JKSV/releases)
2. Open JKSV and navigate to Stardew Valley.
3. Select New, and call it whatever you want.
4. In either the Hekate SD card access tool or an FTP server, copy over `sd:/JKSV/Stardew Valley/NameOfTheSaveYouSaved.zip`.

## Transfer a save

### Back up or transfer between two PCs

1. [Find your save files](#Find_your_save_files).
2. Zip the entire folder that looks like `JonSnow_123456789`.
3. Share or back up that zip file.

### Android

:   Android to PC

:   :   1. [Connect the device to your PC](https://support.google.com/android/answer/9064445).
        2. Browse to the save folder in the Android internal shared storage.

        :   :   * Version 1.5 or later: `Android/data/com.chucklefish.stardewvalley/files/Saves`
                * Before version 1.5: `StardewValley`.

        1. Copy the entire save folder (the one that looks like `JonSnow_123456789`) into [your computer's saves folder](#Find_your_save_files).
        2. Remove the `.bin` file extension from all of the files in the transferred folder.

:   PC to Android

:   :   1. If you use mods, remove any custom content before transferring to mobile.
        2. [Find the save folder on your computer](#Find_your_save_files).
        3. [Connect the device to your PC](https://support.google.com/android/answer/9064445).
        4. Browse to the save folder in the Android internal shared storage.

        :   :   * Version 1.5 or later: `Android/data/com.chucklefish.stardewvalley/files/Saves`
                * Before version 1.5: `StardewValley`.

        1. * The folder won't appear if you haven't created a save on Android yet.
        2. Copy the entire save folder (the one that looks like `JonSnow_123456789`) into the saves folder on your device.
        3. If you use adb to push a save file to your phone, be sure to set read/write permissions so the game doesn't crash when you try to save at the end of the day.

### iOS

Note: On macOS 10.15 and later this iTunes feature has been moved to the Finder.

:   iOS to PC

:   :   1. [Find the saves in iTunes](#find-ios-saves).
        2. Choose the save folder in iTunes and click the 'save' button.
        3. That will save a folder containing two files (both required for the save to work).
        4. Copy the whole folder to [your computer's save location](#Find_your_save_files).

:   PC to iOS

:   :   1. If you use mods, remove any custom content before transferring to mobile.
        2. [Find the save folder on your computer](#Find_your_save_files).
        3. [Find the iOS saves in iTunes](#find-ios-saves).
        4. Copy the entire save folder (the one that looks like `JonSnow_123456789`) into the 'Stardew Valley Documents' panel in iTunes.  
           *Note: there's one folder for each save. You need to drag each of these folders into iTunes, so that the individual save folders are all in the 'root' of the 'Stardew Valley Documents' panel. You can't drag the folder containing all your save games into iTunes.*
        5. Click the 'sync' button in iTunes to synchronize your iOS device with your computer. The save should now appear in the game's Load Game menu on your device.

### Chromebook to iPhone

You will need Dropbox and Files apps on iOS and File Manager+ on Chromebook

:   :   1. Open File Manager+ and go to Cloud, then add a location and choose Dropbox and sign in
        2. Go back to Home on File Manager+ and go to Main Storage -> Android -> data -> com.chucklefish.stardewvalley -> files -> Saves. Your save should have the format JonSnow\_123456789
        3. Right click the folder and click Move, go back to home and go to Cloud and then your Dropbox, put your folder there.
        4. Sign into Dropbox on your phone then choose connect and follow the instructions on the app.
        5. Once you connect you will see the files in your Dropbox, tap the … (ellipse) and tap save to device then select Save to Files put it in an empty folder, save all the files into the folder
        6. Go to the files app and go to the folder you put all the files in, hold down in it and tap Move, then go to Browse -> On my iPhone -> Stardew Valley, put the file there
        7. You should be able to go into Stardew Valley and see the save

### PS Vita

Note: Development on the Vita release of the game [has been abandoned](/Console_Version_History#PS_Vita "Console Version History"), leaving the final Vita version as equivalent to [PC version 1.2.33 (2017)](/Version_History#1.2.33 "Version History"). As such, a Vita save may be transferred to PC/mobile, but a modern PC/mobile save file is incompatible with Vita.

:   Vita to PC/Android

:   :   1. Navigate to  [your Vita's save folder](#Find_your_save_files)
        2. Press triangle on your save folder (the one that looks like `JonSnow_123456789`) and select Copy.
        3. Navigate to `ux0:/data/`.
        4. Press triangle and select Paste.
        5. Transfer the save folder to [your PC/Android device save folder](#Find_your_save_files) via FTP or USB with Vita Shell.

:   PC/Android to Vita

:   :   1. If you use mods, remove any custom content before transferring to Vita.
        2. Find the save folder [on your PC/Android device](#Find_your_save_files) (the one that looks like `JonSnow_123456789`).
        3. Transfer your save folder to `ux0:/data/` via FTP or USB with Vita Shell.
           * **Android**: Remove the `.bin` file extension from all of the files in the transferred folder by pressing triangle and selecting Rename.
        4. Press triangle on your save folder and select Copy.
        5. Navigate to  [your Vita's save folder](#Find_your_save_files)
        6. Press triangle and select Paste.

### Nintendo Switch

Note: Access to a Switch's saves requires custom firmware (CFW)

:   Switch to PC/Android

:   :   1. Open [JKSV](https://github.com/J-D-K/JKSV) and navigate to Stardew Valley.
        2. Select New, and call it whatever you want.
        3. In either Hekate SD card access tool or an FTP server, copy over `sd:/JKSV/Stardew Valley/NameOfTheSaveYouSaved.zip`.

:   PC/Android to Switch

:   :   1. Place the PC/Android saves folder in a zip in `sd:/JKSV/Stardew Valley/`.
        2. Open [JKSV](https://github.com/J-D-K/JKSV) and navigate to Stardew Valley.
        3. It is advised to create a backup (above) before the next step.
        4. Press Y on the save you just copied over and hold A.

## Troubleshooting

### Save disappeared or doesn't load

Here's how to recover your save in most cases. (Note that save issues are almost always caused by the game itself, not mods.)

1. [Find your save files](#Find_your_save_files).
2. Recover the files:
   * If the files are still there, here are some common fixes (try one at a time):
     1. If some of the files have `_STARDEWVALLEYSAVETMP` in the name, remove that from their name and reload the game. You may need to first disable Steam cloud saves for SDV, as it can keep automatically renaming them every time you reload. To do that, go to Stardew Valley in your Steam library, click the gear icon and go to Properties, and uncheck the option to sync cloud saves.
     2. If you recently renamed or created the folder (*e.g.,* to restore a backup), make sure the folder name **exactly** matches the file that looks like `FarmName_0123456789`.
     3. Try [undoing the last save](#Undo_the_last_save).
     4. If you are on PC, ensure that the game files do not have an extension like `.bin`. If you are on Android, you may need to add the file extension `.bin`.
     5. Modded saves may not be able to load in the vanilla game, depending on the mods that were used. If you previously played with mods but are trying to launch the game in vanilla, try reinstalling SMAPI and playing a day. SMAPI will automatically clean up any custom content from your save. Note that if you still have custom items in your inventory, they will turn into blank error items and may cause issues.
   * If the files are missing but you have SMAPI installed, see [*restore a backup by SMAPI*](#Restore_a_backup_by_SMAPI).
   * If the files are there but newer game progress is missing, it's possible Steam Cloud Sync / GOG Galaxy / mobile equivalent automatically replaced your save with the version it had stored. To solve:
     1. Launch the game. (Don't load a save yet.)
     2. While the game is still running, delete your save folder and put your backup back in.
     3. Load the save.
     4. The cloud backup service will detect that the save changed while the game was running, so it'll treat that as the new version to save.
3. If the above fixes didn't help, [see this guide](https://www.stardewvalley.net/missing-corrupt-save-file-troubleshooting-guide/) or [ask for help](/Modding:Player_Guide/Troubleshooting#Ask_for_help "Modding:Player Guide/Troubleshooting"); we might be able to recover the save for you.

Note: don't keep backup folders in the saves folder, since the game will try to load them. Either move those into a different folder, or delete them.

### Undo the last save

If something went wrong, you can undo the last save.

For a save from Linux/Mac/Windows/Android:

:   1. [Find your save files](#Find_your_save_files).  
       You should see two files with an `_old` suffix in the name; if not, ask for help instead!
    2. Back up your save folder just in case.
    3. Delete `SaveGameInfo` and the file that looks like `FarmName_123456789`.
    4. Remove the `_old` suffix from `SaveGameInfo_old` and the file that looks like `FarmName_123456789_old`.

For a save from iOS:

:   1. [Find your save files](#Find_your_save_files).  
       You should see a file with an `_SVBAK` suffix in the name; if not, ask for help instead!
    2. Back up your save folder just in case.
    3. Delete the files that look like `YourName_123456789` and `YourName_123456789_SVEMERG`.
    4. Remove the `_SVBAK` suffix from the file that looks like `YourName_123456789_SVBAK`.

### Restore a backup by SMAPI

If you use the [SMAPI](https://smapi.io) modding API, the bundled `SaveBackup` mod keeps up to 10 daily backups of your saves. Even if the original save was completely deleted or corrupted, you can probably recover it from SMAPI's backup.

To restore a save backup:

1. Find your [game folder](/Modding:Player_Guide/Getting_Started#Find_your_game_folder "Modding:Player Guide/Getting Started").
2. Open the `save-backups` subfolder.
3. Unzip (or 'extract') the latest backup which has your save.
4. Copy the save folder back into [your `Saves` folder](#Find_your_save_files).

## Advanced

### Edit a save

[![](/mediawiki/images/thumb/3/38/Editing_a_save_in_Sublime_Text.png/300px-Editing_a_save_in_Sublime_Text.png)](/File:Editing_a_save_in_Sublime_Text.png)

A save file open in Sublime Text with formatted XML.

You can edit your save to fix some common issues or change your choices. **This can permanently break your save if you make a mistake; don't forget to [create a backup first](#Back_up_or_transfer_between_two_PCs).** You should also avoid automatic save editor tools, since they often break the save.

1. Install [Sublime Text](https://www.sublimetext.com/) for Linux, Mac, or Windows. (If you already have another text editor which supports XML formatting, feel free to use that instead.)
2. Install the [Package Control extension for Sublime Text](https://packagecontrol.io/installation).
3. Use the Package Control extension to install the *Indent XML* and *XPath* plugins (see [how to add plugins](https://packagecontrol.io/docs/usage)).
4. Make a backup of [your save file](#Find_your_save_files) just in case something goes wrong.
5. Open [your save file](#Find_your_save_files) (the file that looks like `Name_0123456789`) in Sublime Text.
6. Click Selection > Format > Indent XML.
7. Make any changes you want and save. (See the sections below, [this guide for changing the host of a co-op save](https://www.reddit.com/r/StardewValley/comments/8i5z1j/guide_how_to_change_hosts_of_a_multiplayer_save/), and [this guide for other changes](http://community.playstarbound.com/threads/save-file-editing-guide-for-solving-some-common-issues.110762/).)

**Tips:**

* Click an element, and press `CTRL` + `SHIFT` + `[` to collapse the whole section which contains it. This is useful when you want to ignore a large field. For example, given this text in the save file:

  ```
  <ArrayOfInt>
      <int>1981</int>
      <int>0</int>
      <int>0</int>
      <int>0</int>
      <int>0</int>
      <int>0</int>
  </ArrayOfInt>
  ```

  Click on one of the `<int>` fields and press those keys, and it will collapse into this:

  ```
  <ArrayOfInt> […]
  </ArrayOfInt>
  ```
* Click any element, and look in the status bar to see the path to where you are in the save format (like `/SaveGame/player/friendships/item[32]`).

### Duplicate a save

You can duplicate a save for testing purposes, or to explore different options without starting over.

1. [Find your save files](#Find_your_save_files).
2. Create the new save folder:
   1. Duplicate the target save folder.
   2. Rename the new folder:
      * change the name so you can recognize it in-game;
      * change the number at the end to any number that's not used by another save.
   3. Open the new folder for the next steps.
3. Prepare the new files:
   1. Delete (or apply the following steps to, if you want the backup as well) any file whose name ends with `_old` or `.back.*`.
   2. Rename the file that looks like `Name_0123456789` to match your new folder name.
4. Edit the save metadata:
   1. Open the `SaveGameInfo` file in a text editor like Notepad.
   2. Look for `<name>` on the first line. Your farmer's name should be right after that. Change it to your new name.
   3. Search for the 2nd mention of your name (ctrl+f to 'find') and change it to your new name.
5. Edit the save file:
   1. Open the file that looks like `Name_0123456789` in a text editor like Notepad.
   2. Look for `<name>` on the first line. Your farmer's name should be right after that. Change it to your new name.
   3. Search for the 2nd mention of your name (ctrl+f to 'find') and change it to your new name.
   4. Search for the old save ID (`<uniqueIDForThisGame>`, the number from the old filename). Change it to your new number.

That's it! Launch the game and check the load menu; you'll see both saves now.

### Change farm type

If you use [SMAPI](/Modding:Player_Guide/Getting_Started "Modding:Player Guide/Getting Started") (mods):
:   You can change [farm type](/Farm_Maps "Farm Maps") by loading your save in-game, then entering `set_farm_type FARM_ID_HERE` in the SMAPI console window. (You can enter `set_farm_type list` to see a list of farm type IDs.)

    That will change the farm map, but everything placed on the farm will stay where it is. You may have things in an invalid position, like trees in a lake. You can either install [Noclip Mode](https://www.nexusmods.com/stardewvalley/mods/3900) to reach things that are out of bounds, or run one of these console commands:

    | command | effect |
    | --- | --- |
    | `world_clear farm debris` | remove stones, branches, weeds, and dead crops. |
    | `world_clear farm trees` | remove non-fruit trees. |
    | `world_clear farm fruit-trees` | remove fruit trees. |
    | `world_clear farm grass` | remove tall grass. |
    | `world_clear farm everything` | remove *everything*, including placed objects. |

If you play without mods:
:   You can change [farm type](/Farm_Maps "Farm Maps") by editing your save file:

    1. [Open your save file for editing](#Edit_a_save).
    2. Search for `<whichFarm>`. The number after that open tag is the farm type.
    3. Change the number to the one you want:

       | Code | Farm Type |
       | --- | --- |
       | 0 | Standard Farm |
       | 1 | Riverland Farm |
       | 2 | Forest Farm |
       | 3 | Hilltop Farm |
       | 4 | Wilderness Farm |
       | 5 | Four Corners Farm |
       | 6 | Beach Farm |
       | 7 | Meadowlands Farm |

    That will change the farm map, but everything placed on the farm will stay where it is. You may have things in an invalid position, like trees in a lake. You can take note of what's out of bounds, then switch back to the old farm type and move them.

### Remove an NPC

You can remove an NPC from your save file (*e.g.,* to fix an NPC permanently stuck in an invalid place). If it still exists in the game data, the NPC will respawn when you reload the save file. This should be a last resort, and usually isn't needed when using SMAPI since it'll remove invalid NPCs automatically.

1. [Open your save file for editing](#Edit_a_save). Make sure you format the file for readability per those instructions.
2. Remove the NPC:
   1. Search for the NPC's default name between 'name' tags (*e.g.,* to remove Penny: `<name>Penny</name>`).
   2. Remove the entire 'NPC' section containing the line you found, starting from the previous `<NPC>` line up to and including the next `</NPC>` line.
3. *(optional)* Remove the NPC friendship data:
   1. Search for the NPC's default name between 'string' tags (*e.g.,* to remove Penny: `<string>Penny</string>`).
   2. Remove the entire 'item' section containing the line you found, starting from the previous `<item>` line up to the next `</item>` line.