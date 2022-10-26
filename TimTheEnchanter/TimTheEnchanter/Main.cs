using HarmonyLib;
using QModManager.API.ModLoading;
using System.Reflection;
using UnityEngine;

namespace TimTheEnchanter
{
    public static class Main
    {
        public static AssetBundle assetBundle;

        private static Assembly assembly = Assembly.GetExecutingAssembly();
        private static Harmony harmony;

        public static void Patch()
        {
            assetBundle = Helpers.LoadAssetBundleFromAssetsFolder(Assembly.GetExecutingAssembly(), "tim");

            harmony = new Harmony("Lee23.TimTheEnchanter");
            harmony.PatchAll();
            ModAudio.PatchAudio();
        }
    }
}