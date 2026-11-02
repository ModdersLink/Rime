using System;
using System.Collections.Generic;
using System.IO;
using RimeLib.Content.Frostbite;
using RimeLib.Content.Mounting;
using RimeLib.Frostbite;
using RimeLib.Shader.Frostbite2013_2.Frostbite;
using RimeLib.Shader.Pooled;

namespace RimeLib.Shader.Frostbite2013_2;

/// <summary>
/// Which shaders and textures a Frostbite 2013.2 shader database (version 194) holds. Shaders are
/// stored by name hash and named here by the mounted partition of that hash; textures are named in
/// the texture constants of the solutions.
/// </summary>
public class ShaderResolver : IShaderResolver
{
    // Size, padding, the offsets of values, textures, external values, external textures and
    // sampler states, the constant count and value start, then one count byte per list.
    private const int c_TextureOffsetField = 16;
    private const int c_TextureCountField = 8 + 5 * 8 + 4 + 1;

    // Index, type, padding, then the name.
    private const int c_TextureSize = 152;
    private const int c_TextureNameOffset = 8;

    // The solution's vertex and pixel constants, after its five permutations.
    private static readonly int[] s_ConstantRefs = { 5, 6 };

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

        if (resource == null || resource.GetResourceType() != ResourceType.IShaderDatabase)
            return;

        byte[] s_Data;
        using (var s_Reader = resource.GetReader())
        using (var s_Memory = new MemoryStream())
        {
            s_Reader.CopyTo(s_Memory);
            s_Data = s_Memory.ToArray();
        }

        foreach (var s_Database in PooledShaderDatabaseImage.Read(s_Data, ShaderDatabaseFormat.Instance).Databases)
        {
            var s_Constants = s_Database.Pools[0];
            var s_TexturesOf = new Dictionary<int, List<string>>();
            List<string> TexturesOf(int p_Constants)
            {
                if (!s_TexturesOf.TryGetValue(p_Constants, out var s_Names))
                    s_TexturesOf[p_Constants] = s_Names = ReadTextureNames(s_Constants[p_Constants].Bytes);
                return s_Names;
            }

            foreach (var s_Shader in s_Database.Shaders)
            {
                if (!mounter.TryGetPartitionByHashLower(s_Shader.Key, out var s_Partition))
                    continue;

                var s_Name = s_Partition.OriginalName.ToLowerInvariant();
                m_ShaderNames.Add(s_Name);
                if (!m_TexturesByShader.TryGetValue(s_Name, out var s_Textures))
                    m_TexturesByShader[s_Name] = s_Textures = new HashSet<string>(StringComparer.OrdinalIgnoreCase);

                foreach (var s_Index in s_Shader.Solutions)
                {
                    var s_Solution = s_Database.Solutions[s_Index];
                    foreach (var s_Ref in s_ConstantRefs)
                    {
                        var s_Constant = s_Solution.GetIndex(s_Solution.Refs[s_Ref]);
                        if (s_Constant != -1)
                            s_Textures.UnionWith(TexturesOf((int)s_Constant));
                    }
                }
            }

            foreach (var s_Record in s_Constants)
            foreach (var s_Texture in ReadTextureNames(s_Record.Bytes))
            {
                if (mounter.TryGetPartition(s_Texture, out _))
                    m_TextureNames.Add(s_Texture.ToLowerInvariant());
            }
        }
    }

    private static List<string> ReadTextureNames(byte[] p_Constants)
    {
        var s_Names = new List<string>();
        using var s_Reader = PooledRecord.ReaderAt(p_Constants, c_TextureOffsetField);
        var s_Offset = s_Reader.ReadInt64();
        s_Reader.Seek(c_TextureCountField, SeekOrigin.Begin);
        var s_Count = s_Reader.ReadByte();
        for (var i = 0; i < s_Count; i++)
        {
            s_Reader.Seek(s_Offset + i * c_TextureSize + c_TextureNameOffset, SeekOrigin.Begin);
            s_Names.Add(s_Reader.ReadNullTerminatedString());
        }

        return s_Names;
    }
}
