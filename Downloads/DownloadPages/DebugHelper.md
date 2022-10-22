# DebugHelper

Added XXXXX 2022, last updated August XXXXX 2022.

### [Download Here](null)

My goal with this mod is to add as many useful commands and tools for debugging as possible to make Subnautica modding a more smooth experience. If you are a modder, feel free to contribute!

Requirements:
- [SMLHelper](https://www.nexusmods.com/subnautica/mods/113)

## Comprehensive list of features
### Commands
`spawnc [classId]` - Spawns a prefab by its ClassID. These are 36 character GUID strings, found in [this file](https://github.com/LeeTwentyThree/Lee23-SubnauticaMods/blob/main/Resources/SN1-PrefabPaths.json).

`spawnp [path]` - Spawns a prefab by its path in resources folder. These can be found on the right side of each entry in [this file](https://github.com/LeeTwentyThree/Lee23-SubnauticaMods/blob/main/Resources/SN1-PrefabPaths.json). May become obsolete with Modpocalypse.

`playsound [path] (maxDuration = 10)` - Plays an FMOD event by its path. [Here](https://github.com/LeeTwentyThree/Lee23-SubnauticaMods/blob/main/Resources/SN1-FMODEvents.txt) is a comprehensive list of all sound events in the game.

`loopsound [path] [lifetime]` - Plays a looping FMOD event by its path. The `lifetime` parameter must be set to avoid unwarranted noise pollution.

`search [distance]` - Searches for all PrefabIdentifiers within `distance` meters (based around pivot). Outputs name and TechType. This is especially useful for finding objects with RuntimeEditor.

`lookingat (hitTriggers = false)` - Returns the name of the hit collider, its parent, attached rigidbody, and entity root. Also useful for RuntimeEditor and similar tools.

`showcolliders (hitTriggers = false)` - Renders all the colliders on the object that is being looked at.

`entgal` - Spawns the entity gallery. Very unsafe!
### REPL Console Tools
This mod adds the [DB](https://github.com/LeeTwentyThree/Lee23-SubnauticaMods/blob/main/DebugHelper/DebugHelper/DB.cs) class (in the global namespace) to assist with debugging and patching at Runtime. Call these methods in the REPL console (RuntimeEditor).

`DB.Help` - Call this in a REPL console if you forget how something is done.

`Listen(MethodInfo original, bool prefix = false)` - Outputs method call information onto the screen whenever the given method is called.
- Example: Calling `DB.Listen("UniqueIdentifier.Awake")` will alert you every time an object is loaded.

`Mute(MethodInfo original)` - Stops a method from being called entirely.
  - Example: Calling `DB.Mute("Player.OnConsoleCommand_kill")` nullifies the Kill command, and it will do nothing until the game is reloaded.

`Method(string location)` - Returns a MethodInfo by its name. Valid examples of usage:
  - `"Peeper.Start"`
  - `typeof(Peeper), "Start"`
  - `"Peeper", "Start"`

All of the methods in this class have various overloads which can be viewed [here](https://github.com/LeeTwentyThree/Lee23-SubnauticaMods/blob/main/DebugHelper/DebugHelper/DB.cs).

---

### Credits

Programming done by Lee23.

### [Back to mods list](https://github.com/LeeTwentyThree/Lee23-SubnauticaMods/blob/main/Downloads/DownloadPages/ModDownloads-Subnautica.md)

---

###### [Source code for modders](null)
