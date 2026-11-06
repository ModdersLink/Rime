using System;
using System.Collections.Concurrent;
using System.Linq;
using System.Reflection;

namespace RimeLib.Serialization.Attributes
{
    /// <summary>
    /// The container fields of reflected types, looked up once per type. Reading attributes is slow
    /// and the same few thousand types repeat across every partition.
    /// </summary>
    public static class ContainerFields
    {
        private static readonly ConcurrentDictionary<Type, PropertyInfo[]> s_Fields = new();
        private static readonly ConcurrentDictionary<(Type, string), (PropertyInfo? Property, bool IsField)> s_ByName = new();

        /// <summary>The public instance properties that carry a <see cref="ContainerFieldAttribute"/>.</summary>
        public static PropertyInfo[] Of(Type p_Type) => s_Fields.GetOrAdd(p_Type, p_T =>
            p_T.GetProperties(BindingFlags.Public | BindingFlags.Instance).Where(p_P => p_P.GetCustomAttribute<ContainerFieldAttribute>() != null).ToArray());

        /// <summary>The property of that name, and whether it carries a <see cref="ContainerFieldAttribute"/>.</summary>
        public static (PropertyInfo? Property, bool IsField) Named(Type p_Type, string p_Name) => s_ByName.GetOrAdd((p_Type, p_Name), p_Key =>
        {
            var s_Property = p_Key.Item1.GetProperty(p_Key.Item2);
            return (s_Property, s_Property?.GetCustomAttribute<ContainerFieldAttribute>() != null);
        });
    }
}
