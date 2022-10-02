namespace AggressiveFauna
{
    using System;
    using System.Reflection;
    using HarmonyLib;
    using SMLHelper.V2.Handlers;
    using Common;
    using Items;
    using UnityEngine;
    using Patchers;
    using QModManager.API.ModLoading;
    using SMLHelper.V2.Crafting;
    using System.Collections.Generic;

    [QModCore]
    public class AggressiveFauna
    {
        public static void Patch()
        {
            Harmony harmony = new Harmony("cattlesquat.deathrun.mod");
            harmony.PatchAll(Assembly.GetExecutingAssembly());
        }

    }


    internal class WarnFailurePatcher
    {
        [HarmonyPostfix]
        public static void Postfix()
        {
            if (DeathRun.patchFailed)
            {
                ErrorMessage.AddMessage("PATCH FAILED - Death Run patch failed to complete. See errorlog (Logoutput.Log) for details.");
                DeathRunUtils.CenterMessage("PATCH FAILED", 10, 6);
            }

            DeathRunUtils.ShowHighScores(true);
        }
    }
}
