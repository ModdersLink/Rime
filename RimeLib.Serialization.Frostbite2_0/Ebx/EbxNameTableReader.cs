using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using RimeLib.Frostbite;
using RimeLib.IO;

namespace RimeLib.Serialization.Frostbite2_0.Ebx;

/// <summary>
/// Frostbite 2 partition name tables: the <see cref="StreamingPartitionHeader"/>, the imports, the
/// type string table with the field and type descriptors after it (16 bytes each, the name hash
/// first; the type descriptors start 16-byte aligned), and the string table at MetaSize.
/// </summary>
public class EbxNameTableReader : IEbxNameTable
{
    private const uint c_LittleEndianMagic = 0x0FB2D1CE;
    private const int c_ImportSize = 32;
    private const int c_DescriptorSize = 16;

    public EngineType[] GetSupportedEngines() => new[] { EngineType.Frostbite2_0 };

    public EbxNameTable? Read(byte[] p_Partition)
    {
        if (p_Partition.Length < StreamingPartitionHeader.SizeOf)
            throw new InvalidDataException($"A partition has at least {StreamingPartitionHeader.SizeOf} bytes, this one {p_Partition.Length}.");

        using var s_Reader = new RimeReader(new MemoryStream(p_Partition));
        var s_Header = new StreamingPartitionHeader(s_Reader);

        if (s_Header.Magic != c_LittleEndianMagic)
            return null;

        var s_TypeStringStart = StreamingPartitionHeader.SizeOf + (long)s_Header.ImportCount * c_ImportSize;
        var s_TypeStringEnd = s_TypeStringStart + s_Header.TypeStringTableSize;

        if (s_TypeStringEnd > p_Partition.Length || (long)s_Header.MetaSize + s_Header.StringTableSize > p_Partition.Length)
            throw new InvalidDataException("The name tables run past the end of the partition.");

        s_Reader.Seek(s_TypeStringStart, SeekOrigin.Begin);
        var s_TypeStrings = Split(s_Reader.ReadBytes((int)s_Header.TypeStringTableSize));

        var s_Hashes = new List<uint>();
        ReadDescriptorHashes(s_Reader, s_Header.FieldDescriptorCount, s_Hashes);

        if (s_Reader.Position % c_DescriptorSize != 0)
            s_Reader.Seek(c_DescriptorSize - s_Reader.Position % c_DescriptorSize, SeekOrigin.Current);

        ReadDescriptorHashes(s_Reader, s_Header.TypeDescriptorCount, s_Hashes);

        s_Reader.Seek(s_Header.MetaSize, SeekOrigin.Begin);
        var s_ValueStrings = Split(s_Reader.ReadBytes((int)s_Header.StringTableSize));

        return new EbxNameTable(s_TypeStrings, s_ValueStrings, s_Hashes);
    }

    public IEnumerable<(uint Hash, string Name)> GetNamedHashes(DataContainerBase p_Instance)
    {
        if (p_Instance is fb.ObjectVariation s_Variation)
            yield return (s_Variation.NameHash, s_Variation.Name);
    }

    /// <summary>The hash at the start of each descriptor, as far as the partition holds whole descriptors.</summary>
    private static void ReadDescriptorHashes(RimeReader p_Reader, uint p_Count, List<uint> p_Hashes)
    {
        for (var i = 0; i < p_Count && p_Reader.Position + c_DescriptorSize <= p_Reader.Length; ++i)
        {
            p_Hashes.Add(p_Reader.ReadUInt32());
            p_Reader.Seek(c_DescriptorSize - sizeof(uint), SeekOrigin.Current);
        }
    }

    /// <summary>
    /// The strings of a NUL-separated table. Empty runs are dropped: a table starts with a NUL so
    /// that offset 0 means the empty string.
    /// </summary>
    private static List<string> Split(byte[] p_Table)
    {
        var s_Strings = new List<string>();
        var s_Start = 0;

        for (var i = 0; i <= p_Table.Length; ++i)
        {
            if (i < p_Table.Length && p_Table[i] != 0)
                continue;

            if (i > s_Start)
                s_Strings.Add(Encoding.UTF8.GetString(p_Table, s_Start, i - s_Start));

            s_Start = i + 1;
        }

        return s_Strings;
    }
}
