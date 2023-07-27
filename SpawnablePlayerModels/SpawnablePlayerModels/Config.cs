using SMLHelper.V2.Json;
using SMLHelper.V2.Options.Attributes;
using UnityEngine;

namespace SpawnablePlayerModels
{
    [Menu("Player Wave")]
    internal class Config : ConfigFile
    {
        [Keybind("Wave Button")]
        public KeyCode WaveKey = KeyCode.O;
    }
}
