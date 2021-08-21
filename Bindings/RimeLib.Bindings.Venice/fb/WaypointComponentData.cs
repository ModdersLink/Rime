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
	[ContainerType(Alignment: 16,  Flags: 53, Size: 112)]
	public class WaypointComponentData : 
		ComponentData
	{
		protected bool m_Looping = new bool();
		[ContainerField(Name: "Looping", Offset: 96, NameHash: 1366646169, Flags: 49325), LayoutImmutable, Blittable]
		public bool Looping { get { return m_Looping; } set { if (OnPropertyChanging("WaypointComponentData." + nameof(Looping), this, m_Looping, value)) m_Looping = value; } } // 0x60 (96)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 1366646169:
					Looping = (bool) p_Value;
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
				case 1366646169:
					return Looping;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 1366646169:
					return typeof(WaypointComponentData).GetProperty(nameof(Looping));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
