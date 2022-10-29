using QModManager.API.ModLoading;
using SMLHelper.V2.Handlers;
using DebugHelper.Commands;
using DebugHelper.Systems;
using UnityEngine;
using System.Reflection;

namespace DebugHelper
{
    [QModCore()]
    public static class Main
    {
        public static Config config;

        internal static AssetBundle assetBundle;

        [QModPatch()]
        public static void Patch()
        {
            config = OptionsPanelHandler.RegisterModOptions<Config>();

            ConsoleCommandsHandler.Main.RegisterConsoleCommands(typeof(PrefabCommands));
            ConsoleCommandsHandler.Main.RegisterConsoleCommands(typeof(AudioCommands));
            ConsoleCommandsHandler.Main.RegisterConsoleCommands(typeof(ColliderCommands));

            assetBundle = Helpers.LoadAssetBundleFromAssetsFolder(Assembly.GetExecutingAssembly(), "debughelper");
            DebugIconManager.Icons.LoadIcons(assetBundle);
        }

        [QModPostPatch()]
        public static void PostPatch()
        {
            DB.Setup();
        }
    }
}