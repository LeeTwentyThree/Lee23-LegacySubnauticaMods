using UnityEngine;
using UnityEngine.UI;

namespace Socksfor1Subs.Mono.UI
{
    public abstract class HUDButton<T> : MonoBehaviour where T : MonoBehaviour
    {
        public T sub;
        public Image buttonImage;
        public Button button;
        public HUDTooltip tooltip;
        public Sprite primaryButtonSprite;
        public Sprite secondaryButtonSprite;
        public Sprite deactiveButtonSprite;
        public string defaultTooltip;

        public void Setup(T sub, string defaultTooltip, Sprite primaryButtonSprite, Sprite secondaryButtonSprite, Sprite deactiveButtonSprite)
        {
            button = GetComponent<Button>();
            buttonImage = GetComponent<Image>();
            tooltip = gameObject.EnsureComponent<HUDTooltip>();
            this.defaultTooltip = defaultTooltip;
            tooltip.displayText = defaultTooltip;
            this.primaryButtonSprite = primaryButtonSprite;
            this.secondaryButtonSprite = secondaryButtonSprite;
            this.deactiveButtonSprite = deactiveButtonSprite;
            this.sub = sub;
        }

        public static B Create<B>(T sub, GameObject root, string defaultTooltip, Sprite primaryButtonSprite, Sprite secondaryButtonSprite, Sprite deactiveButtonSprite) where B : HUDButton<T>
        {
            var hudButton = root.AddComponent<B>();
            hudButton.Setup(sub, defaultTooltip, primaryButtonSprite, secondaryButtonSprite, deactiveButtonSprite);
            return hudButton;
        }

        private void Start()
        {
            button.onClick.AddListener(OnClickButton);
        }

        private void Update()
        {
            buttonImage.sprite = GetButtonImageThisFrame();
            tooltip.clickable = IsInteractible();
            tooltip.displayText = GetTooltip();
        }

        private void OnClickButton()
        {
            OnClick();
        }

        public virtual void OnClick()
        {
            PlayClickSound(ModAudio.SharedButtonClick);
        }

        protected void PlayClickSound(FMODAsset sound)
        {
            Utils.PlayFMODAsset(sound, Player.main.transform.position);
        }

        protected virtual bool IsInteractible()
        {
            return true;
        }
        
        protected virtual Sprite GetButtonImageThisFrame()
        {
            if (!IsInteractible())
            {
                return deactiveButtonSprite;
            }
            return primaryButtonSprite;
        }

        protected virtual string GetTooltip()
        {
            if (!IsInteractible())
            {
                return null;
            }
            return defaultTooltip;
        }
    }
}
