using UnityEngine;

namespace RandomEvents.Mono
{
    class ErrorModelAnimate : MonoBehaviour
    {
        Renderer renderer;
        float baseEmissionStrength = 2f;
        float illumPeriod = 0.5f;
        Material material;

        void Start()
        {
            renderer = GetComponentInChildren<Renderer>();
            material = renderer.material;
        }

        void Update()
        {
            float brightness = Mathf.PingPong(Time.time * illumPeriod, 1f) * baseEmissionStrength;
            material.SetFloat("_GlowStrength", brightness);
            material.SetFloat("_GlowStrengthNight", brightness);
        }

        void LateUpdate()
        {
            SetOrientation();
        }

        void FixedUpdate()
        {
            SetOrientation();
        }

        void SetOrientation()
        {
            Utils.LookAtPlayerUprightGlobal(transform);
        }

        void OnDestroy()
        {
            Destroy(material);
        }
    }
}
