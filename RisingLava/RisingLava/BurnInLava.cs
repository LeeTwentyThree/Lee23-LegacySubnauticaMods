using UnityEngine;

namespace RisingLava
{
    public class BurnInLava : MonoBehaviour
    {
        public float bottomOffset = 0f;

        public bool isCyclops;

        private void Update()
        {
            if (Main.LavaLevel > transform.position.y + bottomOffset)
            {
                if (isCyclops)
                {
                    var subRoot = gameObject.GetComponent<SubRoot>();
                    if (subRoot)
                    {
                        subRoot.DestroyCyclopsSubRoot();
                        Destroy(this);
                        return;
                    }
                }
                var lm = gameObject.GetComponent<LiveMixin>();
                if (lm != null)
                {
                    lm.TakeDamage(20000f, transform.position, DamageType.Heat);
                    lm.TakeDamage(20000f, transform.position, DamageType.Normal);
                    Destroy(this);
                }
            }
        }
    }
}
