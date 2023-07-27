using HarmonyLib;
using QModManager.API.ModLoading;
using SMLHelper.V2.Handlers;
using UWE;

namespace GargScales
{
    [QModCore]
    public static class Mod
    {
        public static GargScalePrefab gargScale;
        [QModPatch]
        public static void Patch()
        {
            gargScale = new GargScalePrefab();
            gargScale.Patch();
            if (QModManager.API.QModServices.Main.ModPresent("ProjectAncients"))
            {
                Harmony.CreateAndPatchAll(System.Reflection.Assembly.GetExecutingAssembly(), "com.lee23.gargscales");
                if (TechTypeExtensions.FromString("IonKnife", out var ionKnifeTechType, true))
                {
                    CraftTreeHandler.AddCraftingNode(CraftTree.Type.Workbench, ionKnifeTechType);
                }
            }
        }
    }
}