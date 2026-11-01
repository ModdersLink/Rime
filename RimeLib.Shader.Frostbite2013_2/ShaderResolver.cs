using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using RimeLib.Content.Frostbite;
using RimeLib.Content.Mounting;
using RimeLib.Frostbite;

namespace RimeLib.Shader.Frostbite2013_2;

/// <summary>
/// Which shaders and textures a Frostbite 2013.2 shader database (version 194) holds. This is not a
/// parser of the whole database: it reads only the two things that name assets.
///  - The shader table: a count followed by 32 byte entries, one per shader solution, each starting
///    with the lowercase name hash of its shader asset. Several entries share a shader. The table is
///    found by its shape (a count whose entries all fit, and whose first, second and last entries name
///    mounted partitions), which matches exactly once per database in retail levels.
///  - Texture names, stored as null-terminated strings: those that name a mounted partition.
/// </summary>
public class ShaderResolver : IShaderResolver
{
    private const int c_EntrySize = 32;
    private const uint c_ShaderDatabaseVersion = 194;

    private readonly HashSet<string> m_ShaderNames = new(StringComparer.OrdinalIgnoreCase);
    private readonly HashSet<string> m_TextureNames = new(StringComparer.OrdinalIgnoreCase);

    public EngineType[] GetSupportedEngines()
    {
        return new[] { EngineType.Frostbite2013_2 };
    }

    public ISet<string> GetTextureNames() => m_TextureNames;

    public ISet<string> GetShaderNames() => m_ShaderNames;

    public void Initialize(IResourceObject resource, IEngineMounter mounter)
    {
        m_ShaderNames.Clear();
        m_TextureNames.Clear();

        if (resource == null || resource.GetResourceType() != ResourceType.IShaderDatabase)
            return;

        byte[] s_Data;
        using (var s_Reader = resource.GetReader())
        using (var s_Memory = new MemoryStream())
        {
            s_Reader.CopyTo(s_Memory);
            s_Data = s_Memory.ToArray();
        }

        // Container: render path count, then per render path its id, size and database.
        var s_RenderPaths = BitConverter.ToUInt32(s_Data, 0);
        var s_Offset = 4;
        for (var i = 0; i < s_RenderPaths && s_Offset + 8 <= s_Data.Length; i++)
        {
            var s_Size = (int)BitConverter.ToUInt32(s_Data, s_Offset + 4);
            var s_Start = s_Offset + 8;
            if (s_Start + s_Size > s_Data.Length)
                throw new InvalidDataException($"Shader database {i} of {s_Size} bytes overruns the resource.");

            var s_Version = BitConverter.ToUInt32(s_Data, s_Start);
            if (s_Version != c_ShaderDatabaseVersion)
                throw new InvalidDataException($"Unsupported shader database version (expected {c_ShaderDatabaseVersion} got {s_Version}).");

            var s_Database = new ReadOnlySpan<byte>(s_Data, s_Start, s_Size);
            ReadShaderTable(s_Database, mounter);
            ReadTextureNames(s_Database, mounter);

            s_Offset = s_Start + s_Size;
        }
    }

    private void ReadShaderTable(ReadOnlySpan<byte> p_Database, IEngineMounter p_Mounter)
    {
        bool NamesShader(ReadOnlySpan<byte> p_Data, int p_Entry) =>
            p_Mounter.TryGetPartitionByHashLower(BitConverter.ToUInt32(p_Data.Slice(p_Entry, 4)), out _);

        // A position inside the table can look like a table too (a field of the previous entry read as
        // a small count), but such a match lies within the real one; keep the largest.
        var s_Best = -1;
        var s_BestCount = 0u;
        for (var s_Position = 4; s_Position <= p_Database.Length - c_EntrySize; s_Position++)
        {
            var s_Count = BitConverter.ToUInt32(p_Database.Slice(s_Position - 4, 4));
            if (s_Count < 2 || s_Count <= s_BestCount || s_Count > (p_Database.Length - s_Position) / c_EntrySize)
                continue;

            var s_Last = s_Position + (int)(s_Count - 1) * c_EntrySize;
            if (!NamesShader(p_Database, s_Position) || !NamesShader(p_Database, s_Position + c_EntrySize) || !NamesShader(p_Database, s_Last))
                continue;

            s_Best = s_Position;
            s_BestCount = s_Count;
        }

        if (s_Best >= 0)
        {
            for (var i = 0; i < s_BestCount; i++)
            {
                var s_Hash = BitConverter.ToUInt32(p_Database.Slice(s_Best + i * c_EntrySize, 4));
                if (p_Mounter.TryGetPartitionByHashLower(s_Hash, out var s_Partition))
                    m_ShaderNames.Add(s_Partition.OriginalName.ToLowerInvariant());
            }

            return;
        }

        throw new InvalidDataException("Could not find the shader table in the shader database.");
    }

    private void ReadTextureNames(ReadOnlySpan<byte> p_Database, IEngineMounter p_Mounter)
    {
        var s_Start = -1;
        for (var i = 0; i < p_Database.Length; i++)
        {
            var s_Byte = p_Database[i];
            var s_IsNameChar = s_Byte is >= (byte)'a' and <= (byte)'z' or >= (byte)'A' and <= (byte)'Z' or >= (byte)'0' and <= (byte)'9'
                or (byte)'_' or (byte)'/' or (byte)'-' or (byte)'.';

            if (s_IsNameChar)
            {
                if (s_Start < 0)
                    s_Start = i;
                continue;
            }

            if (s_Byte == 0 && s_Start >= 0 && i - s_Start >= 4)
            {
                var s_Name = Encoding.ASCII.GetString(p_Database.Slice(s_Start, i - s_Start));
                if (s_Name.Contains('/') && p_Mounter.TryGetPartition(s_Name, out _))
                    m_TextureNames.Add(s_Name.ToLowerInvariant());
            }

            s_Start = -1;
        }
    }
}
