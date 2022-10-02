using UnityEngine;
using System.IO;

namespace InventoryColorCustomization
{
    internal static partial class ItemBackgroundData
    {
        internal class BackgroundData
        {
            public CraftData.BackgroundType BackgroundType;
            public string DefaultTextureFileName;

            public Texture2D DefaultTexture { get; private set; }

            public Atlas.Sprite DefaultSprite { get; private set; }

            public string ID { get { return BackgroundType.ToString() + "Color"; } }

            public BackgroundData(CraftData.BackgroundType backgroundType, string defaultTextureFileName)
            {
                BackgroundType = backgroundType;
                DefaultTextureFileName = defaultTextureFileName;
                DefaultTexture = BackgroundIconGenerator.LoadTextureFromFile(Main.GetPathInAssetsFolder(Path.Combine("Default", DefaultTextureFileName + ".png")));
                DefaultSprite = BackgroundIconGenerator.TextureToSprite(DefaultTexture);
            }
        }
    }
}
