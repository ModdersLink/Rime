///////////////////////////////////////////////////////////////
//                                                           //
// This is an automatically generated file.                  //
// Do *NOT* modify unless you really know what you're doing. //
//                                                           //
///////////////////////////////////////////////////////////////

using System;
using System.Reflection;using RimeLib.Serialization.Attributes;using RimeLib.Serialization.Ebx;using RimeLib.Serialization.Containers;using RimeLib.Frostbite.Core;

namespace fb
{
    [ContainerType(4)]
	public class WeaponAnimTypeModifier : 
		WeaponModifierBase
	{
		[ContainerField(8)]
		public WeaponAnimType WeaponAnimType { get; set; } = new WeaponAnimType(); // 0x8 (8)
		
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
