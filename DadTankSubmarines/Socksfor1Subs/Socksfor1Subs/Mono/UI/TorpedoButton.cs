using UnityEngine;

namespace Socksfor1Subs.Mono.UI
{
    public class TorpedoButton : HUDButton<Tank>
    {
        public override void OnClick()
        {
            if (!IsInteractible())
            {
                return;
            }
            base.OnClick();
            sub.weapons.SetMode(TankWeapons.Mode.Torpedo);
        }

        protected override Sprite GetButtonImageThisFrame()
        {
            if (!IsInteractible())
            {
                return secondaryButtonSprite;
            }
            return primaryButtonSprite;
        }

        protected override bool IsInteractible()
        {
            return sub.weapons.CurrentMode != TankWeapons.Mode.Torpedo && sub.weapons.CanSwitchMode;
        }

        protected override string GetTooltip()
        {
            if (IsInteractible())
            {
                return "Enable Torpedo System";
            }
            else
            {
                return null;
            }
        }
    }
}
