using UnityEngine;

namespace CreatureMorphs
{
    internal class MorphBehaviour : MonoBehaviour
    {
        public MorphType morph;
        protected Creature creature;

        private void Awake()
        {
            creature = GetComponent<Creature>();
        }

        private void Update()
        {
            foreach (var ability in morph.abi)
            {
                ability.OnUpdate();
            }
        }
    }
}
