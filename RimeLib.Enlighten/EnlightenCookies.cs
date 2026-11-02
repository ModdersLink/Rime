using RimeLib.Frostbite;
using RimeLib.IO;

namespace RimeLib.Enlighten;

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

/// <summary>
/// The cookie of an EnlightenDatabase (BF4; BF3's meta is empty and its payload describes itself):
/// flags, then the sizes of the image and its relocation table.
/// </summary>
public class EnlightenDatabaseCookie : ResourceCookie
{
    public uint Flags { get; set; }
    public uint DataSize { get; set; }
    public uint RelocSize { get; set; }
    public uint Pad { get; set; }

    public override long PayloadSize => (long)DataSize + RelocSize;

    public override bool Serialize(RimeWriter p_Writer)
    {
        p_Writer.Write(Flags);
        p_Writer.Write(DataSize);
        p_Writer.Write(RelocSize);
        p_Writer.Write(Pad);
        return true;
    }

    public override void Deserialize(RimeReader p_Reader)
    {
        Flags = p_Reader.ReadUInt32();
        DataSize = p_Reader.ReadUInt32();
        RelocSize = p_Reader.ReadUInt32();
        Pad = p_Reader.ReadUInt32();
    }
}

/// <summary>
/// The cookie of an EnlightenStaticDatabase (BF4; BF3's StaticEnlightenDatabase has an empty meta):
/// whether it is enabled, then the sizes of the image and its relocation table. A disabled one's
/// payload is a single word. The pad is kept as found.
/// </summary>
public class EnlightenStaticDatabaseCookie : ResourceCookie
{
    public uint Enabled { get; set; }
    public uint DataSize { get; set; }
    public uint RelocSize { get; set; }
    public uint Pad { get; set; }

    public override long PayloadSize => Enabled != 0 ? (long)DataSize + RelocSize : 4;

    public override bool Serialize(RimeWriter p_Writer)
    {
        p_Writer.Write(Enabled);
        p_Writer.Write(DataSize);
        p_Writer.Write(RelocSize);
        p_Writer.Write(Pad);
        return true;
    }

    public override void Deserialize(RimeReader p_Reader)
    {
        Enabled = p_Reader.ReadUInt32();
        DataSize = p_Reader.ReadUInt32();
        RelocSize = p_Reader.ReadUInt32();
        Pad = p_Reader.ReadUInt32();
    }
}

/// <summary>
/// The cookie of an EnlightenShaderDatabase (BF4; BF3's meta is empty and its payload starts with
/// the count): the payload size and the number of materials. The padding is kept as found.
/// </summary>
public class EnlightenShaderDatabaseCookie : ResourceCookie
{
    public uint DataSize { get; set; }
    public uint NumMaterials { get; set; }
    public uint[] Padding { get; set; } = new uint[2];

    public override long PayloadSize => DataSize;

    public override bool Serialize(RimeWriter p_Writer)
    {
        p_Writer.Write(DataSize);
        p_Writer.Write(NumMaterials);
        p_Writer.Write(Padding[0]);
        p_Writer.Write(Padding[1]);
        return true;
    }

    public override void Deserialize(RimeReader p_Reader)
    {
        DataSize = p_Reader.ReadUInt32();
        NumMaterials = p_Reader.ReadUInt32();
        Padding = [p_Reader.ReadUInt32(), p_Reader.ReadUInt32()];
    }
}
