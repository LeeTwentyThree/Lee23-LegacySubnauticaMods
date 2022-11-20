using QModManager.API.ModLoading;
using HarmonyLib;
using System.Reflection;

namespace FreecamRoll
{
    [QModCore]
    public static class Main
    {
        public static float sensitivity = 160;

        [QModPatch]
        public static void Patch()
        {
            var harmony = new Harmony("Lee23.FreecamRoll");
            harmony.PatchAll(Assembly.GetExecutingAssembly());
        }
    }
}