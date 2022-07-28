using SMLHelper.V2.Json;
using SMLHelper.V2.Options.Attributes;

namespace RisingLava
{
    [Menu("Rising Lava")]
    public class LavaConfig : ConfigFile
    {
        [Toggle(Label = "Enable Lava", Tooltip = "Uncheck this box to disable the mod.\nRESTART REQUIRED.")]
        public bool EnableMod = true;
        [Slider(Label = "Base Lava level", Tooltip = "The base level of the lava, in meters, relative to the default surface of the ocean.\nCan be changed more precisely in the mod files.\nCANNOT MODIFY WITHOUT CREATING A NEW SAVE OR USING MOD COMMANDS.", DefaultValue = 0, Min = -1700, Max = 50, Step = 10)]
        public float LavaLevel = -1700;
        [Toggle(Label = "Affects creatures", Tooltip = "Whether fish should die when below lava or not.")]
        public bool KillFish = true;
        [Toggle(Label = "Enable Auto movement", Tooltip = "If enabled, the lava level will change on its own, and will be influenced by the settings below.\nRESTART REQUIRED.")]
        public bool AutomaticChange = true;
        [Slider(Label = "Time between movements", Tooltip = "The amount of time, in seconds, between each lava level change.", DefaultValue = 60, Min = 0, Max = 600, Step = 5)]
        public float IntervalDuration = 60f;
        [Slider(Label = "Distance per movement", Tooltip = "The distance in meters that the lava will move during each change, can be positive or negative.", DefaultValue = 0, Min = -25, Max = 25, Step = 5)]
        public float IntervalChange = 0f;
        [Slider(Label = "Rise/fall speed", Tooltip = "The speed, in 1/4 meters per second, of which the lava level rises/falls.", DefaultValue = 4f, Min = 1f, Max = 16f, Step = 1f)]
        public float LavaMoveSpeed = 4f;
        [Slider(Label = "Lava level upper limit", Tooltip = "The lava can never rise above this value (in meters).", DefaultValue = -5f, Min = -100f, Max = -5f, Step = 5f)]
        public float LavaLevelMax = -5f;
        [Toggle(Label = "Disable on-screen messages", Tooltip = "Uncheck this box to disable the on screen messages that appear when typing commands.")]
        public bool DisableErrorMessages = false;
    }
}