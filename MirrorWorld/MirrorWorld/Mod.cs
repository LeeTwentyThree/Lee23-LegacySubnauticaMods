using HarmonyLib;
using QModManager.API.ModLoading;
using System.Reflection;
using UnityEngine;

namespace MirrorWorld
{
    [QModCore]
    public static class Mod
    {
        public static Assembly modAssembly = Assembly.GetExecutingAssembly();

        [QModPatch]
        public static void Entry()
        {
            var harmony = new Harmony("Lee23.MirrorWorld");
            harmony.PatchAll(modAssembly);
        }
    }
}