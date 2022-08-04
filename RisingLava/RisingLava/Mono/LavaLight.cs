using UnityEngine;

namespace RisingLava.Mono
{
    public class LavaLight : MonoBehaviour
    {
        public LavaLightManager manager;

        public Light light;

        private bool active;
        private float timeActivated;

        private Vector2 xzPos;

        private float timeStartAgain;
        private float maxInterval = 4f;

        public void SetActive(bool state)
        {
            var wasActive = active;
            active = state;
            light.enabled = active;
            if (!wasActive && active && Time.time > timeStartAgain)
            {
                timeActivated = Time.time;
                light.intensity = 0f;
                DetermineNewPosition();
            }
            if (wasActive && !active)
            {
                timeStartAgain = Time.time + Random.value * maxInterval;
            }
        }

        public bool Active
        {
            get
            {
                return active;
            }
        }

        public void RandomizeTimeOffset()
        {
            timeActivated = Time.time + Random.value * manager.lightDuration;
        }

        private void DetermineNewPosition()
        {
            var camPos = MainCamera.camera.transform.position;
            xzPos = new Vector2(camPos.x, camPos.z) + (Random.insideUnitCircle * manager.radiusAroundCamera);
        }

        private void Update()
        {
            if (!active)
            {
                return;
            }
            if (Time.time > timeActivated + manager.lightDuration)
            {
                SetActive(false);
                return;
            }
            light.intensity = manager.intensityCurve.Evaluate((Time.time - timeActivated) / manager.lightDuration) * manager.intensity;
            transform.position = new Vector3(xzPos.x, Main.LavaLevel + manager.yOffset, xzPos.y);
        }
    }
}
