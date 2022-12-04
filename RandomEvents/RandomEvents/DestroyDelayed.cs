using UnityEngine;

namespace RandomEvents
{
    class DestroyDelayed : MonoBehaviour
    {
        private float timeStart;
        public float destroyDelay;

        void Start()
        {
            timeStart = Time.time;
        }
        public void Update()
        {
            if(Time.time > (timeStart + destroyDelay))
            {
                if (gameObject.activeSelf)
                {
                    Destroy(gameObject);
                }
                else
                {
                    Destroy(this);
                }
            }
        }
    }
}
