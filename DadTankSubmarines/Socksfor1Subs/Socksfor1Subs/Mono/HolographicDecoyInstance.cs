using UnityEngine;

namespace Socksfor1Subs.Mono
{
    public class HolographicDecoyInstance : MonoBehaviour
    {
        public float duration = 13f;

        private float _spawnTime;

        private void Start()
        {
            _spawnTime = Time.time;
        }

        private void Update()
        {
            if (Time.time > _spawnTime + duration)
            {
                Destroy(gameObject);
            }
        }
    }
}
