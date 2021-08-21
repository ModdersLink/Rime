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
	public class WeaponInputRouterComponentData : 
		ComponentData
	{
		protected float m_MaxFireRate = new float();
		[ContainerField(Name: "MaxFireRate", Offset: 96, NameHash: 369835659, Flags: 49469), LayoutImmutable, Blittable]
		public float MaxFireRate { get { return m_MaxFireRate; } set { if (OnPropertyChanging("WeaponInputRouterComponentData." + nameof(MaxFireRate), this, m_MaxFireRate, value)) m_MaxFireRate = value; } } // 0x60 (96)
		
		protected uint m_RotationCount = new uint();
		[ContainerField(Name: "RotationCount", Offset: 100, NameHash: 821183634, Flags: 49421), LayoutImmutable, Blittable]
		public uint RotationCount { get { return m_RotationCount; } set { if (OnPropertyChanging("WeaponInputRouterComponentData." + nameof(RotationCount), this, m_RotationCount, value)) m_RotationCount = value; } } // 0x64 (100)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 369835659:
					MaxFireRate = (float) p_Value;
					break;

				case 821183634:
					RotationCount = (uint) p_Value;
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
				case 369835659:
					return MaxFireRate;

				case 821183634:
					return RotationCount;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 369835659:
					return typeof(WeaponInputRouterComponentData).GetProperty(nameof(MaxFireRate));

				case 821183634:
					return typeof(WeaponInputRouterComponentData).GetProperty(nameof(RotationCount));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
