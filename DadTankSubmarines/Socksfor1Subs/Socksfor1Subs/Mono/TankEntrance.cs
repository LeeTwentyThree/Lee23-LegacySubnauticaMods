namespace Socksfor1Subs.Mono
{
    public class TankEntrance : HandTarget, IHandTarget
    {
        public Tank tank;

        public void OnHandClick(GUIHand hand)
        {
            tank.OnHandClick(hand);
        }

        public void OnHandHover(GUIHand hand)
        {
            tank.OnHandHover(hand);
        }
    }
}
