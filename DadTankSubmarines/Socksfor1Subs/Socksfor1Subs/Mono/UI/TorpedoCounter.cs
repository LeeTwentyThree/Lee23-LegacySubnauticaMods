using UnityEngine;
using UnityEngine.UI;

namespace Socksfor1Subs.Mono.UI
{
    public class TorpedoCounter : MonoBehaviour
    {
        public int Count
        {
            set
            {
                _count = value;
                UpdateImages();
            }
        }

        private int _count;

        private Image[] _images;
        private Color _disabledColor = new Color(0.038f, 0.038f, 0.038f, 0.61f);
        private Color _activeColor = new Color(0.91f, 0.97f, 0.52f, 1f);

        private void Start()
        {
            _images = GetComponentsInChildren<Image>();
        }

        private void UpdateImages()
        {
            var lastIndex = _count - 1;
            for (int i = 0; i < _images.Length; i++)
            {
                _images[i].color = (i <= lastIndex) ? _activeColor : _disabledColor;
            }
        }
    }
}
