using UnityEngine;

namespace RisingLava
{
    public class CreatureBurn : MonoBehaviour
    {
        public Creature creature;

        private void Update()
        {
            if (transform.position.y < Main.LavaLevel - 1f)
            {
                creature.liveMixin.TakeDamage(20000f, transform.position, DamageType.Heat);
                creature.liveMixin.TakeDamage(20000f, transform.position, DamageType.Normal);
            }
        }
    }
}
