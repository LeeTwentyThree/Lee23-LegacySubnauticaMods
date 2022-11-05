using SMLHelper.V2.Options.Attributes;
using SMLHelper.V2.Json;

namespace AggressiveFauna
{
    [Menu("AggressiveFauna")]
    internal class Config : ConfigFile
    {
        internal static Config Instance { get { return Main.config; } }

        [Toggle("Changes apply during day", Tooltip = "If disabled, the settings below will not have an effect during daytime.")]
        public bool AffectDaytime = true;
        [Toggle("Changes apply during night", Tooltip = "If disabled, the settings below will not have an effect during nighttime.")]
        public bool AffectNighttime = true;
        [Slider("Detection radius multiplier", DefaultValue = 1f, Min = 0.0f, Max = 5f, Step = 0.1f, Tooltip = "The scale factor of the detection range of aggressive creatures.\nUnmodded value: 1x")]
        public float DetectionRadiusMultiplier = 3f;
        [Toggle("Detection through terrain", Tooltip = "If enabled, creatures will be able to detect you through walls.\nUnmodded value: False")]
        public bool CanSeeThroughTerrain = false;
        [Toggle("Detection through bases", Tooltip = "If enabled, creatures will be able to detect you while you're inside a base. They still can not attack the base.\nUnmodded value: False")]
        public bool CanSeeThroughBases = false;
        [Slider("Player prioritization", DefaultValue = 1f, Min = 0.0f, Max = 5f, Step = 0.1f, Tooltip = "The higher this value, the more creatures will be more likely to attack you over other targets in range.\nUnmodded value: 1x")]
        public float PlayerPrioritization = 3f;
        [Slider("Aggression multiplier", DefaultValue = 1f, Min = 0.0f, Max = 10f, Step = 0.1f, Tooltip = "General aggression multiplier. Scales the minimum aggression required for attacking.\nUnmodded value: 1x")]
        public float AggressionMultiplier = 3f;
        [Toggle("No fleeing", Tooltip = "If enabled, creatures will not flee when taking damage.\nUnmodded value: False")]
        public bool DisableFleeing = true;
        [Toggle("No fear of electricity", Tooltip = "If enabled, creatures will not flee when taking damage from electrical sources, such as perimeter defense modules.\nUnmodded value: False")]
        public bool DisableFleeingFromElectricity = true;
        [Toggle("Ignore befriending", Tooltip = "If enabled, creatures will ignore attempts to feed & befriend them.\nUnmodded value: False")]
        public bool DisableFeeding = true;
        [Toggle("No attack delay", Tooltip = "If unchecked, this setting will disable the check that stops a creature from attacking immediately after already doing so.\nUnmodded value: False")]
        public bool DisableAttackDelay = true;
        [Toggle("Attack unoccupied vehicles", Tooltip = "If enabled, creatures will be able to target vehicles that are not being piloted.\nUnmodded value: False")]
        public bool AttackUnoccupiedVehicles = true;
    }
}
