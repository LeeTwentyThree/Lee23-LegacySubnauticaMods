using UnityEngine;
using UnityEngine.UI;

namespace Socksfor1Subs.Mono.UI
{
    public class PilotHUD : MonoBehaviour
    {
        public DadSubBehaviour sub;
        public GameObject hudCanvas;

        public WarningSymbol leviathanWarning;

        public Text mainStatusText;
        public Text positionStatusText;
        public Text solarStatusText;

        public Text healthStatusText;
        public Text powerStatusText;

        public Button decoyButton;
        public Button deterButton;
        public Button stealthButton;

        public Image stealthBar;
        public Image deterrenceBar;

        private Transform _hudScaleTransform;
        private Vector3 _fullHudScale;
        private float _hudScaleDuration = 50f;

        private Color _statColorGood = new Color(1f, 0.84f, 0.043f);
        private Color _statColorBad = new Color(1f, 0.04f, 0.16f);

        private void Start()
        {
            _hudScaleTransform = hudCanvas.transform;
            _fullHudScale = _hudScaleTransform.localScale;
            _hudScaleTransform.localScale = Vector3.zero;
        }

        private void Update()
        {
            var hudEnabled = HudEnabled();
            _hudScaleTransform.localScale = Vector3.MoveTowards(_hudScaleTransform.localScale, hudEnabled ? _fullHudScale : Vector3.zero, Time.deltaTime / _hudScaleDuration);

            if (!hudEnabled)
            {
                return;
            }

            mainStatusText.text = GetMainStatus();
            positionStatusText.text = GetPositionStatus();
            solarStatusText.text = GetSolarStatus();

            healthStatusText.text = FormatPercent(sub.HealthPercentFormatted);
            healthStatusText.color = GetStatColor(sub.HealthPercent > 0.2f);
            powerStatusText.text = FormatPercent(sub.PowerPercentFormatted);
            powerStatusText.color = GetStatColor(sub.PowerPercent > 0.2f);

            stealthBar.fillAmount = GetStealthBarFill();
            deterrenceBar.fillAmount = GetDeterrenceBarFill();
        }

        private string GetMainStatus()
        {
            return string.Format("Status: {0}", sub.CurrentStatusFormatted);
        }

        private string GetPositionStatus()
        {
            return string.Format("Depth: {0}m\nSpeed: {1}km/h", sub.DepthInt, sub.SpeedKMHFormatted);
        }

        private string GetSolarStatus()
        {
            return string.Format("Solar Panel\nEfficency: {0}%", sub.SolarPowerPercentFormatted);
        }

        private string FormatPercent(string number)
        {
            return string.Format("{0}%", number);
        }

        private Color GetStatColor(bool good)
        {
            return good ? _statColorGood : _statColorBad;
        }

        private float GetStealthBarFill()
        {
            return Helpers.JessyMap(sub.stealthManager.Charge, 0f, 1f, 0.137f, 1f);
        }

        private float GetDeterrenceBarFill()
        {
            return Helpers.JessyMap(sub.deterCreatures.CooldownCompletionPercentage, 0f, 1f, 0.141f, 1f);
        }

        private bool HudEnabled()
        {
            if (sub.LOD.current != LODState.Full)
            {
                return false;
            }
            if (!sub.subControl.canAccel)
            {
                return false;
            }
            return true;
        }
    }
}
