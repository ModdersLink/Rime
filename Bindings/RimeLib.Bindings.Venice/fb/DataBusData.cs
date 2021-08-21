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
	[ContainerType(Alignment: 4,  Flags: 53, Size: 20)]
	public class DataBusData : 
		Asset
	{
		protected List<PropertyConnection> m_PropertyConnections = new List<PropertyConnection>();
		[ContainerField(Name: "PropertyConnections", Offset: 12, NameHash: 1023567943, Flags: 65)]
		public List<PropertyConnection> PropertyConnections { get { return m_PropertyConnections; } set { if (OnPropertyChanging("DataBusData." + nameof(PropertyConnections), this, m_PropertyConnections, value)) m_PropertyConnections = value; } } // 0xC (12)
		
		protected List<LinkConnection> m_LinkConnections = new List<LinkConnection>();
		[ContainerField(Name: "LinkConnections", Offset: 16, NameHash: 1859919712, Flags: 65)]
		public List<LinkConnection> LinkConnections { get { return m_LinkConnections; } set { if (OnPropertyChanging("DataBusData." + nameof(LinkConnections), this, m_LinkConnections, value)) m_LinkConnections = value; } } // 0x10 (16)
		
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
