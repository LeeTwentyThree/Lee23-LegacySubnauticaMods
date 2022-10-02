using UnityEngine;
using SMLHelper.V2.Utility;
using System.IO;

namespace InventoryColorCustomization
{
    internal static class BackgroundIconGenerator
    {
        private static Texture2D ReferenceTexture
        {
            get
            {
                if (_referenceTexture == null)
                {
                    _referenceTexture = LoadTextureFromFile(Main.GetPathInAssetsFolder("Grayscale"));
                }
                return _referenceTexture;
            }
        }

        private static Texture2D _referenceTexture;

        public static Atlas.Sprite TextureToSprite(Texture2D texture)
        {
            texture.wrapMode = TextureWrapMode.Clamp;
            texture.filterMode = FilterMode.Bilinear;
            return new Atlas.Sprite(texture) { slice9Grid = !Main.modConfig.SquareIcons };
        }

        // ripped from SMLHelper
        public static Texture2D LoadTextureFromFile(string filePathToImage, TextureFormat format = TextureFormat.BC7)
        {
            if (File.Exists(filePathToImage))
            {
                byte[] array = File.ReadAllBytes(filePathToImage);
                Texture2D texture2D = new Texture2D(2, 2, format, false, Main.modConfig.TransparentBackgrounds);
                ImageConversion.LoadImage(texture2D, array);
                return texture2D;
            }
            return null;
        }
    }
}