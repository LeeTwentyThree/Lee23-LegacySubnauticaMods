using UnityEngine;
using SMLHelper.V2.Utility;
using System.IO;

namespace InventoryColorCustomization
{
    internal static class BackgroundIconGenerator
    {
        // grayscale texture that can be "painted" to your liking
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

        // ripped from SMLHelper, thanks modders!
        public static Texture2D LoadTextureFromFile(string filePathToImage)
        {
            if (File.Exists(filePathToImage))
            {
                byte[] array = File.ReadAllBytes(filePathToImage);
                Texture2D texture2D = new Texture2D(2, 2, TextureFormat, false, LinearColorSpace);
                ImageConversion.LoadImage(texture2D, array);
                return texture2D;
            }
            return null;
        }

        private static bool LinearColorSpace
        {
            get
            {
                return Main.modConfig.TransparentBackgrounds;
            }
        }

        private static TextureFormat TextureFormat
        {
            get
            {
                return TextureFormat.BC7;
            }
        }

        public static Atlas.Sprite CreatePaintedIcon(Color color)
        {
            var grayscale = ReferenceTexture;
            return TextureToSprite(PaintGrayscaleTexture(ReferenceTexture, color));
        }

        private static Texture2D PaintGrayscaleTexture(Texture2D grayscale, Color newColor) // give life to a grayscale image!!!
        {
            var pixels = grayscale.GetPixels();
            Texture2D newTex = new Texture2D(grayscale.width, grayscale.height, TextureFormat, false, LinearColorSpace);
            for (int i = 0; i < pixels.Length; i++)
            {
                pixels[i] = pixels[i] * newColor;
            }
            newTex.SetPixels(pixels);
            newTex.Apply();
            return newTex;
        }
    }
}