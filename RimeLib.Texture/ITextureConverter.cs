using RimeLib.Content.Mounting;
using RimeLib.IO;

namespace RimeLib.Texture
{
    public interface ITextureConverter : IEngineInterface
    {
        public void ConvertToDDS(IResourceObject p_Resource, IEngineMounter p_Mounter, RimeWriter p_OutputWriter);
    }
}
