using UWE;
using UnityEngine;
using System.Collections;
using ECCLibrary;

namespace RandomEvents.Events
{
    class Herobrine : RandomEventBase
    {
        public override float GetDestroyTime => -1f;

        public override string GetEventStartMessage => "";

        private AudioSource src;

        private GameObject herobrine;

        private ECCAudio.AudioClipPool clipPool;

        const float raycastSquareSize = 30f;
        const float rayMaxDistance = 60f;

        public override void StartRandomEvent()
        {
            clipPool = ECCAudio.CreateClipPool("CaveSound");
            GameObject obj = new GameObject("AudioClipInstance");
            src = obj.AddComponent<AudioSource>();
            src.volume = ECCHelpers.GetECCVolume() * 0.5f;
            AudioClip clip = clipPool.GetRandomClip();
            src.clip = clip;
            src.Play();
            Destroy(src.gameObject, clip.length);

            herobrine = GameObject.Instantiate(Mod.assetBundle.LoadAsset<GameObject>("Herobrine_Prefab"));
            herobrine.transform.position = DetermineHerobrinePosition();
            Utils.LookAtPlayerUpright(herobrine.transform);
            ECCHelpers.ApplySNShaders(herobrine, new UBERMaterialProperties(4f, 1f, 4f));
            if (Player.main.GetCurrentSub() != null)
            {
                herobrine.transform.localScale = Vector3.one * 0.6f;
                foreach (Material m in herobrine.GetComponentInChildren<Renderer>().materials)
                {
                    m.SetFloat("_EmissionLM", 1f);
                    m.SetFloat("_EmissionLMNight", 1f);
                }
            }

            StartCoroutine(Lifetime());
        }

        private float GetRaycastSquareSize()
        {
            if (Player.main.GetCurrentSub() != null)
            {
                return 4f;
            }
            return raycastSquareSize;
        }

        private Vector3 DetermineHerobrinePosition()
        {
            var player = Player.main.viewModelCamera.transform;
            Vector3 hitPosition = default;
            for (int i = 0; i < 50; i++)
            {
                float squareSize = GetRaycastSquareSize();
                Vector3 raycastOrigin = new Vector3(player.position.x + Random.Range(-squareSize, squareSize), player.position.y, player.position.z + Random.Range(-squareSize, squareSize));
                Ray ray = new Ray(raycastOrigin, Vector3.down);
                if (Physics.Raycast(ray, out RaycastHit hit, rayMaxDistance, Utils.GetOutsideLayerMask(), QueryTriggerInteraction.Ignore))
                {
                    if (PointOnScreenDot(hit.point) < -0.15f)
                    {
                        hitPosition = hit.point;
                    }
                }
            }
            if (hitPosition == default)
            {
                hitPosition = Player.main.transform.position + (Random.onUnitSphere * raycastSquareSize);
            }
            return hitPosition;
        }

        private float PointOnScreenDot(Vector3 point)
        {
            var player = Player.main.viewModelCamera.transform;
            Vector3 direction = (point - player.position).normalized;
            return Vector3.Dot(direction, player.forward);
        }

        IEnumerator Lifetime()
        {
            while (true)
            {
                if (PointOnScreenDot(herobrine.transform.position) > 0.3f) // wait until herobrine is on screen
                {
                    break;
                }
                yield return null;
            }
            while (true)
            {
                if (PointOnScreenDot(herobrine.transform.position) < 0.15f) // wait until herobrine is off screen
                {
                    break;
                }
                yield return null;
            }
            Utils.PlaySound("event:/env/creature_teleport", herobrine.transform.position);
            Destroy(gameObject);
        }

        void OnDestroy()
        {
            Destroy(herobrine);
        }
    }
}
