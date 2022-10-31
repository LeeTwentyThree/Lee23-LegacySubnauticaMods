using SMLHelper.V2.Json;
using SMLHelper.V2.Options.Attributes;
using UnityEngine;

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
        [Toggle("Debug rigidbodies", Tooltip = "Automatically runs the 'showrigidbodies' command.")]
        public bool ShowRigidbodies = false;
        [Toggle("Show damage numbers", Tooltip = "If enabled, shows information whenever a LiveMixin takes damage.")]
        public bool ShowDamageInfo = false;
        [Toggle("Hide small damage numbers", Tooltip = "If enabled, damage numbers of less than 0.1 will be hidden.")]
        public bool HideSmallDamageNumbers = true;
        [Toggle("Show ClassIDs", Tooltip = "Automatically runs the 'showclassids' command.")]
        public bool ShowClassIDs = false;
        [Toggle("Generate SpawnInfo", Tooltip = "Automatically runs the 'showspawninfo' command.")]
        public bool ShowSpawnInfo = false;

        [Keybind("Interact with Debug Icons (1)", Tooltip = "Both of these binds must be activated at once to interact.")]
        public KeyCode InteractWithDebugIconKey1 = KeyCode.Mouse0;
        [Keybind("Interact with Debug Icons (2)", Tooltip = "Both of these binds must be activated at once to interact.")]
        public KeyCode InteractWithDebugIconKey2 = KeyCode.LeftShift;

        public float DebugIconScale
        {
            get
            {
                return DebugIconScalePercent / 100f;
            }
        }
    }
}
