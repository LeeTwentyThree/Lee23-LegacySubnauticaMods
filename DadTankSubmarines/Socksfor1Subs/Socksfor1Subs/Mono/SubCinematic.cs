using System;
using UnityEngine;

namespace Socksfor1Subs.Mono
{
    public class SubCinematic : MonoBehaviour
    {
        public PlayerCinematicController controller;
        public float length;
        public string playerAnim;
        public string animatorParam;
        public Action finishCinematicAction;
        public FMODAsset sound;
        public Transform endTransform;

        public void Initialize(string playerAnim, string animatorParam, float length, FMODAsset sound = null, Transform endTransform = null)
        {
            this.length = length;
            this.playerAnim = playerAnim;
            this.animatorParam = animatorParam;
            this.sound = sound;
            this.endTransform = endTransform;
        }

        private void Start()
        {
            controller = gameObject.EnsureComponent<PlayerCinematicController>();
            controller.animator = GetComponent<Animator>();
            controller.animParamReceivers = new GameObject[0];
            controller.playerViewAnimationName = playerAnim;
            controller.animParam = animatorParam;
            controller.animatedTransform = transform.GetChild(0);
            controller.endTransform = endTransform;
        }

        public bool PlayCinematic(Action onFinished)
        {
            if (PlayerCinematicController.cinematicModeCount > 0)
            {
                return false;
            }
            if (!Inventory.main.ReturnHeld(true))
            {
                return false;
            }
            finishCinematicAction = onFinished;
            Invoke(nameof(FinishCinematic), length);
            if (sound != null)
            {
                Utils.PlayFMODAsset(sound, Player.main.transform.position);
            }
            controller.StartCinematicMode(Player.main);
            return true;
        }

        private void FinishCinematic()
        {
            controller.OnPlayerCinematicModeEnd();
            if (finishCinematicAction != null)
            {
                finishCinematicAction.Invoke();
            }
        }
    }
}
