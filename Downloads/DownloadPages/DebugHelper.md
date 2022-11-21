# DebugHelper v1.2.0

Added October 22 2022, last updated November 7 2022.

### [Download Here](https://github.com/LeeTwentyThree/Lee23-SubnauticaMods/raw/main/Downloads/DebugHelper.zip)

My goal with this mod is to add as many useful commands and tools for debugging as possible to make Subnautica modding a more smooth experience. If you are a modder, feel free to contribute!

Requirements:
- [SMLHelper](https://www.nexusmods.com/subnautica/mods/113)

## Table of contents
- [Commands](https://github.com/LeeTwentyThree/Lee23-SubnauticaMods/blob/main/Downloads/DownloadPages/DebugHelper.md#commands)
- [REPL Console Tools](https://github.com/LeeTwentyThree/Lee23-SubnauticaMods/blob/main/Downloads/DownloadPages/DebugHelper.md#repl-console-tools)

## Comprehensive list of features
### Mod options
There are several options added into the Mod Options menu to help modders, playtesters, and even the average player to discover things about the Subnautica world that were once hidden behind obscure code. Several options related to visualization of once abstract concepts are available. Most of them activate commands that are explained in the list below.
### Commands
#### Prefab commands
- `spawnc [classId]` - Spawns a prefab by its ClassID. These are 36 character GUID strings, found in [this file](https://github.com/LeeTwentyThree/Lee23-SubnauticaMods/blob/main/Resources/SN1-PrefabPaths.json).

- `spawnp [path]` - Spawns a prefab by its path in resources folder. These can be found on the right side of each entry in [this file](https://github.com/LeeTwentyThree/Lee23-SubnauticaMods/blob/main/Resources/SN1-PrefabPaths.json). May become obsolete with Modpocalypse.

- `search [distance]` - Searches for all PrefabIdentifiers within `distance` meters (based around pivot). Outputs name and TechType. This is especially useful for finding objects with RuntimeEditor.

- `entgal` - Spawns the entity gallery, which contains every prefab in the game. Very unsafe!

- `showclassids [inRange]` 📋 - Displays every ClassID on every prefab in range, through the Debug Icons system. These can be interacted with to **copy the ClassID to your clipboard** (See mod options menu).

- `hideclassids` - Hides all ClassID Debug Icons.

- `showspawninfo [inRange]` 📋 - Displays the name of all prefabs in range. When one is interacted with (See mod options menu), a constructor for a CoordinatedSpawn at the prefab's position is **copied to the clipboard**. 

- `hidespawninfo` - Hides all SpawnInfo Debug Icons.

#### Audio commands
- `playsound [path] (maxDuration = 10)` - Plays an FMOD event by its path. [Here](https://github.com/LeeTwentyThree/Lee23-SubnauticaMods/blob/main/Resources/SN1-FMODEvents.txt) is a comprehensive list of all sound events in the game.

- `ps [path] (maxDuration = 10)` - Shorthand for `playsound`.

- `loopsound [path] [lifetime]` - Plays a looping FMOD event by its path. The `lifetime` parameter must be set to avoid unwarranted noise pollution.

- `showemitters [inRange]` - Shows all FMOD emitters in range through the Debug Icons system.

- `hideemitters` - Hides FMOD emitter Debug Icons.

#### Creature commands
- `creatureactions [inRange]` - Shows the current CreatureAction on every Creature in range, through the Debug Icons system.

- `hidecreatureactions` - Hides CreatureAction Debug Icons.

#### Light commands
- `showlights [inRange]` - Displays Light components on every GameObject in range, through the Debug Icons system.

- `hidelights` - Hides Light Debug Icons.

#### LiveMixin commands
- `showhealth [inRange]` - Shows the current health on all LiveMixins in range, through the Debug Icons system.

- `hidehealth` - Hides LiveMixin Debug Icons.

#### Rigidbody commands
- `showrigidbodies [inRange]` - Displays information about every Rigidbody on every prefab in range, through the Debug Icons system.

- `hiderigidbodies` - Hides all Rigidbody Debug Icons.

#### SkyApplier commands
- `showskyappliers [inRange]` - Displays every SkyApplier on every prefab in range, through the Debug Icons system. Yellow sky appliers should be found in interior locations, while blue sky appliers are generally in exterior locations. "Outside" sky appliers that are not affected by the day/night cycle should appear dark green.

- `hideskyappliers` - Hides all SkyApplier Debug Icons.

#### Targeting commands
- `lookingat (hitTriggers = false)` - Returns the name of the hit collider, its parent, attached rigidbody, and entity root. Also useful for RuntimeEditor and similar tools.

#### Collider commands
- `showcolliders (range = 50) (hideMessage = false)` - Enables the continuous rendering of all the colliders within `maxRange` meters. A shorthand for this command is `sw_colls`.
  - Blue: Mesh colliders.
  - Green: Solid colliders with no Rigidbody present.
  - Red: Colliders attached to non-kinematic Rigidbodies.
  - White: Colliders marked as triggers.
  - Yellow: Colliders attached to kinematic Rigidbodies.

- `hidecolliders` - Cancels the `showcolliders` command and destroys all collider renderers in the scene. A shorthand for this command is `hd_colls`.

#### Player commands
- `forcewalkmode` - Calls `Player.main.SetPrecursorOutOfWater(true)`, forcing them to walk.

- `swimmode` - Calls `Player.main.SetPrecursorOutOfWater(false)`, removing them from walking mode if they had used the `forcewalkmode` command.

- `playeranimtrigger [parameter: string]` - Triggers trigger `parameter` on the player's animator.

- `playeranimbool [parameter: string] [value: true/false]` - Sets the `parameter` boolean field on the player's animator to `value`.

- `playeranimfloat [parameter: string] [value: float]` - Sets the `parameter` float field on the player's animator to `value`.

#### Miscellaneous commands
- `copyposition` 📋 - Copies a constructor for the player's current position vector to **clipboard**.

- `copyrayposition` 📋 - Copies a constructor for the position of a raycast hit (starting at the crosshair) to **clipboard**.

- `createreferencepoint` - Creates a new basic Debug Icon at the player camera position, showing its coordinates and distance to player. Useful for testing the Debug Icons system.

- `drawstar [duration] (radius = 1)` - Draws a star shape with Debug.DrawLine at the player's camera. Useful for testing the Debug Overlay system.

### REPL Console Tools
This mod adds the [DB](https://github.com/LeeTwentyThree/Lee23-SubnauticaMods/blob/main/DebugHelper/DebugHelper/DB.cs) class (in the global namespace) to assist with debugging and patching at Runtime. Call these methods in the REPL console (RuntimeEditor).

`DB.Help` - Call this in a REPL console if you forget how something is done.

`DB.Listen(MethodInfo original, bool prefix = false)` - Outputs method call information onto the screen whenever the given method is called.
- Example: Calling `DB.Listen("UniqueIdentifier.Awake")` will alert you every time an object is loaded.

`DB.Mute(MethodInfo original)` - Stops a method from being called entirely.
  - Example: Calling `DB.Mute("Player.OnConsoleCommand_kill")` nullifies the Kill command, and it will do nothing until the game is reloaded.

`DB.Method(string location)` - Returns a MethodInfo by its name. Valid examples of usage:
  - `"Peeper.Start"`
  - `typeof(Peeper), "Start"`
  - `"Peeper", "Start"`

All of the methods in this class have various overloads which can be viewed [here](https://github.com/LeeTwentyThree/Lee23-SubnauticaMods/blob/main/DebugHelper/DebugHelper/DB.cs).

---

### Credits

Programming done by Lee23. Thanks to EldritchCarMaker for testing & feedback.

### [Back to mods list](https://github.com/LeeTwentyThree/Lee23-SubnauticaMods/blob/main/Downloads/DownloadPages/ModDownloads-Subnautica.md)

---

###### [Source code for modders](https://github.com/LeeTwentyThree/Lee23-SubnauticaMods/tree/main/DebugHelper)
