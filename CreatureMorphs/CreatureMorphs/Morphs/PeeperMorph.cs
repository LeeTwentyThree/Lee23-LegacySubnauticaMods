using UnityEngine;

namespace CreatureMorphs.Morphs
{
    internal class PeeperMorph : CreatureMorph
    {
        public PeeperMorph(string morphClassId) : base(morphClassId)
        {
        }

        protected override void Setup()
        {
            AddAbility(new Abilities.Bite(), GameInput.Button.LeftHand);
        }
    }
}