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
	public class InterfaceDescriptorData : 
		DynamicDataContainer
	{
		[ContainerField(12)]
		public List<DynamicEvent> InputEvents { get; set; } = new List<DynamicEvent>(); // 0xC (12)
		
		[ContainerField(16)]
		public List<DynamicEvent> OutputEvents { get; set; } = new List<DynamicEvent>(); // 0x10 (16)
		
		[ContainerField(20)]
		public List<DynamicLink> InputLinks { get; set; } = new List<DynamicLink>(); // 0x14 (20)
		
		[ContainerField(24)]
		public List<DynamicLink> OutputLinks { get; set; } = new List<DynamicLink>(); // 0x18 (24)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 1542460652:
					InputEvents = (List<DynamicEvent>) p_Value;
					break;

				case 3452448709:
					OutputEvents = (List<DynamicEvent>) p_Value;
					break;

				case 1626510432:
					InputLinks = (List<DynamicLink>) p_Value;
					break;

				case 748160425:
					OutputLinks = (List<DynamicLink>) p_Value;
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
				case 1542460652:
					return InputEvents;

				case 3452448709:
					return OutputEvents;

				case 1626510432:
					return InputLinks;

				case 748160425:
					return OutputLinks;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 1542460652:
					return typeof(InterfaceDescriptorData).GetProperty(nameof(InputEvents));

				case 3452448709:
					return typeof(InterfaceDescriptorData).GetProperty(nameof(OutputEvents));

				case 1626510432:
					return typeof(InterfaceDescriptorData).GetProperty(nameof(InputLinks));

				case 748160425:
					return typeof(InterfaceDescriptorData).GetProperty(nameof(OutputLinks));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
