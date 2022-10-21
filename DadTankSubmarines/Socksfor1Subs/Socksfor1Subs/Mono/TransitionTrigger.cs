using UnityEngine;

namespace Socksfor1Subs.Mono
{
    public class TransitionTrigger : MonoBehaviour
    {
        public WaterTransition manager;
        public Type type;

        public enum Type
        {
            Air,
            Water
        }

        private void OnTriggerEnter(Collider collider)
        {
            var isPlayer = collider.gameObject.GetComponentInParent<Player>() != null;
            if (isPlayer)
            {
                switch (type)
                {
                    default:
                        return;
                        case Type.Air:
                        if (Player.main.GetCurrentSub() == null && manager.CanPlayEnterSound())
                        {
                            if (manager.sub is DadSubBehaviour dad)
                            {
                                dad.PlayWelcomeVoiceLine();
                            }
                        }
                        Player.main.SetCurrentSub(manager.sub);
                        manager.OnSetMode(type);
                        return;
                    case Type.Water:
                        if (Player.main.GetCurrentSub() != manager.sub) 
                        {
                            return;
                        }
                        Player.main.SetCurrentSub(null);
                        manager.OnSetMode(type);
                        return;
                }
            }
        }
    }
}
