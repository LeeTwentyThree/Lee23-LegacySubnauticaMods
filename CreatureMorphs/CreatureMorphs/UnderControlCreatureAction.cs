using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreatureMorphs
{
    internal class UnderControlCreatureAction : CreatureAction
    {
        public override float Evaluate(Creature creature)
        {
            return float.MaxValue;
        }
    }
}
