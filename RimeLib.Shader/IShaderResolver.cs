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
        void Initialize(IResourceObject resource, IEngineMounter mounter);
    }
}
