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
	[ContainerType(16), MemberInfoFlag(53), ContainerSize(384), ContainerClass]
	public class WheelConfigData : 
		DataContainer
	{
		protected Vec3 m_Offset = new Vec3();
		[ContainerField(16), Homogeneous, LayoutImmutable, Blittable, MemberInfoFlag(53289), ContainerFieldNameHash(2871410728)]
		public Vec3 Offset { get { return m_Offset; } set { if (OnPropertyChanging("WheelConfigData." + nameof(Offset), this, m_Offset, value)) m_Offset = value; } } // 0x10 (16)
		
		protected Vec3 m_Inertia = new Vec3();
		[ContainerField(32), Homogeneous, LayoutImmutable, Blittable, MemberInfoFlag(53289), ContainerFieldNameHash(1681436809)]
		public Vec3 Inertia { get { return m_Inertia; } set { if (OnPropertyChanging("WheelConfigData." + nameof(Inertia), this, m_Inertia, value)) m_Inertia = value; } } // 0x20 (32)
		
		protected CtrRef<RotationBodyData> m_RotationBody = new CtrRef<RotationBodyData>();
		[ContainerField(48), MemberInfoFlag(53), ContainerFieldNameHash(3148736225), ContainerCtrRef]
		public CtrRef<RotationBodyData> RotationBody { get { return m_RotationBody; } set { if (OnPropertyChanging("WheelConfigData." + nameof(RotationBody), this, m_RotationBody, value)) m_RotationBody = value; } } // 0x30 (48)
		
		protected SphereCollisionData m_SphereCollision = new SphereCollisionData();
		[ContainerField(52), MemberInfoFlag(41), ContainerFieldNameHash(2517711074)]
		public SphereCollisionData SphereCollision { get { return m_SphereCollision; } set { if (OnPropertyChanging("WheelConfigData." + nameof(SphereCollision), this, m_SphereCollision, value)) m_SphereCollision = value; } } // 0x34 (52)
		
		protected SpringData m_Spring = new SpringData();
		[ContainerField(64), MemberInfoFlag(41), ContainerFieldNameHash(3324856916)]
		public SpringData Spring { get { return m_Spring; } set { if (OnPropertyChanging("WheelConfigData." + nameof(Spring), this, m_Spring, value)) m_Spring = value; } } // 0x40 (64)
		
		protected float m_Mass = new float();
		[ContainerField(100), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(2088779625)]
		public float Mass { get { return m_Mass; } set { if (OnPropertyChanging("WheelConfigData." + nameof(Mass), this, m_Mass, value)) m_Mass = value; } } // 0x64 (100)
		
		protected float m_Radius = new float();
		[ContainerField(104), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(3298407133)]
		public float Radius { get { return m_Radius; } set { if (OnPropertyChanging("WheelConfigData." + nameof(Radius), this, m_Radius, value)) m_Radius = value; } } // 0x68 (104)
		
		protected float m_Width = new float();
		[ContainerField(108), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(226981187)]
		public float Width { get { return m_Width; } set { if (OnPropertyChanging("WheelConfigData." + nameof(Width), this, m_Width, value)) m_Width = value; } } // 0x6C (108)
		
		protected float m_RollingResistanceInternalBaseFactor = new float();
		[ContainerField(112), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(313472228)]
		public float RollingResistanceInternalBaseFactor { get { return m_RollingResistanceInternalBaseFactor; } set { if (OnPropertyChanging("WheelConfigData." + nameof(RollingResistanceInternalBaseFactor), this, m_RollingResistanceInternalBaseFactor, value)) m_RollingResistanceInternalBaseFactor = value; } } // 0x70 (112)
		
		protected float m_RollingResistanceBaseFactor = new float();
		[ContainerField(116), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(1977241987)]
		public float RollingResistanceBaseFactor { get { return m_RollingResistanceBaseFactor; } set { if (OnPropertyChanging("WheelConfigData." + nameof(RollingResistanceBaseFactor), this, m_RollingResistanceBaseFactor, value)) m_RollingResistanceBaseFactor = value; } } // 0x74 (116)
		
		protected float m_RollingResistanceVelocityFactor = new float();
		[ContainerField(120), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(3215467073)]
		public float RollingResistanceVelocityFactor { get { return m_RollingResistanceVelocityFactor; } set { if (OnPropertyChanging("WheelConfigData." + nameof(RollingResistanceVelocityFactor), this, m_RollingResistanceVelocityFactor, value)) m_RollingResistanceVelocityFactor = value; } } // 0x78 (120)
		
		protected float m_EngineBrakeVelocityFactor = new float();
		[ContainerField(124), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(3527754894)]
		public float EngineBrakeVelocityFactor { get { return m_EngineBrakeVelocityFactor; } set { if (OnPropertyChanging("WheelConfigData." + nameof(EngineBrakeVelocityFactor), this, m_EngineBrakeVelocityFactor, value)) m_EngineBrakeVelocityFactor = value; } } // 0x7C (124)
		
		protected float m_EngineBrakeMinFactor = new float();
		[ContainerField(128), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(1444818995)]
		public float EngineBrakeMinFactor { get { return m_EngineBrakeMinFactor; } set { if (OnPropertyChanging("WheelConfigData." + nameof(EngineBrakeMinFactor), this, m_EngineBrakeMinFactor, value)) m_EngineBrakeMinFactor = value; } } // 0x80 (128)
		
		protected float m_EngineBrakeMaxFactor = new float();
		[ContainerField(132), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(1018553005)]
		public float EngineBrakeMaxFactor { get { return m_EngineBrakeMaxFactor; } set { if (OnPropertyChanging("WheelConfigData." + nameof(EngineBrakeMaxFactor), this, m_EngineBrakeMaxFactor, value)) m_EngineBrakeMaxFactor = value; } } // 0x84 (132)
		
		protected List<Vec2> m_TransmissionLoss = new List<Vec2>();
		[ContainerField(136), MemberInfoFlag(65), ContainerFieldNameHash(1052226128), ContainerArray]
		public List<Vec2> TransmissionLoss { get { return m_TransmissionLoss; } set { if (OnPropertyChanging("WheelConfigData." + nameof(TransmissionLoss), this, m_TransmissionLoss, value)) m_TransmissionLoss = value; } } // 0x88 (136)
		
		protected float m_DiffGearRatio = new float();
		[ContainerField(140), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(424954360)]
		public float DiffGearRatio { get { return m_DiffGearRatio; } set { if (OnPropertyChanging("WheelConfigData." + nameof(DiffGearRatio), this, m_DiffGearRatio, value)) m_DiffGearRatio = value; } } // 0x8C (140)
		
		protected float m_LowSpeedSteeringSensitivity = new float();
		[ContainerField(144), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(4128407246)]
		public float LowSpeedSteeringSensitivity { get { return m_LowSpeedSteeringSensitivity; } set { if (OnPropertyChanging("WheelConfigData." + nameof(LowSpeedSteeringSensitivity), this, m_LowSpeedSteeringSensitivity, value)) m_LowSpeedSteeringSensitivity = value; } } // 0x90 (144)
		
		protected float m_MidSpeedSteeringSensitivity = new float();
		[ContainerField(148), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(2353241178)]
		public float MidSpeedSteeringSensitivity { get { return m_MidSpeedSteeringSensitivity; } set { if (OnPropertyChanging("WheelConfigData." + nameof(MidSpeedSteeringSensitivity), this, m_MidSpeedSteeringSensitivity, value)) m_MidSpeedSteeringSensitivity = value; } } // 0x94 (148)
		
		protected float m_HighSpeedSteeringSensitivity = new float();
		[ContainerField(152), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(1468359572)]
		public float HighSpeedSteeringSensitivity { get { return m_HighSpeedSteeringSensitivity; } set { if (OnPropertyChanging("WheelConfigData." + nameof(HighSpeedSteeringSensitivity), this, m_HighSpeedSteeringSensitivity, value)) m_HighSpeedSteeringSensitivity = value; } } // 0x98 (152)
		
		protected float m_SensitivityRangeScale = new float();
		[ContainerField(156), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(1713265071)]
		public float SensitivityRangeScale { get { return m_SensitivityRangeScale; } set { if (OnPropertyChanging("WheelConfigData." + nameof(SensitivityRangeScale), this, m_SensitivityRangeScale, value)) m_SensitivityRangeScale = value; } } // 0x9C (156)
		
		protected float m_LowSpeedSteeringSensitivityLimit = new float();
		[ContainerField(160), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(1606276251)]
		public float LowSpeedSteeringSensitivityLimit { get { return m_LowSpeedSteeringSensitivityLimit; } set { if (OnPropertyChanging("WheelConfigData." + nameof(LowSpeedSteeringSensitivityLimit), this, m_LowSpeedSteeringSensitivityLimit, value)) m_LowSpeedSteeringSensitivityLimit = value; } } // 0xA0 (160)
		
		protected float m_MidSpeedSteeringSensitivityLimit = new float();
		[ContainerField(164), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(1766583183)]
		public float MidSpeedSteeringSensitivityLimit { get { return m_MidSpeedSteeringSensitivityLimit; } set { if (OnPropertyChanging("WheelConfigData." + nameof(MidSpeedSteeringSensitivityLimit), this, m_MidSpeedSteeringSensitivityLimit, value)) m_MidSpeedSteeringSensitivityLimit = value; } } // 0xA4 (164)
		
		protected float m_HighSpeedSteeringSensitivityLimit = new float();
		[ContainerField(168), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(525306113)]
		public float HighSpeedSteeringSensitivityLimit { get { return m_HighSpeedSteeringSensitivityLimit; } set { if (OnPropertyChanging("WheelConfigData." + nameof(HighSpeedSteeringSensitivityLimit), this, m_HighSpeedSteeringSensitivityLimit, value)) m_HighSpeedSteeringSensitivityLimit = value; } } // 0xA8 (168)
		
		protected float m_TrackedTurnSpeedLimit = new float();
		[ContainerField(172), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(2598948484)]
		public float TrackedTurnSpeedLimit { get { return m_TrackedTurnSpeedLimit; } set { if (OnPropertyChanging("WheelConfigData." + nameof(TrackedTurnSpeedLimit), this, m_TrackedTurnSpeedLimit, value)) m_TrackedTurnSpeedLimit = value; } } // 0xAC (172)
		
		protected float m_TrackedForwardSpeedLimit = new float();
		[ContainerField(176), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(1013932930)]
		public float TrackedForwardSpeedLimit { get { return m_TrackedForwardSpeedLimit; } set { if (OnPropertyChanging("WheelConfigData." + nameof(TrackedForwardSpeedLimit), this, m_TrackedForwardSpeedLimit, value)) m_TrackedForwardSpeedLimit = value; } } // 0xB0 (176)
		
		protected CtrRef<Curve2D> m_SteerInertia = new CtrRef<Curve2D>();
		[ContainerField(180), MemberInfoFlag(53), ContainerFieldNameHash(848827836), ContainerCtrRef]
		public CtrRef<Curve2D> SteerInertia { get { return m_SteerInertia; } set { if (OnPropertyChanging("WheelConfigData." + nameof(SteerInertia), this, m_SteerInertia, value)) m_SteerInertia = value; } } // 0xB4 (180)
		
		protected List<SensitivityAtVelocity> m_SteeringSensitivity = new List<SensitivityAtVelocity>();
		[ContainerField(184), MemberInfoFlag(65), ContainerFieldNameHash(1426555133), ContainerArray]
		public List<SensitivityAtVelocity> SteeringSensitivity { get { return m_SteeringSensitivity; } set { if (OnPropertyChanging("WheelConfigData." + nameof(SteeringSensitivity), this, m_SteeringSensitivity, value)) m_SteeringSensitivity = value; } } // 0xB8 (184)
		
		protected float m_SlopeGripMinAngle = new float();
		[ContainerField(188), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(2194066087)]
		public float SlopeGripMinAngle { get { return m_SlopeGripMinAngle; } set { if (OnPropertyChanging("WheelConfigData." + nameof(SlopeGripMinAngle), this, m_SlopeGripMinAngle, value)) m_SlopeGripMinAngle = value; } } // 0xBC (188)
		
		protected float m_SlopeGripMaxAngle = new float();
		[ContainerField(192), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(1317962745)]
		public float SlopeGripMaxAngle { get { return m_SlopeGripMaxAngle; } set { if (OnPropertyChanging("WheelConfigData." + nameof(SlopeGripMaxAngle), this, m_SlopeGripMaxAngle, value)) m_SlopeGripMaxAngle = value; } } // 0xC0 (192)
		
		protected int m_SlopeGripExponent = new int();
		[ContainerField(196), LayoutImmutable, Blittable, MemberInfoFlag(49405), ContainerFieldNameHash(1902079775)]
		public int SlopeGripExponent { get { return m_SlopeGripExponent; } set { if (OnPropertyChanging("WheelConfigData." + nameof(SlopeGripExponent), this, m_SlopeGripExponent, value)) m_SlopeGripExponent = value; } } // 0xC4 (196)
		
		protected float m_OffGroundGravityModifier = new float();
		[ContainerField(200), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(2849668638)]
		public float OffGroundGravityModifier { get { return m_OffGroundGravityModifier; } set { if (OnPropertyChanging("WheelConfigData." + nameof(OffGroundGravityModifier), this, m_OffGroundGravityModifier, value)) m_OffGroundGravityModifier = value; } } // 0xC8 (200)
		
		protected float m_SideSlipAngleMaxSlipCondition = new float();
		[ContainerField(204), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(3875040376)]
		public float SideSlipAngleMaxSlipCondition { get { return m_SideSlipAngleMaxSlipCondition; } set { if (OnPropertyChanging("WheelConfigData." + nameof(SideSlipAngleMaxSlipCondition), this, m_SideSlipAngleMaxSlipCondition, value)) m_SideSlipAngleMaxSlipCondition = value; } } // 0xCC (204)
		
		protected float m_AngularVelocityMinSlipCondition = new float();
		[ContainerField(208), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(3049185647)]
		public float AngularVelocityMinSlipCondition { get { return m_AngularVelocityMinSlipCondition; } set { if (OnPropertyChanging("WheelConfigData." + nameof(AngularVelocityMinSlipCondition), this, m_AngularVelocityMinSlipCondition, value)) m_AngularVelocityMinSlipCondition = value; } } // 0xD0 (208)
		
		protected float m_WheelVelocityXMinSlipCondition = new float();
		[ContainerField(212), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(3555418854)]
		public float WheelVelocityXMinSlipCondition { get { return m_WheelVelocityXMinSlipCondition; } set { if (OnPropertyChanging("WheelConfigData." + nameof(WheelVelocityXMinSlipCondition), this, m_WheelVelocityXMinSlipCondition, value)) m_WheelVelocityXMinSlipCondition = value; } } // 0xD4 (212)
		
		protected float m_WheelSlipRatioMaxSlipCondition = new float();
		[ContainerField(216), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(4035440)]
		public float WheelSlipRatioMaxSlipCondition { get { return m_WheelSlipRatioMaxSlipCondition; } set { if (OnPropertyChanging("WheelConfigData." + nameof(WheelSlipRatioMaxSlipCondition), this, m_WheelSlipRatioMaxSlipCondition, value)) m_WheelSlipRatioMaxSlipCondition = value; } } // 0xD8 (216)
		
		protected float m_LongitudinalFrictionForceMaxFactor = new float();
		[ContainerField(220), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(4145733487)]
		public float LongitudinalFrictionForceMaxFactor { get { return m_LongitudinalFrictionForceMaxFactor; } set { if (OnPropertyChanging("WheelConfigData." + nameof(LongitudinalFrictionForceMaxFactor), this, m_LongitudinalFrictionForceMaxFactor, value)) m_LongitudinalFrictionForceMaxFactor = value; } } // 0xDC (220)
		
		protected float m_LateralFrictionForceMaxFactor = new float();
		[ContainerField(224), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(267896320)]
		public float LateralFrictionForceMaxFactor { get { return m_LateralFrictionForceMaxFactor; } set { if (OnPropertyChanging("WheelConfigData." + nameof(LateralFrictionForceMaxFactor), this, m_LateralFrictionForceMaxFactor, value)) m_LateralFrictionForceMaxFactor = value; } } // 0xE0 (224)
		
		protected List<FrictionScaleAtVelocity> m_LongitudeFrictionScale = new List<FrictionScaleAtVelocity>();
		[ContainerField(228), MemberInfoFlag(65), ContainerFieldNameHash(1528459772), ContainerArray]
		public List<FrictionScaleAtVelocity> LongitudeFrictionScale { get { return m_LongitudeFrictionScale; } set { if (OnPropertyChanging("WheelConfigData." + nameof(LongitudeFrictionScale), this, m_LongitudeFrictionScale, value)) m_LongitudeFrictionScale = value; } } // 0xE4 (228)
		
		protected List<FrictionScaleAtVelocity> m_LattitudeFrictionScale = new List<FrictionScaleAtVelocity>();
		[ContainerField(232), MemberInfoFlag(65), ContainerFieldNameHash(2093823291), ContainerArray]
		public List<FrictionScaleAtVelocity> LattitudeFrictionScale { get { return m_LattitudeFrictionScale; } set { if (OnPropertyChanging("WheelConfigData." + nameof(LattitudeFrictionScale), this, m_LattitudeFrictionScale, value)) m_LattitudeFrictionScale = value; } } // 0xE8 (232)
		
		protected float m_WheelFrictionLattitudeBrakeScale = new float();
		[ContainerField(236), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(3639987319)]
		public float WheelFrictionLattitudeBrakeScale { get { return m_WheelFrictionLattitudeBrakeScale; } set { if (OnPropertyChanging("WheelConfigData." + nameof(WheelFrictionLattitudeBrakeScale), this, m_WheelFrictionLattitudeBrakeScale, value)) m_WheelFrictionLattitudeBrakeScale = value; } } // 0xEC (236)
		
		protected float m_MaxSlipRatio = new float();
		[ContainerField(240), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(435831062)]
		public float MaxSlipRatio { get { return m_MaxSlipRatio; } set { if (OnPropertyChanging("WheelConfigData." + nameof(MaxSlipRatio), this, m_MaxSlipRatio, value)) m_MaxSlipRatio = value; } } // 0xF0 (240)
		
		protected float m_Resistance = new float();
		[ContainerField(244), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(61696806)]
		public float Resistance { get { return m_Resistance; } set { if (OnPropertyChanging("WheelConfigData." + nameof(Resistance), this, m_Resistance, value)) m_Resistance = value; } } // 0xF4 (244)
		
		protected float m_FxTorqueRadiusMultiplier = new float();
		[ContainerField(248), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(667791392)]
		public float FxTorqueRadiusMultiplier { get { return m_FxTorqueRadiusMultiplier; } set { if (OnPropertyChanging("WheelConfigData." + nameof(FxTorqueRadiusMultiplier), this, m_FxTorqueRadiusMultiplier, value)) m_FxTorqueRadiusMultiplier = value; } } // 0xF8 (248)
		
		protected float m_FrictionMomentVelocityMin = new float();
		[ContainerField(252), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(1187371114)]
		public float FrictionMomentVelocityMin { get { return m_FrictionMomentVelocityMin; } set { if (OnPropertyChanging("WheelConfigData." + nameof(FrictionMomentVelocityMin), this, m_FrictionMomentVelocityMin, value)) m_FrictionMomentVelocityMin = value; } } // 0xFC (252)
		
		protected float m_FrictionMomentVelocityMax = new float();
		[ContainerField(256), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(1187371380)]
		public float FrictionMomentVelocityMax { get { return m_FrictionMomentVelocityMax; } set { if (OnPropertyChanging("WheelConfigData." + nameof(FrictionMomentVelocityMax), this, m_FrictionMomentVelocityMax, value)) m_FrictionMomentVelocityMax = value; } } // 0x100 (256)
		
		protected float m_FrictionMomentMultiplier = new float();
		[ContainerField(260), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(2140919388)]
		public float FrictionMomentMultiplier { get { return m_FrictionMomentMultiplier; } set { if (OnPropertyChanging("WheelConfigData." + nameof(FrictionMomentMultiplier), this, m_FrictionMomentMultiplier, value)) m_FrictionMomentMultiplier = value; } } // 0x104 (260)
		
		protected float m_FrictionMomentMaxFactor = new float();
		[ContainerField(264), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(862687406)]
		public float FrictionMomentMaxFactor { get { return m_FrictionMomentMaxFactor; } set { if (OnPropertyChanging("WheelConfigData." + nameof(FrictionMomentMaxFactor), this, m_FrictionMomentMaxFactor, value)) m_FrictionMomentMaxFactor = value; } } // 0x108 (264)
		
		protected float m_BrakeFactor = new float();
		[ContainerField(268), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(1705735991)]
		public float BrakeFactor { get { return m_BrakeFactor; } set { if (OnPropertyChanging("WheelConfigData." + nameof(BrakeFactor), this, m_BrakeFactor, value)) m_BrakeFactor = value; } } // 0x10C (268)
		
		protected float m_BrakeForce = new float();
		[ContainerField(272), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(3435369031)]
		public float BrakeForce { get { return m_BrakeForce; } set { if (OnPropertyChanging("WheelConfigData." + nameof(BrakeForce), this, m_BrakeForce, value)) m_BrakeForce = value; } } // 0x110 (272)
		
		protected float m_HandBrakeFactor = new float();
		[ContainerField(276), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(575415412)]
		public float HandBrakeFactor { get { return m_HandBrakeFactor; } set { if (OnPropertyChanging("WheelConfigData." + nameof(HandBrakeFactor), this, m_HandBrakeFactor, value)) m_HandBrakeFactor = value; } } // 0x114 (276)
		
		protected float m_HandBrakeForce = new float();
		[ContainerField(280), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(2880094372)]
		public float HandBrakeForce { get { return m_HandBrakeForce; } set { if (OnPropertyChanging("WheelConfigData." + nameof(HandBrakeForce), this, m_HandBrakeForce, value)) m_HandBrakeForce = value; } } // 0x118 (280)
		
		protected float m_LateralPosK = new float();
		[ContainerField(284), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(1794073761)]
		public float LateralPosK { get { return m_LateralPosK; } set { if (OnPropertyChanging("WheelConfigData." + nameof(LateralPosK), this, m_LateralPosK, value)) m_LateralPosK = value; } } // 0x11C (284)
		
		protected float m_LateralNegK = new float();
		[ContainerField(288), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(1793716961)]
		public float LateralNegK { get { return m_LateralNegK; } set { if (OnPropertyChanging("WheelConfigData." + nameof(LateralNegK), this, m_LateralNegK, value)) m_LateralNegK = value; } } // 0x120 (288)
		
		protected float m_LongitudinalPosK = new float();
		[ContainerField(292), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(2235876046)]
		public float LongitudinalPosK { get { return m_LongitudinalPosK; } set { if (OnPropertyChanging("WheelConfigData." + nameof(LongitudinalPosK), this, m_LongitudinalPosK, value)) m_LongitudinalPosK = value; } } // 0x124 (292)
		
		protected float m_LongitudinalNegK = new float();
		[ContainerField(296), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(2235083918)]
		public float LongitudinalNegK { get { return m_LongitudinalNegK; } set { if (OnPropertyChanging("WheelConfigData." + nameof(LongitudinalNegK), this, m_LongitudinalNegK, value)) m_LongitudinalNegK = value; } } // 0x128 (296)
		
		protected float m_AlignMomScale = new float();
		[ContainerField(300), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(3964733375)]
		public float AlignMomScale { get { return m_AlignMomScale; } set { if (OnPropertyChanging("WheelConfigData." + nameof(AlignMomScale), this, m_AlignMomScale, value)) m_AlignMomScale = value; } } // 0x12C (300)
		
		protected float m_WheelBaseLateral = new float();
		[ContainerField(304), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(29121024)]
		public float WheelBaseLateral { get { return m_WheelBaseLateral; } set { if (OnPropertyChanging("WheelConfigData." + nameof(WheelBaseLateral), this, m_WheelBaseLateral, value)) m_WheelBaseLateral = value; } } // 0x130 (304)
		
		protected float m_WheelBaseLongitudinal = new float();
		[ContainerField(308), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(1965622255)]
		public float WheelBaseLongitudinal { get { return m_WheelBaseLongitudinal; } set { if (OnPropertyChanging("WheelConfigData." + nameof(WheelBaseLongitudinal), this, m_WheelBaseLongitudinal, value)) m_WheelBaseLongitudinal = value; } } // 0x134 (308)
		
		protected int m_DrivingType = new int();
		[ContainerField(312), LayoutImmutable, Blittable, MemberInfoFlag(49405), ContainerFieldNameHash(3293344276)]
		public int DrivingType { get { return m_DrivingType; } set { if (OnPropertyChanging("WheelConfigData." + nameof(DrivingType), this, m_DrivingType, value)) m_DrivingType = value; } } // 0x138 (312)
		
		protected int m_SteeringType = new int();
		[ContainerField(316), LayoutImmutable, Blittable, MemberInfoFlag(49405), ContainerFieldNameHash(2522217992)]
		public int SteeringType { get { return m_SteeringType; } set { if (OnPropertyChanging("WheelConfigData." + nameof(SteeringType), this, m_SteeringType, value)) m_SteeringType = value; } } // 0x13C (316)
		
		protected int m_FrictionMethod = new int();
		[ContainerField(320), LayoutImmutable, Blittable, MemberInfoFlag(49405), ContainerFieldNameHash(512648344)]
		public int FrictionMethod { get { return m_FrictionMethod; } set { if (OnPropertyChanging("WheelConfigData." + nameof(FrictionMethod), this, m_FrictionMethod, value)) m_FrictionMethod = value; } } // 0x140 (320)
		
		protected int m_AckermanDeviceType = new int();
		[ContainerField(324), LayoutImmutable, Blittable, MemberInfoFlag(49405), ContainerFieldNameHash(508374905)]
		public int AckermanDeviceType { get { return m_AckermanDeviceType; } set { if (OnPropertyChanging("WheelConfigData." + nameof(AckermanDeviceType), this, m_AckermanDeviceType, value)) m_AckermanDeviceType = value; } } // 0x144 (324)
		
		protected float m_CollisionYawDampeningDuration = new float();
		[ContainerField(328), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(1688291961)]
		public float CollisionYawDampeningDuration { get { return m_CollisionYawDampeningDuration; } set { if (OnPropertyChanging("WheelConfigData." + nameof(CollisionYawDampeningDuration), this, m_CollisionYawDampeningDuration, value)) m_CollisionYawDampeningDuration = value; } } // 0x148 (328)
		
		protected float m_CollisionYawDampening = new float();
		[ContainerField(332), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(659118567)]
		public float CollisionYawDampening { get { return m_CollisionYawDampening; } set { if (OnPropertyChanging("WheelConfigData." + nameof(CollisionYawDampening), this, m_CollisionYawDampening, value)) m_CollisionYawDampening = value; } } // 0x14C (332)
		
		protected float m_ConstantSpringForceFrictionScale = new float();
		[ContainerField(336), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(3176887917)]
		public float ConstantSpringForceFrictionScale { get { return m_ConstantSpringForceFrictionScale; } set { if (OnPropertyChanging("WheelConfigData." + nameof(ConstantSpringForceFrictionScale), this, m_ConstantSpringForceFrictionScale, value)) m_ConstantSpringForceFrictionScale = value; } } // 0x150 (336)
		
		protected int m_RotationDirectionIndex = new int();
		[ContainerField(340), LayoutImmutable, Blittable, MemberInfoFlag(49405), ContainerFieldNameHash(3008488874)]
		public int RotationDirectionIndex { get { return m_RotationDirectionIndex; } set { if (OnPropertyChanging("WheelConfigData." + nameof(RotationDirectionIndex), this, m_RotationDirectionIndex, value)) m_RotationDirectionIndex = value; } } // 0x154 (340)
		
		protected int m_SteeringAngleIndex = new int();
		[ContainerField(344), LayoutImmutable, Blittable, MemberInfoFlag(49405), ContainerFieldNameHash(892311087)]
		public int SteeringAngleIndex { get { return m_SteeringAngleIndex; } set { if (OnPropertyChanging("WheelConfigData." + nameof(SteeringAngleIndex), this, m_SteeringAngleIndex, value)) m_SteeringAngleIndex = value; } } // 0x158 (344)
		
		protected int m_PacejkaConfigIndex = new int();
		[ContainerField(348), LayoutImmutable, Blittable, MemberInfoFlag(49405), ContainerFieldNameHash(2476871494)]
		public int PacejkaConfigIndex { get { return m_PacejkaConfigIndex; } set { if (OnPropertyChanging("WheelConfigData." + nameof(PacejkaConfigIndex), this, m_PacejkaConfigIndex, value)) m_PacejkaConfigIndex = value; } } // 0x15C (348)
		
		protected int m_EngineIndex = new int();
		[ContainerField(352), LayoutImmutable, Blittable, MemberInfoFlag(49405), ContainerFieldNameHash(1485813685)]
		public int EngineIndex { get { return m_EngineIndex; } set { if (OnPropertyChanging("WheelConfigData." + nameof(EngineIndex), this, m_EngineIndex, value)) m_EngineIndex = value; } } // 0x160 (352)
		
		protected CtrRef<MaterialContainerPair> m_CollisionMaterialPair = new CtrRef<MaterialContainerPair>();
		[ContainerField(356), MemberInfoFlag(53), ContainerFieldNameHash(810888378), ContainerCtrRef]
		public CtrRef<MaterialContainerPair> CollisionMaterialPair { get { return m_CollisionMaterialPair; } set { if (OnPropertyChanging("WheelConfigData." + nameof(CollisionMaterialPair), this, m_CollisionMaterialPair, value)) m_CollisionMaterialPair = value; } } // 0x164 (356)
		
		protected bool m_AlwaysGrip = new bool();
		[ContainerField(360), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(580256120)]
		public bool AlwaysGrip { get { return m_AlwaysGrip; } set { if (OnPropertyChanging("WheelConfigData." + nameof(AlwaysGrip), this, m_AlwaysGrip, value)) m_AlwaysGrip = value; } } // 0x168 (360)
		
		protected bool m_UseRollingResistanceBaseFactor = new bool();
		[ContainerField(361), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(3566324640)]
		public bool UseRollingResistanceBaseFactor { get { return m_UseRollingResistanceBaseFactor; } set { if (OnPropertyChanging("WheelConfigData." + nameof(UseRollingResistanceBaseFactor), this, m_UseRollingResistanceBaseFactor, value)) m_UseRollingResistanceBaseFactor = value; } } // 0x169 (361)
		
		protected bool m_UseEngineBrake = new bool();
		[ContainerField(362), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(4151667607)]
		public bool UseEngineBrake { get { return m_UseEngineBrake; } set { if (OnPropertyChanging("WheelConfigData." + nameof(UseEngineBrake), this, m_UseEngineBrake, value)) m_UseEngineBrake = value; } } // 0x16A (362)
		
		protected bool m_IsAllowedToSpin = new bool();
		[ContainerField(363), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(3369853368)]
		public bool IsAllowedToSpin { get { return m_IsAllowedToSpin; } set { if (OnPropertyChanging("WheelConfigData." + nameof(IsAllowedToSpin), this, m_IsAllowedToSpin, value)) m_IsAllowedToSpin = value; } } // 0x16B (363)
		
		protected bool m_HasSteeringInverted = new bool();
		[ContainerField(364), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(1649025497)]
		public bool HasSteeringInverted { get { return m_HasSteeringInverted; } set { if (OnPropertyChanging("WheelConfigData." + nameof(HasSteeringInverted), this, m_HasSteeringInverted, value)) m_HasSteeringInverted = value; } } // 0x16C (364)
		
		protected bool m_UseFrictionMoment = new bool();
		[ContainerField(365), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(4263491220)]
		public bool UseFrictionMoment { get { return m_UseFrictionMoment; } set { if (OnPropertyChanging("WheelConfigData." + nameof(UseFrictionMoment), this, m_UseFrictionMoment, value)) m_UseFrictionMoment = value; } } // 0x16D (365)
		
		protected bool m_UseLowSpeedAutoBrake = new bool();
		[ContainerField(366), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(389204645)]
		public bool UseLowSpeedAutoBrake { get { return m_UseLowSpeedAutoBrake; } set { if (OnPropertyChanging("WheelConfigData." + nameof(UseLowSpeedAutoBrake), this, m_UseLowSpeedAutoBrake, value)) m_UseLowSpeedAutoBrake = value; } } // 0x16E (366)
		
		protected bool m_AdjustWheelRotation = new bool();
		[ContainerField(367), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(2477470367)]
		public bool AdjustWheelRotation { get { return m_AdjustWheelRotation; } set { if (OnPropertyChanging("WheelConfigData." + nameof(AdjustWheelRotation), this, m_AdjustWheelRotation, value)) m_AdjustWheelRotation = value; } } // 0x16F (367)
		
		protected bool m_UseRollingResistanceVelocityFactor = new bool();
		[ContainerField(368), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(1119393506)]
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
