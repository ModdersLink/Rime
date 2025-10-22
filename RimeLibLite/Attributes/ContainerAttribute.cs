using System;
using System.Runtime.CompilerServices;
using RimeLib.Frostbite.Core;

namespace RimeLib.Serialization.Attributes
{
    /// <summary>
    /// Attribute information for the container type
    /// </summary>
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Enum | AttributeTargets.Struct | AttributeTargets.Interface | AttributeTargets.Delegate)]
    public class ContainerTypeAttribute : Attribute
    {
        /// <summary>
        /// Alignment for this data
        /// </summary>
        public byte DataAlignment { get; set; }

        /// <summary>
        /// Size of this data
        /// NOTE: FBCCompiler will need to be updated once working
        /// </summary>
        public ushort Size { get; set; }

        public ushort AlignedSize
        {
            get
            {
                var s_BytesToAlign = Size % DataAlignment;

                if (s_BytesToAlign == 0)
                    return Size;

                return (ushort) (Size + (DataAlignment - s_BytesToAlign));
            }
        }

        /// <summary>
        /// Default constructor that takes an alignment
        /// NOTE: FBCCompiler will need to be updated once working
        /// </summary>
        /// <param name="Alignment">Default alignment: 0</param>
        /// <param name="p_Size">Size of this container</param>
        /// <param name="p_Flags">Member information flags of this container</param>
        public ContainerTypeAttribute(byte p_Alignment, ushort p_Size)
        {
            DataAlignment = p_Alignment;
            Size = p_Size;
        }
    }
    
    
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Enum | AttributeTargets.Struct | AttributeTargets.Interface | AttributeTargets.Delegate)]
    public class ContainerIdAttribute : Attribute
    {
        /// <summary>
        /// Type guid.
        /// md5(md5(moduleName.tolower()) + typeName.tolower())
        /// hashcat -m 20
        /// </summary>
        public GUID Guid { get; set; }

        /// <summary>
        /// Signature
        /// </summary>
        public uint Signature { get; set; }


        /// <summary>
        /// Default constructor that takes an alignment
        /// </summary>
        /// <param name="p_Guid">type guid</param>
        /// <param name="p_Signature">Type signature</param>
        public ContainerIdAttribute(string p_Guid, uint p_Signature=0)
        {
            Guid = new GUID(p_Guid);
            Signature = p_Signature;
        }
    }

    /// <summary>
    /// Attributes for container fields
    /// </summary>
    [AttributeUsage(AttributeTargets.Property)]
    public class ContainerFieldAttribute : Attribute
    {
        /// <summary>
        /// Offset for this field
        /// </summary>
        public uint Offset { get; }

        public string Name { get; set; }

        /// <summary>
        /// Constructor taking a name and offset
        /// </summary>
        /// <param name="Name">Name of this field</param>
        /// <param name="Offset">Offset of this field</param>
	    public ContainerFieldAttribute(uint p_Offset, [CallerMemberName] string p_Name = "")
        {
            Offset = p_Offset;
            Name = p_Name;
        }
    }

    /// <summary>
    /// Attributes for Homogeneous
    /// </summary>
	[AttributeUsage(AttributeTargets.Property | AttributeTargets.Class | AttributeTargets.Enum | AttributeTargets.Struct)]
    public class HomogeneousAttribute : Attribute
    {
    }

    /// <summary>
    /// Attributes for objects that layout should be immutable
    /// </summary>
	[AttributeUsage(AttributeTargets.Property | AttributeTargets.Class | AttributeTargets.Enum | AttributeTargets.Struct)]
    public class LayoutImmutableAttribute : Attribute
    {
    }

    /// <summary>
    /// Attributes for objects that are blittable
    /// </summary>
	[AttributeUsage(AttributeTargets.Property | AttributeTargets.Class | AttributeTargets.Enum | AttributeTargets.Struct)]
    public class BlittableAttribute : Attribute
    {
    }

}
