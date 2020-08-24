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
	[ContainerType(4), MemberInfoFlag(53), ContainerClass]
	public class WeaponZoomModifier : 
		WeaponModifierBase
	{
		protected float m_ZoomRenderFov = new float();
		[ContainerField(8), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(956290279)]
		public float ZoomRenderFov { get { return m_ZoomRenderFov; } set { if (OnPropertyChanging("WeaponZoomModifier." + nameof(ZoomRenderFov), this, m_ZoomRenderFov, value)) m_ZoomRenderFov = value; } } // 0x8 (8)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 956290279:
					ZoomRenderFov = (float) p_Value;
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
				case 956290279:
					return ZoomRenderFov;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 956290279:
					return typeof(WeaponZoomModifier).GetProperty(nameof(ZoomRenderFov));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
