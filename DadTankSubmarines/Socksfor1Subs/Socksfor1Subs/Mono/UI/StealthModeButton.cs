using UnityEngine;

namespace Socksfor1Subs.Mono.UI
{
    public class StealthModeButton : HUDButton<DadSubBehaviour>
    {
        public override void OnClick()
        {
            if (!IsInteractible() || Stealth.JustToggled)
            {
                return;
            }
            base.OnClick();
            Stealth.StealthEnabled = !Stealth.StealthEnabled;
        }

        public SubStealthManager Stealth // shorthand
        {
            get
            {
                return sub.stealthManager;
            }
        }

        protected override bool IsInteractible()
        {
            return Stealth.CanToggleStealthMode;
        }

        protected override Sprite GetButtonImageThisFrame()
        {
            if (!IsInteractible())
            {
                return deactiveButtonSprite;
            }
            if (Stealth.StealthEnabled)
            {
                return secondaryButtonSprite;
            }
            return primaryButtonSprite;
        }

        protected override string GetTooltip()
        {
            if (!IsInteractible() || Stealth.JustToggled)
            {
                return null;
            }
            if (Stealth.StealthEnabled)
            {
                return "Disable Stealth Mode";
            }
            else
            {
                return "Enable Stealth Mode";
            }
        }
    }
}
