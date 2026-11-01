using System;
using System.Buffers.Binary;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using RimeLib.Frostbite.Core;

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

    private readonly MemoryStream m_Strings = new();
    private readonly Dictionary<string, uint> m_StringOffsets = new();

    private readonly List<(uint Offset, uint Count, string TypeKey)> m_Arrays = new();
    private readonly MemoryStream m_ArrayData = new();

    private readonly Dictionary<DataContainerId, int> m_InstanceIndices = new();
    private DatabasePartition m_Partition = new();

    public byte[] Write(DatabasePartition p_Partition)
    {
        m_Partition = p_Partition;

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
        var s_Payload = new MemoryStream();
        foreach (var (s_Key, s_Exported, s_RangeInstances) in s_Ranges)
        {
            var s_Layout = Layout(s_Key);
            Pad(s_Payload, s_Layout.Alignment);

            foreach (var s_Instance in s_RangeInstances)
            {
                if (s_Exported)
                    s_Payload.Write(((DataContainerId.Guid)s_Instance.InstanceId).Id.Id);

                var s_Buffer = new byte[s_Layout.Size];
                WriteObject(s_Buffer, 0, s_Layout, s_Instance);

                // Types aligned to 4 start 8 bytes before their data: the GUID covers them.
                var s_Shift = s_Layout.Alignment == 4 ? 8 : 0;
                s_Payload.Write(s_Buffer, s_Shift, s_Buffer.Length - s_Shift);
            }
        }
        // The instances are followed by at least 4 bytes of padding up to the next 16.
        s_Payload.Write(new byte[4]);
        Pad(s_Payload, 16);
        var s_ArrayOffset = (uint)s_Payload.Length;

        Pad(m_ArrayData, 16);
        s_Payload.Write(m_ArrayData.ToArray());
        Pad(m_Strings, 16);

        // Metadata.
        var s_Meta = new MemoryStream();
        s_Meta.Write(new byte[56]);
        Pad(s_Meta, 16);

        foreach (var (s_Partition, s_Instance) in m_Imports)
        {
            s_Meta.Write(s_Partition.Id);
            s_Meta.Write(s_Instance.Id);
        }

        var s_TypeStringStart = s_Meta.Length;
        foreach (var s_String in m_TypeStrings)
        {
            s_Meta.Write(Encoding.UTF8.GetBytes(s_String));
            s_Meta.WriteByte(0);
        }
        Pad(s_Meta, 16);
        var s_TypeStringSize = s_Meta.Length - s_TypeStringStart;

        var s_FieldIndex = 0;
        var s_FieldStarts = new List<int>();
        foreach (var s_Type in m_Types)
        {
            s_FieldStarts.Add(s_FieldIndex);
            foreach (var s_Field in s_Type.Fields)
            {
                WriteUInt32(s_Meta, s_Field.NameHash);
                WriteUInt16(s_Meta, s_Field.Flags);
                WriteUInt16(s_Meta, (ushort)(s_Field.TypeKey != null ? m_TypeIndices[s_Field.TypeKey] : 0));
                WriteUInt32(s_Meta, (uint)s_Field.Offset);
                WriteUInt32(s_Meta, (uint)s_Field.SecondaryOffset);
                ++s_FieldIndex;
            }
        }

        for (var i = 0; i < m_Types.Count; ++i)
        {
            var s_Type = m_Types[i];
            WriteUInt32(s_Meta, s_Type.NameHash);
            WriteUInt32(s_Meta, (uint)s_FieldStarts[i]);
            s_Meta.WriteByte((byte)s_Type.Fields.Count);
            s_Meta.WriteByte(s_Type.Alignment);
            WriteUInt16(s_Meta, s_Type.Flags);
            WriteUInt16(s_Meta, s_Type.Size);
            WriteUInt16(s_Meta, s_Type.SecondarySize);
        }

        foreach (var (s_Key, _, s_RangeInstances) in s_Ranges)
        {
            WriteUInt16(s_Meta, (ushort)m_TypeIndices[s_Key]);
            WriteUInt16(s_Meta, (ushort)s_RangeInstances.Count);
        }
        Pad(s_Meta, 16);

        foreach (var (s_Offset, s_Count, s_TypeKey) in m_Arrays)
        {
            WriteUInt32(s_Meta, s_Offset);
            WriteUInt32(s_Meta, s_Count);
            WriteUInt32(s_Meta, (uint)m_TypeIndices[s_TypeKey]);
        }
        Pad(s_Meta, 16);

        var s_MetaSize = (uint)s_Meta.Length;
        var s_Header = new MemoryStream();
        WriteUInt32(s_Header, c_Magic);
        WriteUInt32(s_Header, s_MetaSize);
        WriteUInt32(s_Header, (uint)(m_Strings.Length + s_Payload.Length));
        WriteUInt32(s_Header, (uint)m_Imports.Count);
        WriteUInt16(s_Header, (ushort)s_Ranges.Count);
        WriteUInt16(s_Header, (ushort)s_Ranges.Count(p_R => p_R.Exported));
        WriteUInt16(s_Header, (ushort)s_Ranges.Select(p_R => p_R.TypeKey).Distinct().Count());
        WriteUInt16(s_Header, (ushort)m_Types.Count);
        WriteUInt16(s_Header, (ushort)s_FieldIndex);
        WriteUInt16(s_Header, (ushort)s_TypeStringSize);
        WriteUInt32(s_Header, (uint)m_Strings.Length);
        WriteUInt32(s_Header, (uint)m_Arrays.Count);
        WriteUInt32(s_Header, s_ArrayOffset);
        s_Header.Write(p_Partition.PartitionGuid.Id);

        var s_Result = s_Meta.ToArray();
        Array.Copy(s_Header.ToArray(), s_Result, s_Header.Length);

        var s_File = new MemoryStream();
        s_File.Write(s_Result);
        s_File.Write(m_Strings.ToArray());
        s_File.Write(s_Payload.ToArray());
        return s_File.ToArray();
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

    private void WriteObject(byte[] p_Buffer, int p_Base, EbxTypeLayout p_Layout, object p_Object)
    {
        foreach (var s_Field in p_Layout.Fields)
        {
            if (s_Field.Name == "$")
            {
                if (s_Field.TypeKey != null)
                    WriteObject(p_Buffer, p_Base, Layout(s_Field.TypeKey), p_Object);
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
                {
                    var s_Struct = Layout(s_Field.TypeKey!);
                    var s_Bytes = new byte[s_Struct.Size];
                    if (s_Value != null)
                        WriteObject(s_Bytes, 0, s_Struct, s_Value);
                    Array.Copy(s_Bytes, 0, p_Buffer, s_Position, s_Bytes.Length);
                    break;
                }
                case FieldType.Array:
                    BinaryPrimitives.WriteUInt32LittleEndian(p_Buffer.AsSpan(s_Position), WriteArray(s_Field.TypeKey!, s_Value as IEnumerable));
                    break;
                default:
                    WriteValue(p_Buffer, s_Position, s_Field.Code, s_Field.TypeKey, s_Value, false);
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
        var s_Data = new byte[s_Values.Count * s_Size];
        for (var i = 0; i < s_Values.Count; ++i)
        {
            if (s_Member.Code == FieldType.ValueType)
            {
                if (s_Values[i] != null)
                    WriteObject(s_Data, i * s_Size, Layout(s_Member.TypeKey!), s_Values[i]!);
            }
            else
            {
                WriteValue(s_Data, i * s_Size, s_Member.Code, s_Member.TypeKey, s_Values[i], true);
            }
        }

        // The count is 4-aligned and sits right before the data, which is aligned for its elements.
        var s_Offset = Align(Align(m_ArrayData.Length, 4) + 4, s_Alignment);
        while (m_ArrayData.Length < s_Offset - 4)
            m_ArrayData.WriteByte(0);
        WriteUInt32(m_ArrayData, (uint)s_Values.Count);
        m_ArrayData.Write(s_Data);

        m_Arrays.Add(((uint)s_Offset, (uint)s_Values.Count, p_Key));
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

    private void WriteValue(byte[] p_Buffer, int p_Position, FieldType p_Code, string? p_TypeKey, object? p_Value, bool p_InArray)
    {
        var s_Span = p_Buffer.AsSpan(p_Position);
        switch (p_Code)
        {
            case FieldType.Class:
                BinaryPrimitives.WriteUInt32LittleEndian(s_Span, Reference(p_Value as CtrRefBase));
                break;
            case FieldType.Enum:
                BinaryPrimitives.WriteInt32LittleEndian(s_Span, EnumValue(p_TypeKey, p_Value, p_InArray));
                break;
            case FieldType.CString:
            case FieldType.FileRef:
                BinaryPrimitives.WriteUInt32LittleEndian(s_Span, StringOffset(p_Value as string));
                break;
            case FieldType.Boolean:
                p_Buffer[p_Position] = (byte)(p_Value is true ? 1 : 0);
                break;
            case FieldType.Int8:
                p_Buffer[p_Position] = (byte)Convert.ToSByte(p_Value);
                break;
            case FieldType.UInt8:
                p_Buffer[p_Position] = Convert.ToByte(p_Value);
                break;
            case FieldType.Int16:
                BinaryPrimitives.WriteInt16LittleEndian(s_Span, Convert.ToInt16(p_Value));
                break;
            case FieldType.UInt16:
                BinaryPrimitives.WriteUInt16LittleEndian(s_Span, Convert.ToUInt16(p_Value));
                break;
            case FieldType.Int32:
                BinaryPrimitives.WriteInt32LittleEndian(s_Span, Convert.ToInt32(p_Value));
                break;
            case FieldType.UInt32:
                BinaryPrimitives.WriteUInt32LittleEndian(s_Span, Convert.ToUInt32(p_Value));
                break;
            case FieldType.Int64:
                BinaryPrimitives.WriteInt64LittleEndian(s_Span, Convert.ToInt64(p_Value));
                break;
            case FieldType.UInt64:
                BinaryPrimitives.WriteUInt64LittleEndian(s_Span, Convert.ToUInt64(p_Value));
                break;
            case FieldType.Float32:
                BinaryPrimitives.WriteSingleLittleEndian(s_Span, Convert.ToSingle(p_Value));
                break;
            case FieldType.Float64:
                BinaryPrimitives.WriteDoubleLittleEndian(s_Span, Convert.ToDouble(p_Value));
                break;
            case FieldType.Guid:
                ((p_Value as GUID) ?? GUID.Empty).Id.CopyTo(s_Span);
                break;
            case FieldType.Sha1:
                if (p_Value is Sha1 s_Sha1 && s_Sha1.Serialize(out byte[]? s_ShaBytes))
                    s_ShaBytes.CopyTo(s_Span);
                break;
            case FieldType.ResourceRef:
                BinaryPrimitives.WriteUInt64LittleEndian(s_Span, (p_Value as ResourceRef)?.Id ?? 0);
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

        s_Offset = (uint)m_Strings.Length;
        m_Strings.Write(Encoding.Latin1.GetBytes(p_String));
        m_Strings.WriteByte(0);
        m_StringOffsets[p_String] = s_Offset;
        return s_Offset;
    }

    private static long Align(long p_Value, int p_Alignment) => p_Alignment <= 1 ? p_Value : (p_Value + p_Alignment - 1) / p_Alignment * p_Alignment;

    private static void Pad(Stream p_Stream, int p_Alignment)
    {
        while (p_Stream.Length % p_Alignment != 0)
            p_Stream.WriteByte(0);
    }

    private static void WriteUInt32(Stream p_Stream, uint p_Value)
    {
        Span<byte> s_Bytes = stackalloc byte[4];
        BinaryPrimitives.WriteUInt32LittleEndian(s_Bytes, p_Value);
        p_Stream.Write(s_Bytes);
    }

    private static void WriteUInt16(Stream p_Stream, ushort p_Value)
    {
        Span<byte> s_Bytes = stackalloc byte[2];
        BinaryPrimitives.WriteUInt16LittleEndian(s_Bytes, p_Value);
        p_Stream.Write(s_Bytes);
    }
}
