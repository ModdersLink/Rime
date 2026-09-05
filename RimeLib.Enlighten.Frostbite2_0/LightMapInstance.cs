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

    /// <summary>
    /// The exact inverse of <see cref="Deserialize(RimeReader)"/>: 88 bytes, being the guid (16),
    /// the transform as four bare Vec3 (48), the uv transform (16) and the uv translation (8).
    ///
    /// The transform is four Vec3 here and NOT four padded Vec4 -- unlike
    /// <see cref="EnlightenProbeSet"/>, which stores the same logical transform 16-byte aligned.
    /// The two layouts differ, and 88 is the stride the database's own reader strides by.
    /// </summary>
    public bool Serialize(RimeWriter p_Writer)
    {
        if (!Guid.Serialize(p_Writer))
            return false;

        p_Writer.Write(Transform.right.x);
        p_Writer.Write(Transform.right.y);
        p_Writer.Write(Transform.right.z);

        p_Writer.Write(Transform.up.x);
        p_Writer.Write(Transform.up.y);
        p_Writer.Write(Transform.up.z);

        p_Writer.Write(Transform.forward.x);
        p_Writer.Write(Transform.forward.y);
        p_Writer.Write(Transform.forward.z);

        p_Writer.Write(Transform.trans.x);
        p_Writer.Write(Transform.trans.y);
        p_Writer.Write(Transform.trans.z);

        p_Writer.Write(UVTransform.x);
        p_Writer.Write(UVTransform.y);
        p_Writer.Write(UVTransform.z);
        p_Writer.Write(UVTransform.w);

        p_Writer.Write(UVTranslation.x);
        p_Writer.Write(UVTranslation.y);

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
