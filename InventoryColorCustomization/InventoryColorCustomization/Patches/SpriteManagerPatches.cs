using HarmonyLib;
using UnityEngine.UI;

namespace InventoryColorCustomization.Patches
{
    [HarmonyPatch(typeof(SpriteManager))]
    public static class SpriteManagerPatches
    {
        // public static Atlas.Sprite GetBackground(CraftData.BackgroundType backgroundType)
        [HarmonyPatch(nameof(SpriteManager.GetBackground))] // original method gets an Atlas.Sprite for the item background
        [HarmonyPatch(new System.Type[] { typeof(CraftData.BackgroundType) })] // clarify the correct method overload
        [HarmonyPrefix()]
        public static bool SetBackgroundSpritePostfix(CraftData.BackgroundType backgroundType, ref Atlas.Sprite __result)
        {
            var backgroundData = ItemBackgroundData.GetBackgroundData(backgroundType).ID;
            if (backgroundData == null)
            {
                return true;
            }
            var choiceIndex = Main.modConfig.GetSelectedIndexForBackground(backgroundData);
            if (choiceIndex < 0) // if invalid (-1), use original background
            {
                return true;
            }
            var choice = ItemBackgroundData.GetColorChoice(choiceIndex);
            __result = choice.GetSprite(backgroundType);
            return false;
        }
    }
}