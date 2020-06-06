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
	public class WheelConfigData : 
		DataContainer
	{
		[ContainerField(16), Homogeneous, LayoutImmutable, Blittable]
		public Vec3 Offset { get; set; } = new Vec3(); // 0x10 (16)
		
		[ContainerField(32), Homogeneous, LayoutImmutable, Blittable]
		public Vec3 Inertia { get; set; } = new Vec3(); // 0x20 (32)
		
		[ContainerField(48)]
		public CtrRef<RotationBodyData> RotationBody { get; set; } = new CtrRef<RotationBodyData>(); // 0x30 (48)
		
		[ContainerField(52)]
		public SphereCollisionData SphereCollision { get; set; } = new SphereCollisionData(); // 0x34 (52)
		
		[ContainerField(64)]
		public SpringData Spring { get; set; } = new SpringData(); // 0x40 (64)
		
		[ContainerField(100), LayoutImmutable, Blittable]
		public float Mass { get; set; } // 0x64 (100)
		
		[ContainerField(104), LayoutImmutable, Blittable]
		public float Radius { get; set; } // 0x68 (104)
		
		[ContainerField(108), LayoutImmutable, Blittable]
		public float Width { get; set; } // 0x6C (108)
		
		[ContainerField(112), LayoutImmutable, Blittable]
		public float RollingResistanceInternalBaseFactor { get; set; } // 0x70 (112)
		
		[ContainerField(116), LayoutImmutable, Blittable]
		public float RollingResistanceBaseFactor { get; set; } // 0x74 (116)
		
		[ContainerField(120), LayoutImmutable, Blittable]
		public float RollingResistanceVelocityFactor { get; set; } // 0x78 (120)
		
		[ContainerField(124), LayoutImmutable, Blittable]
		public float EngineBrakeVelocityFactor { get; set; } // 0x7C (124)
		
		[ContainerField(128), LayoutImmutable, Blittable]
		public float EngineBrakeMinFactor { get; set; } // 0x80 (128)
		
		[ContainerField(132), LayoutImmutable, Blittable]
		public float EngineBrakeMaxFactor { get; set; } // 0x84 (132)
		
		[ContainerField(136)]
		public List<Vec2> TransmissionLoss { get; set; } = new List<Vec2>(); // 0x88 (136)
		
		[ContainerField(140), LayoutImmutable, Blittable]
		public float DiffGearRatio { get; set; } // 0x8C (140)
		
		[ContainerField(144), LayoutImmutable, Blittable]
		public float LowSpeedSteeringSensitivity { get; set; } // 0x90 (144)
		
		[ContainerField(148), LayoutImmutable, Blittable]
		public float MidSpeedSteeringSensitivity { get; set; } // 0x94 (148)
		
		[ContainerField(152), LayoutImmutable, Blittable]
		public float HighSpeedSteeringSensitivity { get; set; } // 0x98 (152)
		
		[ContainerField(156), LayoutImmutable, Blittable]
		public float SensitivityRangeScale { get; set; } // 0x9C (156)
		
		[ContainerField(160), LayoutImmutable, Blittable]
		public float LowSpeedSteeringSensitivityLimit { get; set; } // 0xA0 (160)
		
		[ContainerField(164), LayoutImmutable, Blittable]
		public float MidSpeedSteeringSensitivityLimit { get; set; } // 0xA4 (164)
		
		[ContainerField(168), LayoutImmutable, Blittable]
		public float HighSpeedSteeringSensitivityLimit { get; set; } // 0xA8 (168)
		
		[ContainerField(172), LayoutImmutable, Blittable]
		public float TrackedTurnSpeedLimit { get; set; } // 0xAC (172)
		
		[ContainerField(176), LayoutImmutable, Blittable]
		public float TrackedForwardSpeedLimit { get; set; } // 0xB0 (176)
		
		[ContainerField(180)]
		public CtrRef<Curve2D> SteerInertia { get; set; } = new CtrRef<Curve2D>(); // 0xB4 (180)
		
		[ContainerField(184)]
		public List<SensitivityAtVelocity> SteeringSensitivity { get; set; } = new List<SensitivityAtVelocity>(); // 0xB8 (184)
		
		[ContainerField(188), LayoutImmutable, Blittable]
		public float SlopeGripMinAngle { get; set; } // 0xBC (188)
		
		[ContainerField(192), LayoutImmutable, Blittable]
		public float SlopeGripMaxAngle { get; set; } // 0xC0 (192)
		
		[ContainerField(196), LayoutImmutable, Blittable]
		public int SlopeGripExponent { get; set; } // 0xC4 (196)
		
		[ContainerField(200), LayoutImmutable, Blittable]
		public float OffGroundGravityModifier { get; set; } // 0xC8 (200)
		
		[ContainerField(204), LayoutImmutable, Blittable]
		public float SideSlipAngleMaxSlipCondition { get; set; } // 0xCC (204)
		
		[ContainerField(208), LayoutImmutable, Blittable]
		public float AngularVelocityMinSlipCondition { get; set; } // 0xD0 (208)
		
		[ContainerField(212), LayoutImmutable, Blittable]
		public float WheelVelocityXMinSlipCondition { get; set; } // 0xD4 (212)
		
		[ContainerField(216), LayoutImmutable, Blittable]
		public float WheelSlipRatioMaxSlipCondition { get; set; } // 0xD8 (216)
		
		[ContainerField(220), LayoutImmutable, Blittable]
		public float LongitudinalFrictionForceMaxFactor { get; set; } // 0xDC (220)
		
		[ContainerField(224), LayoutImmutable, Blittable]
		public float LateralFrictionForceMaxFactor { get; set; } // 0xE0 (224)
		
		[ContainerField(228)]
		public List<FrictionScaleAtVelocity> LongitudeFrictionScale { get; set; } = new List<FrictionScaleAtVelocity>(); // 0xE4 (228)
		
		[ContainerField(232)]
		public List<FrictionScaleAtVelocity> LattitudeFrictionScale { get; set; } = new List<FrictionScaleAtVelocity>(); // 0xE8 (232)
		
		[ContainerField(236), LayoutImmutable, Blittable]
		public float WheelFrictionLattitudeBrakeScale { get; set; } // 0xEC (236)
		
		[ContainerField(240), LayoutImmutable, Blittable]
		public float MaxSlipRatio { get; set; } // 0xF0 (240)
		
		[ContainerField(244), LayoutImmutable, Blittable]
		public float Resistance { get; set; } // 0xF4 (244)
		
		[ContainerField(248), LayoutImmutable, Blittable]
		public float FxTorqueRadiusMultiplier { get; set; } // 0xF8 (248)
		
		[ContainerField(252), LayoutImmutable, Blittable]
		public float FrictionMomentVelocityMin { get; set; } // 0xFC (252)
		
		[ContainerField(256), LayoutImmutable, Blittable]
		public float FrictionMomentVelocityMax { get; set; } // 0x100 (256)
		
		[ContainerField(260), LayoutImmutable, Blittable]
		public float FrictionMomentMultiplier { get; set; } // 0x104 (260)
		
		[ContainerField(264), LayoutImmutable, Blittable]
		public float FrictionMomentMaxFactor { get; set; } // 0x108 (264)
		
		[ContainerField(268), LayoutImmutable, Blittable]
		public float BrakeFactor { get; set; } // 0x10C (268)
		
		[ContainerField(272), LayoutImmutable, Blittable]
		public float BrakeForce { get; set; } // 0x110 (272)
		
		[ContainerField(276), LayoutImmutable, Blittable]
		public float HandBrakeFactor { get; set; } // 0x114 (276)
		
		[ContainerField(280), LayoutImmutable, Blittable]
		public float HandBrakeForce { get; set; } // 0x118 (280)
		
		[ContainerField(284), LayoutImmutable, Blittable]
		public float LateralPosK { get; set; } // 0x11C (284)
		
		[ContainerField(288), LayoutImmutable, Blittable]
		public float LateralNegK { get; set; } // 0x120 (288)
		
		[ContainerField(292), LayoutImmutable, Blittable]
		public float LongitudinalPosK { get; set; } // 0x124 (292)
		
		[ContainerField(296), LayoutImmutable, Blittable]
		public float LongitudinalNegK { get; set; } // 0x128 (296)
		
		[ContainerField(300), LayoutImmutable, Blittable]
		public float AlignMomScale { get; set; } // 0x12C (300)
		
		[ContainerField(304), LayoutImmutable, Blittable]
		public float WheelBaseLateral { get; set; } // 0x130 (304)
		
		[ContainerField(308), LayoutImmutable, Blittable]
		public float WheelBaseLongitudinal { get; set; } // 0x134 (308)
		
		[ContainerField(312), LayoutImmutable, Blittable]
		public int DrivingType { get; set; } // 0x138 (312)
		
		[ContainerField(316), LayoutImmutable, Blittable]
		public int SteeringType { get; set; } // 0x13C (316)
		
		[ContainerField(320), LayoutImmutable, Blittable]
		public int FrictionMethod { get; set; } // 0x140 (320)
		
		[ContainerField(324), LayoutImmutable, Blittable]
		public int AckermanDeviceType { get; set; } // 0x144 (324)
		
		[ContainerField(328), LayoutImmutable, Blittable]
		public float CollisionYawDampeningDuration { get; set; } // 0x148 (328)
		
		[ContainerField(332), LayoutImmutable, Blittable]
		public float CollisionYawDampening { get; set; } // 0x14C (332)
		
		[ContainerField(336), LayoutImmutable, Blittable]
		public float ConstantSpringForceFrictionScale { get; set; } // 0x150 (336)
		
		[ContainerField(340), LayoutImmutable, Blittable]
		public int RotationDirectionIndex { get; set; } // 0x154 (340)
		
		[ContainerField(344), LayoutImmutable, Blittable]
		public int SteeringAngleIndex { get; set; } // 0x158 (344)
		
		[ContainerField(348), LayoutImmutable, Blittable]
		public int PacejkaConfigIndex { get; set; } // 0x15C (348)
		
		[ContainerField(352), LayoutImmutable, Blittable]
		public int EngineIndex { get; set; } // 0x160 (352)
		
		[ContainerField(356)]
		public CtrRef<MaterialContainerPair> CollisionMaterialPair { get; set; } = new CtrRef<MaterialContainerPair>(); // 0x164 (356)
		
		[ContainerField(360), LayoutImmutable, Blittable]
		public bool AlwaysGrip { get; set; } // 0x168 (360)
		
		[ContainerField(361), LayoutImmutable, Blittable]
		public bool UseRollingResistanceBaseFactor { get; set; } // 0x169 (361)
		
		[ContainerField(362), LayoutImmutable, Blittable]
		public bool UseEngineBrake { get; set; } // 0x16A (362)
		
		[ContainerField(363), LayoutImmutable, Blittable]
		public bool IsAllowedToSpin { get; set; } // 0x16B (363)
		
		[ContainerField(364), LayoutImmutable, Blittable]
		public bool HasSteeringInverted { get; set; } // 0x16C (364)
		
		[ContainerField(365), LayoutImmutable, Blittable]
		public bool UseFrictionMoment { get; set; } // 0x16D (365)
		
		[ContainerField(366), LayoutImmutable, Blittable]
		public bool UseLowSpeedAutoBrake { get; set; } // 0x16E (366)
		
		[ContainerField(367), LayoutImmutable, Blittable]
		public bool AdjustWheelRotation { get; set; } // 0x16F (367)
		
		[ContainerField(368), LayoutImmutable, Blittable]
		public bool UseRollingResistanceVelocityFactor { get; set; } // 0x170 (368)
		
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
