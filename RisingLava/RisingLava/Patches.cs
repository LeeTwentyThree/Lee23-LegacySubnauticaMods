using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;
using System.Threading.Tasks;
using HarmonyLib;
using UnityEngine;
using System.Reflection.Emit;

namespace RisingLava
{
    internal static class Patches
    {
        [HarmonyPatch(typeof(Creature))]
        [HarmonyPatch(nameof(Creature.Start))]
        internal static class Creature_Start_Patch
        {
            [HarmonyPostfix]
            public static void Postfix(Creature __instance)
            {
                if (!Main.EnabledInConfig)
                {
                    return;
                }
                if (__instance.liveMixin == null)
                {
                    return;
                }
                if (Main.config.KillFish)
                {
                    /*var waterParkCreature = __instance.gameObject.GetComponent<WaterParkCreature>();
                    if (waterParkCreature != null)
                    {
                        if (waterParkCreature.IsInsideWaterPark())
                        {
                            return;
                        }
                    }*/
                    __instance.gameObject.AddComponent<CreatureBurn>().creature = __instance;
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
                LavaScreenOverlay.EnsureInstance();
            }
        }

        [HarmonyPatch(typeof(MainMenuController))]
        [HarmonyPatch(nameof(MainMenuController.Start))]
        internal static class MainMenuController_Start_Patch
        {
            [HarmonyPostfix]
            public static void Postfix(MainMenuController __instance)
            {
                if (!Main.EnabledInConfig)
                {
                    return;
                }
                LavaSurface.EnsureLavaSurface();
                LavaScreenOverlay.EnsureInstance();
            }
        }
    }
}