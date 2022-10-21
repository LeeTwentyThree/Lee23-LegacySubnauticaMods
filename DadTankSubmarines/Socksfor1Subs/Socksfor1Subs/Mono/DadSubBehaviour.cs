using UnityEngine;
using Socksfor1Subs.Mono.UI;

namespace Socksfor1Subs.Mono
{
    public class DadSubBehaviour : SubRoot
    {
        public AnimatedDoor[] exteriorDoors;

        public VFXConstructing constructing;

        public SubVoice voice;
        public SubStealthManager stealthManager;
        public SubControl subControl;
        public PilotHUD pilotHUD;
        public ScanForLeviathans scanForLeviathans;
        public DeterCreatures deterCreatures;
        public HolographicDecoyManager holographicDecoyManager;
        public EcoTarget ecoTarget;
        public SolarCharger solarCharger;
        public DadSubDock dock;
        public DadDamageHandler dadDamageHandler;
        public CameraManager cameraManager;

        private const float kMetersPerKilometer = 1000f;
        private const float kSecondsPerHour = 3600f;

        public float Depth
        {
            get
            {
                var y = transform.position.y;
                if (y > Ocean.main.GetOceanLevel())
                {
                    return Ocean.main.GetOceanLevel();
                }
                return Mathf.Abs(y);
            }
        }

        public int DepthInt
        {
            get
            {
                return Mathf.RoundToInt(Depth);
            }
        }

        public float SpeedKMH
        {
            get
            {
                var metersPerSecond = rigidbody.velocity.magnitude;
                var kilometersPerSecond = metersPerSecond / kMetersPerKilometer;
                var kmPerHour = kilometersPerSecond * kSecondsPerHour;
                return kmPerHour;
            }
        }

        public string SpeedKMHFormatted
        {
            get
            {
                return SpeedKMH.ToString("00.0");
            }
        }

        public float SolarPowerPercent
        {
            get
            {
                return solarCharger.Efficiency;
            }
        }

        public string SolarPowerPercentFormatted
        {
            get
            {
                return (SolarPowerPercent * 100).ToString("0.0");
            }
        }

        public float HealthPercent
        {
            get
            {
                return live.health / live.maxHealth;
            }
        }

        public string HealthPercentFormatted
        {
            get
            {
                return (HealthPercent * 100f).ToString("0.0");
            }
        }

        public float PowerPercent
        {
            get
            {
                if (powerRelay.GetMaxPower() == 0f)
                {
                    return 0f;
                }
                return powerRelay.GetPower() / powerRelay.GetMaxPower();
            }
        }

        public string PowerPercentFormatted
        {
            get
            {
                return (PowerPercent * 100f).ToString("0.0");
            }
        }

        public Status CurrentStatus
        {
            get
            {
                if (live == null)
                {
                    return Status.ERROR;
                }
                if (dadDamageHandler.AboutToExplode)
                {
                    return Status.EVACUATE;
                }
                if (!powerRelay.IsPowered())
                {
                    return Status.UNPOWERED;
                }
                if (stealthManager.StealthEnabled)
                {
                    return Status.HIDDEN;
                }
                if (scanForLeviathans.EnvironmentIsDangerous())
                {
                    return Status.DANGER;
                }
                if (HealthPercent < 0.5f)
                {
                    return Status.DAMAGED;
                }
                return Status.ONLINE;
            }
        }

        public string CurrentStatusFormatted
        {
            get
            {
                return GetTextForStatus(CurrentStatus);
            }
        }

        public bool InfinitePower
        {
            get
            {
                return !GameModeUtils.RequiresPower();
            }
        }

        public void PlayWelcomeVoiceLine()
        {
            if (powerRelay.IsPowered() && HealthPercent > 0.5f)
            {
                if (Random.value < 0.05f)
                {
                    voice.PlayVoiceLine("DadWelcomeSecret");
                }
                else
                {
                    voice.PlayVoiceLine("DadWelcomeAboard");
                }
            }
            else
            {
                voice.PlayVoiceLine("DadWelcomeNegative");
            }
        }

        public string GetTextForStatus(Status status)
        {
            return status.ToString();
        }

        public override void Awake()
        {
            LOD = GetComponent<BehaviourLOD>();
            rb = GetComponent<Rigidbody>();
            oxygenMgr = GetComponent<OxygenManager>();

            powerRelay = GetComponent<PowerRelay>();
            isBase = true;
            modulesRoot = transform;
            lightControl = GetComponentInChildren<LightingController>();

            voiceNotificationManager = Helpers.FindChild(gameObject, "VoiceSource").AddComponent<VoiceNotificationManager>();
            voiceNotificationManager.subRoot = this;
        }

        public override void OnTakeDamage(DamageInfo damageInfo)
        {
            base.OnTakeDamage(damageInfo);
            dadDamageHandler.PlayDamageNoise(damageInfo);
        }

        public enum Status
        {
            ONLINE,
            ERROR,
            UNPOWERED,
            DANGER,
            HIDDEN,
            EVACUATE,
            DAMAGED
        }
    }
}
