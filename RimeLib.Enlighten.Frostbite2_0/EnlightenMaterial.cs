using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using fb;
using RimeLib.Frostbite;
using RimeLib.IO;

namespace RimeLib.Enlighten.Frostbite2_0;

public class EnlightenMaterial : IFbSerializable
{
    public Vec3? Color { get; set; }
    public GUID Guid { get; set; }
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
        return true;
    }

    public bool Serialize([NotNullWhen(true)] out byte[]? p_Data)
    {
        var s_Stream = new MemoryStream();
        using var s_Writer = new RimeWriter(s_Stream);

        if (Serialize(s_Writer))
        {
            p_Data = s_Stream.ToArray();
            return true;
        }

        p_Data = null;
        return false;
    }

    public void Deserialize(RimeReader p_Reader)
    {
        Color = new Vec3
        {
            x = p_Reader.ReadSingle(),
            y = p_Reader.ReadSingle(),
            z = p_Reader.ReadSingle()
        };

        Guid = new GUID(p_Reader);
        ShaderId = p_Reader.ReadUInt64();
        Emissive = p_Reader.ReadBool();
    }

    public void Deserialize(byte[] p_Data)
    {
        using var s_Reader = new RimeReader(new MemoryStream(p_Data));
        Deserialize(s_Reader);
    }
}
