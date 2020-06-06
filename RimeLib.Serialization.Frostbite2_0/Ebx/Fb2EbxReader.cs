using RimeLib.Extensions;
using RimeLib.Frostbite.Core;
using RimeLib.IO;
using RimeLib.IO.Conversion;
using RimeLib.Serialization.Attributes;
using RimeLib.Serialization.Containers;
using RimeLib.Serialization.Ebx;
using RimeLib.Utils;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Text;

namespace RimeLib.Serialization.Frostbite2_0.Ebx
{
    /// <summary>
    /// Frostbite 2 ebx reader
    /// </summary>
    public class Fb2EbxReader : IEbxReader
    {
        /// <summary>
        /// Current state of the parser
        /// </summary>
        enum ParseState
        {
            ParseHeader,
            ParseMetadata,
            ParsePayloads,
            ResolveReferences,
            ParseFinished
        }

        private FrostbitePartition m_ParsingPartition;

        /// <summary>
        /// Tracking for the current container we are parsing
        /// </summary>
        protected FrostbiteContainer m_CurrentContainer;

        private ParseState m_ParseState;
        private StreamingPartitionHeader m_Header;
        private RimeReader m_Reader;
        private List<ImportEntry> m_ImportEntries;
        private List<string> m_TypeStrings;
        private Dictionary<uint, string> m_HashedTypeStrings;
        private List<FieldDescriptor> m_FieldDescriptors;
        private List<TypeDescriptor> m_TypeDescriptors;
        private List<InstanceEntry> m_InstanceEntries;
        private List<ArrayEntry> m_ArrayEntries;
        private List<GUID> m_InstanceGuiDs;
        private List<Instance> m_Instances;
        private Dictionary<ushort, EnumInstance> m_Enumerations;
        private IList m_PopulatingArray;
        private List<CtrRefBase> m_LateResolveReferences;

        /// <summary>
        /// Parses a partition with the specified name and data
        /// </summary>
        /// <param name="p_Name">Name of the parition</param>
        /// <param name="p_Data">Ebx partition data</param>
        /// <returns>Partition object</returns>
        public FrostbitePartition ParsePartition(string p_Name, byte[] p_Data)
        {
            if (p_Data == null || p_Data.Length < 4)
                throw new InvalidDataException("Data is invalid for ebx.");

            m_PopulatingArray = null;
            m_CurrentContainer = null;
            m_ParsingPartition = new FrostbitePartition() { Name = p_Name };
            m_LateResolveReferences = new List<CtrRefBase>();

            var s_Data = new byte[p_Data.Length];
            Buffer.BlockCopy(p_Data, 0, s_Data, 0, p_Data.Length);

            if (LittleEndian(s_Data))
                m_Reader = new RimeReader(new MemoryStream(s_Data));
            else if (BigEndian(s_Data))
                m_Reader = new RimeReader(new MemoryStream(s_Data), Endianness.BigEndian);
            else
            {
                // Try to resource decompress
                if (p_Data.Length < 12)
                    throw new Exception("The supplied file has an invalid magic header.");

                var s_Header = BitConverter.ToUInt16(p_Data, 8);
                if (s_Header != 0xDA78)
                    throw new Exception("The supplied file has an invalid magic header.");

                // It's a compressed resource
                s_Data = Decoding.DecodeZlibSegmented(p_Data); //RimeHelper.ResourceDecompress(p_Data);

                if (LittleEndian(s_Data))
                    m_Reader = new RimeReader(new MemoryStream(s_Data));
                else if (BigEndian(s_Data))
                    m_Reader = new RimeReader(new MemoryStream(s_Data), Endianness.BigEndian);
                else
                    throw new Exception("The supplied file has an invalid magic header.");
            }

            ProcessHeader();

            return m_ParsingPartition;
        }

        /// <summary>
        /// Parses a partition with specified name and opened reader to the position of the ebx data
        /// </summary>
        /// <param name="p_Name">Name of partition</param>
        /// <param name="p_Reader">Reader opened to the position of ebx data</param>
        /// <returns>Partition object</returns>
        public FrostbitePartition ParsePartition(string p_Name, RimeReader p_Reader)
        {
            if (p_Reader == null)
                throw new InvalidDataException("Data is invalid for ebx.");

            m_PopulatingArray = null;
            m_CurrentContainer = null;
            m_ParsingPartition = new FrostbitePartition() { Name = p_Name };
            m_LateResolveReferences = new List<CtrRefBase>();

            // Read out the binary ebx format
            byte[] s_EbxData = p_Reader.ReadBytes((int)p_Reader.Length);
            p_Reader.Seek(0, SeekOrigin.Begin);

            var s_Magic = p_Reader.ReadBytes(4);

            if (LittleEndian(s_Magic))
                m_Reader = new RimeReader(new MemoryStream(s_EbxData), Endianness.LittleEndian);
            else if (BigEndian(s_Magic))
                m_Reader = new RimeReader(new MemoryStream(s_EbxData), Endianness.BigEndian);
            else
                throw new Exception("The supplied file has an invalid magic header.");

            ProcessHeader();

            return m_ParsingPartition;
        }

        /// <summary>
        /// Process the binary data of the loaded file.
        /// </summary>
        private void ProcessData()
        {
            switch (m_ParseState)
            {
                case ParseState.ParseHeader:
                    ProcessHeader();
                    break;
                case ParseState.ParseMetadata:
                    ProcessMetadata();
                    break;
                case ParseState.ParsePayloads:
                    ProcessPayloads();
                    break;
                case ParseState.ResolveReferences:
                    ProcessReferences();
                    break;
                case ParseState.ParseFinished:
                    break;
            }
        }


        /// <summary>
        /// If needed, skip alignment-based padded bytes.
        /// </summary>
        private void ProcessPadding()
        {
            while (m_Reader.Position % 16 != 0)
                m_Reader.Seek(1, SeekOrigin.Current);
        }

        /// <summary>
        /// Parse the header of the provided file.
        /// </summary>
        private void ProcessHeader()
        {
            m_Header = new StreamingPartitionHeader(m_Reader);

            m_ParsingPartition.PartitionGuid = m_Header.PartitionGuid;

            // Advance state
            m_ParseState = ParseState.ParseMetadata;
            ProcessData();
        }

        /// <summary>
        /// Parse the metadata of the provided file.
        /// </summary>
        private void ProcessMetadata()
        {
            // Parse imports.
            m_ImportEntries = new List<ImportEntry>((int)m_Header.ImportCount);
            for (var i = 0; i < m_Header.ImportCount; ++i)
                m_ImportEntries.Add(new ImportEntry(m_Reader));

            // Parse strings.r
            m_TypeStrings = new List<string>(Encoding.UTF8.GetString(m_Reader.ReadBytes((int)m_Header.TypeStringTableSize)).TrimEnd('\0').Split('\0'));

            m_HashedTypeStrings = new Dictionary<uint, string>();

            foreach (var s_TypeString in m_TypeStrings)
                m_HashedTypeStrings[FbUtils.HashQuick(s_TypeString)] = s_TypeString;

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

            /*Debug.WriteLine($"Strings: {m_HashedTypeStrings.Count}");
            Debug.WriteLine($"Imports: {m_ImportEntries.Count}");
            Debug.WriteLine($"Fields: {m_FieldDescriptors.Count}");
            Debug.WriteLine($"Types: {m_TypeDescriptors.Count}");
            Debug.WriteLine($"Instances: {m_InstanceEntries.Count}");
            Debug.WriteLine($"Arrays: {m_ArrayEntries.Count}");

            foreach (var s_Descriptor in m_TypeDescriptors)
                Debug.WriteLine($"Type '{s_Descriptor.Name} (sz: {s_Descriptor.Size}, al: {s_Descriptor.Alignment}) Flags: 0x{s_Descriptor.Flags.FlagBits:X04}");

            foreach (var s_Descriptor in m_FieldDescriptors)
                Debug.WriteLine($"Field '{s_Descriptor.Name} (+{s_Descriptor.Offset}) Flags: 0x{s_Descriptor.Flags.FlagBits:X04}");*/

            ProcessPadding();

            // Advance state
            m_ParseState = ParseState.ParsePayloads;
            ProcessData();
        }

        /// <summary>
        /// Process the payload data of the provided file and parse all the Instances, their Types, and their Fields.
        /// </summary>
        private void ProcessPayloads()
        {
            m_InstanceGuiDs = new List<GUID>();
            m_Instances = new List<Instance>();
            m_Enumerations = new Dictionary<ushort, EnumInstance>();

            m_Reader.Seek((int)(m_Header.MetaSize + m_Header.StringTableSize), SeekOrigin.Begin);

            foreach (var s_Entry in m_InstanceEntries)
            {
                if (s_Entry.InternalCount > 0)
                    throw new Exception("Unhandled Internal Data for Instance Entry.");

                var s_Descriptor = m_TypeDescriptors[(int)s_Entry.TypeDescriptorIndex];
                var s_ContainerType = ContainerRegistry.GetContainerType(s_Descriptor.NameHash);

                if (s_ContainerType == null)
                    Debug.WriteLine($"Failed to find container of type '{s_Descriptor.Name}'.");

                for (var i = 0; i < s_Entry.ExportCount; ++i)
                {
                    var s_Guid = new GUID(m_Reader);
                    m_InstanceGuiDs.Add(s_Guid);

                    // Create our container used for binding.
                    if (s_ContainerType != null)
                    {
                        m_CurrentContainer = (FrostbiteContainer)Activator.CreateInstance(s_ContainerType);
                        ((DataContainer)m_CurrentContainer).InstanceGuid = s_Guid;
                        ((DataContainer)m_CurrentContainer).PartitionGuid = m_Header.PartitionGuid;
                    }
                    else
                    {
                        m_CurrentContainer = new DataContainer()
                        {
                            ContainerAlignment = s_Descriptor.Alignment,
                            ContainerFlags = s_Descriptor.Flags.FlagBits,
                            ContainerTypeName = s_Descriptor.Name,
                            InstanceGuid = s_Guid,
                            PartitionGuid = m_Header.PartitionGuid
                        };

                    }

                    m_Instances.Add(new Instance { Id = s_Guid, Type = ParseTypeInstance(s_Guid, s_Entry.TypeDescriptorIndex) });

                    // Add our fully parsed container to the list of parsed containers.
                    m_ParsingPartition.AddInstance((DataContainer)m_CurrentContainer, s_Guid == m_Header.PrimaryInstanceGuid);
                    m_CurrentContainer = null;
                }
            }

            m_ParseState = ParseState.ResolveReferences;
            ProcessData();
        }

        private void ProcessReferences()
        {
            foreach (var s_Reference in m_LateResolveReferences)
            {
                var s_Container = m_ParsingPartition.Instances[(int)(s_Reference.ImportIndex - 1)];

                s_Reference.ImportIndex = 0;
                s_Reference.SetValue(s_Container.PartitionGuid, s_Container.InstanceGuid);
            }

            m_ParseState = ParseState.ParseFinished;
            ProcessData();
        }

        /// <summary>
        /// Parse a TypeInstance using previously parsed metadata.
        /// </summary>
        /// <param name="p_InstanceGuid">Parent Instance Id.</param>
        /// <param name="p_DescriptorIndex">TypeDescriptor metadata Index.</param>
        /// <returns></returns>
        private TypeInstance ParseTypeInstance(GUID p_InstanceGuid, uint p_DescriptorIndex)
        {
            var s_TypeInstance = new TypeInstance()
            {
                Descriptor = m_TypeDescriptors[(int)p_DescriptorIndex],
                Fields = new List<FieldInstance>()
            };

            //Debug.WriteLine("Parsing type '{0}' of type '{1}'.", s_TypeInstance.Descriptor.Name, s_TypeInstance.Descriptor.Flags.GetFieldType());

            var s_StartOffset = m_Reader.Position;

            for (var i = s_TypeInstance.Descriptor.LayoutDescriptor; i < (s_TypeInstance.Descriptor.LayoutDescriptor + s_TypeInstance.Descriptor.FieldCount); ++i)
            {
                m_Reader.Seek((int)(s_StartOffset + m_FieldDescriptors[(int)i].Offset), SeekOrigin.Begin);
                s_TypeInstance.Fields.Add(ParseFieldInstance(p_InstanceGuid, i, s_TypeInstance, null));
            }

            m_Reader.Seek((int)(s_StartOffset + s_TypeInstance.Descriptor.Size), SeekOrigin.Begin);

            return s_TypeInstance;
        }

        /// <summary>
        /// Parse a FieldInstance using previously parsed metadata.
        /// </summary>
        /// <param name="p_InstanceGuid">Parent Instance Id.</param>
        /// <param name="p_DescriptorIndex">FieldDescriptor metadata Index.</param>
        /// <param name="p_TypeInstance"></param>
        /// <param name="p_ArrayType"></param>
        /// <returns></returns>
        private FieldInstance ParseFieldInstance(GUID p_InstanceGuid, uint p_DescriptorIndex, TypeInstance p_TypeInstance, Type p_ArrayType)
        {
            var s_Field = new FieldInstance()
            {
                Descriptor = m_FieldDescriptors[(int)p_DescriptorIndex],
                Value = null
            };

            var s_ContainerType = ContainerRegistry.GetContainerType(p_TypeInstance.Descriptor.NameHash);

            var s_StartOffsetField = m_Reader.BaseStream.Position;
            Debug.WriteLine("Parsing field '{0}' of type '{1:X04}' at offset {2} ({3}).", s_Field.Descriptor.Name, s_Field.Descriptor.Flags.FlagBits, s_Field.Descriptor.Offset, m_Reader.BaseStream.Position);

            if (s_Field.Descriptor.Flags.GetFieldType() >= FieldType.FieldTypeCount)
                throw new Exception($"Tried to parse field with unknown type '{(int)s_Field.Descriptor.Flags.GetFieldType()}'.");

            switch (s_Field.Descriptor.Flags.GetFieldType())
            {
                case FieldType.Void:
                    {
                        // This is class inheritance.
                        // This will never exist ever in a struct.
                        // We don't need to bind anything here; everything will happen automagically™.
                        s_Field.Value = ParseTypeInstance(p_InstanceGuid, s_Field.Descriptor.FieldType);
                        break;
                    }

                case FieldType.ValueType:
                    {
                        // Create our struct type.
                        var s_StructDescriptor = m_TypeDescriptors[s_Field.Descriptor.FieldType];
                        var s_StructType = ContainerRegistry.GetContainerType(s_StructDescriptor.NameHash);

                        if (s_StructType == null)
                            Debug.WriteLine($"Failed to find value container of type '{s_StructDescriptor.Name}'.");

                        var s_PreviouslyParsingContainer = m_CurrentContainer;

                        var s_PreviouslyPopulatingArray = m_PopulatingArray;
                        m_PopulatingArray = null;

                        if (s_StructType != null)
                        {
                            m_CurrentContainer = (FrostbiteContainer)Activator.CreateInstance(s_StructType);
                        }
                        else
                        {
                            m_CurrentContainer = new FrostbiteContainer()
                            {
                                ContainerAlignment = s_StructDescriptor.Alignment,
                                ContainerFlags = s_StructDescriptor.Flags.FlagBits,
                                ContainerTypeName = s_StructDescriptor.Name
                            };
                        }

                        s_Field.Value = ParseTypeInstance(p_InstanceGuid, s_Field.Descriptor.FieldType);

                        // Bind our value type.
                        s_PreviouslyPopulatingArray?.Add(m_CurrentContainer);
                        s_PreviouslyParsingContainer?.Bind(s_Field.Descriptor, m_CurrentContainer);

                        m_CurrentContainer = s_PreviouslyParsingContainer;
                        m_PopulatingArray = s_PreviouslyPopulatingArray;
                        break;
                    }

                case FieldType.Array:
                    {
                        var s_ArrayEntryIndex = m_Reader.ReadUInt32();
                        var s_Entry = m_ArrayEntries[(int)s_ArrayEntryIndex];

                        m_Reader.Seek((int)(m_Header.MetaSize + m_Header.StringTableSize + m_Header.ArrayOffset + s_Entry.Offset), SeekOrigin.Begin);

                        if (s_Entry.ElementCount > 0)
                        {
                            var s_TypeInstance = new TypeInstance()
                            {
                                Descriptor = m_TypeDescriptors[(int)s_Entry.TypeDescriptorIndex],
                                Fields = new List<FieldInstance>(),
                                ArrayEntryIndex = s_ArrayEntryIndex
                            };

                            var s_LastPopulatingArray = m_PopulatingArray;
                            var s_CreatedWithType = false;
                            Type s_ArrayType = null;

                            // If we have a container type we will get the specific array type from there.
                            // If not, we will create a generic array based on limited typeinfo data.
                            if (s_ContainerType != null)
                            {
                                var s_Property = s_ContainerType.GetProperty(s_Field.Descriptor.Name);

                                if (s_Property != null)
                                {
                                    // Make sure this is a Container Field.
                                    var s_Attr = s_Property.GetCustomAttribute<ContainerFieldAttribute>();

                                    if (s_Attr != null)
                                    {
                                        // Make sure this is an array.
                                        if (!typeof(IList).IsAssignableFrom(s_Property.PropertyType))
                                            throw new Exception($"Tried parsing an EBX array ({s_Field.Descriptor.Name}) that doesn't match the bound data structure ({p_TypeInstance.Descriptor.Name}).");

                                        s_CreatedWithType = true;
                                        s_ArrayType = s_Property.PropertyType;
                                    }
                                }
                            }

                            if (!s_CreatedWithType)
                            {
                                var s_ArrayFieldDescriptor = m_FieldDescriptors[(int)s_TypeInstance.Descriptor.LayoutDescriptor];

                                var s_NativeType = GetNativeType(s_ArrayFieldDescriptor);

                                if (s_NativeType == null)
                                {
                                    var s_InternalTypeDescriptor = m_TypeDescriptors[s_ArrayFieldDescriptor.FieldType];
                                    var s_ArrayFieldType =
                                        ContainerRegistry.GetContainerType(s_InternalTypeDescriptor.NameHash);

                                    if (s_ArrayFieldType == null)
                                        Debug.WriteLine($"Failed to find array container of type '{s_InternalTypeDescriptor.Name}'.");

                                    if (s_ArrayFieldDescriptor.Flags.GetFieldType() == FieldType.Enum)
                                        s_ArrayFieldType = typeof(uint);

                                    if (s_ArrayFieldDescriptor.Flags.GetFieldType() == FieldType.Class && s_ArrayFieldType == null)
                                        s_ArrayFieldType = typeof(DataContainer);

                                    if (s_ArrayFieldDescriptor.Flags.GetFieldType() == FieldType.ValueType &&
                                        s_ArrayFieldType == null)
                                        s_ArrayFieldType = typeof(FrostbiteContainer);

                                    s_NativeType = s_ArrayFieldType;
                                }

                                s_ArrayType = s_ArrayFieldDescriptor.Flags.GetFieldType() == FieldType.Class
                                    ? typeof(RefArray<>).MakeGenericType(s_NativeType)
                                    : typeof(List<>).MakeGenericType(s_NativeType);
                            }

                            m_PopulatingArray = (IList)Activator.CreateInstance(s_ArrayType);

                            var s_LastParsingContainer = m_CurrentContainer;
                            m_CurrentContainer = null;

                            for (var i = 0; i < s_Entry.ElementCount; ++i)
                            {
                                s_TypeInstance.Fields.Add(ParseFieldInstance(
                                    p_InstanceGuid,
                                    s_TypeInstance.Descriptor.LayoutDescriptor,
                                    s_TypeInstance,
                                    s_ArrayType
                                ));
                            }

                            s_Field.Value = s_TypeInstance;

                            s_LastPopulatingArray?.Add(m_PopulatingArray);
                            s_LastParsingContainer?.Bind(s_Field.Descriptor, m_PopulatingArray);

                            m_PopulatingArray = s_LastPopulatingArray;
                            m_CurrentContainer = s_LastParsingContainer;
                        }
                        break;
                    }

                case FieldType.CString:
                    {
                        var s_StartOffset = m_Reader.Position;

                        var s_StringOffset = m_Reader.ReadUInt32();

                        string s_String = null;

                        if (s_StringOffset != 0xFFFFFFFF)
                        {
                            s_String = "";

                            m_Reader.Seek((int)(m_Header.MetaSize + s_StringOffset), SeekOrigin.Begin);

                            while (true)
                            {
                                var s_Char = (char)m_Reader.ReadByte();

                                if (s_Char == '\0')
                                    break;

                                s_String += s_Char;
                            }

                            m_Reader.Seek((int)(s_StartOffset + 4), SeekOrigin.Begin);
                        }

                        s_Field.Value = s_String;

                        m_PopulatingArray?.Add(s_Field.Value);
                        m_CurrentContainer?.Bind(s_Field.Descriptor, s_Field.Value);
                        break;
                    }

                case FieldType.Boolean:
                    {
                        s_Field.Value = m_Reader.ReadBool();

                        m_PopulatingArray?.Add(s_Field.Value);
                        m_CurrentContainer?.Bind(s_Field.Descriptor, s_Field.Value);
                        break;
                    }

                case FieldType.Int8:
                    {
                        s_Field.Value = m_Reader.ReadSByte();

                        m_PopulatingArray?.Add(s_Field.Value);
                        m_CurrentContainer?.Bind(s_Field.Descriptor, s_Field.Value);
                        break;
                    }

                case FieldType.UInt8:
                    {
                        s_Field.Value = m_Reader.ReadByte();

                        m_PopulatingArray?.Add(s_Field.Value);
                        m_CurrentContainer?.Bind(s_Field.Descriptor, s_Field.Value);
                        break;
                    }

                case FieldType.Int16:
                    {
                        s_Field.Value = m_Reader.ReadInt16();

                        m_PopulatingArray?.Add(s_Field.Value);
                        m_CurrentContainer?.Bind(s_Field.Descriptor, s_Field.Value);
                        break;
                    }

                case FieldType.UInt16:
                    {
                        s_Field.Value = m_Reader.ReadUInt16();

                        m_PopulatingArray?.Add(s_Field.Value);
                        m_CurrentContainer?.Bind(s_Field.Descriptor, s_Field.Value);
                        break;
                    }

                case FieldType.Int32:
                    {
                        s_Field.Value = m_Reader.ReadInt32();

                        m_PopulatingArray?.Add(s_Field.Value);
                        m_CurrentContainer?.Bind(s_Field.Descriptor, s_Field.Value);
                        break;
                    }

                case FieldType.UInt32:
                    {
                        s_Field.Value = m_Reader.ReadUInt32();

                        m_PopulatingArray?.Add(s_Field.Value);
                        m_CurrentContainer?.Bind(s_Field.Descriptor, s_Field.Value);
                        break;
                    }

                case FieldType.Int64:
                    {
                        s_Field.Value = m_Reader.ReadInt16();

                        m_PopulatingArray?.Add(s_Field.Value);
                        m_CurrentContainer?.Bind(s_Field.Descriptor, s_Field.Value);
                        break;
                    }

                case FieldType.UInt64:
                    {
                        s_Field.Value = m_Reader.ReadUInt64();

                        m_PopulatingArray?.Add(s_Field.Value);
                        m_CurrentContainer?.Bind(s_Field.Descriptor, s_Field.Value);
                        break;
                    }

                case FieldType.Float32:
                    {
                        s_Field.Value = m_Reader.ReadSingle();

                        m_PopulatingArray?.Add(s_Field.Value);
                        m_CurrentContainer?.Bind(s_Field.Descriptor, s_Field.Value);
                        break;
                    }

                case FieldType.Float64:
                    {
                        s_Field.Value = m_Reader.ReadDouble();

                        m_PopulatingArray?.Add(s_Field.Value);
                        m_CurrentContainer?.Bind(s_Field.Descriptor, s_Field.Value);
                        break;
                    }

                case FieldType.Guid:
                    {
                        s_Field.Value = new GUID(m_Reader);

                        m_PopulatingArray?.Add(s_Field.Value);
                        m_CurrentContainer?.Bind(s_Field.Descriptor, s_Field.Value);
                        break;
                    }

                case FieldType.Sha1:
                    {
                        s_Field.Value = new Sha1(m_Reader);

                        m_PopulatingArray?.Add(s_Field.Value);
                        m_CurrentContainer?.Bind(s_Field.Descriptor, s_Field.Value);
                        break;
                    }

                case FieldType.Enum:
                    {
                        var s_CompareValue = m_Reader.ReadUInt32();

                        var s_Descriptor = m_TypeDescriptors[s_Field.Descriptor.FieldType];

                        if (!m_Enumerations.ContainsKey(s_Field.Descriptor.FieldType))
                        {
                            // Create a new Enumeration
                            var s_Enumeration = new EnumInstance { Type = s_Field.Descriptor.FieldType };

                            for (var i = s_Descriptor.LayoutDescriptor; i < (s_Descriptor.LayoutDescriptor + s_Descriptor.FieldCount); ++i)
                                s_Enumeration.Values[m_FieldDescriptors[(int)i].Offset] = m_FieldDescriptors[(int)i].Name;

                            m_Enumerations[s_Field.Descriptor.FieldType] = s_Enumeration;
                        }

                        s_Field.Value = new EnumValue()
                        {
                            Type = s_Field.Descriptor.FieldType,
                            Value = s_CompareValue
                        };

                        var s_EnumType = ContainerRegistry.GetContainerType(s_Descriptor.NameHash);

                        if ((!s_EnumType?.IsEnum ?? false) && p_ArrayType != null)
                            s_EnumType = p_ArrayType.GetGenericArguments()[0];

                        if (!s_EnumType.IsEnum)
                            s_EnumType = null;

                        // If we have a bound enum type then cast it appropriately.
                        if (s_EnumType != null)
                        {
                            var s_RealValue = Enum.ToObject(s_EnumType, s_CompareValue);

                            m_PopulatingArray?.Add(s_RealValue);
                            m_CurrentContainer?.Bind(s_Field.Descriptor, s_RealValue);
                        }
                        else
                        {
                            m_PopulatingArray?.Add(s_CompareValue);
                            m_CurrentContainer?.Bind(s_Field.Descriptor, s_CompareValue);
                        }

                        break;
                    }

                case FieldType.Class:
                    {
                        // External (or internal) class reference
                        var s_ImportIndex = m_Reader.ReadUInt32();

                        var s_TypeDescriptor = m_TypeDescriptors[s_Field.Descriptor.FieldType];
                        var s_FieldType = ContainerRegistry.GetContainerType(s_TypeDescriptor.NameHash);

                        if (s_FieldType == null)
                            Debug.WriteLine($"Failed to find container of type '{s_TypeDescriptor.Name}'.");

                        CtrRefBase s_CtrRef = null;
                        var s_CreatedWithType = false;

                        // If we have a container type we will get the reference type from there.
                        // If not, we will create a generic reference based on limited typeinfo data.
                        if (s_ContainerType != null)
                        {
                            var s_Property = s_ContainerType.GetProperty(s_Field.Descriptor.Name);

                            if (s_Property != null)
                            {
                                // Make sure this is a Container Field.
                                var s_Attr = s_Property.GetCustomAttribute<ContainerFieldAttribute>();

                                if (s_Attr != null)
                                {
                                    typeof(CtrRef<>).IsAssignableFrom(s_Property.PropertyType);
                                    // Make sure this is an array.
                                    if (!typeof(CtrRef<>).IsGenericAssignableFrom(s_Property.PropertyType))
                                    {
                                        throw new Exception($"Tried parsing an EBX reference ({s_Field.Descriptor.Name}) that doesn't match the bound data structure ({p_TypeInstance.Descriptor.Name}).");
                                    }

                                    s_CreatedWithType = true;
                                    s_CtrRef = (CtrRefBase)Activator.CreateInstance(s_Property.PropertyType);
                                }
                            }
                        }
                        else
                        {
                            if (p_ArrayType != null)
                            {
                                s_CreatedWithType = true;

                                var s_RefType = p_ArrayType.GetGenericArguments()[0];
                                s_CtrRef = (CtrRefBase)Activator.CreateInstance(typeof(CtrRef<>).MakeGenericType(s_RefType));
                            }
                        }

                        if (!s_CreatedWithType)
                        {
                            s_CtrRef = s_FieldType != null
                                ? (CtrRefBase)Activator.CreateInstance(typeof(CtrRef<>).MakeGenericType(s_FieldType))
                                : new CtrRef<DataContainer>();
                        }

                        if ((s_ImportIndex & 0x80000000) != 0)
                        {
                            // External reference.
                            s_ImportIndex &= 0x7FFFFFFF;

                            var s_Import = m_ImportEntries[(int)s_ImportIndex];
                            s_Field.Value = s_Import;

                            s_CtrRef.SetValue(s_Import.PartitionGuid, s_Import.InstanceGuid);
                        }
                        else if (s_ImportIndex != 0)
                        {
                            if (s_ImportIndex > m_ParsingPartition.Instances.Count)
                            {
                                // Store for later resolution.
                                s_CtrRef.ImportIndex = s_ImportIndex;
                                m_LateResolveReferences.Add(s_CtrRef);
                            }
                            else
                            {
                                var s_Container = m_ParsingPartition.Instances[(int)(s_ImportIndex - 1)];
                                s_CtrRef.SetValue(s_Container.PartitionGuid, s_Container.InstanceGuid);
                            }
                        }
                        else
                        {
                            // We don't need to do anything here. This is a null pointer.
                        }

                        m_PopulatingArray?.Add(s_CtrRef);
                        m_CurrentContainer?.Bind(s_Field.Descriptor, s_CtrRef);
                        break;
                    }

                default:
                    {
                        Console.WriteLine("Unhandled FieldType: {0} ({1:X04})", s_Field.Descriptor.Flags.GetFieldType(), s_Field.Descriptor.Flags.FlagBits);
                        break;
                    }
            }

            //Debug.WriteLine("Finished parsing field '{0}' of type '{1}' with size {2}.", s_Field.Descriptor.Name, s_Field.Descriptor.Flags.GetFieldType(), m_Reader.BaseStream.Position - s_StartOffsetField);

            return s_Field;
        }

        private static Type GetNativeType(FieldDescriptor p_Descriptor)
        {
            switch (p_Descriptor.Flags.GetFieldType())
            {
                case FieldType.Array:
                    throw new Exception("Encountered array inside an array. Is this even supported?");
                //return typeof(IList);
                case FieldType.Boolean:
                    return typeof(bool);
                case FieldType.CString:
                    return typeof(string);
                case FieldType.Float32:
                    return typeof(float);
                case FieldType.Float64:
                    return typeof(double);
                case FieldType.Int8:
                    return typeof(sbyte);
                case FieldType.UInt8:
                    return typeof(byte);
                case FieldType.Int16:
                    return typeof(short);
                case FieldType.UInt16:
                    return typeof(ushort);
                case FieldType.Int32:
                    return typeof(int);
                case FieldType.UInt32:
                    return typeof(uint);
                case FieldType.Int64:
                    return typeof(long);
                case FieldType.UInt64:
                    return typeof(ulong);
                case FieldType.Guid:
                    return typeof(GUID);
                case FieldType.Sha1:
                    return typeof(Sha1);
                default:
                    return null;
            }
        }

        /// <summary>
        /// Check whether the provided file follows the Little Endian order.
        /// </summary>
        /// <param name="p_Data">File data</param>
        /// <returns></returns>
        private static bool LittleEndian(byte[] p_Data)
        {
            return p_Data[0] == 0xCE &&
                   p_Data[1] == 0xD1 &&
                   p_Data[2] == 0xB2 &&
                   p_Data[3] == 0x0F;
        }

        /// <summary>
        /// Check whether the provided file follows the Big Endian order.
        /// </summary>
        /// <param name="p_Data"></param>
        /// <returns></returns>
        private static bool BigEndian(byte[] p_Data)
        {
            return p_Data[3] == 0xCE &&
                   p_Data[2] == 0xD1 &&
                   p_Data[1] == 0xB2 &&
                   p_Data[0] == 0x0F;
        }
    }
}
