using QModManager.API.ModLoading;
using SMLHelper.V2.Handlers;
using HarmonyLib;
using System.Reflection;
using UnityEngine;

namespace CreatureMorphs
{
    [QModCore]
    public static class Main
    {
        public static AssetBundle bundle;

        [QModPatch]
        public static void Entry()
        {
            Assembly assembly = Assembly.GetExecutingAssembly();

            bundle = Helpers.LoadAssetBundleFromAssetsFolder(assembly, "creaturemorphs");

            MorphDatabase.Setup();
            ConsoleCommandsHandler.Main.RegisterConsoleCommands(typeof(PlayerMorphController));

            new Harmony("Lee23.CreatureMorhps").PatchAll(assembly);
        }
    }
}
