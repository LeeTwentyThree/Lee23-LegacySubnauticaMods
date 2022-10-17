using HarmonyLib;

namespace ColorfulCreatures.Patches
{
    [HarmonyPatch(typeof(Creature))]
    internal class CreaturePatches
    {
        [HarmonyPatch(nameof(Creature.Start))]
        [HarmonyPostfix()]
        private static void StartPostfix(Creature __instance)
        {
            var prefabIdentifier = __instance.gameObject.GetComponent<PrefabIdentifier>();
            if (prefabIdentifier != null)
            {
                CreatureDatabase.ApplyColors(__instance, prefabIdentifier.ClassId);
            }
        }
    }
}
