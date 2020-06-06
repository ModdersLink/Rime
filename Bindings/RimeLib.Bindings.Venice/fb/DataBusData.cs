///////////////////////////////////////////////////////////////
//                                                           //
// This is an automatically generated file.                  //
// Do *NOT* modify unless you really know what you're doing. //
//                                                           //
///////////////////////////////////////////////////////////////

using System.Collections.Generic;
using System.Reflection;using RimeLib.Serialization.Attributes;using RimeLib.Serialization.Ebx;using RimeLib.Serialization.Containers;using RimeLib.Frostbite.Core;

namespace fb
{
    [ContainerType(4)]
	public class DataBusData : 
		Asset
	{
		[ContainerField(12)]
		public List<PropertyConnection> PropertyConnections { get; set; } = new List<PropertyConnection>(); // 0xC (12)
		
		[ContainerField(16)]
		public List<LinkConnection> LinkConnections { get; set; } = new List<LinkConnection>(); // 0x10 (16)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 1023567943:
					PropertyConnections = (List<PropertyConnection>) p_Value;
					break;

				case 1859919712:
					LinkConnections = (List<LinkConnection>) p_Value;
					break;

				default:
					base.Bind(p_Descriptor, p_Value);
					break;
			}
		}

		public override object GetFieldValueByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 1023567943:
					return PropertyConnections;

				case 1859919712:
					return LinkConnections;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 1023567943:
					return typeof(DataBusData).GetProperty(nameof(PropertyConnections));

				case 1859919712:
					return typeof(DataBusData).GetProperty(nameof(LinkConnections));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
