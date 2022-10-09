using System.Diagnostics.CodeAnalysis;
using System.IO;
using RimeLib.Frostbite;
using RimeLib.IO;

namespace RimeLib.Animation.Frostbite2_0.Frostbite;

public class AnimTrackData : IFbSerializable
{
    public AnimKey[] AnimKeys { get; set; }

    public AnimTrackData()
    {

    }

    public AnimTrackData(RimeReader p_Reader)
    {
        Deserialize(p_Reader);
    }

    public bool Serialize(RimeWriter p_Writer)
    {
        foreach (var s_AnimKey in AnimKeys)
        {
            s_AnimKey.Serialize(p_Writer);
        }

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
        for (var i = 0; i < p_Reader.Length; i++)
            AnimKeys.SetValue(new AnimKey(p_Reader), i);
    }

    public void Deserialize(byte[] p_Data)
    {
        using var s_Reader = new RimeReader(new MemoryStream(p_Data));
        Deserialize(s_Reader);
    }
}