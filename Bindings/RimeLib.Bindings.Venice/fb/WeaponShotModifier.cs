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
	[ContainerType(Alignment: 16,  Flags: 53, Size: 48)]
	public class WeaponShotModifier : 
		WeaponModifierBase
	{
		protected Vec3 m_InitialSpeed = new Vec3();
		[ContainerField(Name: "InitialSpeed", Offset: 16, NameHash: 3681055580, Flags: 53289), Homogeneous, LayoutImmutable, Blittable]
		public Vec3 InitialSpeed { get { return m_InitialSpeed; } set { if (OnPropertyChanging("WeaponShotModifier." + nameof(InitialSpeed), this, m_InitialSpeed, value)) m_InitialSpeed = value; } } // 0x10 (16)
		
		protected int m_NumberOfBulletsPerShell = new int();
		[ContainerField(Name: "NumberOfBulletsPerShell", Offset: 32, NameHash: 464437027, Flags: 49405), LayoutImmutable, Blittable]
		public int NumberOfBulletsPerShell { get { return m_NumberOfBulletsPerShell; } set { if (OnPropertyChanging("WeaponShotModifier." + nameof(NumberOfBulletsPerShell), this, m_NumberOfBulletsPerShell, value)) m_NumberOfBulletsPerShell = value; } } // 0x20 (32)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 3681055580:
					InitialSpeed = (Vec3) p_Value;
					break;

				case 464437027:
					NumberOfBulletsPerShell = (int) p_Value;
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
				case 3681055580:
					return InitialSpeed;

				case 464437027:
					return NumberOfBulletsPerShell;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 3681055580:
					return typeof(WeaponShotModifier).GetProperty(nameof(InitialSpeed));

				case 464437027:
					return typeof(WeaponShotModifier).GetProperty(nameof(NumberOfBulletsPerShell));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
