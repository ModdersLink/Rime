using RimeLib.Content.Mounting;
using RimeLib.Frostbite;
using RimeLib.Utils;
using SharpGLTF.Scenes;

namespace RimeLib.Toolkit.Frostbite2_0;

public class Toolkit : IToolKit
{
    protected IEngineMounter? Mounter;
    protected TextWriter? Writer;

    private bool m_Initialized = false;
    
    public EngineType[] GetSupportedEngines()
    {
        return [EngineType.Frostbite2_0];
    }

    public bool Initialize(IEngineMounter p_Mounter, TextWriter p_OutputWriter)
    {
        Mounter = p_Mounter;
        Writer = p_OutputWriter;
        
        m_Initialized = true;
        
        return true;
    }

    public bool ConvertLevelMesh(string p_LevelPartition, out SceneBuilder? p_SceneBuilder)
    {
        p_SceneBuilder = null;
        
        if (!m_Initialized)
            return false;
        
        var s_LevelMeshConverter = new LevelMeshConverter(Mounter!, Writer!);
        if (s_LevelMeshConverter.ExportLevelMesh(p_LevelPartition, out p_SceneBuilder)) 
            return true;
        
        Writer?.WriteLine($"Could not export level mesh {p_LevelPartition}.");
        
        return false;

    }

    public bool ConvertLevelPlacements(string p_LevelPartition,
        out Dictionary<string, List<float[]>>? p_Placements)
    {
        p_Placements = null;

        if (!m_Initialized)
            return false;

        var s_LevelMeshConverter = new LevelMeshConverter(Mounter!, Writer!);

        if (s_LevelMeshConverter.ExportLevelPlacements(p_LevelPartition, out var s_Transforms) && s_Transforms is not null)
        {
            p_Placements = new Dictionary<string, List<float[]>>();

            foreach (var s_Pair in s_Transforms)
            {
                var s_List = new List<float[]>();

                foreach (var s_Transform in s_Pair.Value)
                {
                    s_List.Add([
                        s_Transform.right.x, s_Transform.right.y, s_Transform.right.z,
                        s_Transform.up.x, s_Transform.up.y, s_Transform.up.z,
                        s_Transform.forward.x, s_Transform.forward.y, s_Transform.forward.z,
                        s_Transform.trans.x, s_Transform.trans.y, s_Transform.trans.z
                    ]);
                }

                p_Placements[s_Pair.Key] = s_List;
            }

            return true;
        }

        Writer?.WriteLine($"Could not resolve placements for {p_LevelPartition}.");

        return false;
    }
}