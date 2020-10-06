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
	[ContainerType(4), MemberInfoFlag(53), ContainerSize(20), ContainerClass]
	public class MeleeWeaponData : 
		WeaponData
	{
		protected bool m_UseCannedAnimation = new bool();
		[ContainerField(16), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(1105762899)]
		public bool UseCannedAnimation { get { return m_UseCannedAnimation; } set { if (OnPropertyChanging("MeleeWeaponData." + nameof(UseCannedAnimation), this, m_UseCannedAnimation, value)) m_UseCannedAnimation = value; } } // 0x10 (16)
		
		protected bool m_UseSphereDamage = new bool();
		[ContainerField(17), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(1535336436)]
		public bool UseSphereDamage { get { return m_UseSphereDamage; } set { if (OnPropertyChanging("MeleeWeaponData." + nameof(UseSphereDamage), this, m_UseSphereDamage, value)) m_UseSphereDamage = value; } } // 0x11 (17)
		
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
