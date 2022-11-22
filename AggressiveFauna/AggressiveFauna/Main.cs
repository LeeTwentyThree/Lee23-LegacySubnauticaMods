using QModManager.API;
using QModManager.API.ModLoading;
using HarmonyLib;
using System.IO;
using System.Reflection;
using SMLHelper.V2.Handlers;
using UnityEngine;

/* Light version of DeathRun, focusing on creature aggression.
 * Credit to Cattlesquat for original code
 * Modified by Lee23
 * Not compatible with DeathRun */
namespace AggressiveFauna
{
    [QModCore]
    public static class Main
    {
        internal static Config config;
        internal static Assembly assembly = Assembly.GetExecutingAssembly();
        internal static AssetBundle bundle;

        [QModPatch]
        public static void Entry()
        {
            bundle = LoadAssetBundleFromAssetsFolder(assembly, "aggressivefauna");
            config = OptionsPanelHandler.RegisterModOptions<Config>();
            var harmony = new Harmony("Lee23.AggressiveFauna");
            harmony.PatchAll(assembly);
            ModAudio.PatchAudio();
        }

        private static AssetBundle LoadAssetBundleFromAssetsFolder(Assembly modAssembly, string assetsFileName)
        {
            return AssetBundle.LoadFromFile(Path.Combine(Path.GetDirectoryName(modAssembly.Location), "Assets", assetsFileName));
        }
    }
}