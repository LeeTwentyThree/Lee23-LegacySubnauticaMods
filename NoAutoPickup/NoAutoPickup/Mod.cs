using HarmonyLib;
using SMLHelper.V2.Handlers;
using System.Reflection;
using QModManager.API.ModLoading;

namespace NoAutoPickup
{
    [QModCore]
    public static class Mod
    {
        public static ModConfig Config { get; private set; }

        [QModPatch]
        public static void Entry()
        {
            Config = OptionsPanelHandler.Main.RegisterModOptions<ModConfig>();

            var harmony = new Harmony("Lee23.NoAutoPickup");
            harmony.PatchAll(Assembly.GetExecutingAssembly());
        }
    }
}