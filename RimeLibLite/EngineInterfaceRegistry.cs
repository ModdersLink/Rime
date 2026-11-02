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

        // Each implementation's supported engines, and its own engine: the oldest it supports.
        var s_Candidates = new List<(Type Type, EngineType Own, EngineType[] Supported)>();
        foreach (var s_InterfaceType in s_InterfaceTypes)
        {
            // We only want types with 0-arg constructors.
            if (s_InterfaceType.IsAbstract || s_InterfaceType.GetConstructor(Type.EmptyTypes) == null)
                continue;

            try
            {
                var s_Supported = ((T) Activator.CreateInstance(s_InterfaceType)!).GetSupportedEngines();
                if (s_Supported.Length > 0)
                    s_Candidates.Add((s_InterfaceType, s_Supported.Min(), s_Supported));
            }
            catch
            {
                // Ignored.
            }
        }

        // An engine gets the implementation of the newest engine at or below it that supports it:
        // a struct lives in the oldest engine project with its layout and names the later engines
        // it still fits, and an engine whose layout changed brings its own, which then wins.
        foreach (var s_Engine in s_Candidates.SelectMany(p_C => p_C.Supported).Distinct())
        {
            var s_Best = s_Candidates
                .Where(p_C => p_C.Supported.Contains(s_Engine) && p_C.Own <= s_Engine)
                .OrderByDescending(p_C => p_C.Own)
                .Select(p_C => p_C.Type)
                .FirstOrDefault();
            if (s_Best != null)
                Registry[typeof(T)][s_Engine] = s_Best;
        }

        Registry[typeof(T)].TryGetValue(p_Type, out var s_FoundInterface);
        return s_FoundInterface;
    }
}