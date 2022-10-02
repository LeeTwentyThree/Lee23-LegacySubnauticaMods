using UnityEngine;

namespace InventoryColorCustomization
{
    internal class CustomColorChoice : ColorChoice
    {
        public CustomColorChoice(CustomBackground customBackground) : base(customBackground.name, Color.white)
        {
            this.customBackground = customBackground;
        }

        private CustomBackground customBackground;

        public override Atlas.Sprite GetSprite(BackgroundType backgroundType)
        {
            if (cachedSprite == null)
            {
                cachedSprite = BackgroundIconGenerator.TextureToBGSprite(customBackground.texture);
            }
            return cachedSprite;
        }
    }
}
