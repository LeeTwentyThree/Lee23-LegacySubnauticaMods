using HarmonyLib;
using UnityEngine;

namespace FreecamRoll
{
    [HarmonyPatch(typeof(FreecamController))]
    internal static class FreecamControllerPatches
    {
        [HarmonyPatch(nameof(FreecamController.Update))]
        internal static void FreecamControllerUpdatePostfix(FreecamController __instance)
        {
            float rollDelta = 0;
            if (Input.GetKey(KeyCode.Q)) rollDelta = -1;
            else if (Input.GetKey(KeyCode.E)) rollDelta = 1;
            rollDelta *= Main.sensitivity;
            rollDelta *= Time.deltaTime;
            __instance.tr.localEulerAngles += new Vector3(0, 0, rollDelta);
        }
    }
}
