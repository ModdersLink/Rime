using RimeLib.Extensions;
using RimeLib.Frostbite.Core;
using RimeLib.IO;
using RimeLib.Serialization.Attributes;
using RimeLib.Serialization.Containers;
using RimeLib.Serialization.Ebx;
using RimeLib.Serialization.Frostbite2_0.Ebx;
using RimeLib.Utils;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography;
using System.Text;
using MemberType = RimeLib.Frostbite.Core.MemberType;
using TypeCategory = RimeLib.Frostbite.Core.TypeCategory;

namespace RimeLib.Serialization.Frostbite2_0
{
    public class PartitionSerializer
    {
        private ISerializationContext m_Context;
        private StreamingPartitionHeader m_Header = new StreamingPartitionHeader();

        public const uint c_PartitionMagicLE = 0x0fb2d1ce;
        public const uint c_PartitionMagicBE = 0;

        public PartitionSerializer(ISerializationContext p_Context)
        {
            m_Context = p_Context;
        }

        public void SerializePartition(FrostbitePartition p_Partition, bool p_BigEndian = false)
        {
            // Set the header magic
            m_Header.Magic = p_BigEndian ? c_PartitionMagicBE : c_PartitionMagicLE;

            // TODO: Calculate the metasize

            // TODO: Calculate the payload size

            // TODO: Calculate the import count
            var s_ImportEntries = new List<ImportEntry>();

            var s_ImportCount = p_Partition.Instances.Sum(p_Instance => p_Instance.GetImportCount());

            // Iterate through each of the instances
            foreach (var s_Instance in p_Partition.Instances)
            {
                // Iterate through each of the properties
                foreach (var s_Property in s_Instance.GetType().GetProperties())
                {
                    // Check to see if this property is browsable or not
                    var s_Browsable = (BrowsableAttribute[])s_Property.GetCustomAttributes(typeof(BrowsableAttribute), false);
                    var s_NotBrowsable = s_Browsable.Any(p_Attr => !p_Attr.Browsable);
                    if (s_NotBrowsable)
                        continue;

                    // Check to ensure that this property has a ContainerField attribute
                    var s_FieldAttributes = s_Property.GetCustomAttribute<ContainerFieldAttribute>();
                    if (s_FieldAttributes == null)
                        continue;

                    // Make sure we can cast to a CtrRefBase
                    if (!typeof(CtrRefBase).IsAssignableFrom(s_Property.PropertyType))
                        continue;

                    // Get the actual CtrRefBase object
                    var s_Value = s_Property.GetValue(s_Instance);
                    if (s_Value == null)
                        continue;

                    // Cast the CtrRefBase type
                    var s_CtrRef = (CtrRefBase)s_Value;

                    // Make sure that the reference points to something
                    if (s_CtrRef.PartitionGuid == GUID.Empty || s_CtrRef.InstanceGuid == GUID.Empty)
                        continue;

                    s_ImportEntries.Add(new ImportEntry(s_CtrRef));
                }
            }

            // Dictionary with string, offset
            var s_TypeStrings = new Dictionary<string, long>();
            var s_TypeStringsLength = 0;

            // Iterate through each of the instances
            foreach (var s_Instance in p_Partition.Instances)
            {
                // Iterate over all properties
                // C# Properties == Frostbite Fields (in all? cases)
                foreach (var s_Property in s_Instance.GetType().GetProperties())
                {
                    // Check to see if this property is browsable or not
                    var s_Browsable = (BrowsableAttribute[])s_Property.GetCustomAttributes(typeof(BrowsableAttribute), false);
                    var s_NotBrowsable = s_Browsable.Any(p_Attr => !p_Attr.Browsable);
                    if (s_NotBrowsable)
                        continue;

                    // Check to ensure that this property has a ContainerField attribute
                    var s_FieldAttributes = s_Property.GetCustomAttribute<ContainerFieldAttribute>();
                    if (s_FieldAttributes == null)
                        continue;

                    // Get the field offset
                    var s_Offset = s_FieldAttributes.FieldOffset;

                    // Handle typestrings
                    var s_PropertyType = s_Property.PropertyType;


                    // Handle arrays
                    if (s_Property.GetCustomAttribute<ContainerCtrRef>() != null ||
                        s_Property.GetCustomAttribute<ContainerRefArray>() != null ||
                        s_Property.GetCustomAttribute<ContainerArray>() != null)
                    {
                        // Read the array type
                        // Note: Is this an okay assumption to make?
                        var s_TypeString = s_PropertyType.GetGenericArguments().FirstOrDefault()?.Name;
                        if (s_TypeStrings.ContainsKey(s_TypeString))
                            continue;

                        // Check if the typestring has already been added
                        if (s_TypeStrings.ContainsKey(s_TypeString))
                            continue;

                        // Add the typestring at the current offset (s_TypeStringsLength)
                        s_TypeStrings.Add(s_TypeString, s_TypeStringsLength);

                        // Increment the length of the type string + 1 null character
                        s_TypeStringsLength += s_TypeString.Length + 1;
                    }
                    else // Handle POD
                    {
                        // Get the type string
                        var s_TypeString = s_Property.PropertyType.Name;

                        // Check if the type string has already been added
                        if (s_TypeStrings.ContainsKey(s_TypeString))
                            continue;

                        // Add the type strings + offset
                        s_TypeStrings.Add(s_TypeString, s_TypeStringsLength);

                        // Increase the blob length offset
                        s_TypeStringsLength += s_TypeString.Length + 1;
                    }

                    //// Alright at this point we already have the string table built, cool
                    //// The next is creating the field descriptors so frostbite knows what good crack to smoke
                    //// when we build our own stuff for it

                    //// Handle field descriptors
                    //if (s_PropertyType.IsGenericType && (s_PropertyType.GetGenericTypeDefinition() == typeof(CtrRef<>)))
                    //{
                    //    // Triple check this ish
                    //    if (!typeof(CtrRef<>).IsGenericAssignableFrom(s_Property.PropertyType))
                    //        throw new Exception();

                    //    // Cast it to a CtrRefBase
                    //    var s_CtrRefBase = s_Property.GetValue(s_Instance) as CtrRefBase;



                    //    // Check to see if this is a null reference
                    //    if (s_CtrRefBase?.IsNull() ?? true)
                    //    {
                    //        // TODO: Handle null references
                    //    }

                    //    // Next check to see if this was imported from another partition
                    //    var s_Internal = p_Partition.Instances.Any(p_Instance => p_Instance.PartitionGuid == s_CtrRefBase.PartitionGuid);
                    //    if (!s_Internal)
                    //    {
                    //        // TODO: Handle an imported reference
                    //    }
                    //    else
                    //    {
                    //        // TODO: handle internal reference
                    //    }
                    //}


                    //// Get the type from our data type
                    //// TODO: Determine how to set MemberType
                    //// It's either Field or TypeInfo
                    //var s_MemberType = MemberTypeEnum.Field; // MemberType.TypeInfo
                    //var s_FieldType = GetFieldType(s_Property.GetValue(s_Instance));
                    //var s_TypeCategory = TypeCategoryEnum.NotApplicable;

                    //var s_MemberInfoFlags = new MemberInfoFlags(
                    //    (ushort)(((ushort)s_MemberType & 3) |
                    //    (((ushort)s_TypeCategory & 3) << 2) |
                    //    (((ushort)s_FieldType & 0x1F) << 4))
                    //    );
                    //// MemberInfoFlags is ushort in length
                    //// 16============================0
                    //// 0 0 0 0 0 0 0 F F F F F C C M M
                    //// F = FieldType    (5-bits)
                    //// C = TypeCategory (2-bits)
                    //// M = MemberType   (2-bits)

                    //var s_FieldDescriptor = new FieldDescriptor
                    //{
                    //    FieldType = (ushort)s_FieldType,
                    //    Flags = s_MemberInfoFlags,
                    //    Name = "",
                    //    NameHash = FbUtils.HashQuick(""),
                    //    Offset = 0,
                    //    SecondaryOffset = 0
                    //};
                }
            }

            // Write out the string table block for this partition
            using (var s_Writer = new RimeWriter(new MemoryStream()))
            {
                foreach (var l_Pair in s_TypeStrings)
                {
                    s_Writer.Seek(l_Pair.Value, SeekOrigin.Begin);
                    s_Writer.WriteNullTerminatedString(l_Pair.Key);
                }

                var s_Data = ((MemoryStream)s_Writer.BaseStream).ToArray();
            }

            // Create the field entries per instance
            foreach (var s_Instance in p_Partition.Instances)
            {
                var s_InstanceFieldDescriptors = new List<FieldDescriptor>();

                // Iterate over each property
                foreach (var s_Property in s_Instance.GetType().GetProperties())
                {
                    // Check to see if this property is browsable or not
                    var s_Browsable = (BrowsableAttribute[])s_Property.GetCustomAttributes(typeof(BrowsableAttribute), false);
                    var s_NotBrowsable = s_Browsable.Any(p_Attr => !p_Attr.Browsable);
                    if (s_NotBrowsable)
                        continue;

                    // Check to ensure that this property has a ContainerField attribute
                    var s_FieldAttributes = s_Property.GetCustomAttribute<ContainerFieldAttribute>();
                    if (s_FieldAttributes == null)
                        continue;

                    // Get the member info flag attributes
                    var s_MemberInfoFlagAttribute = s_Property.GetCustomAttribute<MemberInfoFlagAttribute>();
                    if (s_MemberInfoFlagAttribute == null)
                    {
                        Debug.WriteLine("invalid member info flag attribute.");
                        continue;
                    }

                    var s_MemberInfoFlags = new MemberInfoFlags(s_MemberInfoFlagAttribute.Flag);
                    s_InstanceFieldDescriptors.Add(new FieldDescriptor
                    {
                        Flags = s_MemberInfoFlags,
                        Name = s_Property.Name,
                        NameHash = FbUtils.HashQuick(s_Property.Name),
                        Offset = (int)s_FieldAttributes.FieldOffset,
                        SecondaryOffset = 0,
                        FieldType = 0 // This is set in a second pass, this is a index into the field descriptor types
                    });
                }
            }
            //var s_ImportEntry = new ImportEntry(

            var s_TotalPossibleImports = p_Partition.Instances.Sum(p_Instance => p_Instance.GetImportCount(true));

            /*
             * This is done by going through the primary partition's references anywhere inside the data
             * and figuring out how many CtrRef's point to something that's external
             * 
             * TODO: Verify that it's only CtrRef's that cause this
            */

            // TODO: Calculate the types
        }
    }

}
