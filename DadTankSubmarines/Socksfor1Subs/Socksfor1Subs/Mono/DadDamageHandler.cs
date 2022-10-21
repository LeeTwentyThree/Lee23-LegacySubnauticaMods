using UnityEngine;
using UWE;

namespace Socksfor1Subs.Mono
{
    public class DadDamageHandler : MonoBehaviour
    {
        public DadSubBehaviour sub;

        public DealDamageOnImpact impactDamage;

        public FMOD_CustomLoopingEmitter emergencyMusicEmitter;

        public bool forceExplosionImmediately;

        private float _timeNextTick;

        private static FMODAsset _interiorExplosion = Helpers.GetFmodAsset("DadExplosionInterior");
        private static FMODAsset _exteriorExplosion = Helpers.GetFmodAsset("DadExplosionExterior");
        private static FMODAsset _damageSound = Helpers.GetFmodAsset("event:/sub/cyclops/creature_attack_sfx");

        private float _scrapMinSize = 3f;
        private float _scrapMaxSize = 4.5f;

        public bool AboutToExplode
        {
            get
            {
                return _deathCountdownStarted && !sub.live.IsAlive() && !HasExploded;
            }
        }

        public bool HasExploded
        {
            get
            {
                return _hasExploded;
            }
        }

        private float _timeDeathCountdownStarted;
        private bool _deathCountdownStarted;
        private float _deathCountdownDuration = 23f;
        private bool _hasExploded;

        private Debris[] _debrisData = new Debris[]
        {
            new Debris("5cd34124-935f-4628-b694-a266bc2f5517", 3, 1f, 1f),
            new Debris("669d26ab-81a0-4e4f-8bba-fac0d6cf8dab", 2, 2f, 3f),
            new Debris("6ef6075d-47c8-479a-a5b8-c142a44a9ff8", 2, 3f, 4f),
            new Debris("72437ebc-7d61-49b8-bac4-cb7f3af3af8e", 2, 0.8f, 1f),
            new Debris("7b8e9633-45a3-4542-93e2-34001523cac9", 4, 1.5f, 3f)
        };

        private class Debris
        {
            public string classId;
            public float minSize;
            public float maxSize;
            public int amount;

            public Debris(string classId, int amount, float minSize, float maxSize)
            {
                this.classId = classId;
                this.minSize = minSize;
                this.maxSize = maxSize;
                this.amount = amount;
            }
        }

        private void Update()
        {
            DoVoiceLines();
            HealOverTime();
            ManageDeath();
            ManageDamageOnImpact();
            var shouldPlayMusic = ShouldPlayMusic();
            if (shouldPlayMusic && !emergencyMusicEmitter.playing)
            {
                emergencyMusicEmitter.Play();
            }
            else if (!shouldPlayMusic)
            {
                emergencyMusicEmitter.Stop();
            }
        }

        private void DoVoiceLines()
        {
            if (Player.main.GetCurrentSub() != sub)
            {
                return;
            }
            if (sub.HealthPercent < 0.01f || !sub.live.IsAlive())
            {
                sub.voice.PlayVoiceLine("DadHullFailureImminent");
            }
            else if (sub.HealthPercent < 0.5f)
            {
                sub.voice.PlayVoiceLine("DadHullDamage");
            }
        }

        private void ManageDamageOnImpact()
        {
            impactDamage.enabled = Player.main.GetCurrentSub() == sub;
        }

        private bool ShouldPlayMusic()
        {
            if (Player.main.GetCurrentSub() != sub)
            {
                return false;
            }
            if (AboutToExplode)
            {
                return true;
            }
            return false;
        }

        private void HealOverTime()
        {
            if (Time.time > _timeNextTick && sub.live.IsAlive() && sub.powerRelay.IsPowered())
            {
                _timeNextTick = Time.time + Balance.DadRegenInterval;
                sub.live.AddHealth(Balance.DadHealthPerRegen);
            }
        }

        private void ManageDeath()
        {
            if (AboutToExplode)
            {
                if (Time.time > _timeDeathCountdownStarted + _deathCountdownDuration || forceExplosionImmediately)
                {
                    ExplodeShip();
                }
            }
            else if (!sub.live.IsAlive())
            {
                if (!_deathCountdownStarted)
                {
                    StartDeathCountdown();
                }
            }
        }

        public void StartDeathCountdown()
        {
            _timeDeathCountdownStarted = Time.time;
            _deathCountdownStarted = true;
        }

        private void ExplodeShip()
        {
            _hasExploded = true;
            bool playerWasInside = false;
            if (Player.main.GetCurrentSub() == sub)
            {
                playerWasInside = true;
                var playerChair = Player.main.GetPilotingChair();
                if (playerChair != null && playerChair.subRoot == sub)
                {
                    Player.main.ExitPilotingMode();
                }
                Player.main.SetCurrentSub(null);
            }
            if (Vector3.Distance(MainCameraControl.main.transform.position, transform.position) < 500f)
            {
                FadingOverlay.PlayFX(Color.white, 0f, 3f, 3f);
            }
            if (playerWasInside)
            {
                Player.main.liveMixin.TakeDamage(1000f, transform.position, DamageType.Explosive);
            }
            Utils.PlayFMODAsset(playerWasInside ? _interiorExplosion : _exteriorExplosion, transform.position);
            Destroy(sub.gameObject);
            SpawnScrap(sub.transform.position, 24f);
            SpawnDebris(sub.transform.position, 24f);
        }

        private void SpawnScrap(Vector3 aroundPosition, float radius)
        {
            var metalScrapPrefab = CraftData.GetPrefabForTechType(TechType.ScrapMetal);
            for (int i = 0; i < 11; i++)
            {
                var scrap = Instantiate(metalScrapPrefab, aroundPosition + Random.insideUnitSphere * radius, Random.rotation);
                var rb = scrap.GetComponent<Rigidbody>();
                if (rb)
                {
                    rb.isKinematic = false;
                }
                scrap.transform.localScale = Vector3.one * Random.Range(_scrapMinSize, _scrapMaxSize);
            }
        }

        private void SpawnDebris(Vector3 aroundPosition, float radius)
        {
            foreach (var debris in _debrisData)
            {
                if (PrefabDatabase.TryGetPrefab(debris.classId, out var prefab))
                {
                    for (int i = 0; i < debris.amount; i++)
                    {
                        var spawned = Instantiate(prefab, aroundPosition + Random.insideUnitSphere * radius, Random.rotation);
                        spawned.transform.localScale = Vector3.one * Random.Range(debris.minSize, debris.maxSize);
                        var rb = spawned.EnsureComponent<Rigidbody>();
                        rb.useGravity = false;
                        rb.isKinematic = false;
                        rb.gameObject.EnsureComponent<WorldForces>();
                    }
                }
            }
        }

        public void PlayDamageNoise(DamageInfo info)
        {
            if (info.damage > 100f)
            {
                Utils.PlayFMODAsset(_damageSound, Player.main.transform.position);
                sub.voice.PlayVoiceLine("DadHullDamage");
            }
        }
    }
}
