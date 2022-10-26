using UWE;
using System.Collections;
using UnityEngine;

// taken from Architect's Library (AotU). code written by me, either way, though
namespace TimTheEnchanter
{
    public static class CustomPlayerAnimations
    {
        private static GameObject _playerRoot;

        private static void EnsurePlayerRoot()
        {
            if (_playerRoot == null)
            {
                _playerRoot = Player.main.transform.Find("body/player_view").gameObject;
            }
        }

        /// <summary>
        /// Overrides the player's current animation, and forces it to use <paramref name="animationController"/>. After <paramref name="duration"/>, normal control will be restored.
        /// </summary>
        /// <param name="animationController"></param>
        /// <param name="duration"></param>
        public static void PlayCustomAnimation(RuntimeAnimatorController animationController, float duration)
        {
            EnsurePlayerRoot();
            var animator = _playerRoot.GetComponent<Animator>();
            var defaultController = animator.runtimeAnimatorController;
            animator.runtimeAnimatorController = animationController;
            CoroutineHost.StartCoroutine(PlayAnimationCoroutine(animator, defaultController, duration));
        }

        private static IEnumerator PlayAnimationCoroutine(Animator animator, RuntimeAnimatorController defaultController, float duration)
        {
            yield return new WaitForSeconds(duration);
            animator.runtimeAnimatorController = defaultController;
            animator.enabled = true;
        }
    }
}