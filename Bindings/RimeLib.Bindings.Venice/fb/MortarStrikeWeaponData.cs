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
	[ContainerType(4), MemberInfoFlag(53), ContainerSize(32), ContainerClass]
	public class MortarStrikeWeaponData : 
		WeaponData
	{
		protected float m_HoldingTolerance = new float();
		[ContainerField(16), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(1278440067)]
		public float HoldingTolerance { get { return m_HoldingTolerance; } set { if (OnPropertyChanging("MortarStrikeWeaponData." + nameof(HoldingTolerance), this, m_HoldingTolerance, value)) m_HoldingTolerance = value; } } // 0x10 (16)
		
		protected float m_MaxStrikeDistance = new float();
		[ContainerField(20), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(3419412896)]
		public float MaxStrikeDistance { get { return m_MaxStrikeDistance; } set { if (OnPropertyChanging("MortarStrikeWeaponData." + nameof(MaxStrikeDistance), this, m_MaxStrikeDistance, value)) m_MaxStrikeDistance = value; } } // 0x14 (20)
		
		protected float m_StrikeRadius = new float();
		[ContainerField(24), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(4030357871)]
		public float StrikeRadius { get { return m_StrikeRadius; } set { if (OnPropertyChanging("MortarStrikeWeaponData." + nameof(StrikeRadius), this, m_StrikeRadius, value)) m_StrikeRadius = value; } } // 0x18 (24)
		
		protected float m_MaxRandomSpawnHeight = new float();
		[ContainerField(28), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(2881356526)]
		public float MaxRandomSpawnHeight { get { return m_MaxRandomSpawnHeight; } set { if (OnPropertyChanging("MortarStrikeWeaponData." + nameof(MaxRandomSpawnHeight), this, m_MaxRandomSpawnHeight, value)) m_MaxRandomSpawnHeight = value; } } // 0x1C (28)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 1278440067:
					HoldingTolerance = (float) p_Value;
					break;

				case 3419412896:
					MaxStrikeDistance = (float) p_Value;
					break;

				case 4030357871:
					StrikeRadius = (float) p_Value;
					break;

				case 2881356526:
					MaxRandomSpawnHeight = (float) p_Value;
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
				case 1278440067:
					return HoldingTolerance;

				case 3419412896:
					return MaxStrikeDistance;

				case 4030357871:
					return StrikeRadius;

				case 2881356526:
					return MaxRandomSpawnHeight;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 1278440067:
					return typeof(MortarStrikeWeaponData).GetProperty(nameof(HoldingTolerance));

				case 3419412896:
					return typeof(MortarStrikeWeaponData).GetProperty(nameof(MaxStrikeDistance));

				case 4030357871:
					return typeof(MortarStrikeWeaponData).GetProperty(nameof(StrikeRadius));

				case 2881356526:
					return typeof(MortarStrikeWeaponData).GetProperty(nameof(MaxRandomSpawnHeight));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
