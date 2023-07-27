using HarmonyLib;
using RotA.Mono.Creatures.GargEssentials;
using RotA.Mono.Equipment;
using UnityEngine;

namespace GargScales
{
    [HarmonyPatch]
    internal static class Patches
    {
        [HarmonyPostfix()]
        [HarmonyPatch(typeof(IonKnife), "OnSwing")]
        public static void OnToolUseAnimPostfix(IonKnife __instance, LiveMixin lm, GameObject hitGo)
        {
            if (hitGo == null)
            {
                return;
            }
            if (hitGo.GetComponent<GargantuanBehaviour>() == null)
            {
                return;
            }
            var scale = CraftData.InstantiateFromPrefab(Mod.gargScale.TechType);
            scale.transform.position = __instance.transform.position + MainCamera.camera.transform.forward;
        }
    }
}