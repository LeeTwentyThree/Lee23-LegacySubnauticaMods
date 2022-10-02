using UnityEngine;
using SMLHelper.V2.Utility;
using System.Collections.Generic;

namespace InventoryColorCustomization
{
    internal static partial class ItemBackgroundUtils
    {
        public static void Initialize()
        {
            ColorChoices = new List<ColorChoice>(_defaultColorChoices);
        }

        public static List<ColorChoice> ColorChoices;

        private static ColorChoice[] _defaultColorChoices = new ColorChoice[]
        {
            new DefaultColorChoice(),
            new ColorChoice("Blue", new Color(3f / 255, 211f / 255, 252f / 255)),
            new ColorChoice("Red", new Color(242f / 255, 68f / 255, 68f / 255)),
            new ColorChoice("Orange", new Color(252f / 255, 169f / 255, 3f / 255)),
            new ColorChoice("Yellow", new Color(252f / 255, 227f / 255, 3f / 255)),
            new ColorChoice("Green", new Color(88f / 255, 232f / 255, 84f / 255)),
            new ColorChoice("White", new Color(1, 1, 1)),
            new ColorChoice("Black", new Color(0, 0, 0)),
        };

        public static BackgroundData[] BackgroundsDatas = new BackgroundData[]
        {
            new BackgroundData(new BackgroundType(CraftData.BackgroundType.Normal), "Normal"),
            new BackgroundData(new BackgroundType(CraftData.BackgroundType.Blueprint), "Blueprint"),
            new BackgroundData(new BackgroundType(CraftData.BackgroundType.PlantWater), "PlantWater"),
            new BackgroundData(new BackgroundType(CraftData.BackgroundType.PlantWaterSeed), "PlantWater"),
            new BackgroundData(new BackgroundType(CraftData.BackgroundType.PlantAir), "PlantAir"),
            new BackgroundData(new BackgroundType(CraftData.BackgroundType.PlantAirSeed), "PlantAir"),
            new BackgroundData(new BackgroundType(CraftData.BackgroundType.ExosuitArm), "ExosuitArm"),

            new BackgroundData(new BackgroundType(BackgroundTypeManager.Category_Creatures), "Normal"),
            new BackgroundData(new BackgroundType(BackgroundTypeManager.Category_Precursor), "Normal"),
            new BackgroundData(new BackgroundType(BackgroundTypeManager.Category_Hybrid), "Normal"),
        };

        public static ColorChoice GetColorChoiceAtIndex(int index)
        {
            return ColorChoices[index];
        }

        public static string[] GetColorChoiceNames(BackgroundType backgroundType)
        {
            var colorChoicesAsString = new string[ColorChoices.Count];
            for (int i = 0; i < ColorChoices.Count; i++)
            {
                colorChoicesAsString[i] = ColorChoices[i].GetName(backgroundType);
            }
            return colorChoicesAsString;
        }

        public static BackgroundData GetBackgroundData(BackgroundType backgroundType)
        {
            foreach (var background in BackgroundsDatas)
            {
                if (background.BackgroundType.Equals(backgroundType))
                {
                    return background;
                }
            }
            return null;
        }

        // fuck the ModOptions class, that is why I HAVE to do this
        public static int ChoiceNameToIndex(string backgroundDataID, string choiceOption)
        {
            foreach (var backgroundData in BackgroundsDatas)
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
