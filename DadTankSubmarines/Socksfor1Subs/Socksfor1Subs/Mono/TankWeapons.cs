using UnityEngine;

namespace Socksfor1Subs.Mono
{
    public class TankWeapons : MonoBehaviour
    {
        public Tank tank;

        public Transform barrelEnd;

        public FMOD_CustomLoopingEmitter reelEmitter;

        private Mode _mode;

        private bool _fired;
        private bool _letGo;
        private bool _boost;
        private bool _switchingView;
        private bool _switchingWeapon;

        private GameObject _torpedoPrefab;
        private GameObject _harpoonPrefab;

        private bool _prefabsLoaded;

        private float _timeModeChanged;
        private float _timeTorpedoLastShot;
        private float _timeTorpedoesDepleted;
        private int _torpedoes = 6;
        private int _maxTorpedoes = 6;
        private float _timeTorpedoLastRegened;

        private float _torpedoFireDelay = 1.5f;
        private float _torpedoFireDuration = 0.5f;
        private float _torpedoRegenTime = 5f;
        private float _torpedoDepletePunishment = 8f;

        private Harpoon _currentHarpoon;
        private bool _harpoonWasDeployed;
        private float _harpoonDragTankVelocity = 3f;
        private float _harpoonMirrorVelocityMultiplier = 0.9f;
        private float _timeFiredHarpoon;
        private float _harpoonMinRetractTime = 0.3f;

        private float _timeLastBoosted;
        private float _boostCooldown = 5f;
        private float _boostForce = 40f;

        private FMODAsset _torpedoFireSound = Helpers.GetFmodAsset("event:/sub/seamoth/torpedo_fire");
        private FMODAsset _harpoonFireSound = Helpers.GetFmodAsset("TankShootHarpoon");
        private FMODAsset _harpoonReturnSound = Helpers.GetFmodAsset("TankReloadHarpoon");
        private FMODAsset _boostSound = Helpers.GetFmodAsset("TankBoost");
        private FMODAsset _cancelReelInSound = Helpers.GetFmodAsset("TankCancelReelIn");

        public bool JustChangedMode
        {
            get
            {
                return Time.time >= _timeModeChanged && Time.time < _timeModeChanged + 0.5f;
            }
        }

        public bool TorpedoOnCooldown
        {
            get
            {
                return Time.time >= _timeTorpedoLastShot && Time.time < _timeTorpedoLastShot + _torpedoFireDelay;
            }
        }

        public bool ShootingTorpedo
        {
            get
            {
                return Time.time >= _timeTorpedoLastShot && Time.time < _timeTorpedoLastShot + _torpedoFireDuration;
            }
        }

        public bool JustShotHarpoon
        {
            get
            {
                return Time.time >= _timeFiredHarpoon && Time.time < _timeFiredHarpoon + _harpoonMinRetractTime;
            }
        }

        public bool PunishedForDepletion
        {
            get
            {
                return Time.time >= _timeTorpedoesDepleted && Time.time < _timeTorpedoesDepleted + _torpedoDepletePunishment;
            }
        }

        public bool HarpoonDeployed
        {
            get
            {
                return _currentHarpoon != null;
            }
        }

        public bool ReelingInHarpoon
        {
            get
            {
                if (!HarpoonDeployed)
                {
                    return false;
                }
                return _currentHarpoon.BeingReeledIn;
            }
        }

        public Mode CurrentMode
        {
            get
            {
                return _mode;
            }
        }

        public Harpoon CurrentHarpoon
        {
            get
            {
                return _currentHarpoon;
            }
        }

        public int TorpedoCount
        {
            get
            {
                return _torpedoes;
            }
            set
            {
                int torpedoesBefore = _torpedoes;
                _torpedoes = value;
                tank.hud.torpedoCounter.Count = _torpedoes;
                if (_torpedoes == 0)
                {
                    tank.voice.PlayVoiceLine("TankNoTorpedoes");
                    _timeTorpedoesDepleted = Time.time;
                }
                if (_torpedoes == _maxTorpedoes - 1 && _torpedoes < torpedoesBefore)
                {
                    _timeTorpedoLastRegened = Time.time; // don't want to immediately get it back!
                }
            }
        }

        public int MaxTorpedoes
        {
            get
            {
                return _maxTorpedoes;
            }
        }

        public bool CanSwitchMode
        {
            get
            {
                if (ShootingTorpedo)
                {
                    return false;
                }
                /*if (HarpoonDeployed)
                {
                    return false;
                }*/
                return true;
            }
        }

        public void SetMode(Mode mode)
        {
            _mode = mode;
            _timeModeChanged = Time.time;
        }

        public enum Mode
        {
            Torpedo,
            Harpoon
        }
        
        private void Start()
        {
            GetPrefabs();
        }

        private void GetPrefabs()
        {
            _torpedoPrefab = Instantiate(Mod.assetBundle.LoadAsset<GameObject>("Torpedo_Prefab"));
            _torpedoPrefab.SetActive(false);
            var torpedoComponent = _torpedoPrefab.AddComponent<ExplosiveTorpedo>();
            var torpedoEmitter = _torpedoPrefab.AddComponent<FMOD_CustomLoopingEmitter>();
            torpedoEmitter.asset = _torpedoFireSound;
            torpedoEmitter.followParent = true;
            torpedoComponent.emitter = torpedoEmitter;
            torpedoComponent.modelTransform = _torpedoPrefab.transform.GetChild(0);
            torpedoComponent.rb = _torpedoPrefab.AddComponent<Rigidbody>();
            torpedoComponent.rb.useGravity = false;
            torpedoComponent.rb.mass = 50f;
            var torpedoWf = _torpedoPrefab.AddComponent<WorldForces>();
            torpedoWf.useRigidbody = torpedoComponent.rb;
            torpedoWf.underwaterGravity = 0f;
            torpedoWf.underwaterDrag = 1f;
            torpedoComponent.worldForces = torpedoWf;
            Helpers.ApplySNShaders(_torpedoPrefab);
            _torpedoPrefab.AddComponent<SkyApplier>().renderers = _torpedoPrefab.GetComponentsInChildren<Renderer>();

            _harpoonPrefab = Instantiate(Mod.assetBundle.LoadAsset<GameObject>("Harpoon_Prefab"));
            _harpoonPrefab.SetActive(false);
            var harpoonComponent = _harpoonPrefab.AddComponent<Harpoon>();
            harpoonComponent.rb = _harpoonPrefab.AddComponent<Rigidbody>();
            harpoonComponent.rb.useGravity = false;
            harpoonComponent.rb.mass = 50f;
            var harpoonWf = _harpoonPrefab.AddComponent<WorldForces>();
            harpoonWf.useRigidbody = harpoonComponent.rb;
            harpoonWf.underwaterGravity = 0f;
            harpoonWf.underwaterDrag = 1f;
            harpoonComponent.worldForces = harpoonWf;
            harpoonComponent.chainAttach = Helpers.FindChild(_harpoonPrefab, "ChainAttach").transform;
            harpoonComponent.collider = _harpoonPrefab.GetComponent<Collider>();
            Helpers.ApplySNShaders(_harpoonPrefab);
            _harpoonPrefab.AddComponent<SkyApplier>().renderers = _harpoonPrefab.GetComponentsInChildren<Renderer>();

            _prefabsLoaded = true;
        }

        private void Update()
        {
            if (!_prefabsLoaded)
            {
                return;
            }
            UpdateWeaponInput();
            ManageTorpedoRegeneration();
            ManageSounds();
        }

        private void FixedUpdate()
        {
            if (HarpoonDeployed)
            {
                ManageHarpoonPhysics();
            }
        }

        private void ManageHarpoonPhysics()
        {
            if (_currentHarpoon.AttachedToAnything)
            {
                bool attachedToMovingObject = _currentHarpoon.AttachedToSomethingMoving;
                bool draggingInObject = _currentHarpoon.DraggingObjectIn;
                bool reeledIn = _currentHarpoon.BeingReeledIn;
                if (!reeledIn && attachedToMovingObject)
                {
                    tank.useRigidbody.AddForce(_currentHarpoon.PulledInRigidbody.velocity * _harpoonMirrorVelocityMultiplier * Time.deltaTime, ForceMode.VelocityChange);
                }
                else if (reeledIn && !draggingInObject)
                {
                    tank.useRigidbody.AddForce((_currentHarpoon.transform.position - barrelEnd.position) * _harpoonDragTankVelocity * Time.deltaTime, ForceMode.VelocityChange);
                }
            }
        }

        private void ManageTorpedoRegeneration()
        {
            if (Time.time > _timeTorpedoLastRegened + _torpedoRegenTime && TorpedoCount < MaxTorpedoes && !PunishedForDepletion)
            {
                RegenTorpedo();
            }
        }

        private void RegenTorpedo()
        {
            _timeTorpedoLastRegened = Time.time;
            TorpedoCount++;
        }

        private void LateUpdate()
        {
            UpdateWeapons();
        }

        private void ManageSounds()
        {
            if (_harpoonWasDeployed && HarpoonDeployed == false)
            {
                Utils.PlayFMODAsset(_harpoonReturnSound, transform.position);
            }
            _harpoonWasDeployed = HarpoonDeployed;
            if (HarpoonDeployed && _currentHarpoon.BeingReeledIn)
            {
                reelEmitter.Play();
            }
            else if (reelEmitter.playing)
            {
                reelEmitter.Stop();
            }
        }

        private void UpdateWeaponInput()
        {
            _fired = false;
            _letGo = false;
            _boost = false;
            _switchingView = false;
            _switchingWeapon = false;
            if (tank.GetPilotingMode())
            {
                if (AvatarInputHandler.main.IsEnabled() && !JustChangedMode)
                {
                    if (GameInput.GetButtonDown(GameInput.Button.LeftHand))
                    {
                        _fired = true;
                    }
                    if (!GameInput.GetButtonHeld(GameInput.Button.LeftHand))
                    {
                        _letGo = true;
                    }
                    if (GameInput.GetButtonDown(GameInput.Button.Sprint))
                    {
                        _boost = true;
                    }
                    if (GameInput.GetButtonDown(GameInput.Button.AltTool))
                    {
                        _switchingView = true;
                    }
                    if (GameInput.GetButtonDown(GameInput.Button.Reload))
                    {
                        _switchingWeapon = true;
                    }
                }

            }
        }

        private void ShootTorpedo()
        {
            _timeTorpedoLastShot = Time.time;
            var torpedo = Instantiate(_torpedoPrefab, barrelEnd.transform.position, barrelEnd.transform.rotation);
            var targetPosition = GetAimPosition(3f, 150f, 125f, out var targetTransform);
            torpedo.SetActive(true);
            var component = torpedo.GetComponent<ExplosiveTorpedo>();
            component.targetPosition = targetPosition;
            component.targetTransform = targetTransform;
            component.tank = tank;
            MainCameraControl.main.ShakeCamera(2f, 1f, MainCameraControl.ShakeMode.Linear, 1f);
            TorpedoCount--;
        }

        private void FireHarpoon()
        {
            var harpoon = Instantiate(_harpoonPrefab, barrelEnd.transform.position, barrelEnd.transform.rotation);
            var targetPosition = GetAimPosition(3f, 200f, 1500f, out var targetTransform);
            harpoon.SetActive(true);
            var component = harpoon.GetComponent<Harpoon>();
            component.targetPosition = targetPosition;
            component.targetTransform = targetTransform;
            component.tank = tank;
            _currentHarpoon = component;
            Utils.PlayFMODAsset(_harpoonFireSound, transform.position);
            _timeFiredHarpoon = Time.time;
        }

        private void CallBackHarpoon()
        {
            if (HarpoonDeployed && !_currentHarpoon.BeingReeledIn)
            {
                _currentHarpoon.CallBack();
            }
        }

        private void CancelReelIn()
        {
            if (HarpoonDeployed && _currentHarpoon.BeingReeledIn)
            {
                _currentHarpoon.CancelReelIn();
                Utils.PlayFMODAsset(_cancelReelInSound, transform.position);
            }
        }

        private Vector3 GetAimPosition(float minDistance, float maxDistance, float defaultDistance, out Transform targetTransform)
        {
            var camTransform = MainCameraControl.main.transform;
            targetTransform = null;
            Vector3 defaultPosition = camTransform.position + camTransform.forward * defaultDistance;
            if (Physics.Raycast(camTransform.position, camTransform.forward, out var hit, maxDistance, -1, QueryTriggerInteraction.Ignore))
            {
                var dist = hit.distance;
                if (dist < minDistance)
                {
                    return defaultPosition;
                }
                var lm = hit.collider.gameObject.GetComponentInParent<LiveMixin>();
                if (lm != null)
                {
                    targetTransform = lm.transform;
                }
                return hit.point;
            }
            return defaultPosition;
        }

        private bool TryConsumePower(float powerToConsume)
        {
            tank.energyInterface.GetValues(out float power, out float capacity);
            if (powerToConsume > power)
            {
                return false;
            }
            tank.energyInterface.ConsumeEnergy(powerToConsume);
            return true;
        }

        private void UpdateWeapons()
        {
            if (_switchingView)
            {
                tank.ToggleActiveView();
            }
            if (!JustChangedMode && !tank.hud.AnyButtonHovered())
            {
                if (_switchingWeapon)
                {
                    if (CurrentMode == Mode.Torpedo)
                    {
                        tank.hud.harpoonButton.OnClick();
                    }
                    else
                    {
                        tank.hud.torpedoButton.OnClick();
                    }
                    return;
                }
                if (_fired)
                {
                    if (CurrentMode == Mode.Torpedo && !TorpedoOnCooldown && TorpedoCount > 0)
                    {
                        if (TryConsumePower(Balance.TankTorpedoPowerUsage))
                        {
                            ShootTorpedo();
                        }
                        else
                        {
                            ErrorMessage.AddMessage("Insufficient power!");
                        }
                    }
                    if (CurrentMode == Mode.Harpoon && !HarpoonDeployed)
                    {
                        if (TryConsumePower(Balance.TankHarpoonPowerUsage))
                        {
                            FireHarpoon();
                        }
                        else
                        {
                            ErrorMessage.AddMessage("Insufficient power!");
                        }
                        return;
                    }
                }
                if (CurrentMode == Mode.Harpoon && HarpoonDeployed && !JustShotHarpoon)
                {
                    if (CurrentHarpoon.BeingReeledIn)
                    {
                        if (_fired)
                        {
                            CancelReelIn();
                        }
                    }
                    else
                    {
                        if (_fired || _letGo)
                        {
                            CallBackHarpoon();
                        }
                    }
                }
                if (_boost && Time.time > _timeLastBoosted + _boostCooldown)
                {
                    if (TryConsumePower(Balance.TankBoostPowerUsage))
                    {
                        Boost();
                    }
                    else
                    {
                        ErrorMessage.AddMessage("Insufficient power!");
                    }
                }
            }
        }

        private void Boost()
        {
            Utils.PlayFMODAsset(_boostSound, transform.position);
            tank.useRigidbody.AddForce(MainCameraControl.main.transform.forward * _boostForce, ForceMode.VelocityChange);
            _timeLastBoosted = Time.time;
        }
    }
}
