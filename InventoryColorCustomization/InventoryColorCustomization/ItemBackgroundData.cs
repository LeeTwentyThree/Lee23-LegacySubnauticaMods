using UnityEngine;
using SMLHelper.V2.Utility;
using System.Collections.Generic;

namespace InventoryColorCustomization
{
    internal static partial class ItemBackgroundData
    {
        public static void Initialize()
        {
            ColorChoices = new List<ColorChoice>(_defaultColorChoices);
        }

        public static List<ColorChoice> ColorChoices;

        private static ColorChoice[] _defaultColorChoices = new ColorChoice[]
        {
            new DefaultColorChoice(),
            new ColorChoice("Blue", new Color(0f, 0f, 1f)),
            new ColorChoice("Red", new Color(1f, 0f, 0f)),
            new ColorChoice("Orange", new Color(1f, 0.6f, 0f)),
            new ColorChoice("Yellow", new Color(1f, 1f, 0f))
        };

        public static BackgroundData[] BackgroundsTypes = new BackgroundData[]
        {
            new BackgroundData(CraftData.BackgroundType.Normal, "Normal"),
            new BackgroundData(CraftData.BackgroundType.Blueprint, "Blueprint"),
            new BackgroundData(CraftData.BackgroundType.PlantWater, "PlantWater"),
            new BackgroundData(CraftData.BackgroundType.PlantWaterSeed, "PlantWater"),
            new BackgroundData(CraftData.BackgroundType.PlantAir, "PlantAir"),
            new BackgroundData(CraftData.BackgroundType.PlantAirSeed, "PlantAir"),
            new BackgroundData(CraftData.BackgroundType.ExosuitArm, "ExosuitArm"),
        };

        public static ColorChoice GetColorChoice(int index)
        {
            return ColorChoices[index];
        }

        public static string[] GetColorChoiceNames(CraftData.BackgroundType backgroundType)
        {
            var colorChoicesAsString = new string[ColorChoices.Count];
            for (int i = 0; i < ColorChoices.Count; i++)
            {
                colorChoicesAsString[i] = ColorChoices[i].GetName(backgroundType);
            }
            return colorChoicesAsString;
        }

        public static BackgroundData GetBackgroundData(CraftData.BackgroundType backgroundType)
        {
            foreach (var background in BackgroundsTypes)
            {
                if (background.BackgroundType == backgroundType)
                {
                    return background;
                }
            }
            return null;
        }

        // fuck the ModOptions class, that is why I HAVE to do this
        public static int ChoiceNameToIndex(string backgroundDataID, string choiceOption)
        {
            foreach (var backgroundData in BackgroundsTypes)
            {
                if (backgroundData.ID == backgroundDataID)
                {
                    for (int i = 0; i < ColorChoices.Count; i++)
                    {
                        if (ColorChoices[i].GetName(backgroundData.BackgroundType) == choiceOption)
                        {
                            return i;
                        }
                    }
                }
            }
            return -1;
        }
    }
}
