using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using fb;
using RimeLib.Frostbite;
using RimeLib.Frostbite.Core;
using RimeLib.IO;

namespace RimeLib.Enlighten.Frostbite2_0;

public class LightMapInstance : IFbSerializable
{
    public GUID Guid { get; set; } = GUID.Empty;
    public LinearTransform Transform { get; set; } = new LinearTransform();
    public Vec4 UVTransform { get; set; } = new Vec4();
    public Vec2 UVTranslation { get; set; } = new Vec2();

    public LightMapInstance()
    {

    }

    public LightMapInstance(RimeReader p_Reader)
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
        Guid = new GUID(p_Reader);

        var s_Right = new Vec3
        {
            x = p_Reader.ReadSingle(),
            y = p_Reader.ReadSingle(),
            z = p_Reader.ReadSingle()
        };

        var s_Up = new Vec3
        {
            x = p_Reader.ReadSingle(),
            y = p_Reader.ReadSingle(),
            z = p_Reader.ReadSingle()
        };

        var s_Forward = new Vec3
        {
            x = p_Reader.ReadSingle(),
            y = p_Reader.ReadSingle(),
            z = p_Reader.ReadSingle()
        };

        var s_Trans = new Vec3
        {
            x = p_Reader.ReadSingle(),
            y = p_Reader.ReadSingle(),
            z = p_Reader.ReadSingle()
        };

        Transform = new LinearTransform
        {
            right = s_Right,
            up = s_Up,
            forward = s_Forward,
            trans = s_Trans
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
