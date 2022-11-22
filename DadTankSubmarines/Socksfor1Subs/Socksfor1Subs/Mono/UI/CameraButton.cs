using UnityEngine;

namespace Socksfor1Subs.Mono.UI
{
    public class CameraButton : HUDButton<DadSubBehaviour>
    {
        public bool upper;

        public override void OnClick()
        {
            if (!IsInteractible())
            {
                return;
            }
            base.OnClick();
            if (upper)
            {
                sub.cameraManager.topCamera.SetActiveView(true);
            }
            else
            {
                sub.cameraManager.bottomCamera.SetActiveView(true);
            }
        }

        protected override bool IsInteractible()
        {
            return true;
        }

        protected override Sprite GetButtonImageThisFrame()
        {
            return primaryButtonSprite;
        }

        protected override string GetTooltip()
        {
            return "View camera";
        }
    }
}
