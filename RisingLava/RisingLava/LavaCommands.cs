using SMLHelper.V2.Commands;
using UnityEngine;
using RisingLava.Mono;

namespace RisingLava
{
    public static class LavaCommands
    {
        [ConsoleCommand("setlavalevel")]
        public static void SetLavaLevel(float yLevel)
        {
            if (LavaMove.main == null)
            {
                ErrorMessage.AddMessage("No lava found!");
            }
            LavaMove.main.ForceLavaLevel(yLevel);
            if (!Main.config.DisableErrorMessages)
            {
                ErrorMessage.AddMessage("Sending the lava surface to a new Y level of " + yLevel);
                if (Main.AutoModeEnabled)
                {
                    ErrorMessage.AddMessage("The lava will likely move from this new location because automatic movement is enabled.");
                }
            }
        }

        [ConsoleCommand("changelavalevel")]
        public static void ChangeLavaLevel(float yLevel)
        {
            if (LavaMove.main == null)
            {
                ErrorMessage.AddMessage("No lava found!");
            }
            var targetBefore = LavaMove.main.LavaLevelTarget;
            LavaMove.main.SetLavaLevelTarget(yLevel);
            if (!Main.config.DisableErrorMessages)
            {
                if (yLevel > targetBefore)
                {
                    ErrorMessage.AddMessage("The lava will rise to a new Y level of " + yLevel);
                }
                else if (yLevel < targetBefore)
                {
                    ErrorMessage.AddMessage("The lava will drain to a new Y level of " + yLevel);
                }
                else
                {
                    ErrorMessage.AddMessage("The lava level will not change, it was already at a Y level of " + yLevel);
                }
            }
            if (Main.AutoModeEnabled)
            {
                if (overrideAutoMode.overriden)
                {
                    ErrorMessage.AddMessage("This change will not work, automatic mode is currently enabled. You can use the `pauseautomode` command to disable it.");
                }
                else
                {
                    ErrorMessage.AddMessage("This change will not work, it has been overriden by the automatic movement setting. Please disable this in settings.");
                }
            }
        }

        [ConsoleCommand("lavamovespeed")]
        public static void LavaLevelSpeed(float metersPerSecond)
        {
            overrideLavaSpeed.FeedNewValue(metersPerSecond);
        }

        [ConsoleCommand("lavalevelmax")]
        public static void LavaLevelMax(float maxYLevel)
        {
            overrideMaxHeight.FeedNewValue(maxYLevel);
        }

        [ConsoleCommand("pauseautomode")]
        public static void PauseAutoMode()
        {
            overrideAutoMode.FeedNewValue(false);
        }

        [ConsoleCommand("beginlavachallenge")]
        public static void BeginChallenge()
        {
            if (!BeginChallengeCinematic.CinematicActive())
            {
                BeginChallengeCinematic.BeginCinematic();
            }
            else
            {
                overrideAutoMode.FeedNewValue(true, true);
            }
        }

        [ConsoleCommand("resetlavaoverridesettings")]
        public static void ResetLavaOverrideSettings()
        {
            overrideLavaSpeed.overriden = false;
            overrideMaxHeight.overriden = false;
            overrideAutoMode.overriden = false;
        }

        [ConsoleCommand("lavachallengeduration")]
        public static void PrintLavaChallengeDuration()
        {
            if (Main.LavaMoveSpeed == 0)
            {
                ErrorMessage.AddMessage("This challenge will go on for eternity, Rise/fall speed is set to 0.");
                return;
            }
            if (Main.MaxLavaLevel <= Main.LavaLevel)
            {
                ErrorMessage.AddMessage("The challenge has already ended. The lava level has reached its limit.");
                return;
            }
            if (Main.config.MovementIntervalDuration > 0)
            {
                ErrorMessage.AddMessage("An accurate estimate can only be provided if the `Time between movements` setting is set to 0. Sorry!");
                ErrorMessage.AddMessage("It looks better if you leave it at zero, anyway... and if you're worried about it rising too fast, just use the `lavamovespeed [speed]` command!");
                return;
            }
            var heightDifference = Mathf.Abs(Main.MaxLavaLevel - Main.LavaLevel);
            var timeToReachTop = heightDifference / Main.ActualLavaMoveSpeed;
            ErrorMessage.AddMessage($"It will take the lava approximately {timeToReachTop} seconds to move up {heightDifference} meters.");
            var minutes = Mathf.Floor(timeToReachTop / 60);
            var seconds = Mathf.Round(timeToReachTop % 60);
            ErrorMessage.AddMessage($"In other words, {minutes} minutes and {seconds} seconds.");
            ErrorMessage.AddMessage($"The lava will move at a rate of {Main.ActualLavaMoveSpeed} meters per second.");

            if (!Main.AutoModeEnabled)
            {
                ErrorMessage.AddMessage("Use the `beginlavachallenge` command to make it rise!");
                return;
            }
        }

        [ConsoleCommand("resumelava")]
        public static void ResumeLavaMovement()
        {
            if (LavaMove.main == null)
            {
                ErrorMessage.AddMessage("No lava found!");
            }
            if (!Main.AutoModeEnabled)
            {
                overrideAutoMode.FeedNewValue(true);
            }
        }

        [ConsoleCommand("stoplava")]
        public static void StopLavaMovement()
        {
            if (LavaMove.main == null)
            {
                ErrorMessage.AddMessage("No lava found!");
            }
            if (Main.AutoModeEnabled)
            {
                PauseAutoMode();
            }
            LavaMove.main.SetLavaLevelTarget(Main.LavaLevel);
        }

        public static OverrideSetting<float> overrideLavaSpeed = new OverrideSetting<float>("Rise/fall speed");
        public static OverrideSetting<float> overrideMaxHeight = new OverrideSetting<float>("Lava level upper limit");
        public static OverrideSetting<bool> overrideAutoMode = new OverrideSetting<bool>("Auto movement");
        
        public class OverrideSetting<T>
        {
            public bool overriden;
            public T value;
            public string label;

            public OverrideSetting(string label)
            {
                overriden = false;
                value = default;
                this.label = label;
            }

            public void FeedNewValue(T newValue, bool hideMessage = false)
            {
                value = newValue;
                overriden = true;
                if (!Main.config.DisableErrorMessages && !hideMessage)
                {
                    ErrorMessage.AddMessage($"Overriding the '{label}' configuration with a new value of '{value}'. The '{label}' setting will remain overriden by commands (and unaffected by in-game mod options) until the game is restarted.");
                }
            }
        }
    }
}
