using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using fb;
using RimeLib.Frostbite;
using RimeLib.IO;

namespace RimeLib.Enlighten.Frostbite2_0;

public class EnlightenTerrainLightmap : IFbSerializable
{
    public AxisAlignedBox WorldBoundingBox { get; set; } = new AxisAlignedBox();
    public Vec4 UVTransform { get; set; } = new Vec4();
    public Vec2 UVTranslation { get; set; } = new Vec2();

    public EnlightenTerrainLightmap()
    {

    }

    public EnlightenTerrainLightmap(RimeReader p_Reader)
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
        var s_Min = new Vec3
        {
            x = p_Reader.ReadSingle(),
            y = p_Reader.ReadSingle(),
            z = p_Reader.ReadSingle()
        };

        var s_Max = new Vec3
        {
            x = p_Reader.ReadSingle(),
            y = p_Reader.ReadSingle(),
            z = p_Reader.ReadSingle()
        };

        WorldBoundingBox = new AxisAlignedBox
        {
            min = s_Min,
            max = s_Max,
        };

        UVTransform = new Vec4
        {
            x = p_Reader.ReadSingle(),
            y = p_Reader.ReadSingle(),
            z = p_Reader.ReadSingle(),
            w = p_Reader.ReadSingle()
        };

        UVTranslation = new Vec2
        {
            x = p_Reader.ReadSingle(),
            y = p_Reader.ReadSingle()
        };
    }

    public void Deserialize(byte[] p_Data)
    {
        using var s_Reader = new RimeReader(new MemoryStream(p_Data));
        Deserialize(s_Reader);
    }
}
