using System.Collections.Generic;
using UnityEngine;

namespace Socksfor1Subs.Mono
{
    public class ExplosiveTorpedo : MonoBehaviour
    {
        public Tank tank;
        public WorldForces worldForces;
        public Rigidbody rb;
        public Transform modelTransform;
        public FMOD_CustomLoopingEmitter emitter;

        public float velocity = 23f;
        public float spinDegreesPerSecond = 360f;
        public float fuseTimer = 12f;
        public float damageToSubs = 200f;
        public float rotateToTargetAnglesPerSecond = 120f;
        public float fallDownAnglesPerSecond = 50f;
        public float homeDelay = 1f;
        public float emitterDuration = 1f;

        public Vector3 targetPosition;
        public Transform targetTransform;

        private float _timeCreated;
        private bool _breachedSurface;
        private float _distantExplosionThreshold = 100f;
        private FMODAsset _explodeSoundClose = Helpers.GetFmodAsset("TankTorpedoExplosionClose");
        private FMODAsset _explodeSoundFar = Helpers.GetFmodAsset("TankTorpedoExplosionFar");

        private Vector3 TargetPosition
        {
            get
            {
                if (targetTransform != null)
                {
                    return targetTransform.position;
                }
                else
                {
                    return targetPosition;
                }
            }
        }

        private void Start()
        {
            emitter.Play();
            _timeCreated = Time.time;
            rb.velocity = transform.forward * velocity;
        }

        private void Update()
        {
            CheckEmitter();
            modelTransform.localEulerAngles += new Vector3(0f, 0f, spinDegreesPerSecond * Time.deltaTime);
            if (Time.time > _timeCreated + fuseTimer)
            {
                Explode();
            }
            if (worldForces.IsAboveWater())
            {
                FallToDownRotation();
                _breachedSurface = true;
            }
            if (_breachedSurface)
            {
                return;
            }
            rb.velocity = transform.forward * velocity;
            if (Time.time > _timeCreated + homeDelay)
            {
                HomeOnTarget();
            }
        }

        private void CheckEmitter()
        {
            if (Time.time > _timeCreated + emitterDuration && emitter.playing)
            {
                emitter.Stop();
            }
        }

        private void HomeOnTarget()
        {
            transform.rotation = Quaternion.RotateTowards(transform.rotation, Quaternion.LookRotation((TargetPosition - transform.position).normalized), Time.deltaTime * rotateToTargetAnglesPerSecond);
        }

        private void FallToDownRotation()
        {
            transform.rotation = Quaternion.RotateTowards(transform.rotation, Quaternion.LookRotation(Vector3.down), Time.deltaTime * fallDownAnglesPerSecond);
        }

        private void OnCollisionEnter(Collision collision)
        {
            Explode();
        }

        public void Explode()
        {
            Destroy(gameObject);
            PlayExplodeFX(transform.position);
            DamageInRadius(transform.position, 7f);
        }

        private void DamageInRadius(Vector3 center, float radius)
        {
            var damagedList = new List<LiveMixin>();
            int count = UWE.Utils.OverlapSphereIntoSharedBuffer(center, radius, -1, QueryTriggerInteraction.Ignore);
            for (int i = 0; i < count; i++)
            {
                var collider = UWE.Utils.sharedColliderBuffer[i];
                var liveMixin = collider.gameObject.GetComponentInParent<LiveMixin>();
                if (liveMixin != null)
                {
                    if (damagedList.Contains(liveMixin))
                    {
                        continue;
                    }
                    damagedList.Add(liveMixin);
                    var damage = Balance.TankTorpedoDamage;
                    bool damagingVehicle = liveMixin.IsWeldable() || liveMixin.gameObject.GetComponent<SubRoot>() != null || liveMixin.gameObject.GetComponent<Vehicle>() != null;
                    if (damagingVehicle)
                    {
                        damage = damageToSubs;
                    }
                    liveMixin.TakeDamage(damage, center, DamageType.Explosive, gameObject);
                    if (tank != null && liveMixin.health == 0 && liveMixin.transform == targetTransform)
                    {
                        bool isLeviathan = liveMixin.gameObject.GetComponent<Creature>() != null && liveMixin.maxHealth > 4000f;
                        if (damagingVehicle)
                        {
                            tank.voice.PlayVoiceLine("TankFriendlyFire", liveMixin.gameObject == tank.gameObject);
                        }
                        else if (isLeviathan)
                        {
                            tank.voice.PlayVoiceLine("TankKillLeviathan");
                        }
                        else
                        {
                            tank.voice.PlayVoiceLine("TankKill");
                        }
                    }
                    var dad = liveMixin.gameObject.GetComponent<DadDamageHandler>();
                    if (dad != null)
                    {
                        dad.forceExplosionImmediately = true;
                    }
                }
            }
        }

        private void PlayExplodeFX(Vector3 location)
        {
            FMODAsset sound;
            var distance = Vector3.Distance(MainCameraControl.main.transform.position, location);
            if (distance > _distantExplosionThreshold)
            {
                sound = _explodeSoundFar;
            }
            else
            {
                sound = _explodeSoundClose;
            }
            Utils.PlayFMODAsset(sound, location);
            if (distance < 60f)
            {
                if (Mod.config.EnableTorpedoFlash)
                {
                    FadingOverlay.PlayFX(Color.white, 0f, 0f, 1f);
                }
            }
            if (distance < 100f)
            {
                MainCameraControl.main.ShakeCamera(3f, 3f, MainCameraControl.ShakeMode.Quadratic, 0.8f);
            }
            WorldForces.AddExplosion(location, DayNightCycle.main.timePassed, 500f, 10f);
        }
    }
}