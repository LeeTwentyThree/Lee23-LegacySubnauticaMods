using UnityEngine;
using UnityEngine.UI;

namespace RisingLava.Mono.Equipment
{
    public class LavaMonitorUI : MonoBehaviour
    {
        private Sprite[] imagesPerState;
        private Sprite[] idleDepthImages;
        private Sprite[] risingDepthImages;
        private string[] labelsPerState = new string[] { "No motion", "Rising", "Draining", "Limit reached" };

        private RectTransform tabMainRoot;
        private GameObject dangerRoot;
        private GameObject safeRoot;
        private GameObject approachingRoot;
        private Text statusText;
        private Text speedText;
        private Text timeText;
        private Text depthText;
        private Image statusImage;

        private void Start()
        {
            LoadAssets();
            GetReferences();
        }

        private void LoadAssets()
        {
            imagesPerState = new Sprite[] { LoadSprite("LavaTablet_State_Idle"), LoadSprite("LavaTablet_State_Rising"), LoadSprite("LavaTablet_State_Draining"), LoadSprite("LavaTablet_State_Stuck") };
            idleDepthImages = new Sprite[] { LoadSprite("LavaTablet_State_Idle"), LoadSprite("LavaTablet_State_Idle_LavaZone"), LoadSprite("LavaTablet_State_Idle_LostRiver"), LoadSprite("LavaTablet_State_Idle_DeepCave"), LoadSprite("LavaTablet_State_Idle_Deep"), LoadSprite("LavaTablet_State_Idle_Shallow"), LoadSprite("LavaTablet_State_Idle_AboveWaterLow"), LoadSprite("LavaTablet_State_Idle_AboveWaterHigh") };
            risingDepthImages = new Sprite[] { LoadSprite("LavaTablet_State_Rising"), LoadSprite("LavaTablet_State_Rising_LavaZone"), LoadSprite("LavaTablet_State_Rising_LostRiver"), LoadSprite("LavaTablet_State_Rising_DeepCave"), LoadSprite("LavaTablet_State_Rising_Deep"), LoadSprite("LavaTablet_State_Rising_Shallow"), LoadSprite("LavaTablet_State_Rising_AboveWaterLow"), LoadSprite("LavaTablet_State_Rising_AboveWaterHigh") };
        }

        private void GetReferences()
        {
            tabMainRoot = gameObject.transform.GetChild(0).GetComponent<RectTransform>();

            dangerRoot = tabMainRoot.Find("Danger").gameObject;
            safeRoot = tabMainRoot.Find("Safe").gameObject;
            approachingRoot = tabMainRoot.Find("Approaching").gameObject;

            statusText = tabMainRoot.Find("StateText").GetComponent<Text>();
            speedText = tabMainRoot.Find("SpeedText").GetComponent<Text>();
            timeText = tabMainRoot.Find("TimeText").GetComponent<Text>();
            depthText = tabMainRoot.Find("DepthText").GetComponent<Text>();

            statusImage = tabMainRoot.Find("StateImage").GetComponent<Image>();
        }

        private Sprite LoadSprite(string name)
        {
            return Main.assetBundle.LoadAsset<Sprite>(name);
        }

        private void Update()
        {
            var currentState = DetermineCurrentState();
            var statusSprite = imagesPerState[(int)currentState];
            if (currentState == LavaState.NotMoving)
            {
                statusSprite = idleDepthImages[(int)DetermineDepthLayer()];
            }
            if (currentState == LavaState.Rising)
            {
                statusSprite = risingDepthImages[(int)DetermineDepthLayer()];
            }
            statusImage.sprite = statusSprite;
            statusText.text = labelsPerState[(int)currentState];
            timeText.text = GetTimeText();
            speedText.text = GetSpeedText();
            depthText.text = GetDepthText();
            var safety = DetermineSafety();
            dangerRoot.SetActive(false);
            safeRoot.SetActive(false);
            approachingRoot.SetActive(false);
            switch (safety)
            {
                default:
                    break;
                case SafetyState.Safe:
                    safeRoot.SetActive(true);
                    break;
                case SafetyState.Danger:
                    dangerRoot.SetActive(true);
                    break;
                case SafetyState.Approaching:
                    approachingRoot.SetActive(true);
                    break;
            }
            dangerRoot.SetActive(IsInDanger());
        }

        public bool IsInDanger()
        {
            return Player.main.transform.position.y < Main.LavaLevel + 40f;
        }

        public string GetDepthText()
        {
            var depth = Main.LavaLevel;
            var absolute = Mathf.Abs(Mathf.Round(depth));
            if (depth < 0)
            {
                return $"{absolute}m below sea level";
            }
            else
            {
                return $"{absolute}m above sea level";
            }
        }

        public string GetSpeedText()
        {
            var main = LavaMove.main;
            if (main == null || Main.ActualLavaMoveSpeed == 0f)
            {
                return "N/A";
            }
            return (Main.ActualLavaMoveSpeed + Mathf.PerlinNoise(Time.time, 4f) - 0.5f).ToString("0.0") + " m/s";
        }

        public string GetTimeText()
        {
            var main = LavaMove.main;
            if (main == null || Main.ActualLavaMoveSpeed == 0f || !main.AutomaticallyChange)
            {
                return "Remaining time undeterminable";
            }
            if (Main.LavaLevel >= Main.MaxLavaLevel)
            {
                return "Eruption survived, congratulations!";
            }
            var heightDifference = Mathf.Abs(Main.MaxLavaLevel - Main.LavaLevel);
            var secondsToReachTop = heightDifference / Main.ActualLavaMoveSpeed;
            var hours = Mathf.Floor(secondsToReachTop / 3600);
            var minutes = Mathf.Floor((secondsToReachTop / 60) % 60);
            var seconds = Mathf.Round(secondsToReachTop % 60);
            var timeFormat = string.Format("{0}:{1}:{2}", hours.ToString("00"), minutes.ToString("00"), seconds.ToString("00"));
            return "Eruption ending in " + timeFormat;
        }

        public LavaState DetermineCurrentState()
        {
            if (Main.LavaLevel >= Main.MaxLavaLevel)
            {
                return LavaState.Blocked;
            }
            var lavaMove = LavaMove.main;
            if (!lavaMove.IsMoving)
            {
                return LavaState.NotMoving;
            }
            if (Main.ActualLavaMoveSpeed == 0)
            {
                return LavaState.NotMoving;
            }
            if (lavaMove.LavaLevelTarget > Main.LavaLevel)
            {
                return LavaState.Rising;
            }
            if (lavaMove.LavaLevelTarget < Main.LavaLevel)
            {
                return LavaState.Draining;
            }
            return LavaState.NotMoving;
        }

        public DepthLayers DetermineDepthLayer()
        {
            float lavaLevel = Main.LavaLevel;
            if (lavaLevel > 100f)
            {
                return DepthLayers.AboveWaterHigh;
            }
            if (lavaLevel >= 0)
            {
                return DepthLayers.AboveWaterLow;
            }
            if (lavaLevel > -135)
            {
                return DepthLayers.Shallow;
            }
            if (lavaLevel > -400)
            {
                return DepthLayers.Deep;
            }
            if (lavaLevel > -550)
            {
                return DepthLayers.DeepCave;
            }
            if (lavaLevel > -1000)
            {
                return DepthLayers.LostRiver;
            }
            if (lavaLevel >= -1700)
            {
                return DepthLayers.LavaZone;
            }
            return DepthLayers.Unknown;
        }

        public SafetyState DetermineSafety()
        {
            if (IsInDanger())
            {
                return SafetyState.Danger;
            }
            var main = LavaMove.main;
            if (main == null)
            {
                return SafetyState.Safe;
            }
            if (!main.AutomaticallyChange && !main.IsMoving && Main.LavaLevel <= -1699)
            {
                return SafetyState.Safe;
            }
            return SafetyState.Approaching;
        }

        public enum LavaState
        {
            NotMoving,
            Rising,
            Draining,
            Blocked
        }

        public enum DepthLayers
        {
            Unknown,
            LavaZone,
            LostRiver,
            DeepCave,
            Deep,
            Shallow,
            AboveWaterLow,
            AboveWaterHigh
        }

        public enum SafetyState
        {
            Danger,
            Safe,
            Approaching
        }
    }
}
