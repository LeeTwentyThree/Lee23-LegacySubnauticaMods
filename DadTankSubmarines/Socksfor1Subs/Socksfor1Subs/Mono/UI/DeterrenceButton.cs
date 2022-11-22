using UnityEngine;

namespace Socksfor1Subs.Mono.UI
{
    public class DeterrenceButton : HUDButton<DadSubBehaviour>
    {
        public override void OnClick()
        {
            if (!IsInteractible())
            {
                return;
            }
            base.OnClick();
            sub.deterCreatures.DeterInRange();
        }

        protected override bool IsInteractible()
        {
            return sub.deterCreatures.CanDeter;
        }

        protected override Sprite GetButtonImageThisFrame()
        {
            if (!IsInteractible())
            {
                return secondaryButtonSprite;
            }
            return primaryButtonSprite;
        }

        protected override string GetTooltip()
        {
            if (!IsInteractible())
            {
                return null;
            }
            return "Enable Deterrence System";
        }
    }
}
