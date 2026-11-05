using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using fb;
using RimeLib.Frostbite;
using RimeLib.IO;

namespace RimeLib.Enlighten.Frostbite2_0;

/// <summary>
/// One baked probe: four Vec4, sixty-four bytes. Frostbite 2013.2's static database holds the same
/// probes.
///
/// Each is shaped like a first-order spherical harmonic -- three signed directional terms and a
/// fourth that is never negative. MEASURED over MP_001's probes: components 0-2 of each vector run
/// either side of zero within about +/-0.05, while component 3 stays at or above zero. The first
/// three vectors are the red, green and blue bands; what the fourth carries is not established
/// here, so it is named for its position rather than given a meaning it may not have.
/// </summary>
public class StaticEnlightenProbe : IFbSerializable
{
    public Vec4 Red { get; set; } = new Vec4();
    public Vec4 Green { get; set; } = new Vec4();
    public Vec4 Blue { get; set; } = new Vec4();
    public Vec4 Fourth { get; set; } = new Vec4();

    public StaticEnlightenProbe()
    {

    }

    public StaticEnlightenProbe(RimeReader p_Reader)
    {
        Deserialize(p_Reader);
    }

    public bool Serialize(RimeWriter p_Writer)
    {
        WriteVec4(p_Writer, Red);
        WriteVec4(p_Writer, Green);
        WriteVec4(p_Writer, Blue);
        WriteVec4(p_Writer, Fourth);

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
        Red = ReadVec4(p_Reader);
        Green = ReadVec4(p_Reader);
        Blue = ReadVec4(p_Reader);
        Fourth = ReadVec4(p_Reader);
    }

    public void Deserialize(byte[] p_Data)
    {
        using var s_Reader = new RimeReader(new MemoryStream(p_Data));
        Deserialize(s_Reader);
    }

    private static Vec4 ReadVec4(RimeReader p_Reader)
    {
        return new Vec4
        {
            x = p_Reader.ReadSingle(),
            y = p_Reader.ReadSingle(),
            z = p_Reader.ReadSingle(),
            w = p_Reader.ReadSingle()
        };
    }

    private static void WriteVec4(RimeWriter p_Writer, Vec4 p_Value)
    {
        p_Writer.Write(p_Value.x);
        p_Writer.Write(p_Value.y);
        p_Writer.Write(p_Value.z);
        p_Writer.Write(p_Value.w);
    }
}
