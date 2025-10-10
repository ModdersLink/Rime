using RimeLib.Content.Mounting;
using RimeLib.Frostbite;
using SharpGLTF.Scenes;

namespace RimeLib.Toolkit;

/// <summary>
/// This is where we will shove more complicated code that spans across multiple libraries
/// </summary>
public interface IToolKit : IEngineInterface
{
    public bool Initialize(IEngineMounter p_Mounter, TextWriter p_OutputWriter);

    public bool ConvertLevelMesh(string p_LevelPartition, out SceneBuilder? p_SceneBuilder);
}