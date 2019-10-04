using System;
using System.Collections.Generic;
using System.Linq;
using RimeLib.Frostbite;

namespace RimeLib.Content.Mounting
{
    public static class EngineMounterRegistry
    {
        private static Dictionary<EngineType, IEngineMounterFactory> m_Factories = new Dictionary<EngineType, IEngineMounterFactory>();

        /// <summary>
        /// Create an engine mounter of the requested type. An exception will be thrown if
        /// this engine type is not supported by any of the registered mounters.
        /// </summary>
        /// <param name="p_Type">The engine type to create an engine mounter for.</param>
        /// <returns>An engine mounter than can be used to mount and read game content.</returns>
        public static IEngineMounter Create(EngineType p_Type)
        {
            // Try to get a mounter from the currently registered factories.
            if (m_Factories.TryGetValue(p_Type, out var s_Factory))
                return s_Factory.Create();

            // If it doesn't exist, then refresh the mounters and try again.
            var s_FoundFactory = RefreshMountersForFactory(p_Type);

            if (s_FoundFactory != null)
                return s_FoundFactory.Create();

            // Otherwise throw an exception.
            throw new ArgumentException("The engine type you provided does not have a mounter associated with it. This means that the engine type you're trying to mount is either not supported, or the support module for it is not loaded.", nameof(p_Type));
        }

        /// <summary>
        /// Refresh all the available mounter factories from the loaded assemblies.
        /// </summary>
        /// <returns>A mounter factory of the specific type, if found.</returns>
        private static IEngineMounterFactory? RefreshMountersForFactory(EngineType p_Type)
        {
            // Get all factory types from all loaded assemblies.
            var s_FactoryTypes = AppDomain.CurrentDomain.GetAssemblies()
                .SelectMany(a => a.GetTypes())
                .Where(t => typeof(IEngineMounterFactory).IsAssignableFrom(t) && t.IsClass);

            // Clear the list of currently registered factories.
            m_Factories.Clear();

            IEngineMounterFactory? s_FoundFactory = null;

            // From the above types, instantiate the ones that have a 0-arg constructor and add them to the list.
            foreach (var s_FactoryType in s_FactoryTypes)
            {
                var s_Constructor = s_FactoryType.GetConstructor(Type.EmptyTypes);

                if (s_Constructor == null)
                    continue;

                // Instantiate the factory.
                var s_Factory = (IEngineMounterFactory) Activator.CreateInstance(s_FactoryType);

                // If this is the requested factory type then store it so we can return it later.
                if (s_Factory.GetSupportedEngine() == p_Type)
                    s_FoundFactory = s_Factory;

                // If we already have an instance of it, then overwrite it.
                if (m_Factories.ContainsKey(s_Factory.GetSupportedEngine()))
                {
                    m_Factories[s_Factory.GetSupportedEngine()] = s_Factory;
                    continue;
                }

                // Otherwise just add it.
                m_Factories.Add(s_Factory.GetSupportedEngine(), s_Factory);
            }

            return s_FoundFactory;
        }
    }
}
