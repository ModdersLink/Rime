using System.Collections.Concurrent;
using System.Reflection;
using RimeLib.Serialization.Attributes;

namespace RimeLib.Serialization.Frostbite2013_2;

public static class DataContainerTypeRegistry
{
    private static readonly ConcurrentDictionary<string, Type> NameRegistry = new();

    public static Type FindByName(string p_Name) 
    {
        if (!NameRegistry.TryGetValue(p_Name, out var s_InterfaceType))
        {
            // If it doesn't exist, then refresh and try again.
            // only refresh if registry is empty, otherwise seems like an annoying performance hit
            if (NameRegistry.Count == 0)
                RefreshTypes();
            
            NameRegistry.TryGetValue(p_Name, out s_InterfaceType);
        }

        // Still doesn't exist. Throw an exception.
        if (s_InterfaceType == null)
            throw new ArgumentException($"The type you provided does not exist, or is not loaded: {p_Name}");

        return s_InterfaceType;
    }

    private static void RefreshTypes()
    {
        var s_GuidTypes = AppDomain.CurrentDomain.GetAssemblies()
            .SelectMany(a => a.GetTypes())
            .Where(t => t.GetCustomAttribute<ContainerTypeAttribute>() != null);
        
        Type? s_FoundInterface = null;

        // From the above types, check the engine support method for each and register accordingly.
        foreach (var s_InterfaceType in s_GuidTypes)
        {
            NameRegistry.TryAdd(s_InterfaceType.Name, s_InterfaceType);
        }

    }
}