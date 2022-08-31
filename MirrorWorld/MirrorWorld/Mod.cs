using HarmonyLib;
using QModManager.API.ModLoading;
using System.Reflection;
using SMLHelper.V2.Handlers;

namespace MirrorWorld
{
    [QModCore]
    public static class Mod
    {
        public static Assembly modAssembly = Assembly.GetExecutingAssembly();

        public static Config config = OptionsPanelHandler.Main.RegisterModOptions<Config>();

        [QModPatch]
        public static void Entry()
        {
            var harmony = new Harmony("Lee23.MirrorWorld");
            harmony.PatchAll(modAssembly);
        }
    }
}