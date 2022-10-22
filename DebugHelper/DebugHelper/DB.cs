using HarmonyLib;
using System.Reflection;

/* Global namespace and short name to make it as accessible as possible
 * Class to help with the REPL console */
public static class DB
{
    public static Harmony harmony;
    public static MethodInfo returnFalse;
    private static MethodInfo echo;
    
    internal static void Setup()
    {
        harmony = new Harmony("Subnautica.DebugHelper");
        returnFalse = AccessTools.Method(typeof(DB), nameof(False));
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

    #region Listen
    public static void Listen(MethodInfo original, bool prefix = false) // whenever the method is run, shows information about it on screen
    {
        if (prefix) harmony.Patch(original, new HarmonyMethod(echo));
        else harmony.Patch(original, null, new HarmonyMethod(echo));
    }

    public static void Listen(string typeName, string methodName, bool prefix = false)
    {
        if (prefix) harmony.Patch(Method(typeName, methodName), new HarmonyMethod(echo));
        else harmony.Patch(Method(typeName, methodName), null, new HarmonyMethod(echo));
    }

    public static void Listen(System.Type type, string methodName, bool prefix = false)
    {
        if (prefix) harmony.Patch(Method(type, methodName), new HarmonyMethod(echo));
        else harmony.Patch(Method(type, methodName), null, new HarmonyMethod(echo));
    }
    #endregion

    #region Mute
    public static void Mute(MethodInfo original) // forces this method to never run
    {
        harmony.Patch(original, new HarmonyMethod(returnFalse));
    }

    public static void Mute(string typeName, string methodName)
    {
        harmony.Patch(Method(typeName, methodName), new HarmonyMethod(returnFalse));
    }

    public static void Mute(System.Type type, string methodName)
    {
        harmony.Patch(Method(type, methodName), new HarmonyMethod(returnFalse));
    }
    #endregion

    public static MethodInfo Method(string typeName, string methodName) // fast way to reference a method
    {
        return AccessTools.Method(System.Type.GetType(typeName), methodName);
    }

    public static MethodInfo Method(System.Type type, string methodName) // fast-ish way to reference a method
    {
        return AccessTools.Method(type, methodName);
    }
}
