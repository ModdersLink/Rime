using RimeLib.Content.Mounting;
using System.Collections.Generic;

namespace RimeLib.Shader
{
    public interface IShaderResolver : IEngineInterface
    {
        ISet<string> GetTextureNames();
        void Initialize(IResourceObject resource, IEngineMounter mounter);
    }
}
