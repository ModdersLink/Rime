using RimeLib.Content.Mounting;

namespace RimeLib.Mesh;

public interface IMeshConverter : IEngineInterface
{
    public void ConvertToObj(IResourceObject p_Resource, IEngineMounter p_Mounter, string p_OutputFilePath);
    public void ConvertToGltf(IResourceObject p_Resource, IEngineMounter p_Mounter, string p_OutputFilePath);
    public void ConvertToBlenderScript(IResourceObject p_Resource, IEngineMounter p_Mounter, string p_OutputFilePath);
}