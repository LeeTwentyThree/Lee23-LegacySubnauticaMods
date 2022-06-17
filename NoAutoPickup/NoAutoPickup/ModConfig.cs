using SMLHelper.V2.Options.Attributes;
using SMLHelper.V2.Json;

namespace NoAutoPickup
{
    [Menu("No Auto Pickup")]
    public class ModConfig : ConfigFile
    {
        [Toggle("Disable auto-pickup for Fabricator:")]
        public bool NoAutoPickup_Fabricator = true;
        [Toggle("Disable auto-pickup for Modification Station:")]
        public bool NoAutoPickup_ModificationStation = true;
        [Toggle("Disable auto-pickup for other crafting stations:", Tooltip = "Cyclops Upgrade Fabricator, Scanner Room, and Vehicle Upgrade Console")]
        public bool NoAutoPickup_Other = true;
        [Toggle("Disable auto-pickup for modded stations:", Tooltip = "WARNING: Enabling this option may lead to unexpected compatibility issues")]
        public bool NoAutoPickup_Modded = false;
    }
}
