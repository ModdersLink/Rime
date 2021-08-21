///////////////////////////////////////////////////////////////
//                                                           //
// This is an automatically generated file.                  //
// Do *NOT* modify unless you really know what you're doing. //
//                                                           //
///////////////////////////////////////////////////////////////

using RimeLib.IO;
using RimeLib.Frostbite.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel;
using System.Reflection;
using RimeLib.Serialization.Attributes;
using RimeLib.Frostbite.Containers;
using RimeLib.Serialization.Ebx;

namespace fb
{
	[ContainerType(Alignment: 4,  Flags: 53, Size: 28)]
	public class InterfaceDescriptorData : 
		DynamicDataContainer
	{
		protected List<DynamicEvent> m_InputEvents = new List<DynamicEvent>();
		[ContainerField(Name: "InputEvents", Offset: 12, NameHash: 1542460652, Flags: 65)]
		public List<DynamicEvent> InputEvents { get { return m_InputEvents; } set { if (OnPropertyChanging("InterfaceDescriptorData." + nameof(InputEvents), this, m_InputEvents, value)) m_InputEvents = value; } } // 0xC (12)
		
		protected List<DynamicEvent> m_OutputEvents = new List<DynamicEvent>();
		[ContainerField(Name: "OutputEvents", Offset: 16, NameHash: 3452448709, Flags: 65)]
		public List<DynamicEvent> OutputEvents { get { return m_OutputEvents; } set { if (OnPropertyChanging("InterfaceDescriptorData." + nameof(OutputEvents), this, m_OutputEvents, value)) m_OutputEvents = value; } } // 0x10 (16)
		
		protected List<DynamicLink> m_InputLinks = new List<DynamicLink>();
		[ContainerField(Name: "InputLinks", Offset: 20, NameHash: 1626510432, Flags: 65)]
		public List<DynamicLink> InputLinks { get { return m_InputLinks; } set { if (OnPropertyChanging("InterfaceDescriptorData." + nameof(InputLinks), this, m_InputLinks, value)) m_InputLinks = value; } } // 0x14 (20)
		
		protected List<DynamicLink> m_OutputLinks = new List<DynamicLink>();
		[ContainerField(Name: "OutputLinks", Offset: 24, NameHash: 748160425, Flags: 65)]
		public List<DynamicLink> OutputLinks { get { return m_OutputLinks; } set { if (OnPropertyChanging("InterfaceDescriptorData." + nameof(OutputLinks), this, m_OutputLinks, value)) m_OutputLinks = value; } } // 0x18 (24)
		
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
