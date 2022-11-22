using UnityEngine;

namespace Socksfor1Subs.Mono.UI
{
    public class HarpoonButton : HUDButton<Tank>
    {
        public override void OnClick()
        {
            if (!IsInteractible())
            {
                return;
            }
            base.OnClick();
            sub.weapons.SetMode(TankWeapons.Mode.Harpoon);
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
            return sub.weapons.CurrentMode != TankWeapons.Mode.Harpoon && sub.weapons.CanSwitchMode;
        }

        protected override string GetTooltip()
        {
            if (IsInteractible())
            {
                return "Enable Harpoon System";
            }
            else
            {
                return null;
            }
        }
    }
}
