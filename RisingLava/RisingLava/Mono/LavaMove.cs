using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using UnityEngine;

namespace RisingLava.Mono
{
    public class LavaMove : MonoBehaviour
    {
        public static LavaMove main;

        public float lavaLevel;

        private LavaLevelData save;
        private bool firstLoad;
        private float timeSaveAgain;
        private float targetLavaLevel;
        private bool lavaIsMoving;

        private const float saveDelay = 5f;

        private void Awake()
        {
            main = this;
        }

        private void Start()
        {
            save = new LavaLevelData();
            LoadData();
        }

        private void LoadData()
        {
            if (!File.Exists(save.JsonFilePath))
            {
                firstLoad = true;
            }
            save.Load();
            if (firstLoad)
            {
                save.LavaLevel = Main.config.LavaLevel;
                save.TimeLastChange = 0f;
            }
            lavaLevel = save.LavaLevel;
        }

        public bool AutomaticallyChange
        {
            get
            {
                return Main.AutoModeEnabled;
            }
        }

        private void Update()
        {
            CalculateLavaLevel();
            if (DayNightCycle.main.timePassedSinceOrigin > save.TimeLastChange + Main.config.IntervalDuration && AutomaticallyChange)
            {
                targetLavaLevel = lavaLevel + Main.config.IntervalChange;
                if (Main.config.IntervalChange > 0f)
                {
                    targetLavaLevel = Mathf.Clamp(targetLavaLevel, float.MinValue, Main.MaxLavaLevel);
                }
                save.TimeLastChange = DayNightCycle.main.timePassedSinceOrigin;
                lavaIsMoving = true;
            }
            if (Time.time > timeSaveAgain)
            {
                SaveData();
                timeSaveAgain = Time.time + saveDelay;
            }
        }

        private void SaveData()
        {
            save.LavaLevel = lavaLevel;
            save.Save();
        }

        private void CalculateLavaLevel()
        {
            if (save == null)
            {
                ErrorMessage.AddMessage("Error: No LavaLevelData present!");
                return;
            }
            if (lavaIsMoving)
            {
                lavaLevel = Mathf.MoveTowards(lavaLevel, targetLavaLevel, Time.deltaTime * Main.LavaMoveSpeed / 4f);
                if (Mathf.Approximately(lavaLevel, targetLavaLevel))
                {
                    lavaIsMoving = false;
                }
            }
        }

        public void ForceLavaLevel(float value)
        {
            lavaLevel = value;
            targetLavaLevel = value;
        }

        public void SetLavaLevelTarget(float value)
        {
            targetLavaLevel = value;
            lavaIsMoving = true;
        }

        public float LavaLevelTarget
        {
            get
            {
                return targetLavaLevel;
            }
        }
    }
}
