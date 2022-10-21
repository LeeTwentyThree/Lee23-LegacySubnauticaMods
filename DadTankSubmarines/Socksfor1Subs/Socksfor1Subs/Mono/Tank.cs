using Socksfor1Subs.Mono.UI;
using UnityEngine;

namespace Socksfor1Subs.Mono
{
    public class Tank : Vehicle
    {
        public TankVoice voice;

        public TankAim aim;

        public override string vehicleDefaultName => "S.O.C.K. TANK";

        public override Vector3[] vehicleDefaultColors => new Vector3[] { new Vector3(0f, 0f, 1f) };

        public GameObject exteriorGlass;

        public EngineRpmSFXManager engineRpmSFX;

        public VFXVolumetricLight[] volumetricLights;

        public TankWeapons weapons;

        public TankHUD hud;

        public TankView activeView;

        public TankView mainView;
        public TankView bottomView;

        private float _steeringSpeed = 0.08f;

        private float _timeLastTurned;

        private bool _vehicleInMotion;

        public bool IsTurning
        {
            get
            {
                return Time.time > _timeLastTurned && Time.time < _timeLastTurned + 0.1f;
            }
        }

        private static FMODAsset _enterOnlineSound = Helpers.GetFmodAsset("TankStartup");

        public static bool inTank;

        public static readonly string[] slotIDArray = new string[]
        {
            "TankModule1",
            "TankModule2",
            "TankModule3",
            "TankModule4"
        };

        public override string[] slotIDs
        {
            get
            {
                return slotIDArray;
            }
        }

        public override void Start()
        {
            base.Start();
            SetRotationLocked(true);
            activeView = mainView;
        }

        public override void SetPlayerInside(bool inside)
        {
            base.SetPlayerInside(inside);
            inTank = inside;
        }

        public override bool GetAllowedToEject()
        {
            return !docked;
        }

        public override void EnterVehicle(Player player, bool teleport, bool playEnterAnimation = true)
        {
            base.EnterVehicle(player, teleport, playEnterAnimation);
            if (player != null)
            {
                if (!energyInterface.hasCharge)
                {
                    voice.PlayVoiceLine("TankNoPower");
                }
                else
                {
                    voice.PlayVoiceLine("TankWelcome");
                    Utils.PlayFMODAsset(_enterOnlineSound, transform.position);
                }
            }
        }

        public override void OnPilotModeBegin()
        {
            base.OnPilotModeBegin();
            inTank = true;
            mainView.SetActiveView(true);
            bottomView.ForgetRotation();
            DisableVolumetricLights();
        }

        public void EnableVolumetricLights()
        {
            for (int i = 0; i < volumetricLights.Length; i++)
            {
                volumetricLights[i].RestoreVolume();
            }
        }

        public void DisableVolumetricLights()
        {
            for (int i = 0; i < volumetricLights.Length; i++)
            {
                volumetricLights[i].DisableVolume();
            }
        }

        public override void OnPilotModeEnd()
        {
            base.OnPilotModeEnd();
            inTank = false;
            EnableVolumetricLights();
        }

        public void ToggleActiveView()
        {
            if (mainView.Active)
            {
                bottomView.SetActiveView(true);
            }
            else
            {
                mainView.SetActiveView(false);
            }
        }

        public override bool CanPilot()
        {
            return !FPSInputModule.current.lockMovement && IsPowered();
        }

        public override void Update()
        {
            base.Update();
            UpdateGlassVisiblity();
            UpdateSounds();
            if (GetPilotingMode())
            {
                string buttonFormat = GetPrimaryControlText() + " " + LanguageCache.GetButtonFormat("TankControlDisplay2", GameInput.Button.Sprint) + " " + LanguageCache.GetButtonFormat("TankControlDisplay3", GameInput.Button.Reload) + " " + LanguageCache.GetButtonFormat("TankControlDisplay4", GameInput.Button.AltTool) + "\n" + LanguageCache.GetButtonFormat("PressToExit", GameInput.Button.Exit);
                HandReticle.main.SetUseTextRaw(buttonFormat, string.Empty);
                Vector3 vector = AvatarInputHandler.main.IsEnabled() ? GameInput.GetMoveDirection() : Vector3.zero;
                if (vector.magnitude > 0.1f)
                {
                    ConsumeEngineEnergy(Time.deltaTime * Balance.TankEnginePowerConsumption * vector.magnitude);
                }
            }
        }

        private string GetPrimaryControlText()
        {
            if (weapons.CurrentMode == TankWeapons.Mode.Torpedo)
            {
                return LanguageCache.GetButtonFormat("TankTorpedoControl", GameInput.Button.LeftHand);
            }
            if (weapons.CurrentMode == TankWeapons.Mode.Harpoon)
            {
                if (!weapons.HarpoonDeployed)
                {
                    return LanguageCache.GetButtonFormat("TankHarpoonControlFire", GameInput.Button.LeftHand);
                }
                else if (weapons.ReelingInHarpoon)
                {
                    return LanguageCache.GetButtonFormat("TankHarpoonControlCancelReel", GameInput.Button.LeftHand);
                }
                else
                {
                    return LanguageCache.GetButtonFormat("TankHarpoonControlReel", GameInput.Button.LeftHand);
                }
            }
            return LanguageCache.GetButtonFormat("TankControlGeneric", GameInput.Button.LeftHand);
        }

        private void UpdateGlassVisiblity()
        {
            exteriorGlass.SetActive(!GetPilotingMode());
        }

        private void UpdateSounds()
        {
            if (_vehicleInMotion)
            {
                engineRpmSFX.AccelerateInput(1f);
            }
        }

        public override void FixedUpdate()
        {
            _vehicleInMotion = false;
            bool pilotingMode = GetPilotingMode();
            if (pilotingMode != lastPilotingState)
            {
                if (pilotingMode)
                {
                    OnPilotModeBegin();
                }
                else
                {
                    OnPilotModeEnd();
                }
                lastPilotingState = pilotingMode;
            }
            if (CanPilot())
            {
                if (pilotingMode)
                {
                    HandleMovement();
                }
                steeringWheelYaw = Mathf.Lerp(steeringWheelYaw, 0f, Time.deltaTime);
                steeringWheelPitch = Mathf.Lerp(steeringWheelPitch, 0f, Time.deltaTime);
                if (mainAnimator)
                {
                    mainAnimator.SetFloat("view_yaw", steeringWheelYaw * 70f);
                    mainAnimator.SetFloat("view_pitch", steeringWheelPitch * 45f);
                }
                if (stabilizeRoll)
                {
                    StabilizeRoll();
                }
            }
            prevVelocity = useRigidbody.velocity;
        }

        private void HandleMovement()
        {
            if (GetPilotingMode())
            {
                if (worldForces.IsAboveWater() != wasAboveWater)
                {
                    PlaySplashSound();
                    wasAboveWater = worldForces.IsAboveWater();
                }
                bool onGround = transform.position.y < Ocean.main.GetOceanLevel() && transform.position.y < worldForces.waterDepth && !precursorOutOfWater;
                if (moveOnLand || onGround)
                {
                    Vector3 moveInput = AvatarInputHandler.main.IsEnabled() ? GameInput.GetMoveDirection() : Vector3.zero;
                    Vector3 moveForward = new Vector3(0f, 0f, moveInput.z);
                    float forwardVelocity = Mathf.Max(0f, moveForward.z) * forwardForce + Mathf.Max(0f, -moveForward.z) * backwardForce;
                    moveForward = transform.rotation * moveForward;
                    moveForward.y = 0f;
                    moveForward = Vector3.Normalize(moveForward);
                    if (base.onGround)
                    {
                        moveForward = Vector3.ProjectOnPlane(moveForward, surfaceNormal);
                        moveForward.y = Mathf.Clamp(moveForward.y, -0.5f, 0.5f);
                        forwardVelocity *= onGroundForceMultiplier;
                    }
                    Vector3 b = new Vector3(0f, moveInput.y, 0f);
                    b.y *= verticalForce * Time.deltaTime;
                    Vector3 driveForce = forwardVelocity * moveForward * Time.deltaTime + b;
                    OverrideAcceleration(ref driveForce);
                    for (int j = 0; j < accelerationModifiers.Length; j++)
                    {
                        accelerationModifiers[j].ModifyAcceleration(ref driveForce);
                    }
                    useRigidbody.AddForce(driveForce, ForceMode.VelocityChange);

                    Vector3 rotationDirection = new Vector3(0f, moveInput.x, 0f);
                    Vector3 torque = rotationDirection * _steeringSpeed;
                    useRigidbody.AddTorque(torque, ForceMode.VelocityChange);

                    bool goingForward = Mathf.Abs(moveInput.z) > 0.5f;
                    bool turning = Mathf.Abs(moveInput.x) > 0.5f;

                    if (turning)
                    {
                        _timeLastTurned = Time.time;
                    }

                    if (turning || goingForward)
                    {
                        _vehicleInMotion = true;
                    }
                }
            }
        }

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

        private const float kMetersPerKilometer = 1000f;
        private const float kSecondsPerHour = 3600f;

        public float SpeedKMH
        {
            get
            {
                var metersPerSecond = useRigidbody.velocity.magnitude;
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

        public float HealthPercent
        {
            get
            {
                return liveMixin.health / liveMixin.maxHealth;
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
                if (!energyInterface.hasCharge)
                {
                    return 0f;
                }
                energyInterface.GetValues(out float charge, out float capacity);
                if (capacity == 0f) // dividing by zero is not a good idea
                {
                    return 0f;
                }
                return charge / capacity;
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
                if (!energyInterface.hasCharge)
                {
                    return Status.UNPOWERED;
                }
                if (HealthPercent < 0.5f)
                {
                    return Status.DAMAGED;
                }
                return Status.ONLINE;
            }
        }

        public string GetTextForStatus(Status status)
        {
            return status.ToString();
        }

        public string CurrentStatusFormatted
        {
            get
            {
                return GetTextForStatus(CurrentStatus);
            }
        }

        public enum Status
        {
            ONLINE,
            UNPOWERED,
            DAMAGED
        }
    }
}
