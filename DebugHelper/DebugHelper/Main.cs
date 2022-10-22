using QModManager.API.ModLoading;
using SMLHelper.V2.Handlers;
using DebugHelper.Commands;

namespace DebugHelper
{
    [QModCore()]
    public static class Main
    {
        [QModPatch()]
        public static void Patch()
        {
            ConsoleCommandsHandler.Main.RegisterConsoleCommands(typeof(PrefabCommands));
            ConsoleCommandsHandler.Main.RegisterConsoleCommands(typeof(AudioCommands));
            ConsoleCommandsHandler.Main.RegisterConsoleCommands(typeof(ColliderCommands));
        }

        [QModPostPatch()]
        public static void PostPatch()
        {
            DB.Setup();
        }
    }
}