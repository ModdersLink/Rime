///////////////////////////////////////////////////////////////
//                                                           //
// This is an automatically generated file.                  //
// Do *NOT* modify unless you really know what you're doing. //
//                                                           //
///////////////////////////////////////////////////////////////

using System.Reflection;using RimeLib.Serialization.Attributes;using RimeLib.Serialization.Ebx;using RimeLib.Serialization.Containers;using RimeLib.Frostbite.Core;

namespace fb
{
    [ContainerType(4)]
	public class MeleeWeaponData : 
		WeaponData
	{
		[ContainerField(16), LayoutImmutable, Blittable]
		public bool UseCannedAnimation { get; set; } // 0x10 (16)
		
		[ContainerField(17), LayoutImmutable, Blittable]
		public bool UseSphereDamage { get; set; } // 0x11 (17)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 1105762899:
					UseCannedAnimation = (bool) p_Value;
					break;

				case 1535336436:
					UseSphereDamage = (bool) p_Value;
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
				case 1105762899:
					return UseCannedAnimation;

				case 1535336436:
					return UseSphereDamage;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 1105762899:
					return typeof(MeleeWeaponData).GetProperty(nameof(UseCannedAnimation));

				case 1535336436:
					return typeof(MeleeWeaponData).GetProperty(nameof(UseSphereDamage));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
