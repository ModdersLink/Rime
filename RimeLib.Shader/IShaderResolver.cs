using RimeLib.Content.Mounting;
using System.Collections.Generic;

namespace RimeLib.Shader
{
    public interface IShaderResolver : IEngineInterface
    {
        ISet<string> GetTextureNames();

        /// <summary>
        /// The names of every shader the initialized shader database holds, across all render paths.
        /// </summary>
        ISet<string> GetShaderNames();

        /// <summary>
        /// The textures each shader of the initialized database binds, by shader name. Empty where
        /// the database format doesn't say per shader.
        /// </summary>
        IReadOnlyDictionary<string, ISet<string>> GetTexturesByShader();
        void Initialize(IResourceObject resource, IEngineMounter mounter);
    }
}
