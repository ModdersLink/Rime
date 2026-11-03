using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using RimeLib.Havok.Frostbite2_0.Frostbite;
using RimeLib.IO;

namespace RimeLib.Havok.Frostbite2_0.Packfile;

/// <summary>
/// Havok 2010 packfiles as Frostbite 2 ships them: a header, the class names, an empty types
/// section and the data section, whose pointers are not fixed up by Havok's own tables but by the
/// blob Frostbite keeps after both packfiles (pointers to data, then pointers to objects).
/// </summary>
public static class HkPackfile
{
    private const int c_HeaderSize = 0x40;
    private const int c_SectionHeaderSize = 0x30;
    private const int c_DataSectionIndex = 2;
    private static readonly byte[] s_ContentsVersion = [.. Encoding.ASCII.GetBytes("hk_2010.2.0-r1"), 0x00, 0xFF];

    /// <summary>The objects of a packfile, from its root.</summary>
    public static HkRootLevelContainer Read(HavokPhysicsData.HavokInstance p_Instance)
    {
        var s_Names = p_Instance.Descriptors.ToDictionary(p_D => (int)p_D.Key, p_D => p_D.Name);
        // The run of fixups ends at the first -1; what follows is the 0xFF padding of the section.
        var s_Classes = p_Instance.DescriptorInfos
            .TakeWhile(p_I => (int)(p_I.Offset & 0xFFFFFFFF) != -1)
            .ToDictionary(p_I => (int)(p_I.Offset & 0xFFFFFFFF), p_I => s_Names[p_I.Key]);
        var s_Reader = new HkReader(p_Instance.ObjectData, p_Instance.PointerSize,
            p_Instance.ArrayOffsets.ToDictionary(p_F => (int)p_F.Key, p_F => (int)p_F.Value),
            p_Instance.ObjectOffsets.ToDictionary(p_F => (int)p_F.Key, p_F => (int)p_F.Value),
            s_Classes);

        return s_Reader.ObjectAt(p_Instance.HkPackfile.ContentsSectionOffset) as HkRootLevelContainer
            ?? throw new InvalidDataException("The packfile's contents are not an hkRootLevelContainer.");
    }

    /// <summary>A packfile of the objects the root reaches, for the given pointer size.</summary>
    public static HavokPhysicsData.HavokInstance Write(HkRootLevelContainer p_Root, byte p_PointerSize)
    {
        var s_Writer = new HkWriter(p_PointerSize);
        s_Writer.WriteTree(p_Root);
        var s_Objects = s_Writer.ToArray();

        // The class names: the reflection classes, then each class in the order its first object is.
        var s_Descriptors = new List<hkDescriptor>();
        var s_NameOffsets = new Dictionary<string, int>();
        var s_ClassNameSize = 0;
        foreach (var (s_Name, s_Signature) in HkClasses.Reflection.Concat(s_Writer.Objects
                     .Select(p_O => p_O.Object.ClassName).Distinct().Select(p_N => (p_N, HkClasses.Signature(p_N)))))
        {
            s_NameOffsets[s_Name] = s_ClassNameSize + 5;
            s_Descriptors.Add(new hkDescriptor { Signature = (int)s_Signature, Version = 0x09, Name = s_Name, Key = s_ClassNameSize + 5 });
            s_ClassNameSize += 5 + s_Name.Length + 1;
        }

        s_ClassNameSize = RoundUp(s_ClassNameSize, 16);

        var s_VirtualFixups = s_Writer.Objects
            .Select(p_O => new hkDescriptorInfo { Offset = p_O.Offset, Key = s_NameOffsets[p_O.Object.ClassName] })
            .ToList();
        var s_DataEnd = s_Objects.Length + RoundUp(s_VirtualFixups.Count * hkDescriptorInfo.c_SizeOfDescriptorInfo, 16);

        var s_LocalSize = RoundUp(s_Writer.LocalFixups.Count * 8, 16);
        var s_FixupSize = s_LocalSize + RoundUp(s_Writer.GlobalFixups.Count * 12, 16);

        var s_ClassNamesStart = c_HeaderSize + 3 * c_SectionHeaderSize;
        var s_DataStart = s_ClassNamesStart + s_ClassNameSize;

        return new HavokPhysicsData.HavokInstance
        {
            PointerSize = p_PointerSize,
            EndianType = 1,
            HkPackfile = new hkPackfileHeader
            {
                Magic = [0x57E0E057, 0x10C0C010],
                FileVersion = 8,
                LayoutRules = [p_PointerSize, 1, 0, 1],
                NumSections = 3,
                ContentsSectionIndex = c_DataSectionIndex,
                ContentsSectionOffset = s_Writer.OffsetOf(p_Root),
                ContentsClassNameSectionIndex = 0,
                ContentsClassNameSectionOffset = s_NameOffsets[p_Root.ClassName],
                ContentsVersion = s_ContentsVersion.ToArray(),
                Pad = -1,
            },
            ClassNamesSection = Section("__classnames__", s_ClassNamesStart, 0, 0, s_ClassNameSize, s_ClassNameSize),
            TypesSection = Section("__types__", s_DataStart, 0, 0, 0, 0),
            DataSection = Section("__data__", s_DataStart, s_FixupSize, s_LocalSize, s_Objects.Length, s_DataEnd),
            Descriptors = s_Descriptors,
            DescriptorInfos = s_VirtualFixups,
            ObjectData = s_Objects,
            ArrayOffsets = s_Writer.LocalFixups.ToDictionary(p_F => (long)p_F.Source, p_F => (long)p_F.Target),
            ObjectOffsets = s_Writer.GlobalFixups.ToDictionary(p_F => (long)p_F.Source, p_F => (long)s_Writer.OffsetOf(p_F.Target)),
            FixupData = FixupBlob(s_Writer, s_LocalSize, s_FixupSize),
        };
    }

    /// <summary>A section header; the fixup fields of the data section are what Frostbite keeps there.</summary>
    private static hkPackfileSectionHeader Section(string p_Tag, int p_Start, int p_Local, int p_Global, int p_Virtual, int p_End)
    {
        var s_Section = new hkPackfileSectionHeader
        {
            NullByte = 0xFF,
            AbsoluteDataStart = p_Start,
            LocalFixupsOffset = p_Local,
            GlobalFixupsOffset = p_Global,
            VirtualFixupsOffset = p_Virtual,
            ExportsOffset = p_End,
            ImportsOffset = p_End,
            EndOffset = p_End,
        };
        p_Tag.PadRight(hkPackfileSectionHeader.c_SectionTagLength, '\0').CopyTo(0, s_Section.SectionTagData, 0, hkPackfileSectionHeader.c_SectionTagLength);
        return s_Section;
    }

    /// <summary>The pointers to data, then the pointers to objects, each run padded to 16 with 0xFF.</summary>
    private static byte[] FixupBlob(HkWriter p_Writer, int p_LocalSize, int p_Size)
    {
        var s_Stream = new MemoryStream();
        using (var s_Blob = new RimeWriter(s_Stream))
        {
            foreach (var (s_Source, s_Target) in p_Writer.LocalFixups)
            {
                s_Blob.Write(s_Source);
                s_Blob.Write(s_Target);
            }

            PadWith0xFF(s_Blob, p_LocalSize);

            foreach (var (s_Source, s_Target) in p_Writer.GlobalFixups)
            {
                s_Blob.Write(s_Source);
                s_Blob.Write(c_DataSectionIndex);
                s_Blob.Write(p_Writer.OffsetOf(s_Target));
            }

            PadWith0xFF(s_Blob, p_Size);
        }

        return s_Stream.ToArray();
    }

    private static void PadWith0xFF(RimeWriter p_Writer, int p_Until)
    {
        while (p_Writer.Position < p_Until)
            p_Writer.Write((byte)0xFF);
    }

    private static int RoundUp(int p_Value, int p_Alignment) => (p_Value + p_Alignment - 1) / p_Alignment * p_Alignment;
}
