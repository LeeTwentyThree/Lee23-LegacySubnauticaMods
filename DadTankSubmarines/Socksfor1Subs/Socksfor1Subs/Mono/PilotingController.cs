using UnityEngine;

namespace Socksfor1Subs.Mono
{
    public class PilotingController : MonoBehaviour
    {
        public GameObject cinematicRoot;
        private RuntimeAnimatorController _pilotingAnimator;
        private PlayerCinematicController _cinematicController;

        private bool _piloting;

        private void Start()
        {
            _pilotingAnimator = Mod.assetBundle.LoadAsset<RuntimeAnimatorController>("PilotDadSub_Animator");

            _cinematicController = cinematicRoot.AddComponent<PlayerCinematicController>();
            _cinematicController.animator = cinematicRoot.GetComponentInChildren<Animator>();
            _cinematicController.animatedTransform = cinematicRoot.transform.GetChild(0);
            _cinematicController.animParamReceivers = new GameObject[0];
            _cinematicController.animParam = "cinematic";
        }

        public bool Piloting
        {
            get
            {
                return _piloting;
            }
            set
            {
                _piloting = value;
                if (_piloting)
                {
                    CustomPlayerAnimations.PlayCustomAnimation(_pilotingAnimator, -1f);
                    _cinematicController.StartCinematicMode(Player.main);
                }
                else
                {
                    CustomPlayerAnimations.EndCustomAnimation();
                    _cinematicController.OnPlayerCinematicModeEnd();
                }
            }
        }
    }
}
