using System;
using System.Buffers.Binary;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Newtonsoft.Json;
using RimeLib.Cmd.Attributes;
using RimeLib.Cmd.Contexts;
using RimeLib.Frostbite.Core;

namespace RimeLib.Cmd.Commands.Game
{
    /// <summary>
    /// Every 32-bit integer field in every mounted EBX partition, grouped by the type and field
    /// that declares it, so that "is this field a name hash?" can be ANSWERED rather than guessed.
    ///
    /// Frostbite stores name hashes in fields that mostly do not say "hash": EventSpec.Id,
    /// PropertyConnection.SourceFieldId, ObjectBlueprint.Identifier. The detector is the
    /// resolution rate against a reverse table built from the game's own names -- a real hash
    /// field resolves at or near 100%, and a packed bitfield or an index resolves at ~0%. That
    /// only works if EVERY integer field is offered up, including the ones nested inside structs
    /// and inside arrays of structs, which is where the connection tables live.
    ///
    /// Like DumpNameSourcesCommand this walks the bytes rather than the partition converter: the
    /// converter needs a generated fb:: class per type and throws when one is missing, so it can
    /// only see the subset Rime models. The layout walked here is the one EbxReader itself uses --
    /// instances at MetaSize+StringTableSize as GUID + TypeDescriptor.Size, field offsets relative
    /// to the instance (and to the enclosing struct), arrays at
    /// MetaSize+StringTableSize+ArrayOffset+ArrayEntry.Offset -- so it reads 100% of partitions.
    /// </summary>
    [CommandDescription("Dumps every 32-bit integer field value in every mounted partition, keyed by declaring type and field, for hash-field detection.")]
    public class DumpIntFieldsCommand : Command
    {
        [CommandArgument(Description = "Destination directory")]
        public DirectoryInfo? Destination { get; set; }

        [CommandArgument(Description = "Stop after this many partitions (0 = all). For smoke tests.", Optional = true)]
        public int MaxPartitions { get; set; } = 0;

        private const int c_HeaderSize = 80;
        private const int c_ImportSize = 32;
        private const int c_DescriptorSize = 16;
        private const int c_EntrySize = 12;
        private const int c_MaxDepth = 24;

        // A field with more distinct values than this is not a name hash in any useful sense, and
        // keeping them all would be the only part of this that could exhaust memory. The cap is
        // recorded per field so a truncated rate is never reported as if it were complete.
        private const int c_MaxDistinctPerField = 200000;

        private sealed class FieldStats
        {
            public HashSet<uint> Values = new();
            public long Occurrences;
            public bool Truncated;
        }

        private readonly Dictionary<string, FieldStats> m_Fields = new(StringComparer.Ordinal);

        // typeName -> "fieldName<tab>FieldType", unioned over the game. This is BF3's OWN
        // statement of what a type persists, which is not the same as what Rime's generated fb::
        // classes declare -- some of those are field-less stubs. It is the difference between
        // "the C# class has no Name" and "the shipped data has no Name".
        private readonly Dictionary<string, SortedSet<string>> m_Layouts = new(StringComparer.Ordinal);

        // Per-partition tables, held as fields so the recursive walk does not thread six arrays.
        private byte[] m_Data = Array.Empty<byte>();
        private string[] m_TypeNames = Array.Empty<string>();
        private int[] m_FieldNameIndex = Array.Empty<int>();
        private ushort[] m_FieldFlags = Array.Empty<ushort>();
        private ushort[] m_FieldTypeIndex = Array.Empty<ushort>();
        private int[] m_FieldOffset = Array.Empty<int>();
        private uint[] m_TypeLayout = Array.Empty<uint>();
        private byte[] m_TypeFieldCount = Array.Empty<byte>();
        private ushort[] m_TypeSize = Array.Empty<ushort>();
        private int[] m_TypeNameIndex = Array.Empty<int>();
        private uint[] m_ArrayOffsets = Array.Empty<uint>();
        private uint[] m_ArrayCounts = Array.Empty<uint>();
        private uint[] m_ArrayTypeIndex = Array.Empty<uint>();
        private long m_ArrayBase;

        public override bool Execute(ref ExecutionContext p_Context, TextWriter p_Writer)
        {
            if (Destination is null)
            {
                p_Writer.WriteLine("Usage: dump_int_fields <destination-dir> [max-partitions]");
                return false;
            }

            var s_Mounter = ((GameContext)p_Context).GetMounter();
            Directory.CreateDirectory(Destination.FullName);

            var s_Partitions = s_Mounter.GetPartitions();
            var s_Read = 0;
            var s_Failed = 0;
            var s_Internal = 0;
            var s_Index = 0;

            foreach (var s_Entry in s_Partitions)
            {
                if (MaxPartitions > 0 && s_Index >= MaxPartitions)
                    break;

                s_Index++;

                try
                {
                    using var s_Reader = s_Entry.Value.FirstVariant.GetReader();
                    m_Data = s_Reader.ReadBytes((int)s_Reader.Length);
                }
                catch (Exception)
                {
                    s_Failed++;
                    continue;
                }

                try
                {
                    if (!ScanPartition(ref s_Internal))
                        s_Failed++;
                    else
                        s_Read++;
                }
                catch (Exception)
                {
                    s_Failed++;
                }

                if (s_Read % 10000 == 0 && s_Read > 0)
                {
                    p_Writer.WriteLine($"INTFIELD: {s_Read} read, keys={m_Fields.Count}");
                    p_Writer.Flush();
                }
            }

            var s_Keys = new List<string>(m_Fields.Keys);
            s_Keys.Sort(StringComparer.Ordinal);

            long s_TotalDistinct = 0;

            using (var s_Stats = new StreamWriter(Path.Combine(Destination.FullName, "int_field_stats.tsv"),
                                                  false, new UTF8Encoding(false)))
            using (var s_Values = new StreamWriter(Path.Combine(Destination.FullName, "int_field_values.tsv"),
                                                   false, new UTF8Encoding(false)))
            {
                s_Stats.WriteLine("# key\tdistinct\toccurrences\ttruncated");

                foreach (var s_Key in s_Keys)
                {
                    var s_Stat = m_Fields[s_Key];
                    s_TotalDistinct += s_Stat.Values.Count;
                    s_Stats.WriteLine($"{s_Key}\t{s_Stat.Values.Count}\t{s_Stat.Occurrences}\t{(s_Stat.Truncated ? 1 : 0)}");

                    foreach (var s_Value in s_Stat.Values)
                        s_Values.WriteLine($"{s_Key}\t{s_Value:X8}");
                }
            }

            using (var s_LayoutWriter = new StreamWriter(Path.Combine(Destination.FullName, "type_layouts.tsv"),
                                                        false, new UTF8Encoding(false)))
            {
                s_LayoutWriter.WriteLine("# type\tfield\tfieldType");

                var s_LayoutKeys = new List<string>(m_Layouts.Keys);
                s_LayoutKeys.Sort(StringComparer.Ordinal);

                foreach (var s_Type in s_LayoutKeys)
                    foreach (var s_Field in m_Layouts[s_Type])
                        s_LayoutWriter.WriteLine($"{s_Type}\t{s_Field}");
            }

            var s_Summary = new Dictionary<string, object>
            {
                ["types_with_layouts"] = m_Layouts.Count,
                ["partitions_read"] = s_Read,
                ["partitions_failed"] = s_Failed,
                ["partitions_with_internal_instances"] = s_Internal,
                ["field_keys"] = m_Fields.Count,
                ["distinct_values_total"] = s_TotalDistinct,
                ["max_distinct_per_field"] = c_MaxDistinctPerField,
            };

            File.WriteAllText(Path.Combine(Destination.FullName, "int_field_summary.json"),
                              JsonConvert.SerializeObject(s_Summary, Formatting.Indented));

            p_Writer.WriteLine($"INTFIELD: read={s_Read} failed={s_Failed} internalInstancePartitions={s_Internal} " +
                               $"keys={m_Fields.Count} distinctValues={s_TotalDistinct}");
            p_Writer.WriteLine($"INTFIELD-DONE: {Destination.FullName}");
            return true;
        }

        private static uint U32(byte[] p_Data, long p_Offset)
            => BinaryPrimitives.ReadUInt32LittleEndian(p_Data.AsSpan((int)p_Offset));

        private bool ScanPartition(ref int p_InternalCount)
        {
            if (m_Data.Length < c_HeaderSize)
                return false;

            if (!(m_Data[0] == 0xCE && m_Data[1] == 0xD1 && m_Data[2] == 0xB2 && m_Data[3] == 0x0F))
                return false;

            var s_MetaSize = U32(m_Data, 4);
            var s_ImportCount = U32(m_Data, 12);
            var s_TypeCount = U32(m_Data, 20);
            var s_TypeDescriptorCount = U32(m_Data, 24);
            var s_FieldDescriptorCount = U32(m_Data, 28);
            var s_TypeStringTableSize = U32(m_Data, 32);
            var s_StringTableSize = U32(m_Data, 36);
            var s_ArrayCount = U32(m_Data, 40);
            var s_ArrayOffset = U32(m_Data, 44);

            var s_TypeStringStart = c_HeaderSize + (long)s_ImportCount * c_ImportSize;
            var s_Cursor = s_TypeStringStart + s_TypeStringTableSize;

            if (s_Cursor > m_Data.Length || s_MetaSize + s_StringTableSize > m_Data.Length)
                return false;

            // The type string table, and hashQuick of each entry: field and type descriptors name
            // themselves by hash, exactly as FieldDescriptor/TypeDescriptor do.
            var s_Strings = new List<string>();
            var s_Start = s_TypeStringStart;

            while (s_Start < s_TypeStringStart + s_TypeStringTableSize)
            {
                var s_Stop = s_Start;

                while (s_Stop < s_TypeStringStart + s_TypeStringTableSize && m_Data[s_Stop] != 0)
                    s_Stop++;

                if (s_Stop > s_Start)
                    s_Strings.Add(Encoding.UTF8.GetString(m_Data, (int)s_Start, (int)(s_Stop - s_Start)));

                s_Start = s_Stop + 1;
            }

            m_TypeNames = s_Strings.ToArray();

            var s_ByHash = new Dictionary<uint, int>();

            for (var i = 0; i < m_TypeNames.Length; ++i)
                s_ByHash[RimeLib.Frostbite.Utils.HashQuick(m_TypeNames[i])] = i;

            if (s_Cursor + (long)s_FieldDescriptorCount * c_DescriptorSize > m_Data.Length)
                return false;

            m_FieldNameIndex = new int[s_FieldDescriptorCount];
            m_FieldFlags = new ushort[s_FieldDescriptorCount];
            m_FieldTypeIndex = new ushort[s_FieldDescriptorCount];
            m_FieldOffset = new int[s_FieldDescriptorCount];

            for (var i = 0; i < s_FieldDescriptorCount; ++i)
            {
                var s_At = s_Cursor + (long)i * c_DescriptorSize;
                m_FieldNameIndex[i] = s_ByHash.TryGetValue(U32(m_Data, s_At), out var s_Idx) ? s_Idx : -1;
                m_FieldFlags[i] = BinaryPrimitives.ReadUInt16LittleEndian(m_Data.AsSpan((int)s_At + 4));
                m_FieldTypeIndex[i] = BinaryPrimitives.ReadUInt16LittleEndian(m_Data.AsSpan((int)s_At + 6));
                m_FieldOffset[i] = BinaryPrimitives.ReadInt32LittleEndian(m_Data.AsSpan((int)s_At + 8));
            }

            s_Cursor += (long)s_FieldDescriptorCount * c_DescriptorSize;

            while (s_Cursor % 16 != 0)
                s_Cursor++;

            if (s_Cursor + (long)s_TypeDescriptorCount * c_DescriptorSize > m_Data.Length)
                return false;

            m_TypeLayout = new uint[s_TypeDescriptorCount];
            m_TypeFieldCount = new byte[s_TypeDescriptorCount];
            m_TypeSize = new ushort[s_TypeDescriptorCount];
            m_TypeNameIndex = new int[s_TypeDescriptorCount];

            for (var i = 0; i < s_TypeDescriptorCount; ++i)
            {
                var s_At = s_Cursor + (long)i * c_DescriptorSize;
                m_TypeNameIndex[i] = s_ByHash.TryGetValue(U32(m_Data, s_At), out var s_Idx) ? s_Idx : -1;
                m_TypeLayout[i] = U32(m_Data, s_At + 4);
                m_TypeFieldCount[i] = m_Data[s_At + 8];
                m_TypeSize[i] = BinaryPrimitives.ReadUInt16LittleEndian(m_Data.AsSpan((int)s_At + 12));
            }

            s_Cursor += (long)s_TypeDescriptorCount * c_DescriptorSize;

            if (s_Cursor + (long)s_TypeCount * c_EntrySize > m_Data.Length)
                return false;

            var s_InstanceInternal = new uint[s_TypeCount];
            var s_InstanceExport = new uint[s_TypeCount];
            var s_InstanceType = new uint[s_TypeCount];

            for (var i = 0; i < s_TypeCount; ++i)
            {
                var s_At = s_Cursor + (long)i * c_EntrySize;
                s_InstanceInternal[i] = U32(m_Data, s_At);
                s_InstanceExport[i] = U32(m_Data, s_At + 4);
                s_InstanceType[i] = U32(m_Data, s_At + 8);
            }

            s_Cursor += (long)s_TypeCount * c_EntrySize;

            while (s_Cursor % 16 != 0)
                s_Cursor++;

            if (s_Cursor + (long)s_ArrayCount * c_EntrySize > m_Data.Length)
                return false;

            m_ArrayOffsets = new uint[s_ArrayCount];
            m_ArrayCounts = new uint[s_ArrayCount];
            m_ArrayTypeIndex = new uint[s_ArrayCount];

            for (var i = 0; i < s_ArrayCount; ++i)
            {
                var s_At = s_Cursor + (long)i * c_EntrySize;
                m_ArrayOffsets[i] = U32(m_Data, s_At);
                m_ArrayCounts[i] = U32(m_Data, s_At + 4);
                m_ArrayTypeIndex[i] = U32(m_Data, s_At + 8);
            }

            var s_PayloadBase = (long)s_MetaSize + s_StringTableSize;
            m_ArrayBase = s_PayloadBase + s_ArrayOffset;

            var s_At2 = s_PayloadBase;
            var s_SawInternal = false;

            for (var i = 0; i < s_TypeCount; ++i)
            {
                if (s_InstanceInternal[i] != 0)
                {
                    // EbxReader throws here rather than guessing the layout of a non-exported
                    // instance. Counted and skipped, so one odd partition cannot silently drop the
                    // rest of the game.
                    s_SawInternal = true;
                    break;
                }

                var s_TypeIdx = (int)s_InstanceType[i];

                if (s_TypeIdx < 0 || s_TypeIdx >= m_TypeSize.Length)
                    return false;

                for (var j = 0; j < s_InstanceExport[i]; ++j)
                {
                    s_At2 += GUID.SizeOf;

                    if (s_At2 + m_TypeSize[s_TypeIdx] > m_Data.Length)
                        return false;

                    WalkType(s_TypeIdx, s_At2, 0);
                    s_At2 += m_TypeSize[s_TypeIdx];
                }
            }

            if (s_SawInternal)
                p_InternalCount++;

            return true;
        }

        private string NameOf(int p_Index) => p_Index >= 0 && p_Index < m_TypeNames.Length
            ? m_TypeNames[p_Index]
            : "?";

        private void WalkType(int p_TypeIndex, long p_Base, int p_Depth)
        {
            if (p_Depth > c_MaxDepth || p_TypeIndex < 0 || p_TypeIndex >= m_TypeLayout.Length)
                return;

            var s_First = (int)m_TypeLayout[p_TypeIndex];
            var s_Count = m_TypeFieldCount[p_TypeIndex];
            var s_TypeName = NameOf(m_TypeNameIndex[p_TypeIndex]);

            if (!m_Layouts.TryGetValue(s_TypeName, out var s_Layout))
            {
                s_Layout = new SortedSet<string>(StringComparer.Ordinal);
                m_Layouts[s_TypeName] = s_Layout;
            }

            for (var i = 0; i < s_Count; ++i)
            {
                var s_Idx = s_First + i;

                if (s_Idx < 0 || s_Idx >= m_FieldOffset.Length)
                    return;

                s_Layout.Add(NameOf(m_FieldNameIndex[s_Idx]) + "\t" +
                             ((FieldType)((m_FieldFlags[s_Idx] >> 4) & 0x1F)));

                // TypeCodeShift 4, TypeCodeMask 0x1F -- the same decode as MemberInfoFlagsExtension.
                var s_Type = (FieldType)((m_FieldFlags[s_Idx] >> 4) & 0x1F);
                var s_At = p_Base + m_FieldOffset[s_Idx];

                switch (s_Type)
                {
                    case FieldType.Void:
                        // An inlined base class: its fields are offset from the SAME instance base.
                        WalkType(m_FieldTypeIndex[s_Idx], p_Base, p_Depth + 1);
                        break;

                    case FieldType.ValueType:
                        WalkType(m_FieldTypeIndex[s_Idx], s_At, p_Depth + 1);
                        break;

                    case FieldType.Array:
                        if (s_At >= 0 && s_At + 4 <= m_Data.Length)
                            WalkArray(U32(m_Data, s_At), s_TypeName, NameOf(m_FieldNameIndex[s_Idx]),
                                      p_Depth + 1);
                        break;

                    case FieldType.Int32:
                    case FieldType.UInt32:
                        if (s_At >= 0 && s_At + 4 <= m_Data.Length)
                            Record(s_TypeName + "." + NameOf(m_FieldNameIndex[s_Idx]), U32(m_Data, s_At));
                        break;
                }
            }
        }

        private void WalkArray(uint p_ArrayIndex, string p_ParentType, string p_ParentField, int p_Depth)
        {
            if (p_Depth > c_MaxDepth || p_ArrayIndex >= m_ArrayOffsets.Length)
                return;

            var s_TypeIdx = (int)m_ArrayTypeIndex[p_ArrayIndex];

            if (s_TypeIdx < 0 || s_TypeIdx >= m_TypeLayout.Length)
                return;

            var s_ElementField = (int)m_TypeLayout[s_TypeIdx];

            if (s_ElementField < 0 || s_ElementField >= m_FieldFlags.Length)
                return;

            var s_ElementType = (FieldType)((m_FieldFlags[s_ElementField] >> 4) & 0x1F);
            var s_Base = m_ArrayBase + m_ArrayOffsets[p_ArrayIndex];
            var s_Count = m_ArrayCounts[p_ArrayIndex];

            switch (s_ElementType)
            {
                case FieldType.ValueType:
                {
                    var s_ElementDesc = (int)m_FieldTypeIndex[s_ElementField];

                    if (s_ElementDesc < 0 || s_ElementDesc >= m_TypeSize.Length)
                        return;

                    var s_Stride = m_TypeSize[s_ElementDesc];

                    if (s_Stride == 0 || s_Base + (long)s_Count * s_Stride > m_Data.Length)
                        return;

                    for (var j = 0; j < s_Count; ++j)
                        WalkType(s_ElementDesc, s_Base + (long)j * s_Stride, p_Depth + 1);

                    break;
                }

                case FieldType.Int32:
                case FieldType.UInt32:
                {
                    if (s_Base + (long)s_Count * 4 > m_Data.Length || s_Base < 0)
                        return;

                    // Keyed by the field that HOLDS the array, because that is the name a caller
                    // would recognise; the element field is always called "member".
                    var s_Key = p_ParentType + "." + p_ParentField + "[]";

                    for (var j = 0; j < s_Count; ++j)
                        Record(s_Key, U32(m_Data, s_Base + (long)j * 4));

                    break;
                }
            }
        }

        private void Record(string p_Key, uint p_Value)
        {
            if (!m_Fields.TryGetValue(p_Key, out var s_Stat))
            {
                s_Stat = new FieldStats();
                m_Fields[p_Key] = s_Stat;
            }

            s_Stat.Occurrences++;

            if (s_Stat.Values.Count >= c_MaxDistinctPerField)
            {
                s_Stat.Truncated = true;
                return;
            }

            s_Stat.Values.Add(p_Value);
        }
    }
}
