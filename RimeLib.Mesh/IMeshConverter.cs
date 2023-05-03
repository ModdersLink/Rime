using RimeLib.Content.Mounting;
using RimeLib.IO;

namespace RimeLib.Mesh
{
    public interface IMeshConverter : IEngineInterface
    {
        public void ConvertToText(IResourceObject p_Resource, IEngineMounter p_Mounter, RimeWriter p_Writer);
        public void ConvertToObj(IResourceObject p_Resource, IEngineMounter p_Mounter, RimeWriter p_Writer);
        public void ConvertToBlender(IResourceObject p_Resource, IEngineMounter p_Mounter, RimeWriter p_Writer);
        public void ConvertToGltf(IResourceObject p_Resource, IEngineMounter p_Mounter, RimeWriter p_Writer);
    }
}
