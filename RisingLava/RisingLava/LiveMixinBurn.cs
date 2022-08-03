using UnityEngine;

namespace RisingLava
{
    public class LiveMixinBurn : MonoBehaviour
    {
        public LiveMixin lm;

        private void Update()
        {
            if (transform.position.y < Main.LavaLevel - 1f)
            {
                if (lm)
                {
                    lm.TakeDamage(20000f, transform.position, DamageType.Heat);
                    lm.TakeDamage(20000f, transform.position, DamageType.Normal);
                    Destroy(this);
                }
            }
        }
    }
}
