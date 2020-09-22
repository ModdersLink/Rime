using RimeLib.Frostbite;
using RimeLib.Texture.Attributes;
using RimeLib.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace RimeLib.Texture
{
    public class TextureLoaderRegistry
    {
        private static Dictionary<EngineType, ITextureHandler> m_Factories = new Dictionary<EngineType, ITextureHandler>( );


        public static ITextureHandler? FindLoader(EngineType p_Engine)
        {
            if (m_Factories.TryGetValue(p_Engine, out var s_Loader))
                return s_Loader;


            return RefreshLoaders(p_Engine);
        }

        /// <summary>
        /// Refresh all the available texture loaders from the loaded assemblies.
        /// </summary>
        /// <returns>A texture loader of the specific version, if found.</returns>
        private static ITextureHandler? RefreshLoaders(EngineType p_Engine)
        {
            // Load texture assembly
            AssemblyUtils.LoadSupportAssembly(AssemblyType.Texture, p_Engine);


            // Get all factory types from all loaded assemblies.
            var s_FactoryTypes = AppDomain.CurrentDomain.GetAssemblies( )
                .SelectMany( a => a.GetTypes( ) )
                .Where( t => typeof( ITextureHandler ).IsAssignableFrom(t) && t.IsClass );

            


            // Clear the list of currently registered factories.
            m_Factories.Clear();


            ITextureHandler? s_FoundLoader = null;

            // From the above types, instantiate the ones that have a 0-arg constructor and add them to the list.
            foreach (var s_FactoryType in s_FactoryTypes)
            {
                var s_Constructor = s_FactoryType.GetConstructor(Type.EmptyTypes);

                if (s_Constructor == null)
                    continue;

                // Instantiate the loader.
                var s_Loader = ( ITextureHandler )Activator.CreateInstance(s_FactoryType);


                // Get class attribute
                var s_Attributes = s_FactoryType.GetCustomAttributes(typeof(TextureLoaderAttribute), true) as TextureLoaderAttribute[];

                if (s_Attributes == null)
                    continue;

                foreach (var s_Attribute in s_Attributes)
                {
                    // Save loader if we find a matching one
                    if (s_Attribute.EngineVersion == p_Engine)
                        s_FoundLoader = s_Loader;

                    if (m_Factories.ContainsKey(s_Attribute.EngineVersion))
                    {
                        m_Factories[s_Attribute.EngineVersion] = s_Loader;
                        continue;
                    }
                    // Otherwise just add it.
                    m_Factories.Add(s_Attribute.EngineVersion, s_Loader);
                }
            }

            return s_FoundLoader;
        }
    }
}
