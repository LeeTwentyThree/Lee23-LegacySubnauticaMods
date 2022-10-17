using System.Collections.Generic;
using UnityEngine;

namespace ColorfulCreatures
{
    internal class MaterialPreset : IRandomizable
    {
        public List<TextureSet> textures = new List<TextureSet>();

        public TextureSet chosenTextureSet;

        public MaterialPreset(params TextureSet[] textures)
        {
            this.textures = new List<TextureSet>(textures);
        }

        public void Randomize()
        {
            chosenTextureSet = textures[Random.Range(0, textures.Count)];
        }
    }
}
