using RimeLib.Content.Mounting;
using RimeLib.IO;
using SharpDX.Direct3D11;

namespace RimeLib.Texture
{
    public interface ITextureConverter : IEngineInterface
    {
        public void ConvertToDDS(IResourceObject p_Resource, IEngineMounter p_Mounter, RimeWriter p_OutputWriter);

        public ShaderResourceView CreateTextureResourceView(
            IResourceObject p_Resource,
            IEngineMounter p_Mounter,
            Device p_D3DDevice
        );

        public void GetTextureChunk(IResourceObject p_Resource, IEngineMounter p_Mounter);
    }
}
