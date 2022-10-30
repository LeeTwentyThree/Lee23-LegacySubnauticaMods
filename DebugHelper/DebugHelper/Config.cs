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

        [Slider("Debug range", DefaultValue = 35f, Min = -1f, Max = 150f, Tooltip = "Values less than 0 count as infinity.")]
        public float DebugRange = 35f;
        [Toggle("Debug lights")]
        public bool ShowLights = false;
        [Toggle("Debug sky appliers")]
        public bool ShowSkyAppliers = false;
        [Toggle("Debug FMOD emitters")]
        public bool ShowEmitters = false;
        [Toggle("Debug colliders")]
        public bool ShowColliders = false;

        public float DebugIconScale
        {
            get
            {
                return DebugIconScalePercent / 100f;
            }
        }
    }
}
