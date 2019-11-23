using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using RimeLib.Attributes;
using RimeLib.Frostbite;

namespace RimeLib.Content.Mounting
{
    public static class EngineMounterRegistry
    {
        private static Dictionary<EngineType, Type> m_EngineMounters = new Dictionary<EngineType, Type>();

        /// <summary>
        /// Create an engine mounter of the requested type. An exception will be thrown if
        /// this engine type is not supported by any of the registered mounters.
        /// </summary>
        /// <param name="p_Type">The engine type to create an engine mounter for.</param>
        /// <returns>An engine mounter than can be used to mount and read game content.</returns>
        public static IEngineMounter Create(EngineType p_Type)
        {
            Type? s_MounterType;

            // Try to get a type from the currently registered mounters.
            if (!m_EngineMounters.TryGetValue(p_Type, out s_MounterType))
            {
                // If it doesn't exist, then refresh them and try again.
                s_MounterType = RefreshMounters(p_Type);
            }

            // Still doesn't exist. Throw an exception.
            if (s_MounterType == null)
                throw new ArgumentException("The engine type you provided does not have a mounter associated with it. This means that the engine type you're trying to mount is either not supported, or the support module for it is not loaded.", nameof(p_Type));

            return (IEngineMounter) Activator.CreateInstance(s_MounterType);
        }

        /// <summary>
        /// Refresh all the available mounter factories from the loaded assemblies.
        /// </summary>
        /// <returns>An engine mounter type supporting the specific engine type, if found.</returns>
        private static Type? RefreshMounters(EngineType p_Type)
        {
            // Get all serializer types from all loaded assemblies.
            var s_MounterTypes = AppDomain.CurrentDomain.GetAssemblies()
                .SelectMany(a => a.GetTypes())
                .Where(t => typeof(IEngineMounter).IsAssignableFrom(t) && t.IsClass);

            // Clear the list of currently registered serializers.
            m_EngineMounters.Clear();

            Type? s_FoundMounter = null;

            // From the above types, check the engine support attribute for each and register accordingly.
            foreach (var s_MounterType in s_MounterTypes)
            {
                // We only want types with 0-arg constructors.
                var s_Constructor = s_MounterType.GetConstructor(Type.EmptyTypes);

                if (s_Constructor == null)
                    continue;

                try
                {
                    var s_Attribute = s_MounterType.GetCustomAttribute<EngineSupportAttribute>(true);

                    foreach (var s_SupportedEngine in s_Attribute.SupportedEngines)
                    {
                        m_EngineMounters[s_SupportedEngine] = s_MounterType;

                        // If this is the requested serializer type then store it so we can return it later.
                        if (s_SupportedEngine == p_Type)
                            s_FoundMounter = s_MounterType;
                    }
                }
                catch
                {
                    // Ignored.
                }
            }

            return s_FoundMounter;
        }
    }
}
