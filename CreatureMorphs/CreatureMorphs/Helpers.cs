using UnityEngine;
using System.Reflection;
using System.IO;

namespace CreatureMorphs
{
    internal class Helpers
    {
        public static Transform CameraTransform => MainCamera.camera.transform;

        public static AssetBundle LoadAssetBundleFromAssetsFolder(Assembly modAssembly, string assetsFileName)
        {
            return AssetBundle.LoadFromFile(Path.Combine(Path.GetDirectoryName(modAssembly.Location), "Assets", assetsFileName));
        }

        public static FMODAsset GetFmodAsset(string audioPath)
        {
            FMODAsset asset = ScriptableObject.CreateInstance<FMODAsset>();
            asset.path = audioPath;
            return asset;
        }
    }
}
