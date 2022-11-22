using UnityEngine;

namespace Socksfor1Subs.Mono
{
    public abstract class TankView : MonoBehaviour
    {
        public Tank tank;

        protected float _lookHorizontal;
        protected float _lookHorizontalMin = -120;
        protected float _lookHorizontalMax = 120f;
        protected float _lookVertical;
        protected float _lookVerticalMin = -80f;
        protected float _lookVerticalMax = 50f;
        protected float mouseSensitivity = 1f;

        public bool Active
        {
            get
            {
                return tank.activeView == this;
            }
        }

        public Transform PlayerViewTransform
        {
            get
            {
                return tank.playerPosition.transform; 
            }
        }

        public Transform ViewParent
        {
            get
            {
                return transform;
            }
        }

        public void SetActiveView(bool inDefaultRotation)
        {
            PlayerViewTransform.parent = ViewParent;
            PlayerViewTransform.localPosition = Vector3.zero;
            if (inDefaultRotation)
            {
                ResetLook();
            }
            tank.activeView = this;
        }

        private void Start()
        {
            InitializeFields();
            ForgetRotation();
            if (Active)
            {
                ResetLook();
            }
        }

        private void Update()
        {
            if (Active)
            {
                UpdateLook();
            }
        }

        private void UpdateLook()
        {
            Vector2 lookDelta = AvatarInputHandler.main.IsEnabled() ? GameInput.GetLookDelta() : Vector2.zero;
            _lookHorizontal = _lookHorizontal + lookDelta.x * mouseSensitivity;
            _lookHorizontal = Mathf.Clamp(_lookHorizontal, _lookHorizontalMin, _lookHorizontalMax);
            _lookVertical = _lookVertical - lookDelta.y * mouseSensitivity;
            _lookVertical = Mathf.Clamp(_lookVertical, _lookVerticalMin, _lookVerticalMax);
            PlayerViewTransform.localEulerAngles = new Vector3(_lookVertical, _lookHorizontal, 0f);
        }

        protected abstract void InitializeFields();

        public void ResetLook()
        {
            PlayerViewTransform.localEulerAngles = Vector3.zero;
            ForgetRotation();
            OnResetLook();
        }

        public virtual void ForgetRotation()
        {
            _lookHorizontal = 0f;
            _lookVertical = 0f;
        }

        protected virtual void OnResetLook()
        {

        }
    }
}
