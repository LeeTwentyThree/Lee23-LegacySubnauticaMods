using HarmonyLib;

namespace MirrorWorld
{
    [HarmonyPatch(typeof(LargeWorld))]
    public static class LargeWorldPatches
    {
        [HarmonyPatch(nameof(LargeWorld.Awake))]
        [HarmonyPostfix]
        public static void AwakePostfix()
        {
            var config = Mod.config;
            FlipLogic.Flip(config.xAxis, config.yAxis, config.zAxis);
        }
    }

    [HarmonyPatch(typeof(Ocean))]
    public static class OceanPatches
    {
        [HarmonyPatch(nameof(Ocean.Awake))]
        [HarmonyPostfix]
        public static void AwakePostfix(Ocean __instance)
        {
            FlipLogic.FixOceanPosition(__instance.gameObject);
        }
    }

    [HarmonyPatch(typeof(EscapePod))]
    public static class EscapePodPatches
    {
        [HarmonyPatch(nameof(EscapePod.Awake))]
        [HarmonyPostfix]
        public static void AwakePostfix(EscapePod __instance)
        {
            __instance.gameObject.EnsureComponent<EscapePodFixer>();
        }
    }

    [HarmonyPatch(typeof(CrashedShipExploder))]
    public static class CrashedShipPatches
    {
        [HarmonyPatch(nameof(CrashedShipExploder.Start))]
        [HarmonyPostfix]
        public static void StartPostfix(CrashedShipExploder __instance)
        {
            FlipLogic.FixAuroraPosition(__instance.transform);
        }
    }
}
