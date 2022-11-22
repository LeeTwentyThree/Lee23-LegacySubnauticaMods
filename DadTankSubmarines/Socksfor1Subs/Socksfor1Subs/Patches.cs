using HarmonyLib;
using Socksfor1Subs.Mono;
using UnityEngine;

namespace Socksfor1Subs
{
    [HarmonyPatch(typeof(VehicleDockingBay))]
    public static class VehicleDockingBay_Patches
    {
        [HarmonyPatch(nameof(VehicleDockingBay.OnTriggerEnter))]
        [HarmonyPrefix()]
        public static bool OnTriggerEnter_Prefix(Collider other)
        {
            var vehicle = UWE.Utils.GetComponentInHierarchy<Vehicle>(other.gameObject);
            if (vehicle != null && vehicle is Tank)
            {
                return false;
            }
            return true;
        }
    }

    [HarmonyPatch(typeof(ConstructorInput))]
    public static class ConstructorInput_Patches
    {
        [HarmonyPatch(nameof(ConstructorInput.OnCraftingBegin))]
        [HarmonyPrefix()]
        public static void OnCraftingBegin_Prefix(TechType techType, ref float duration)
        {
            if (techType == Mod.dadSub.TechType)
            {
                duration = 25f; //Takes 20 seconds to build
                FMODUWE.PlayOneShot("event:/tools/constructor/spawn", Player.main.transform.position, 1f);
            }
            if (techType == Mod.sockTank.TechType)
            {
                duration = 10f;
                FMODUWE.PlayOneShot("event:/tools/constructor/spawn", Player.main.transform.position, 1f);
            }
        }
    }

    [HarmonyPatch(typeof(Creature))]
    public static class Creature_Patches
    {
        [HarmonyPatch(nameof(Creature.Start))]
        [HarmonyPostfix()]
        public static void Start_Postfix(Creature __instance)
        {
            if (!(__instance is ReaperLeviathan))
            {
                return;
            }
            if (Mod.config.MoreViciousReapers)
            {
                var melee = __instance.gameObject.GetComponentInChildren<MeleeAttack>();
                if (melee != null)
                {
                    melee.canBiteVehicle = true;
                }
            }
        }
    }

    [HarmonyPatch(typeof(FleeOnDamage))]
    public static class FleeOnDamage_Patches
    {
        [HarmonyPatch(nameof(FleeOnDamage.StartPerform))]
        [HarmonyPrefix()]
        public static bool StartPerform_Prefix(FleeOnDamage __instance, Creature creature)
        {
            if (Mod.config.DisableLeviathanFear == false)
            {
                return true;
            }
            if (IsCreatureLeviathan(creature))
            {
                __instance.timeNextSwim = float.MaxValue;
                return false;
            }
            return true;
        }

        private static bool IsCreatureLeviathan(Creature creature)
        {
            if (creature.liveMixin != null && creature.liveMixin.maxHealth >= 3000)
            {
                return true;
            }
            return false;
        }
    }

    [HarmonyPatch(typeof(GhostLeviatanVoid))]
    public static class GhostLeviatanVoid_Patches
    {
        [HarmonyPatch(nameof(GhostLeviatanVoid.UpdateVoidBehaviour))]
        [HarmonyPostfix()]
        public static void UpdateVoidBehaviour_Postfix(GhostLeviatanVoid __instance)
        {
            var spawner = VoidGhostLeviathansSpawner.main;
            bool targetPlayer = spawner && spawner.IsPlayerInVoid();
            if (targetPlayer)
            {
                var playerSub = Player.main.GetCurrentSub();
                if (playerSub != null && playerSub is DadSubBehaviour)
                {
                    __instance.lastTarget.target = playerSub.gameObject;
                }
            }
        }
    }

    [HarmonyPatch(typeof(Constructor))]
    public static class Constructor_Patches
    {
        [HarmonyPatch(nameof(Constructor.OnEnable))]
        [HarmonyPostfix()]
        public static void OnEnable_Postfix(Constructor __instance)
        {
            AddSpawnPoint(__instance, Mod.dadSub.TechType, new Vector3(65f, 8f, 0f), new Vector3(0f, -90f, 0f));
            AddSpawnPoint(__instance, Mod.sockTank.TechType, new Vector3(16f, 4f, 0f), new Vector3(0f, -90f, 0f));
        }

        private static void AddSpawnPoint(Constructor constructor, TechType techType, Vector3 position, Vector3 eulers)
        {
            foreach (var spawnPos in constructor.spawnPoints)
            {
                if (spawnPos.techType == techType)
                {
                    return;
                }
            }
            var newSpawnPoint = Object.Instantiate(constructor.defaultSpawnPoint, constructor.transform);
            newSpawnPoint.transform.localPosition = position;
            newSpawnPoint.transform.localEulerAngles = eulers;
            constructor.spawnPoints.Add(new Constructor.SpawnPoint() { techType = techType, transform = newSpawnPoint.transform });

        }
    }
}
