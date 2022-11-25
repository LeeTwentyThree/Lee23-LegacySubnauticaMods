using HarmonyLib;
using QModManager.API.ModLoading;
using System.Reflection;
using UnityEngine;

namespace DeadWorld
{
    [QModCore]
    public static class Main
    {
        [QModPatch]
        public static void Patch()
        {
            new Harmony("Lee23.DeadWorld").PatchAll(Assembly.GetExecutingAssembly());
        }
        
        [HarmonyPatch(typeof(Creature))]
        private static class CreaturePatches
        {
            [HarmonyPatch(nameof(Creature.Start))]
            [HarmonyPostfix]
            private static void StartPatch(Creature __instance)
            {
                if (CreatureShouldBeRemoved(__instance))
                {
                    Object.DestroyImmediate(__instance.gameObject);
                }
            }
        }

        private static bool CreatureShouldBeRemoved(Creature creature)
        {
            if (creature == null) return false;
            var techType = CraftData.GetTechType(creature.gameObject);
            if (techType == TechType.None) return true;
            if (techType == TechType.Warper || techType == TechType.PrecursorDroid) return false;
            return true;
        }
    }
}