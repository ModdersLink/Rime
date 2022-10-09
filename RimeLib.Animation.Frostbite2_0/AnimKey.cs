using System.Diagnostics.CodeAnalysis;
using System.IO;
using RimeLib.Frostbite;
using RimeLib.IO;

namespace RimeLib.Animation.Frostbite2_0;

public class AnimKey : IFbSerializable
{
    public float Time { get; set; }
    public float Value { get; set; }
    public float InTanX { get; set; }
    public float InTanY { get; set; }
    public float OutTanX { get; set; }
    public float OutTanY { get; set; }

    public AnimKey()
    {

    }

    public AnimKey(RimeReader p_Reader)
    {
        Deserialize(p_Reader);
    }

    public bool Serialize(RimeWriter p_Writer)
    {
        p_Writer.Write(Time);
        p_Writer.Write(Value);
        p_Writer.Write(InTanX);
        p_Writer.Write(InTanY);
        p_Writer.Write(OutTanX);
        p_Writer.Write(OutTanY);

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
        Time = p_Reader.ReadSingle();
        Value = p_Reader.ReadSingle();
        InTanX = p_Reader.ReadSingle();
        InTanY = p_Reader.ReadSingle();
        OutTanX = p_Reader.ReadSingle();
        OutTanY = p_Reader.ReadSingle();
    }

    public void Deserialize(byte[] p_Data)
    {
        using var s_Reader = new RimeReader(new MemoryStream(p_Data));
        Deserialize(s_Reader);
    }
}