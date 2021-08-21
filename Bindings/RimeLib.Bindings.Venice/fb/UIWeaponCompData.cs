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
	[ContainerType(Alignment: 4,  Flags: 53, Size: 40)]
	public class UIWeaponCompData : 
		UIComponentData
	{
		protected float m_MinHitIndicatorLimit = new float();
		[ContainerField(Name: "MinHitIndicatorLimit", Offset: 28, NameHash: 2846241422, Flags: 49469), LayoutImmutable, Blittable]
		public float MinHitIndicatorLimit { get { return m_MinHitIndicatorLimit; } set { if (OnPropertyChanging("UIWeaponCompData." + nameof(MinHitIndicatorLimit), this, m_MinHitIndicatorLimit, value)) m_MinHitIndicatorLimit = value; } } // 0x1C (28)
		
		protected float m_MaxHitIndicatorLimit = new float();
		[ContainerField(Name: "MaxHitIndicatorLimit", Offset: 32, NameHash: 3944764752, Flags: 49469), LayoutImmutable, Blittable]
		public float MaxHitIndicatorLimit { get { return m_MaxHitIndicatorLimit; } set { if (OnPropertyChanging("UIWeaponCompData." + nameof(MaxHitIndicatorLimit), this, m_MaxHitIndicatorLimit, value)) m_MaxHitIndicatorLimit = value; } } // 0x20 (32)
		
		protected float m_NormalHitIndicatorLimit = new float();
		[ContainerField(Name: "NormalHitIndicatorLimit", Offset: 36, NameHash: 2004036151, Flags: 49469), LayoutImmutable, Blittable]
		public float NormalHitIndicatorLimit { get { return m_NormalHitIndicatorLimit; } set { if (OnPropertyChanging("UIWeaponCompData." + nameof(NormalHitIndicatorLimit), this, m_NormalHitIndicatorLimit, value)) m_NormalHitIndicatorLimit = value; } } // 0x24 (36)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 2846241422:
					MinHitIndicatorLimit = (float) p_Value;
					break;

				case 3944764752:
					MaxHitIndicatorLimit = (float) p_Value;
					break;

				case 2004036151:
					NormalHitIndicatorLimit = (float) p_Value;
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
				case 2846241422:
					return MinHitIndicatorLimit;

				case 3944764752:
					return MaxHitIndicatorLimit;

				case 2004036151:
					return NormalHitIndicatorLimit;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 2846241422:
					return typeof(UIWeaponCompData).GetProperty(nameof(MinHitIndicatorLimit));

				case 3944764752:
					return typeof(UIWeaponCompData).GetProperty(nameof(MaxHitIndicatorLimit));

				case 2004036151:
					return typeof(UIWeaponCompData).GetProperty(nameof(NormalHitIndicatorLimit));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
