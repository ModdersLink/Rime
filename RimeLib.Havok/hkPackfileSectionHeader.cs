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

    /// <summary>
    /// Mirrors <see cref="Deserialize"/> field for field, in its order: 0x30 bytes.
    ///
    /// The tag is written from SectionTagData, the raw 19 chars, and not from the trimmed
    /// SectionTag -- trimming loses whatever follows the first null, which the file still carries.
    /// </summary>
    public void Serialize(RimeWriter p_Writer)
    {
        for (var s_Index = 0; s_Index < c_SectionTagLength; s_Index++)
            p_Writer.Write((byte) SectionTagData[s_Index]);

        p_Writer.Write(NullByte);
        p_Writer.Write(AbsoluteDataStart);
        p_Writer.Write(LocalFixupsOffset);
        p_Writer.Write(GlobalFixupsOffset);
        p_Writer.Write(VirtualFixupsOffset);
        p_Writer.Write(ExportsOffset);
        p_Writer.Write(ImportsOffset);
        p_Writer.Write(EndOffset);
    }
}