using System.Collections.Generic;
using UnityEngine;

namespace InventoryColorCustomization
{
    internal class ColorChoiceManager
    {
        public static void Initialize()
        {
            ColorChoices = new List<ColorChoice>(_defaultColorChoices);
        }

        public static List<ColorChoice> ColorChoices;

        private static ColorChoice[] _defaultColorChoices = new ColorChoice[]
        {
            new DefaultColorChoice(),
            new ColorChoice("Red", new Color(242f / 255, 68f / 255, 68f / 255)),
            new ColorChoice("Orange", new Color(252f / 255, 82f / 255, 3f / 255)),
            new ColorChoice("Yellow", new Color(252f / 255, 227f / 255, 3f / 255)),
            new ColorChoice("Green", new Color(88f / 255, 232f / 255, 84f / 255)),
            new ColorChoice("Dark Green", new Color(30f / 255, 100 / 255, 40f / 255)),
            new ColorChoice("Cyan", new Color(0f, 0.83f, 0.99f)),
            new ColorChoice("Violet", new Color(0.5f, 0f, 1f)),
            new ColorChoice("White", new Color(1, 1, 1)),
            new ColorChoice("Black", new Color(0, 0, 0)),
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

        // ModOptions class is extremely limited, that is why I HAVE to do this
        public static int ChoiceNameToIndex(string backgroundDataID, string choiceOption)
        {
            foreach (var backgroundData in BackgroundDataManager.BackgroundsDatas)
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
