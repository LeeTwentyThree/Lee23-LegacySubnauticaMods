using QModManager.API;
using QModManager.API.ModLoading;
using HarmonyLib;
using System.Reflection;

/* Light version of DeathRun, focusing on creature aggression.
 * Credit to Cattlesquat for original code
 * Modified by Lee23
 * Not compatible with DeathRun */
[QModCore]
public static class Main
{
    [QModPatch]
    public static void Entry()
    {

        var harmony = new Harmony("Lee23.AggressiveFauna");
        harmony.PatchAll(Assembly.GetExecutingAssembly());
    }
}