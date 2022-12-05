using UnityEngine;

namespace CreatureMorphs.Morphs
{
    internal class PeeperMorph : MorphType
    {
        public PeeperMorph(string morphClassId) : base(morphClassId)
        {
        }

        protected override void SetEssentials()
        {
            CameraFollowDistance = 4f;
        }

        internal override void SetupController(MorphController controller)
        {
            controller.AddAbility(new Bite(), PrimaryActionKey);
        }
    }
}