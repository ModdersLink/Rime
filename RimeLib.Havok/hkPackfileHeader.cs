using RimeLib.IO;

namespace RimeLib.Havok
{
    public class hkPackfileHeader
    {
        public int[] Magic { get; set; } = new int[2]; // int[2];
        public int UserTag { get; set; }
        public int FileVersion  { get; set; }
        public byte[] LayoutRules { get; set; } = new byte[4]; // byte[4]
        public int NumSections  { get; set; }
        public int ContentsSectionIndex { get; set; }
        public int ContentsSectionOffset  { get; set; }
        public int ContentsClassNameSectionIndex  { get; set; }
        public int ContentsClassNameSectionOffset { get; set; }
        public byte[] ContentsVersion { get; set; } = new byte[16]; // byte[16];
        public int Flags  { get; set; }
        public int Pad { get; set; }

        public enum LayoutRule
        {
            PointerSize = 0,
            EndianType = 1,
            Platform = 2,
            Unknown = 3
        }

        public const int c_MagicCount = 2;
        public const int c_LayoutRuleCount = 4;
        public const int c_ContentsVersionCount = 16;

        public void Deserialize(RimeReader p_Reader)
        {
            // Read both magic variables
            for (var s_MagicIndex = 0; s_MagicIndex < c_MagicCount; ++s_MagicIndex)
                Magic[s_MagicIndex] = p_Reader.ReadInt32();
            
            UserTag = p_Reader.ReadInt32();
            FileVersion = p_Reader.ReadInt32();
            
            // Read all the layout rules
            for (var s_LayoutRuleIndex = 0; s_LayoutRuleIndex < c_LayoutRuleCount; ++s_LayoutRuleIndex)
                LayoutRules[s_LayoutRuleIndex] = p_Reader.ReadUByte();
            
            NumSections = p_Reader.ReadInt32();
            
            ContentsSectionIndex = p_Reader.ReadInt32();
            ContentsSectionOffset = p_Reader.ReadInt32();
            
            ContentsClassNameSectionIndex = p_Reader.ReadInt32();
            ContentsClassNameSectionOffset = p_Reader.ReadInt32();
            
            ContentsVersion = p_Reader.ReadBytes(c_ContentsVersionCount);
            
            Flags = p_Reader.ReadInt32();
            
            Pad = p_Reader.ReadInt32();
        }
    }
}