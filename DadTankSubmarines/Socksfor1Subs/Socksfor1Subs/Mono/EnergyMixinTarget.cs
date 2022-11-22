using UnityEngine;

namespace Socksfor1Subs.Mono
{
    public class EnergyMixinTarget : HandTarget, IHandTarget
    {
        public EnergyMixin energyMixin;

        public void OnHandClick(GUIHand hand)
        {
            energyMixin.InitiateReload();
        }

        public void OnHandHover(GUIHand hand)
        {
            energyMixin.HandHover();
        }
    }
}
