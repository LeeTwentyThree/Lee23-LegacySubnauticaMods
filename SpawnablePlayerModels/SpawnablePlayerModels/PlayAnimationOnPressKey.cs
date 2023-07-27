using UnityEngine;

namespace SpawnablePlayerModels
{
    internal class PlayAnimationOnPressKey : MonoBehaviour
    {
        private Animator _animator;
        private static int _waveParam = Animator.StringToHash("wave");

        private void Start()
        {
            _animator = GetComponentInChildren<Animator>();
        }

        private void Update()
        {
            if (Input.GetKeyDown(Mod.config.WaveKey))
            {
                _animator.SetTrigger(_waveParam);
            }
        }
    }
}
