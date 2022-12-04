using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using QModManager.API.ModLoading;
using HarmonyLib;
using UnityEngine;
using RandomEvents.Creatures;
using ECCLibrary;

namespace RandomEvents
{
    [QModCore]
    public static class Mod
    {
        public static RandomEventItem randomEventItem;
        public static AssetBundle assetBundle;

        public static AmongUs amongUs;
        public static ErrorModelFish errorModelFish;
        public static BananaDuck bananaDuck;

        [QModPatch]
        public static void Patch()
        {
            assetBundle = ECCHelpers.LoadAssetBundleFromAssetsFolder(Assembly.GetExecutingAssembly(), "randomevents");
            ECCAudio.RegisterClips(assetBundle);

            randomEventItem = new RandomEventItem();
            randomEventItem.Patch();

            amongUs = new AmongUs("AmongUsFish", "???", "Sus.", assetBundle.LoadAsset<GameObject>("AmongUs_Prefab"), null);
            amongUs.Patch();

            errorModelFish = new ErrorModelFish("ErrorModelFish", "Error", "Error", assetBundle.LoadAsset<GameObject>("ErrorFish_Prefab"), null);
            errorModelFish.Patch();

            bananaDuck = new BananaDuck("BananaDuck", "Banana Duck", "Cute", assetBundle.LoadAsset<GameObject>("BananaDuck_Prefab"), null);
            bananaDuck.Patch();

            Harmony harmony = new Harmony("Lee23.RandomEvents");
            harmony.PatchAll(Assembly.GetExecutingAssembly());
        }

        [HarmonyPatch(typeof(Player))]
        public static class Player_Patches
        {
            [HarmonyPatch("Start")]
            [HarmonyPostfix]
            public static void PlayerPatch()
            {
                GameObject eventControllerObj = new GameObject("RandomEventContoller");
                eventControllerObj.EnsureComponent<RandomEventController>();
            }
        }

        [HarmonyPatch(typeof(WorldForces))]
        public static class WorldForces_Patches
        {
            [HarmonyPatch("IsAboveWater")]
            [HarmonyPrefix]
            public static bool PrefixPatch(WorldForces __instance, ref bool __result)
            {
                __result = __instance.transform.position.y >= (__instance.waterDepth + Utils.overrideWaterLevel);
                return false;
            }
        }
    }
}
