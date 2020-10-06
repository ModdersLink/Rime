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
	[ContainerType(4), MemberInfoFlag(53), ContainerSize(12), ContainerClass]
	public class WeaponClassModifier : 
		WeaponModifierBase
	{
		protected WeaponClassEnum m_WeaponClass = new WeaponClassEnum();
		[ContainerField(8), MemberInfoFlag(137), ContainerFieldNameHash(711657993)]
		public WeaponClassEnum WeaponClass { get { return m_WeaponClass; } set { if (OnPropertyChanging("WeaponClassModifier." + nameof(WeaponClass), this, m_WeaponClass, value)) m_WeaponClass = value; } } // 0x8 (8)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 711657993:
					WeaponClass = (WeaponClassEnum) Enum.ToObject(typeof(WeaponClassEnum), p_Value);
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
				case 711657993:
					return WeaponClass;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 711657993:
					return typeof(WeaponClassModifier).GetProperty(nameof(WeaponClass));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
