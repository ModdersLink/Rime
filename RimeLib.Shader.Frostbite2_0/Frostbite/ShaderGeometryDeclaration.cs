using System.Diagnostics.CodeAnalysis;
using System.IO;
using RimeLib.Frostbite;
using RimeLib.IO;
using RimeLib.Mesh.Frostbite2_0.Frostbite;

namespace RimeLib.Shader.Frostbite2_0.Frostbite;

/// <summary>A geometry declaration a solution state names by hash: the hash, then the declaration.</summary>
public class ShaderGeometryDeclaration : IFbSerializable
{
    public uint Hash { get; set; }
    public GeometryDeclarationDesc Desc { get; set; } = new();

    public void Deserialize(RimeReader p_Reader)
    {
        Hash = p_Reader.ReadUInt32();
        Desc = new GeometryDeclarationDesc(p_Reader);
    }

    public bool Serialize(RimeWriter p_Writer)
    {
        p_Writer.Write(Hash);
        return Desc.Serialize(p_Writer);
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
