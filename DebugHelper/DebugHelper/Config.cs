using SMLHelper.V2.Json;
using SMLHelper.V2.Options.Attributes;

namespace DebugHelper
{
    [Menu("DebugHelper")]
    public class Config : ConfigFile
    {
        [Slider("Debug icons scale", DefaultValue = 50f, Min = 0f, Max = 100f)]
        public float DebugIconScalePercent = 50f;
        [Toggle("3D Debug Icons")]
        public bool DebugIconsAre3D = true;

        public float DebugIconScale
        {
            get
            {
                return DebugIconScalePercent / 100f;
            }
        }
    }
}
