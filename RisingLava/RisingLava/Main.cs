using QModManager.API.ModLoading;
using HarmonyLib;
using SMLHelper.V2.Handlers;
using System.IO;
using System.Reflection;
using UnityEngine;

namespace RisingLava
{
    [QModCore]
    public static class Main
    {
        public static LavaConfig config = OptionsPanelHandler.Main.RegisterModOptions<LavaConfig>();

        public static Assembly assembly = Assembly.GetExecutingAssembly();

        public static AssetBundle assetBundle;

        [QModPatch]
        public static void Entry()
        {
            assetBundle = AssetBundle.LoadFromFile(Path.Combine(Path.GetDirectoryName(assembly.Location), "Assets", "risinglavaassets"));

            Harmony harmony = new Harmony("Lee23.RisingLava");
            harmony.PatchAll(assembly);

            ConsoleCommandsHandler.Main.RegisterConsoleCommands(typeof(LavaCommands));
        }

        public static bool EnabledInConfig
        {
            get
            {
                return config.EnableMod;
            }
        }

        public static float LavaLevel
        {
            get
            {
                var wm = LavaMove.main;
                if (wm != null)
                {
                    return wm.lavaLevel;
                }
                return config.LavaLevel;
            }
        }
    }
}