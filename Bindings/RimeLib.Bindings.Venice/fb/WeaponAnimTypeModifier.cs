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
	[ContainerType(Alignment: 4,  Flags: 53, Size: 12)]
	public class WeaponAnimTypeModifier : 
		WeaponModifierBase
	{
		protected WeaponAnimType m_WeaponAnimType = new WeaponAnimType();
		[ContainerField(Name: "WeaponAnimType", Offset: 8, NameHash: 2116604244, Flags: 137)]
		public WeaponAnimType WeaponAnimType { get { return m_WeaponAnimType; } set { if (OnPropertyChanging("WeaponAnimTypeModifier." + nameof(WeaponAnimType), this, m_WeaponAnimType, value)) m_WeaponAnimType = value; } } // 0x8 (8)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 2116604244:
					WeaponAnimType = (WeaponAnimType) Enum.ToObject(typeof(WeaponAnimType), p_Value);
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
				case 2116604244:
					return WeaponAnimType;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 2116604244:
					return typeof(WeaponAnimTypeModifier).GetProperty(nameof(WeaponAnimType));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
