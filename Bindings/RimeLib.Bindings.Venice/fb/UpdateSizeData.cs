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
	[ContainerType(16), MemberInfoFlag(53), ContainerSize(64), ContainerClass]
	public class UpdateSizeData : 
		ProcessorData
	{
		protected Vec2 m_Pivot = new Vec2();
		[ContainerField(48), Homogeneous, LayoutImmutable, Blittable, MemberInfoFlag(53289), ContainerFieldNameHash(232602033)]
		public Vec2 Pivot { get { return m_Pivot; } set { if (OnPropertyChanging("UpdateSizeData." + nameof(Pivot), this, m_Pivot, value)) m_Pivot = value; } } // 0x30 (48)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 232602033:
					Pivot = (Vec2) p_Value;
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
				case 232602033:
					return Pivot;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 232602033:
					return typeof(UpdateSizeData).GetProperty(nameof(Pivot));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
