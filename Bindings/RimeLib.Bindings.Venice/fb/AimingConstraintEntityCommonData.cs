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
	[ContainerType(4), MemberInfoFlag(53), ContainerSize(52), ContainerClass]
	public class AimingConstraintEntityCommonData : 
		Asset
	{
		protected AimingConstraintEntityBinding m_AimingConstraintsBinding = new AimingConstraintEntityBinding();
		[ContainerField(12), MemberInfoFlag(41), ContainerFieldNameHash(959117047)]
		public AimingConstraintEntityBinding AimingConstraintsBinding { get { return m_AimingConstraintsBinding; } set { if (OnPropertyChanging("AimingConstraintEntityCommonData." + nameof(AimingConstraintsBinding), this, m_AimingConstraintsBinding, value)) m_AimingConstraintsBinding = value; } } // 0xC (12)
		
		protected AimingConstraintsData m_AimingConstraints = new AimingConstraintsData();
		[ContainerField(20), MemberInfoFlag(41), ContainerFieldNameHash(1523178198)]
		public AimingConstraintsData AimingConstraints { get { return m_AimingConstraints; } set { if (OnPropertyChanging("AimingConstraintEntityCommonData." + nameof(AimingConstraints), this, m_AimingConstraints, value)) m_AimingConstraints = value; } } // 0x14 (20)
		
		protected float m_DisableAimingConstraintsDelay = new float();
		[ContainerField(36), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(4044073143)]
		public float DisableAimingConstraintsDelay { get { return m_DisableAimingConstraintsDelay; } set { if (OnPropertyChanging("AimingConstraintEntityCommonData." + nameof(DisableAimingConstraintsDelay), this, m_DisableAimingConstraintsDelay, value)) m_DisableAimingConstraintsDelay = value; } } // 0x24 (36)
		
		protected float m_ConstraintMoveSpeedMultiplier = new float();
		[ContainerField(40), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(1613795389)]
		public float ConstraintMoveSpeedMultiplier { get { return m_ConstraintMoveSpeedMultiplier; } set { if (OnPropertyChanging("AimingConstraintEntityCommonData." + nameof(ConstraintMoveSpeedMultiplier), this, m_ConstraintMoveSpeedMultiplier, value)) m_ConstraintMoveSpeedMultiplier = value; } } // 0x28 (40)
		
		protected float m_ShuffleAnimationThreshold = new float();
		[ContainerField(44), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(1503561667)]
		public float ShuffleAnimationThreshold { get { return m_ShuffleAnimationThreshold; } set { if (OnPropertyChanging("AimingConstraintEntityCommonData." + nameof(ShuffleAnimationThreshold), this, m_ShuffleAnimationThreshold, value)) m_ShuffleAnimationThreshold = value; } } // 0x2C (44)
		
		protected float m_ShuffleAnimationDelay = new float();
		[ContainerField(48), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(1783074145)]
		public float ShuffleAnimationDelay { get { return m_ShuffleAnimationDelay; } set { if (OnPropertyChanging("AimingConstraintEntityCommonData." + nameof(ShuffleAnimationDelay), this, m_ShuffleAnimationDelay, value)) m_ShuffleAnimationDelay = value; } } // 0x30 (48)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 959117047:
					AimingConstraintsBinding = (AimingConstraintEntityBinding) p_Value;
					break;

				case 1523178198:
					AimingConstraints = (AimingConstraintsData) p_Value;
					break;

				case 4044073143:
					DisableAimingConstraintsDelay = (float) p_Value;
					break;

				case 1613795389:
					ConstraintMoveSpeedMultiplier = (float) p_Value;
					break;

				case 1503561667:
					ShuffleAnimationThreshold = (float) p_Value;
					break;

				case 1783074145:
					ShuffleAnimationDelay = (float) p_Value;
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
				case 959117047:
					return AimingConstraintsBinding;

				case 1523178198:
					return AimingConstraints;

				case 4044073143:
					return DisableAimingConstraintsDelay;

				case 1613795389:
					return ConstraintMoveSpeedMultiplier;

				case 1503561667:
					return ShuffleAnimationThreshold;

				case 1783074145:
					return ShuffleAnimationDelay;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 959117047:
					return typeof(AimingConstraintEntityCommonData).GetProperty(nameof(AimingConstraintsBinding));

				case 1523178198:
					return typeof(AimingConstraintEntityCommonData).GetProperty(nameof(AimingConstraints));

				case 4044073143:
					return typeof(AimingConstraintEntityCommonData).GetProperty(nameof(DisableAimingConstraintsDelay));

				case 1613795389:
					return typeof(AimingConstraintEntityCommonData).GetProperty(nameof(ConstraintMoveSpeedMultiplier));

				case 1503561667:
					return typeof(AimingConstraintEntityCommonData).GetProperty(nameof(ShuffleAnimationThreshold));

				case 1783074145:
					return typeof(AimingConstraintEntityCommonData).GetProperty(nameof(ShuffleAnimationDelay));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
