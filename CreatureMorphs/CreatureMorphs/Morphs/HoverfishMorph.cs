using UnityEngine;

namespace CreatureMorphs.Morphs
{
    internal class HoverfishMorph : MorphType
    {
        public HoverfishMorph(string morphClassId) : base(morphClassId)
        {
        }

        protected override void SetEssentials()
        {
            CameraFollowDistance = 4f;
            MorphModeType = MorphModeType.Prey;
        }

        internal override void SetupController(MorphController controller)
        {
            controller.AddAbility(new Bite(10f, null, genericBiteSound), PrimaryActionKey);
        }
    }
}