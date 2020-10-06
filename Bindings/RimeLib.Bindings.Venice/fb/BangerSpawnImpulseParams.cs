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
	[ContainerType(4), MemberInfoFlag(53), ContainerSize(44), ContainerClass]
	public class BangerSpawnImpulseParams : 
		DataContainer
	{
		protected float m_MinHorizontalAngle = new float();
		[ContainerField(8), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(1294078192)]
		public float MinHorizontalAngle { get { return m_MinHorizontalAngle; } set { if (OnPropertyChanging("BangerSpawnImpulseParams." + nameof(MinHorizontalAngle), this, m_MinHorizontalAngle, value)) m_MinHorizontalAngle = value; } } // 0x8 (8)
		
		protected float m_MaxHorizontalAngle = new float();
		[ContainerField(12), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(3734684206)]
		public float MaxHorizontalAngle { get { return m_MaxHorizontalAngle; } set { if (OnPropertyChanging("BangerSpawnImpulseParams." + nameof(MaxHorizontalAngle), this, m_MaxHorizontalAngle, value)) m_MaxHorizontalAngle = value; } } // 0xC (12)
		
		protected float m_MinVerticalAngle = new float();
		[ContainerField(16), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(335615388)]
		public float MinVerticalAngle { get { return m_MinVerticalAngle; } set { if (OnPropertyChanging("BangerSpawnImpulseParams." + nameof(MinVerticalAngle), this, m_MinVerticalAngle, value)) m_MinVerticalAngle = value; } } // 0x10 (16)
		
		protected float m_MaxVerticalAngle = new float();
		[ContainerField(20), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(3164410690)]
		public float MaxVerticalAngle { get { return m_MaxVerticalAngle; } set { if (OnPropertyChanging("BangerSpawnImpulseParams." + nameof(MaxVerticalAngle), this, m_MaxVerticalAngle, value)) m_MaxVerticalAngle = value; } } // 0x14 (20)
		
		protected float m_MinStrength = new float();
		[ContainerField(24), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(1539610890)]
		public float MinStrength { get { return m_MinStrength; } set { if (OnPropertyChanging("BangerSpawnImpulseParams." + nameof(MinStrength), this, m_MinStrength, value)) m_MinStrength = value; } } // 0x18 (24)
		
		protected float m_MaxStrength = new float();
		[ContainerField(28), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(1356104340)]
		public float MaxStrength { get { return m_MaxStrength; } set { if (OnPropertyChanging("BangerSpawnImpulseParams." + nameof(MaxStrength), this, m_MaxStrength, value)) m_MaxStrength = value; } } // 0x1C (28)
		
		protected float m_WaterStrengthModifier = new float();
		[ContainerField(32), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(778848386)]
		public float WaterStrengthModifier { get { return m_WaterStrengthModifier; } set { if (OnPropertyChanging("BangerSpawnImpulseParams." + nameof(WaterStrengthModifier), this, m_WaterStrengthModifier, value)) m_WaterStrengthModifier = value; } } // 0x20 (32)
		
		protected float m_LinearDamping = new float();
		[ContainerField(36), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(1796037280)]
		public float LinearDamping { get { return m_LinearDamping; } set { if (OnPropertyChanging("BangerSpawnImpulseParams." + nameof(LinearDamping), this, m_LinearDamping, value)) m_LinearDamping = value; } } // 0x24 (36)
		
		protected float m_AngularDamping = new float();
		[ContainerField(40), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(2055444159)]
		public float AngularDamping { get { return m_AngularDamping; } set { if (OnPropertyChanging("BangerSpawnImpulseParams." + nameof(AngularDamping), this, m_AngularDamping, value)) m_AngularDamping = value; } } // 0x28 (40)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 1294078192:
					MinHorizontalAngle = (float) p_Value;
					break;

				case 3734684206:
					MaxHorizontalAngle = (float) p_Value;
					break;

				case 335615388:
					MinVerticalAngle = (float) p_Value;
					break;

				case 3164410690:
					MaxVerticalAngle = (float) p_Value;
					break;

				case 1539610890:
					MinStrength = (float) p_Value;
					break;

				case 1356104340:
					MaxStrength = (float) p_Value;
					break;

				case 778848386:
					WaterStrengthModifier = (float) p_Value;
					break;

				case 1796037280:
					LinearDamping = (float) p_Value;
					break;

				case 2055444159:
					AngularDamping = (float) p_Value;
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
				case 1294078192:
					return MinHorizontalAngle;

				case 3734684206:
					return MaxHorizontalAngle;

				case 335615388:
					return MinVerticalAngle;

				case 3164410690:
					return MaxVerticalAngle;

				case 1539610890:
					return MinStrength;

				case 1356104340:
					return MaxStrength;

				case 778848386:
					return WaterStrengthModifier;

				case 1796037280:
					return LinearDamping;

				case 2055444159:
					return AngularDamping;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 1294078192:
					return typeof(BangerSpawnImpulseParams).GetProperty(nameof(MinHorizontalAngle));

				case 3734684206:
					return typeof(BangerSpawnImpulseParams).GetProperty(nameof(MaxHorizontalAngle));

				case 335615388:
					return typeof(BangerSpawnImpulseParams).GetProperty(nameof(MinVerticalAngle));

				case 3164410690:
					return typeof(BangerSpawnImpulseParams).GetProperty(nameof(MaxVerticalAngle));

				case 1539610890:
					return typeof(BangerSpawnImpulseParams).GetProperty(nameof(MinStrength));

				case 1356104340:
					return typeof(BangerSpawnImpulseParams).GetProperty(nameof(MaxStrength));

				case 778848386:
					return typeof(BangerSpawnImpulseParams).GetProperty(nameof(WaterStrengthModifier));

				case 1796037280:
					return typeof(BangerSpawnImpulseParams).GetProperty(nameof(LinearDamping));

				case 2055444159:
					return typeof(BangerSpawnImpulseParams).GetProperty(nameof(AngularDamping));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
