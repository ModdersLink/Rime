namespace RimeLib.Havok;

public class hkPackfileSectionHeader
{
    public char[] SectionTag { get; set; } = new char[c_SectionTagLength];
    public byte NullByte { get; set; }
    public int AbsoluteDataStart { get; set; }
    public int LocalFixupsOffset { get; set; }
    public int GlobalFixupsOffset { get; set; }
    public int VirtualFixupsOffset { get; set; }
    public int ExportsOffset { get; set; }
    public int ImportsOffset { get; set; }
    public int EndOffset { get; set; }

    public const int c_SectionTagLength = 19;

    public void Deserialize(BinaryReader p_Reader)
    {
        SectionTag = p_Reader.ReadChars(c_SectionTagLength);
        NullByte = p_Reader.ReadByte();
        AbsoluteDataStart = p_Reader.ReadInt32();
        LocalFixupsOffset = p_Reader.ReadInt32();
        GlobalFixupsOffset = p_Reader.ReadInt32();
        VirtualFixupsOffset = p_Reader.ReadInt32();
        ExportsOffset = p_Reader.ReadInt32();
        ImportsOffset = p_Reader.ReadInt32();
        EndOffset = p_Reader.ReadInt32();
    }
}