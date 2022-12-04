using UnityEngine;

namespace RandomEvents.Mono
{
    class DestroyOffScreen : MonoBehaviour
    {
        // range -1f (behind you) to 1f (in front of you)

        public float minOnScreenDot = 0.2f;

        public float minLifetime;

        public float maxLifetime = 120f;

        private float minDestroyTime;
        private float maxDestroyTime;

        public void InitValues(float minOnScreenDot, float minLifetime, float maxLifetime)
        {
            this.minOnScreenDot = minOnScreenDot;
            this.minLifetime = minLifetime;
            this.maxLifetime = maxLifetime;
        }

        private void Start()
        {
            minDestroyTime = Time.time + minLifetime;
            maxDestroyTime = Time.time + maxLifetime;
        }

        private void Update()
        {
            if (Time.time < minDestroyTime)
            {
                return;
            }
            if (Time.time > maxDestroyTime)
            {
                DestroyThis();
                return;
            }
            float dot = Utils.PointOnScreenDot(transform.position);
            if (dot < minOnScreenDot)
            {
                DestroyThis();
            }
        }

        private void DestroyThis()
        {
            Destroy(gameObject);
        }
    }
}
