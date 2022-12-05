using UnityEngine;

namespace CreatureMorphs.Morphs
{
    internal class BoomerangMorph : MorphType
    {
        public BoomerangMorph(string morphClassId) : base(morphClassId)
        {
        }

        protected override void SetEssentials()
        {
            CameraFollowDistance = 4f;
            MorphModeType = MorphModeType.Prey;
        }

        internal override void SetupController(MorphController controller)
        {
            controller.AddAbility(new Bite(2f, null, genericBiteSound), PrimaryActionKey);
        }
    }
}