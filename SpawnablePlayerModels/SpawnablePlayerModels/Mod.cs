using System.IO;
using QModManager.API.ModLoading;
using SMLHelper.V2.Handlers;
using System.Reflection;
using UnityEngine;

namespace SpawnablePlayerModels
{
    [QModCore]
    public static class Mod
    {
        internal static Config config = OptionsPanelHandler.Main.RegisterModOptions<Config>();

        internal static AssetBundle bundle;

        [QModPatch]
        public static void Patch()
        {
            Assembly assembly = Assembly.GetExecutingAssembly();
            bundle = AssetBundle.LoadFromFile(Path.Combine(Path.GetDirectoryName(assembly.Location), "Assets", "playerwave"));

            new SpawnablePlayerModel().Patch();
        }
    }
}