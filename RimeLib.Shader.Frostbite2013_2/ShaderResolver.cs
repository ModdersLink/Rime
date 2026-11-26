using System;
using System.Collections.Generic;
using System.IO;
using RimeLib.Content.Frostbite;
using RimeLib.Content.Mounting;
using RimeLib.Frostbite;
using RimeLib.Shader.Frostbite2013_2.Frostbite;

namespace RimeLib.Shader.Frostbite2013_2;

/// <summary>
/// Which shaders and textures a Frostbite 2013.2 shader database (version 194) holds. Shaders are
/// stored by name hash and named here by the mounted partition of that hash; textures are named in
/// the texture constants of the solutions.
/// </summary>
public class ShaderResolver : IShaderResolver
{
    /// <summary>The initialized database, its shader tables named by their assets.</summary>
    public ShaderDatabaseContainer? ShaderDatabaseContainer { get; private set; }

    private readonly HashSet<string> m_ShaderNames = new(StringComparer.OrdinalIgnoreCase);
    private readonly HashSet<string> m_TextureNames = new(StringComparer.OrdinalIgnoreCase);
    private readonly Dictionary<string, ISet<string>> m_TexturesByShader = new(StringComparer.OrdinalIgnoreCase);

    public EngineType[] GetSupportedEngines()
    {
        return new[] { EngineType.Frostbite2013_2 };
    }

    public ISet<string> GetTextureNames() => m_TextureNames;

    public ISet<string> GetShaderNames() => m_ShaderNames;

    public IReadOnlyDictionary<string, ISet<string>> GetTexturesByShader() => m_TexturesByShader;

    public void Initialize(IResourceObject resource, IEngineMounter mounter)
    {
        m_ShaderNames.Clear();
        m_TextureNames.Clear();
        m_TexturesByShader.Clear();
        ShaderDatabaseContainer = null;

        if (resource == null || resource.GetResourceType() != ResourceType.IShaderDatabase)
            return;

        byte[] s_Data;
        using (var s_Reader = resource.GetReader())
            s_Data = s_Reader.ReadBytes((int)s_Reader.Length);

        var s_Container = new ShaderDatabaseContainer();
        s_Container.Deserialize(s_Data);
        foreach (var s_Database in s_Container.Databases.Values)
            s_Database.ResolveNames(mounter);
        ShaderDatabaseContainer = s_Container;

        foreach (var s_Database in s_Container.Databases.Values)
        {
            foreach (var s_Shader in s_Database.ShaderInfos)
            {
                if (!mounter.TryGetPartitionByHashLower(s_Shader.Key, out var s_Partition))
                    continue;

                var s_Name = s_Partition.OriginalName.ToLowerInvariant();
                m_ShaderNames.Add(s_Name);
                if (!m_TexturesByShader.TryGetValue(s_Name, out var s_Textures))
                    m_TexturesByShader[s_Name] = s_Textures = new HashSet<string>(StringComparer.OrdinalIgnoreCase);

                // The solution's constants and its permutations' own: the engine binds both by name when it draws.
                foreach (var s_Solution in s_Shader.Solutions)
                foreach (var s_Constants in new[] { s_Solution.VertexConstants, s_Solution.PixelConstants,
                             s_Solution.VertexPermutation?.Constant, s_Solution.PixelPermutation?.Constant })
                foreach (var s_Texture in s_Constants?.Textures ?? [])
                    s_Textures.Add(s_Texture.Name);
            }

            foreach (var s_Constants in s_Database.Constants)
            foreach (var s_Texture in s_Constants.Textures)
            {
                if (mounter.TryGetPartition(s_Texture.Name, out _))
                    m_TextureNames.Add(s_Texture.Name.ToLowerInvariant());
            }
        }
    }
}
