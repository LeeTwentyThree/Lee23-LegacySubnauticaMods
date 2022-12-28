using QModManager.API.ModLoading;
using UnityEngine;
using ECCLibrary;
using System.Reflection;
using Socksfor1Monsters.Prefabs;
using System.Linq.Expressions;

namespace Socksfor1Monsters
{
    [QModCore]
    public static class Mod
    {
        public static AssetBundle assetBundle;
        public static Blaza blaza;
        public static Bloop bloop;

        [QModPatch]
        public static void Patch()
        {
            assetBundle = ECCHelpers.LoadAssetBundleFromAssetsFolder(Assembly.GetExecutingAssembly(), "socksfor1monsters");
            ECCAudio.RegisterClips(assetBundle);

            blaza = new Blaza("BlazaLeviathan", "The Blaza", "Big spooky fish.", assetBundle.LoadAsset<GameObject>("Blaza_Prefab"), null);
            blaza.Patch();
            bloop = new Bloop("Bloop", "The Bloop", "He's always hungry.", assetBundle.LoadAsset<GameObject>("Bloop_Prefab"), null);
            bloop.Patch();

            StaticCreatureSpawns.RegisterStaticSpawn(new StaticSpawn(blaza, new Vector3(-946, -315, -537), "BlazaBloodKelpTrench", 250f));
            StaticCreatureSpawns.RegisterStaticSpawn(new StaticSpawn(blaza, new Vector3(-757, -742, -93), "BlazaRibcage", 250f));
            StaticCreatureSpawns.RegisterStaticSpawn(new StaticSpawn(blaza, new Vector3(-523, -782, 144), "BlazaRibcageEnd", 250f));
            StaticCreatureSpawns.RegisterStaticSpawn(new StaticSpawn(blaza, new Vector3(-666, -749, 510), "BlazaWaterfall", 250f));
            StaticCreatureSpawns.RegisterStaticSpawn(new StaticSpawn(blaza, new Vector3(-718, -1127, 123), "BlazaLava", 250f));
            StaticCreatureSpawns.RegisterStaticSpawn(new StaticSpawn(blaza, new Vector3(-1144, -200f, 1147), "BlazaCrater", 250f));
            StaticCreatureSpawns.RegisterStaticSpawn(new StaticSpawn(blaza, new Vector3(64, -236, -292), "BlazaJellyshroom", 250f));

            StaticCreatureSpawns.RegisterStaticSpawn(new StaticSpawn(bloop, new Vector3(280, -60f, 205), "BloopQuad1", 300f));
            StaticCreatureSpawns.RegisterStaticSpawn(new StaticSpawn(bloop, new Vector3(-460, -60f, 540f), "BloopQuad2", 300f));
            StaticCreatureSpawns.RegisterStaticSpawn(new StaticSpawn(bloop, new Vector3(-574, -60f, -120), "BloopQuad3", 300f));
            StaticCreatureSpawns.RegisterStaticSpawn(new StaticSpawn(bloop, new Vector3(130, -60f, -850), "BloopQuad4", 300f));
            StaticCreatureSpawns.RegisterStaticSpawn(new StaticSpawn(bloop, new Vector3(650f, -70f, 390f), "BloopMushroomForest", 300f));
        }

    }
}
