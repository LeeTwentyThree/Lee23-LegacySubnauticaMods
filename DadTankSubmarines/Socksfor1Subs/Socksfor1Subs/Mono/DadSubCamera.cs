using UnityEngine;

namespace Socksfor1Subs.Mono
{
    public class DadSubCamera : MonoBehaviour
    {
        public CameraManager cameraManager;

        private float _lookHorizontal;
        private float _lookVertical;
        private float _lookVerticalMin = -90f;
        private float _lookVerticalMax = 90f;
        private float mouseSensitivity = 1f;

        public bool Active
        {
            get
            {
                return cameraManager.activeCamera == this;
            }
        }

        public Transform PlayerViewTransform
        {
            get
            {
                return cameraManager.sittingPosition;
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
            PlayerViewTransform.localEulerAngles = Vector3.zero;
            if (inDefaultRotation)
            {
                ResetLook();
            }
            cameraManager.activeCamera = this;
            FadingOverlay.PlayFX(Color.black, 0f, 0.4f, 0.1f);
        }

        public void ResetLook()
        {
            ViewParent.localEulerAngles = Vector3.zero;
            ForgetRotation();
        }

        public virtual void ForgetRotation()
        {
            _lookHorizontal = 0f;
            _lookVertical = 0f;
        }

        private void Start()
        {
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
                if (GameInput.GetButtonDown(GameInput.Button.LeftHand))
                {
                    cameraManager.ExitCameras();
                }
            }
        }

        private void LateUpdate()
        {
            if (Active)
            {
                UpdateUseText();
            }
        }

        private void UpdateUseText()
        {
            string buttonFormat = LanguageCache.GetButtonFormat("PressToExit", GameInput.Button.LeftHand);
            HandReticle.main.SetUseTextRaw(buttonFormat, null);
            HandReticle.main.LateUpdate();
        }

        private void UpdateLook()
        {
            Vector2 lookDelta = GameInput.GetLookDelta();
            _lookHorizontal = _lookHorizontal + lookDelta.x * mouseSensitivity;
            _lookVertical = _lookVertical - lookDelta.y * mouseSensitivity;
            _lookVertical = Mathf.Clamp(_lookVertical, _lookVerticalMin, _lookVerticalMax);
            ViewParent.localEulerAngles = new Vector3(_lookVertical, _lookHorizontal, 0f);
        }
    }
}
