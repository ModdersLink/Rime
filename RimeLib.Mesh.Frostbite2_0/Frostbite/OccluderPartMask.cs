using System.Diagnostics.CodeAnalysis;
using System.IO;
using RimeLib.Frostbite;
using RimeLib.IO;

namespace RimeLib.Mesh.Frostbite2_0.Frostbite;

/// <summary>A triangle's part mask: three 64-bit masks. The engine spells it OccluderPartMaks.</summary>
public class OccluderPartMask : IFbSerializable
{
    public const int Size = 24;

    public ulong[] Masks { get; set; } = new ulong[3];

    public OccluderPartMask()
    {
    }

    public OccluderPartMask(RimeReader p_Reader)
    {
        Deserialize(p_Reader);
    }

    public void Deserialize(RimeReader p_Reader)
    {
        for (var i = 0; i < Masks.Length; i++)
            Masks[i] = p_Reader.ReadUInt64();
    }

    public bool Serialize(RimeWriter p_Writer)
    {
        if (Masks.Length != 3)
            throw new InvalidDataException($"An occluder part mask is three masks, not {Masks.Length}.");

        foreach (var s_Mask in Masks)
            p_Writer.Write(s_Mask);
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
