# DebugHelper

Added October 22 2022, last updated October 22 2022.

### [Download Here](https://github.com/LeeTwentyThree/Lee23-SubnauticaMods/raw/main/Downloads/DebugHelper.zip)

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

`showcolliders (hitTriggers = false)` - Renders all the colliders on the object that is being looked at. Colliders are color coded according to various factors:
- Green: Solid colliders.
- Red: Colliders attached to non-kinematic Rigidbodies.
- Blue: Colliders attached to mesh renderers.
- White: Triggers colliders.

`showallcolliders [maxRange]` - Renders all the colliders within `maxRange` meters. Calling this command also removes all previously added collider renderers.

`hidecolliders` - Destroys all collider renderers in the scene.

`entgal` - Spawns the entity gallery, which contains all prefabs in the game. Very unsafe!

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
