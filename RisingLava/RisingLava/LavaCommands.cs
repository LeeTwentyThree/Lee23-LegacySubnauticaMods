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
                if (Main.config.AutomaticChange)
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
            if (Main.config.AutomaticChange)
            {
                ErrorMessage.AddMessage("This change will not work, it has been overriden by the automatic movement setting. Please disable this in settings ");
            }
        }
    }
}
