using RimeLib.IO;

namespace RimeLib.Havok;

/// <summary>
///  THIS MAY NOT BE THE REAL NAME
/// 010 scripts powback, I am willin
/// </summary>
public class hkExtendedMeshHeader // ExtendedMesh_Header
{
    public byte[] UnknownNull { get; set; } = new byte[21];
    public byte U1 { get; set; }
    public byte[] UnknownNull2 { get; set; } = new byte[11];
    public byte U2 { get; set; }
    public long UnknownNull3 { get; set; }
    public byte U3 { get; set; }
    public byte[] U4Padding { get; set; } = new byte[83];
    public int U4 { get; set; }
    public int U5 { get; set; }
    public int U6 { get; set; }
    public int U7 { get; set; }
    public short U8 { get; set; }
    public byte[] U9 { get; set; } = new byte[16];
    public byte[] U10 { get; set; } = new byte[16];
    public int Null1 { get; set; }
    public int U11 { get; set; }
    public byte[] Null2 { get; set; } = new byte[11];
    public int U12 { get; set; }
    public byte Null3 { get; set; }
    public int IndexCount { get; set; }
    public short IndexCount2 { get; set; }
    public byte Null4 { get; set; }
    public int U14 { get; set; }
    public int U15 { get; set; }
    public int U16 { get; set; }
    public int U17 { get; set; }
    public int U18 { get; set; }
    public byte U19 { get; set; }
    public int U20 { get; set; }
    public int U21 { get; set; }
    public int Null5 { get; set; }

    public hkExtendedMeshHeader()
    {
        
    }

    public hkExtendedMeshHeader(RimeReader p_Reader)
    {
        Deserialize(p_Reader);
    }

    public void Deserialize(RimeReader p_Reader)
    {
        UnknownNull = p_Reader.ReadBytes(21);
        U1 = p_Reader.ReadUByte();
        UnknownNull2 = p_Reader.ReadBytes(11);
        U2 = p_Reader.ReadUByte();
        UnknownNull3 = p_Reader.ReadInt64();
        U3 = p_Reader.ReadUByte();
        U4Padding = p_Reader.ReadBytes(83);
        U4 = p_Reader.ReadInt32();
        U5 = p_Reader.ReadInt32();
        U6 = p_Reader.ReadInt32();
        U7 = p_Reader.ReadInt32();
        U8 = p_Reader.ReadInt16();
        U9 = p_Reader.ReadBytes(16);
        U10 = p_Reader.ReadBytes(16);
        Null1 = p_Reader.ReadInt32();
        U11 = p_Reader.ReadInt32();
        Null2 = p_Reader.ReadBytes(11);
        U12 = p_Reader.ReadInt32();
        Null3 = p_Reader.ReadUByte();
        IndexCount = p_Reader.ReadInt32();
        IndexCount2 = p_Reader.ReadInt16();
        Null4 = p_Reader.ReadUByte();
        U14 = p_Reader.ReadInt32();
        U15 = p_Reader.ReadInt32();
        U16 = p_Reader.ReadInt32();
        U17 = p_Reader.ReadInt32();
        U18 = p_Reader.ReadInt32();
        U19 = p_Reader.ReadUByte();
        U20 = p_Reader.ReadInt32();
        U21 = p_Reader.ReadInt32();
        Null5 = p_Reader.ReadInt32();
    }
}