using System.Collections.Generic;
using UnityEngine;

namespace Socksfor1Subs.Mono
{
    public class SubStealthManager : VehicleAccelerationModifier
    {
        public DadSubBehaviour sub;

        public List<Renderer> stealthRenderers = new List<Renderer>(); // Do not change this list after initialization I'm beginning you

        public Material cloakMaterial;

        public GameObject waterPlane;

        private List<Material> _defaultMaterials;

        private bool _stealthEnabled;

        private static FMODAsset _stealthEnable = Helpers.GetFmodAsset("DadStealthEnable");
        private static FMODAsset _stealthDisable = Helpers.GetFmodAsset("DadStealthDisable");

        private float _timeLastChanged;

        private float _charge = 1f;

        public float maxStealthDuration = 32f;
        public float maxRechargeDuration = 20f;
        public float rechargeDelay = 5f;
        public float overheatRecoveryTime = 3f;

        private float _timeCanRechargeAgain;

        private void Start()
        {
            _defaultMaterials = new List<Material>();
            foreach (var renderer in stealthRenderers)
            {
                foreach (var material in renderer.materials)
                {
                    if (ModifyMaterial(material))
                    {
                        _defaultMaterials.Add(material);
                    }
                }
            }
        }

        private void Update()
        {
            if (StealthEnabled)
            {
                if (IsOverheating)
                {
                    StealthEnabled = false;
                    _timeCanRechargeAgain = Time.time + rechargeDelay + overheatRecoveryTime;
                }
                if (sub.InfinitePower || (sub.powerRelay.GetPower() >= Time.deltaTime * Balance.StealthPowerUsagePerSecond && sub.powerRelay.ConsumeEnergy(Time.deltaTime * Balance.StealthPowerUsagePerSecond, out var _)))
                {
                    Charge -= Time.deltaTime / maxStealthDuration;
                }
                else
                {
                    StealthEnabled = false;
                }
            }
            if (CanRecharge)
            {
                Charge += Time.deltaTime / maxRechargeDuration;
                if (Charge > 0.9f && Charge < 1f)
                {
                    sub.voice.PlayVoiceLine("DadStealthReady");
                }
            }
        }

        public bool CanToggleStealthMode
        {
            get
            {
                return !IsOverheating;
            }
        }

        public bool JustToggled
        {
            get
            {
                return Time.time < _timeLastChanged + 3f;
            }
        }

        public float Charge
        {
            get
            {
                return _charge;
            }
            set
            {
                _charge = Mathf.Clamp01(value);
            }
        }

        public string ChargeFormatted
        {
            get 
            {
                return (Charge * 100f).ToString("0.0");
            }
        }

        public bool Recharging
        {
            get
            {
                return CanRecharge && !StealthEnabled;
            }
        }

        public bool CanRecharge
        {
            get
            {
                return !StealthEnabled && Time.time > _timeCanRechargeAgain && sub.live.IsAlive();
            }
        }

        public bool IsOverheating
        {
            get
            {
                return Charge <= 0.01f;
            }
        }

        public bool StealthEnabled
        {
            get
            {
                return _stealthEnabled;
            }
            set
            {
                if (value == _stealthEnabled)
                {
                    return;
                }
                _stealthEnabled = value;
                bool justChanged = JustToggled;
                CancelInvoke();
                FadingOverlay.PlayFX(Color.black, 0.1f, 0.5f, 1f);
                Invoke(nameof(UpdateStealthMaterial), 0.15f);
                if (StealthEnabled)
                {
                    sub.voice.PlayVoiceLine("DadStealthEnabled");
                    if (!justChanged)
                    {
                        Utils.PlayFMODAsset(_stealthEnable, Player.main.transform.position);
                    }
                    sub.ecoTarget.type = EcoTargetType.None;
                }
                else
                {
                    if (IsOverheating)
                    {
                        sub.voice.PlayVoiceLine("DadStealthDisabled", true);
                    }
                    if (!justChanged)
                    {
                        Utils.PlayFMODAsset(_stealthDisable, Player.main.transform.position);
                    }
                    sub.ecoTarget.type = EcoTargetType.Shark;
                    _timeCanRechargeAgain = Time.time + rechargeDelay;
                }
                _timeLastChanged = Time.time;
                sub.live.invincible = value;
            }
        }

        private void UpdateStealthMaterial()
        {
            StealthMaterialEnabled = StealthEnabled;
        }

        private bool StealthMaterialEnabled
        {
            set
            {
                waterPlane.SetActive(!value);
                var index = 0;
                foreach (var renderer in stealthRenderers)
                {
                    var materials = renderer.materials;
                    for (int i = 0; i < renderer.materials.Length; i++)
                    {
                        if (ModifyMaterial(renderer.materials[i]))
                        {
                            if (value)
                            {
                                materials[i] = cloakMaterial;
                            }
                            else
                            {
                                materials[i] = _defaultMaterials[index];
                            }
                            index++;
                        }
                    }
                    renderer.materials = materials;
                }
            }
        }

        private bool ModifyMaterial(Material material)
        {
            return !material.name.ToLower().Contains("glass");
        }

        public override void ModifyAcceleration(ref Vector3 acceleration)
        {
            if (StealthEnabled)
            {
                acceleration *= 0.7f;
            }
        }
    }
}
