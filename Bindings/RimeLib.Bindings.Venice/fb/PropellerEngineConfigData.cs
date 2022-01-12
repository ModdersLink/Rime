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
	[ContainerType(16, 256)]
	public class PropellerEngineConfigData : 
		EngineConfigData
	{
		[ContainerField(96), Homogeneous, LayoutImmutable, Blittable]
		public Vec3 HorisontalForceOffset { get; set; } = new();

		[ContainerField(112)]
		public PropellerType PropellerType { get; set; } = new();

		[ContainerField(116)]
		public CtrRef<RotorParameters> RotorConfig { get; set; } = new();

		[ContainerField(120)]
		public ForceMagnitudeInputType ForceMagnitudeInputType { get; set; } = new();

		[ContainerField(124), LayoutImmutable, Blittable]
		public uint DirectionVectorIndex { get; set; }

		[ContainerField(128), LayoutImmutable, Blittable]
		public float ForceMagnitudeMultiplier { get; set; }

		[ContainerField(132), LayoutImmutable, Blittable]
		public float LiftForceSpringConstant { get; set; }

		[ContainerField(136), LayoutImmutable, Blittable]
		public float LiftForceDampingConstant { get; set; }

		[ContainerField(140), LayoutImmutable, Blittable]
		public float CyclicInputScaleRoll { get; set; }

		[ContainerField(144), LayoutImmutable, Blittable]
		public float CyclicRollLiftMod { get; set; }

		[ContainerField(148), LayoutImmutable, Blittable]
		public float CyclicRollStrafeMod { get; set; }

		[ContainerField(152), LayoutImmutable, Blittable]
		public float CyclicInputScalePitch { get; set; }

		[ContainerField(156), LayoutImmutable, Blittable]
		public float CyclicPitchLiftMod { get; set; }

		[ContainerField(160), LayoutImmutable, Blittable]
		public float CyclicPitchStrafeMod { get; set; }

		[ContainerField(164), LayoutImmutable, Blittable]
		public float CyclicPitchStrafeBrakeMod { get; set; }

		[ContainerField(168), LayoutImmutable, Blittable]
		public float CollectiveInputIdle { get; set; }

		[ContainerField(172), LayoutImmutable, Blittable]
		public float CollectiveThrottleInputScale { get; set; }

		[ContainerField(176), LayoutImmutable, Blittable]
		public float CollectiveBrakeInputScale { get; set; }

		[ContainerField(180), LayoutImmutable, Blittable]
		public float DefaultAngleOfAttack { get; set; }

		[ContainerField(184), LayoutImmutable, Blittable]
		public float AttackAngleMod { get; set; }

		[ContainerField(188), LayoutImmutable, Blittable]
		public float StabilizerMod { get; set; }

		[ContainerField(192), LayoutImmutable, Blittable]
		public float HorisontalMinEffectVelocity { get; set; }

		[ContainerField(196), LayoutImmutable, Blittable]
		public float HorisontalMinEffectMod { get; set; }

		[ContainerField(200), LayoutImmutable, Blittable]
		public float PitchStrength { get; set; }

		[ContainerField(204), LayoutImmutable, Blittable]
		public float PitchFromVel { get; set; }

		[ContainerField(208), LayoutImmutable, Blittable]
		public float GravityMod { get; set; }

		[ContainerField(212), LayoutImmutable, Blittable]
		public float SPForwardStrength { get; set; }

		[ContainerField(216), LayoutImmutable, Blittable]
		public float SPSidewaysStrength { get; set; }

		[ContainerField(220), LayoutImmutable, Blittable]
		public float SPVerticalStrength { get; set; }

		[ContainerField(224), LayoutImmutable, Blittable]
		public float VelocityFromPitch { get; set; }

		[ContainerField(228), LayoutImmutable, Blittable]
		public float PitchLimit { get; set; }

		[ContainerField(232), LayoutImmutable, Blittable]
		public float BankingStrength { get; set; }

		[ContainerField(236), LayoutImmutable, Blittable]
		public float BankingLimit { get; set; }

		[ContainerField(240), LayoutImmutable, Blittable]
		public float RollStrength { get; set; }

		[ContainerField(244), LayoutImmutable, Blittable]
		public float PitchUpWhenBankStrength { get; set; }

		[ContainerField(248), LayoutImmutable, Blittable]
		public float PitchUpWhenBankLimit { get; set; }

		[ContainerField(252), LayoutImmutable, Blittable]
		public bool SPDefault { get; set; }

		[ContainerField(253), LayoutImmutable, Blittable]
		public bool EnableNewHelicopter { get; set; }

		[ContainerField(254), LayoutImmutable, Blittable]
		public bool SPAllowed { get; set; }

	}
}
