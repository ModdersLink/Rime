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

        /// <summary>
        /// Member information flags
        /// </summary>
        public ushort Flags { get; set; }

        /// <summary>
        /// Default constructor that takes an alignment
        /// NOTE: FBCCompiler will need to be updated once working
        /// </summary>
        /// <param name="Alignment">Default alignment: 0</param>
        /// <param name="p_Size">Size of this container</param>
        /// <param name="p_Flags">Member information flags of this container</param>
        public ContainerTypeAttribute(byte Alignment = 0, ushort Size = 0, ushort Flags = 0)
        {
            DataAlignment = Alignment;
            this.Size = Size;
            this.Flags = Flags;
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
        /// Name of this field
        /// </summary>
		public string FieldName { get; set; }

        /// <summary>
        /// Fnv hash of the name of this field
        /// </summary>
        public uint FieldNameHash { get; set; }

        /// <summary>
        /// Member info flags for this field
        /// </summary>
        public ushort FieldFlags { get; set; }

        /// <summary>
        /// Default constructor
        /// </summary>
        /// <param name="Offset">Offset of this field, default: 0</param>
		//public ContainerFieldAttribute(uint Offset = 0)
  //      {
  //          FieldOffset = Offset;
  //          FieldName = string.Empty;
  //          FieldNameHash = 0;
  //          FieldFlags = 0;
  //      }

        /// <summary>
        /// Constructor taking a name and offset
        /// </summary>
        /// <param name="Name">Name of this field</param>
        /// <param name="Offset">Offset of this field</param>
	    public ContainerFieldAttribute(string Name, uint Offset = 0, uint NameHash = 0, ushort Flags = 0)
        {
            FieldOffset = Offset;
            FieldName = Name;
            FieldNameHash = NameHash;
            FieldFlags = Flags;
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
