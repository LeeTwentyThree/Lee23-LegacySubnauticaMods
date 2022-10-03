using System.Collections.Generic;

namespace InventoryColorCustomization
{
    internal static class BackgroundTypeManager
    {
        public static BackgroundType GetBackgroundType(TechType tech)
        {
            if (!initializedDictionary)
            {
                PopulateDictionary();
            }

            if (customCategorizations.TryGetValue(tech, out var category))
            {
                switch (category)
                {
                    default:
                        break;
                    case Category_Creatures:
                        return creatureBackgroundType;
                    case Category_Precursor:
                        return precursorBackgroundType;
                    case Category_Tools:
                        return toolsBackgroundType;
                    case Category_Deployables:
                        return deployablesBackgroundType;
                }
            }
            return new BackgroundType(CraftData.GetBackgroundType(tech));
        }

        private static void PopulateDictionary()
        {
            customCategorizations = new Dictionary<TechType, string>();
            foreach (var behaviour in BehaviourData.behaviourTypeList)
            {
                customCategorizations.Add(behaviour.Key, Category_Creatures);
            }
            customCategorizations.Add(TechType.PrecursorKey_Purple, Category_Precursor);
            customCategorizations.Add(TechType.PrecursorKey_Orange, Category_Precursor);
            customCategorizations.Add(TechType.PrecursorKey_Blue, Category_Precursor);
            customCategorizations.Add(TechType.PrecursorKey_White, Category_Precursor);
            customCategorizations.Add(TechType.PrecursorKey_Red, Category_Precursor);
            customCategorizations.Add(TechType.PrecursorIonCrystal, Category_Precursor);
            customCategorizations.Add(TechType.PrecursorIonPowerCell, Category_Precursor);
            customCategorizations.Add(TechType.PrecursorIonBattery, Category_Precursor);

            customCategorizations.Add(TechType.Terraformer, Category_Tools);
            customCategorizations.Add(TechType.Transfuser, Category_Tools);
            customCategorizations.Add(TechType.AirBladder, Category_Tools);
            customCategorizations.Add(TechType.Flare, Category_Tools);
            customCategorizations.Add(TechType.Flashlight, Category_Tools);
            customCategorizations.Add(TechType.Builder, Category_Tools);
            customCategorizations.Add(TechType.LaserCutter, Category_Tools);
            customCategorizations.Add(TechType.LEDLight, Category_Tools);
            customCategorizations.Add(TechType.DiveReel, Category_Tools);
            customCategorizations.Add(TechType.PropulsionCannon, Category_Tools);
            customCategorizations.Add(TechType.Welder, Category_Tools);
            customCategorizations.Add(TechType.RepulsionCannon, Category_Tools);
            customCategorizations.Add(TechType.Scanner, Category_Tools);
            customCategorizations.Add(TechType.StasisRifle, Category_Tools);
            customCategorizations.Add(TechType.Knife, Category_Tools);
            customCategorizations.Add(TechType.HeatBlade, Category_Tools);

            customCategorizations.Add(TechType.Beacon, Category_Deployables);
            customCategorizations.Add(TechType.CyclopsDecoy, Category_Deployables);
            customCategorizations.Add(TechType.Gravsphere, Category_Deployables);
            customCategorizations.Add(TechType.Constructor, Category_Deployables);
            customCategorizations.Add(TechType.Seaglide, Category_Deployables);
            customCategorizations.Add(TechType.SmallStorage, Category_Deployables);
            initializedDictionary = true;
        }

        private static bool initializedDictionary;

        private static Dictionary<TechType, string> customCategorizations;

        public const string Category_Creatures = "Creatures";
        public const string Category_Precursor = "Precursor";
        public const string Category_Tools = "Tools";
        public const string Category_Deployables = "Deployables";

        private static BackgroundType creatureBackgroundType = new BackgroundType(Category_Creatures);
        private static BackgroundType precursorBackgroundType = new BackgroundType(Category_Precursor);
        private static BackgroundType toolsBackgroundType = new BackgroundType(Category_Tools);
        private static BackgroundType deployablesBackgroundType = new BackgroundType(Category_Deployables);
    }
}
