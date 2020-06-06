///////////////////////////////////////////////////////////////
//                                                           //
// This is an automatically generated file.                  //
// Do *NOT* modify unless you really know what you're doing. //
//                                                           //
///////////////////////////////////////////////////////////////

using System.Reflection;using RimeLib.Serialization.Attributes;using RimeLib.Serialization.Ebx;using RimeLib.Serialization.Containers;using RimeLib.Frostbite.Core;

namespace fb
{
    [ContainerType(16)]
	public class WeaponLagSpringEffectData : 
		DataContainer
	{
		[ContainerField(8)]
		public WeaponLagEffectSpringVector OffsetSprings { get; set; } = new WeaponLagEffectSpringVector(); // 0x8 (8)
		
		[ContainerField(32)]
		public WeaponLagEffectSpringVector RotationSprings { get; set; } = new WeaponLagEffectSpringVector(); // 0x20 (32)
		
		[ContainerField(64)]
		public WeaponLagEffectForceData JumpForces { get; set; } = new WeaponLagEffectForceData(); // 0x40 (64)
		
		[ContainerField(96)]
		public WeaponLagEffectForceData LandForces { get; set; } = new WeaponLagEffectForceData(); // 0x60 (96)
		
		[ContainerField(128)]
		public WeaponLagEffectForceData PoseUpForces { get; set; } = new WeaponLagEffectForceData(); // 0x80 (128)
		
		[ContainerField(160)]
		public WeaponLagEffectForceData PoseDownForces { get; set; } = new WeaponLagEffectForceData(); // 0xA0 (160)
		
		[ContainerField(192), LayoutImmutable, Blittable]
		public float ZoomForceModifier { get; set; } // 0xC0 (192)
		
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
