using DebugHelper.Managers;
using HarmonyLib;

namespace DebugHelper.Patches
{
    [HarmonyPatch(typeof(uGUI))]
    internal static class uGUIPatches
    {
        [HarmonyPatch(nameof(uGUI.Awake))]
        [HarmonyPostfix()]
        public static void PlayerStartPostfix()
        {
            DebugCollidersManager.CreateInstance();
        }
    }
}
