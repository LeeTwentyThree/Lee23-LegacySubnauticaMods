using UnityEngine;

namespace InventoryColorCustomization
{
    internal class ColorChoice
    {
        protected string name;
        protected Color color;

        private Atlas.Sprite mySprite; // do not drink my Sprite!

        public ColorChoice(string name, Color color)
        {
            this.name = name;
            this.color = color;
        }

        public virtual string GetName(BackgroundType backgroundType)
        {
            return name;
        }

        public virtual Atlas.Sprite GetSprite(BackgroundType backgroundType)
        {
            if (mySprite == null)
            {
                mySprite = BackgroundIconGenerator.CreatePaintedIcon(color);
            }
            return mySprite;
        }
    }
}
