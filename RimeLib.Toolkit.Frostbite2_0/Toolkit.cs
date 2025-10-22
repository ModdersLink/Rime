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
}