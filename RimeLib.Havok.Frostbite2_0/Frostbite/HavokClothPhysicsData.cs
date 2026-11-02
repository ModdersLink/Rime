using System.Diagnostics.CodeAnalysis;
using System.IO;
using RimeLib.Frostbite;
using RimeLib.IO;

namespace RimeLib.Havok.Frostbite2_0.Frostbite;

/// <summary>A HavokClothPhysicsData: the sizes of its two packfiles, then the packfiles.</summary>
public class HavokClothPhysicsData : IFbSerializable
{
    public HavokPackfilePair Packfiles { get; set; } = new();

    public HavokClothPhysicsData()
    {
    }

    public HavokClothPhysicsData(RimeReader p_Reader)
    {
        Deserialize(p_Reader);
    }

    public void Deserialize(RimeReader p_Reader)
    {
        Packfiles = new HavokPackfilePair(p_Reader.ReadInt32(), p_Reader.ReadInt32());
        Packfiles.Deserialize(p_Reader);
    }

    public void Deserialize(byte[] p_Data)
    {
        using var s_Reader = new RimeReader(new MemoryStream(p_Data, false));
        Deserialize(s_Reader);
    }

    public bool Serialize(RimeWriter p_Writer)
    {
        var s_Sizes = p_Writer.Position;
        p_Writer.Write(0);
        p_Writer.Write(0);
        Packfiles.Serialize(p_Writer);

        var s_End = p_Writer.Position;
        p_Writer.Seek(s_Sizes, SeekOrigin.Begin);
        p_Writer.Write(Packfiles.Size32);
        p_Writer.Write(Packfiles.Size64);
        p_Writer.Seek(s_End, SeekOrigin.Begin);
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
}
