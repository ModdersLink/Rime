using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using RimeLib.Attributes;
using RimeLib.Frostbite;

namespace RimeLib.Content.Building
{
    internal static class SuperbundleSerializerRegistry
    {
        private static readonly Dictionary<EngineType, Type> m_Serializers = new Dictionary<EngineType, Type>();

        /// <summary>
        /// Create a superbundle serializer of the requested type. An exception will be thrown if
        /// this engine type is not supported by any of the registered serializers.
        /// </summary>
        /// <param name="p_Type">The engine type to create an sb serializer for.</param>
        /// <returns>A superbundle serializer instance.</returns>
        public static ISuperbundleSerializer Create(EngineType p_Type)
        {
            Type? s_SerializerType;

            // Try to get a type from the currently registered serializers.
            if (!m_Serializers.TryGetValue(p_Type, out s_SerializerType))
            {
                // If it doesn't exist, then refresh them and try again.
                s_SerializerType = RefreshSerializers(p_Type);
            }

            // Still doesn't exist. Throw an exception.
            if (s_SerializerType == null)
                throw new ArgumentException("The engine type you provided does not have a superbundle serializer associated with it. This means that the engine type you're trying to mount is either not supported, or the support module for it is not loaded.", nameof(p_Type));

#pragma warning disable CS8600 // Converting null literal or possible null value to non-nullable type.
#pragma warning disable CS8603 // Possible null reference return.
            return (ISuperbundleSerializer) Activator.CreateInstance(s_SerializerType);
#pragma warning restore CS8603 // Possible null reference return.
#pragma warning restore CS8600 // Converting null literal or possible null value to non-nullable type.
        }

        /// <summary>
        /// Refresh all the available mounter factories from the loaded assemblies.
        /// </summary>
        /// <returns>A mounter factory of the specific type, if found.</returns>
        private static Type? RefreshSerializers(EngineType p_Type)
        {
            // Get all serializer types from all loaded assemblies.
            var s_SerializerTypes = AppDomain.CurrentDomain.GetAssemblies()
                .SelectMany(a => a.GetTypes())
                .Where(t => typeof(ISuperbundleSerializer).IsAssignableFrom(t) && t.IsClass);

            // Clear the list of currently registered serializers.
            m_Serializers.Clear();

            Type? s_FoundSerializer = null;

            // From the above types, check the engine support attribute for each and register accordingly.
            foreach (var s_SerializerType in s_SerializerTypes)
            {
                // We only want types with 0-arg constructors.
                var s_Constructor = s_SerializerType.GetConstructor(Type.EmptyTypes);

                if (s_Constructor == null)
                    continue;

                try
                {
                    var s_Attribute = s_SerializerType.GetCustomAttribute<EngineSupportAttribute>(true);

#pragma warning disable CS8602 // Dereference of a possibly null reference.
                    foreach (var s_SupportedEngine in s_Attribute.SupportedEngines)
#pragma warning restore CS8602 // Dereference of a possibly null reference.
                    {
                        m_Serializers[s_SupportedEngine] = s_SerializerType;

                        // If this is the requested serializer type then store it so we can return it later.
                        if (s_SupportedEngine == p_Type)
                            s_FoundSerializer = s_SerializerType;
                    }
                }
                catch
                {
                    // Ignored.
                }
            }

            return s_FoundSerializer;
        }
    }
}
