using RimeLib.IO;

namespace RimeLib.Havok;

/// <summary>
/// THIS MAY NOT BE THE REAL NAME
/// COMES FROM POWBACKS 010 SCRIPTS
/// </summary>
public class hkxBlock
{
    public ushort Pad { get; set; }
    public uint B1 { get; set; }
    public uint B2 { get; set; }
    public uint B3 { get; set; }
    public uint SkeletonsCount { get; set; }
    public uint B5 { get; set; }
    public uint B6 { get; set; }
    public short AnimationsCount { get; set; }
    public short B7 { get; set; }
    public uint B8 { get; set; }
    public uint B9 {get; set;}
    public uint BindingsCount { get; set; }
    public uint B11 { get; set; }
    public uint B12 { get; set; }
    public uint AttachmentsCount { get; set; }
    public uint B14 { get; set; }
    public uint B15 { get; set; }
    public uint SkinsCount { get; set; }
    public uint B17 { get; set; }

    public hkxBlock()
    {
        
    }

    public hkxBlock(RimeReader p_Reader)
    {
        Deserialize(p_Reader);
    }

    public void Deserialize(RimeReader p_Reader)
    {
        Pad = p_Reader.ReadUInt16();
        B1 = p_Reader.ReadUInt32();
        B2 = p_Reader.ReadUInt32();
        B3 = p_Reader.ReadUInt32();
        SkeletonsCount = p_Reader.ReadUInt32();
        B5 = p_Reader.ReadUInt32();
        B6 = p_Reader.ReadUInt32();
        AnimationsCount = p_Reader.ReadInt16();
        B7 = p_Reader.ReadInt16();
        B8 = p_Reader.ReadUInt32();
        B9 = p_Reader.ReadUInt32();
        BindingsCount =  p_Reader.ReadUInt32();
        B11 = p_Reader.ReadUInt32();
        B12 = p_Reader.ReadUInt32();
        AttachmentsCount = p_Reader.ReadUInt32();
        B14 = p_Reader.ReadUInt32();
        B15 = p_Reader.ReadUInt32();
        SkinsCount = p_Reader.ReadUInt32();
        B17 = p_Reader.ReadUInt32();
    }
}