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

        [Slider("Debug range", DefaultValue = 35f, Min = -1f, Max = 150f, Tooltip = "Values less than 0 count as infinity. High values can be VERY slow.")]
        public float DebugRange = 35f;
        [Slider("Debug update interval", DefaultValue = 1f, Min = 1f, Max = 10f, Tooltip = "The number of seconds between debug renderers being automatically regenerated.\nIncrease this value if the debug systems are affecting framerate.")]
        public float DebugUpdateInterval = 1f;
        [Toggle("Debug lights", Tooltip = "Automatically runs the 'showlights' command.")]
        public bool ShowLights = false;
        [Toggle("Debug sky appliers", Tooltip = "Automatically runs the 'showskyappliers' command. When enabled, this option can be EXTREMELY slow.")]
        public bool ShowSkyAppliers = false;
        [Toggle("Debug FMOD emitters", Tooltip = "Automatically runs the 'showemitters' command.")]
        public bool ShowEmitters = false;
        [Toggle("Debug CreatureActions", Tooltip = "Automatically runs the 'creatureactions' command.")]
        public bool ShowCreatureActions = false;
        [Toggle("Debug LiveMixin health", Tooltip = "Automatically runs the 'showhealth' command.")]
        public bool ShowHealth = false;
        [Toggle("Debug Rigidbodies", Tooltip = "Automatically runs the 'showrigidbodies' command.")]
        public bool ShowRigidbodies = false;

        public float DebugIconScale
        {
            get
            {
                return DebugIconScalePercent / 100f;
            }
        }
    }
}
