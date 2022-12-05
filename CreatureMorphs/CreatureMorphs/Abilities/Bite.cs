using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreatureMorphs
{
    internal class Bite : MorphAbility
    {
        public float damage;
        public string animationParameter;

        protected override void OnInputReceived()
        {
            if (string.IsNullOrEmpty(animationParameter))
            {

            }
        }

        protected override void Setup()
        {
            
        }
    }
}
