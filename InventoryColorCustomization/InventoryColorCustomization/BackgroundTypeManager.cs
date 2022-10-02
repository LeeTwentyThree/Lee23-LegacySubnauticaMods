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
            initializedDictionary = true;
        }

        private static bool initializedDictionary;

        private static Dictionary<TechType, string> customCategorizations;
        private static Dictionary<TechType, CraftData.BackgroundType> vanillaCategorizations;

        public const string Category_Creatures = "Creatures";
        public const string Category_Precursor = "Precursor";

        private static BackgroundType creatureBackgroundType = new BackgroundType(Category_Creatures);
        private static BackgroundType precursorBackgroundType = new BackgroundType(Category_Precursor);
    }
}
