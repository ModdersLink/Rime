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
	[ContainerType(Alignment: 16,  Flags: 53, Size: 192)]
	public class SoldierAimAssistData : 
		GameDataContainer
	{
		protected Vec3 m_EyePosOffset = new Vec3();
		[ContainerField(Name: "EyePosOffset", Offset: 16, NameHash: 334053853, Flags: 53289), Homogeneous, LayoutImmutable, Blittable]
		public Vec3 EyePosOffset { get { return m_EyePosOffset; } set { if (OnPropertyChanging("SoldierAimAssistData." + nameof(EyePosOffset), this, m_EyePosOffset, value)) m_EyePosOffset = value; } } // 0x10 (16)
		
		protected Vec3 m_StickyBoxScale = new Vec3();
		[ContainerField(Name: "StickyBoxScale", Offset: 32, NameHash: 3854254263, Flags: 53289), Homogeneous, LayoutImmutable, Blittable]
		public Vec3 StickyBoxScale { get { return m_StickyBoxScale; } set { if (OnPropertyChanging("SoldierAimAssistData." + nameof(StickyBoxScale), this, m_StickyBoxScale, value)) m_StickyBoxScale = value; } } // 0x20 (32)
		
		protected Vec3 m_SnapDistanceScale = new Vec3();
		[ContainerField(Name: "SnapDistanceScale", Offset: 48, NameHash: 3981710610, Flags: 53289), Homogeneous, LayoutImmutable, Blittable]
		public Vec3 SnapDistanceScale { get { return m_SnapDistanceScale; } set { if (OnPropertyChanging("SoldierAimAssistData." + nameof(SnapDistanceScale), this, m_SnapDistanceScale, value)) m_SnapDistanceScale = value; } } // 0x30 (48)
		
		protected Vec3 m_SnapBoxScale = new Vec3();
		[ContainerField(Name: "SnapBoxScale", Offset: 64, NameHash: 425834884, Flags: 53289), Homogeneous, LayoutImmutable, Blittable]
		public Vec3 SnapBoxScale { get { return m_SnapBoxScale; } set { if (OnPropertyChanging("SoldierAimAssistData." + nameof(SnapBoxScale), this, m_SnapBoxScale, value)) m_SnapBoxScale = value; } } // 0x40 (64)
		
		protected Vec3 m_StickyDistanceScale = new Vec3();
		[ContainerField(Name: "StickyDistanceScale", Offset: 80, NameHash: 1797517697, Flags: 53289), Homogeneous, LayoutImmutable, Blittable]
		public Vec3 StickyDistanceScale { get { return m_StickyDistanceScale; } set { if (OnPropertyChanging("SoldierAimAssistData." + nameof(StickyDistanceScale), this, m_StickyDistanceScale, value)) m_StickyDistanceScale = value; } } // 0x50 (80)
		
		protected Vec2 m_MaxAcceleration = new Vec2();
		[ContainerField(Name: "MaxAcceleration", Offset: 96, NameHash: 1511134867, Flags: 53289), Homogeneous, LayoutImmutable, Blittable]
		public Vec2 MaxAcceleration { get { return m_MaxAcceleration; } set { if (OnPropertyChanging("SoldierAimAssistData." + nameof(MaxAcceleration), this, m_MaxAcceleration, value)) m_MaxAcceleration = value; } } // 0x60 (96)
		
		protected float m_AccelerationDamping = new float();
		[ContainerField(Name: "AccelerationDamping", Offset: 104, NameHash: 3904446687, Flags: 49469), LayoutImmutable, Blittable]
		public float AccelerationDamping { get { return m_AccelerationDamping; } set { if (OnPropertyChanging("SoldierAimAssistData." + nameof(AccelerationDamping), this, m_AccelerationDamping, value)) m_AccelerationDamping = value; } } // 0x68 (104)
		
		protected float m_AccelerationInputThreshold = new float();
		[ContainerField(Name: "AccelerationInputThreshold", Offset: 108, NameHash: 438577286, Flags: 49469), LayoutImmutable, Blittable]
		public float AccelerationInputThreshold { get { return m_AccelerationInputThreshold; } set { if (OnPropertyChanging("SoldierAimAssistData." + nameof(AccelerationInputThreshold), this, m_AccelerationInputThreshold, value)) m_AccelerationInputThreshold = value; } } // 0x6C (108)
		
		protected float m_AccelerationMultiplier = new float();
		[ContainerField(Name: "AccelerationMultiplier", Offset: 112, NameHash: 609974796, Flags: 49469), LayoutImmutable, Blittable]
		public float AccelerationMultiplier { get { return m_AccelerationMultiplier; } set { if (OnPropertyChanging("SoldierAimAssistData." + nameof(AccelerationMultiplier), this, m_AccelerationMultiplier, value)) m_AccelerationMultiplier = value; } } // 0x70 (112)
		
		protected float m_SquaredAcceleration = new float();
		[ContainerField(Name: "SquaredAcceleration", Offset: 116, NameHash: 2257519106, Flags: 49469), LayoutImmutable, Blittable]
		public float SquaredAcceleration { get { return m_SquaredAcceleration; } set { if (OnPropertyChanging("SoldierAimAssistData." + nameof(SquaredAcceleration), this, m_SquaredAcceleration, value)) m_SquaredAcceleration = value; } } // 0x74 (116)
		
		protected float m_YawSpeedStrength = new float();
		[ContainerField(Name: "YawSpeedStrength", Offset: 120, NameHash: 2553748136, Flags: 49469), LayoutImmutable, Blittable]
		public float YawSpeedStrength { get { return m_YawSpeedStrength; } set { if (OnPropertyChanging("SoldierAimAssistData." + nameof(YawSpeedStrength), this, m_YawSpeedStrength, value)) m_YawSpeedStrength = value; } } // 0x78 (120)
		
		protected List<float> m_ZoomedInputPolynomial = new List<float>();
		[ContainerField(Name: "ZoomedInputPolynomial", Offset: 124, NameHash: 1758785415, Flags: 65)]
		public List<float> ZoomedInputPolynomial { get { return m_ZoomedInputPolynomial; } set { if (OnPropertyChanging("SoldierAimAssistData." + nameof(ZoomedInputPolynomial), this, m_ZoomedInputPolynomial, value)) m_ZoomedInputPolynomial = value; } } // 0x7C (124)
		
		protected float m_AccelerationTimeThreshold = new float();
		[ContainerField(Name: "AccelerationTimeThreshold", Offset: 128, NameHash: 805561701, Flags: 49469), LayoutImmutable, Blittable]
		public float AccelerationTimeThreshold { get { return m_AccelerationTimeThreshold; } set { if (OnPropertyChanging("SoldierAimAssistData." + nameof(AccelerationTimeThreshold), this, m_AccelerationTimeThreshold, value)) m_AccelerationTimeThreshold = value; } } // 0x80 (128)
		
		protected List<float> m_AttractDistanceFallOff = new List<float>();
		[ContainerField(Name: "AttractDistanceFallOff", Offset: 132, NameHash: 422416875, Flags: 65)]
		public List<float> AttractDistanceFallOff { get { return m_AttractDistanceFallOff; } set { if (OnPropertyChanging("SoldierAimAssistData." + nameof(AttractDistanceFallOff), this, m_AttractDistanceFallOff, value)) m_AttractDistanceFallOff = value; } } // 0x84 (132)
		
		protected float m_AttractUserInputMultiplier = new float();
		[ContainerField(Name: "AttractUserInputMultiplier", Offset: 136, NameHash: 583637228, Flags: 49469), LayoutImmutable, Blittable]
		public float AttractUserInputMultiplier { get { return m_AttractUserInputMultiplier; } set { if (OnPropertyChanging("SoldierAimAssistData." + nameof(AttractUserInputMultiplier), this, m_AttractUserInputMultiplier, value)) m_AttractUserInputMultiplier = value; } } // 0x88 (136)
		
		protected float m_AttractOwnSpeedInfluence = new float();
		[ContainerField(Name: "AttractOwnSpeedInfluence", Offset: 140, NameHash: 2072441956, Flags: 49469), LayoutImmutable, Blittable]
		public float AttractOwnSpeedInfluence { get { return m_AttractOwnSpeedInfluence; } set { if (OnPropertyChanging("SoldierAimAssistData." + nameof(AttractOwnSpeedInfluence), this, m_AttractOwnSpeedInfluence, value)) m_AttractOwnSpeedInfluence = value; } } // 0x8C (140)
		
		protected float m_AttractTargetSpeedInfluence = new float();
		[ContainerField(Name: "AttractTargetSpeedInfluence", Offset: 144, NameHash: 4195244099, Flags: 49469), LayoutImmutable, Blittable]
		public float AttractTargetSpeedInfluence { get { return m_AttractTargetSpeedInfluence; } set { if (OnPropertyChanging("SoldierAimAssistData." + nameof(AttractTargetSpeedInfluence), this, m_AttractTargetSpeedInfluence, value)) m_AttractTargetSpeedInfluence = value; } } // 0x90 (144)
		
		protected float m_AttractOwnRequiredMovementForMaximumAttract = new float();
		[ContainerField(Name: "AttractOwnRequiredMovementForMaximumAttract", Offset: 148, NameHash: 3256866282, Flags: 49469), LayoutImmutable, Blittable]
		public float AttractOwnRequiredMovementForMaximumAttract { get { return m_AttractOwnRequiredMovementForMaximumAttract; } set { if (OnPropertyChanging("SoldierAimAssistData." + nameof(AttractOwnRequiredMovementForMaximumAttract), this, m_AttractOwnRequiredMovementForMaximumAttract, value)) m_AttractOwnRequiredMovementForMaximumAttract = value; } } // 0x94 (148)
		
		protected float m_AttractStartInputThreshold = new float();
		[ContainerField(Name: "AttractStartInputThreshold", Offset: 152, NameHash: 3874172161, Flags: 49469), LayoutImmutable, Blittable]
		public float AttractStartInputThreshold { get { return m_AttractStartInputThreshold; } set { if (OnPropertyChanging("SoldierAimAssistData." + nameof(AttractStartInputThreshold), this, m_AttractStartInputThreshold, value)) m_AttractStartInputThreshold = value; } } // 0x98 (152)
		
		protected float m_AttractZoomingMultiplier = new float();
		[ContainerField(Name: "AttractZoomingMultiplier", Offset: 156, NameHash: 2845655516, Flags: 49469), LayoutImmutable, Blittable]
		public float AttractZoomingMultiplier { get { return m_AttractZoomingMultiplier; } set { if (OnPropertyChanging("SoldierAimAssistData." + nameof(AttractZoomingMultiplier), this, m_AttractZoomingMultiplier, value)) m_AttractZoomingMultiplier = value; } } // 0x9C (156)
		
		protected float m_AttractZoomingPostTime = new float();
		[ContainerField(Name: "AttractZoomingPostTime", Offset: 160, NameHash: 286135002, Flags: 49469), LayoutImmutable, Blittable]
		public float AttractZoomingPostTime { get { return m_AttractZoomingPostTime; } set { if (OnPropertyChanging("SoldierAimAssistData." + nameof(AttractZoomingPostTime), this, m_AttractZoomingPostTime, value)) m_AttractZoomingPostTime = value; } } // 0xA0 (160)
		
		protected float m_AttractYawStrength = new float();
		[ContainerField(Name: "AttractYawStrength", Offset: 164, NameHash: 4291196522, Flags: 49469), LayoutImmutable, Blittable]
		public float AttractYawStrength { get { return m_AttractYawStrength; } set { if (OnPropertyChanging("SoldierAimAssistData." + nameof(AttractYawStrength), this, m_AttractYawStrength, value)) m_AttractYawStrength = value; } } // 0xA4 (164)
		
		protected float m_AttractPitchStrength = new float();
		[ContainerField(Name: "AttractPitchStrength", Offset: 168, NameHash: 2360266947, Flags: 49469), LayoutImmutable, Blittable]
		public float AttractPitchStrength { get { return m_AttractPitchStrength; } set { if (OnPropertyChanging("SoldierAimAssistData." + nameof(AttractPitchStrength), this, m_AttractPitchStrength, value)) m_AttractPitchStrength = value; } } // 0xA8 (168)
		
		protected float m_PitchSpeedStrength = new float();
		[ContainerField(Name: "PitchSpeedStrength", Offset: 172, NameHash: 1028465505, Flags: 49469), LayoutImmutable, Blittable]
		public float PitchSpeedStrength { get { return m_PitchSpeedStrength; } set { if (OnPropertyChanging("SoldierAimAssistData." + nameof(PitchSpeedStrength), this, m_PitchSpeedStrength, value)) m_PitchSpeedStrength = value; } } // 0xAC (172)
		
		protected float m_AttractSoftZone = new float();
		[ContainerField(Name: "AttractSoftZone", Offset: 176, NameHash: 2537844656, Flags: 49469), LayoutImmutable, Blittable]
		public float AttractSoftZone { get { return m_AttractSoftZone; } set { if (OnPropertyChanging("SoldierAimAssistData." + nameof(AttractSoftZone), this, m_AttractSoftZone, value)) m_AttractSoftZone = value; } } // 0xB0 (176)
		
		protected List<float> m_InputPolynomial = new List<float>();
		[ContainerField(Name: "InputPolynomial", Offset: 180, NameHash: 1051263345, Flags: 65)]
		public List<float> InputPolynomial { get { return m_InputPolynomial; } set { if (OnPropertyChanging("SoldierAimAssistData." + nameof(InputPolynomial), this, m_InputPolynomial, value)) m_InputPolynomial = value; } } // 0xB4 (180)
		
		protected bool m_UseYawAcceleration = new bool();
		[ContainerField(Name: "UseYawAcceleration", Offset: 184, NameHash: 2274673707, Flags: 49325), LayoutImmutable, Blittable]
		public bool UseYawAcceleration { get { return m_UseYawAcceleration; } set { if (OnPropertyChanging("SoldierAimAssistData." + nameof(UseYawAcceleration), this, m_UseYawAcceleration, value)) m_UseYawAcceleration = value; } } // 0xB8 (184)
		
		protected bool m_UsePitchAcceleration = new bool();
		[ContainerField(Name: "UsePitchAcceleration", Offset: 185, NameHash: 142087170, Flags: 49325), LayoutImmutable, Blittable]
		public bool UsePitchAcceleration { get { return m_UsePitchAcceleration; } set { if (OnPropertyChanging("SoldierAimAssistData." + nameof(UsePitchAcceleration), this, m_UsePitchAcceleration, value)) m_UsePitchAcceleration = value; } } // 0xB9 (185)
		
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
