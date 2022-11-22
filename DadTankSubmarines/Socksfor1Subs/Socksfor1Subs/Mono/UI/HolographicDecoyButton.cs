using UnityEngine;

namespace Socksfor1Subs.Mono.UI
{
    public class HolographicDecoyButton : HUDButton<DadSubBehaviour>
    {
        public override void OnClick()
        {
            if (!IsInteractible())
            {
                return;
            }
            base.OnClick();
            sub.holographicDecoyManager.SpawnDecoys();
        }

        protected override bool IsInteractible()
        {
            return sub.holographicDecoyManager.CanSpawn;
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
            return "Deploy Holographic Decoy";
        }
    }
}
