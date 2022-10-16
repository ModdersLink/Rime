using RimeLib.Frostbite;
using RimeLib.IO;

namespace RimeLib.Havok.Frostbite2_0;

public struct HkPackfileSection
{
    public string SectionTag { get; set; }
    public int AbsoluteDataStart { get; set; }
    public int LocalFixupsOffset { get; set; }
    public int GlobalFixupsOffset { get; set; }
    public int VirtualFixupsOffset { get; set; }
    public int ExportsOffset { get; set; }
    public int ImportsOffset { get; set; }
    public int EndOffset { get; set; }
}

public class HkPackfileHeader
{
    public int UserTag { get; set; }
    
    public int FileVersion { get; set; }

    public byte[] LayoutRules { get; set; } = new byte[4];

    public List<HkPackfileSection> Sections { get; set; } = new();
    
    public int ContentsSectionIndex { get; set; }
    
    public int ContentsSectionOffset { get; set; }
    
    public int ContentsClassNameSectionIndex { get; set; }
    
    public int ContentsClassNameSectionOffset { get; set; }

    public string ContentsVersion { get; set; } = "";
    
    public int Flags { get; set; }

    public string ClassName { get; set; } = "";

    public HkPackfileHeader(RimeReader p_Reader, RimeReader p_FixupTableReader)
    {
        // Fixup table format:
        // 32bitSize: uint32
        // 64bitSize: uint32
        // (fromOffset: uint32, toOffset: uint32) x globalFixupOffset32 / 4 / 2
        // (fromOffset: uint32, sectionIndex: uint32, toOffset: uint32) x (localFixupsOffset32 - globalFixupsOffset32) / 4 / 3
        // (fromOffset: uint32, toOffset: uint32) x globalFixupOffset / 4 / 2
        // (fromOffset: uint32, sectionIndex: uint32, toOffset: uint32) x (localFixupsOffset64 - globalFixupsOffset64) / 4 / 3
        // unknown01: uint32
        // unknown02: uint32
        // unknown03: uint32
        // unknown04: uint32

        // Virtual fixups
        // at packfile + absoluledatastart + virtualfixupsoffset
        // ends at packfile + absolutedatastart + virtualfixupsoffset + exportsoffset
        // format:
        // offsetFromAbsoluteData: uint32
        // sectionIndex: uint32
        // classNameOffset: uint32
        //
        // Basically offsetFromAbsoluteData points to a havok class of the type that's at
        // classNameOffset + absoluteData for the section at index sectionIndex.
        
        var s_StartPos = p_Reader.Position;
        
        var s_Magic1 = p_Reader.ReadUInt32();
        var s_Magic2 = p_Reader.ReadUInt32();

        if (s_Magic1 != 0x57E0E057 || s_Magic2 != 0x10C0C010)
            throw new Exception("This shit fucked");

        UserTag = p_Reader.ReadInt32();
        FileVersion = p_Reader.ReadInt32();
        
        for (var i = 0; i < 4; ++i)
            LayoutRules[i] = p_Reader.ReadUByte();

        var s_SectionCount = p_Reader.ReadInt32();

        ContentsSectionIndex = p_Reader.ReadInt32();
        ContentsSectionOffset = p_Reader.ReadInt32();
        ContentsClassNameSectionIndex = p_Reader.ReadInt32();
        ContentsClassNameSectionOffset = p_Reader.ReadInt32();
        ContentsVersion = p_Reader.ReadFixedLengthString(16);
        Flags = p_Reader.ReadInt32();
        p_Reader.ReadInt32(); // padding
        
        Sections.Clear();

        for (var i = 0; i < s_SectionCount; ++i)
        {
            var s_Section = new HkPackfileSection();
            
            s_Section.SectionTag = p_Reader.ReadFixedLengthString(19);
            p_Reader.ReadUByte();
            s_Section.AbsoluteDataStart = p_Reader.ReadInt32();
            s_Section.LocalFixupsOffset = p_Reader.ReadInt32();
            s_Section.GlobalFixupsOffset = p_Reader.ReadInt32();
            s_Section.VirtualFixupsOffset = p_Reader.ReadInt32();
            s_Section.ExportsOffset = p_Reader.ReadInt32();
            s_Section.ImportsOffset = p_Reader.ReadInt32();
            s_Section.EndOffset = p_Reader.ReadInt32();

            Sections.Add(s_Section);
        }

        var s_DataStartOffset = Sections[ContentsSectionIndex].AbsoluteDataStart + ContentsSectionOffset;
        var s_ClassNameOffset = Sections[ContentsClassNameSectionIndex].AbsoluteDataStart + ContentsClassNameSectionOffset;

        p_Reader.Seek(s_StartPos + s_ClassNameOffset, SeekOrigin.Begin);
        ClassName = p_Reader.ReadNullTerminatedString();
    }
}
