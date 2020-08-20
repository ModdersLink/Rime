using RimeLib.Frostbite.Core;
using RimeLib.Serialization.Attributes;
using RimeLib.Serialization.Ebx;
using RimeLib.Serialization.Frostbite2_0.Ebx;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Text;

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

                    var s_PropertyType = s_Property.PropertyType;
                    if (s_PropertyType.IsGenericType && s_PropertyType.GetGenericTypeDefinition() == typeof(List<>))
                    {
                        var s_TypeString = s_PropertyType.GetGenericArguments().FirstOrDefault()?.Name;

                        if (s_TypeStrings.ContainsKey(s_TypeString))
                            continue;

                        s_TypeStrings.Add(s_TypeString, s_TypeStringsLength);

                        s_TypeStringsLength += s_TypeString.Length + 1;
                    }
                    else if (s_PropertyType.IsGenericType && s_PropertyType.GetGenericTypeDefinition() == typeof(CtrRef<>))
                    {
                        var s_TypeString = s_PropertyType.GetGenericArguments().FirstOrDefault()?.Name;

                        if (s_TypeStrings.ContainsKey(s_TypeString))
                            continue;

                        s_TypeStrings.Add(s_TypeString, s_TypeStringsLength);

                        s_TypeStringsLength += s_TypeString.Length + 1;
                    }
                    else if (s_PropertyType.IsGenericType && s_PropertyType.GetGenericTypeDefinition() == typeof(RefArray<>))
                    {
                        var s_TypeString = s_PropertyType.GetGenericArguments().FirstOrDefault()?.Name;

                        if (s_TypeStrings.ContainsKey(s_TypeString))
                            continue;

                        s_TypeStrings.Add(s_TypeString, s_TypeStringsLength);

                        s_TypeStringsLength += s_TypeString.Length + 1;
                    }
                    else
                    {
                        // Get the type string
                        var s_TypeString = s_Property.PropertyType.Name;

                        if (s_TypeStrings.ContainsKey(s_TypeString))
                            continue;

                        // Add the type strings + offset
                        s_TypeStrings.Add(s_TypeString, s_TypeStringsLength);

                        // Increase the blob length offset
                        s_TypeStringsLength += s_TypeString.Length + 1;
                    }
                }
            }

            // Create the field entries per instance
            foreach (var s_Instance in p_Partition.Instances)
            {
                var s_FieldDescriptor = new FieldDescriptor();
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
