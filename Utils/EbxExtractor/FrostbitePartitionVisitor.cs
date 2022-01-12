/*
using RimeLib.Frostbite.Core;
using RimeLib.Serialization.Ebx;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using RimeLib.Serialization.Attributes;
using RimeLib.Frostbite.Containers;
using System.ComponentModel;

namespace EbxExtractor
{
    class FrostbitePartitionVisitor
    {
        // Currently visiting partition
        private FrostbiteContainer m_Partition;

        public FrostbitePartitionVisitor(FrostbiteContainer p_Partition)
        {
            m_Partition = p_Partition;
        }


        public MemberInfoFlags GetMemberInfoFlags()
        {
            return default;
        }

        public Type GetCsType()
        {
            throw new NotImplementedException();
        }

        public void Iterate()
        {
            /*var s_PartitionType = m_Partition.GetType();
            var s_Name = s_PartitionType.Name;

            var s_ContainerTypeAttribute = s_PartitionType.GetCustomAttribute<ContainerTypeAttribute>();
            if (s_ContainerTypeAttribute == null)
                throw new InvalidOperationException("Attempted to iterate on a type without a ContainerTypeAttribute");

            var s_MemberInfoFlags = new MemberInfoFlags(s_ContainerTypeAttribute.Flags);

            var s_Category = s_MemberInfoFlags.GetTypeCategory();
            var s_MemberType = s_MemberInfoFlags.GetMemberType();
            var s_FieldType = s_MemberInfoFlags.GetFieldType();

            Console.WriteLine($"{s_Name}: Category: {s_Category} MemberType: {s_MemberType} FieldType: {s_FieldType}");

            // Iterate each of the field types
            var s_Properties = s_PartitionType.GetProperties(BindingFlags.Public | BindingFlags.Instance);

            foreach (var s_Property in s_Properties)
            {
                var s_BrowsableAttribute = s_Property.GetCustomAttribute<BrowsableAttribute>();
                if (s_BrowsableAttribute != null)
                {
                    if (!s_BrowsableAttribute.Browsable)
                        continue;
                }

                var s_PropertyAttribute = s_Property.GetCustomAttribute<ContainerFieldAttribute>();
                if (s_PropertyAttribute == null)
                    throw new InvalidOperationException("Attempted to iterate on a property without a container field type.");

                var s_PropertyValue = s_Property.GetValue(m_Partition);
                ushort s_ValueSize = 0;
                if (s_PropertyValue != null)
                {
                    var s_ValueAttribute = s_PropertyValue.GetType().GetCustomAttribute<ContainerTypeAttribute>();
                    if (s_ValueAttribute != null)
                        s_ValueSize = s_ValueAttribute.Size;
                }

                Console.WriteLine($"\t{s_PropertyAttribute.FieldName}: Offset: {s_PropertyAttribute.FieldOffset} Flags: {s_PropertyAttribute.FieldFlags} Size: {s_ValueSize}");

                
            }#1#
        }
    }
}
*/
