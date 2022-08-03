using UnityEngine;
using System.Collections.Generic;

namespace RisingLava
{
    public class LavaLightManager : MonoBehaviour
    {
        private LavaLight[] lights;

        private int maxLights = 20;
        public float intensity = 4f;
        private float range = 100f;
        private Color color = new Color(0.99f, 0.3f, 0.01f);

        public AnimationCurve intensityCurve = new AnimationCurve(new Keyframe(0, 0f), new Keyframe(0.33f, 1f), new Keyframe(0.67f, 1f), new Keyframe(1, 0f));
        public float lightDuration = 10f;
        public float radiusAroundCamera = 159f;
        public float yOffset = 0.4f;

        private void Start()
        {
            InitLights();
        }

        private void InitLights()
        {
            lights = new LavaLight[maxLights];
            for (int i = 0; i < maxLights; i++)
            {
                lights[i] = CreateLight();
                lights[i].RandomizeTimeOffset();
            }
        }

        private void Update()
        {
            foreach (var light in lights)
            {
                if (!light.Active)
                {
                    light.SetActive(true);
                }
            }
        }

        private LavaLight CreateLight()
        {
            var light = new GameObject("LavaLight").AddComponent<Light>();
            light.intensity = intensity;
            light.range = range;
            light.color = color;
            light.type = LightType.Point;
            light.shadows = LightShadows.Hard;

            var lavaLight = light.gameObject.AddComponent<LavaLight>();
            lavaLight.light = light;
            lavaLight.manager = this;

            return lavaLight;
        }
    }
}
