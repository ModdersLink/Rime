using System;
using System.Collections.Generic;
using System.Text;

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
        /// Default constructor that takes an alignment
        /// </summary>
        /// <param name="Alignment">Default alignment: 0</param>
        public ContainerTypeAttribute(byte Alignment = 0)
        {
            DataAlignment = Alignment;
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
        /// Default constructor
        /// </summary>
        /// <param name="Offset">Offset of this field, default: 0</param>
		public ContainerFieldAttribute(uint Offset = 0)
        {
            FieldOffset = Offset;
            FieldName = string.Empty;
        }

        /// <summary>
        /// Constructor taking a name and offset
        /// </summary>
        /// <param name="Name">Name of this field</param>
        /// <param name="Offset">Offset of this field</param>
	    public ContainerFieldAttribute(string Name, uint Offset = 0)
        {
            FieldOffset = Offset;
            FieldName = Name;
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
