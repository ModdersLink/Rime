using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using RimeLib.Frostbite.Core;
using RimeLib.IO;
using RimeLib.Serialization.Attributes;
using RimeLib.Utils;

namespace RimeLib.Serialization.Frostbite2013_2.Ebx;

// public class EbxWriter : IEbxWriter
// {
//     private readonly RimeWriter m_PayloadWriter = new(new MemoryStream());
//     private readonly RimeWriter m_TypeStringWriter = new(new MemoryStream());
//     private readonly RimeWriter m_StringWriter = new(new MemoryStream());
//     private readonly RimeWriter m_ArrayPayloadWriter = new(new MemoryStream());
//     private readonly RimeWriter m_MetaWriter = new(new MemoryStream());
//
//     private readonly List<ImportEntry> m_ImportEntries = new();
//     private readonly List<FieldDescriptor> m_FieldDescriptors = new();
//     private readonly List<TypeDescriptor> m_TypeDescriptors = new();
//     private readonly List<InstanceEntry> m_InstanceEntries = new();
//     private readonly List<ArrayEntry> m_ArrayEntries = new();
//
//     private readonly Dictionary<GUID, uint> m_InternalInstanceGuids = new();
//     private readonly Dictionary<string, uint> m_StringIndices = new();
//     private readonly Dictionary<string, uint> m_TypeStringHashes = new();
//     private readonly Dictionary<string, uint> m_TypeIndices = new();
//
//     private readonly List<RimeWriter> m_ArrayWriters = new();
//
//     private DatabasePartition m_Partition = new();
//
//     public void Serialize(RimeWriter p_Writer, DatabasePartition p_Partition)
//     {
//         m_Partition = p_Partition;
//
//         // Group instances by type.
//         var s_GroupedInstances = p_Partition.InstanceMap.GroupBy((p_Pair) => p_Pair.Value.GetType());
//
//         var s_SortedInstances = new SortedDictionary<string, SortedDictionary<GUID, DataContainer>>();
//
//         foreach (var s_InstanceGroup in s_GroupedInstances)
//         {
//             var s_Group = new SortedDictionary<GUID, DataContainer>();
//
//             foreach (var (s_InstanceGuid, s_Instance) in s_InstanceGroup)
//                 s_Group.Add(s_InstanceGuid, s_Instance);
//
//             s_SortedInstances.Add(s_InstanceGroup.Key.FullName!, s_Group);
//         }
//
//         // Calculate internal instance indices.
//         // Since everything is grouped and sorted, the indices won't change while we are serializing.
//         var s_InstanceIndex = 0u;
//
//         foreach (var (_, s_Group) in s_SortedInstances)
//         foreach (var (s_InstanceGuid, _) in s_Group)
//             m_InternalInstanceGuids.Add(s_InstanceGuid, s_InstanceIndex++);
//
//         foreach (var (s_TypeName, s_Group) in s_SortedInstances)
//         {
//             var s_InstanceEntry = new InstanceEntry()
//             {
//                 InternalCount = 0,
//                 ExportCount = 0,
//                 TypeDescriptorIndex = WriteTypeDescriptor(Type.GetType(s_TypeName)!),
//             };
//
//             foreach (var (s_InstanceGuid, s_Instance) in s_Group)
//             {
//                 ++s_InstanceEntry.ExportCount;
//                 s_InstanceGuid.Serialize(m_PayloadWriter);
//                 s_Instance.Serialize(m_PayloadWriter, this);
//             }
//
//             m_InstanceEntries.Add(s_InstanceEntry);
//         }
//
//         WriteFinalPartition(p_Writer);
//     }
//
//     private void WriteFinalPartition(RimeWriter p_Writer)
//     {
//         // Write final array payload.
//         for (var i = 0; i < m_ArrayEntries.Count; ++i)
//         {
//             var s_ArrayWriter = m_ArrayWriters[i];
//             var s_ArrayEntry = m_ArrayEntries[i];
//             s_ArrayEntry.Offset = (uint) m_ArrayPayloadWriter.Position;
//             m_ArrayPayloadWriter.Write(s_ArrayWriter);
//         }
//             
//         // Align payloads.
//         m_StringWriter.Align(16);
//         m_TypeStringWriter.Align(16);
//         m_PayloadWriter.Align(16);
//         m_ArrayPayloadWriter.Align(16);
//
//         // Write meta first.
//         foreach (var s_Entry in m_ImportEntries)
//             s_Entry.Serialize(m_MetaWriter);
//
//         m_MetaWriter.Write(m_TypeStringWriter);
//
//         foreach (var s_Descriptor in m_FieldDescriptors)
//             s_Descriptor.Serialize(m_MetaWriter);
//
//         m_MetaWriter.Align(16);
//
//         foreach (var s_Descriptor in m_TypeDescriptors)
//             s_Descriptor.Serialize(m_MetaWriter);
//
//         foreach (var s_Entry in m_InstanceEntries)
//             s_Entry.Serialize(m_MetaWriter);
//
//         m_MetaWriter.Align(16);
//
//         foreach (var s_Entry in m_ArrayEntries)
//             s_Entry.Serialize(m_MetaWriter);
//
//         m_MetaWriter.Align(16);
//
//         var s_Header = new StreamingPartitionHeader()
//         {
//             Magic = 0x0FB2D1CE,
//             MetaSize = (uint) (StreamingPartitionHeader.SizeOf + m_MetaWriter.Position),
//             PayloadSize = (uint) (m_StringWriter.Position + m_PayloadWriter.Position + m_ArrayPayloadWriter.Position),
//             ImportCount = (uint) m_ImportEntries.Count,
//             TypeCount = (uint) m_InstanceEntries.Count,
//             TypeDescriptorCount = (uint) m_TypeDescriptors.Count,
//             FieldDescriptorCount = (uint) m_FieldDescriptors.Count,
//             TypeStringTableSize = (uint) m_TypeStringWriter.Position,
//             StringTableSize = (uint) m_StringWriter.Position,
//             ArrayCount = (uint) m_ArrayEntries.Count,
//             ArrayOffset = (uint) m_PayloadWriter.Position,
//             PartitionGuid = m_Partition.PartitionGuid,
//             PrimaryInstanceGuid = m_Partition.PrimaryInstanceGuid,
//         };
//
//         // Write final payload.
//         s_Header.Serialize(p_Writer);
//         p_Writer.Write(m_MetaWriter);
//         p_Writer.Write(m_StringWriter);
//         p_Writer.Write(m_PayloadWriter);
//         p_Writer.Write(m_ArrayPayloadWriter);
//     }
//
//     private uint WriteArrayDescriptor(Type p_Type)
//     {
//         var s_Descriptor = new TypeDescriptor()
//         {
//             NameHash = WriteTypeString("array"),
//             LayoutDescriptor = 0,
//             Alignment = 4,
//             FieldCount = 1,
//             Size = 4,
//             SecondarySize = 0,
//         };
//
//         s_Descriptor.Flags.SetIsArray(false);
//
//         var s_FieldDescriptor = new FieldDescriptor()
//         {
//             NameHash = WriteTypeString("member"),
//             FieldType = 0,
//             Offset = 0,
//             SecondaryOffset = 0,
//         };
//
//         var s_ElementType = p_Type.GetGenericArguments()[0];
//
//         if (typeof(DataContainer).IsAssignableFrom(s_ElementType))
//         {
//             s_FieldDescriptor.Flags.SetIsClass(false);
//         }
//         else if (typeof(EbxSerializable).IsAssignableFrom(s_ElementType))
//         {
//             s_FieldDescriptor.Flags.SetIsValueType(false);
//             s_FieldDescriptor.FieldType = (ushort)WriteTypeDescriptor(s_ElementType);
//         }
//         else if (s_ElementType.IsEnum)
//         {
//             s_FieldDescriptor.Flags.SetIsPrimitive(false, s_ElementType);
//             s_FieldDescriptor.FieldType = (ushort)WriteTypeDescriptor(s_ElementType);
//         }
//         else
//         {
//             s_FieldDescriptor.Flags.SetIsPrimitive(false, s_ElementType);
//         }
//
//         s_Descriptor.LayoutDescriptor = (uint) m_FieldDescriptors.Count;
//         m_FieldDescriptors.Add(s_FieldDescriptor);
//
//         var s_TypeIndex = m_TypeDescriptors.Count;
//         m_TypeDescriptors.Add(s_Descriptor);
//
//         m_TypeIndices.Add(p_Type.FullName!, (uint) s_TypeIndex);
//
//         return (uint) s_TypeIndex;
//     }
//
//     private uint WriteEnumDescriptor(Type p_Type)
//     {
//         var s_EnumNames = Enum.GetNames(p_Type);
//
//         var s_Descriptor = new TypeDescriptor()
//         {
//             NameHash = WriteTypeString(p_Type.Name),
//             LayoutDescriptor = (uint)m_FieldDescriptors.Count,
//             Alignment = 4,
//             FieldCount = (byte) s_EnumNames.Length,
//             Size = 4,
//             SecondarySize = 0,
//         };
//
//         s_Descriptor.Flags.SetIsPrimitive(false, p_Type);
//
//         foreach (var s_Name in s_EnumNames)
//         {
//             var s_Value = (int) Enum.Parse(p_Type, s_Name);
//
//             var s_FieldDescriptor = new FieldDescriptor()
//             {
//                 NameHash = WriteTypeString(s_Name),
//                 FieldType = 0,
//                 Offset = s_Value,
//                 SecondaryOffset = s_Value,
//             };
//
//             m_FieldDescriptors.Add(s_FieldDescriptor);
//         }
//
//         var s_TypeIndex = m_TypeDescriptors.Count;
//         m_TypeDescriptors.Add(s_Descriptor);
//
//         m_TypeIndices.Add(p_Type.FullName!, (uint)s_TypeIndex);
//
//         return (uint) s_TypeIndex;
//     }
//
//     private void ApplyTypeFlags(MemberInfoFlags p_Flags, IEnumerable<Attribute> p_Attributes)
//     {
//         if (p_Attributes.Any((p_Attr) => p_Attr is HomogeneousAttribute))
//             p_Flags.SetHomogenous();
//
//         if (p_Attributes.Any((p_Attr) => p_Attr is LayoutImmutableAttribute))
//             p_Flags.SetLayoutImmutable();
//
//         if (p_Attributes.Any((p_Attr) => p_Attr is BlittableAttribute))
//             p_Flags.SetBlittable();
//     }
//
//     private uint WriteTypeDescriptor(Type p_Type)
//     {
//         if (m_TypeDescriptors.Count >= ushort.MaxValue)
//             throw new Exception($"Too many different types in this partition. Max supported count is {ushort.MaxValue}.");
//
//         if (m_TypeIndices.TryGetValue(p_Type.FullName!, out var s_ExistingIndex))
//             return s_ExistingIndex;
//
//         // If this is a generic type then we're dealing with an array.
//         if (p_Type.IsGenericType)
//             return WriteArrayDescriptor(p_Type);
//
//         if (p_Type.IsEnum)
//             return WriteEnumDescriptor(p_Type);
//
//         var s_ContainerTypeAttr = p_Type.GetCustomAttribute<ContainerTypeAttribute>();
//
//         if (s_ContainerTypeAttr == null)
//             throw new Exception("Tried serializing an instance without a ContainerType attribute.");
//
//         uint? s_BaseTypeIndex = null;
//
//         if (p_Type.BaseType != null && (p_Type.BaseType != typeof(EbxSerializable) && p_Type.BaseType != typeof(DataContainerBase)))
//             s_BaseTypeIndex = WriteTypeDescriptor(p_Type.BaseType);
//
//         var s_Properties = p_Type.GetProperties(BindingFlags.Public | BindingFlags.DeclaredOnly | BindingFlags.Instance);
//
//         var s_Descriptor = new TypeDescriptor()
//         {
//             NameHash = WriteTypeString(p_Type.Name),
//             LayoutDescriptor = (uint) m_FieldDescriptors.Count,
//             FieldCount = 0,
//             Alignment = s_ContainerTypeAttr.DataAlignment,
//             Size = s_ContainerTypeAttr.Size,
//             SecondarySize = 0,
//         };
//
//         // Set flags.
//         if (typeof(DataContainer).IsAssignableFrom(p_Type))
//             s_Descriptor.Flags.SetIsClass(false);
//         else
//             s_Descriptor.Flags.SetIsValueType(false);
//
//         ApplyTypeFlags(s_Descriptor.Flags, p_Type.GetCustomAttributes());
//
//         // Write inheritance.
//         if (s_BaseTypeIndex != null)
//         {
//             ++s_Descriptor.FieldCount;
//
//             var s_FieldDescriptor = new FieldDescriptor()
//             {
//                 NameHash = WriteTypeString("$"),
//                 FieldType = (ushort) s_BaseTypeIndex,
//                 Offset = 0,
//                 SecondaryOffset = 0,
//             };
//
//             s_FieldDescriptor.Flags.SetIsVoid();
//                 
//             m_FieldDescriptors.Add(s_FieldDescriptor);
//         }
//
//         // We need to write field descriptors first and then we'll write their types.
//         // This is because the parser expects all the field descriptors for this type to be in the same sequence.
//         foreach (var s_Property in s_Properties)
//         {
//             var s_ContainerField = s_Property.GetCustomAttribute<ContainerFieldAttribute>();
//
//             if (s_ContainerField == null)
//                 continue;
//
//             var s_FieldDescriptor = new FieldDescriptor()
//             {
//                 NameHash = WriteTypeString(s_ContainerField.Name),
//                 FieldType = 0,
//                 Offset = (int) s_ContainerField.Offset,
//                 SecondaryOffset = 0,
//             };
//                 
//             m_FieldDescriptors.Add(s_FieldDescriptor);
//         }
//
//         foreach (var s_Property in s_Properties)
//         {
//             var s_ContainerField = s_Property.GetCustomAttribute<ContainerFieldAttribute>();
//
//             if (s_ContainerField == null)
//                 continue;
//
//             var s_FieldDescriptor = m_FieldDescriptors[(int) (s_Descriptor.LayoutDescriptor + s_Descriptor.FieldCount)];
//             ++s_Descriptor.FieldCount;
//
//             if (typeof(CtrRefBase).IsAssignableFrom(s_Property.PropertyType))
//             {
//                 s_FieldDescriptor.Flags.SetIsClass(false);
//             }
//             else if (typeof(EbxSerializable).IsAssignableFrom(s_Property.PropertyType))
//             {
//                 s_FieldDescriptor.Flags.SetIsValueType(false);
//                 s_FieldDescriptor.FieldType = (ushort)WriteTypeDescriptor(s_Property.PropertyType);
//             }
//             else if (s_Property.PropertyType.IsGenericType)
//             {
//                 s_FieldDescriptor.Flags.SetIsArray(false);
//                 s_FieldDescriptor.FieldType = (ushort)WriteTypeDescriptor(s_Property.PropertyType);
//             }
//             else if (s_Property.PropertyType.IsEnum)
//             {
//                 s_FieldDescriptor.Flags.SetIsPrimitive(false, s_Property.PropertyType);
//                 s_FieldDescriptor.FieldType = (ushort)WriteTypeDescriptor(s_Property.PropertyType);
//             }
//             else
//             {
//                 s_FieldDescriptor.Flags.SetIsPrimitive(false, s_Property.PropertyType);
//             }
//
//             ApplyTypeFlags(s_FieldDescriptor.Flags, s_Property.GetCustomAttributes());
//         }
//
//         var s_Index = m_TypeDescriptors.Count;
//         m_TypeDescriptors.Add(s_Descriptor);
//
//         m_TypeIndices.Add(p_Type.FullName!, (uint) s_Index);
//
//         return (uint) s_Index;
//     }
//
//     private uint WriteTypeString(string p_String)
//     {
//         if (m_TypeStringHashes.TryGetValue(p_String, out var s_Hash))
//             return s_Hash;
//             
//         m_TypeStringWriter.Write(Encoding.UTF8.GetBytes(p_String));
//         m_TypeStringWriter.WriteByte(0);
//
//         s_Hash = Frostbite.Utils.HashQuick(p_String);
//         m_TypeStringHashes.Add(p_String, s_Hash);
//             
//         return s_Hash;
//     }
//
//     public uint WriteImport(CtrRefBase p_CtrRef)
//     {
//         if (p_CtrRef.IsNull())
//             return 0;
//
//         if (p_CtrRef.InstanceId is not DataContainerId.Guid s_InstanceId)
//         {
//             throw new Exception($"This version of the Frostbite engine does not support index-based DataContainer ids.");
//         }
//
//         if (p_CtrRef.PartitionGuid == m_Partition.PartitionGuid)
//         {
//             if (m_InternalInstanceGuids.TryGetValue(s_InstanceId.Id, out var s_Index))
//                 return s_Index + 1;
//
//             throw new Exception($"Found internal reference to instance '{p_CtrRef.InstanceId}', but this instance doesn't exist in this partition.");
//         }
//
//         // See if we already have an entry for this import.
//         var s_ImportIndex = m_ImportEntries.FindIndex(
//             (p_Entry) => p_Entry.InstanceGuid == s_InstanceId.Id &&
//                          p_Entry.PartitionGuid == p_CtrRef.PartitionGuid
//         );
//
//         if (s_ImportIndex == -1)
//         {
//             // Import not found, create one.
//             s_ImportIndex = m_ImportEntries.Count;
//
//             m_ImportEntries.Add(new ImportEntry()
//             {
//                 InstanceGuid = s_InstanceId.Id,
//                 PartitionGuid = p_CtrRef.PartitionGuid,
//             });
//         }
//
//         return (uint) s_ImportIndex | 0x80000000u;
//     }
//
//     public uint WriteString(string p_String)
//     {
//         if (m_StringIndices.TryGetValue(p_String, out var s_Offset))
//             return s_Offset;
//
//         var s_StringOffset = m_StringWriter.Position;
//
//         m_StringWriter.Write(Encoding.UTF8.GetBytes(p_String));
//         m_StringWriter.WriteByte(0);
//
//         m_StringIndices.Add(p_String, (uint) s_StringOffset);
//
//         return (uint) s_StringOffset;
//     }
//
//     public (RimeWriter, uint) GetArrayWriter(Type p_ArrayType, int p_ElementCount)
//     {
//         var s_Writer = new RimeWriter(new MemoryStream());
//
//         var s_ArrayIndex = m_ArrayEntries.Count;
//         m_ArrayEntries.Add(new ArrayEntry()
//         {
//             ElementCount = (uint) p_ElementCount,
//             Offset = 0,
//             TypeDescriptorIndex = WriteTypeDescriptor(p_ArrayType),
//         });
//
//         m_ArrayWriters.Add(s_Writer);
//
//         return (s_Writer, (uint) s_ArrayIndex);
//     }
//
//     public void Dispose()
//     {
//         m_PayloadWriter.Dispose();
//         m_TypeStringWriter.Dispose();
//         m_StringWriter.Dispose();
//         m_ArrayPayloadWriter.Dispose();
//         m_MetaWriter.Dispose();
//
//         foreach (var s_Writer in m_ArrayWriters)
//             s_Writer.Dispose();
//
//         m_ArrayWriters.Clear();
//     }
// }