using UnityEngine;

namespace Socksfor1Subs.Mono
{
    public class HolographicDecoyManager : MonoBehaviour
    {
        public DadSubBehaviour sub;

        private static FMODAsset _asset = Helpers.GetFmodAsset("DadHolographicDecoyFX");

        private float _minDelay = 15f;

        private float _timeLastSpawned;

        private float _duration = 13f;

        public void SpawnDecoys()
        {
            if (sub.InfinitePower || (sub.powerRelay.GetPower() >= Balance.DecoyPowerUsage && sub.powerRelay.ConsumeEnergy(Balance.DecoyPowerUsage, out var _)))
            {
                _timeLastSpawned = Time.time;
                FadingOverlay.PlayFX(Color.white, 0f, 0f, 0.5f);
                sub.voice.PlayVoiceLine("DadHolographicDecoy");
                Utils.PlayFMODAsset(_asset, Player.main.transform.position);
                var position = transform.position;
                SpawnDecoy(position, TechType.GhostRayRed, 4);
                SpawnDecoy(position, TechType.Stalker, 2);
                SpawnDecoy(position, TechType.ReaperLeviathan, 1);
                SpawnDecoy(position, TechType.CrabSquid, 1);
                Invoke(nameof(FlashScreenDelayed), _duration);
            }
        }

        private void FlashScreenDelayed()
        {
            FadingOverlay.PlayFX(Color.white, 0f, 0f, 0.5f);
        }

        public bool CanSpawn
        {
            get
            {
                return Time.time > _timeLastSpawned + _minDelay;
            }
        }

        private static void SpawnDecoy(Vector3 pos, TechType type, int amount)
        {
            var prefab = CraftData.GetPrefabForTechType(type);
            var material = new Material(GetStasisFieldMaterial());
            material.color = new Color(1f, 1f, 1f, 10f);
            for (int i = 0; i < amount; i++)
            {
                var gameObject = Instantiate(prefab, pos + Random.onUnitSphere * 3f, Random.rotation);
                foreach (var renderer in gameObject.GetComponentsInChildren<Renderer>())
                {
                    var ms = renderer.materials;
                    for (int j = 0; j < renderer.materials.Length; j++)
                    {
                        ms[j] = material;
                    }
                    renderer.materials = ms;
                }
                Destroy(gameObject.GetComponent<LargeWorldEntity>());
                gameObject.EnsureComponent<EcoTarget>().type = EcoTargetType.Shark;
                var creature = gameObject.GetComponent<Creature>();
                creature.Aggression = new CreatureTrait(0f, 99999f);
                gameObject.EnsureComponent<StayAtLeashPosition>().leashDistance = 8f;
                var collider = gameObject.GetComponent<Collider>();
                if (collider) collider.enabled = false;

                gameObject.AddComponent<HolographicDecoyInstance>();
            }
        }

        private static Material GetStasisFieldMaterial()
        {
            var stasisRifle = CraftData.GetPrefabForTechType(TechType.StasisRifle);
            return stasisRifle.GetComponent<StasisRifle>().effectSpherePrefab.GetComponent<Renderer>().materials[0];
        }
    }
}
