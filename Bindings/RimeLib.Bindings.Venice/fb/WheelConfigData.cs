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
	[ContainerType(Alignment: 16,  Flags: 53, Size: 384)]
	public class WheelConfigData : 
		DataContainer
	{
		protected Vec3 m_Offset = new Vec3();
		[ContainerField(Name: "Offset", Offset: 16, NameHash: 2871410728, Flags: 53289), Homogeneous, LayoutImmutable, Blittable]
		public Vec3 Offset { get { return m_Offset; } set { if (OnPropertyChanging("WheelConfigData." + nameof(Offset), this, m_Offset, value)) m_Offset = value; } } // 0x10 (16)
		
		protected Vec3 m_Inertia = new Vec3();
		[ContainerField(Name: "Inertia", Offset: 32, NameHash: 1681436809, Flags: 53289), Homogeneous, LayoutImmutable, Blittable]
		public Vec3 Inertia { get { return m_Inertia; } set { if (OnPropertyChanging("WheelConfigData." + nameof(Inertia), this, m_Inertia, value)) m_Inertia = value; } } // 0x20 (32)
		
		protected CtrRef<RotationBodyData> m_RotationBody = new CtrRef<RotationBodyData>();
		[ContainerField(Name: "RotationBody", Offset: 48, NameHash: 3148736225, Flags: 53)]
		public CtrRef<RotationBodyData> RotationBody { get { return m_RotationBody; } set { if (OnPropertyChanging("WheelConfigData." + nameof(RotationBody), this, m_RotationBody, value)) m_RotationBody = value; } } // 0x30 (48)
		
		protected SphereCollisionData m_SphereCollision = new SphereCollisionData();
		[ContainerField(Name: "SphereCollision", Offset: 52, NameHash: 2517711074, Flags: 41)]
		public SphereCollisionData SphereCollision { get { return m_SphereCollision; } set { if (OnPropertyChanging("WheelConfigData." + nameof(SphereCollision), this, m_SphereCollision, value)) m_SphereCollision = value; } } // 0x34 (52)
		
		protected SpringData m_Spring = new SpringData();
		[ContainerField(Name: "Spring", Offset: 64, NameHash: 3324856916, Flags: 41)]
		public SpringData Spring { get { return m_Spring; } set { if (OnPropertyChanging("WheelConfigData." + nameof(Spring), this, m_Spring, value)) m_Spring = value; } } // 0x40 (64)
		
		protected float m_Mass = new float();
		[ContainerField(Name: "Mass", Offset: 100, NameHash: 2088779625, Flags: 49469), LayoutImmutable, Blittable]
		public float Mass { get { return m_Mass; } set { if (OnPropertyChanging("WheelConfigData." + nameof(Mass), this, m_Mass, value)) m_Mass = value; } } // 0x64 (100)
		
		protected float m_Radius = new float();
		[ContainerField(Name: "Radius", Offset: 104, NameHash: 3298407133, Flags: 49469), LayoutImmutable, Blittable]
		public float Radius { get { return m_Radius; } set { if (OnPropertyChanging("WheelConfigData." + nameof(Radius), this, m_Radius, value)) m_Radius = value; } } // 0x68 (104)
		
		protected float m_Width = new float();
		[ContainerField(Name: "Width", Offset: 108, NameHash: 226981187, Flags: 49469), LayoutImmutable, Blittable]
		public float Width { get { return m_Width; } set { if (OnPropertyChanging("WheelConfigData." + nameof(Width), this, m_Width, value)) m_Width = value; } } // 0x6C (108)
		
		protected float m_RollingResistanceInternalBaseFactor = new float();
		[ContainerField(Name: "RollingResistanceInternalBaseFactor", Offset: 112, NameHash: 313472228, Flags: 49469), LayoutImmutable, Blittable]
		public float RollingResistanceInternalBaseFactor { get { return m_RollingResistanceInternalBaseFactor; } set { if (OnPropertyChanging("WheelConfigData." + nameof(RollingResistanceInternalBaseFactor), this, m_RollingResistanceInternalBaseFactor, value)) m_RollingResistanceInternalBaseFactor = value; } } // 0x70 (112)
		
		protected float m_RollingResistanceBaseFactor = new float();
		[ContainerField(Name: "RollingResistanceBaseFactor", Offset: 116, NameHash: 1977241987, Flags: 49469), LayoutImmutable, Blittable]
		public float RollingResistanceBaseFactor { get { return m_RollingResistanceBaseFactor; } set { if (OnPropertyChanging("WheelConfigData." + nameof(RollingResistanceBaseFactor), this, m_RollingResistanceBaseFactor, value)) m_RollingResistanceBaseFactor = value; } } // 0x74 (116)
		
		protected float m_RollingResistanceVelocityFactor = new float();
		[ContainerField(Name: "RollingResistanceVelocityFactor", Offset: 120, NameHash: 3215467073, Flags: 49469), LayoutImmutable, Blittable]
		public float RollingResistanceVelocityFactor { get { return m_RollingResistanceVelocityFactor; } set { if (OnPropertyChanging("WheelConfigData." + nameof(RollingResistanceVelocityFactor), this, m_RollingResistanceVelocityFactor, value)) m_RollingResistanceVelocityFactor = value; } } // 0x78 (120)
		
		protected float m_EngineBrakeVelocityFactor = new float();
		[ContainerField(Name: "EngineBrakeVelocityFactor", Offset: 124, NameHash: 3527754894, Flags: 49469), LayoutImmutable, Blittable]
		public float EngineBrakeVelocityFactor { get { return m_EngineBrakeVelocityFactor; } set { if (OnPropertyChanging("WheelConfigData." + nameof(EngineBrakeVelocityFactor), this, m_EngineBrakeVelocityFactor, value)) m_EngineBrakeVelocityFactor = value; } } // 0x7C (124)
		
		protected float m_EngineBrakeMinFactor = new float();
		[ContainerField(Name: "EngineBrakeMinFactor", Offset: 128, NameHash: 1444818995, Flags: 49469), LayoutImmutable, Blittable]
		public float EngineBrakeMinFactor { get { return m_EngineBrakeMinFactor; } set { if (OnPropertyChanging("WheelConfigData." + nameof(EngineBrakeMinFactor), this, m_EngineBrakeMinFactor, value)) m_EngineBrakeMinFactor = value; } } // 0x80 (128)
		
		protected float m_EngineBrakeMaxFactor = new float();
		[ContainerField(Name: "EngineBrakeMaxFactor", Offset: 132, NameHash: 1018553005, Flags: 49469), LayoutImmutable, Blittable]
		public float EngineBrakeMaxFactor { get { return m_EngineBrakeMaxFactor; } set { if (OnPropertyChanging("WheelConfigData." + nameof(EngineBrakeMaxFactor), this, m_EngineBrakeMaxFactor, value)) m_EngineBrakeMaxFactor = value; } } // 0x84 (132)
		
		protected List<Vec2> m_TransmissionLoss = new List<Vec2>();
		[ContainerField(Name: "TransmissionLoss", Offset: 136, NameHash: 1052226128, Flags: 65)]
		public List<Vec2> TransmissionLoss { get { return m_TransmissionLoss; } set { if (OnPropertyChanging("WheelConfigData." + nameof(TransmissionLoss), this, m_TransmissionLoss, value)) m_TransmissionLoss = value; } } // 0x88 (136)
		
		protected float m_DiffGearRatio = new float();
		[ContainerField(Name: "DiffGearRatio", Offset: 140, NameHash: 424954360, Flags: 49469), LayoutImmutable, Blittable]
		public float DiffGearRatio { get { return m_DiffGearRatio; } set { if (OnPropertyChanging("WheelConfigData." + nameof(DiffGearRatio), this, m_DiffGearRatio, value)) m_DiffGearRatio = value; } } // 0x8C (140)
		
		protected float m_LowSpeedSteeringSensitivity = new float();
		[ContainerField(Name: "LowSpeedSteeringSensitivity", Offset: 144, NameHash: 4128407246, Flags: 49469), LayoutImmutable, Blittable]
		public float LowSpeedSteeringSensitivity { get { return m_LowSpeedSteeringSensitivity; } set { if (OnPropertyChanging("WheelConfigData." + nameof(LowSpeedSteeringSensitivity), this, m_LowSpeedSteeringSensitivity, value)) m_LowSpeedSteeringSensitivity = value; } } // 0x90 (144)
		
		protected float m_MidSpeedSteeringSensitivity = new float();
		[ContainerField(Name: "MidSpeedSteeringSensitivity", Offset: 148, NameHash: 2353241178, Flags: 49469), LayoutImmutable, Blittable]
		public float MidSpeedSteeringSensitivity { get { return m_MidSpeedSteeringSensitivity; } set { if (OnPropertyChanging("WheelConfigData." + nameof(MidSpeedSteeringSensitivity), this, m_MidSpeedSteeringSensitivity, value)) m_MidSpeedSteeringSensitivity = value; } } // 0x94 (148)
		
		protected float m_HighSpeedSteeringSensitivity = new float();
		[ContainerField(Name: "HighSpeedSteeringSensitivity", Offset: 152, NameHash: 1468359572, Flags: 49469), LayoutImmutable, Blittable]
		public float HighSpeedSteeringSensitivity { get { return m_HighSpeedSteeringSensitivity; } set { if (OnPropertyChanging("WheelConfigData." + nameof(HighSpeedSteeringSensitivity), this, m_HighSpeedSteeringSensitivity, value)) m_HighSpeedSteeringSensitivity = value; } } // 0x98 (152)
		
		protected float m_SensitivityRangeScale = new float();
		[ContainerField(Name: "SensitivityRangeScale", Offset: 156, NameHash: 1713265071, Flags: 49469), LayoutImmutable, Blittable]
		public float SensitivityRangeScale { get { return m_SensitivityRangeScale; } set { if (OnPropertyChanging("WheelConfigData." + nameof(SensitivityRangeScale), this, m_SensitivityRangeScale, value)) m_SensitivityRangeScale = value; } } // 0x9C (156)
		
		protected float m_LowSpeedSteeringSensitivityLimit = new float();
		[ContainerField(Name: "LowSpeedSteeringSensitivityLimit", Offset: 160, NameHash: 1606276251, Flags: 49469), LayoutImmutable, Blittable]
		public float LowSpeedSteeringSensitivityLimit { get { return m_LowSpeedSteeringSensitivityLimit; } set { if (OnPropertyChanging("WheelConfigData." + nameof(LowSpeedSteeringSensitivityLimit), this, m_LowSpeedSteeringSensitivityLimit, value)) m_LowSpeedSteeringSensitivityLimit = value; } } // 0xA0 (160)
		
		protected float m_MidSpeedSteeringSensitivityLimit = new float();
		[ContainerField(Name: "MidSpeedSteeringSensitivityLimit", Offset: 164, NameHash: 1766583183, Flags: 49469), LayoutImmutable, Blittable]
		public float MidSpeedSteeringSensitivityLimit { get { return m_MidSpeedSteeringSensitivityLimit; } set { if (OnPropertyChanging("WheelConfigData." + nameof(MidSpeedSteeringSensitivityLimit), this, m_MidSpeedSteeringSensitivityLimit, value)) m_MidSpeedSteeringSensitivityLimit = value; } } // 0xA4 (164)
		
		protected float m_HighSpeedSteeringSensitivityLimit = new float();
		[ContainerField(Name: "HighSpeedSteeringSensitivityLimit", Offset: 168, NameHash: 525306113, Flags: 49469), LayoutImmutable, Blittable]
		public float HighSpeedSteeringSensitivityLimit { get { return m_HighSpeedSteeringSensitivityLimit; } set { if (OnPropertyChanging("WheelConfigData." + nameof(HighSpeedSteeringSensitivityLimit), this, m_HighSpeedSteeringSensitivityLimit, value)) m_HighSpeedSteeringSensitivityLimit = value; } } // 0xA8 (168)
		
		protected float m_TrackedTurnSpeedLimit = new float();
		[ContainerField(Name: "TrackedTurnSpeedLimit", Offset: 172, NameHash: 2598948484, Flags: 49469), LayoutImmutable, Blittable]
		public float TrackedTurnSpeedLimit { get { return m_TrackedTurnSpeedLimit; } set { if (OnPropertyChanging("WheelConfigData." + nameof(TrackedTurnSpeedLimit), this, m_TrackedTurnSpeedLimit, value)) m_TrackedTurnSpeedLimit = value; } } // 0xAC (172)
		
		protected float m_TrackedForwardSpeedLimit = new float();
		[ContainerField(Name: "TrackedForwardSpeedLimit", Offset: 176, NameHash: 1013932930, Flags: 49469), LayoutImmutable, Blittable]
		public float TrackedForwardSpeedLimit { get { return m_TrackedForwardSpeedLimit; } set { if (OnPropertyChanging("WheelConfigData." + nameof(TrackedForwardSpeedLimit), this, m_TrackedForwardSpeedLimit, value)) m_TrackedForwardSpeedLimit = value; } } // 0xB0 (176)
		
		protected CtrRef<Curve2D> m_SteerInertia = new CtrRef<Curve2D>();
		[ContainerField(Name: "SteerInertia", Offset: 180, NameHash: 848827836, Flags: 53)]
		public CtrRef<Curve2D> SteerInertia { get { return m_SteerInertia; } set { if (OnPropertyChanging("WheelConfigData." + nameof(SteerInertia), this, m_SteerInertia, value)) m_SteerInertia = value; } } // 0xB4 (180)
		
		protected List<SensitivityAtVelocity> m_SteeringSensitivity = new List<SensitivityAtVelocity>();
		[ContainerField(Name: "SteeringSensitivity", Offset: 184, NameHash: 1426555133, Flags: 65)]
		public List<SensitivityAtVelocity> SteeringSensitivity { get { return m_SteeringSensitivity; } set { if (OnPropertyChanging("WheelConfigData." + nameof(SteeringSensitivity), this, m_SteeringSensitivity, value)) m_SteeringSensitivity = value; } } // 0xB8 (184)
		
		protected float m_SlopeGripMinAngle = new float();
		[ContainerField(Name: "SlopeGripMinAngle", Offset: 188, NameHash: 2194066087, Flags: 49469), LayoutImmutable, Blittable]
		public float SlopeGripMinAngle { get { return m_SlopeGripMinAngle; } set { if (OnPropertyChanging("WheelConfigData." + nameof(SlopeGripMinAngle), this, m_SlopeGripMinAngle, value)) m_SlopeGripMinAngle = value; } } // 0xBC (188)
		
		protected float m_SlopeGripMaxAngle = new float();
		[ContainerField(Name: "SlopeGripMaxAngle", Offset: 192, NameHash: 1317962745, Flags: 49469), LayoutImmutable, Blittable]
		public float SlopeGripMaxAngle { get { return m_SlopeGripMaxAngle; } set { if (OnPropertyChanging("WheelConfigData." + nameof(SlopeGripMaxAngle), this, m_SlopeGripMaxAngle, value)) m_SlopeGripMaxAngle = value; } } // 0xC0 (192)
		
		protected int m_SlopeGripExponent = new int();
		[ContainerField(Name: "SlopeGripExponent", Offset: 196, NameHash: 1902079775, Flags: 49405), LayoutImmutable, Blittable]
		public int SlopeGripExponent { get { return m_SlopeGripExponent; } set { if (OnPropertyChanging("WheelConfigData." + nameof(SlopeGripExponent), this, m_SlopeGripExponent, value)) m_SlopeGripExponent = value; } } // 0xC4 (196)
		
		protected float m_OffGroundGravityModifier = new float();
		[ContainerField(Name: "OffGroundGravityModifier", Offset: 200, NameHash: 2849668638, Flags: 49469), LayoutImmutable, Blittable]
		public float OffGroundGravityModifier { get { return m_OffGroundGravityModifier; } set { if (OnPropertyChanging("WheelConfigData." + nameof(OffGroundGravityModifier), this, m_OffGroundGravityModifier, value)) m_OffGroundGravityModifier = value; } } // 0xC8 (200)
		
		protected float m_SideSlipAngleMaxSlipCondition = new float();
		[ContainerField(Name: "SideSlipAngleMaxSlipCondition", Offset: 204, NameHash: 3875040376, Flags: 49469), LayoutImmutable, Blittable]
		public float SideSlipAngleMaxSlipCondition { get { return m_SideSlipAngleMaxSlipCondition; } set { if (OnPropertyChanging("WheelConfigData." + nameof(SideSlipAngleMaxSlipCondition), this, m_SideSlipAngleMaxSlipCondition, value)) m_SideSlipAngleMaxSlipCondition = value; } } // 0xCC (204)
		
		protected float m_AngularVelocityMinSlipCondition = new float();
		[ContainerField(Name: "AngularVelocityMinSlipCondition", Offset: 208, NameHash: 3049185647, Flags: 49469), LayoutImmutable, Blittable]
		public float AngularVelocityMinSlipCondition { get { return m_AngularVelocityMinSlipCondition; } set { if (OnPropertyChanging("WheelConfigData." + nameof(AngularVelocityMinSlipCondition), this, m_AngularVelocityMinSlipCondition, value)) m_AngularVelocityMinSlipCondition = value; } } // 0xD0 (208)
		
		protected float m_WheelVelocityXMinSlipCondition = new float();
		[ContainerField(Name: "WheelVelocityXMinSlipCondition", Offset: 212, NameHash: 3555418854, Flags: 49469), LayoutImmutable, Blittable]
		public float WheelVelocityXMinSlipCondition { get { return m_WheelVelocityXMinSlipCondition; } set { if (OnPropertyChanging("WheelConfigData." + nameof(WheelVelocityXMinSlipCondition), this, m_WheelVelocityXMinSlipCondition, value)) m_WheelVelocityXMinSlipCondition = value; } } // 0xD4 (212)
		
		protected float m_WheelSlipRatioMaxSlipCondition = new float();
		[ContainerField(Name: "WheelSlipRatioMaxSlipCondition", Offset: 216, NameHash: 4035440, Flags: 49469), LayoutImmutable, Blittable]
		public float WheelSlipRatioMaxSlipCondition { get { return m_WheelSlipRatioMaxSlipCondition; } set { if (OnPropertyChanging("WheelConfigData." + nameof(WheelSlipRatioMaxSlipCondition), this, m_WheelSlipRatioMaxSlipCondition, value)) m_WheelSlipRatioMaxSlipCondition = value; } } // 0xD8 (216)
		
		protected float m_LongitudinalFrictionForceMaxFactor = new float();
		[ContainerField(Name: "LongitudinalFrictionForceMaxFactor", Offset: 220, NameHash: 4145733487, Flags: 49469), LayoutImmutable, Blittable]
		public float LongitudinalFrictionForceMaxFactor { get { return m_LongitudinalFrictionForceMaxFactor; } set { if (OnPropertyChanging("WheelConfigData." + nameof(LongitudinalFrictionForceMaxFactor), this, m_LongitudinalFrictionForceMaxFactor, value)) m_LongitudinalFrictionForceMaxFactor = value; } } // 0xDC (220)
		
		protected float m_LateralFrictionForceMaxFactor = new float();
		[ContainerField(Name: "LateralFrictionForceMaxFactor", Offset: 224, NameHash: 267896320, Flags: 49469), LayoutImmutable, Blittable]
		public float LateralFrictionForceMaxFactor { get { return m_LateralFrictionForceMaxFactor; } set { if (OnPropertyChanging("WheelConfigData." + nameof(LateralFrictionForceMaxFactor), this, m_LateralFrictionForceMaxFactor, value)) m_LateralFrictionForceMaxFactor = value; } } // 0xE0 (224)
		
		protected List<FrictionScaleAtVelocity> m_LongitudeFrictionScale = new List<FrictionScaleAtVelocity>();
		[ContainerField(Name: "LongitudeFrictionScale", Offset: 228, NameHash: 1528459772, Flags: 65)]
		public List<FrictionScaleAtVelocity> LongitudeFrictionScale { get { return m_LongitudeFrictionScale; } set { if (OnPropertyChanging("WheelConfigData." + nameof(LongitudeFrictionScale), this, m_LongitudeFrictionScale, value)) m_LongitudeFrictionScale = value; } } // 0xE4 (228)
		
		protected List<FrictionScaleAtVelocity> m_LattitudeFrictionScale = new List<FrictionScaleAtVelocity>();
		[ContainerField(Name: "LattitudeFrictionScale", Offset: 232, NameHash: 2093823291, Flags: 65)]
		public List<FrictionScaleAtVelocity> LattitudeFrictionScale { get { return m_LattitudeFrictionScale; } set { if (OnPropertyChanging("WheelConfigData." + nameof(LattitudeFrictionScale), this, m_LattitudeFrictionScale, value)) m_LattitudeFrictionScale = value; } } // 0xE8 (232)
		
		protected float m_WheelFrictionLattitudeBrakeScale = new float();
		[ContainerField(Name: "WheelFrictionLattitudeBrakeScale", Offset: 236, NameHash: 3639987319, Flags: 49469), LayoutImmutable, Blittable]
		public float WheelFrictionLattitudeBrakeScale { get { return m_WheelFrictionLattitudeBrakeScale; } set { if (OnPropertyChanging("WheelConfigData." + nameof(WheelFrictionLattitudeBrakeScale), this, m_WheelFrictionLattitudeBrakeScale, value)) m_WheelFrictionLattitudeBrakeScale = value; } } // 0xEC (236)
		
		protected float m_MaxSlipRatio = new float();
		[ContainerField(Name: "MaxSlipRatio", Offset: 240, NameHash: 435831062, Flags: 49469), LayoutImmutable, Blittable]
		public float MaxSlipRatio { get { return m_MaxSlipRatio; } set { if (OnPropertyChanging("WheelConfigData." + nameof(MaxSlipRatio), this, m_MaxSlipRatio, value)) m_MaxSlipRatio = value; } } // 0xF0 (240)
		
		protected float m_Resistance = new float();
		[ContainerField(Name: "Resistance", Offset: 244, NameHash: 61696806, Flags: 49469), LayoutImmutable, Blittable]
		public float Resistance { get { return m_Resistance; } set { if (OnPropertyChanging("WheelConfigData." + nameof(Resistance), this, m_Resistance, value)) m_Resistance = value; } } // 0xF4 (244)
		
		protected float m_FxTorqueRadiusMultiplier = new float();
		[ContainerField(Name: "FxTorqueRadiusMultiplier", Offset: 248, NameHash: 667791392, Flags: 49469), LayoutImmutable, Blittable]
		public float FxTorqueRadiusMultiplier { get { return m_FxTorqueRadiusMultiplier; } set { if (OnPropertyChanging("WheelConfigData." + nameof(FxTorqueRadiusMultiplier), this, m_FxTorqueRadiusMultiplier, value)) m_FxTorqueRadiusMultiplier = value; } } // 0xF8 (248)
		
		protected float m_FrictionMomentVelocityMin = new float();
		[ContainerField(Name: "FrictionMomentVelocityMin", Offset: 252, NameHash: 1187371114, Flags: 49469), LayoutImmutable, Blittable]
		public float FrictionMomentVelocityMin { get { return m_FrictionMomentVelocityMin; } set { if (OnPropertyChanging("WheelConfigData." + nameof(FrictionMomentVelocityMin), this, m_FrictionMomentVelocityMin, value)) m_FrictionMomentVelocityMin = value; } } // 0xFC (252)
		
		protected float m_FrictionMomentVelocityMax = new float();
		[ContainerField(Name: "FrictionMomentVelocityMax", Offset: 256, NameHash: 1187371380, Flags: 49469), LayoutImmutable, Blittable]
		public float FrictionMomentVelocityMax { get { return m_FrictionMomentVelocityMax; } set { if (OnPropertyChanging("WheelConfigData." + nameof(FrictionMomentVelocityMax), this, m_FrictionMomentVelocityMax, value)) m_FrictionMomentVelocityMax = value; } } // 0x100 (256)
		
		protected float m_FrictionMomentMultiplier = new float();
		[ContainerField(Name: "FrictionMomentMultiplier", Offset: 260, NameHash: 2140919388, Flags: 49469), LayoutImmutable, Blittable]
		public float FrictionMomentMultiplier { get { return m_FrictionMomentMultiplier; } set { if (OnPropertyChanging("WheelConfigData." + nameof(FrictionMomentMultiplier), this, m_FrictionMomentMultiplier, value)) m_FrictionMomentMultiplier = value; } } // 0x104 (260)
		
		protected float m_FrictionMomentMaxFactor = new float();
		[ContainerField(Name: "FrictionMomentMaxFactor", Offset: 264, NameHash: 862687406, Flags: 49469), LayoutImmutable, Blittable]
		public float FrictionMomentMaxFactor { get { return m_FrictionMomentMaxFactor; } set { if (OnPropertyChanging("WheelConfigData." + nameof(FrictionMomentMaxFactor), this, m_FrictionMomentMaxFactor, value)) m_FrictionMomentMaxFactor = value; } } // 0x108 (264)
		
		protected float m_BrakeFactor = new float();
		[ContainerField(Name: "BrakeFactor", Offset: 268, NameHash: 1705735991, Flags: 49469), LayoutImmutable, Blittable]
		public float BrakeFactor { get { return m_BrakeFactor; } set { if (OnPropertyChanging("WheelConfigData." + nameof(BrakeFactor), this, m_BrakeFactor, value)) m_BrakeFactor = value; } } // 0x10C (268)
		
		protected float m_BrakeForce = new float();
		[ContainerField(Name: "BrakeForce", Offset: 272, NameHash: 3435369031, Flags: 49469), LayoutImmutable, Blittable]
		public float BrakeForce { get { return m_BrakeForce; } set { if (OnPropertyChanging("WheelConfigData." + nameof(BrakeForce), this, m_BrakeForce, value)) m_BrakeForce = value; } } // 0x110 (272)
		
		protected float m_HandBrakeFactor = new float();
		[ContainerField(Name: "HandBrakeFactor", Offset: 276, NameHash: 575415412, Flags: 49469), LayoutImmutable, Blittable]
		public float HandBrakeFactor { get { return m_HandBrakeFactor; } set { if (OnPropertyChanging("WheelConfigData." + nameof(HandBrakeFactor), this, m_HandBrakeFactor, value)) m_HandBrakeFactor = value; } } // 0x114 (276)
		
		protected float m_HandBrakeForce = new float();
		[ContainerField(Name: "HandBrakeForce", Offset: 280, NameHash: 2880094372, Flags: 49469), LayoutImmutable, Blittable]
		public float HandBrakeForce { get { return m_HandBrakeForce; } set { if (OnPropertyChanging("WheelConfigData." + nameof(HandBrakeForce), this, m_HandBrakeForce, value)) m_HandBrakeForce = value; } } // 0x118 (280)
		
		protected float m_LateralPosK = new float();
		[ContainerField(Name: "LateralPosK", Offset: 284, NameHash: 1794073761, Flags: 49469), LayoutImmutable, Blittable]
		public float LateralPosK { get { return m_LateralPosK; } set { if (OnPropertyChanging("WheelConfigData." + nameof(LateralPosK), this, m_LateralPosK, value)) m_LateralPosK = value; } } // 0x11C (284)
		
		protected float m_LateralNegK = new float();
		[ContainerField(Name: "LateralNegK", Offset: 288, NameHash: 1793716961, Flags: 49469), LayoutImmutable, Blittable]
		public float LateralNegK { get { return m_LateralNegK; } set { if (OnPropertyChanging("WheelConfigData." + nameof(LateralNegK), this, m_LateralNegK, value)) m_LateralNegK = value; } } // 0x120 (288)
		
		protected float m_LongitudinalPosK = new float();
		[ContainerField(Name: "LongitudinalPosK", Offset: 292, NameHash: 2235876046, Flags: 49469), LayoutImmutable, Blittable]
		public float LongitudinalPosK { get { return m_LongitudinalPosK; } set { if (OnPropertyChanging("WheelConfigData." + nameof(LongitudinalPosK), this, m_LongitudinalPosK, value)) m_LongitudinalPosK = value; } } // 0x124 (292)
		
		protected float m_LongitudinalNegK = new float();
		[ContainerField(Name: "LongitudinalNegK", Offset: 296, NameHash: 2235083918, Flags: 49469), LayoutImmutable, Blittable]
		public float LongitudinalNegK { get { return m_LongitudinalNegK; } set { if (OnPropertyChanging("WheelConfigData." + nameof(LongitudinalNegK), this, m_LongitudinalNegK, value)) m_LongitudinalNegK = value; } } // 0x128 (296)
		
		protected float m_AlignMomScale = new float();
		[ContainerField(Name: "AlignMomScale", Offset: 300, NameHash: 3964733375, Flags: 49469), LayoutImmutable, Blittable]
		public float AlignMomScale { get { return m_AlignMomScale; } set { if (OnPropertyChanging("WheelConfigData." + nameof(AlignMomScale), this, m_AlignMomScale, value)) m_AlignMomScale = value; } } // 0x12C (300)
		
		protected float m_WheelBaseLateral = new float();
		[ContainerField(Name: "WheelBaseLateral", Offset: 304, NameHash: 29121024, Flags: 49469), LayoutImmutable, Blittable]
		public float WheelBaseLateral { get { return m_WheelBaseLateral; } set { if (OnPropertyChanging("WheelConfigData." + nameof(WheelBaseLateral), this, m_WheelBaseLateral, value)) m_WheelBaseLateral = value; } } // 0x130 (304)
		
		protected float m_WheelBaseLongitudinal = new float();
		[ContainerField(Name: "WheelBaseLongitudinal", Offset: 308, NameHash: 1965622255, Flags: 49469), LayoutImmutable, Blittable]
		public float WheelBaseLongitudinal { get { return m_WheelBaseLongitudinal; } set { if (OnPropertyChanging("WheelConfigData." + nameof(WheelBaseLongitudinal), this, m_WheelBaseLongitudinal, value)) m_WheelBaseLongitudinal = value; } } // 0x134 (308)
		
		protected int m_DrivingType = new int();
		[ContainerField(Name: "DrivingType", Offset: 312, NameHash: 3293344276, Flags: 49405), LayoutImmutable, Blittable]
		public int DrivingType { get { return m_DrivingType; } set { if (OnPropertyChanging("WheelConfigData." + nameof(DrivingType), this, m_DrivingType, value)) m_DrivingType = value; } } // 0x138 (312)
		
		protected int m_SteeringType = new int();
		[ContainerField(Name: "SteeringType", Offset: 316, NameHash: 2522217992, Flags: 49405), LayoutImmutable, Blittable]
		public int SteeringType { get { return m_SteeringType; } set { if (OnPropertyChanging("WheelConfigData." + nameof(SteeringType), this, m_SteeringType, value)) m_SteeringType = value; } } // 0x13C (316)
		
		protected int m_FrictionMethod = new int();
		[ContainerField(Name: "FrictionMethod", Offset: 320, NameHash: 512648344, Flags: 49405), LayoutImmutable, Blittable]
		public int FrictionMethod { get { return m_FrictionMethod; } set { if (OnPropertyChanging("WheelConfigData." + nameof(FrictionMethod), this, m_FrictionMethod, value)) m_FrictionMethod = value; } } // 0x140 (320)
		
		protected int m_AckermanDeviceType = new int();
		[ContainerField(Name: "AckermanDeviceType", Offset: 324, NameHash: 508374905, Flags: 49405), LayoutImmutable, Blittable]
		public int AckermanDeviceType { get { return m_AckermanDeviceType; } set { if (OnPropertyChanging("WheelConfigData." + nameof(AckermanDeviceType), this, m_AckermanDeviceType, value)) m_AckermanDeviceType = value; } } // 0x144 (324)
		
		protected float m_CollisionYawDampeningDuration = new float();
		[ContainerField(Name: "CollisionYawDampeningDuration", Offset: 328, NameHash: 1688291961, Flags: 49469), LayoutImmutable, Blittable]
		public float CollisionYawDampeningDuration { get { return m_CollisionYawDampeningDuration; } set { if (OnPropertyChanging("WheelConfigData." + nameof(CollisionYawDampeningDuration), this, m_CollisionYawDampeningDuration, value)) m_CollisionYawDampeningDuration = value; } } // 0x148 (328)
		
		protected float m_CollisionYawDampening = new float();
		[ContainerField(Name: "CollisionYawDampening", Offset: 332, NameHash: 659118567, Flags: 49469), LayoutImmutable, Blittable]
		public float CollisionYawDampening { get { return m_CollisionYawDampening; } set { if (OnPropertyChanging("WheelConfigData." + nameof(CollisionYawDampening), this, m_CollisionYawDampening, value)) m_CollisionYawDampening = value; } } // 0x14C (332)
		
		protected float m_ConstantSpringForceFrictionScale = new float();
		[ContainerField(Name: "ConstantSpringForceFrictionScale", Offset: 336, NameHash: 3176887917, Flags: 49469), LayoutImmutable, Blittable]
		public float ConstantSpringForceFrictionScale { get { return m_ConstantSpringForceFrictionScale; } set { if (OnPropertyChanging("WheelConfigData." + nameof(ConstantSpringForceFrictionScale), this, m_ConstantSpringForceFrictionScale, value)) m_ConstantSpringForceFrictionScale = value; } } // 0x150 (336)
		
		protected int m_RotationDirectionIndex = new int();
		[ContainerField(Name: "RotationDirectionIndex", Offset: 340, NameHash: 3008488874, Flags: 49405), LayoutImmutable, Blittable]
		public int RotationDirectionIndex { get { return m_RotationDirectionIndex; } set { if (OnPropertyChanging("WheelConfigData." + nameof(RotationDirectionIndex), this, m_RotationDirectionIndex, value)) m_RotationDirectionIndex = value; } } // 0x154 (340)
		
		protected int m_SteeringAngleIndex = new int();
		[ContainerField(Name: "SteeringAngleIndex", Offset: 344, NameHash: 892311087, Flags: 49405), LayoutImmutable, Blittable]
		public int SteeringAngleIndex { get { return m_SteeringAngleIndex; } set { if (OnPropertyChanging("WheelConfigData." + nameof(SteeringAngleIndex), this, m_SteeringAngleIndex, value)) m_SteeringAngleIndex = value; } } // 0x158 (344)
		
		protected int m_PacejkaConfigIndex = new int();
		[ContainerField(Name: "PacejkaConfigIndex", Offset: 348, NameHash: 2476871494, Flags: 49405), LayoutImmutable, Blittable]
		public int PacejkaConfigIndex { get { return m_PacejkaConfigIndex; } set { if (OnPropertyChanging("WheelConfigData." + nameof(PacejkaConfigIndex), this, m_PacejkaConfigIndex, value)) m_PacejkaConfigIndex = value; } } // 0x15C (348)
		
		protected int m_EngineIndex = new int();
		[ContainerField(Name: "EngineIndex", Offset: 352, NameHash: 1485813685, Flags: 49405), LayoutImmutable, Blittable]
		public int EngineIndex { get { return m_EngineIndex; } set { if (OnPropertyChanging("WheelConfigData." + nameof(EngineIndex), this, m_EngineIndex, value)) m_EngineIndex = value; } } // 0x160 (352)
		
		protected CtrRef<MaterialContainerPair> m_CollisionMaterialPair = new CtrRef<MaterialContainerPair>();
		[ContainerField(Name: "CollisionMaterialPair", Offset: 356, NameHash: 810888378, Flags: 53)]
		public CtrRef<MaterialContainerPair> CollisionMaterialPair { get { return m_CollisionMaterialPair; } set { if (OnPropertyChanging("WheelConfigData." + nameof(CollisionMaterialPair), this, m_CollisionMaterialPair, value)) m_CollisionMaterialPair = value; } } // 0x164 (356)
		
		protected bool m_AlwaysGrip = new bool();
		[ContainerField(Name: "AlwaysGrip", Offset: 360, NameHash: 580256120, Flags: 49325), LayoutImmutable, Blittable]
		public bool AlwaysGrip { get { return m_AlwaysGrip; } set { if (OnPropertyChanging("WheelConfigData." + nameof(AlwaysGrip), this, m_AlwaysGrip, value)) m_AlwaysGrip = value; } } // 0x168 (360)
		
		protected bool m_UseRollingResistanceBaseFactor = new bool();
		[ContainerField(Name: "UseRollingResistanceBaseFactor", Offset: 361, NameHash: 3566324640, Flags: 49325), LayoutImmutable, Blittable]
		public bool UseRollingResistanceBaseFactor { get { return m_UseRollingResistanceBaseFactor; } set { if (OnPropertyChanging("WheelConfigData." + nameof(UseRollingResistanceBaseFactor), this, m_UseRollingResistanceBaseFactor, value)) m_UseRollingResistanceBaseFactor = value; } } // 0x169 (361)
		
		protected bool m_UseEngineBrake = new bool();
		[ContainerField(Name: "UseEngineBrake", Offset: 362, NameHash: 4151667607, Flags: 49325), LayoutImmutable, Blittable]
		public bool UseEngineBrake { get { return m_UseEngineBrake; } set { if (OnPropertyChanging("WheelConfigData." + nameof(UseEngineBrake), this, m_UseEngineBrake, value)) m_UseEngineBrake = value; } } // 0x16A (362)
		
		protected bool m_IsAllowedToSpin = new bool();
		[ContainerField(Name: "IsAllowedToSpin", Offset: 363, NameHash: 3369853368, Flags: 49325), LayoutImmutable, Blittable]
		public bool IsAllowedToSpin { get { return m_IsAllowedToSpin; } set { if (OnPropertyChanging("WheelConfigData." + nameof(IsAllowedToSpin), this, m_IsAllowedToSpin, value)) m_IsAllowedToSpin = value; } } // 0x16B (363)
		
		protected bool m_HasSteeringInverted = new bool();
		[ContainerField(Name: "HasSteeringInverted", Offset: 364, NameHash: 1649025497, Flags: 49325), LayoutImmutable, Blittable]
		public bool HasSteeringInverted { get { return m_HasSteeringInverted; } set { if (OnPropertyChanging("WheelConfigData." + nameof(HasSteeringInverted), this, m_HasSteeringInverted, value)) m_HasSteeringInverted = value; } } // 0x16C (364)
		
		protected bool m_UseFrictionMoment = new bool();
		[ContainerField(Name: "UseFrictionMoment", Offset: 365, NameHash: 4263491220, Flags: 49325), LayoutImmutable, Blittable]
		public bool UseFrictionMoment { get { return m_UseFrictionMoment; } set { if (OnPropertyChanging("WheelConfigData." + nameof(UseFrictionMoment), this, m_UseFrictionMoment, value)) m_UseFrictionMoment = value; } } // 0x16D (365)
		
		protected bool m_UseLowSpeedAutoBrake = new bool();
		[ContainerField(Name: "UseLowSpeedAutoBrake", Offset: 366, NameHash: 389204645, Flags: 49325), LayoutImmutable, Blittable]
		public bool UseLowSpeedAutoBrake { get { return m_UseLowSpeedAutoBrake; } set { if (OnPropertyChanging("WheelConfigData." + nameof(UseLowSpeedAutoBrake), this, m_UseLowSpeedAutoBrake, value)) m_UseLowSpeedAutoBrake = value; } } // 0x16E (366)
		
		protected bool m_AdjustWheelRotation = new bool();
		[ContainerField(Name: "AdjustWheelRotation", Offset: 367, NameHash: 2477470367, Flags: 49325), LayoutImmutable, Blittable]
		public bool AdjustWheelRotation { get { return m_AdjustWheelRotation; } set { if (OnPropertyChanging("WheelConfigData." + nameof(AdjustWheelRotation), this, m_AdjustWheelRotation, value)) m_AdjustWheelRotation = value; } } // 0x16F (367)
		
		protected bool m_UseRollingResistanceVelocityFactor = new bool();
		[ContainerField(Name: "UseRollingResistanceVelocityFactor", Offset: 368, NameHash: 1119393506, Flags: 49325), LayoutImmutable, Blittable]
		public bool UseRollingResistanceVelocityFactor { get { return m_UseRollingResistanceVelocityFactor; } set { if (OnPropertyChanging("WheelConfigData." + nameof(UseRollingResistanceVelocityFactor), this, m_UseRollingResistanceVelocityFactor, value)) m_UseRollingResistanceVelocityFactor = value; } } // 0x170 (368)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 2871410728:
					Offset = (Vec3) p_Value;
					break;

				case 1681436809:
					Inertia = (Vec3) p_Value;
					break;

				case 3148736225:
					RotationBody = (CtrRef<RotationBodyData>) p_Value;
					break;

				case 2517711074:
					SphereCollision = (SphereCollisionData) p_Value;
					break;

				case 3324856916:
					Spring = (SpringData) p_Value;
					break;

				case 2088779625:
					Mass = (float) p_Value;
					break;

				case 3298407133:
					Radius = (float) p_Value;
					break;

				case 226981187:
					Width = (float) p_Value;
					break;

				case 313472228:
					RollingResistanceInternalBaseFactor = (float) p_Value;
					break;

				case 1977241987:
					RollingResistanceBaseFactor = (float) p_Value;
					break;

				case 3215467073:
					RollingResistanceVelocityFactor = (float) p_Value;
					break;

				case 3527754894:
					EngineBrakeVelocityFactor = (float) p_Value;
					break;

				case 1444818995:
					EngineBrakeMinFactor = (float) p_Value;
					break;

				case 1018553005:
					EngineBrakeMaxFactor = (float) p_Value;
					break;

				case 1052226128:
					TransmissionLoss = (List<Vec2>) p_Value;
					break;

				case 424954360:
					DiffGearRatio = (float) p_Value;
					break;

				case 4128407246:
					LowSpeedSteeringSensitivity = (float) p_Value;
					break;

				case 2353241178:
					MidSpeedSteeringSensitivity = (float) p_Value;
					break;

				case 1468359572:
					HighSpeedSteeringSensitivity = (float) p_Value;
					break;

				case 1713265071:
					SensitivityRangeScale = (float) p_Value;
					break;

				case 1606276251:
					LowSpeedSteeringSensitivityLimit = (float) p_Value;
					break;

				case 1766583183:
					MidSpeedSteeringSensitivityLimit = (float) p_Value;
					break;

				case 525306113:
					HighSpeedSteeringSensitivityLimit = (float) p_Value;
					break;

				case 2598948484:
					TrackedTurnSpeedLimit = (float) p_Value;
					break;

				case 1013932930:
					TrackedForwardSpeedLimit = (float) p_Value;
					break;

				case 848827836:
					SteerInertia = (CtrRef<Curve2D>) p_Value;
					break;

				case 1426555133:
					SteeringSensitivity = (List<SensitivityAtVelocity>) p_Value;
					break;

				case 2194066087:
					SlopeGripMinAngle = (float) p_Value;
					break;

				case 1317962745:
					SlopeGripMaxAngle = (float) p_Value;
					break;

				case 1902079775:
					SlopeGripExponent = (int) p_Value;
					break;

				case 2849668638:
					OffGroundGravityModifier = (float) p_Value;
					break;

				case 3875040376:
					SideSlipAngleMaxSlipCondition = (float) p_Value;
					break;

				case 3049185647:
					AngularVelocityMinSlipCondition = (float) p_Value;
					break;

				case 3555418854:
					WheelVelocityXMinSlipCondition = (float) p_Value;
					break;

				case 4035440:
					WheelSlipRatioMaxSlipCondition = (float) p_Value;
					break;

				case 4145733487:
					LongitudinalFrictionForceMaxFactor = (float) p_Value;
					break;

				case 267896320:
					LateralFrictionForceMaxFactor = (float) p_Value;
					break;

				case 1528459772:
					LongitudeFrictionScale = (List<FrictionScaleAtVelocity>) p_Value;
					break;

				case 2093823291:
					LattitudeFrictionScale = (List<FrictionScaleAtVelocity>) p_Value;
					break;

				case 3639987319:
					WheelFrictionLattitudeBrakeScale = (float) p_Value;
					break;

				case 435831062:
					MaxSlipRatio = (float) p_Value;
					break;

				case 61696806:
					Resistance = (float) p_Value;
					break;

				case 667791392:
					FxTorqueRadiusMultiplier = (float) p_Value;
					break;

				case 1187371114:
					FrictionMomentVelocityMin = (float) p_Value;
					break;

				case 1187371380:
					FrictionMomentVelocityMax = (float) p_Value;
					break;

				case 2140919388:
					FrictionMomentMultiplier = (float) p_Value;
					break;

				case 862687406:
					FrictionMomentMaxFactor = (float) p_Value;
					break;

				case 1705735991:
					BrakeFactor = (float) p_Value;
					break;

				case 3435369031:
					BrakeForce = (float) p_Value;
					break;

				case 575415412:
					HandBrakeFactor = (float) p_Value;
					break;

				case 2880094372:
					HandBrakeForce = (float) p_Value;
					break;

				case 1794073761:
					LateralPosK = (float) p_Value;
					break;

				case 1793716961:
					LateralNegK = (float) p_Value;
					break;

				case 2235876046:
					LongitudinalPosK = (float) p_Value;
					break;

				case 2235083918:
					LongitudinalNegK = (float) p_Value;
					break;

				case 3964733375:
					AlignMomScale = (float) p_Value;
					break;

				case 29121024:
					WheelBaseLateral = (float) p_Value;
					break;

				case 1965622255:
					WheelBaseLongitudinal = (float) p_Value;
					break;

				case 3293344276:
					DrivingType = (int) p_Value;
					break;

				case 2522217992:
					SteeringType = (int) p_Value;
					break;

				case 512648344:
					FrictionMethod = (int) p_Value;
					break;

				case 508374905:
					AckermanDeviceType = (int) p_Value;
					break;

				case 1688291961:
					CollisionYawDampeningDuration = (float) p_Value;
					break;

				case 659118567:
					CollisionYawDampening = (float) p_Value;
					break;

				case 3176887917:
					ConstantSpringForceFrictionScale = (float) p_Value;
					break;

				case 3008488874:
					RotationDirectionIndex = (int) p_Value;
					break;

				case 892311087:
					SteeringAngleIndex = (int) p_Value;
					break;

				case 2476871494:
					PacejkaConfigIndex = (int) p_Value;
					break;

				case 1485813685:
					EngineIndex = (int) p_Value;
					break;

				case 810888378:
					CollisionMaterialPair = (CtrRef<MaterialContainerPair>) p_Value;
					break;

				case 580256120:
					AlwaysGrip = (bool) p_Value;
					break;

				case 3566324640:
					UseRollingResistanceBaseFactor = (bool) p_Value;
					break;

				case 4151667607:
					UseEngineBrake = (bool) p_Value;
					break;

				case 3369853368:
					IsAllowedToSpin = (bool) p_Value;
					break;

				case 1649025497:
					HasSteeringInverted = (bool) p_Value;
					break;

				case 4263491220:
					UseFrictionMoment = (bool) p_Value;
					break;

				case 389204645:
					UseLowSpeedAutoBrake = (bool) p_Value;
					break;

				case 2477470367:
					AdjustWheelRotation = (bool) p_Value;
					break;

				case 1119393506:
					UseRollingResistanceVelocityFactor = (bool) p_Value;
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
				case 2871410728:
					return Offset;

				case 1681436809:
					return Inertia;

				case 3148736225:
					return RotationBody;

				case 2517711074:
					return SphereCollision;

				case 3324856916:
					return Spring;

				case 2088779625:
					return Mass;

				case 3298407133:
					return Radius;

				case 226981187:
					return Width;

				case 313472228:
					return RollingResistanceInternalBaseFactor;

				case 1977241987:
					return RollingResistanceBaseFactor;

				case 3215467073:
					return RollingResistanceVelocityFactor;

				case 3527754894:
					return EngineBrakeVelocityFactor;

				case 1444818995:
					return EngineBrakeMinFactor;

				case 1018553005:
					return EngineBrakeMaxFactor;

				case 1052226128:
					return TransmissionLoss;

				case 424954360:
					return DiffGearRatio;

				case 4128407246:
					return LowSpeedSteeringSensitivity;

				case 2353241178:
					return MidSpeedSteeringSensitivity;

				case 1468359572:
					return HighSpeedSteeringSensitivity;

				case 1713265071:
					return SensitivityRangeScale;

				case 1606276251:
					return LowSpeedSteeringSensitivityLimit;

				case 1766583183:
					return MidSpeedSteeringSensitivityLimit;

				case 525306113:
					return HighSpeedSteeringSensitivityLimit;

				case 2598948484:
					return TrackedTurnSpeedLimit;

				case 1013932930:
					return TrackedForwardSpeedLimit;

				case 848827836:
					return SteerInertia;

				case 1426555133:
					return SteeringSensitivity;

				case 2194066087:
					return SlopeGripMinAngle;

				case 1317962745:
					return SlopeGripMaxAngle;

				case 1902079775:
					return SlopeGripExponent;

				case 2849668638:
					return OffGroundGravityModifier;

				case 3875040376:
					return SideSlipAngleMaxSlipCondition;

				case 3049185647:
					return AngularVelocityMinSlipCondition;

				case 3555418854:
					return WheelVelocityXMinSlipCondition;

				case 4035440:
					return WheelSlipRatioMaxSlipCondition;

				case 4145733487:
					return LongitudinalFrictionForceMaxFactor;

				case 267896320:
					return LateralFrictionForceMaxFactor;

				case 1528459772:
					return LongitudeFrictionScale;

				case 2093823291:
					return LattitudeFrictionScale;

				case 3639987319:
					return WheelFrictionLattitudeBrakeScale;

				case 435831062:
					return MaxSlipRatio;

				case 61696806:
					return Resistance;

				case 667791392:
					return FxTorqueRadiusMultiplier;

				case 1187371114:
					return FrictionMomentVelocityMin;

				case 1187371380:
					return FrictionMomentVelocityMax;

				case 2140919388:
					return FrictionMomentMultiplier;

				case 862687406:
					return FrictionMomentMaxFactor;

				case 1705735991:
					return BrakeFactor;

				case 3435369031:
					return BrakeForce;

				case 575415412:
					return HandBrakeFactor;

				case 2880094372:
					return HandBrakeForce;

				case 1794073761:
					return LateralPosK;

				case 1793716961:
					return LateralNegK;

				case 2235876046:
					return LongitudinalPosK;

				case 2235083918:
					return LongitudinalNegK;

				case 3964733375:
					return AlignMomScale;

				case 29121024:
					return WheelBaseLateral;

				case 1965622255:
					return WheelBaseLongitudinal;

				case 3293344276:
					return DrivingType;

				case 2522217992:
					return SteeringType;

				case 512648344:
					return FrictionMethod;

				case 508374905:
					return AckermanDeviceType;

				case 1688291961:
					return CollisionYawDampeningDuration;

				case 659118567:
					return CollisionYawDampening;

				case 3176887917:
					return ConstantSpringForceFrictionScale;

				case 3008488874:
					return RotationDirectionIndex;

				case 892311087:
					return SteeringAngleIndex;

				case 2476871494:
					return PacejkaConfigIndex;

				case 1485813685:
					return EngineIndex;

				case 810888378:
					return CollisionMaterialPair;

				case 580256120:
					return AlwaysGrip;

				case 3566324640:
					return UseRollingResistanceBaseFactor;

				case 4151667607:
					return UseEngineBrake;

				case 3369853368:
					return IsAllowedToSpin;

				case 1649025497:
					return HasSteeringInverted;

				case 4263491220:
					return UseFrictionMoment;

				case 389204645:
					return UseLowSpeedAutoBrake;

				case 2477470367:
					return AdjustWheelRotation;

				case 1119393506:
					return UseRollingResistanceVelocityFactor;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 2871410728:
					return typeof(WheelConfigData).GetProperty(nameof(Offset));

				case 1681436809:
					return typeof(WheelConfigData).GetProperty(nameof(Inertia));

				case 3148736225:
					return typeof(WheelConfigData).GetProperty(nameof(RotationBody));

				case 2517711074:
					return typeof(WheelConfigData).GetProperty(nameof(SphereCollision));

				case 3324856916:
					return typeof(WheelConfigData).GetProperty(nameof(Spring));

				case 2088779625:
					return typeof(WheelConfigData).GetProperty(nameof(Mass));

				case 3298407133:
					return typeof(WheelConfigData).GetProperty(nameof(Radius));

				case 226981187:
					return typeof(WheelConfigData).GetProperty(nameof(Width));

				case 313472228:
					return typeof(WheelConfigData).GetProperty(nameof(RollingResistanceInternalBaseFactor));

				case 1977241987:
					return typeof(WheelConfigData).GetProperty(nameof(RollingResistanceBaseFactor));

				case 3215467073:
					return typeof(WheelConfigData).GetProperty(nameof(RollingResistanceVelocityFactor));

				case 3527754894:
					return typeof(WheelConfigData).GetProperty(nameof(EngineBrakeVelocityFactor));

				case 1444818995:
					return typeof(WheelConfigData).GetProperty(nameof(EngineBrakeMinFactor));

				case 1018553005:
					return typeof(WheelConfigData).GetProperty(nameof(EngineBrakeMaxFactor));

				case 1052226128:
					return typeof(WheelConfigData).GetProperty(nameof(TransmissionLoss));

				case 424954360:
					return typeof(WheelConfigData).GetProperty(nameof(DiffGearRatio));

				case 4128407246:
					return typeof(WheelConfigData).GetProperty(nameof(LowSpeedSteeringSensitivity));

				case 2353241178:
					return typeof(WheelConfigData).GetProperty(nameof(MidSpeedSteeringSensitivity));

				case 1468359572:
					return typeof(WheelConfigData).GetProperty(nameof(HighSpeedSteeringSensitivity));

				case 1713265071:
					return typeof(WheelConfigData).GetProperty(nameof(SensitivityRangeScale));

				case 1606276251:
					return typeof(WheelConfigData).GetProperty(nameof(LowSpeedSteeringSensitivityLimit));

				case 1766583183:
					return typeof(WheelConfigData).GetProperty(nameof(MidSpeedSteeringSensitivityLimit));

				case 525306113:
					return typeof(WheelConfigData).GetProperty(nameof(HighSpeedSteeringSensitivityLimit));

				case 2598948484:
					return typeof(WheelConfigData).GetProperty(nameof(TrackedTurnSpeedLimit));

				case 1013932930:
					return typeof(WheelConfigData).GetProperty(nameof(TrackedForwardSpeedLimit));

				case 848827836:
					return typeof(WheelConfigData).GetProperty(nameof(SteerInertia));

				case 1426555133:
					return typeof(WheelConfigData).GetProperty(nameof(SteeringSensitivity));

				case 2194066087:
					return typeof(WheelConfigData).GetProperty(nameof(SlopeGripMinAngle));

				case 1317962745:
					return typeof(WheelConfigData).GetProperty(nameof(SlopeGripMaxAngle));

				case 1902079775:
					return typeof(WheelConfigData).GetProperty(nameof(SlopeGripExponent));

				case 2849668638:
					return typeof(WheelConfigData).GetProperty(nameof(OffGroundGravityModifier));

				case 3875040376:
					return typeof(WheelConfigData).GetProperty(nameof(SideSlipAngleMaxSlipCondition));

				case 3049185647:
					return typeof(WheelConfigData).GetProperty(nameof(AngularVelocityMinSlipCondition));

				case 3555418854:
					return typeof(WheelConfigData).GetProperty(nameof(WheelVelocityXMinSlipCondition));

				case 4035440:
					return typeof(WheelConfigData).GetProperty(nameof(WheelSlipRatioMaxSlipCondition));

				case 4145733487:
					return typeof(WheelConfigData).GetProperty(nameof(LongitudinalFrictionForceMaxFactor));

				case 267896320:
					return typeof(WheelConfigData).GetProperty(nameof(LateralFrictionForceMaxFactor));

				case 1528459772:
					return typeof(WheelConfigData).GetProperty(nameof(LongitudeFrictionScale));

				case 2093823291:
					return typeof(WheelConfigData).GetProperty(nameof(LattitudeFrictionScale));

				case 3639987319:
					return typeof(WheelConfigData).GetProperty(nameof(WheelFrictionLattitudeBrakeScale));

				case 435831062:
					return typeof(WheelConfigData).GetProperty(nameof(MaxSlipRatio));

				case 61696806:
					return typeof(WheelConfigData).GetProperty(nameof(Resistance));

				case 667791392:
					return typeof(WheelConfigData).GetProperty(nameof(FxTorqueRadiusMultiplier));

				case 1187371114:
					return typeof(WheelConfigData).GetProperty(nameof(FrictionMomentVelocityMin));

				case 1187371380:
					return typeof(WheelConfigData).GetProperty(nameof(FrictionMomentVelocityMax));

				case 2140919388:
					return typeof(WheelConfigData).GetProperty(nameof(FrictionMomentMultiplier));

				case 862687406:
					return typeof(WheelConfigData).GetProperty(nameof(FrictionMomentMaxFactor));

				case 1705735991:
					return typeof(WheelConfigData).GetProperty(nameof(BrakeFactor));

				case 3435369031:
					return typeof(WheelConfigData).GetProperty(nameof(BrakeForce));

				case 575415412:
					return typeof(WheelConfigData).GetProperty(nameof(HandBrakeFactor));

				case 2880094372:
					return typeof(WheelConfigData).GetProperty(nameof(HandBrakeForce));

				case 1794073761:
					return typeof(WheelConfigData).GetProperty(nameof(LateralPosK));

				case 1793716961:
					return typeof(WheelConfigData).GetProperty(nameof(LateralNegK));

				case 2235876046:
					return typeof(WheelConfigData).GetProperty(nameof(LongitudinalPosK));

				case 2235083918:
					return typeof(WheelConfigData).GetProperty(nameof(LongitudinalNegK));

				case 3964733375:
					return typeof(WheelConfigData).GetProperty(nameof(AlignMomScale));

				case 29121024:
					return typeof(WheelConfigData).GetProperty(nameof(WheelBaseLateral));

				case 1965622255:
					return typeof(WheelConfigData).GetProperty(nameof(WheelBaseLongitudinal));

				case 3293344276:
					return typeof(WheelConfigData).GetProperty(nameof(DrivingType));

				case 2522217992:
					return typeof(WheelConfigData).GetProperty(nameof(SteeringType));

				case 512648344:
					return typeof(WheelConfigData).GetProperty(nameof(FrictionMethod));

				case 508374905:
					return typeof(WheelConfigData).GetProperty(nameof(AckermanDeviceType));

				case 1688291961:
					return typeof(WheelConfigData).GetProperty(nameof(CollisionYawDampeningDuration));

				case 659118567:
					return typeof(WheelConfigData).GetProperty(nameof(CollisionYawDampening));

				case 3176887917:
					return typeof(WheelConfigData).GetProperty(nameof(ConstantSpringForceFrictionScale));

				case 3008488874:
					return typeof(WheelConfigData).GetProperty(nameof(RotationDirectionIndex));

				case 892311087:
					return typeof(WheelConfigData).GetProperty(nameof(SteeringAngleIndex));

				case 2476871494:
					return typeof(WheelConfigData).GetProperty(nameof(PacejkaConfigIndex));

				case 1485813685:
					return typeof(WheelConfigData).GetProperty(nameof(EngineIndex));

				case 810888378:
					return typeof(WheelConfigData).GetProperty(nameof(CollisionMaterialPair));

				case 580256120:
					return typeof(WheelConfigData).GetProperty(nameof(AlwaysGrip));

				case 3566324640:
					return typeof(WheelConfigData).GetProperty(nameof(UseRollingResistanceBaseFactor));

				case 4151667607:
					return typeof(WheelConfigData).GetProperty(nameof(UseEngineBrake));

				case 3369853368:
					return typeof(WheelConfigData).GetProperty(nameof(IsAllowedToSpin));

				case 1649025497:
					return typeof(WheelConfigData).GetProperty(nameof(HasSteeringInverted));

				case 4263491220:
					return typeof(WheelConfigData).GetProperty(nameof(UseFrictionMoment));

				case 389204645:
					return typeof(WheelConfigData).GetProperty(nameof(UseLowSpeedAutoBrake));

				case 2477470367:
					return typeof(WheelConfigData).GetProperty(nameof(AdjustWheelRotation));

				case 1119393506:
					return typeof(WheelConfigData).GetProperty(nameof(UseRollingResistanceVelocityFactor));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
