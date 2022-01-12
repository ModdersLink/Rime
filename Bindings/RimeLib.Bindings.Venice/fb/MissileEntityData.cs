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
	[ContainerType(16, 320)]
	public class MissileEntityData : 
		MeshProjectileEntityData
	{
		[ContainerField(192), LayoutImmutable, Blittable]
		public float Gravity { get; set; }

		[ContainerField(196)]
		public CtrRef<EffectBlueprint> EngineEffect { get; set; } = new();

		[ContainerField(200)]
		public CtrRef<ExplosionEntityData> DudExplosion { get; set; } = new();

		[ContainerField(204)]
		public CtrRef<SoundAsset> FlyBySound { get; set; } = new();

		[ContainerField(208), LayoutImmutable, Blittable]
		public float EngineStrength { get; set; }

		[ContainerField(212), LayoutImmutable, Blittable]
		public float MaxSpeed { get; set; }

		[ContainerField(216), LayoutImmutable, Blittable]
		public float EngineTimeToIgnition { get; set; }

		[ContainerField(220), LayoutImmutable, Blittable]
		public float EngineTimeToLive { get; set; }

		[ContainerField(224), LayoutImmutable, Blittable]
		public float TimeToActivateGuidingSystem { get; set; }

		[ContainerField(228), LayoutImmutable, Blittable]
		public float TimeToArm { get; set; }

		[ContainerField(232), LayoutImmutable, Blittable]
		public float MaxTurnAngle { get; set; }

		[ContainerField(236), LayoutImmutable, Blittable]
		public float Drag { get; set; }

		[ContainerField(240)]
		public NearTargetDetonationData NearTargetDetonation { get; set; } = new();

		[ContainerField(256)]
		public TeamId DefaultTeam { get; set; } = new();

		[ContainerField(260), LayoutImmutable, Blittable]
		public float FlyBySoundRadius { get; set; }

		[ContainerField(264), LayoutImmutable, Blittable]
		public float FlyBySoundSpeed { get; set; }

		[ContainerField(268), LayoutImmutable, Blittable]
		public float ImpactImpulse { get; set; }

		[ContainerField(272), LayoutImmutable, Blittable]
		public float Damage { get; set; }

		[ContainerField(276)]
		public MissileUnguidedData UnguidedData { get; set; } = new();

		[ContainerField(296)]
		public WarnTarget WarnTarget { get; set; } = new();

		[ContainerField(300)]
		public MissileLockableInfoData LockableInfo { get; set; } = new();

		[ContainerField(308)]
		public CtrRef<LockingControllerData> LockingController { get; set; } = new();

		[ContainerField(312), LayoutImmutable, Blittable]
		public bool WarnOnPointingMissile { get; set; }

		[ContainerField(313), LayoutImmutable, Blittable]
		public bool ApplyGravityWhenGuided { get; set; }

	}
}
