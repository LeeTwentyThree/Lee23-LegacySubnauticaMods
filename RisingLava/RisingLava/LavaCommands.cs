using SMLHelper.V2.Commands;

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
            overrideAutoMode.FeedNewValue(true, true);
            if (!BeginChallengeCinematic.CinematicActive())
            {
                BeginChallengeCinematic.BeginCinematic();
            }
        }

        [ConsoleCommand("resetlavaoverridesettings")]
        public static void ResetLavaOverrideSettings()
        {
            overrideLavaSpeed.overriden = false;
            overrideMaxHeight.overriden = false;
            overrideAutoMode.overriden = false;
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
