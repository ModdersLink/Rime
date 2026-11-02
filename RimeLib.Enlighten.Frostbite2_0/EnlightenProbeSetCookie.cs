using RimeLib.Frostbite;
using RimeLib.IO;

namespace RimeLib.Enlighten.Frostbite2_0;

/// <summary>
/// The cookie of an EnlightenProbeSet (BF3; BF4 has no probe sets): the sizes of its image and its
/// fixups. The padding holds whatever was in memory and is kept as found.
/// </summary>
public class EnlightenProbeSetCookie : ResourceCookie
{
    public uint CellBlockSize { get; set; }
    public uint FixUpSize { get; set; }
    public uint[] Padding { get; set; } = new uint[2];

    public override long PayloadSize => (long)CellBlockSize + FixUpSize;

    public override bool Serialize(RimeWriter p_Writer)
    {
        p_Writer.Write(CellBlockSize);
        p_Writer.Write(FixUpSize);
        p_Writer.Write(Padding[0]);
        p_Writer.Write(Padding[1]);
        return true;
    }

    public override void Deserialize(RimeReader p_Reader)
    {
        CellBlockSize = p_Reader.ReadUInt32();
        FixUpSize = p_Reader.ReadUInt32();
        Padding = [p_Reader.ReadUInt32(), p_Reader.ReadUInt32()];
    }
}
