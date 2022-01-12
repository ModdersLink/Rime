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
	[ContainerType(16, 208)]
	public class DebrisClusterData : 
		GameEntityData
	{
		[ContainerField(96), Homogeneous, LayoutImmutable, Blittable]
		public Vec3 PushVelocityMul { get; set; } = new();

		[ContainerField(112), Homogeneous, LayoutImmutable, Blittable]
		public Vec3 PushVelocityRndMul { get; set; } = new();

		[ContainerField(128), Homogeneous, LayoutImmutable, Blittable]
		public Vec3 InitRotationRndMul { get; set; } = new();

		[ContainerField(144), LayoutImmutable, Blittable]
		public float ClusterLifetime { get; set; }

		[ContainerField(148)]
		public CtrRef<MeshAsset> Mesh { get; set; } = new();

		[ContainerField(152), LayoutImmutable, Blittable]
		public uint CompositePartCount { get; set; }

		[ContainerField(156), LayoutImmutable, Blittable]
		public uint MaxActivePartsCount { get; set; }

		[ContainerField(160)]
		public List<DebrisClusterPartInfoData> PartHierarchy { get; set; } = new();

		[ContainerField(164), LayoutImmutable, Blittable]
		public float ActivationPushForceMul { get; set; }

		[ContainerField(168), LayoutImmutable, Blittable]
		public float ProjectileForceTransferMul { get; set; }

		[ContainerField(172)]
		public CtrRef<PhysicsEntityData> PhysicsData { get; set; } = new();

		[ContainerField(176)]
		public CtrRef<GameEntityData> Explosion { get; set; } = new();

		[ContainerField(180)]
		public CtrRef<EffectBlueprint> ActivationEffect { get; set; } = new();

		[ContainerField(184)]
		public CtrRef<EffectBlueprint> Effect { get; set; } = new();

		[ContainerField(188), LayoutImmutable, Blittable]
		public float OnPartCollisionSpeedThreshold { get; set; }

		[ContainerField(192), LayoutImmutable, Blittable]
		public bool PartialDestruction { get; set; }

		[ContainerField(193), LayoutImmutable, Blittable]
		public bool ClientSideOnly { get; set; }

		[ContainerField(194), LayoutImmutable, Blittable]
		public bool OnPartCollisionEnable { get; set; }

		[ContainerField(195), LayoutImmutable, Blittable]
		public bool NoCollision { get; set; }

		[ContainerField(196), LayoutImmutable, Blittable]
		public bool KillPartsOnCollision { get; set; }

		[ContainerField(197), LayoutImmutable, Blittable]
		public bool DeactivatePartsOnSleep { get; set; }

		[ContainerField(198), LayoutImmutable, Blittable]
		public bool ActivateOnSpawn { get; set; }

		[ContainerField(199), LayoutImmutable, Blittable]
		public bool InEffectWorldOnly { get; set; }

		[ContainerField(200), LayoutImmutable, Blittable]
		public bool SpawnExplosionOnFirstImpactOnly { get; set; }

	}
}
