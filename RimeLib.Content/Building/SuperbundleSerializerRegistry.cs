using System;
using System.Collections.Generic;
using System.Linq;
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
            Type? s_SerializerType = null;

            // Try to get a type from the currently registered serializers.
            if (!m_Serializers.TryGetValue(p_Type, out s_SerializerType))
            {
                // If it doesn't exist, then refresh them and try again.
                s_SerializerType = RefreshSerializers(p_Type);
            }

            // Still doesn't exist. Throw an exception.
            if (s_SerializerType == null)
                throw new ArgumentException("The engine type you provided does not have a superbundle serializer associated with it. This means that the engine type you're trying to mount is either not supported, or the support module for it is not loaded.", nameof(p_Type));

            return (ISuperbundleSerializer) Activator.CreateInstance(s_SerializerType);
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

            // From the above types, instantiate the ones that have a 0-arg constructor and add them to the list.
            foreach (var s_SerializerType in s_SerializerTypes)
            {
                var s_Constructor = s_SerializerType.GetConstructor(Type.EmptyTypes);

                if (s_Constructor == null)
                    continue;

                // Instantiate the serializer.
                // TODO: This is silly. Replace with an attribute.
                var s_Serializer = (ISuperbundleSerializer) Activator.CreateInstance(s_SerializerType);

                // If this is the requested serializer type then store it so we can return it later.
                if (s_Serializer.GetSupportedEngine() == p_Type)
                    s_FoundSerializer = s_SerializerType;

                m_Serializers[s_Serializer.GetSupportedEngine()] = s_SerializerType;
            }

            return s_FoundSerializer;
        }
    }
}
