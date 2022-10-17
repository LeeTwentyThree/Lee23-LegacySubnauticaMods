using ColorfulCreatures;
using HarmonyLib;
using QModManager.API.ModLoading;
using System.IO;
using System.Reflection;
using UnityEngine;

[QModCore]
public class Main
{
    public static AssetBundle assets;
    public static Assembly assembly = Assembly.GetExecutingAssembly();

    [QModPatch()]
    public static void Entry()
    {
        assets = LoadAssetBundleFromAssetsFolder("reskins");

        var harmony = new Harmony("Subnautica.ColorfulCreatures");
        harmony.PatchAll(assembly);

        CreatureDatabase.Initialize();
    }

    private static AssetBundle LoadAssetBundleFromAssetsFolder(string assetsFileName)
    {
        return AssetBundle.LoadFromFile(Path.Combine(Path.GetDirectoryName(assembly.Location), "Assets", assetsFileName));
    }
}