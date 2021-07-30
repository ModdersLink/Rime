using RimeLib.Texture.Attributes;
using RimeLib.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RimeLib.Texture
{
    public class TextureFileHandlerRegistry
    {
        private static Dictionary<string, ITextureFileHandler> m_Handlers = new Dictionary<string, ITextureFileHandler>( );


        public static ITextureFileHandler? FindHandler(string p_Type)
        {
            if (m_Handlers.TryGetValue(p_Type.ToLower( ), out var s_Loader))
                return s_Loader;


            return RefreshHandlers(p_Type);
        }

        /// <summary>
        /// Refresh all the available texture loaders from the loaded assemblies.
        /// </summary>
        /// <returns>A texture loader of the specific version, if found.</returns>
        private static ITextureFileHandler? RefreshHandlers(string p_Type)
        {
            // Load texture assembly
            //AssemblyUtils.LoadSupportAssembly(AssemblyType.Texture, p_Engine);


            // Get all factory types from all loaded assemblies.
            var s_FactoryTypes = AppDomain.CurrentDomain.GetAssemblies( )
                .SelectMany( a => a.GetTypes( ) )
                .Where( t => typeof( ITextureFileHandler ).IsAssignableFrom(t) && t.IsClass );




            // Clear the list of currently registered factories.
            m_Handlers.Clear();


            ITextureFileHandler? s_FoundLoader = null;

            // From the above types, instantiate the ones that have a 0-arg constructor and add them to the list.
            foreach (var s_FactoryType in s_FactoryTypes)
            {
                var s_Constructor = s_FactoryType.GetConstructor(Type.EmptyTypes);

                if (s_Constructor == null)
                    continue;

                // Instantiate the loader.
#pragma warning disable CS8600 // Converting null literal or possible null value to non-nullable type.
                var s_Loader = ( ITextureFileHandler )Activator.CreateInstance(s_FactoryType);
#pragma warning restore CS8600 // Converting null literal or possible null value to non-nullable type.


                // Get class attribute
                var s_Attributes = s_FactoryType.GetCustomAttributes(typeof(TextureHandlerAttribute), true) as TextureHandlerAttribute[];

                if (s_Attributes == null)
                    continue;

                foreach (var s_Attribute in s_Attributes)
                {
                    // Save loader if we find a matching one
                    if (s_Attribute.FormatType.ToLower() == p_Type.ToLower())
                        s_FoundLoader = s_Loader;

                    if (m_Handlers.ContainsKey(s_Attribute.FormatType.ToLower()))
                    {
#pragma warning disable CS8601 // Possible null reference assignment.
                        m_Handlers[s_Attribute.FormatType.ToLower()] = s_Loader;
#pragma warning restore CS8601 // Possible null reference assignment.
                        continue;
                    }
                    // Otherwise just add it.
#pragma warning disable CS8604 // Possible null reference argument.
                    m_Handlers.Add(s_Attribute.FormatType.ToLower(), s_Loader);
#pragma warning restore CS8604 // Possible null reference argument.
                }
            }

            return s_FoundLoader;
        }


    }
}
