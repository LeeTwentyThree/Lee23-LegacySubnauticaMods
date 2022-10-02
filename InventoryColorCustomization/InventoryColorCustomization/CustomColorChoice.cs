using UnityEngine;

namespace InventoryColorCustomization
{
    internal class CustomColorChoice : ColorChoice
    {
        public CustomColorChoice() : base("Default", Color.white)
        {
        }

        public override string GetName(CraftData.BackgroundType backgroundType)
        {
            switch (backgroundType)
            {
                case CraftData.BackgroundType.Normal:
                    return "Default (blue)";
                case CraftData.BackgroundType.Blueprint:
                    return "Default (purple)";
                case CraftData.BackgroundType.PlantWater:
                    return "Default (blue)";
                case CraftData.BackgroundType.PlantWaterSeed:
                    return "Default (blue)";
                case CraftData.BackgroundType.PlantAir:
                    return "Default (green)";
                case CraftData.BackgroundType.PlantAirSeed:
                    return "Default (green)";
                case CraftData.BackgroundType.ExosuitArm:
                    return "Default (purple)";
                default:
                    return "Unknown";
            }
        }

        public override Atlas.Sprite GetSprite(CraftData.BackgroundType backgroundType)
        {
            return null;
        }
    }
}
