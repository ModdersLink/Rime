using RimeLib.Frostbite.Core;
using RimeLib.IO;
using RimeLib.IO.Conversion;
using RimeLib.Serialization.Attributes;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Text;
using fb;
using RimeLib.Content.Mounting;

namespace RimeLib.Serialization.Frostbite2_0.Ebx;

public class EbxReader : IDisposable
{
    private StreamingPartitionHeader m_Header = new();
    private RimeReader m_Reader = new(new MemoryStream());
    private List<ImportEntry> m_ImportEntries = new();
    public List<string> m_TypeStrings = new();
    private Dictionary<uint, string> m_HashedTypeStrings = new();
    private List<FieldDescriptor> m_FieldDescriptors = new();
    private List<TypeDescriptor> m_TypeDescriptors = new();
    private List<InstanceEntry> m_InstanceEntries = new();
    private List<ArrayEntry> m_ArrayEntries = new();
    private List<GUID> m_InternalInstanceGuids = new();

    private DatabasePartition m_Partition = new();

    public DatabasePartition ParsePartition(string p_Name, IObjectVariant p_Variant)
    {
        using var s_Reader = p_Variant.GetReader();

        m_Partition = new DatabasePartition
        {
            Name = p_Name,
            AssociatedVariant = p_Variant,
        };

        var s_Magic = s_Reader.ReadBytes(4);
        s_Reader.Seek(-4, SeekOrigin.Current);

        if (IsLittleEndian(s_Magic))
            m_Reader = new RimeReader(s_Reader, Endianness.LittleEndian, false);
        else if (IsBigEndian(s_Magic))
            m_Reader = new RimeReader(s_Reader, Endianness.BigEndian, false);
        else
            throw new Exception("The supplied file has an invalid magic header.");

        ProcessHeader();

        return m_Partition;
    }
        
    private void ProcessPadding()
    {
        while (m_Reader.Position % 16 != 0)
            m_Reader.Seek(1, SeekOrigin.Current);
    }
        
    private void ProcessHeader()
    {
        m_Header = new StreamingPartitionHeader(m_Reader);

        m_Partition.PartitionGuid = m_Header.PartitionGuid;
        m_Partition.PrimaryInstanceGuid = m_Header.PrimaryInstanceGuid;

        // Advance state
        ProcessMetadata();
    }
        
    private void ProcessMetadata()
    {
        // Parse imports.
        m_ImportEntries = new List<ImportEntry>((int)m_Header.ImportCount);
        for (var i = 0; i < m_Header.ImportCount; ++i)
            m_ImportEntries.Add(new ImportEntry(m_Reader));

        // Parse type strings.
        m_TypeStrings = new List<string>(Encoding.UTF8.GetString(m_Reader.ReadBytes((int)m_Header.TypeStringTableSize)).TrimEnd('\0').Split('\0'));

        m_HashedTypeStrings = new Dictionary<uint, string>();

        foreach (var s_TypeString in m_TypeStrings)
            m_HashedTypeStrings[Frostbite.Utils.HashQuick(s_TypeString)] = s_TypeString;

        // Parse field descriptors.
        m_FieldDescriptors = new List<FieldDescriptor>((int)m_Header.FieldDescriptorCount);
        for (var i = 0; i < m_Header.FieldDescriptorCount; ++i)
            m_FieldDescriptors.Add(new FieldDescriptor(m_Reader, m_HashedTypeStrings));

        ProcessPadding();

        // Parse type descriptors.
        m_TypeDescriptors = new List<TypeDescriptor>((int)m_Header.TypeDescriptorCount);
        for (var i = 0; i < m_Header.TypeDescriptorCount; ++i)
            m_TypeDescriptors.Add(new TypeDescriptor(m_Reader, m_HashedTypeStrings));

        // Parse instances.
        m_InstanceEntries = new List<InstanceEntry>((int)m_Header.TypeCount);
        for (var i = 0; i < m_Header.TypeCount; ++i)
            m_InstanceEntries.Add(new InstanceEntry(m_Reader));

        ProcessPadding();

        // Parse array entries.
        m_ArrayEntries = new List<ArrayEntry>((int)m_Header.ArrayCount);
        for (var i = 0; i < m_Header.ArrayCount; ++i)
            m_ArrayEntries.Add(new ArrayEntry(m_Reader));

        ProcessPadding();
        ProcessInstanceGuids();
    }

    private void ProcessInstanceGuids()
    {
        m_InternalInstanceGuids = new List<GUID>();

        m_Reader.Seek((int)(m_Header.MetaSize + m_Header.StringTableSize), SeekOrigin.Begin);

        // Here we go and read only the instance guids, since we will need those for internal instance references (CtrRef).
        foreach (var s_Entry in m_InstanceEntries)
        {
            if (s_Entry.InternalCount > 0)
                throw new Exception("Unhandled Internal Data for Instance Entry.");

            var s_Descriptor = m_TypeDescriptors[(int)s_Entry.TypeDescriptorIndex];

            for (var i = 0; i < s_Entry.ExportCount; ++i)
            {
                var s_Guid = new GUID(m_Reader);
                m_InternalInstanceGuids.Add(s_Guid);
                m_Reader.Seek(s_Descriptor.Size, SeekOrigin.Current);

            }
        }

        ProcessPayloads();
    }
        
    private void ProcessPayloads()
    {
        m_Reader.Seek((int)(m_Header.MetaSize + m_Header.StringTableSize), SeekOrigin.Begin);

        foreach (var s_Entry in m_InstanceEntries)
        {
            if (s_Entry.InternalCount > 0)
                throw new Exception("Unhandled Internal Data for Instance Entry.");

            var s_Descriptor = m_TypeDescriptors[(int)s_Entry.TypeDescriptorIndex];
            var s_ContainerType = Type.GetType($"fb.{s_Descriptor.Name}");

            if (s_ContainerType == null)
                throw new Exception($"Could not find container of type {s_Descriptor.Name}.");

            for (var i = 0; i < s_Entry.ExportCount; ++i)
            {
                var s_Guid = new GUID(m_Reader);

                //Console.WriteLine($"Parsing {s_ContainerType} with GUID {s_Guid}.");

                var s_ContainerAttribute = s_ContainerType.GetCustomAttribute<ContainerTypeAttribute>()!;

                if (s_ContainerAttribute.AlignedSize != s_Descriptor.Size ||
                    s_ContainerAttribute.DataAlignment != s_Descriptor.Alignment)
                {
                    //Console.WriteLine($"Expected size of {s_ContainerType} of {s_ContainerAttribute.AlignedSize} bytes does not match in-file size of {s_Descriptor.Size} bytes. Probably means the game was updated but the data was not.");
                }

                var s_Instance = (DataContainerBase) Activator.CreateInstance(s_ContainerType)!;
                s_Instance.InstanceId = new DataContainerId.Guid(s_Guid);
                s_Instance.Partition = m_Partition;

                using var s_LimitedReader = new LimitedRimeReader(m_Reader, s_Descriptor.Size, false);
                ParseTypeInstance(s_LimitedReader, s_Descriptor, s_Instance, s_ContainerType);

                m_Partition.InstanceMap.Add(s_Guid, (s_Instance as DataContainer)!);
            }
        }
    }
        
    private void ParseTypeInstance(RimeReader p_Reader, TypeDescriptor p_Descriptor, object p_Instance, Type p_InstanceType)
    {
        var s_StartPosition = p_Reader.Position;

        for (var i = p_Descriptor.LayoutDescriptor; i < (p_Descriptor.LayoutDescriptor + p_Descriptor.FieldCount); ++i)
        {
            var s_FieldDescriptor = m_FieldDescriptors[(int) i];
                
            p_Reader.Seek(s_FieldDescriptor.Offset, SeekOrigin.Begin);

            if (s_FieldDescriptor.Flags.Type == FieldType.Void)
            {
                ParseTypeInstance(p_Reader, m_TypeDescriptors[s_FieldDescriptor.FieldType], p_Instance, p_InstanceType);
                continue;
            }

            // See if this field exists in the type binding.
            // TODO: This will not work for types with duplicate property names.
            var s_PropertyType = p_InstanceType.GetProperty(s_FieldDescriptor.Name);

            if (s_PropertyType == null)
            {
                //Console.WriteLine($"Type {p_InstanceType.Name} has field {s_FieldDescriptor.Name} in data that no longer exists.");
                continue;
            }

            var s_ContainerFieldAttribute = s_PropertyType.GetCustomAttribute<ContainerFieldAttribute>();

            if (s_ContainerFieldAttribute == null)
            {
                Console.WriteLine($"Field {s_FieldDescriptor.Name} of type {p_InstanceType.Name} has no ContainerField attribute. Is this intentional?");
                continue;
            }
                
            switch (s_FieldDescriptor.Flags.Type)
            {
                case FieldType.ValueType:
                    var s_StructDescriptor = m_TypeDescriptors[s_FieldDescriptor.FieldType];
                    var s_StructType = Type.GetType($"fb.{s_StructDescriptor.Name}");

                    if (s_StructType == null)
                        throw new Exception($"Could not find container of type {s_StructDescriptor.Name}.");

                    var s_Struct = Activator.CreateInstance(s_StructType)!;

                    using (var s_Reader = new LimitedRimeReader(p_Reader, s_StructDescriptor.Size, false))
                        ParseTypeInstance(s_Reader, s_StructDescriptor, s_Struct, s_StructType);

                    s_PropertyType.SetValue(p_Instance, s_Struct);
                    break;
                case FieldType.Class:
                    var s_ImportIndex = p_Reader.ReadUInt32();
                    var s_CtrRef = s_PropertyType.GetValue(p_Instance) as CtrRefBase;
                    s_CtrRef!.SetValue(GetImportAtIndex(s_ImportIndex));
                    break;
                case FieldType.Array:
                    var s_ArrayIndex = p_Reader.ReadUInt32();
                    ParseArray((int) s_ArrayIndex, s_PropertyType, p_Instance);
                    break;
                case FieldType.Enum:
                    var s_EnumValue = GetEnumForValue(m_Reader.ReadInt32(), m_TypeDescriptors[s_FieldDescriptor.FieldType], s_PropertyType.PropertyType, false);
                    s_PropertyType.SetValue(p_Instance, s_EnumValue);
                    break;
                default:
                    var s_Value = ParseSimpleType(p_Reader, s_FieldDescriptor.Flags.Type);
                    s_PropertyType.SetValue(p_Instance, s_Value);
                    break;
            }
        }

        var s_BytesLeftToRead = p_Descriptor.Size - (p_Reader.Position - s_StartPosition);
        p_Reader.Seek(s_BytesLeftToRead, SeekOrigin.Current);
    }

    private void ParseArray(int p_ArrayIndex, PropertyInfo p_PropertyType, object p_Instance)
    {
        var s_ArrayEntry = m_ArrayEntries[p_ArrayIndex];
        var s_ArrayDescriptor = m_TypeDescriptors[(int)s_ArrayEntry.TypeDescriptorIndex];
        var s_ArrayElementFieldDescriptor = m_FieldDescriptors[(int)s_ArrayDescriptor.LayoutDescriptor];
        var s_ArrayElementDescriptor = m_TypeDescriptors[s_ArrayElementFieldDescriptor.FieldType];
        var s_CurrentOffset = m_Reader.Position;

        m_Reader.Seek((int)(m_Header.MetaSize + m_Header.StringTableSize + m_Header.ArrayOffset + s_ArrayEntry.Offset), SeekOrigin.Begin);

        switch (s_ArrayElementFieldDescriptor.Flags.Type)
        {
            case FieldType.Class:
            {
                var s_List = p_PropertyType.GetValue(p_Instance);
                var s_AddRef = s_List!.GetType().GetMethod("AddRef")!;

                for (var j = 0; j < s_ArrayEntry.ElementCount; ++j)
                {
                    var s_Ref = GetImportAtIndex(m_Reader.ReadUInt32());
                    s_AddRef.Invoke(s_List, new[] { s_Ref });
                }

                break;
            }
            case FieldType.ValueType:
            {
                var s_List = p_PropertyType.GetValue(p_Instance) as IList;
                var s_ArrayStructType = Type.GetType($"fb.{s_ArrayElementDescriptor.Name}");

                if (s_ArrayStructType == null)
                    throw new Exception($"Could not find container of type {s_ArrayElementDescriptor.Name}.");

                for (var j = 0; j < s_ArrayEntry.ElementCount; ++j)
                {
                    var s_ArrayStruct = Activator.CreateInstance(s_ArrayStructType);

                    using (var s_ArrayStructReader = new LimitedRimeReader(m_Reader, s_ArrayElementDescriptor.Size, false))
                    {
                        ParseTypeInstance(
                            s_ArrayStructReader,
                            s_ArrayElementDescriptor,
                            s_ArrayStruct!,
                            s_ArrayStructType
                        );
                    }

                    s_List!.Add(s_ArrayStruct);
                }

                break;
            }
            case FieldType.Enum:
            {
                var s_List = p_PropertyType.GetValue(p_Instance) as IList;

                for (var j = 0; j < s_ArrayEntry.ElementCount; ++j)
                {
                    var s_Value = GetEnumForValue(
                        m_Reader.ReadInt32(),
                        s_ArrayElementDescriptor,
                        p_PropertyType.PropertyType.GetGenericArguments()[0],
                        true
                    );
                     
                    s_List!.Add(s_Value);
                }

                break;
            }
            case FieldType.Array:
            {
                throw new Exception("Found an array nested in another array. This is currently unsupported.");
            }
            default:
            {
                var s_List = p_PropertyType.GetValue(p_Instance) as IList;

                for (var j = 0; j < s_ArrayEntry.ElementCount; ++j)
                {
                    s_List!.Add(ParseSimpleType(m_Reader, s_ArrayElementFieldDescriptor.Flags.Type));
                }

                break;
            }
        }

        m_Reader.Seek(s_CurrentOffset, SeekOrigin.Begin);
    }

    private object ParseSimpleType(RimeReader p_Reader, FieldType p_Type)
    {
        switch (p_Type)
        {
            case FieldType.CString:
                return GetStringAtOffset(p_Reader.ReadUInt32());
            case FieldType.Boolean:
                return p_Reader.ReadBool();
            case FieldType.Int8:
                return p_Reader.ReadSByte();
            case FieldType.UInt8:
                return p_Reader.ReadUByte();
            case FieldType.Int16:
                return p_Reader.ReadInt16();
            case FieldType.UInt16:
                return p_Reader.ReadUInt16();
            case FieldType.Int32:
                return p_Reader.ReadInt32();
            case FieldType.UInt32:
                return p_Reader.ReadUInt32();
            case FieldType.Int64:
                return p_Reader.ReadInt64();
            case FieldType.UInt64:
                return p_Reader.ReadUInt64();
            case FieldType.Float32:
                return p_Reader.ReadSingle();
            case FieldType.Float64:
                return p_Reader.ReadDouble();
            case FieldType.Guid:
                return new GUID(p_Reader);
            default:
                throw new Exception($"Unsupported field type {p_Type}.");
        }
    }
        
    private static bool IsLittleEndian(byte[] p_Data)
    {
        return p_Data[0] == 0xCE &&
               p_Data[1] == 0xD1 &&
               p_Data[2] == 0xB2 &&
               p_Data[3] == 0x0F;
    }
        
    private static bool IsBigEndian(byte[] p_Data)
    {
        return p_Data[3] == 0xCE &&
               p_Data[2] == 0xD1 &&
               p_Data[1] == 0xB2 &&
               p_Data[0] == 0x0F;
    }

    public object GetEnumForValue(int p_Value, TypeDescriptor p_Descriptor, Type p_EnumType, bool p_InArray)
    {
        if (p_InArray)
            return Enum.ToObject(p_EnumType, p_Value);

        string? s_EnumValueName = null;

        for (var i = p_Descriptor.LayoutDescriptor; i < (p_Descriptor.LayoutDescriptor + p_Descriptor.FieldCount); ++i)
        {
            if (p_Value == m_FieldDescriptors[(int) i].Offset)
            {
                s_EnumValueName = m_FieldDescriptors[(int) i].Name;
                break;
            }
        }
               
        if (s_EnumValueName == null)
            throw new Exception($"Could not find value '{p_Value}' in enum '{p_Descriptor.Name}'. This probably means the EBX was corrupted.");

        if (!Enum.IsDefined(p_EnumType, s_EnumValueName))
            throw new Exception($"Value '{s_EnumValueName}' no longer exists in enum '{p_Descriptor.Name}'.");

        return Enum.Parse(p_EnumType, s_EnumValueName);
    }

    public CtrRefBase GetImportAtIndex(uint p_Index)
    {
        // External reference.
        if ((p_Index & 0x80000000) != 0)
        {
            p_Index &= 0x7FFFFFFF;
            var s_Import = m_ImportEntries[(int)p_Index];
            return new CtrRefBase(s_Import.PartitionGuid, new DataContainerId.Guid(s_Import.InstanceGuid));
        }

        // Null reference.
        if (p_Index == 0)
            return new CtrRefBase();

        var s_ActualIndex = p_Index - 1;
            
        if (s_ActualIndex >= m_InternalInstanceGuids.Count)
        {
            throw new Exception(
                $"Found an internal instance reference for instance at index {s_ActualIndex} but this partition only has {m_InternalInstanceGuids.Count} instances."
            );
        }

        return new CtrRefBase(m_Header.PartitionGuid, new DataContainerId.Guid(m_InternalInstanceGuids[(int) s_ActualIndex]));
    }

    public string GetStringAtOffset(uint p_Offset)
    {
        var s_String = "";

        if (p_Offset != 0xFFFFFFFF)
        {
            var s_CurrentOffset = m_Reader.Position;

            m_Reader.Seek((int) (m_Header.MetaSize + p_Offset), SeekOrigin.Begin);

            using var s_TempStream = new RimeWriter(new MemoryStream());

            while (true)
            {
                var s_Byte = m_Reader.ReadUByte();

                if (s_Byte == 0x00)
                    break;

                s_TempStream.Write(s_Byte);
            }

            s_TempStream.Flush();
            s_String = Encoding.UTF8.GetString(((MemoryStream) s_TempStream.BaseStream).ToArray());
                
            m_Reader.Seek(s_CurrentOffset, SeekOrigin.Begin);
        }

        return s_String;
    }

    public void Dispose()
    {
        m_Reader?.Dispose();
    }
}