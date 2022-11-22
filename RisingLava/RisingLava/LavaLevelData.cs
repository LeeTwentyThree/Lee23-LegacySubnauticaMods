using SMLHelper.V2.Json;
using SMLHelper.V2.Json.Attributes;
using System;
using System.IO;

namespace RisingLava
{
    [FileName("LavaLevelData")]
    [Serializable]
    public class LavaLevelData : SaveDataCache
    {
        public float LavaLevel;
        public float TimeLastChange;
    }
}