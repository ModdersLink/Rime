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
	[ContainerType(16, 272)]
	public class BulletEntityData : 
		MeshProjectileEntityData
	{
		[ContainerField(192), LayoutImmutable, Blittable, JsonProperty(Order = 192)]
		public float Stamina { get; set; }

		[ContainerField(196), JsonProperty(Order = 196)]
		public CtrRef<SoundAsset> FlyBySound { get; set; } = new();

		[ContainerField(200), JsonProperty(Order = 200)]
		public CtrRef<ExplosionEntityData> DudExplosion { get; set; } = new();

		[ContainerField(204), LayoutImmutable, Blittable, JsonProperty(Order = 204)]
		public float Gravity { get; set; }

		[ContainerField(208), LayoutImmutable, Blittable, JsonProperty(Order = 208)]
		public float ImpactImpulse { get; set; }

		[ContainerField(212), LayoutImmutable, Blittable, JsonProperty(Order = 212)]
		public float DetonationTimeVariation { get; set; }

		[ContainerField(216), LayoutImmutable, Blittable, JsonProperty(Order = 216)]
		public float VehicleDetonationRadius { get; set; }

		[ContainerField(220), LayoutImmutable, Blittable, JsonProperty(Order = 220)]
		public float VehicleDetonationActivationDelay { get; set; }

		[ContainerField(224), LayoutImmutable, Blittable, JsonProperty(Order = 224)]
		public float FlyBySoundRadius { get; set; }

		[ContainerField(228), LayoutImmutable, Blittable, JsonProperty(Order = 228)]
		public float FlyBySoundSpeed { get; set; }

		[ContainerField(232), LayoutImmutable, Blittable, JsonProperty(Order = 232)]
		public float FirstFrameTravelDistance { get; set; }

		[ContainerField(236), LayoutImmutable, Blittable, JsonProperty(Order = 236)]
		public float DistributeDamageOverTime { get; set; }

		[ContainerField(240), LayoutImmutable, Blittable, JsonProperty(Order = 240)]
		public float StartDamage { get; set; }

		[ContainerField(244), LayoutImmutable, Blittable, JsonProperty(Order = 244)]
		public float EndDamage { get; set; }

		[ContainerField(248), LayoutImmutable, Blittable, JsonProperty(Order = 248)]
		public float DamageFalloffStartDistance { get; set; }

		[ContainerField(252), LayoutImmutable, Blittable, JsonProperty(Order = 252)]
		public float DamageFalloffEndDistance { get; set; }

		[ContainerField(256), LayoutImmutable, Blittable, JsonProperty(Order = 256)]
		public float TimeToArmExplosion { get; set; }

		[ContainerField(260), LayoutImmutable, Blittable, JsonProperty(Order = 260)]
		public bool HasVehicleDetonation { get; set; }

		[ContainerField(261), LayoutImmutable, Blittable, JsonProperty(Order = 261)]
		public bool InstantHit { get; set; }

		[ContainerField(262), LayoutImmutable, Blittable, JsonProperty(Order = 262)]
		public bool StopTrailEffectOnUnspawn { get; set; }

	}
}
