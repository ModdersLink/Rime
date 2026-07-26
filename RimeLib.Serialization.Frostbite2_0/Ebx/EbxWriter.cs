using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using fb;
using RimeLib.Frostbite.Core;
using RimeLib.IO;
using RimeLib.Serialization.Attributes;
using RimeLib.Serialization.Frostbite2_0.Extensions;
using RimeLib.Utils;

namespace RimeLib.Serialization.Frostbite2_0.Ebx;

/// <summary>
/// Byte-faithful EBX writer (2026-07 "fidelity" rewrite).
///
/// The engine memory-maps EBX payloads against its compiled type layouts, so a generated partition
/// must reproduce DICE's serialization rules EXACTLY or the engine consumes it as silent garbage
/// (while reflection-based readers, which use the file's own descriptors symmetrically, still read
/// it fine). Rules replicated here, all byte-verified against vanilla BF3 partitions:
///
///  1. Instances keep their original order (partition InstanceMap is insertion-ordered); instance
///     entries group by type in first-appearance order.
///  2. Type descriptors: base types first, then the type itself, THEN its field types are resolved
///     per field in declaration order (each field: resolve/create its type fully, then register the
///     field's name string) - this also reproduces DICE's type-string table order.
///  3. A type's field-descriptor block ($ inheritance row + declared fields) is reserved contiguously
///     when the type descriptor is allocated; nested type creation appends after the block.
///  4. All arrays-of-references share ONE "array of class" descriptor; struct/enum/primitive arrays
///     are shared per element type.
///  5. Array entries and payload are emitted in post-order DFS (children fully emitted before their
///     containing array), each non-empty array's data is preceded by a u32 element-count prefix
///     (entry offsets point past it), and ALL empty arrays share a single sentinel entry at index 0
///     (offset 0, count 0) which exists only if at least one empty array does.
///  6. Field descriptor SecondaryOffset and the exact flag bits come from the fidelity map
///     (fidelity_fb2.json, mined from vanilla EBX) when available - they are not derivable from the
///     C# SDK attributes.
/// </summary>
public class EbxWriter : IEbxWriter
{
    /// <summary>
    /// RimeWriter that notifies the owning EbxWriter before every write. Used to capture, for each
    /// GetArrayWriter call, WHERE the caller wrote the array index (the generated SDK serializers
    /// always write it as the very next write after GetArrayWriter returns) - giving both the array
    /// parent/child tree and the exact patch position, so final post-order indices can be fixed up
    /// after serialization.
    /// </summary>
    private sealed class TrackedWriter : RimeWriter
    {
        private readonly EbxWriter m_Owner;
        public readonly int ArrayId; // -1 = the instance payload writer

        public TrackedWriter(EbxWriter p_Owner, int p_ArrayId)
            : base(new MemoryStream())
        {
            m_Owner = p_Owner;
            ArrayId = p_ArrayId;
        }

        protected override void WriteInternal(byte[] p_Bytes, int p_Offset, int p_Length)
        {
            m_Owner.OnTrackedWrite(this, p_Length);
            base.WriteInternal(p_Bytes, p_Offset, p_Length);
        }
    }

    private sealed class PendingArray
    {
        public int Id;
        public TrackedWriter Writer = null!;   // element data buffer
        public int ElementCount;
        public uint TypeDescriptorIndex;
        public List<int> Children = new();     // nested arrays, in discovery order
        public TrackedWriter? IndexWriter;     // the buffer holding this array's u32 index
        public long IndexPosition = -1;
        public uint FinalIndex;
    }

    private readonly TrackedWriter m_PayloadWriter;
    private readonly RimeWriter m_TypeStringWriter = new(new MemoryStream());
    private readonly RimeWriter m_StringWriter = new(new MemoryStream());
    private readonly RimeWriter m_ArrayPayloadWriter = new(new MemoryStream());
    private readonly RimeWriter m_MetaWriter = new(new MemoryStream());

    private readonly List<ImportEntry> m_ImportEntries = new();
    private readonly Dictionary<(GUID, GUID), int> m_ImportIndices = new();
    private readonly List<FieldDescriptor> m_FieldDescriptors = new();
    private readonly List<TypeDescriptor> m_TypeDescriptors = new();
    private readonly List<InstanceEntry> m_InstanceEntries = new();
    private readonly List<ArrayEntry> m_ArrayEntries = new();

    private readonly Dictionary<GUID, uint> m_InternalInstanceGuids = new();
    private readonly Dictionary<string, uint> m_StringIndices = new();
    private readonly Dictionary<string, uint> m_TypeStringHashes = new();
    private readonly Dictionary<string, uint> m_TypeIndices = new();

    private readonly List<PendingArray> m_Arrays = new();
    private readonly List<int> m_RootArrays = new();
    private PendingArray? m_PendingIndexCapture;

    private DatabasePartition m_Partition = new();

    public EbxWriter()
    {
        m_PayloadWriter = new TrackedWriter(this, -1);
    }

    public void Serialize(RimeWriter p_Writer, DatabasePartition p_Partition)
    {
        m_Partition = p_Partition;

        // Group instances by type in FIRST-APPEARANCE order, preserving in-group order (this equals
        // the original DICE layout for unmodified partitions, since their instances are contiguous
        // per type; instances of already-seen types appended later join their group's end).
        var s_Groups = new List<(Type Type, List<KeyValuePair<GUID, DataContainer>> Items)>();
        var s_GroupIndices = new Dictionary<Type, int>();

        foreach (var s_Pair in p_Partition.InstanceMap)
        {
            var s_Type = s_Pair.Value.GetType();

            if (!s_GroupIndices.TryGetValue(s_Type, out var s_GroupIndex))
            {
                s_GroupIndex = s_Groups.Count;
                s_GroupIndices.Add(s_Type, s_GroupIndex);
                s_Groups.Add((s_Type, new List<KeyValuePair<GUID, DataContainer>>()));
            }

            s_Groups[s_GroupIndex].Items.Add(s_Pair);
        }

        // Internal instance indices follow the grouped payload order.
        var s_InstanceIndex = 0u;

        foreach (var (_, s_Items) in s_Groups)
        foreach (var (s_InstanceGuid, _) in s_Items)
            m_InternalInstanceGuids.Add(s_InstanceGuid, s_InstanceIndex++);

        foreach (var (s_Type, s_Items) in s_Groups)
        {
            var s_InstanceEntry = new InstanceEntry()
            {
                InternalCount = 0,
                ExportCount = 0,
                TypeDescriptorIndex = WriteTypeDescriptor(s_Type),
            };

            foreach (var (s_InstanceGuid, s_Instance) in s_Items)
            {
                ++s_InstanceEntry.ExportCount;
                s_InstanceGuid.Serialize(m_PayloadWriter);
                s_Instance.Serialize(m_PayloadWriter, this);
            }

            m_InstanceEntries.Add(s_InstanceEntry);
        }

        WriteFinalPartition(p_Writer);
    }

    private void OnTrackedWrite(TrackedWriter p_Writer, int p_Length)
    {
        if (m_PendingIndexCapture == null)
            return;

        var s_Array = m_PendingIndexCapture;
        m_PendingIndexCapture = null;

        if (p_Length != 4)
            throw new Exception("Expected the array index (4 bytes) to be the first write after GetArrayWriter.");

        s_Array.IndexWriter = p_Writer;
        s_Array.IndexPosition = p_Writer.Position;

        // The buffer receiving the index tells us the containing array (or the instance payload).
        if (p_Writer.ArrayId < 0)
            m_RootArrays.Add(s_Array.Id);
        else
            m_Arrays[p_Writer.ArrayId].Children.Add(s_Array.Id);
    }

    private void WriteFinalPartition(RimeWriter p_Writer)
    {
        // Emit array entries + payload the DICE way: a null/empty-array sentinel always sits at
        // entry 0 whenever the partition has any arrays (all empty array fields reference it, and
        // vanilla partitions carry it even with no empty arrays at all - e.g. emittersystem);
        // then post-order DFS with a u32 count prefix per non-empty array.
        if (m_Arrays.Count > 0)
        {
            m_ArrayEntries.Add(new ArrayEntry()
            {
                Offset = 0,
                ElementCount = 0,
                TypeDescriptorIndex = m_Arrays[0].TypeDescriptorIndex,
            });
        }

        foreach (var s_RootId in m_RootArrays)
            EmitArrayPostOrder(m_Arrays[s_RootId]);

        // Align payloads.
        m_StringWriter.Align(16);
        m_TypeStringWriter.Align(16);
        m_PayloadWriter.Align(16);
        m_ArrayPayloadWriter.Align(16);

        // Write meta first.
        foreach (var s_Entry in m_ImportEntries)
            s_Entry.Serialize(m_MetaWriter);

        m_MetaWriter.Write(m_TypeStringWriter);

        foreach (var s_Descriptor in m_FieldDescriptors)
            s_Descriptor.Serialize(m_MetaWriter);

        m_MetaWriter.Align(16);

        foreach (var s_Descriptor in m_TypeDescriptors)
            s_Descriptor.Serialize(m_MetaWriter);

        foreach (var s_Entry in m_InstanceEntries)
            s_Entry.Serialize(m_MetaWriter);

        m_MetaWriter.Align(16);

        foreach (var s_Entry in m_ArrayEntries)
            s_Entry.Serialize(m_MetaWriter);

        m_MetaWriter.Align(16);

        var s_Header = new StreamingPartitionHeader()
        {
            Magic = 0x0FB2D1CE,
            MetaSize = (uint) (StreamingPartitionHeader.SizeOf + m_MetaWriter.Position),
            PayloadSize = (uint) (m_StringWriter.Position + m_PayloadWriter.Position + m_ArrayPayloadWriter.Position),
            ImportCount = (uint) m_ImportEntries.Count,
            TypeCount = (uint) m_InstanceEntries.Count,
            TypeDescriptorCount = (uint) m_TypeDescriptors.Count,
            FieldDescriptorCount = (uint) m_FieldDescriptors.Count,
            TypeStringTableSize = (uint) m_TypeStringWriter.Position,
            StringTableSize = (uint) m_StringWriter.Position,
            ArrayCount = (uint) m_ArrayEntries.Count,
            ArrayOffset = (uint) m_PayloadWriter.Position,
            PartitionGuid = m_Partition.PartitionGuid,
            PrimaryInstanceGuid = m_Partition.PrimaryInstanceGuid,
        };

        // Write final payload.
        s_Header.Serialize(p_Writer);
        p_Writer.Write(m_MetaWriter);
        p_Writer.Write(m_StringWriter);
        p_Writer.Write(m_PayloadWriter);
        p_Writer.Write(m_ArrayPayloadWriter);
    }

    private void EmitArrayPostOrder(PendingArray p_Array)
    {
        // Children first: their data blocks precede the containing array's block, and their index
        // patches (which land inside p_Array's buffer) must happen before that buffer is copied.
        foreach (var s_ChildId in p_Array.Children)
            EmitArrayPostOrder(m_Arrays[s_ChildId]);

        if (p_Array.ElementCount > 0)
        {
            m_ArrayPayloadWriter.Write((uint) p_Array.ElementCount);   // DICE element-count prefix
            p_Array.FinalIndex = (uint) m_ArrayEntries.Count;

            var s_Offset = (uint) m_ArrayPayloadWriter.Position;
            m_ArrayPayloadWriter.Write(p_Array.Writer);

            m_ArrayEntries.Add(new ArrayEntry()
            {
                Offset = s_Offset,
                ElementCount = (uint) p_Array.ElementCount,
                TypeDescriptorIndex = p_Array.TypeDescriptorIndex,
            });
        }
        else
        {
            p_Array.FinalIndex = 0;   // the shared empty sentinel
        }

        // Patch the placeholder index the caller wrote right after GetArrayWriter.
        if (p_Array.IndexWriter != null)
        {
            var s_Current = p_Array.IndexWriter.Position;
            p_Array.IndexWriter.Seek(p_Array.IndexPosition, SeekOrigin.Begin);
            p_Array.IndexWriter.Write(p_Array.FinalIndex);
            p_Array.IndexWriter.Seek(s_Current, SeekOrigin.Begin);
        }
    }

    private static readonly Dictionary<Type, int> s_PrimitiveCodes = new()
    {
        { typeof(bool), (int) FieldType.Boolean },
        { typeof(sbyte), (int) FieldType.Int8 },
        { typeof(byte), (int) FieldType.UInt8 },
        { typeof(short), (int) FieldType.Int16 },
        { typeof(ushort), (int) FieldType.UInt16 },
        { typeof(int), (int) FieldType.Int32 },
        { typeof(uint), (int) FieldType.UInt32 },
        { typeof(long), (int) FieldType.Int64 },
        { typeof(ulong), (int) FieldType.UInt64 },
        { typeof(float), (int) FieldType.Float32 },
        { typeof(double), (int) FieldType.Float64 },
        { typeof(string), (int) FieldType.CString },
        { typeof(GUID), (int) FieldType.Guid },
    };

    private void ApplyPrimitiveFieldFlags(FieldDescriptor p_Descriptor, Type p_PrimitiveType)
    {
        p_Descriptor.Flags.SetIsPrimitive(false, p_PrimitiveType);

        // Vanilla primitive fields carry type-intrinsic upper flag bits (Blittable/LayoutImmutable...)
        // the reflection model doesn't know; take the exact bits from the fidelity map.
        if (s_PrimitiveCodes.TryGetValue(p_PrimitiveType, out var s_Code) &&
            EbxFidelity.GetPrimitiveFlags(s_Code) is { } s_Flags)
        {
            p_Descriptor.Flags.SetFromFlagBits(s_Flags);
        }
    }

    private void ApplyTypeFlags(MemberInfoFlags p_Flags, IEnumerable<Attribute> p_Attributes)
    {
        if (p_Attributes.Any((p_Attr) => p_Attr is HomogeneousAttribute))
            p_Flags.SetHomogenous();

        if (p_Attributes.Any((p_Attr) => p_Attr is LayoutImmutableAttribute))
            p_Flags.SetLayoutImmutable();

        if (p_Attributes.Any((p_Attr) => p_Attr is BlittableAttribute))
            p_Flags.SetBlittable();
    }

    private uint WriteArrayDescriptor(Type p_Type)
    {
        var s_ElementType = p_Type.GetGenericArguments()[0];

        // DICE shares array descriptors: ALL reference arrays collapse into a single "array of
        // class" descriptor; value-type/enum/primitive arrays are shared per element type.
        string s_Key;

        if (typeof(DataContainer).IsAssignableFrom(s_ElementType) || typeof(CtrRefBase).IsAssignableFrom(s_ElementType))
            s_Key = "array:class";
        else if (typeof(EbxSerializable).IsAssignableFrom(s_ElementType))
            s_Key = "array:struct:" + s_ElementType.Name;
        else if (s_ElementType.IsEnum)
            s_Key = "array:enum:" + s_ElementType.Name;
        else
            s_Key = "array:prim:" + (s_PrimitiveCodes.TryGetValue(s_ElementType, out var s_Code) ? s_Code : -1);

        if (m_TypeIndices.TryGetValue(s_Key, out var s_ExistingIndex))
            return s_ExistingIndex;

        var s_Descriptor = new TypeDescriptor()
        {
            NameHash = WriteTypeString("array"),
            LayoutDescriptor = (uint) m_FieldDescriptors.Count,
            Alignment = 4,
            FieldCount = 1,
            Size = 4,
            SecondarySize = 0,
        };

        s_Descriptor.Flags.SetIsArray(false);

        var s_TypeIndex = (uint) m_TypeDescriptors.Count;
        m_TypeDescriptors.Add(s_Descriptor);
        m_TypeIndices.Add(s_Key, s_TypeIndex);

        var s_FieldDescriptor = new FieldDescriptor()
        {
            FieldType = 0,
            Offset = 0,
            SecondaryOffset = 0,
        };

        m_FieldDescriptors.Add(s_FieldDescriptor);

        if (typeof(DataContainer).IsAssignableFrom(s_ElementType) || typeof(CtrRefBase).IsAssignableFrom(s_ElementType))
        {
            s_FieldDescriptor.Flags.SetIsClass(false);
        }
        else if (typeof(EbxSerializable).IsAssignableFrom(s_ElementType))
        {
            s_FieldDescriptor.Flags.SetIsValueType(false);
            s_FieldDescriptor.FieldType = (ushort) WriteTypeDescriptor(s_ElementType);
        }
        else if (s_ElementType.IsEnum)
        {
            s_FieldDescriptor.Flags.SetIsPrimitive(false, s_ElementType);
            s_FieldDescriptor.FieldType = (ushort) WriteTypeDescriptor(s_ElementType);
        }
        else
        {
            ApplyPrimitiveFieldFlags(s_FieldDescriptor, s_ElementType);
        }

        // DICE registers the member field's name AFTER resolving the element type, same as regular
        // fields (byte-proven by the emittersystem type-string order: "...MinUv MaxUv member...").
        s_FieldDescriptor.NameHash = WriteTypeString("member");

        // Exact member flags from the fidelity map when available (e.g. vanilla uint members carry
        // 0xC000 upper bits).
        if (EbxFidelity.GetArrayMemberFlags(s_Key.Substring("array:".Length)) is { } s_MemberFlags)
            s_FieldDescriptor.Flags.SetFromFlagBits(s_MemberFlags);

        return s_TypeIndex;
    }

    private uint WriteEnumDescriptor(Type p_Type)
    {
        var s_EnumNames = Enum.GetNames(p_Type);

        var s_Descriptor = new TypeDescriptor()
        {
            NameHash = WriteTypeString(p_Type.Name),
            LayoutDescriptor = (uint) m_FieldDescriptors.Count,
            Alignment = 4,
            FieldCount = (byte) s_EnumNames.Length,
            Size = 4,
            SecondarySize = 0,
        };

        s_Descriptor.Flags.SetIsPrimitive(false, p_Type);

        if (EbxFidelity.GetType(p_Type.Name) is { } s_Fidelity)
            s_Descriptor.Flags.SetFromFlagBits(s_Fidelity.Flags);

        foreach (var s_Name in s_EnumNames)
        {
            var s_Value = (int) Enum.Parse(p_Type, s_Name);

            var s_FieldDescriptor = new FieldDescriptor()
            {
                NameHash = WriteTypeString(s_Name),
                FieldType = 0,
                Offset = s_Value,
                SecondaryOffset = s_Value,
            };

            m_FieldDescriptors.Add(s_FieldDescriptor);
        }

        var s_TypeIndex = m_TypeDescriptors.Count;
        m_TypeDescriptors.Add(s_Descriptor);

        m_TypeIndices.Add(p_Type.FullName!, (uint) s_TypeIndex);

        return (uint) s_TypeIndex;
    }

    private uint WriteTypeDescriptor(Type p_Type)
    {
        if (m_TypeDescriptors.Count >= ushort.MaxValue)
            throw new Exception($"Too many different types in this partition. Max supported count is {ushort.MaxValue}.");

        // If this is a generic type then we're dealing with an array (shared-key dedupe inside).
        if (p_Type.IsGenericType)
            return WriteArrayDescriptor(p_Type);

        if (m_TypeIndices.TryGetValue(p_Type.FullName!, out var s_ExistingIndex))
            return s_ExistingIndex;

        if (p_Type.IsEnum)
            return WriteEnumDescriptor(p_Type);

        var s_ContainerTypeAttr = p_Type.GetCustomAttribute<ContainerTypeAttribute>();

        if (s_ContainerTypeAttr == null)
            throw new Exception("Tried serializing an instance without a ContainerType attribute.");

        // DICE order: base types are fully emitted first...
        uint? s_BaseTypeIndex = null;

        if (p_Type.BaseType != null && (p_Type.BaseType != typeof(EbxSerializable) && p_Type.BaseType != typeof(DataContainerBase)))
            s_BaseTypeIndex = WriteTypeDescriptor(p_Type.BaseType);

        var s_Properties = p_Type
            .GetProperties(BindingFlags.Public | BindingFlags.DeclaredOnly | BindingFlags.Instance)
            .Select((p_Property) => (Property: p_Property, Field: p_Property.GetCustomAttribute<ContainerFieldAttribute>()))
            .Where((p_Pair) => p_Pair.Field != null)
            .ToList();

        var s_TypeFidelity = EbxFidelity.GetType(p_Type.Name);

        // ...then the type itself is allocated...
        var s_Descriptor = new TypeDescriptor()
        {
            NameHash = WriteTypeString(p_Type.Name),
            LayoutDescriptor = (uint) m_FieldDescriptors.Count,
            FieldCount = (byte) ((s_BaseTypeIndex != null ? 1 : 0) + s_Properties.Count),
            Alignment = s_TypeFidelity?.Alignment ?? s_ContainerTypeAttr.DataAlignment,
            Size = s_TypeFidelity?.Size ?? s_ContainerTypeAttr.Size,
            SecondarySize = s_TypeFidelity?.SecondarySize ?? 0,
        };

        if (typeof(DataContainer).IsAssignableFrom(p_Type))
            s_Descriptor.Flags.SetIsClass(false);
        else
            s_Descriptor.Flags.SetIsValueType(false);

        ApplyTypeFlags(s_Descriptor.Flags, p_Type.GetCustomAttributes());

        if (s_TypeFidelity != null)
            s_Descriptor.Flags.SetFromFlagBits(s_TypeFidelity.Flags);

        var s_Index = (uint) m_TypeDescriptors.Count;
        m_TypeDescriptors.Add(s_Descriptor);
        m_TypeIndices.Add(p_Type.FullName!, s_Index);

        // ...then its field-descriptor block is reserved contiguously ($ inheritance row first)...
        if (s_BaseTypeIndex != null)
        {
            var s_InheritanceDescriptor = new FieldDescriptor()
            {
                NameHash = WriteTypeString("$"),
                FieldType = (ushort) s_BaseTypeIndex,
                Offset = 0,
                SecondaryOffset = 0,
            };

            s_InheritanceDescriptor.Flags.SetIsVoid();

            m_FieldDescriptors.Add(s_InheritanceDescriptor);
        }

        var s_FieldRows = new List<FieldDescriptor>(s_Properties.Count);

        foreach (var _ in s_Properties)
        {
            var s_Row = new FieldDescriptor();
            s_FieldRows.Add(s_Row);
            m_FieldDescriptors.Add(s_Row);
        }

        // ...then each field is processed IN ORDER: its type is resolved/created first (appending
        // any new descriptors after this block), and only then is the field's name registered -
        // this exact sequence reproduces DICE's type-string table.
        for (var i = 0; i < s_Properties.Count; ++i)
        {
            var (s_Property, s_ContainerField) = s_Properties[i];
            var s_FieldDescriptor = s_FieldRows[i];

            if (typeof(CtrRefBase).IsAssignableFrom(s_Property.PropertyType))
            {
                s_FieldDescriptor.Flags.SetIsClass(false);
            }
            else if (typeof(EbxSerializable).IsAssignableFrom(s_Property.PropertyType))
            {
                s_FieldDescriptor.FieldType = (ushort) WriteTypeDescriptor(s_Property.PropertyType);
                // Vanilla struct fields carry their struct type's exact flag bits (e.g. Vec3 0xD029).
                s_FieldDescriptor.Flags.SetFromFlagBits(m_TypeDescriptors[s_FieldDescriptor.FieldType].Flags.ToFlagBits());
            }
            else if (s_Property.PropertyType.IsGenericType)
            {
                s_FieldDescriptor.Flags.SetIsArray(false);
                s_FieldDescriptor.FieldType = (ushort) WriteTypeDescriptor(s_Property.PropertyType);
            }
            else if (s_Property.PropertyType.IsEnum)
            {
                s_FieldDescriptor.FieldType = (ushort) WriteTypeDescriptor(s_Property.PropertyType);
                s_FieldDescriptor.Flags.SetFromFlagBits(m_TypeDescriptors[s_FieldDescriptor.FieldType].Flags.ToFlagBits());
            }
            else
            {
                ApplyPrimitiveFieldFlags(s_FieldDescriptor, s_Property.PropertyType);
            }

            s_FieldDescriptor.NameHash = WriteTypeString(s_ContainerField!.Name);
            s_FieldDescriptor.Offset = (int) s_ContainerField.Offset;

            ApplyTypeFlags(s_FieldDescriptor.Flags, s_Property.GetCustomAttributes());

            // Exact flags + SecondaryOffset from the fidelity map (not derivable via reflection).
            if (EbxFidelity.GetField(p_Type.Name, s_ContainerField.Name) is { } s_FieldFidelity)
            {
                s_FieldDescriptor.Flags.SetFromFlagBits(s_FieldFidelity.Flags);
                s_FieldDescriptor.SecondaryOffset = s_FieldFidelity.SecondaryOffset;

                if (s_FieldFidelity.Offset != s_FieldDescriptor.Offset)
                    Console.WriteLine($"EBX fidelity: offset mismatch for {p_Type.Name}.{s_ContainerField.Name} (SDK {s_FieldDescriptor.Offset} vs game {s_FieldFidelity.Offset}) - keeping the SDK layout.");
            }
        }

        return s_Index;
    }

    private uint WriteTypeString(string p_String)
    {
        if (m_TypeStringHashes.TryGetValue(p_String, out var s_Hash))
            return s_Hash;

        m_TypeStringWriter.Write(Encoding.UTF8.GetBytes(p_String));
        m_TypeStringWriter.WriteByte(0);

        s_Hash = Frostbite.Utils.HashQuick(p_String);
        m_TypeStringHashes.Add(p_String, s_Hash);

        return s_Hash;
    }

    public uint WriteImport(CtrRefBase p_CtrRef)
    {
        if (p_CtrRef.IsNull())
            return 0;

        if (p_CtrRef.InstanceId is not DataContainerId.Guid s_InstanceId)
        {
            throw new Exception($"This version of the Frostbite engine does not support index-based DataContainer ids.");
        }

        if (p_CtrRef.PartitionGuid == m_Partition.PartitionGuid)
        {
            if (m_InternalInstanceGuids.TryGetValue(s_InstanceId.Id, out var s_Index))
                return s_Index + 1;

            throw new Exception($"Found internal reference to instance '{p_CtrRef.InstanceId}', but this instance doesn't exist in this partition.");
        }

        // See if we already have an entry for this import.
        if (!m_ImportIndices.TryGetValue((p_CtrRef.PartitionGuid, s_InstanceId.Id), out var s_ImportIndex))
        {
            // Import not found, create one.
            s_ImportIndex = m_ImportEntries.Count;

            m_ImportEntries.Add(new ImportEntry()
            {
                InstanceGuid = s_InstanceId.Id,
                PartitionGuid = p_CtrRef.PartitionGuid,
            });

            m_ImportIndices.Add((p_CtrRef.PartitionGuid, s_InstanceId.Id), s_ImportIndex);
        }

        return (uint) s_ImportIndex | 0x80000000u;
    }

    public uint WriteString(string p_String)
    {
        if (m_StringIndices.TryGetValue(p_String, out var s_Offset))
            return s_Offset;

        var s_StringOffset = m_StringWriter.Position;

        m_StringWriter.Write(Encoding.UTF8.GetBytes(p_String));
        m_StringWriter.WriteByte(0);

        m_StringIndices.Add(p_String, (uint) s_StringOffset);

        return (uint) s_StringOffset;
    }

    public (RimeWriter, uint) GetArrayWriter(Type p_ArrayType, int p_ElementCount)
    {
        var s_Array = new PendingArray()
        {
            Id = m_Arrays.Count,
            ElementCount = p_ElementCount,
            TypeDescriptorIndex = WriteTypeDescriptor(p_ArrayType),
        };

        s_Array.Writer = new TrackedWriter(this, s_Array.Id);
        m_Arrays.Add(s_Array);

        // The caller writes the returned index as its very next write; we capture where it lands
        // (parent buffer + position) and patch the real post-order index during finalization.
        m_PendingIndexCapture = s_Array;

        return (s_Array.Writer, 0u);
    }

    public void Dispose()
    {
        m_PayloadWriter.Dispose();
        m_TypeStringWriter.Dispose();
        m_StringWriter.Dispose();
        m_ArrayPayloadWriter.Dispose();
        m_MetaWriter.Dispose();

        foreach (var s_Array in m_Arrays)
            s_Array.Writer.Dispose();

        m_Arrays.Clear();
    }
}
