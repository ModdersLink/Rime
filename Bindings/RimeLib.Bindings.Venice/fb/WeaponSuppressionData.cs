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
	[ContainerType(Alignment: 4,  Flags: 53, Size: 24)]
	public class WeaponSuppressionData : 
		DataContainer
	{
		protected float m_MaxMultiplier = new float();
		[ContainerField(Name: "MaxMultiplier", Offset: 8, NameHash: 441185306, Flags: 49469), LayoutImmutable, Blittable]
		public float MaxMultiplier { get { return m_MaxMultiplier; } set { if (OnPropertyChanging("WeaponSuppressionData." + nameof(MaxMultiplier), this, m_MaxMultiplier, value)) m_MaxMultiplier = value; } } // 0x8 (8)
		
		protected float m_MinMultiplier = new float();
		[ContainerField(Name: "MinMultiplier", Offset: 12, NameHash: 3723256324, Flags: 49469), LayoutImmutable, Blittable]
		public float MinMultiplier { get { return m_MinMultiplier; } set { if (OnPropertyChanging("WeaponSuppressionData." + nameof(MinMultiplier), this, m_MinMultiplier, value)) m_MinMultiplier = value; } } // 0xC (12)
		
		protected float m_MinDistance = new float();
		[ContainerField(Name: "MinDistance", Offset: 16, NameHash: 1885855628, Flags: 49469), LayoutImmutable, Blittable]
		public float MinDistance { get { return m_MinDistance; } set { if (OnPropertyChanging("WeaponSuppressionData." + nameof(MinDistance), this, m_MinDistance, value)) m_MinDistance = value; } } // 0x10 (16)
		
		protected float m_MaxDistance = new float();
		[ContainerField(Name: "MaxDistance", Offset: 20, NameHash: 3520454034, Flags: 49469), LayoutImmutable, Blittable]
		public float MaxDistance { get { return m_MaxDistance; } set { if (OnPropertyChanging("WeaponSuppressionData." + nameof(MaxDistance), this, m_MaxDistance, value)) m_MaxDistance = value; } } // 0x14 (20)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 441185306:
					MaxMultiplier = (float) p_Value;
					break;

				case 3723256324:
					MinMultiplier = (float) p_Value;
					break;

				case 1885855628:
					MinDistance = (float) p_Value;
					break;

				case 3520454034:
					MaxDistance = (float) p_Value;
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
				case 441185306:
					return MaxMultiplier;

				case 3723256324:
					return MinMultiplier;

				case 1885855628:
					return MinDistance;

				case 3520454034:
					return MaxDistance;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 441185306:
					return typeof(WeaponSuppressionData).GetProperty(nameof(MaxMultiplier));

				case 3723256324:
					return typeof(WeaponSuppressionData).GetProperty(nameof(MinMultiplier));

				case 1885855628:
					return typeof(WeaponSuppressionData).GetProperty(nameof(MinDistance));

				case 3520454034:
					return typeof(WeaponSuppressionData).GetProperty(nameof(MaxDistance));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
