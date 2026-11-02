using RimeLib.Frostbite;
using RimeLib.IO;

namespace RimeLib.Mesh.Frostbite2_0.Frostbite;

/// <summary>
/// The cookie of a MeshSet: the sizes of its relocatable image (the cell block), its embedded
/// vertex and index data (the rsx block) and its relocation table, in payload order, then the size
/// of a MeshSetLayout and of a MeshSubset (0x70 and 0x94 in BF3, 0x70 and 0xC0 in BF4).
/// </summary>
public class MeshLayoutCookie : ResourceCookie
{
    public uint CellBlockSize { get; set; }
    public uint RsxBlockSize { get; set; }
    public uint RelocationSize { get; set; }
    public ushort MeshSetSize { get; set; }
    public ushort SubsetSize { get; set; }

    public override long PayloadSize => (long)CellBlockSize + RsxBlockSize + RelocationSize;

    public override bool Serialize(RimeWriter p_Writer)
    {
        p_Writer.Write(CellBlockSize);
        p_Writer.Write(RsxBlockSize);
        p_Writer.Write(RelocationSize);
        p_Writer.Write(MeshSetSize);
        p_Writer.Write(SubsetSize);
        return true;
    }

    public override void Deserialize(RimeReader p_Reader)
    {
        CellBlockSize = p_Reader.ReadUInt32();
        RsxBlockSize = p_Reader.ReadUInt32();
        RelocationSize = p_Reader.ReadUInt32();
        MeshSetSize = p_Reader.ReadUInt16();
        SubsetSize = p_Reader.ReadUInt16();
    }
}
