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
	[ContainerType(Alignment: 16,  Flags: 53, Size: 80)]
	public class PlayerLookAtEntityData : 
		EntityData
	{
		protected LinearTransform m_TargetTransform = new LinearTransform();
		[ContainerField(Name: "TargetTransform", Offset: 16, NameHash: 927994776, Flags: 53289), Homogeneous, LayoutImmutable, Blittable]
		public LinearTransform TargetTransform { get { return m_TargetTransform; } set { if (OnPropertyChanging("PlayerLookAtEntityData." + nameof(TargetTransform), this, m_TargetTransform, value)) m_TargetTransform = value; } } // 0x10 (16)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 927994776:
					TargetTransform = (LinearTransform) p_Value;
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
				case 927994776:
					return TargetTransform;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 927994776:
					return typeof(PlayerLookAtEntityData).GetProperty(nameof(TargetTransform));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
