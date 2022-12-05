using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HarmonyLib;

namespace CreatureMorphs.Patches
{
    [HarmonyPatch(typeof(Player))]
    internal static class PlayerPatches
    {
        [HarmonyPatch(nameof(Player.Start))]
        [HarmonyPostfix]
        public static void StartPostfix(Player __instance)
        {
            __instance.gameObject.AddComponent<PlayerMorphController>();
        }
    }
}
