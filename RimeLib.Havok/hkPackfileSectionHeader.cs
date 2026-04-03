using RimeLib.IO;

namespace RimeLib.Havok;

public class hkPackfileSectionHeader
{
    public char[] SectionTagData { get; set; } = new char[c_SectionTagLength];
    // Ignore in serialization
    public string SectionTag { get; private set; } = string.Empty;
    public byte NullByte { get; set; }
    public int AbsoluteDataStart { get; set; }
    public int LocalFixupsOffset { get; set; }
    public int GlobalFixupsOffset { get; set; }
    public int VirtualFixupsOffset { get; set; }
    public int ExportsOffset { get; set; }
    public int ImportsOffset { get; set; }
    public int EndOffset { get; set; }

    public const int c_SectionTagLength = 19;

    public void Deserialize(RimeReader p_Reader)
    {
        // Ew, fix this by adding a p_Reader.ReadChars(int)
        for (var s_Index = 0; s_Index < c_SectionTagLength; s_Index++)
            SectionTagData[s_Index] = p_Reader.ReadChar();

        SectionTag = new string(SectionTagData).TrimEnd('\0');
        
        NullByte = p_Reader.ReadUByte();
        AbsoluteDataStart = p_Reader.ReadInt32();
        LocalFixupsOffset = p_Reader.ReadInt32();
        GlobalFixupsOffset = p_Reader.ReadInt32();
        VirtualFixupsOffset = p_Reader.ReadInt32();
        ExportsOffset = p_Reader.ReadInt32();
        ImportsOffset = p_Reader.ReadInt32();
        EndOffset = p_Reader.ReadInt32();
    }
}