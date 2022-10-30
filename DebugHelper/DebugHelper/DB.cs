using HarmonyLib;
using System.Collections.Generic;
using System.Reflection;
using QModManager.API;

/* Global namespace and short name to make it as accessible as possible
 * Class to help with the REPL console */
public static class DB
{
    public static Harmony harmony;
    public static MethodInfo returnFalse;
    private static MethodInfo echo;
    private static MethodInfo echoWithArgs;
    
    internal static void Setup()
    {
        harmony = DebugHelper.Main.harmony;
        returnFalse = AccessTools.Method(typeof(DB), nameof(False));
        echo = AccessTools.Method(typeof(DB), nameof(Echo));
        echoWithArgs = AccessTools.Method(typeof(DB), nameof(EchoArgs));

        var allMods = QModServices.Main.GetAllMods();
        foreach (var mod in allMods)
        {
            if (mod.IsLoaded)
            {
                knownAssemblyNames.Add(mod.Id);
            }
        }
    }

    public static void Echo(MethodBase __originalMethod)
    {
        var methodName = $"{__originalMethod.DeclaringType.FullName}.{__originalMethod.Name}";
        var message = $"Method run: {methodName}";
        if (__originalMethod is MethodInfo method)
        {
            message += $" (returns {method.ReturnType})";
        }
        if (__originalMethod.IsVirtual)
        {
            message += " (Virtual)";
        }
        ErrorMessage.AddMessage(message);
    }

    public static void EchoArgs(object[] __args)
    {
        var message = $"Method run. Echoing arguments: ";
        if (__args != null)
        {
            for (int i = 0; i < __args.Length; i++)
            {
                if (__args[i] == null) message += "null";
                else message += __args[i].ToString();
                if (i < __args.Length - 1)
                {
                    message += ", ";
                }
            }
        }
        ErrorMessage.AddMessage(message);
    }

    private static bool False()
    {
        return false;
    }

    #region Listen
    public static void Listen(MethodInfo original, bool prefix = false) // whenever the method is run, shows information about it on screen
    {
        if (prefix) harmony.Patch(original, new HarmonyMethod(echo));
        else harmony.Patch(original, null, new HarmonyMethod(echo));
    }

    public static void Listen(string location, bool prefix = false)
    {
        if (prefix) harmony.Patch(Method(location), new HarmonyMethod(echo));
        else harmony.Patch(Method(location), null, new HarmonyMethod(echo));
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

    #region Listen args
    public static void ListenArgs(MethodInfo original, bool prefix = false) // whenever the method is run, shows information about it on screen
    {
        if (prefix) harmony.Patch(original, new HarmonyMethod(echoWithArgs));
        else harmony.Patch(original, null, new HarmonyMethod(echoWithArgs));
    }

    public static void ListenArgs(string location, bool prefix = false)
    {
        if (prefix) harmony.Patch(Method(location), new HarmonyMethod(echoWithArgs));
        else harmony.Patch(Method(location), null, new HarmonyMethod(echoWithArgs));
    }

    public static void ListenArgs(string typeName, string methodName, bool prefix = false)
    {
        if (prefix) harmony.Patch(Method(typeName, methodName), new HarmonyMethod(echoWithArgs));
        else harmony.Patch(Method(typeName, methodName), null, new HarmonyMethod(echoWithArgs));
    }

    public static void ListenArgs(System.Type type, string methodName, bool prefix = false)
    {
        if (prefix) harmony.Patch(Method(type, methodName), new HarmonyMethod(echoWithArgs));
        else harmony.Patch(Method(type, methodName), null, new HarmonyMethod(echoWithArgs));
    }
    #endregion

    #region Mute
    public static void Mute(MethodInfo original) // forces this method to never run
    {
        harmony.Patch(original, new HarmonyMethod(returnFalse));
    }

    public static void Mute(string location)
    {
        harmony.Patch(Method(location), new HarmonyMethod(returnFalse));
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

    public static MethodInfo Method(string location) // fastest way to reference a method ("Creature.Start")
    {
        var split = location.Split('.');
        var typeName = split[split.Length - 2];
        var methodName = split[split.Length - 1];
        return Method(typeName, methodName);
    }

    public static MethodInfo Method(string typeName, string methodName) // fast way to reference a method ("Creature", "Start")
    {
        return AccessTools.Method(TypeByName(typeName), methodName);
    }

    public static MethodInfo Method(System.Type type, string methodName) // fast-ish way to reference a method (typeof(Creature), "Start")
    {
        return AccessTools.Method(type, methodName);
    }

    public static System.Type TypeByName(string typeName)
    {
        foreach (var known in knownAssemblyNames)
        {
            var type = System.Type.GetType($"{typeName},{known}");
            if (type != null)
            {
                return type;
            }
        }
        return null;
    }

    private static List<string> knownAssemblyNames = new List<string>() { "Assembly-CSharp", "Assembly-CSharp-firstpass", "UnityEngine", "UnityEngine.CoreModule", "UnityEngine.PhysicsModule", "SMLHelper" };

    public static string Help
    {
        get
        {
            return "Useful methods:\n" +
                "Listen(MethodInfo original, bool prefix = false): Outputs method call information onto the screen whenever the given method is called.\n" +
                "[BROKEN] ListenArgs(MethodInfo original, bool prefix = false): Outputs method call information onto the screen whenever the given method is called. Also outputs all parameters passed into the method call.\n" +
                "Mute(MethodInfo original): Stops a method from being called.\n" +
                "Method(string location): Returns a MethodInfo by its name (ex: \"Peeper.Start\")\n" +
                "Method(System.Type type, string methodName): Also returns a MethodInfo (ex: typeof(Peeper), \"Start\")\n";
        }
    }
}
