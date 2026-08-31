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

    /// <summary>
    /// Resolves where every mesh in a level is placed, WITHOUT building any geometry.
    ///
    /// Same walk as ConvertLevelMesh -- including StaticModelGroup instances, whose transforms
    /// come out of the level's Havok physics data rather than EBX -- but it stops before loading
    /// MeshSets, so it is cheap enough to answer a request with.
    /// </summary>
    /// Transforms are flat float[12] -- right, up, forward, trans -- so this interface stays free
    /// of any one engine's transform type.
    public bool ConvertLevelPlacements(string p_LevelPartition,
        out Dictionary<string, List<float[]>>? p_Placements);
}