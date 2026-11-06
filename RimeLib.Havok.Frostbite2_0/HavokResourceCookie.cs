using RimeLib.Frostbite;
using RimeLib.Havok.Frostbite2_0.Frostbite;
using RimeLib.IO;

namespace RimeLib.Havok.Frostbite2_0;

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

    /// <summary>The cookie of a physics resource's payload: where its parts start, and its size.</summary>
    public static HavokResourceCookie Of(byte[] p_Payload)
    {
        var s_Physics = new HavokPhysicsData(new RimeReader(new System.IO.MemoryStream(p_Payload)));
        return new HavokResourceCookie
        {
            HeaderSize = (uint)s_Physics.Instance32Offset,
            Size32 = (uint)(s_Physics.Instance64Offset - s_Physics.Instance32Offset),
            Size64 = (uint)(s_Physics.FixupsOffset - s_Physics.Instance64Offset),
            FixupSize = (uint)(p_Payload.Length - s_Physics.FixupsOffset),
        };
    }

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
