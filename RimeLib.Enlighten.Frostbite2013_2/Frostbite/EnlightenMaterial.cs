using System.IO;
using fb;
using RimeLib.Frostbite.Core;
using RimeLib.IO;

namespace RimeLib.Enlighten.Frostbite2013_2.Frostbite;

/// <summary>
/// A Frostbite 2013.2 EnlightenMaterial: the Frostbite 2 fields aligned to 48 bytes, with padding
/// after the colour and after the emissive flag.
/// </summary>
public class EnlightenMaterial : Frostbite2_0.EnlightenMaterial
{
    public const int Size = 48;

    public EnlightenMaterial()
    {
    }

    public EnlightenMaterial(RimeReader p_Reader) : base(p_Reader)
    {
    }

    public override bool Serialize(RimeWriter p_Writer)
    {
        p_Writer.Write(Color.x);
        p_Writer.Write(Color.y);
        p_Writer.Write(Color.z);
        p_Writer.Write(0u);
        Guid.Serialize(p_Writer);
        p_Writer.Write(ShaderId);
        p_Writer.Write(Emissive);
        p_Writer.WriteNullBytes(7);
        return true;
    }

    public override void Deserialize(RimeReader p_Reader)
    {
        Color = new Vec3 { x = p_Reader.ReadSingle(), y = p_Reader.ReadSingle(), z = p_Reader.ReadSingle() };
        var s_ColorPad = p_Reader.ReadUInt32();
        Guid = new GUID(p_Reader);
        ShaderId = p_Reader.ReadUInt64();
        var s_Emissive = p_Reader.ReadUByte();
        var s_Pad = p_Reader.ReadBytes(7);
        if (s_ColorPad != 0 || s_Emissive > 1 || System.Array.Exists(s_Pad, p_B => p_B != 0))
            throw new InvalidDataException("a material with padding that is not zero");

        Emissive = s_Emissive != 0;
    }
}
