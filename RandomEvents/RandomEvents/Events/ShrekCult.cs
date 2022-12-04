using UWE;
using UnityEngine;
using System.Collections;
using ECCLibrary;

namespace RandomEvents.Events
{
    class ShrekCult : RandomEventBase
    {
        public override float GetDestroyTime => 30f;

        private bool dmg = false;

        private float timeTakeDmgAgain;

        public override string GetEventStartMessage => "You sense a holy presence from above...";

        private AudioSource src;

        public override void StartRandomEvent()
        {
            var obj = GameObject.Instantiate(Mod.assetBundle.LoadAsset<GameObject>("ShrekCult"));
            ECCHelpers.ApplySNShaders(obj, new UBERMaterialProperties(7f, 5f, 1f));
            foreach (Renderer r in obj.GetComponentsInChildren<Renderer>())
            {
                foreach (var m in r.materials)
                {
                    m.SetFloat("_EmissionLM", 0.4f);
                    m.SetFloat("_EmissionLMNight", 0.4f);
                    m.SetFloat("_GlowStrength", 0f);
                    m.SetFloat("_GlowStrengthNight", 0f);
                    m.EnableKeyword("MARMO_EMISSION");
                }
            }
            obj.transform.position = Player.main.transform.position + new Vector3(0f, 0f, 500f);
            obj.transform.rotation = Quaternion.identity;
            obj.SetActive(true);
            Destroy(obj, 30f);
            Utils.IncreaseFarplane();

            src = gameObject.AddComponent<AudioSource>();
            src.volume = ECCHelpers.GetECCVolume();
            src.clip = Mod.assetBundle.LoadAsset<AudioClip>("ShrekCult2");
            //src.Play();

            StartCoroutine(Lifetime());
        }

        IEnumerator Lifetime()
        {
            MainCameraControl.main.ShakeCamera(1f, 9f, shakeFrequency: 1f);
            yield return new WaitForSeconds(9f);
            Utils.SetBlurState(true);
            dmg = true;
            MainCameraControl.main.ShakeCamera(1f, 9f, shakeFrequency: 1.5f);
            yield return new WaitForSeconds(8f);
            dmg = false;
            Utils.SetBlurState(false);
        }

        void Update()
        {
            if (dmg && Time.time > timeTakeDmgAgain)
            {
                Camera cam = Player.main.viewModelCamera;
                if (Vector3.Dot(cam.transform.forward, Vector3.up) > 0.65f)
                {
                    Player.main.liveMixin.TakeDamage(0.25f, type: DamageType.Heat);
                }
                timeTakeDmgAgain = Time.time + 0.25f;
            }
        }
    }
}
