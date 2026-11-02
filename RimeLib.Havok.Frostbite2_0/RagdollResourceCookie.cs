using RimeLib.Frostbite;
using RimeLib.IO;

namespace RimeLib.Havok.Frostbite2_0;

/// <summary>The cookie of a RagdollResource: the sizes of its 32-bit and 64-bit data, which together are the payload.</summary>
public class RagdollResourceCookie : ResourceCookie
{
    public uint Size32 { get; set; }
    public uint Size64 { get; set; }
    public uint[] Padding { get; set; } = new uint[2];

    public override long PayloadSize => (long)Size32 + Size64;

    public override bool Serialize(RimeWriter p_Writer)
    {
        p_Writer.Write(Size32);
        p_Writer.Write(Size64);
        p_Writer.Write(Padding[0]);
        p_Writer.Write(Padding[1]);
        return true;
    }

    public override void Deserialize(RimeReader p_Reader)
    {
        Size32 = p_Reader.ReadUInt32();
        Size64 = p_Reader.ReadUInt32();
        Padding = [p_Reader.ReadUInt32(), p_Reader.ReadUInt32()];
    }
}
