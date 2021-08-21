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
	[ContainerType(Alignment: 8,  Flags: 53, Size: 16)]
	public class MetricEvent : 
		DataContainer
	{
		protected ulong m_Owner = new ulong();
		[ContainerField(Name: "Owner", Offset: 8, NameHash: 217695012, Flags: 49453), LayoutImmutable, Blittable]
		public ulong Owner { get { return m_Owner; } set { if (OnPropertyChanging("MetricEvent." + nameof(Owner), this, m_Owner, value)) m_Owner = value; } } // 0x8 (8)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 217695012:
					Owner = (ulong) p_Value;
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
				case 217695012:
					return Owner;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 217695012:
					return typeof(MetricEvent).GetProperty(nameof(Owner));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
