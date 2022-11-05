using QModManager.API;
using QModManager.API.ModLoading;
using HarmonyLib;
using System.Reflection;
using SMLHelper.V2.Handlers;

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

        [QModPatch]
        public static void Entry()
        {
            config = OptionsPanelHandler.RegisterModOptions<Config>();
            var harmony = new Harmony("Lee23.AggressiveFauna");
            harmony.PatchAll(Assembly.GetExecutingAssembly());
        }
    }
}