using UnityEngine;

namespace Socksfor1Subs.Mono
{
    public class Ladder : HandTarget, IHandTarget
    {
        public string interactText;
        public SubCinematic cinematic;

        private Transform _entrancePosition;

        private void Start()
        {
            _entrancePosition = transform.GetChild(0);
        }

        public void OnHandClick(GUIHand hand)
        {
            if (cinematic == null)
            {
                SetPlayerPosition();
            }
            else
            {
                if (!cinematic.PlayCinematic(SetPlayerPosition))
                {
                    SetPlayerPosition();
                }
            }
        }

        public void OnHandHover(GUIHand hand)
        {
            HandReticle.main.SetIcon(HandReticle.IconType.Interact);
            HandReticle.main.SetInteractText(interactText);
        }

        private void SetPlayerPosition()
        {
            Player.main.SetPosition(_entrancePosition.position);
        }
    }
}
