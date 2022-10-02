using UnityEngine;

namespace InventoryColorCustomization
{
    internal static partial class ItemBackgroundData
    {
        // base class that defines a single possible choice for an item color

        internal class ColorChoice
        {
            protected string name;
            protected Color color;

            public ColorChoice(string name, Color color)
            {
                this.name = name;
                this.color = color;
            }

            public virtual string GetName(CraftData.BackgroundType backgroundType)
            {
                return name;
            }

            public virtual Color GetColor()
            {
                return color;
            }

            public virtual Atlas.Sprite GetSprite(CraftData.BackgroundType backgroundType)
            {
                return null;
            }
        }
    }
}
