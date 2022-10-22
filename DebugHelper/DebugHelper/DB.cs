using HarmonyLib;
using System.Reflection;

/* Global namespace and short name to make it as accessible as possible
 * Class to help with the REPL console */
public static class DB
{
    public static Harmony harmony;
    public static MethodInfo returnFalse;
    public static MethodInfo returnTrue;
    public static MethodInfo echo;
    
    public static void Setup()
    {
        harmony = new Harmony("Subnautica.DebugHelper");
        returnFalse = AccessTools.Method(typeof(DB), nameof(False));
        returnTrue = AccessTools.Method(typeof(DB), nameof(True));
        echo = AccessTools.Method(typeof(DB), nameof(Echo));
    }

    public static void Echo(object[] __args, MethodBase __originalMethod)
    {
        ErrorMessage.AddMessage($"Method run: {__originalMethod} with arguments: {__args}");
    }

    public static bool False()
    {
        return false;
    }

    public static bool True() // why would you need this besides consistency?
    {
        return true;
    }

    public static void Listen(MethodInfo original) // whenever the method is run, shows information about it on screen
    {
        harmony.Patch(original, null, new HarmonyMethod(echo));
    }

    public static void ListenPre(MethodInfo original) // variant of Listen using HarmonyPrefix
    {
        harmony.Patch(original, new HarmonyMethod(echo));
    }

    public static void Mute(MethodInfo original) // forces this method to never run
    {
        harmony.Patch(original, new HarmonyMethod(returnFalse));
    }

    private static MethodInfo Method(string typeName, string methodName) // fast way to reference a method
    {
        return AccessTools.Method(System.Type.GetType(typeName), methodName);
    }

    private static MethodInfo Method(System.Type type, string methodName) // fast-ish way to reference a method
    {
        return AccessTools.Method(type, methodName);
    }
}
