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
	[ContainerType(Alignment: 16,  Flags: 53, Size: 208)]
	public class WeaponLagSpringEffectData : 
		DataContainer
	{
		protected WeaponLagEffectSpringVector m_OffsetSprings = new WeaponLagEffectSpringVector();
		[ContainerField(Name: "OffsetSprings", Offset: 8, NameHash: 3506860586, Flags: 41)]
		public WeaponLagEffectSpringVector OffsetSprings { get { return m_OffsetSprings; } set { if (OnPropertyChanging("WeaponLagSpringEffectData." + nameof(OffsetSprings), this, m_OffsetSprings, value)) m_OffsetSprings = value; } } // 0x8 (8)
		
		protected WeaponLagEffectSpringVector m_RotationSprings = new WeaponLagEffectSpringVector();
		[ContainerField(Name: "RotationSprings", Offset: 32, NameHash: 1853141363, Flags: 41)]
		public WeaponLagEffectSpringVector RotationSprings { get { return m_RotationSprings; } set { if (OnPropertyChanging("WeaponLagSpringEffectData." + nameof(RotationSprings), this, m_RotationSprings, value)) m_RotationSprings = value; } } // 0x20 (32)
		
		protected WeaponLagEffectForceData m_JumpForces = new WeaponLagEffectForceData();
		[ContainerField(Name: "JumpForces", Offset: 64, NameHash: 583688585, Flags: 41)]
		public WeaponLagEffectForceData JumpForces { get { return m_JumpForces; } set { if (OnPropertyChanging("WeaponLagSpringEffectData." + nameof(JumpForces), this, m_JumpForces, value)) m_JumpForces = value; } } // 0x40 (64)
		
		protected WeaponLagEffectForceData m_LandForces = new WeaponLagEffectForceData();
		[ContainerField(Name: "LandForces", Offset: 96, NameHash: 2961168620, Flags: 41)]
		public WeaponLagEffectForceData LandForces { get { return m_LandForces; } set { if (OnPropertyChanging("WeaponLagSpringEffectData." + nameof(LandForces), this, m_LandForces, value)) m_LandForces = value; } } // 0x60 (96)
		
		protected WeaponLagEffectForceData m_PoseUpForces = new WeaponLagEffectForceData();
		[ContainerField(Name: "PoseUpForces", Offset: 128, NameHash: 806552583, Flags: 41)]
		public WeaponLagEffectForceData PoseUpForces { get { return m_PoseUpForces; } set { if (OnPropertyChanging("WeaponLagSpringEffectData." + nameof(PoseUpForces), this, m_PoseUpForces, value)) m_PoseUpForces = value; } } // 0x80 (128)
		
		protected WeaponLagEffectForceData m_PoseDownForces = new WeaponLagEffectForceData();
		[ContainerField(Name: "PoseDownForces", Offset: 160, NameHash: 3710232848, Flags: 41)]
		public WeaponLagEffectForceData PoseDownForces { get { return m_PoseDownForces; } set { if (OnPropertyChanging("WeaponLagSpringEffectData." + nameof(PoseDownForces), this, m_PoseDownForces, value)) m_PoseDownForces = value; } } // 0xA0 (160)
		
		protected float m_ZoomForceModifier = new float();
		[ContainerField(Name: "ZoomForceModifier", Offset: 192, NameHash: 6250296, Flags: 49469), LayoutImmutable, Blittable]
		public float ZoomForceModifier { get { return m_ZoomForceModifier; } set { if (OnPropertyChanging("WeaponLagSpringEffectData." + nameof(ZoomForceModifier), this, m_ZoomForceModifier, value)) m_ZoomForceModifier = value; } } // 0xC0 (192)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 3506860586:
					OffsetSprings = (WeaponLagEffectSpringVector) p_Value;
					break;

				case 1853141363:
					RotationSprings = (WeaponLagEffectSpringVector) p_Value;
					break;

				case 583688585:
					JumpForces = (WeaponLagEffectForceData) p_Value;
					break;

				case 2961168620:
					LandForces = (WeaponLagEffectForceData) p_Value;
					break;

				case 806552583:
					PoseUpForces = (WeaponLagEffectForceData) p_Value;
					break;

				case 3710232848:
					PoseDownForces = (WeaponLagEffectForceData) p_Value;
					break;

				case 6250296:
					ZoomForceModifier = (float) p_Value;
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
				case 3506860586:
					return OffsetSprings;

				case 1853141363:
					return RotationSprings;

				case 583688585:
					return JumpForces;

				case 2961168620:
					return LandForces;

				case 806552583:
					return PoseUpForces;

				case 3710232848:
					return PoseDownForces;

				case 6250296:
					return ZoomForceModifier;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 3506860586:
					return typeof(WeaponLagSpringEffectData).GetProperty(nameof(OffsetSprings));

				case 1853141363:
					return typeof(WeaponLagSpringEffectData).GetProperty(nameof(RotationSprings));

				case 583688585:
					return typeof(WeaponLagSpringEffectData).GetProperty(nameof(JumpForces));

				case 2961168620:
					return typeof(WeaponLagSpringEffectData).GetProperty(nameof(LandForces));

				case 806552583:
					return typeof(WeaponLagSpringEffectData).GetProperty(nameof(PoseUpForces));

				case 3710232848:
					return typeof(WeaponLagSpringEffectData).GetProperty(nameof(PoseDownForces));

				case 6250296:
					return typeof(WeaponLagSpringEffectData).GetProperty(nameof(ZoomForceModifier));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
