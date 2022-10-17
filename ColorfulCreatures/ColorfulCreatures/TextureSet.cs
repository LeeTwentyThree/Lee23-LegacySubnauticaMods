using UnityEngine;

namespace ColorfulCreatures
{
    internal class TextureSet
    {
        public Texture2D diffuse;
        public Texture2D illum;
        public Texture2D specular;

        public TextureSet(Texture2D diffuse, Texture2D illum, Texture2D specular)
        {
            this.diffuse = diffuse;
            this.illum = illum;
            this.specular = specular;
        }

        public TextureSet(string diffuse, string illum, string specular)
        {
            this.diffuse = Main.assets.LoadAsset<Texture2D>(diffuse);
            this.illum = Main.assets.LoadAsset<Texture2D>(illum);
            this.specular = Main.assets.LoadAsset<Texture2D>(specular);
        }
    }
}
