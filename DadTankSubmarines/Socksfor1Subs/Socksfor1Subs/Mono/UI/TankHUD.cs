using UnityEngine;
using UnityEngine.UI;

namespace Socksfor1Subs.Mono.UI
{
    public class TankHUD : MonoBehaviour
    {
        public Tank tank;

        public GameObject canvasRoot;
        public HarpoonButton harpoonButton;
        public TorpedoButton torpedoButton;
        public Text healthText;
        public Text powerText;
        public Text statusText;
        public TorpedoCounter torpedoCounter;

        private void Update()
        {
            var showHud = tank.GetPilotingMode();
            canvasRoot.SetActive(showHud);
            if (!showHud)
            {
                return;
            }

            healthText.text = tank.HealthPercentFormatted + "%";
            powerText.text = tank.PowerPercentFormatted + "%";
            statusText.text = string.Format("Status: {0}\nDepth: {1}m\nSpeed: {2}km/h", tank.CurrentStatusFormatted, tank.DepthInt, tank.SpeedKMHFormatted);
        }

        public bool AnyButtonHovered()
        {
            if (harpoonButton.tooltip.Hovering || torpedoButton.tooltip.Hovering)
            {
                return true;
            }
            return false;
        }
	}
}
