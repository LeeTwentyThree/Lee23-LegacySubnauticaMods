using System;
using HarmonyLib;
using UnityEngine;
using RisingLava.Mono;

namespace RisingLava
{
    internal static class Patches
    {
        [HarmonyPatch(typeof(LiveMixin))]
        [HarmonyPatch(nameof(LiveMixin.Start))]
        internal static class LiveMixin_Start_Patch
        {
            [HarmonyPostfix]
            public static void Postfix(LiveMixin __instance)
            {
                if (!Main.EnabledInConfig)
                {
                    return;
                }
                if (Main.config.KillFish)
                {
                    __instance.gameObject.EnsureComponent<LiveMixinBurn>().lm = __instance;
                }
            }
        }

        [HarmonyPatch(typeof(Player))]
        [HarmonyPatch(nameof(Player.Start))]
        internal static class Player_Start_Patch
        {
            [HarmonyPostfix]
            public static void Postfix(Player __instance)
            {
                if (!Main.EnabledInConfig)
                {
                    return;
                }
                LavaSurface.EnsureLavaSurface();
                __instance.gameObject.EnsureComponent<LavaMove>();
                __instance.gameObject.EnsureComponent<PlayerLavaInteractions>();
                __instance.gameObject.EnsureComponent<LavaAmbientSounds>();
                LavaScreenOverlay.EnsureInstance();
            }
        }

        [HarmonyPatch(typeof(MainMenuController))]
        [HarmonyPatch(nameof(MainMenuController.Start))]
        internal static class MainMenuController_Start_Patch
        {
            [HarmonyPostfix]
            public static void Postfix()
            {
                if (!Main.EnabledInConfig)
                {
                    return;
                }
                LavaSurface.EnsureLavaSurface();
                LavaScreenOverlay.EnsureInstance();
            }
        }

        [HarmonyPatch(typeof(WaterTemperatureSimulation))]
        [HarmonyPatch(nameof(WaterTemperatureSimulation.GetTemperature))]
        [HarmonyPatch(new Type[] { typeof(float), typeof(Vector3), typeof(float) })]
        internal static class WaterTemperatureSimulation_GetTemperature_Patch
        {
            [HarmonyPrefix]
            public static void Prefix(Vector3 wsPos, ref float baseTemperature)
            {
                if (!Main.EnabledInConfig)
                {
                    return;
                }
                if (wsPos.y > Main.LavaLevel + Main.kLavaHeatHeight)
                {
                    return;
                }
                if (wsPos.y < Main.LavaLevel)
                {
                    baseTemperature = Main.kUnderlavaTemperature;
                    return;
                }
                baseTemperature += Main.kLavaTempIncrease * ((Main.kLavaHeatHeight + Main.LavaLevel - wsPos.y) / Main.kLavaHeatHeight);
            }
        }

        [HarmonyPatch(typeof(WorldForces))]
        [HarmonyPatch(nameof(WorldForces.Start))]
        internal static class WorldForces_Start_Patch
        {
            [HarmonyPostfix]
            public static void Postfix(WorldForces __instance)
            {
                if (!Main.EnabledInConfig)
                {
                    return;
                }
                if (__instance.useRigidbody != null)
                {
                    __instance.gameObject.AddComponent<FloatInLava>();
                }
            }
        }

        [HarmonyPatch(typeof(SeaMoth))]
        [HarmonyPatch(nameof(SeaMoth.Start))]
        internal static class SeaMoth_Start_Patch
        {
            [HarmonyPostfix]
            public static void Postfix(SeaMoth __instance)
            {
                if (!Main.EnabledInConfig)
                {
                    return;
                }
                __instance.gameObject.EnsureComponent<BurnInLava>();
            }
        }

        [HarmonyPatch(typeof(Exosuit))]
        [HarmonyPatch(nameof(Exosuit.Start))]
        internal static class Exosuit_Start_Patch
        {
            [HarmonyPostfix]
            public static void Postfix(Exosuit __instance)
            {
                if (!Main.EnabledInConfig)
                {
                    return;
                }
                __instance.gameObject.EnsureComponent<BurnInLava>();
            }
        }

        [HarmonyPatch(typeof(SubRoot))]
        [HarmonyPatch(nameof(SubRoot.Start))]
        internal static class SubRoot_Start_Patch
        {
            [HarmonyPostfix]
            public static void Postfix(SubRoot __instance)
            {
                if (!Main.EnabledInConfig)
                {
                    return;
                }
                if (__instance.isCyclops)
                {
                    var burn = __instance.gameObject.EnsureComponent<BurnInLava>();
                    burn.isCyclops = true;
                    burn.bottomOffset = -10f;
                }
            }
        }

        [HarmonyPatch(typeof(WBOIT))]
        [HarmonyPatch(nameof(WBOIT.UpdateMaterialShaderParameters))]
        internal static class WBOIT_UpdateMaterialShaderParameters_Patch
        {
            [HarmonyPrefix]
            public static bool Prefix(WBOIT __instance)
            {
                var mainCamera = MainCamera.camera;
                if (mainCamera == null)
                {
                    return true;
                }

                var w = __instance; // shorthand

                var cameraPos = mainCamera.transform.position;

                if (cameraPos.y > Main.LavaLevel + Main.kDistortionEffectHeight)
                {
                    return true;
                }

                if (Time.time > __instance.nextTemperatureUpdate)
                {
                    w.temperatureScalar = Main.config.HeatDistortionEffectStrength * ((Main.kDistortionEffectHeight + Main.LavaLevel - cameraPos.y) / Main.kDistortionEffectHeight);
                    w.nextTemperatureUpdate = Time.time + UnityEngine.Random.value;
                }
                if (w.temperatureScalar > 0f && w.temperatureRefractTex != null)
                {
                    if (!w.temperatureRefractEnabled)
                    {
                        w.compositeMaterial.EnableKeyword("FX_TEMPERATURE_REFRACT");
                        w.temperatureRefractEnabled = true;
                    }
                    w.compositeMaterial.SetTexture(w.temperatureTexPropertyID, w.temperatureRefractTex);
                    w.compositeMaterial.SetFloat(w.temperaturePropertyID, w.temperatureScalar);
                    return false;
                }
                if (w.temperatureRefractEnabled)
                {
                    w.compositeMaterial.DisableKeyword("FX_TEMPERATURE_REFRACT");
                    w.temperatureRefractEnabled = false;
                }
                return false;
            }
        }
    }
}