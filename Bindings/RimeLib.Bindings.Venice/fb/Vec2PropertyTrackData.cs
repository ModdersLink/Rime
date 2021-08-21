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
	[ContainerType(Alignment: 4,  Flags: 53, Size: 24)]
	public class Vec2PropertyTrackData : 
		SimplePropertyTrackData
	{
		protected List<Vec2> m_Values = new List<Vec2>();
		[ContainerField(Name: "Values", Offset: 20, NameHash: 3142410589, Flags: 65)]
		public List<Vec2> Values { get { return m_Values; } set { if (OnPropertyChanging("Vec2PropertyTrackData." + nameof(Values), this, m_Values, value)) m_Values = value; } } // 0x14 (20)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 3142410589:
					Values = (List<Vec2>) p_Value;
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
				case 3142410589:
					return Values;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 3142410589:
					return typeof(Vec2PropertyTrackData).GetProperty(nameof(Values));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
