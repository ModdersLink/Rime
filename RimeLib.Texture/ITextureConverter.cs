using RimeLib.Content.Mounting;
using RimeLib.IO;
using RimeLib.Frostbite.Core;
using SharpDX.Direct3D11;

namespace RimeLib.Texture
{
    public struct RawTextureData
    {
        public int Width;
        public int Height;
        public byte[] Pixels; // BGRA8888
        public string FormatName;
    }

    public interface ITextureConverter : IEngineInterface
    {
        public void ConvertToDDS(IResourceObject p_Resource, IEngineMounter p_Mounter, RimeWriter p_OutputWriter);

        public ShaderResourceView CreateTextureResourceView(
            IResourceObject p_Resource,
            IEngineMounter p_Mounter,
            Device p_D3DDevice
        );

        public RawTextureData? GetRawTextureData(IResourceObject p_Resource, IEngineMounter p_Mounter);

        public GUID GetTextureChunkId(IResourceObject p_Resource);
    }
}
