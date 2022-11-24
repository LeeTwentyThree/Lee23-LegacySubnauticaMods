using UnityEngine;
using ECCLibrary;
using QModManager.API.ModLoading;
using System.Reflection;
using ArcticMigration.Creatures;

namespace ArcticMigration
{
    [QModCore]
    public static class Main
    {
        public static AssetBundle bundle;
        public static Assembly assembly;

        [QModPatch]
        public static void Patch()
        {
            assembly = Assembly.GetExecutingAssembly();
            bundle = ECCHelpers.LoadAssetBundleFromAssetsFolder(assembly, "sn1creatures");

            var stalker = new StalkerPort("StalkerPort", bundle.LoadAsset<GameObject>("Stalker"));
            stalker.Patch();
            var arcticStalker = new StalkerPort("ArcticStalker", bundle.LoadAsset<GameObject>("ArcticStalker"));
            arcticStalker.Patch();
            var kelpStalker = new StalkerPort("KelpStalker", bundle.LoadAsset<GameObject>("KelpStalker"));
            kelpStalker.Patch();

            var cutefish = new CutefishPort("CuteFishPort", bundle.LoadAsset<GameObject>("CuteFish"));
            cutefish.Patch();
        }
    }
}