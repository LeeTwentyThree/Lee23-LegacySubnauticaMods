using UnityEngine;

namespace Socksfor1Subs.Mono
{
    public class WaterTransition : MonoBehaviour
    {
        public Collider[] airTriggers;
        public Collider[] waterTriggers;
        public Renderer waterPlane;
        public SubRoot sub;
        public float timeLastExited;
        public float minOutsideTimeForEnterSound = 1f;

        private void Start()
        {
            foreach (var air in airTriggers)
            {
                var trigger = air.gameObject.AddComponent<TransitionTrigger>();
                trigger.manager = this;
                trigger.type = TransitionTrigger.Type.Air;
            }
            foreach (var water in waterTriggers)
            {
                var trigger = water.gameObject.AddComponent<TransitionTrigger>();
                trigger.manager = this;
                trigger.type = TransitionTrigger.Type.Water;
            }        
        }

        private void Update()
        {
            waterPlane.enabled = waterPlane.transform.position.y < Ocean.main.GetOceanLevel() - 0.5f;
        }

        public void OnSetMode(TransitionTrigger.Type mode)
        {
            if (mode == TransitionTrigger.Type.Water)
            {
                timeLastExited = Time.time;
            }
        }

        public bool CanPlayEnterSound()
        {
            if (Time.time < timeLastExited + minOutsideTimeForEnterSound)
            {
                return false;
            }
            return true;
        }
    }
}
