using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using ECCLibrary;

namespace RandomEvents.Mono
{
    class AmongUsBomb : MonoBehaviour
    {
        public Rigidbody rb;

        Renderer renderer;

        private bool detonated = false;

        void Start()
        {
            renderer = GetComponentInChildren<Renderer>();
        }
        void Update()
        {
            if (detonated)
            {
                return;
            }
            if (transform.position.y <= 0f)
            {
                detonated = true;
                AudioSource src = new GameObject("Explosion Sound").AddComponent<AudioSource>();
                var clip = Mod.assetBundle.LoadAsset<AudioClip>("NukeExplosionSFX");
                src.clip = clip;
                src.volume = ECCHelpers.GetECCVolume();
                src.spatialBlend = 1f;
                src.minDistance = 1000f;
                src.maxDistance = 50000f;
                src.transform.position = transform.position;
                src.Play();
                Destroy(src.gameObject, clip.length);
                Destroy(gameObject, 8f);
                Invoke(nameof(SpawnExplosionVFX), 2.9f);
                Invoke(nameof(DealDamage), 2.8f);
            }
        }

        private void FixedUpdate()
        {
            if (transform.position.y > 0f)
            {
                rb.AddForce(Vector3.down * 50f, ForceMode.Acceleration);
            }
            else
            {
                rb.AddForce(Vector3.up * 200f, ForceMode.Acceleration);
            }
        }

        private GameObject SpawnExplosionVFX()
        {
            renderer.enabled = false;

            var obj = Instantiate(Mod.assetBundle.LoadAsset<GameObject>("NukeVFX_Prefab"));
            obj.transform.position = new Vector3(transform.position.x, 0f, transform.position.z);
            Utils.LookAtPlayerUpright(obj.transform);
            ECCHelpers.ApplySNShaders(obj, new UBERMaterialProperties(8f, 0f, 3f));
            Destroy(obj, 5f);
            Utils.SetBlurState(true);
            MainCameraControl.main.ShakeCamera(6f, 1f);
            return obj;
        }

        private float GetPlayerDamage()
        {
            if (!Utils.PlayerInSubOrVehicle())
            {
                return 50000f;
            }
            return 3f;
        }

        private void DealDamage()
        {
            Player.main.liveMixin.TakeDamage(GetPlayerDamage(), transform.position, DamageType.Explosive);
            foreach(Creature creature in Object.FindObjectsOfType<Creature>())
            {
                var lm = creature.liveMixin;
                if (lm)
                {
                    lm.TakeDamage(50000f, transform.position, DamageType.Explosive);
                }
            }
            Player.main.liveMixin.TakeDamage(3f, transform.position, DamageType.Radiation);
        }

        void OnDestroy()
        {
            Utils.SetBlurState(false);
        }
    }
}