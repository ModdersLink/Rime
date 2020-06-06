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
	public class HudCameraShakeData : 
		UIComponentData
	{
		[ContainerField(28), LayoutImmutable, Blittable]
		public float WeaponDispersionMin { get; set; } // 0x1C (28)
		
		[ContainerField(32), LayoutImmutable, Blittable]
		public float WeaponDispersionMax { get; set; } // 0x20 (32)
		
		[ContainerField(36), LayoutImmutable, Blittable]
		public float WeaponDispersionOffsetScale { get; set; } // 0x24 (36)
		
		[ContainerField(40), LayoutImmutable, Blittable]
		public float JumpEffectDurationMin { get; set; } // 0x28 (40)
		
		[ContainerField(44), LayoutImmutable, Blittable]
		public float JumpEffectDurationMax { get; set; } // 0x2C (44)
		
		[ContainerField(48), LayoutImmutable, Blittable]
		public float JumpEffectMin { get; set; } // 0x30 (48)
		
		[ContainerField(52), LayoutImmutable, Blittable]
		public float JumpEffectMax { get; set; } // 0x34 (52)
		
		[ContainerField(56), LayoutImmutable, Blittable]
		public float LandEffectDurationMin { get; set; } // 0x38 (56)
		
		[ContainerField(60), LayoutImmutable, Blittable]
		public float LandEffectDurationMax { get; set; } // 0x3C (60)
		
		[ContainerField(64), LayoutImmutable, Blittable]
		public float LandEffectMin { get; set; } // 0x40 (64)
		
		[ContainerField(68), LayoutImmutable, Blittable]
		public float LandEffectMax { get; set; } // 0x44 (68)
		
		[ContainerField(72), LayoutImmutable, Blittable]
		public float CameraShakeMinAngle { get; set; } // 0x48 (72)
		
		[ContainerField(76), LayoutImmutable, Blittable]
		public float CameraShakeMaxAngle { get; set; } // 0x4C (76)
		
		[ContainerField(80), LayoutImmutable, Blittable]
		public float CameraShakeScale { get; set; } // 0x50 (80)
		
		[ContainerField(84), LayoutImmutable, Blittable]
		public float WeaponLagXScale { get; set; } // 0x54 (84)
		
		[ContainerField(88), LayoutImmutable, Blittable]
		public float WeaponLagYScale { get; set; } // 0x58 (88)
		
		[ContainerField(92), LayoutImmutable, Blittable]
		public uint FilterSize { get; set; } // 0x5C (92)
		
		[ContainerField(96), LayoutImmutable, Blittable]
		public float MaxDisplacement { get; set; } // 0x60 (96)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 2596092207:
					WeaponDispersionMin = (float) p_Value;
					break;

				case 2596092465:
					WeaponDispersionMax = (float) p_Value;
					break;

				case 2636099696:
					WeaponDispersionOffsetScale = (float) p_Value;
					break;

				case 3119984708:
					JumpEffectDurationMin = (float) p_Value;
					break;

				case 3119984474:
					JumpEffectDurationMax = (float) p_Value;
					break;

				case 2038531226:
					JumpEffectMin = (float) p_Value;
					break;

				case 2038531460:
					JumpEffectMax = (float) p_Value;
					break;

				case 3149698945:
					LandEffectDurationMin = (float) p_Value;
					break;

				case 3149698719:
					LandEffectDurationMax = (float) p_Value;
					break;

				case 2460750495:
					LandEffectMin = (float) p_Value;
					break;

				case 2460750721:
					LandEffectMax = (float) p_Value;
					break;

				case 939510435:
					CameraShakeMinAngle = (float) p_Value;
					break;

				case 375932157:
					CameraShakeMaxAngle = (float) p_Value;
					break;

				case 3342909616:
					CameraShakeScale = (float) p_Value;
					break;

				case 994760237:
					WeaponLagXScale = (float) p_Value;
					break;

				case 1109790412:
					WeaponLagYScale = (float) p_Value;
					break;

				case 2796213248:
					FilterSize = (uint) p_Value;
					break;

				case 263952390:
					MaxDisplacement = (float) p_Value;
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
				case 2596092207:
					return WeaponDispersionMin;

				case 2596092465:
					return WeaponDispersionMax;

				case 2636099696:
					return WeaponDispersionOffsetScale;

				case 3119984708:
					return JumpEffectDurationMin;

				case 3119984474:
					return JumpEffectDurationMax;

				case 2038531226:
					return JumpEffectMin;

				case 2038531460:
					return JumpEffectMax;

				case 3149698945:
					return LandEffectDurationMin;

				case 3149698719:
					return LandEffectDurationMax;

				case 2460750495:
					return LandEffectMin;

				case 2460750721:
					return LandEffectMax;

				case 939510435:
					return CameraShakeMinAngle;

				case 375932157:
					return CameraShakeMaxAngle;

				case 3342909616:
					return CameraShakeScale;

				case 994760237:
					return WeaponLagXScale;

				case 1109790412:
					return WeaponLagYScale;

				case 2796213248:
					return FilterSize;

				case 263952390:
					return MaxDisplacement;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 2596092207:
					return typeof(HudCameraShakeData).GetProperty(nameof(WeaponDispersionMin));

				case 2596092465:
					return typeof(HudCameraShakeData).GetProperty(nameof(WeaponDispersionMax));

				case 2636099696:
					return typeof(HudCameraShakeData).GetProperty(nameof(WeaponDispersionOffsetScale));

				case 3119984708:
					return typeof(HudCameraShakeData).GetProperty(nameof(JumpEffectDurationMin));

				case 3119984474:
					return typeof(HudCameraShakeData).GetProperty(nameof(JumpEffectDurationMax));

				case 2038531226:
					return typeof(HudCameraShakeData).GetProperty(nameof(JumpEffectMin));

				case 2038531460:
					return typeof(HudCameraShakeData).GetProperty(nameof(JumpEffectMax));

				case 3149698945:
					return typeof(HudCameraShakeData).GetProperty(nameof(LandEffectDurationMin));

				case 3149698719:
					return typeof(HudCameraShakeData).GetProperty(nameof(LandEffectDurationMax));

				case 2460750495:
					return typeof(HudCameraShakeData).GetProperty(nameof(LandEffectMin));

				case 2460750721:
					return typeof(HudCameraShakeData).GetProperty(nameof(LandEffectMax));

				case 939510435:
					return typeof(HudCameraShakeData).GetProperty(nameof(CameraShakeMinAngle));

				case 375932157:
					return typeof(HudCameraShakeData).GetProperty(nameof(CameraShakeMaxAngle));

				case 3342909616:
					return typeof(HudCameraShakeData).GetProperty(nameof(CameraShakeScale));

				case 994760237:
					return typeof(HudCameraShakeData).GetProperty(nameof(WeaponLagXScale));

				case 1109790412:
					return typeof(HudCameraShakeData).GetProperty(nameof(WeaponLagYScale));

				case 2796213248:
					return typeof(HudCameraShakeData).GetProperty(nameof(FilterSize));

				case 263952390:
					return typeof(HudCameraShakeData).GetProperty(nameof(MaxDisplacement));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
