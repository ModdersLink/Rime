///////////////////////////////////////////////////////////////
//                                                           //
// This is an automatically generated file.                  //
// Do *NOT* modify unless you really know what you're doing. //
//                                                           //
///////////////////////////////////////////////////////////////

using System.Collections.Generic;
using System.Reflection;using RimeLib.Serialization.Attributes;using RimeLib.Serialization.Ebx;using RimeLib.Serialization.Containers;using RimeLib.Frostbite.Core;

namespace fb
{
    [ContainerType(16)]
	public class SoldierAimAssistData : 
		GameDataContainer
	{
		[ContainerField(16), Homogeneous, LayoutImmutable, Blittable]
		public Vec3 EyePosOffset { get; set; } = new Vec3(); // 0x10 (16)
		
		[ContainerField(32), Homogeneous, LayoutImmutable, Blittable]
		public Vec3 StickyBoxScale { get; set; } = new Vec3(); // 0x20 (32)
		
		[ContainerField(48), Homogeneous, LayoutImmutable, Blittable]
		public Vec3 SnapDistanceScale { get; set; } = new Vec3(); // 0x30 (48)
		
		[ContainerField(64), Homogeneous, LayoutImmutable, Blittable]
		public Vec3 SnapBoxScale { get; set; } = new Vec3(); // 0x40 (64)
		
		[ContainerField(80), Homogeneous, LayoutImmutable, Blittable]
		public Vec3 StickyDistanceScale { get; set; } = new Vec3(); // 0x50 (80)
		
		[ContainerField(96), Homogeneous, LayoutImmutable, Blittable]
		public Vec2 MaxAcceleration { get; set; } = new Vec2(); // 0x60 (96)
		
		[ContainerField(104), LayoutImmutable, Blittable]
		public float AccelerationDamping { get; set; } // 0x68 (104)
		
		[ContainerField(108), LayoutImmutable, Blittable]
		public float AccelerationInputThreshold { get; set; } // 0x6C (108)
		
		[ContainerField(112), LayoutImmutable, Blittable]
		public float AccelerationMultiplier { get; set; } // 0x70 (112)
		
		[ContainerField(116), LayoutImmutable, Blittable]
		public float SquaredAcceleration { get; set; } // 0x74 (116)
		
		[ContainerField(120), LayoutImmutable, Blittable]
		public float YawSpeedStrength { get; set; } // 0x78 (120)
		
		[ContainerField(124)]
		public List<float> ZoomedInputPolynomial { get; set; } = new List<float>(); // 0x7C (124)
		
		[ContainerField(128), LayoutImmutable, Blittable]
		public float AccelerationTimeThreshold { get; set; } // 0x80 (128)
		
		[ContainerField(132)]
		public List<float> AttractDistanceFallOff { get; set; } = new List<float>(); // 0x84 (132)
		
		[ContainerField(136), LayoutImmutable, Blittable]
		public float AttractUserInputMultiplier { get; set; } // 0x88 (136)
		
		[ContainerField(140), LayoutImmutable, Blittable]
		public float AttractOwnSpeedInfluence { get; set; } // 0x8C (140)
		
		[ContainerField(144), LayoutImmutable, Blittable]
		public float AttractTargetSpeedInfluence { get; set; } // 0x90 (144)
		
		[ContainerField(148), LayoutImmutable, Blittable]
		public float AttractOwnRequiredMovementForMaximumAttract { get; set; } // 0x94 (148)
		
		[ContainerField(152), LayoutImmutable, Blittable]
		public float AttractStartInputThreshold { get; set; } // 0x98 (152)
		
		[ContainerField(156), LayoutImmutable, Blittable]
		public float AttractZoomingMultiplier { get; set; } // 0x9C (156)
		
		[ContainerField(160), LayoutImmutable, Blittable]
		public float AttractZoomingPostTime { get; set; } // 0xA0 (160)
		
		[ContainerField(164), LayoutImmutable, Blittable]
		public float AttractYawStrength { get; set; } // 0xA4 (164)
		
		[ContainerField(168), LayoutImmutable, Blittable]
		public float AttractPitchStrength { get; set; } // 0xA8 (168)
		
		[ContainerField(172), LayoutImmutable, Blittable]
		public float PitchSpeedStrength { get; set; } // 0xAC (172)
		
		[ContainerField(176), LayoutImmutable, Blittable]
		public float AttractSoftZone { get; set; } // 0xB0 (176)
		
		[ContainerField(180)]
		public List<float> InputPolynomial { get; set; } = new List<float>(); // 0xB4 (180)
		
		[ContainerField(184), LayoutImmutable, Blittable]
		public bool UseYawAcceleration { get; set; } // 0xB8 (184)
		
		[ContainerField(185), LayoutImmutable, Blittable]
		public bool UsePitchAcceleration { get; set; } // 0xB9 (185)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 334053853:
					EyePosOffset = (Vec3) p_Value;
					break;

				case 3854254263:
					StickyBoxScale = (Vec3) p_Value;
					break;

				case 3981710610:
					SnapDistanceScale = (Vec3) p_Value;
					break;

				case 425834884:
					SnapBoxScale = (Vec3) p_Value;
					break;

				case 1797517697:
					StickyDistanceScale = (Vec3) p_Value;
					break;

				case 1511134867:
					MaxAcceleration = (Vec2) p_Value;
					break;

				case 3904446687:
					AccelerationDamping = (float) p_Value;
					break;

				case 438577286:
					AccelerationInputThreshold = (float) p_Value;
					break;

				case 609974796:
					AccelerationMultiplier = (float) p_Value;
					break;

				case 2257519106:
					SquaredAcceleration = (float) p_Value;
					break;

				case 2553748136:
					YawSpeedStrength = (float) p_Value;
					break;

				case 1758785415:
					ZoomedInputPolynomial = (List<float>) p_Value;
					break;

				case 805561701:
					AccelerationTimeThreshold = (float) p_Value;
					break;

				case 422416875:
					AttractDistanceFallOff = (List<float>) p_Value;
					break;

				case 583637228:
					AttractUserInputMultiplier = (float) p_Value;
					break;

				case 2072441956:
					AttractOwnSpeedInfluence = (float) p_Value;
					break;

				case 4195244099:
					AttractTargetSpeedInfluence = (float) p_Value;
					break;

				case 3256866282:
					AttractOwnRequiredMovementForMaximumAttract = (float) p_Value;
					break;

				case 3874172161:
					AttractStartInputThreshold = (float) p_Value;
					break;

				case 2845655516:
					AttractZoomingMultiplier = (float) p_Value;
					break;

				case 286135002:
					AttractZoomingPostTime = (float) p_Value;
					break;

				case 4291196522:
					AttractYawStrength = (float) p_Value;
					break;

				case 2360266947:
					AttractPitchStrength = (float) p_Value;
					break;

				case 1028465505:
					PitchSpeedStrength = (float) p_Value;
					break;

				case 2537844656:
					AttractSoftZone = (float) p_Value;
					break;

				case 1051263345:
					InputPolynomial = (List<float>) p_Value;
					break;

				case 2274673707:
					UseYawAcceleration = (bool) p_Value;
					break;

				case 142087170:
					UsePitchAcceleration = (bool) p_Value;
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
				case 334053853:
					return EyePosOffset;

				case 3854254263:
					return StickyBoxScale;

				case 3981710610:
					return SnapDistanceScale;

				case 425834884:
					return SnapBoxScale;

				case 1797517697:
					return StickyDistanceScale;

				case 1511134867:
					return MaxAcceleration;

				case 3904446687:
					return AccelerationDamping;

				case 438577286:
					return AccelerationInputThreshold;

				case 609974796:
					return AccelerationMultiplier;

				case 2257519106:
					return SquaredAcceleration;

				case 2553748136:
					return YawSpeedStrength;

				case 1758785415:
					return ZoomedInputPolynomial;

				case 805561701:
					return AccelerationTimeThreshold;

				case 422416875:
					return AttractDistanceFallOff;

				case 583637228:
					return AttractUserInputMultiplier;

				case 2072441956:
					return AttractOwnSpeedInfluence;

				case 4195244099:
					return AttractTargetSpeedInfluence;

				case 3256866282:
					return AttractOwnRequiredMovementForMaximumAttract;

				case 3874172161:
					return AttractStartInputThreshold;

				case 2845655516:
					return AttractZoomingMultiplier;

				case 286135002:
					return AttractZoomingPostTime;

				case 4291196522:
					return AttractYawStrength;

				case 2360266947:
					return AttractPitchStrength;

				case 1028465505:
					return PitchSpeedStrength;

				case 2537844656:
					return AttractSoftZone;

				case 1051263345:
					return InputPolynomial;

				case 2274673707:
					return UseYawAcceleration;

				case 142087170:
					return UsePitchAcceleration;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 334053853:
					return typeof(SoldierAimAssistData).GetProperty(nameof(EyePosOffset));

				case 3854254263:
					return typeof(SoldierAimAssistData).GetProperty(nameof(StickyBoxScale));

				case 3981710610:
					return typeof(SoldierAimAssistData).GetProperty(nameof(SnapDistanceScale));

				case 425834884:
					return typeof(SoldierAimAssistData).GetProperty(nameof(SnapBoxScale));

				case 1797517697:
					return typeof(SoldierAimAssistData).GetProperty(nameof(StickyDistanceScale));

				case 1511134867:
					return typeof(SoldierAimAssistData).GetProperty(nameof(MaxAcceleration));

				case 3904446687:
					return typeof(SoldierAimAssistData).GetProperty(nameof(AccelerationDamping));

				case 438577286:
					return typeof(SoldierAimAssistData).GetProperty(nameof(AccelerationInputThreshold));

				case 609974796:
					return typeof(SoldierAimAssistData).GetProperty(nameof(AccelerationMultiplier));

				case 2257519106:
					return typeof(SoldierAimAssistData).GetProperty(nameof(SquaredAcceleration));

				case 2553748136:
					return typeof(SoldierAimAssistData).GetProperty(nameof(YawSpeedStrength));

				case 1758785415:
					return typeof(SoldierAimAssistData).GetProperty(nameof(ZoomedInputPolynomial));

				case 805561701:
					return typeof(SoldierAimAssistData).GetProperty(nameof(AccelerationTimeThreshold));

				case 422416875:
					return typeof(SoldierAimAssistData).GetProperty(nameof(AttractDistanceFallOff));

				case 583637228:
					return typeof(SoldierAimAssistData).GetProperty(nameof(AttractUserInputMultiplier));

				case 2072441956:
					return typeof(SoldierAimAssistData).GetProperty(nameof(AttractOwnSpeedInfluence));

				case 4195244099:
					return typeof(SoldierAimAssistData).GetProperty(nameof(AttractTargetSpeedInfluence));

				case 3256866282:
					return typeof(SoldierAimAssistData).GetProperty(nameof(AttractOwnRequiredMovementForMaximumAttract));

				case 3874172161:
					return typeof(SoldierAimAssistData).GetProperty(nameof(AttractStartInputThreshold));

				case 2845655516:
					return typeof(SoldierAimAssistData).GetProperty(nameof(AttractZoomingMultiplier));

				case 286135002:
					return typeof(SoldierAimAssistData).GetProperty(nameof(AttractZoomingPostTime));

				case 4291196522:
					return typeof(SoldierAimAssistData).GetProperty(nameof(AttractYawStrength));

				case 2360266947:
					return typeof(SoldierAimAssistData).GetProperty(nameof(AttractPitchStrength));

				case 1028465505:
					return typeof(SoldierAimAssistData).GetProperty(nameof(PitchSpeedStrength));

				case 2537844656:
					return typeof(SoldierAimAssistData).GetProperty(nameof(AttractSoftZone));

				case 1051263345:
					return typeof(SoldierAimAssistData).GetProperty(nameof(InputPolynomial));

				case 2274673707:
					return typeof(SoldierAimAssistData).GetProperty(nameof(UseYawAcceleration));

				case 142087170:
					return typeof(SoldierAimAssistData).GetProperty(nameof(UsePitchAcceleration));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
