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
    private static MethodInfo echoWithReturn;
    
    internal static void Setup()
    {
        harmony = DebugHelper.Main.harmony;
        returnFalse = AccessTools.Method(typeof(DB), nameof(False));
        echo = AccessTools.Method(typeof(DB), nameof(Echo));
        echoWithArgs = AccessTools.Method(typeof(DB), nameof(EchoArgs));
        echoWithReturn = AccessTools.Method(typeof(DB), nameof(EchoReturn));

        var allMods = QModServices.Main.GetAllMods();
        foreach (var mod in allMods)
        {
            if (mod.IsLoaded)
            {
                knownAssemblyNames.Add(mod.Id);
            }
        }
    }

    private static void Echo(MethodBase __originalMethod)
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

    private static void EchoArgs(object[] __args, MethodBase __originalMethod)
    {
        var message = $"Method run. Echoing arguments: \n";
        var argNames = __originalMethod.GetParameters();
        if (__args != null)
        {
            for (int i = 0; i < __args.Length; i++)
            {
                var valueString = __args[i] == null ? "null" : __args[i].ToString();

                message += $"{argNames[i]}: {valueString}";

                if (i < __args.Length - 1)
                {
                    message += ", \n";
                }
            }
        }
        ErrorMessage.AddMessage(message);
    }

    private static void EchoReturn(object __result)
    {
        ErrorMessage.AddMessage($"Method run. Echoing return value: {(__result == null ? "null" : __result)}");
    }

    private static bool False()
    {
        return false;
    }

    #region Listen
    public static string Listen(MethodInfo original, bool prefix = false) // whenever the method is run, shows information about it on screen
    {
        if(original == null)
        {
            return "Could not find method to listen for";
        }

        if (prefix) harmony.Patch(original, new HarmonyMethod(echo));
        else harmony.Patch(original, null, new HarmonyMethod(echo));
        return "Patched";
    }

    public static string Listen(string location, bool prefix = false)
    {
        return Listen(Method(location), prefix);
    }

    public static string Listen(string typeName, string methodName, bool prefix = false)
    {
        return Listen(Method(typeName, methodName), prefix);
    }

    public static string Listen(System.Type type, string methodName, bool prefix = false)
    {
        return Listen(Method(type, methodName), prefix);
    }
    #endregion

    #region Listen args
    public static string ListenArgs(MethodInfo original, bool prefix = false) // whenever the method is run, shows information about it on screen
    {
        if(original.GetParameters().Length <= 0)
        {
            return "Method does not have arguments";
        }

        if (prefix) harmony.Patch(original, new HarmonyMethod(echoWithArgs));
        else harmony.Patch(original, null, new HarmonyMethod(echoWithArgs));
        return "Patch applied";
    }

    public static string ListenArgs(string location, bool prefix = false)
    {
        return ListenArgs(Method(location), prefix);
    }

    public static string ListenArgs(string typeName, string methodName, bool prefix = false)
    {
        return ListenArgs(Method(typeName, methodName), prefix);
    }

    public static string ListenArgs(System.Type type, string methodName, bool prefix = false)
    {
        return ListenArgs(Method(type, methodName), prefix);
    }
    #endregion
    
    #region Listen return
    public static string ListenReturn(MethodInfo original, bool prefix = false) // whenever the method is run, shows information about it on screen
    {
        if (original.ReturnType == typeof(void))
        {
            return "Method does not have return type";
        }

        if (prefix) harmony.Patch(original, new HarmonyMethod(echoWithReturn));
        else harmony.Patch(original, null, new HarmonyMethod(echoWithReturn));
        return "Patch applied";
    }

    public static string ListenReturn(string location, bool prefix = false)
    {
        return ListenReturn(Method(location), prefix);
    }

    public static string ListenReturn(string typeName, string methodName, bool prefix = false)
    {
        return ListenReturn(Method(typeName, methodName), prefix);
    }

    public static string ListenReturn(System.Type type, string methodName, bool prefix = false)
    {
        return ListenReturn(Method(type, methodName), prefix);
    }
    #endregion

    #region Listen all
    public static string ListenAll(MethodInfo original, bool prefix = false) // whenever the method is run, shows information about it on screen
    {
        if (original == null)
        {
            return "Could not find method to listen for";
        }

        string message = "Patched";

        //patch the main listen
        if (prefix) harmony.Patch(original, new HarmonyMethod(echo));
        else harmony.Patch(original, null, new HarmonyMethod(echo));

        //patch the listen with return type
        if (original.ReturnType != typeof(void))
        {
            if (prefix) harmony.Patch(original, new HarmonyMethod(echoWithReturn));
            else harmony.Patch(original, null, new HarmonyMethod(echoWithReturn));
            message += " with return type";
        }
        else
        {
            message += " without return type";
        }

        //patch the listen with arguments
        if(original.GetParameters().Length > 0)
        {
            if (prefix) harmony.Patch(original, new HarmonyMethod(echoWithArgs));
            else harmony.Patch(original, null, new HarmonyMethod(echoWithArgs));
            message += " and arguments";
        }
        else
        {
            message += " and no arguments";
        }

        return message;
    }

    public static string ListenAll(string location, bool prefix = false)
    {
        return ListenAll(Method(location), prefix);
    }

    public static string ListenAll(string typeName, string methodName, bool prefix = false)
    {
        return ListenAll(Method(typeName, methodName), prefix);
    }

    public static string ListenAll(System.Type type, string methodName, bool prefix = false)
    {
        return ListenAll(Method(type, methodName), prefix);
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
                "- Listen(MethodInfo original, bool prefix = false): Outputs method call information onto the screen whenever the given method is called.\n" +
                "- ListenArgs(MethodInfo original, bool prefix = false): Outputs method call information onto the screen whenever the given method is called. Also outputs all parameters passed into the method call.\n" +
                "- ListenReturn(MethodInfo original, bool prefix = false): Outputs method call information onto the screen whenever the given method is called. Also outputs the returned value of the original method.\n" +
                "- ListenAll(MethodInfo original, bool prefix = false): Outputs method call information onto the screen whenever the given method is called. Also outputs the returned value and all parameters passed to the method.\n" +
                "- Mute(MethodInfo original): Stops a method from being called.\n" +
                "- Method(string location): Returns a MethodInfo by its name (ex: \"Peeper.Start\")\n" +
                "- Method(System.Type type, string methodName): Also returns a MethodInfo (ex: typeof(Peeper), \"Start\")\n";
        }
    }
}
