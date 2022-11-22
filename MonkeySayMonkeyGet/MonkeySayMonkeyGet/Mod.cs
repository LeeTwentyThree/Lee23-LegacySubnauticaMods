using HarmonyLib;
using QModManager.API.ModLoading;
using SMLHelper.V2.Handlers;
using System.Reflection;
using System.IO;
using UnityEngine;

namespace MonkeySayMonkeyGet
{
    [QModCore]
    public static class Mod
    {
        public static string LanguageModelDirPath = "Assets/model/english_small";

        public static Assembly assembly = Assembly.GetExecutingAssembly();

        public static AssetBundle assetBundle;

        public static Config config = OptionsPanelHandler.Main.RegisterModOptions<Config>();

        public static bool TestingModeActive
        {
            get
            {
                return config.EnableDebugMode;
            }
        }

        [QModPatch]
        public static void Load()
        {
            assetBundle = AssetBundle.LoadFromFile(Path.Combine(Path.GetDirectoryName(assembly.Location), "Assets", "monkeysaymonkeyget"));

            PhraseManager.Initialize();

            var harmony = new Harmony("Lee23.MonkeySayMonkeyGet");
            harmony.PatchAll(assembly);
        }
    }
}