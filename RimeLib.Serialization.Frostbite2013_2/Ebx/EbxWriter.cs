using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using RimeLib.Frostbite.Core;
using RimeLib.IO;
using RimeLib.IO.Conversion;

namespace RimeLib.Serialization.Frostbite2013_2.Ebx;

/// <summary>
/// Writes a Frostbite 2013.2 EBX partition. Type and field descriptors come from
/// <see cref="EbxLayoutLibrary"/>, so every type written has to have been read in some partition
/// first; the tables, strings, imports, instances and arrays are laid out the way the game's files
/// lay them out (see the layout notes in each step).
/// </summary>
public class EbxWriter
{
    private const uint c_Magic = 0x0FB2D1CE;

    private readonly List<EbxTypeLayout> m_Types = new();
    private readonly Dictionary<string, int> m_TypeIndices = new();
    private readonly List<string> m_TypeStrings = new();
    private readonly HashSet<string> m_TypeStringSet = new();
    private readonly HashSet<string> m_TypeStringVisited = new();

    private readonly List<(GUID Partition, GUID Instance)> m_Imports = new();
    private readonly Dictionary<(Guid, Guid), int> m_ImportIndices = new();

    private readonly Dictionary<string, uint> m_StringOffsets = new();
    private readonly List<(uint Offset, uint Count, string TypeKey)> m_Arrays = new();
    private readonly Dictionary<DataContainerId, int> m_InstanceIndices = new();

    private Endianness m_Endianness = Endianness.LittleEndian;
    private RimeWriter m_Strings = null!;
    private RimeWriter m_ArrayData = null!;
    private DatabasePartition m_Partition = new();

    /// <summary>Writes the partition to <paramref name="p_Writer"/>, in that writer's byte order.</summary>
    public void Write(RimeWriter p_Writer, DatabasePartition p_Partition)
    {
        m_Partition = p_Partition;
        m_Endianness = p_Writer.Endianness;
        m_Strings = NewWriter();
        m_ArrayData = NewWriter();

        // Instances: the primary first, then those with a GUID (exported), then the others, each
        // group in partition order. Runs of one type form the ranges.
        var s_Primary = p_Partition.PrimaryInstance;
        var s_Instances = p_Partition.InstanceMap.Values.Where(p_I => p_I != null)
            .OrderBy(p_I => ReferenceEquals(p_I, s_Primary) ? 0 : p_I.InstanceId is DataContainerId.Guid ? 1 : 2).ToList();
        for (var i = 0; i < s_Instances.Count; ++i)
            m_InstanceIndices[s_Instances[i].InstanceId] = i;

        var s_Ranges = new List<(string TypeKey, bool Exported, List<DataContainerBase> Instances)>();
        foreach (var s_Instance in s_Instances)
        {
            var s_Key = s_Instance.GetType().Name;
            var s_Exported = s_Instance.InstanceId is DataContainerId.Guid;
            if (s_Ranges.Count > 0 && s_Ranges[^1].TypeKey == s_Key && s_Ranges[^1].Exported == s_Exported)
                s_Ranges[^1].Instances.Add(s_Instance);
            else
                s_Ranges.Add((s_Key, s_Exported, new List<DataContainerBase> { s_Instance }));
        }

        // Types: depth-first from each instance type, the instance types sorted by name, a type's
        // base before it and the types its fields use after it. Type strings: the base's strings,
        // the type's name, then per field the strings of its type followed by the field's name.
        foreach (var s_Key in s_Ranges.Select(p_R => p_R.TypeKey).Distinct().OrderBy(p_K => p_K, StringComparer.Ordinal))
        {
            AddType(s_Key);
            AddTypeStrings(s_Key);
        }

        // The empty array every empty array field points at; it takes the type of the first array
        // field written.
        if (m_Types.Any(p_T => p_T.Key.StartsWith("array<")))
            m_Arrays.Add((0, 0, ""));

        // Instances, field by field; strings, imports and arrays are numbered as they come up.
        var s_Payload = NewWriter();
        foreach (var (s_Key, s_Exported, s_RangeInstances) in s_Ranges)
        {
            var s_Layout = Layout(s_Key);
            s_Payload.Align(s_Layout.Alignment);

            foreach (var s_Instance in s_RangeInstances)
            {
                if (s_Exported)
                    ((DataContainerId.Guid)s_Instance.InstanceId).Id.Serialize(s_Payload);

                var s_Buffer = NewWriter();
                s_Buffer.WriteNullBytes(s_Layout.Size);
                WriteObject(s_Buffer, 0, s_Layout, s_Instance);

                // Types aligned to 4 start 8 bytes before their data: the GUID covers them.
                var s_Shift = s_Layout.Alignment == 4 ? 8 : 0;
                var s_Bytes = Bytes(s_Buffer);
                s_Payload.Write(s_Bytes, s_Shift, s_Bytes.Length - s_Shift);
            }
        }

        // The instances are followed by at least 4 bytes of padding up to the next 16.
        s_Payload.WriteNullBytes(4);
        s_Payload.Align(16);
        var s_ArrayOffset = (uint)s_Payload.Position;

        m_ArrayData.Align(16);
        s_Payload.Write(m_ArrayData);
        m_Strings.Align(16);

        // Metadata, after room for the header.
        var s_Meta = NewWriter();
        s_Meta.WriteNullBytes((uint)StreamingPartitionHeader.SizeOf);
        s_Meta.Align(16);

        foreach (var (s_Partition, s_Instance) in m_Imports)
        {
            s_Partition.Serialize(s_Meta);
            s_Instance.Serialize(s_Meta);
        }

        var s_TypeStringStart = s_Meta.Position;
        foreach (var s_String in m_TypeStrings)
            s_Meta.WriteNullTerminatedString(s_String);
        s_Meta.Align(16);
        var s_TypeStringSize = s_Meta.Position - s_TypeStringStart;

        var s_FieldIndex = 0;
        var s_FieldStarts = new List<int>();
        foreach (var s_Type in m_Types)
        {
            s_FieldStarts.Add(s_FieldIndex);
            foreach (var s_Field in s_Type.Fields)
            {
                s_Meta.Write(s_Field.NameHash);
                s_Meta.Write(s_Field.Flags);
                s_Meta.Write((ushort)(s_Field.TypeKey != null ? m_TypeIndices[s_Field.TypeKey] : 0));
                s_Meta.Write(s_Field.Offset);
                s_Meta.Write(s_Field.SecondaryOffset);
                ++s_FieldIndex;
            }
        }

        for (var i = 0; i < m_Types.Count; ++i)
        {
            var s_Type = m_Types[i];
            s_Meta.Write(s_Type.NameHash);
            s_Meta.Write((uint)s_FieldStarts[i]);
            s_Meta.Write((byte)s_Type.Fields.Count);
            s_Meta.Write(s_Type.Alignment);
            s_Meta.Write(s_Type.Flags);
            s_Meta.Write(s_Type.Size);
            s_Meta.Write(s_Type.SecondarySize);
        }

        foreach (var (s_Key, _, s_RangeInstances) in s_Ranges)
        {
            s_Meta.Write((ushort)m_TypeIndices[s_Key]);
            s_Meta.Write((ushort)s_RangeInstances.Count);
        }
        s_Meta.Align(16);

        foreach (var (s_Offset, s_Count, s_TypeKey) in m_Arrays)
        {
            s_Meta.Write(s_Offset);
            s_Meta.Write(s_Count);
            s_Meta.Write((uint)m_TypeIndices[s_TypeKey]);
        }
        s_Meta.Align(16);

        var s_Header = new StreamingPartitionHeader
        {
            Magic = c_Magic,
            MetaSize = (uint)s_Meta.Position,
            PayloadSize = (uint)(m_Strings.Position + s_Payload.Position),
            ImportCount = (uint)m_Imports.Count,
            RangeCount = (ushort)s_Ranges.Count,
            ExportedRangeCount = (ushort)s_Ranges.Count(p_R => p_R.Exported),
            TypeCount = (ushort)s_Ranges.Select(p_R => p_R.TypeKey).Distinct().Count(),
            TypeDescriptorCount = (ushort)m_Types.Count,
            FieldDescriptorCount = (ushort)s_FieldIndex,
            TypeStringTableSize = (ushort)s_TypeStringSize,
            StringTableSize = (uint)m_Strings.Position,
            ArrayCount = (uint)m_Arrays.Count,
            ArrayOffset = s_ArrayOffset,
            PartitionGuid = p_Partition.PartitionGuid,
        };
        s_Meta.Seek(0, SeekOrigin.Begin);
        s_Header.Serialize(s_Meta);

        p_Writer.Write(s_Meta);
        p_Writer.Write(m_Strings);
        p_Writer.Write(s_Payload);
    }

    private RimeWriter NewWriter() => new(new MemoryStream(), m_Endianness);

    private static byte[] Bytes(RimeWriter p_Writer)
    {
        p_Writer.Flush();
        return ((MemoryStream)p_Writer.BaseStream).ToArray();
    }

    private static EbxTypeLayout Layout(string p_Key)
    {
        if (!EbxLayoutLibrary.TryGet(p_Key, out var s_Layout))
            throw new InvalidOperationException($"No layout known for type '{p_Key}'; read a partition that has it first.");
        return s_Layout;
    }

    private void AddType(string p_Key)
    {
        if (m_TypeIndices.ContainsKey(p_Key))
            return;

        var s_Layout = Layout(p_Key);
        var s_Base = s_Layout.Fields.FirstOrDefault(p_F => p_F.Name == "$");
        if (s_Base?.TypeKey != null)
            AddType(s_Base.TypeKey);

        if (m_TypeIndices.ContainsKey(p_Key))
            return;

        m_TypeIndices[p_Key] = m_Types.Count;
        m_Types.Add(s_Layout);

        foreach (var s_Field in s_Layout.Fields)
        {
            if (s_Field.Name != "$" && s_Field.TypeKey != null)
                AddType(s_Field.TypeKey);
        }
    }

    private void AddTypeStrings(string p_Key)
    {
        if (!m_TypeStringVisited.Add(p_Key))
            return;

        var s_Layout = Layout(p_Key);
        var s_Base = s_Layout.Fields.FirstOrDefault(p_F => p_F.Name == "$");
        if (s_Base?.TypeKey != null)
            AddTypeStrings(s_Base.TypeKey);

        AddTypeString(s_Layout.Name);
        foreach (var s_Field in s_Layout.Fields)
        {
            if (s_Field.Name != "$" && s_Field.TypeKey != null)
                AddTypeStrings(s_Field.TypeKey);
            AddTypeString(s_Field.Name);
        }
    }

    private void AddTypeString(string p_String)
    {
        if (m_TypeStringSet.Add(p_String))
            m_TypeStrings.Add(p_String);
    }

    /// <summary>Writes an object's fields at <paramref name="p_Base"/> plus each field's offset.</summary>
    private void WriteObject(RimeWriter p_Writer, long p_Base, EbxTypeLayout p_Layout, object p_Object)
    {
        foreach (var s_Field in p_Layout.Fields)
        {
            if (s_Field.Name == "$")
            {
                if (s_Field.TypeKey != null)
                    WriteObject(p_Writer, p_Base, Layout(s_Field.TypeKey), p_Object);
                continue;
            }

            var s_Property = p_Object.GetType().GetProperty(s_Field.Name);
            if (s_Property == null)
                continue;

            var s_Value = s_Property.GetValue(p_Object);
            var s_Position = p_Base + s_Field.Offset;
            switch (s_Field.Code)
            {
                case FieldType.ValueType:
                    if (s_Value != null)
                        WriteObject(p_Writer, s_Position, Layout(s_Field.TypeKey!), s_Value);
                    break;
                case FieldType.Array:
                    var s_Index = WriteArray(s_Field.TypeKey!, s_Value as IEnumerable);
                    p_Writer.Seek(s_Position, SeekOrigin.Begin);
                    p_Writer.Write(s_Index);
                    break;
                default:
                    p_Writer.Seek(s_Position, SeekOrigin.Begin);
                    WriteValue(p_Writer, s_Field.Code, s_Field.TypeKey, s_Value, false);
                    break;
            }
        }
    }

    /// <summary>
    /// Writes an array's elements, then the array: arrays inside the elements come first, so an
    /// array is numbered after the arrays it holds. The count sits right before the data.
    /// </summary>
    private uint WriteArray(string p_Key, IEnumerable? p_Values)
    {
        if (m_Arrays.Count > 0 && m_Arrays[0].TypeKey == "")
            m_Arrays[0] = (0, 0, p_Key);

        var s_Values = p_Values?.Cast<object?>().ToList() ?? new List<object?>();
        if (s_Values.Count == 0)
            return 0;

        var s_Member = Layout(p_Key).Fields[0];
        var (s_Size, s_Alignment) = ElementSize(s_Member);
        var s_Data = NewWriter();
        s_Data.WriteNullBytes((uint)(s_Values.Count * s_Size));
        for (var i = 0; i < s_Values.Count; ++i)
        {
            if (s_Member.Code == FieldType.ValueType)
            {
                if (s_Values[i] != null)
                    WriteObject(s_Data, (long)i * s_Size, Layout(s_Member.TypeKey!), s_Values[i]!);
            }
            else
            {
                s_Data.Seek((long)i * s_Size, SeekOrigin.Begin);
                WriteValue(s_Data, s_Member.Code, s_Member.TypeKey, s_Values[i], true);
            }
        }

        // The count is 4-aligned and sits right before the data, which is aligned for its elements.
        m_ArrayData.Align(4);
        while ((m_ArrayData.Position + 4) % s_Alignment != 0)
            m_ArrayData.Write((byte)0);
        m_ArrayData.Write((uint)s_Values.Count);
        var s_Offset = (uint)m_ArrayData.Position;
        m_ArrayData.Write(s_Data);

        m_Arrays.Add((s_Offset, (uint)s_Values.Count, p_Key));
        return (uint)(m_Arrays.Count - 1);
    }

    private (int Size, int Alignment) ElementSize(EbxFieldLayout p_Member)
    {
        if (p_Member.Code == FieldType.ValueType)
        {
            var s_Struct = Layout(p_Member.TypeKey!);
            return (s_Struct.Size, s_Struct.Alignment);
        }

        return p_Member.Code switch
        {
            FieldType.Boolean or FieldType.Int8 or FieldType.UInt8 => (1, 1),
            FieldType.Int16 or FieldType.UInt16 => (2, 2),
            FieldType.Int64 or FieldType.UInt64 or FieldType.Float64 or FieldType.ResourceRef => (8, 8),
            FieldType.Guid => (16, 4),
            FieldType.Sha1 => (20, 4),
            _ => (4, 4),
        };
    }

    private void WriteValue(RimeWriter p_Writer, FieldType p_Code, string? p_TypeKey, object? p_Value, bool p_InArray)
    {
        switch (p_Code)
        {
            case FieldType.Class:
                p_Writer.Write(Reference(p_Value as CtrRefBase));
                break;
            case FieldType.Enum:
                p_Writer.Write(EnumValue(p_TypeKey, p_Value, p_InArray));
                break;
            case FieldType.CString:
            case FieldType.FileRef:
                p_Writer.Write(StringOffset(p_Value as string));
                break;
            case FieldType.Boolean:
                p_Writer.Write(p_Value is true);
                break;
            case FieldType.Int8:
                p_Writer.Write(Convert.ToSByte(p_Value));
                break;
            case FieldType.UInt8:
                p_Writer.Write(Convert.ToByte(p_Value));
                break;
            case FieldType.Int16:
                p_Writer.Write(Convert.ToInt16(p_Value));
                break;
            case FieldType.UInt16:
                p_Writer.Write(Convert.ToUInt16(p_Value));
                break;
            case FieldType.Int32:
                p_Writer.Write(Convert.ToInt32(p_Value));
                break;
            case FieldType.UInt32:
                p_Writer.Write(Convert.ToUInt32(p_Value));
                break;
            case FieldType.Int64:
                p_Writer.Write(Convert.ToInt64(p_Value));
                break;
            case FieldType.UInt64:
                p_Writer.Write(Convert.ToUInt64(p_Value));
                break;
            case FieldType.Float32:
                p_Writer.Write(Convert.ToSingle(p_Value));
                break;
            case FieldType.Float64:
                p_Writer.Write(Convert.ToDouble(p_Value));
                break;
            case FieldType.Guid:
                ((p_Value as GUID) ?? GUID.Empty).Serialize(p_Writer);
                break;
            case FieldType.Sha1:
                (p_Value as Sha1)?.Serialize(p_Writer);
                break;
            case FieldType.ResourceRef:
                (p_Value as ResourceRef ?? new ResourceRef()).Serialize(p_Writer);
                break;
            default:
                throw new NotSupportedException($"Writing fields of type {p_Code} is not supported.");
        }
    }

    private uint Reference(CtrRefBase? p_Ref)
    {
        if (p_Ref == null || p_Ref.IsNull())
            return 0;

        if (p_Ref.PartitionGuid.Equals(m_Partition.PartitionGuid) && m_InstanceIndices.TryGetValue(p_Ref.InstanceId, out var s_Index))
            return (uint)(s_Index + 1);

        if (p_Ref.InstanceId is not DataContainerId.Guid s_Instance)
            throw new InvalidOperationException($"Reference to {p_Ref.PartitionGuid}/{p_Ref.InstanceId} is neither in this partition nor importable.");

        var s_Key = (new Guid(p_Ref.PartitionGuid.Id), new Guid(s_Instance.Id.Id));
        if (!m_ImportIndices.TryGetValue(s_Key, out var s_Import))
        {
            s_Import = m_Imports.Count;
            m_ImportIndices[s_Key] = s_Import;
            m_Imports.Add((p_Ref.PartitionGuid, s_Instance.Id));
        }

        return 0x80000000u | (uint)s_Import;
    }

    private static int EnumValue(string? p_TypeKey, object? p_Value, bool p_InArray)
    {
        if (p_Value == null)
            return 0;

        // In arrays the value is stored as is; in fields as the descriptor's value for its name.
        if (!p_InArray && p_TypeKey != null && EbxLayoutLibrary.TryGet(p_TypeKey, out var s_Enum))
        {
            var s_Name = p_Value.ToString();
            var s_Field = s_Enum.Fields.FirstOrDefault(p_F => p_F.Name == s_Name);
            if (s_Field != null)
                return s_Field.Offset;
        }

        return Convert.ToInt32(p_Value);
    }

    private uint StringOffset(string? p_String)
    {
        if (string.IsNullOrEmpty(p_String))
            return 0xFFFFFFFF;

        if (m_StringOffsets.TryGetValue(p_String, out var s_Offset))
            return s_Offset;

        // Byte for byte, the way the reader reads them (some are not UTF-8 text).
        s_Offset = (uint)m_Strings.Position;
        m_Strings.Write(Encoding.Latin1.GetBytes(p_String));
        m_Strings.Write((byte)0);
        m_StringOffsets[p_String] = s_Offset;
        return s_Offset;
    }
}
