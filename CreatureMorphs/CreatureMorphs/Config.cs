using SMLHelper.V2.Json;
using SMLHelper.V2.Options.Attributes;
using UnityEngine;

namespace CreatureMorphs
{
    [Menu("Creature Morphs")]
    public class Config : ConfigFile
    {
        [Keybind(Label = "Open Morph Menu")]
        public KeyCode OpenMorphMenu = KeyCode.M;
    }
}