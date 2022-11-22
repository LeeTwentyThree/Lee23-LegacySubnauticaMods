using UWE;
using System.Collections;
using UnityEngine;

namespace Socksfor1Subs
{
    public static class CustomPlayerAnimations
    {
        private static GameObject _playerRoot;

        private static void GetPlayerRoot()
        {
            if (_playerRoot == null)
            {
                _playerRoot = Player.main.transform.Find("body/player_view").gameObject;
            }
        }

        private static RuntimeAnimatorController defaultController;

        /// <summary>
        /// Overrides the player's current animation, and forces it to use <paramref name="animationController"/>. After <paramref name="duration"/>, normal control will be restored.
        /// </summary>
        /// <param name="animationController"></param>
        /// <param name="duration"></param>
        public static void PlayCustomAnimation(RuntimeAnimatorController animationController, float duration)
        {
            GetPlayerRoot();
            var animator = _playerRoot.GetComponent<Animator>();
            defaultController = animator.runtimeAnimatorController;
            animator.runtimeAnimatorController = animationController;
            if (duration > 0)
            {
                CoroutineHost.StartCoroutine(PlayAnimationCoroutine(animator, defaultController, duration));
            }
        }

        public static void EndCustomAnimation()
        {
            GetPlayerRoot();
            var animator = _playerRoot.GetComponent<Animator>();
            animator.runtimeAnimatorController = defaultController;
            animator.enabled = true;
        }

        private static IEnumerator PlayAnimationCoroutine(Animator animator, RuntimeAnimatorController defaultController, float duration)
        {
            yield return new WaitForSeconds(duration);
            animator.runtimeAnimatorController = defaultController;
            animator.enabled = true;
        }
    }
}
