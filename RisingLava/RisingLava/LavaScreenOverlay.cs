using UnityEngine;
using UnityEngine.UI;

namespace RisingLava
{
    public class LavaScreenOverlay : MonoBehaviour
    {
        public Image overlayImage;

        private static LavaScreenOverlay _instance;

        public bool overlayEnabled;

        private float _currentAlpha = 0f;

        private float _showLavaScreenYOffset = 0.2f;

        private float _alphaDropSpeed = 0.5f;

        private float _mainMenuMaxAlpha = 0.1f;

        public static LavaScreenOverlay Instance
        {
            get
            {
                if (_instance != null)
                {
                    return _instance;
                }
                return EnsureInstance();
            }
        }

        public static LavaScreenOverlay EnsureInstance()
        {
            if (_instance != null)
            {
                return _instance;
            }
            _instance = Instantiate(Main.assetBundle.LoadAsset<GameObject>("LavaOverlay_Prefab")).AddComponent<LavaScreenOverlay>();
            _instance.overlayImage = _instance.gameObject.GetComponentInChildren<Image>();
            return _instance;
        }


        private bool ShouldShowOverlay()
        {
            var mainCamera = MainCamera.camera;
            if (mainCamera == null)
            {
                return false;
            }
            if (uGUI.main != null)
            {
                if (uGUI.main.respawning.loadingBackground.state == true)
                {
                    return false;
                }
            }
            return mainCamera.transform.position.y < Main.LavaLevel + _showLavaScreenYOffset;
        }

        private void Update()
        {
            overlayEnabled = ShouldShowOverlay();
            bool mainMenu = uGUI_MainMenu.main != null;
            if (overlayEnabled)
            {
                _currentAlpha = mainMenu ? _mainMenuMaxAlpha : 1f;
            }
            else
            {
                _currentAlpha -= _alphaDropSpeed * Time.deltaTime;
            }
            overlayImage.color = new Color(1f, 1f, 1f, _currentAlpha);
        }
    }
}
