using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Numerics;
using RimeLib.Frostbite;
using RimeLib.Frostbite.Core;
using RimeLib.IO;

namespace RimeLib.Enlighten.Frostbite2013_2.Frostbite;

/// <summary>
/// A Frostbite 2013.2 EnlightenMaterial, 48 bytes: colour, four bytes of padding, guid, shader id,
/// the emissive flag and seven bytes of padding.
/// </summary>
public class EnlightenMaterial : IFbSerializable
{
    public const int Size = 48;

    public Vector3 Color { get; set; }
    public GUID Guid { get; set; } = GUID.Empty;
    public ulong ShaderId { get; set; }
    public bool Emissive { get; set; }

    public EnlightenMaterial()
    {
    }

    public EnlightenMaterial(RimeReader p_Reader)
    {
        Deserialize(p_Reader);
    }

    public bool Serialize(RimeWriter p_Writer)
    {
        p_Writer.Write(Color);
        p_Writer.Write(0u);
        Guid.Serialize(p_Writer);
        p_Writer.Write(ShaderId);
        p_Writer.Write(Emissive);
        p_Writer.WriteNullBytes(7);
        return true;
    }

    public bool Serialize([NotNullWhen(true)] out byte[]? p_Data)
    {
        var s_Stream = new MemoryStream();
        using var s_Writer = new RimeWriter(s_Stream);
        Serialize(s_Writer);
        p_Data = s_Stream.ToArray();
        return true;
    }

    public void Deserialize(RimeReader p_Reader)
    {
        Color = p_Reader.ReadVector3();
        var s_ColorPad = p_Reader.ReadUInt32();
        Guid = new GUID(p_Reader);
        ShaderId = p_Reader.ReadUInt64();
        var s_Emissive = p_Reader.ReadUByte();
        var s_Pad = p_Reader.ReadBytes(7);
        if (s_ColorPad != 0 || s_Emissive > 1 || System.Array.Exists(s_Pad, p_B => p_B != 0))
            throw new InvalidDataException("a material with padding that is not zero");

        Emissive = s_Emissive != 0;
    }

    public void Deserialize(byte[] p_Data)
    {
        using var s_Reader = new RimeReader(new MemoryStream(p_Data));
        Deserialize(s_Reader);
    }
}
