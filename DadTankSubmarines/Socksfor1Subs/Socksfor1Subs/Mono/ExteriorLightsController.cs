using UnityEngine;

namespace Socksfor1Subs.Mono
{
    public class ExteriorLightsController : MonoBehaviour
    {
        public DadSubBehaviour sub;
        public Light[] lights;

        public float onIntensity = 3f;
        public float idleIntensity = 1f;
        public float offIntensity = 0f;

        public Color defaultColor = Color.white;
        public Color stealthColor = new Color(1f, 0f, 0f);

        private void LateUpdate()
        {
            foreach (var l in lights)
            {
                l.intensity = GetIntensity();
                if (sub.stealthManager.StealthEnabled)
                {
                    l.color = stealthColor;
                }
                else
                {
                    l.color = defaultColor;
                }
            }
        }

        private float GetIntensity()
        {
            if (!sub.powerRelay.IsPowered())
            {
                return offIntensity;
            }
            if (Player.main.GetCurrentSub() != sub)
            {
                return idleIntensity;
            }
            return onIntensity;
        }
    }
}
