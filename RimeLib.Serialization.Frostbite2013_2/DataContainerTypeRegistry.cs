using System.Collections.Frozen;
using System.Reflection;
using RimeLib.Serialization.Attributes;

namespace RimeLib.Serialization.Frostbite2013_2;

public static class DataContainerTypeRegistry
{
    // Built once, in full, on first use; parsers on other threads wait for it.
    private static readonly Lazy<FrozenDictionary<string, Type>> s_Registry = new(Build);

    public static Type FindByName(string p_Name)
    {
        if (!s_Registry.Value.TryGetValue(p_Name, out var s_Type))
            throw new ArgumentException($"The type you provided does not exist, or is not loaded: {p_Name}");

        return s_Type;
    }

    private static FrozenDictionary<string, Type> Build()
    {
        // Other engines' assemblies define the same type names; this assembly's types take precedence.
        var s_Own = typeof(DataContainerTypeRegistry).Assembly;
        var s_Registry = new Dictionary<string, Type>();

        foreach (var s_Type in ContainerTypes(s_Own))
            s_Registry.TryAdd(s_Type.Name, s_Type);

        foreach (var s_Assembly in AppDomain.CurrentDomain.GetAssemblies().Where(p_A => p_A != s_Own))
        foreach (var s_Type in ContainerTypes(s_Assembly))
            s_Registry.TryAdd(s_Type.Name, s_Type);

        return s_Registry.ToFrozenDictionary();
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
            s_Types = s_Ex.Types.Where(p_T => p_T != null).ToArray()!;
        }

        return s_Types.Where(p_T => p_T.GetCustomAttribute<ContainerTypeAttribute>() != null);
    }
}
