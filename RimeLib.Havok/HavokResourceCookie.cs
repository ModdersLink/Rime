using RimeLib.Frostbite;
using RimeLib.IO;

namespace RimeLib.Havok;

/// <summary>
/// The cookie of a HavokPhysicsData: the sizes of its header, its 32-bit and 64-bit packfiles and
/// its fixups, which together are the payload.
/// </summary>
public class HavokResourceCookie : ResourceCookie
{
    public uint HeaderSize { get; set; }
    public uint Size32 { get; set; }
    public uint Size64 { get; set; }
    public uint FixupSize { get; set; }

    public override long PayloadSize => (long)HeaderSize + Size32 + Size64 + FixupSize;

    public override bool Serialize(RimeWriter p_Writer)
    {
        p_Writer.Write(HeaderSize);
        p_Writer.Write(Size32);
        p_Writer.Write(Size64);
        p_Writer.Write(FixupSize);
        return true;
    }

    public override void Deserialize(RimeReader p_Reader)
    {
        HeaderSize = p_Reader.ReadUInt32();
        Size32 = p_Reader.ReadUInt32();
        Size64 = p_Reader.ReadUInt32();
        FixupSize = p_Reader.ReadUInt32();
    }
}
