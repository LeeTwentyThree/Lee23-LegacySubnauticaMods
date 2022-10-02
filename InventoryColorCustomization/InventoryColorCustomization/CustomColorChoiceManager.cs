using UnityEngine;
using System.Collections.Generic;
using System.IO;

namespace InventoryColorCustomization
{
    internal static class CustomColorChoiceManager
    {
        public static CustomBackground[] loadedBackgrounds;
        private static string[] validFileExtensions = new string[] { ".png" };

        private static string GetCustomFolderPath()
        {
            return Main.GetPathInAssetsFolder("Custom");
        }

        private static bool GetFileExtensionValid(string extensionWithPeriod)
        {
            foreach (var valid in validFileExtensions)
            {
                if (extensionWithPeriod.Equals(valid))
                    return true;
            }
            return false;
        }

        public static void LoadCustomFiles()
        {
            var imageFiles = Directory.GetFiles(GetCustomFolderPath());
            var backgrounds = new List<CustomBackground>();
            foreach (var imagePath in imageFiles)
            {
                var extension = Path.GetExtension(imagePath);
                if (extension != null && GetFileExtensionValid(extension))
                {
                    backgrounds.Add(new CustomBackground(Path.GetFileNameWithoutExtension(imagePath), BackgroundIconGenerator.LoadTextureFromFile(imagePath)));
                }
            }
            loadedBackgrounds = backgrounds.ToArray();
        }

        public class CustomBackground
        {
            public string name;
            public Texture2D texture;

            public CustomBackground(string name, Texture2D texture)
            {
                this.name = name;
                this.texture = texture;
            }
        }
    }
}