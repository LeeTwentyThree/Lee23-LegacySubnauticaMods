using UnityEngine;

namespace Socksfor1Subs.Mono
{
    public class DadSubEngine : MonoBehaviour
    {
        private DadSubBehaviour _sub;
        private SubControl _subControl;
        private bool _targetEngineState;
        private bool _currentEngineState;
        private float _powerUpDuration = 3f;
        private float _powerDownDuration = 0.5f;

        public FMOD_CustomLoopingEmitter enginePassiveEmitter;
        public FMOD_CustomEmitter engineStartupEmitter;
        public Transform glassRimTransform;

        private Vector3 _glassRimDefaultPos = new Vector3(0f, 2.55f, 13.33f);
        private Vector3 _glassRimDrivingPos = new Vector3(0f, 2.55f, 12f);
        private float _glassRimRetractDur = 3f;
        private float _glassRimResetDir = 2f;

        public bool ForceEngineOn { get; set; }

        public bool ForceEngineOff { get; set; }

        public bool EngineState
        {
            get
            {
                return _currentEngineState;
            }
            private set
            {
                if (_targetEngineState == value)
                {
                    return;
                }
                _targetEngineState = value;
                CancelInvoke();
                if (EngineIsPoweringUp())
                {
                    Invoke(nameof(FinishPoweringUp), _powerUpDuration);
                    _sub.voice.PlayVoiceLine("DadEngineOn");
                    MainCameraControl.main.ShakeCamera(4f, 4f, MainCameraControl.ShakeMode.BuildUp, 0.4f);
                    engineStartupEmitter.Play();
                }
                else if (EngineIsPoweringDown())
                {
                    Invoke(nameof(FinishPoweringDown), _powerDownDuration);
                    MainCameraControl.main.ShakeCamera(2f, 3f, MainCameraControl.ShakeMode.Cos, 0.4f);
                }
            }
        }

        private bool CurrentEngineState
        {
            get
            {
                return _currentEngineState;
            }
            set
            {
                _currentEngineState = value;
                _subControl.NewEngineMode(value);
            }
        }

        private void Start()
        {
            _sub = GetComponentInParent<DadSubBehaviour>();
            _subControl = GetComponentInParent<SubControl>();
        }

        public bool EngineIsPoweringUp()
        {
            return CurrentEngineState == false && _targetEngineState == true;
        }

        public bool EngineIsPoweringDown()
        {
            return CurrentEngineState == true && _targetEngineState == false;
        }

        private void FinishPoweringUp()
        {
            if (EngineIsPoweringUp())
            {
                CurrentEngineState = true;
                enginePassiveEmitter.Play();
            }
        }

        private void FinishPoweringDown()
        {
            if (EngineIsPoweringDown())
            {
                CurrentEngineState = false;
                enginePassiveEmitter.Stop();
            }
        }

        private void Update()
        {
            EngineState = GetDesiredEngineState();
            UpdateGlassRimPosition();
        }

        private void UpdateGlassRimPosition()
        {
            var targetPos = CurrentEngineState ? _glassRimDrivingPos : _glassRimDefaultPos;
            glassRimTransform.localPosition = Vector3.MoveTowards(glassRimTransform.localPosition, targetPos, Time.deltaTime / (CurrentEngineState ? _glassRimRetractDur : _glassRimResetDir));
        }

        private bool GetDesiredEngineState()
        {
            if (!_sub.powerRelay.IsPowered())
            {
                return false;
            }
            if (ForceEngineOn)
            {
                return true;
            }
            if (ForceEngineOff)
            {
                return false;
            }
            var chair = Player.main.GetPilotingChair();
            if (chair == null)
            {
                return false;
            }
            if (chair.subRoot == _sub)
            {
                return true;
            }
            return false;
        }
    }
}
