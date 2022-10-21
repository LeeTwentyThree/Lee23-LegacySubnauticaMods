using UnityEngine;

namespace Socksfor1Subs.Mono
{
    public class AnimatedDoor : MonoBehaviour
    {
        public Vector3 eulersOpen;
        public Vector3 eulersClosed;
        public float openLength;
        public float closeLength;
        public FMODAsset openSound;
        public FMODAsset closeSound;

        public State CurrentState { get { return _currentState; } }

        private float _timeTransitionStart = float.MinValue;
        private Vector3 _lastEulers;
        private Quaternion _quaternionOpen;
        private Quaternion _quaternionClosed;
        private Quaternion _lastQuaternion;
        private State _currentState;

        public void Setup(Vector3 eulersOpen, Vector3 eulersClosed, State defaultState, float openLength, float closeLength)
        {
            this.eulersOpen = eulersOpen;
            this.eulersClosed = eulersClosed;
            this.openLength = openLength;
            this.closeLength = closeLength;
            _lastEulers = TargetEuler(InverseState(defaultState));
            SetState(defaultState, true);
        }

        private void Start()
        {
            _quaternionOpen = Quaternion.Euler(eulersOpen);
            _quaternionClosed = Quaternion.Euler(eulersClosed);
        }

        public void SetState(State newState, bool mute = false)
        {
            if (IsTransitioning())
            {
                return;
            }
            if (newState == _currentState)
            {
                return;
            }
            _currentState = newState;
            _lastEulers = TargetEuler(InverseState(newState));
            _lastQuaternion = Quaternion.Euler(_lastEulers);
            if (!mute)
            {
                PlaySound(newState == State.Open? openSound : closeSound);
            }
            _timeTransitionStart = Time.time;
        }

        private void PlaySound(FMODAsset sound)
        {
            if (sound != null && sound.path != null)
            {
                Utils.PlayFMODAsset(sound, transform.position);
            }
        }

        public enum State
        {
            Open,
            Close
        }

        public bool IsTransitioning()
        {
            return Time.time < _timeTransitionStart + TransitionLength;
        }

        private void Update()
        {
            if (IsTransitioning())
            {
                transform.localRotation = Quaternion.Lerp(_lastQuaternion, TargetQuaternion(_currentState), (Time.time - _timeTransitionStart) / TransitionLength);
            }
            else
            {
                transform.localRotation = TargetQuaternion(_currentState);
            }
        }

        public static State InverseState(State state)
        {
            if (state == State.Open)
            {
                return State.Close;
            }
            return State.Open;
        }

        private float TransitionLength
        {
            get
            {
                if (_currentState == State.Close)
                {
                    return closeLength;
                }
                else
                {
                    return openLength;
                }
            }
        }

        private Vector3 TargetEuler(State state)
        {
            if (state == State.Open)
            {
                return eulersOpen;
            }
            else
            {
                return eulersClosed;
            }
        }

        private Quaternion TargetQuaternion(State state)
        {
            if (state == State.Open)
            {
                return _quaternionOpen;
            }
            else
            {
                return _quaternionClosed;
            }
        }
    }
}
