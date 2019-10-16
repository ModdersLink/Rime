using RimeLib.Content.Frostbite;
using RimeLib.Content.Resource.Attributes;
using RimeLib.Frostbite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace RimeLib.Content.Resource
{
    public class ResourceLoaderRegistry
    {
        //TODO: This class is broken, it doesn't assume that Unknown enginetype is all engines..

        private static Dictionary<ResourceType, Dictionary<EngineType, IResourceLoader>> m_Factories = new Dictionary<ResourceType, Dictionary<EngineType, IResourceLoader>>( );


        public static IResourceLoader? FindLoader(ResourceType p_Type, EngineType p_Engine)
        {
            if (m_Factories.TryGetValue(p_Type, out var s_EngineDictionary))
                if (s_EngineDictionary.TryGetValue(p_Engine, out var s_Loader))
                    return s_Loader;


            return RefreshLoaders(p_Type, p_Engine);
        }

        /// <summary>
        /// Refresh all the available mounter factories from the loaded assemblies.
        /// </summary>
        /// <returns>A mounter factory of the specific type, if found.</returns>
        private static IResourceLoader? RefreshLoaders(ResourceType p_Type = ResourceType.None, EngineType p_Engine = EngineType.Unknown)
        {
            // Get all factory types from all loaded assemblies.
            var s_FactoryTypes = AppDomain.CurrentDomain.GetAssemblies( )
                .SelectMany( a => a.GetTypes( ) )
                .Where( t => typeof( IResourceLoader ).IsAssignableFrom( t ) && t.IsClass );

            // Clear the list of currently registered factories.
            m_Factories.Clear();


            IResourceLoader? s_FoundLoader = null;

            // From the above types, instantiate the ones that have a 0-arg constructor and add them to the list.
            foreach (var s_FactoryType in s_FactoryTypes)
            {
                var s_Constructor = s_FactoryType.GetConstructor( Type.EmptyTypes );

                if (s_Constructor == null)
                    continue;

                // Instantiate the loader.
                var s_Loader = ( IResourceLoader )Activator.CreateInstance( s_FactoryType );


                // Get class attribute
                var s_Attributes = s_FactoryType.GetCustomAttributes( typeof( ResourceLoaderAttribute ), true ) as ResourceLoaderAttribute[];

                if (s_Attributes == null)
                    continue;

                foreach (var s_Attribute in s_Attributes)
                {
                    // Save loader if we find a matching one
                    if (s_Attribute.ResourceType == p_Type && s_Attribute.EngineVersion == p_Engine)
                        s_FoundLoader = s_Loader;


                    // If we already have an instance of it, then overwrite it.
                    if (!m_Factories.ContainsKey(s_Attribute.ResourceType))
                    {
                        m_Factories.Add(s_Attribute.ResourceType, new Dictionary<EngineType, IResourceLoader>());
                    }


                    if (m_Factories[s_Attribute.ResourceType].ContainsKey(s_Attribute.EngineVersion))
                    {
                        m_Factories[s_Attribute.ResourceType][s_Attribute.EngineVersion] = s_Loader;
                        continue;
                    }
                    // Otherwise just add it.
                    m_Factories[s_Attribute.ResourceType].Add(s_Attribute.EngineVersion, s_Loader);
                }
            }

            return s_FoundLoader;
        }
    }
}
