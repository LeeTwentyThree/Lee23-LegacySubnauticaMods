using UnityEngine;
using UnityEngine.UI;

namespace Socksfor1Subs.Mono.UI
{
    public class WarningSymbol : MonoBehaviour
    {
        public DadSubBehaviour sub;

        public bool show;

        public Image warningImage;

        public FMOD_CustomLoopingEmitter emitter;

        public Text warningText;

        private float _currentAlpha;

        private void Update()
        {
            _currentAlpha = Mathf.MoveTowards(_currentAlpha, TargetAlpha(), Time.deltaTime);
            warningImage.color = new Color(1f, 1f, 1f, _currentAlpha);
            warningText.enabled = show;
            if (emitter != null)
            {
                if (show && Player.main.GetCurrentSub() == sub && !sub.stealthManager.StealthEnabled)
                {
                    emitter.Play();
                }
                else
                {
                    emitter.Stop();
                }
            }
        }

        private float TargetAlpha()
        {
            if (show)
            {
                return Mathf.PingPong(Time.time, 0.5f);
            }
            return 0f;
        }
    }
}
