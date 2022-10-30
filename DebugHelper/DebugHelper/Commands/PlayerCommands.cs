using SMLHelper.V2.Commands;

namespace DebugHelper.Commands
{
    public static class PlayerCommands
    {
        [ConsoleCommand("forcewalkmode")]
        public static void ForceWalkMode()
        {
            Player.main.SetPrecursorOutOfWater(true);
        }

        [ConsoleCommand("swimmode")]
        public static void SwimMode()
        {
            Player.main.SetPrecursorOutOfWater(false);
        }
    }
}
