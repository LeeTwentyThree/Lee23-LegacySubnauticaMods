using QModManager.API.ModLoading;
using HarmonyLib;
using System.Reflection;
using InventoryColorCustomization;
using SMLHelper.V2.Handlers;
using System.IO;

[QModCore]
public static class Main
{
    internal static Assembly assembly = Assembly.GetExecutingAssembly();
    internal static string assetFolderPath = Path.Combine(Path.GetDirectoryName(assembly.Location), "Assets");
    internal static Options modConfig = new Options();

    [QModPatch]
    public static void Entry()
    {
        ColorChoiceManager.Initialize();
        OptionsPanelHandler.RegisterModOptions(modConfig);
        var harmony = new Harmony("Lee23.InventoryColorCustomization");
        harmony.PatchAll(assembly);
    }

    internal static string GetPathInAssetsFolder(string pathRelativeToAssetsFolder)
    {
        return Path.Combine(assetFolderPath, pathRelativeToAssetsFolder);
    }
}