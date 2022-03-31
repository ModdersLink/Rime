///////////////////////////////////////////////////////////////
//                                                           //
// This is an automatically generated file.                  //
// Do *NOT* modify unless you really know what you're doing. //
//                                                           //
///////////////////////////////////////////////////////////////

using System;
using System.IO;
using System.Collections.Generic;
using Newtonsoft.Json;
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
		[ContainerField(112), LayoutImmutable, Blittable, JsonProperty(Order = 112)]
		public float VisualConvergeDistance { get; set; }

		[ContainerField(116), LayoutImmutable, Blittable, JsonProperty(Order = 116)]
		public float InitialSpeed { get; set; }

		[ContainerField(120), LayoutImmutable, Blittable, JsonProperty(Order = 120)]
		public float TimeToLive { get; set; }

		[ContainerField(124), LayoutImmutable, Blittable, JsonProperty(Order = 124)]
		public uint MaxCount { get; set; }

		[ContainerField(128), LayoutImmutable, Blittable, JsonProperty(Order = 128)]
		public float InitMeshHideTime { get; set; }

		[ContainerField(132), JsonProperty(Order = 132)]
		public CtrRef<MaterialContainerPair> MaterialPair { get; set; } = new();

		[ContainerField(136), JsonProperty(Order = 136)]
		public AntHitReactionWeaponType HitReactionWeaponType { get; set; } = new();

		[ContainerField(140), JsonProperty(Order = 140)]
		public CtrRef<ExplosionEntityData> Explosion { get; set; } = new();

		[ContainerField(144), JsonProperty(Order = 144)]
		public CtrRef<WeaponSuppressionData> SuppressionData { get; set; } = new();

		[ContainerField(148), LayoutImmutable, JsonProperty(Order = 148)]
		public string AmmunitionType { get; set; } = string.Empty;

		[ContainerField(152), LayoutImmutable, Blittable, JsonProperty(Order = 152)]
		public bool ServerProjectileDisabled { get; set; }

		[ContainerField(153), LayoutImmutable, Blittable, JsonProperty(Order = 153)]
		public bool DetonateOnTimeout { get; set; }

		[ContainerField(154), LayoutImmutable, Blittable, JsonProperty(Order = 154)]
		public bool SuppressOwnerVehicleDamage { get; set; }

	}
}
