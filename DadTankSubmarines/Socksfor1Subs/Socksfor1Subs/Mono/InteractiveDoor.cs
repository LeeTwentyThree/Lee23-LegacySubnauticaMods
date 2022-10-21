using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Socksfor1Subs.Mono
{
    public class InteractiveDoor : HandTarget, IHandTarget
    {
        public AnimatedDoor animations;

        public string idleText;
        public string openText;
        public string closeText;

        public void OnHandClick(GUIHand hand)
        {
            if (animations.IsTransitioning())
            {
                return;
            }
            animations.SetState(AnimatedDoor.InverseState(animations.CurrentState));
        }

        public void OnHandHover(GUIHand hand)
        {
            if (animations.IsTransitioning())
            {
                HandReticle.main.SetInteractText(idleText, false, HandReticle.Hand.None);
                HandReticle.main.SetIcon(HandReticle.IconType.HandDeny);
                return;
            }
            if (animations.CurrentState == AnimatedDoor.State.Open)
            {
                HandReticle.main.SetInteractText(closeText, false, HandReticle.Hand.Left);
            }
            else
            {
                HandReticle.main.SetInteractText(openText, false, HandReticle.Hand.Left);
            }
            HandReticle.main.SetIcon(HandReticle.IconType.Hand);
        }
    }
}