using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColorfulCreatures
{
    internal class TextureSetBuilder
    {
        public string diffuseFormat;
        public string illumFormat;
        public string specFormat;

        public TextureSetBuilder(string diffuseFormat, string illumFormat, string specFormat)
        {
            this.diffuseFormat = diffuseFormat;
            this.illumFormat = illumFormat;
            this.specFormat = specFormat;
        }

        public TextureSet Get(string id)
        {
            return new TextureSet(diffuseFormat + id, illumFormat + id, specFormat+ id);
        }

        public TextureSet A
        {
            get
            {
                return Get("a");
            }
        }

        public TextureSet B
        {
            get
            {
                return Get("b");
            }
        }

        public TextureSet C
        {
            get
            {
                return Get("c");
            }
        }

        public TextureSet D
        {
            get
            {
                return Get("d");
            }
        }

        public TextureSet E
        {
            get
            {
                return Get("e");
            }
        }

        public TextureSet F
        {
            get
            {
                return Get("f");
            }
        }

        public TextureSet Albino
        {
            get
            {
                return Get("albi");
            }
        }

        public TextureSet Melanistic
        {
            get
            {
                return Get("mela");
            }
        }
    }
}
