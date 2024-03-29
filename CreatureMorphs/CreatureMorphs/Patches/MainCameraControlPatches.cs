﻿using UnityEngine;
using HarmonyLib;

namespace CreatureMorphs.Patches
{
    [HarmonyPatch(typeof(MainCameraControl))]
    internal static class MainCameraControlPatches
    {
        private static float angleX;
        private static float angleY;

        [HarmonyPatch(nameof(MainCameraControl.Update))]
        [HarmonyPostfix]
        public static void UpdatePostfix(MainCameraControl __instance)
        {
            var morphedCreature = PlayerMorphController.main.GetCurrentMorph();
            if (morphedCreature == null || !morphedCreature.BeingControlled) return;

            var lookDelta = GameInput.GetLookDelta();
            angleX = Mathf.Clamp(angleX - lookDelta.y, -90, 90);
            angleY += lookDelta.x;

            __instance.transform.eulerAngles = new Vector3(angleX, angleY, 0f);
            __instance.transform.position = morphedCreature.transform.position + __instance.transform.forward * -morphedCreature.morph.CameraFollowDistance;
        }
    }
}
