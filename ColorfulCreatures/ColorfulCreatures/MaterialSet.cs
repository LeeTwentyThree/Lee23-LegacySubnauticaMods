using System.Collections.Generic;
using UnityEngine;

namespace ColorfulCreatures
{
    // contains multiple texture sets that are chosen from at random
    internal class MaterialSet : IRandomizable
    {
        public List<TextureSet> textures = new List<TextureSet>();

        public TextureSet chosenTextureSet;

        public MaterialSet(params TextureSet[] textures)
        {
            this.textures = new List<TextureSet>(textures);
        }

        public void Randomize(float value)
        {
            var randomIndex = (int)(value * textures.Count);
            if (randomIndex > textures.Count - 1)
            {
                randomIndex = textures.Count - 1;
            }
            chosenTextureSet = textures[randomIndex];
        }
    }
}
