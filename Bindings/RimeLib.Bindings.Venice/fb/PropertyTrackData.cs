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
using RimeLib.Serialization.Containers;
using RimeLib.Serialization.Ebx;

namespace fb
{
	[ContainerType(4)]
	public class PropertyTrackData : 
		DataContainer
	{
		protected int m_Id = new int();
		[ContainerField(8), LayoutImmutable, Blittable, ContainerFieldNameHash(5862152)]
		public int Id { get { return m_Id; } set { if (OnPropertyChanging("PropertyTrackData." + nameof(Id), this, m_Id, value)) m_Id = value; } } // 0x8 (8)
		
		protected List<int> m_Times = new List<int>();
		[ContainerField(12), ContainerFieldNameHash(227876771)]
		public List<int> Times { get { return m_Times; } set { if (OnPropertyChanging("PropertyTrackData." + nameof(Times), this, m_Times, value)) m_Times = value; } } // 0xC (12)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 5862152:
					Id = (int) p_Value;
					break;

				case 227876771:
					Times = (List<int>) p_Value;
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
				case 5862152:
					return Id;

				case 227876771:
					return Times;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 5862152:
					return typeof(PropertyTrackData).GetProperty(nameof(Id));

				case 227876771:
					return typeof(PropertyTrackData).GetProperty(nameof(Times));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
