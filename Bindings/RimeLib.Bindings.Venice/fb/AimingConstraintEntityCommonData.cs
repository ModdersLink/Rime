///////////////////////////////////////////////////////////////
//                                                           //
// This is an automatically generated file.                  //
// Do *NOT* modify unless you really know what you're doing. //
//                                                           //
///////////////////////////////////////////////////////////////

using System.Reflection;using RimeLib.Serialization.Attributes;using RimeLib.Serialization.Ebx;using RimeLib.Serialization.Containers;using RimeLib.Frostbite.Core;

namespace fb
{
    [ContainerType(4)]
	public class AimingConstraintEntityCommonData : 
		Asset
	{
		[ContainerField(12)]
		public AimingConstraintEntityBinding AimingConstraintsBinding { get; set; } = new AimingConstraintEntityBinding(); // 0xC (12)
		
		[ContainerField(20)]
		public AimingConstraintsData AimingConstraints { get; set; } = new AimingConstraintsData(); // 0x14 (20)
		
		[ContainerField(36), LayoutImmutable, Blittable]
		public float DisableAimingConstraintsDelay { get; set; } // 0x24 (36)
		
		[ContainerField(40), LayoutImmutable, Blittable]
		public float ConstraintMoveSpeedMultiplier { get; set; } // 0x28 (40)
		
		[ContainerField(44), LayoutImmutable, Blittable]
		public float ShuffleAnimationThreshold { get; set; } // 0x2C (44)
		
		[ContainerField(48), LayoutImmutable, Blittable]
		public float ShuffleAnimationDelay { get; set; } // 0x30 (48)
		
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
