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
	[ContainerType(16, 160)]
	public class ProjectileEntityData : 
		GamePhysicsEntityData
	{
		[ContainerField(112), LayoutImmutable, Blittable]
		public float VisualConvergeDistance { get; set; }

		[ContainerField(116), LayoutImmutable, Blittable]
		public float InitialSpeed { get; set; }

		[ContainerField(120), LayoutImmutable, Blittable]
		public float TimeToLive { get; set; }

		[ContainerField(124), LayoutImmutable, Blittable]
		public uint MaxCount { get; set; }

		[ContainerField(128), LayoutImmutable, Blittable]
		public float InitMeshHideTime { get; set; }

		[ContainerField(132)]
		public CtrRef<MaterialContainerPair> MaterialPair { get; set; } = new();

		[ContainerField(136)]
		public AntHitReactionWeaponType HitReactionWeaponType { get; set; } = new();

		[ContainerField(140)]
		public CtrRef<ExplosionEntityData> Explosion { get; set; } = new();

		[ContainerField(144)]
		public CtrRef<WeaponSuppressionData> SuppressionData { get; set; } = new();

		[ContainerField(148), LayoutImmutable]
		public string AmmunitionType { get; set; } = string.Empty;

		[ContainerField(152), LayoutImmutable, Blittable]
		public bool ServerProjectileDisabled { get; set; }

		[ContainerField(153), LayoutImmutable, Blittable]
		public bool DetonateOnTimeout { get; set; }

		[ContainerField(154), LayoutImmutable, Blittable]
		public bool SuppressOwnerVehicleDamage { get; set; }

	}
}
