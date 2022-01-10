using System;

namespace RimeLib.Serialization.Attributes
{
    /// <summary>
    /// Attribute information for the container type
    /// </summary>
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Enum | AttributeTargets.Struct)]
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

        public ushort AlignedSize => (ushort)(Size + (DataAlignment - (Size % DataAlignment)));

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

    [AttributeUsage(AttributeTargets.Property)]
    public class ContainerRefArray : Attribute
    {
    }

    [AttributeUsage(AttributeTargets.Property)]
    public class ContainerCtrRef : Attribute
    {
    }

    [AttributeUsage(AttributeTargets.Property)]
    public class ContainerArray : Attribute
    {
    }

    /// <summary>
    /// Attributes for name hash
    /// </summary>
    [AttributeUsage(AttributeTargets.Property)]
    public class ContainerFieldNameHash : Attribute
    {
        public uint NameHash { get; set; }

        public ContainerFieldNameHash(uint p_NameHash = 0)
        {
            NameHash = 0;
        }

        public ContainerFieldNameHash(string p_Name)
        {
            NameHash = Frostbite.Utils.HashQuick(p_Name);
        }
    }

    [AttributeUsage(AttributeTargets.Property | AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Enum)]
    public class MemberInfoFlagAttribute : Attribute
    {
        public ushort Flag { get; set; }
        public MemberInfoFlagAttribute(ushort p_Flags = 0)
        {
            Flag = p_Flags;
        }
    }

    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Enum)]
    public class ContainerSizeAttribute : Attribute
    {
        public ushort Size { get; set; }
        public ContainerSizeAttribute(ushort p_Size = 0)
        {
            Size = p_Size;
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
        public uint FieldOffset { get; set; }

        /// <summary>
        /// Constructor taking a name and offset
        /// </summary>
        /// <param name="Name">Name of this field</param>
        /// <param name="Offset">Offset of this field</param>
	    public ContainerFieldAttribute(uint p_Offset)
        {
            FieldOffset = p_Offset;
        }
    }

    /// <summary>
    /// Attributes for metadata
    /// </summary>
	[AttributeUsage(AttributeTargets.Property | AttributeTargets.Class | AttributeTargets.Enum | AttributeTargets.Struct)]
    public class MetadataAttribute : Attribute
    {
    }

    /// <summary>
    /// Attributes for Homogeneous
    /// </summary>
	[AttributeUsage(AttributeTargets.Property | AttributeTargets.Class | AttributeTargets.Enum | AttributeTargets.Struct)]
    public class HomogeneousAttribute : Attribute
    {
    }

    /// <summary>
    /// Attributes for objects that should always persist
    /// </summary>
	[AttributeUsage(AttributeTargets.Property)]
    public class AlwaysPersistAttribute : Attribute
    {
    }

    /// <summary>
    /// Attributes for objects that should be exposed
    /// </summary>
	[AttributeUsage(AttributeTargets.Property)]
    public class ExposedAttribute : Attribute
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
