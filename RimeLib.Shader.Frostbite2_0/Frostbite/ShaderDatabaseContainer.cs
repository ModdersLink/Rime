using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using fb;
using RimeLib.Content.Mounting;
using RimeLib.Frostbite;
using RimeLib.IO;
using RimeLib.IO.Conversion;

namespace RimeLib.Shader.Frostbite2_0.Frostbite;

/// <summary>A shaderdb resource: a count, then per render path its key, its size and its database.</summary>
public class ShaderDatabaseContainer : IFbSerializable
{
    /// <summary>In file order.</summary>
    public Dictionary<ShaderRenderPath, ShaderDatabase> Databases { get; set; } = new();

    public ShaderDatabaseContainer()
    {
    }

    public ShaderDatabaseContainer(RimeReader p_Reader)
    {
        Deserialize(p_Reader);
    }

    public ShaderDatabaseContainer(RimeReader p_Reader, IEngineMounter p_Mounter) : this(p_Reader)
    {
        foreach (var s_Database in Databases.Values)
            s_Database.ResolveNames(p_Mounter);
    }

    protected virtual ShaderDatabase CreateDatabase() => new();

    public void Deserialize(RimeReader p_Reader)
    {
        var s_PrevEndianness = p_Reader.Endianness;
        p_Reader.Endianness = Endianness.LittleEndian;

        Databases.Clear();
        var s_Count = p_Reader.ReadUInt32();
        for (var i = 0; i < s_Count; i++)
        {
            var s_Path = (ShaderRenderPath)p_Reader.ReadUInt32();
            var s_Database = CreateDatabase();
            s_Database.Deserialize(p_Reader.ReadBytes((int)p_Reader.ReadUInt32()));
            Databases.Add(s_Path, s_Database);
        }

        p_Reader.Endianness = s_PrevEndianness;
    }

    public bool Serialize(RimeWriter p_Writer)
    {
        p_Writer.Write((uint)Databases.Count);
        foreach (var (s_Path, s_Database) in Databases)
        {
            s_Database.Serialize(out var s_Data);
            p_Writer.Write((uint)s_Path);
            p_Writer.Write((uint)s_Data!.Length);
            p_Writer.Write(s_Data);
        }

        return true;
    }

    public bool Serialize([NotNullWhen(true)] out byte[]? p_Data)
    {
        var s_Stream = new MemoryStream();
        using (var s_Writer = new RimeWriter(s_Stream))
            Serialize(s_Writer);

        p_Data = s_Stream.ToArray();
        return true;
    }

    public void Deserialize(byte[] p_Data)
    {
        using var s_Reader = new RimeReader(new MemoryStream(p_Data, false));
        Deserialize(s_Reader);
    }
}
