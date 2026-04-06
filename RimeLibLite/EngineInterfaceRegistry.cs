using System;
using System.Collections.Generic;
using System.Linq;
using RimeLib.Frostbite;

namespace RimeLib;

public static class EngineInterfaceRegistry
{
    // This is a map of InterfaceType => { EngineType => InterfaceTypeImpl }.
    private static readonly Dictionary<Type, Dictionary<EngineType, Type>> Registry = new();

    public static T Create<T>(EngineType p_Type) where T : IEngineInterface
    {
        if (!Registry.TryGetValue(typeof(T), out var s_Interfaces))
        {
            s_Interfaces = new Dictionary<EngineType, Type>();
            Registry.Add(typeof(T), s_Interfaces);
        }
        
        if (!s_Interfaces.TryGetValue(p_Type, out var s_InterfaceType))
        {
            // If it doesn't exist, then refresh and try again.
            s_InterfaceType = RefreshInterfaces<T>(p_Type);
        }

        // Still doesn't exist. Throw an exception.
        if (s_InterfaceType == null)
            throw new ArgumentException($"The engine type you provided does not have a {typeof(T).Name} associated with it. This means that the engine type is not supported, or the support module for it is not loaded.", nameof(p_Type));

        return (T) Activator.CreateInstance(s_InterfaceType);
    }

    public static bool IsSupported<T>(EngineType p_Type) where T : IEngineInterface
    {
        if (!Registry.TryGetValue(typeof(T), out var s_Interfaces))
        {
            s_Interfaces = new Dictionary<EngineType, Type>();
            Registry.Add(typeof(T), s_Interfaces);
        }

        if (!s_Interfaces.TryGetValue(p_Type, out _))
        {
            RefreshInterfaces<T>(p_Type);
        }

        return Registry[typeof(T)].ContainsKey(p_Type);
    }

    private static Type? RefreshInterfaces<T>(EngineType p_Type) where T : IEngineInterface
    {
        var s_InterfaceTypes = AppDomain.CurrentDomain.GetAssemblies()
            .SelectMany(a => a.GetTypes())
            .Where(t => typeof(T).IsAssignableFrom(t) && t.IsClass);
        
        Registry[typeof(T)].Clear();

        Type? s_FoundInterface = null;

        // From the above types, check the engine support method for each and register accordingly.
        foreach (var s_InterfaceType in s_InterfaceTypes)
        {
            // We only want types with 0-arg constructors.
            var s_Constructor = s_InterfaceType.GetConstructor(Type.EmptyTypes);

            if (s_Constructor == null)
                continue;

            try
            {
                // This is kinda dirty but whatever.
                var s_TempInstance = (T) Activator.CreateInstance(s_InterfaceType);

                foreach (var s_SupportedEngine in s_TempInstance!.GetSupportedEngines())
                {
                    Registry[typeof(T)][s_SupportedEngine] = s_InterfaceType;

                    // If this is the requested type then store it so we can return it later.
                    if (s_SupportedEngine == p_Type)
                        s_FoundInterface = s_InterfaceType;
                }
            }
            catch
            {
                // Ignored.
            }
        }

        return s_FoundInterface;
    }
}