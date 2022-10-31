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

        [ConsoleCommand("playeranimtrigger")]
        public static void PlayerAnimatorTrigger(string parameter)
        {
            Player.main.playerAnimator.SetTrigger(parameter);
        }

        [ConsoleCommand("playeranimbool")]
        public static void PlayerAnimatorBool(string parameter, bool value)
        {
            Player.main.playerAnimator.SetBool(parameter, value);
        }

        [ConsoleCommand("playeranimfloat")]
        public static void PlayerAnimatorFloat(string parameter, float value)
        {
            Player.main.playerAnimator.SetFloat(parameter, value);
        }
    }
}
