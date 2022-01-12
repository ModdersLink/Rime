///////////////////////////////////////////////////////////////
//                                                           //
// This is an automatically generated file.                  //
// Do *NOT* modify unless you really know what you're doing. //
//                                                           //
///////////////////////////////////////////////////////////////

using System;
using System.IO;
using System.Collections.Generic;
using RimeLib.IO;
using RimeLib.Frostbite.Core;
using RimeLib.Serialization.Attributes;
using RimeLib.Serialization;
using RimeLib.Serialization.Ebx;

namespace fb
{
	[ContainerType(16, 384)]
	public class WheelConfigData : 
		DataContainer
	{
		[ContainerField(16), Homogeneous, LayoutImmutable, Blittable]
		public Vec3 Offset { get; set; } = new();

		[ContainerField(32), Homogeneous, LayoutImmutable, Blittable]
		public Vec3 Inertia { get; set; } = new();

		[ContainerField(48)]
		public CtrRef<RotationBodyData> RotationBody { get; set; } = new();

		[ContainerField(52)]
		public SphereCollisionData SphereCollision { get; set; } = new();

		[ContainerField(64)]
		public SpringData Spring { get; set; } = new();

		[ContainerField(100), LayoutImmutable, Blittable]
		public float Mass { get; set; }

		[ContainerField(104), LayoutImmutable, Blittable]
		public float Radius { get; set; }

		[ContainerField(108), LayoutImmutable, Blittable]
		public float Width { get; set; }

		[ContainerField(112), LayoutImmutable, Blittable]
		public float RollingResistanceInternalBaseFactor { get; set; }

		[ContainerField(116), LayoutImmutable, Blittable]
		public float RollingResistanceBaseFactor { get; set; }

		[ContainerField(120), LayoutImmutable, Blittable]
		public float RollingResistanceVelocityFactor { get; set; }

		[ContainerField(124), LayoutImmutable, Blittable]
		public float EngineBrakeVelocityFactor { get; set; }

		[ContainerField(128), LayoutImmutable, Blittable]
		public float EngineBrakeMinFactor { get; set; }

		[ContainerField(132), LayoutImmutable, Blittable]
		public float EngineBrakeMaxFactor { get; set; }

		[ContainerField(136)]
		public List<Vec2> TransmissionLoss { get; set; } = new();

		[ContainerField(140), LayoutImmutable, Blittable]
		public float DiffGearRatio { get; set; }

		[ContainerField(144), LayoutImmutable, Blittable]
		public float LowSpeedSteeringSensitivity { get; set; }

		[ContainerField(148), LayoutImmutable, Blittable]
		public float MidSpeedSteeringSensitivity { get; set; }

		[ContainerField(152), LayoutImmutable, Blittable]
		public float HighSpeedSteeringSensitivity { get; set; }

		[ContainerField(156), LayoutImmutable, Blittable]
		public float SensitivityRangeScale { get; set; }

		[ContainerField(160), LayoutImmutable, Blittable]
		public float LowSpeedSteeringSensitivityLimit { get; set; }

		[ContainerField(164), LayoutImmutable, Blittable]
		public float MidSpeedSteeringSensitivityLimit { get; set; }

		[ContainerField(168), LayoutImmutable, Blittable]
		public float HighSpeedSteeringSensitivityLimit { get; set; }

		[ContainerField(172), LayoutImmutable, Blittable]
		public float TrackedTurnSpeedLimit { get; set; }

		[ContainerField(176), LayoutImmutable, Blittable]
		public float TrackedForwardSpeedLimit { get; set; }

		[ContainerField(180)]
		public CtrRef<Curve2D> SteerInertia { get; set; } = new();

		[ContainerField(184)]
		public List<SensitivityAtVelocity> SteeringSensitivity { get; set; } = new();

		[ContainerField(188), LayoutImmutable, Blittable]
		public float SlopeGripMinAngle { get; set; }

		[ContainerField(192), LayoutImmutable, Blittable]
		public float SlopeGripMaxAngle { get; set; }

		[ContainerField(196), LayoutImmutable, Blittable]
		public int SlopeGripExponent { get; set; }

		[ContainerField(200), LayoutImmutable, Blittable]
		public float OffGroundGravityModifier { get; set; }

		[ContainerField(204), LayoutImmutable, Blittable]
		public float SideSlipAngleMaxSlipCondition { get; set; }

		[ContainerField(208), LayoutImmutable, Blittable]
		public float AngularVelocityMinSlipCondition { get; set; }

		[ContainerField(212), LayoutImmutable, Blittable]
		public float WheelVelocityXMinSlipCondition { get; set; }

		[ContainerField(216), LayoutImmutable, Blittable]
		public float WheelSlipRatioMaxSlipCondition { get; set; }

		[ContainerField(220), LayoutImmutable, Blittable]
		public float LongitudinalFrictionForceMaxFactor { get; set; }

		[ContainerField(224), LayoutImmutable, Blittable]
		public float LateralFrictionForceMaxFactor { get; set; }

		[ContainerField(228)]
		public List<FrictionScaleAtVelocity> LongitudeFrictionScale { get; set; } = new();

		[ContainerField(232)]
		public List<FrictionScaleAtVelocity> LattitudeFrictionScale { get; set; } = new();

		[ContainerField(236), LayoutImmutable, Blittable]
		public float WheelFrictionLattitudeBrakeScale { get; set; }

		[ContainerField(240), LayoutImmutable, Blittable]
		public float MaxSlipRatio { get; set; }

		[ContainerField(244), LayoutImmutable, Blittable]
		public float Resistance { get; set; }

		[ContainerField(248), LayoutImmutable, Blittable]
		public float FxTorqueRadiusMultiplier { get; set; }

		[ContainerField(252), LayoutImmutable, Blittable]
		public float FrictionMomentVelocityMin { get; set; }

		[ContainerField(256), LayoutImmutable, Blittable]
		public float FrictionMomentVelocityMax { get; set; }

		[ContainerField(260), LayoutImmutable, Blittable]
		public float FrictionMomentMultiplier { get; set; }

		[ContainerField(264), LayoutImmutable, Blittable]
		public float FrictionMomentMaxFactor { get; set; }

		[ContainerField(268), LayoutImmutable, Blittable]
		public float BrakeFactor { get; set; }

		[ContainerField(272), LayoutImmutable, Blittable]
		public float BrakeForce { get; set; }

		[ContainerField(276), LayoutImmutable, Blittable]
		public float HandBrakeFactor { get; set; }

		[ContainerField(280), LayoutImmutable, Blittable]
		public float HandBrakeForce { get; set; }

		[ContainerField(284), LayoutImmutable, Blittable]
		public float LateralPosK { get; set; }

		[ContainerField(288), LayoutImmutable, Blittable]
		public float LateralNegK { get; set; }

		[ContainerField(292), LayoutImmutable, Blittable]
		public float LongitudinalPosK { get; set; }

		[ContainerField(296), LayoutImmutable, Blittable]
		public float LongitudinalNegK { get; set; }

		[ContainerField(300), LayoutImmutable, Blittable]
		public float AlignMomScale { get; set; }

		[ContainerField(304), LayoutImmutable, Blittable]
		public float WheelBaseLateral { get; set; }

		[ContainerField(308), LayoutImmutable, Blittable]
		public float WheelBaseLongitudinal { get; set; }

		[ContainerField(312), LayoutImmutable, Blittable]
		public int DrivingType { get; set; }

		[ContainerField(316), LayoutImmutable, Blittable]
		public int SteeringType { get; set; }

		[ContainerField(320), LayoutImmutable, Blittable]
		public int FrictionMethod { get; set; }

		[ContainerField(324), LayoutImmutable, Blittable]
		public int AckermanDeviceType { get; set; }

		[ContainerField(328), LayoutImmutable, Blittable]
		public float CollisionYawDampeningDuration { get; set; }

		[ContainerField(332), LayoutImmutable, Blittable]
		public float CollisionYawDampening { get; set; }

		[ContainerField(336), LayoutImmutable, Blittable]
		public float ConstantSpringForceFrictionScale { get; set; }

		[ContainerField(340), LayoutImmutable, Blittable]
		public int RotationDirectionIndex { get; set; }

		[ContainerField(344), LayoutImmutable, Blittable]
		public int SteeringAngleIndex { get; set; }

		[ContainerField(348), LayoutImmutable, Blittable]
		public int PacejkaConfigIndex { get; set; }

		[ContainerField(352), LayoutImmutable, Blittable]
		public int EngineIndex { get; set; }

		[ContainerField(356)]
		public CtrRef<MaterialContainerPair> CollisionMaterialPair { get; set; } = new();

		[ContainerField(360), LayoutImmutable, Blittable]
		public bool AlwaysGrip { get; set; }

		[ContainerField(361), LayoutImmutable, Blittable]
		public bool UseRollingResistanceBaseFactor { get; set; }

		[ContainerField(362), LayoutImmutable, Blittable]
		public bool UseEngineBrake { get; set; }

		[ContainerField(363), LayoutImmutable, Blittable]
		public bool IsAllowedToSpin { get; set; }

		[ContainerField(364), LayoutImmutable, Blittable]
		public bool HasSteeringInverted { get; set; }

		[ContainerField(365), LayoutImmutable, Blittable]
		public bool UseFrictionMoment { get; set; }

		[ContainerField(366), LayoutImmutable, Blittable]
		public bool UseLowSpeedAutoBrake { get; set; }

		[ContainerField(367), LayoutImmutable, Blittable]
		public bool AdjustWheelRotation { get; set; }

		[ContainerField(368), LayoutImmutable, Blittable]
		public bool UseRollingResistanceVelocityFactor { get; set; }

	}
}
