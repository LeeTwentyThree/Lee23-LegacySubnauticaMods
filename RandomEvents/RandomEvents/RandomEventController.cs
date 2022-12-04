using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.UI;

namespace RandomEvents
{
    class RandomEventController : MonoBehaviour
    {
        public static RandomEventController main;
        private float timeNextEvent = 0f;
        private float timeNextGuaranteeSeamoth = 0f;
        private float timeNextGuaranteeExosuit = 0f;
        private float timeNextGuaranteeCyclops = 0f;
        private float timeNextGuaranteeGoodRain = 0f;
        private float timeNextGuaranteeBuilder = 0f;
        private float timeNextGuaranteeWelder = 0f;
        private float timeNextGuaranteeRadiationSuit = 0f;
        private float timeNextGuaranteeTorpedoLauncher = 0f;
        private string nameOfLastEventType;
        private float timeNextAutosave = 0f;
        private float timeGuaranteeGargSpawn = 10f;
        private bool spawnedGarg = false;

        private Text timerText;

        private static float RandomOffset
        {
            get
            {
                return Random.Range(-10f, 10f);
            }
        }

        public float MinutesToSeconds(float minutes)
        {
            return minutes * 60f;
        }

        private void ResetDelay()
        {
            timeNextEvent = Time.time + 30f;
        }
        private void SetSeamothInitialDelay()
        {
            timeNextGuaranteeSeamoth = Time.time + MinutesToSeconds(5f) + RandomOffset;
        }
        private void SetRadiationSuitDelay()
        {
            timeNextGuaranteeRadiationSuit = Time.time + MinutesToSeconds(13f) + RandomOffset;
        }
        private void SetSeamothTorpedoLauncherDelay()
        {
            timeNextGuaranteeTorpedoLauncher = Time.time + MinutesToSeconds(11f) + RandomOffset;
        }
        private void SetExosuitInitialDelay()
        {
            timeNextGuaranteeExosuit = Time.time + MinutesToSeconds(10f) + RandomOffset;
        }
        private void SetCyclopsInitialDelay()
        {
            timeNextGuaranteeCyclops = Time.time + MinutesToSeconds(15f) + RandomOffset;
        }
        private void SetSeamothAgainDelay()
        {
            timeNextGuaranteeSeamoth = Time.time + MinutesToSeconds(15f) + RandomOffset;
        }
        private void SetExosuitAgainDelay()
        {
            timeNextGuaranteeExosuit = Time.time + MinutesToSeconds(15f) + RandomOffset;
        }
        private void SetCyclopsAgainDelay()
        {
            timeNextGuaranteeCyclops = Time.time + MinutesToSeconds(15f) + RandomOffset;
        }
        private void SetGoodRainDelay()
        {
            timeNextGuaranteeGoodRain = Time.time + MinutesToSeconds(4.5f) + RandomOffset;
        }
        private void SetBuilderInitialDelay()
        {
            timeNextGuaranteeBuilder = Time.time + MinutesToSeconds(5f) + RandomOffset;
        }
        private void SetBuilderAgainDelay()
        {
            timeNextGuaranteeBuilder = Time.time + MinutesToSeconds(20f) + RandomOffset;
        }
        private void SetWelderInitialDelay()
        {
            timeNextGuaranteeWelder = Time.time + MinutesToSeconds(3f) + RandomOffset;
        }
        private void SetWelderAgainDelay()
        {
            timeNextGuaranteeWelder = Time.time + MinutesToSeconds(20f) + RandomOffset;
        }
        private void SetAutoSaveDelay()
        {
            timeNextAutosave = Time.time + MinutesToSeconds(4.5f);
        }
        private void SetGargantuanInitialDelay()
        {
            timeGuaranteeGargSpawn = Time.time + MinutesToSeconds(20f) + RandomOffset;
        }
        void Start()
        {
            main = this;
            InitCanvas();
            ResetDelay();
            SetGoodRainDelay();
            SetSeamothInitialDelay();
            SetExosuitInitialDelay();
            SetCyclopsInitialDelay();
            SetBuilderInitialDelay();
            SetAutoSaveDelay();
            SetRadiationSuitDelay();
            SetGargantuanInitialDelay();
            SetWelderInitialDelay();
            SetSeamothTorpedoLauncherDelay();
        }
        void Update()
        {
            timerText.text = string.Format("Time until next random event: {0} seconds", Mathf.RoundToInt(timeNextEvent - Time.time));
            if (Utils.InCutscene())
            {
                ResetDelay();
                return;
            }
            if (Time.time > timeNextEvent)
            {
                ResetDelay();
                DoRandomEvent();
            }

            if (Time.time > timeNextGuaranteeGoodRain)
            {
                SetGoodRainDelay();
                GuaranteeGoodRain();
            }

            if (Time.time > timeNextGuaranteeSeamoth)
            {
                SetSeamothAgainDelay();
                GuaranteeVehicle(VehicleType.Seamoth);
            }
            if (Time.time > timeNextGuaranteeExosuit)
            {
                SetExosuitAgainDelay();
                GuaranteeVehicle(VehicleType.Exosuit);
            }
            if (Time.time > timeNextGuaranteeCyclops)
            {
                SetCyclopsAgainDelay();
                GuaranteeVehicle(VehicleType.Cyclops);
            }
            if (Time.time > timeNextGuaranteeBuilder)
            {
                SetBuilderAgainDelay();
                Utils.ForceGive(TechType.Builder);
                ErrorMessage.AddMessage("You have been given a habitat builder for free!");
            }
            if (Time.time > timeNextGuaranteeWelder)
            {
                SetWelderAgainDelay();
                Utils.ForceGive(TechType.Welder);
                ErrorMessage.AddMessage("You have been given a Repair Tool for free!");
            }
            if (Time.time > timeNextGuaranteeRadiationSuit)
            {
                SetRadiationSuitDelay();
                Utils.ForceGive(TechType.RadiationSuit);
                Utils.ForceGive(TechType.RadiationGloves);
                Utils.ForceGive(TechType.RadiationHelmet);
                ErrorMessage.AddMessage("You have been given a Radiation Suit. You're welcome.");
            }
            if (Time.time > timeNextGuaranteeTorpedoLauncher)
            {
                SetSeamothTorpedoLauncherDelay();
                ErrorMessage.AddMessage("You have been given a Torpedo Launcher for your vehicles!");
                Utils.ForceGive(TechType.SeamothTorpedoModule);
                Utils.ForceGive(TechType.ExosuitTorpedoArmModule);
                Utils.ForceGive(TechType.GasTorpedo, 2);
                Utils.ForceGive(TechType.WhirlpoolTorpedo, 2);
            }
            if (Time.time > timeNextAutosave)
            {
                SetAutoSaveDelay();
                UWE.CoroutineHost.StartCoroutine(IngameMenu.main.SaveGameAsync());
            }
            if (spawnedGarg == false && Time.time > timeGuaranteeGargSpawn)
            {
                spawnedGarg = true;
                GuaranteeGarg();
            }
        }

        public void DoRandomEvent()
        {
            var type = Utils.GetRandomEvent(nameOfLastEventType);
            nameOfLastEventType = type.ToString();
            GameObject eventObj = new GameObject("Event object instance");
            eventObj.AddComponent(type);
        }
        public void GuaranteeVehicle(VehicleType type)
        {
            GameObject vehicleGuaranteer = new GameObject();
            vehicleGuaranteer.AddComponent<Events.GuaranteeVehicles>().vehicleType = type;
        }
        public void GuaranteeGarg()
        {
            GameObject gargGuaranteer = new GameObject();
            gargGuaranteer.AddComponent<Events.SpawnGargantuan>();
        }
        public void GuaranteeGoodRain()
        {
            GameObject vehicleGuaranteer = new GameObject();
            vehicleGuaranteer.AddComponent<Events.RainUseful>();
        }
        public void InitCanvas()
        {
            Canvas canvas = uGUI.main.screenCanvas;
            GameObject textObj = new GameObject("RandomEventTimer");
            textObj.layer = 5;
            timerText = textObj.EnsureComponent<Text>();
            timerText.color = Color.white;
            timerText.fontSize = 20;
            timerText.alignment = TextAnchor.MiddleLeft;
            timerText.raycastTarget = false;
            timerText.font = canvas.gameObject.GetComponentInChildren<Text>().font;
            var rect = textObj.EnsureComponent<RectTransform>();
            rect.SetParent(canvas.transform);
            rect.sizeDelta = new Vector2(500, 500);
            rect.anchoredPosition = new Vector2(250f, -1000f);
            rect.localPosition = new Vector3(80f, -400f, 0f);
            rect.localScale = Vector3.one;
            rect.localEulerAngles = Vector3.zero;
            var outline = textObj.EnsureComponent<Outline>();
            outline.effectColor = Color.black;
        }
    }
}
