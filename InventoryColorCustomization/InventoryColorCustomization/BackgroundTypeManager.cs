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

            if (techTypeCategorizations.TryGetValue(tech, out var category))
            {
                switch (category)
                {
                    default:
                        break;
                    case Category_Creatures:
                        return creatureBackgroundType;
                    case Category_Precursor:
                        return precursorBackgroundType;
                    case Category_Hybrid:
                        return hybridBackgroundType;
                }
            }
            return new BackgroundType(CraftData.GetBackgroundType(tech));
        }

        private static void PopulateDictionary()
        {
            techTypeCategorizations = new Dictionary<TechType, string>();
            foreach (var behaviour in BehaviourData.behaviourTypeList)
            {
                techTypeCategorizations.Add(behaviour.Key, Category_Creatures);
            }
            techTypeCategorizations.Add(TechType.PrecursorKey_Purple, Category_Precursor);
            techTypeCategorizations.Add(TechType.PrecursorKey_Orange, Category_Precursor);
            techTypeCategorizations.Add(TechType.PrecursorKey_Blue, Category_Precursor);
            techTypeCategorizations.Add(TechType.PrecursorKey_White, Category_Precursor);
            techTypeCategorizations.Add(TechType.PrecursorKey_Red, Category_Precursor);
            techTypeCategorizations.Add(TechType.PrecursorIonCrystal, Category_Precursor);
            techTypeCategorizations.Add(TechType.PrecursorIonPowerCell, Category_Hybrid);
            techTypeCategorizations.Add(TechType.PrecursorIonBattery, Category_Hybrid);
            initializedDictionary = true;
        }

        private static bool initializedDictionary;

        private static Dictionary<TechType, string> techTypeCategorizations;

        public const string Category_Creatures = "Creatures";
        public const string Category_Precursor = "Precursor";
        public const string Category_Hybrid = "Hybrid";

        private static BackgroundType creatureBackgroundType = new BackgroundType(Category_Creatures);
        private static BackgroundType precursorBackgroundType = new BackgroundType(Category_Precursor);
        private static BackgroundType hybridBackgroundType = new BackgroundType(Category_Hybrid);
    }
}
