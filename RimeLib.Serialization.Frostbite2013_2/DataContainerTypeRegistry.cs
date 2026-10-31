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
        // Types are looked up by their bare name, and other engines' serialization assemblies define
        // the same names (Vec3, LinearTransform, EmittableType, ...). With those loaded too, as the
        // REPL does, whichever assembly came first won, and Frostbite 2013.2 partitions were read
        // with another engine's types or failed to parse. This assembly's own types are registered
        // first, so they win; other assemblies only fill in names this one does not define.
        var s_Own = typeof(DataContainerTypeRegistry).Assembly;

        foreach (var s_Type in ContainerTypes(s_Own))
            NameRegistry.TryAdd(s_Type.Name, s_Type);

        foreach (var s_Assembly in AppDomain.CurrentDomain.GetAssemblies().Where(a => a != s_Own))
        {
            foreach (var s_Type in ContainerTypes(s_Assembly))
                NameRegistry.TryAdd(s_Type.Name, s_Type);
        }
    }

    private static IEnumerable<Type> ContainerTypes(Assembly p_Assembly)
    {
        Type[] s_Types;
        try
        {
            s_Types = p_Assembly.GetTypes();
        }
        catch (ReflectionTypeLoadException s_Ex)
        {
            s_Types = s_Ex.Types.Where(t => t != null).ToArray()!;
        }

        return s_Types.Where(t => t.GetCustomAttribute<ContainerTypeAttribute>() != null);
    }
}