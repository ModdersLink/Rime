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
	public class DebrisClusterData : 
		GameEntityData
	{
		[ContainerField(96), Homogeneous, LayoutImmutable, Blittable]
		public Vec3 PushVelocityMul { get; set; } = new Vec3(); // 0x60 (96)
		
		[ContainerField(112), Homogeneous, LayoutImmutable, Blittable]
		public Vec3 PushVelocityRndMul { get; set; } = new Vec3(); // 0x70 (112)
		
		[ContainerField(128), Homogeneous, LayoutImmutable, Blittable]
		public Vec3 InitRotationRndMul { get; set; } = new Vec3(); // 0x80 (128)
		
		[ContainerField(144), LayoutImmutable, Blittable]
		public float ClusterLifetime { get; set; } // 0x90 (144)
		
		[ContainerField(148)]
		public CtrRef<MeshAsset> Mesh { get; set; } = new CtrRef<MeshAsset>(); // 0x94 (148)
		
		[ContainerField(152), LayoutImmutable, Blittable]
		public uint CompositePartCount { get; set; } // 0x98 (152)
		
		[ContainerField(156), LayoutImmutable, Blittable]
		public uint MaxActivePartsCount { get; set; } // 0x9C (156)
		
		[ContainerField(160)]
		public List<DebrisClusterPartInfoData> PartHierarchy { get; set; } = new List<DebrisClusterPartInfoData>(); // 0xA0 (160)
		
		[ContainerField(164), LayoutImmutable, Blittable]
		public float ActivationPushForceMul { get; set; } // 0xA4 (164)
		
		[ContainerField(168), LayoutImmutable, Blittable]
		public float ProjectileForceTransferMul { get; set; } // 0xA8 (168)
		
		[ContainerField(172)]
		public CtrRef<PhysicsEntityData> PhysicsData { get; set; } = new CtrRef<PhysicsEntityData>(); // 0xAC (172)
		
		[ContainerField(176)]
		public CtrRef<GameEntityData> Explosion { get; set; } = new CtrRef<GameEntityData>(); // 0xB0 (176)
		
		[ContainerField(180)]
		public CtrRef<EffectBlueprint> ActivationEffect { get; set; } = new CtrRef<EffectBlueprint>(); // 0xB4 (180)
		
		[ContainerField(184)]
		public CtrRef<EffectBlueprint> Effect { get; set; } = new CtrRef<EffectBlueprint>(); // 0xB8 (184)
		
		[ContainerField(188), LayoutImmutable, Blittable]
		public float OnPartCollisionSpeedThreshold { get; set; } // 0xBC (188)
		
		[ContainerField(192), LayoutImmutable, Blittable]
		public bool PartialDestruction { get; set; } // 0xC0 (192)
		
		[ContainerField(193), LayoutImmutable, Blittable]
		public bool ClientSideOnly { get; set; } // 0xC1 (193)
		
		[ContainerField(194), LayoutImmutable, Blittable]
		public bool OnPartCollisionEnable { get; set; } // 0xC2 (194)
		
		[ContainerField(195), LayoutImmutable, Blittable]
		public bool NoCollision { get; set; } // 0xC3 (195)
		
		[ContainerField(196), LayoutImmutable, Blittable]
		public bool KillPartsOnCollision { get; set; } // 0xC4 (196)
		
		[ContainerField(197), LayoutImmutable, Blittable]
		public bool DeactivatePartsOnSleep { get; set; } // 0xC5 (197)
		
		[ContainerField(198), LayoutImmutable, Blittable]
		public bool ActivateOnSpawn { get; set; } // 0xC6 (198)
		
		[ContainerField(199), LayoutImmutable, Blittable]
		public bool InEffectWorldOnly { get; set; } // 0xC7 (199)
		
		[ContainerField(200), LayoutImmutable, Blittable]
		public bool SpawnExplosionOnFirstImpactOnly { get; set; } // 0xC8 (200)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 3314270712:
					PushVelocityMul = (Vec3) p_Value;
					break;

				case 2525151328:
					PushVelocityRndMul = (Vec3) p_Value;
					break;

				case 2277112647:
					InitRotationRndMul = (Vec3) p_Value;
					break;

				case 250402940:
					ClusterLifetime = (float) p_Value;
					break;

				case 2088783990:
					Mesh = (CtrRef<MeshAsset>) p_Value;
					break;

				case 3195612804:
					CompositePartCount = (uint) p_Value;
					break;

				case 2283606746:
					MaxActivePartsCount = (uint) p_Value;
					break;

				case 3544065669:
					PartHierarchy = (List<DebrisClusterPartInfoData>) p_Value;
					break;

				case 4184797926:
					ActivationPushForceMul = (float) p_Value;
					break;

				case 501994258:
					ProjectileForceTransferMul = (float) p_Value;
					break;

				case 1743842718:
					PhysicsData = (CtrRef<PhysicsEntityData>) p_Value;
					break;

				case 2222171184:
					Explosion = (CtrRef<GameEntityData>) p_Value;
					break;

				case 2134350406:
					ActivationEffect = (CtrRef<EffectBlueprint>) p_Value;
					break;

				case 2332983090:
					Effect = (CtrRef<EffectBlueprint>) p_Value;
					break;

				case 322306461:
					OnPartCollisionSpeedThreshold = (float) p_Value;
					break;

				case 2157329736:
					PartialDestruction = (bool) p_Value;
					break;

				case 3628043763:
					ClientSideOnly = (bool) p_Value;
					break;

				case 1786102988:
					OnPartCollisionEnable = (bool) p_Value;
					break;

				case 3513186074:
					NoCollision = (bool) p_Value;
					break;

				case 1968153084:
					KillPartsOnCollision = (bool) p_Value;
					break;

				case 4098365303:
					DeactivatePartsOnSleep = (bool) p_Value;
					break;

				case 471103942:
					ActivateOnSpawn = (bool) p_Value;
					break;

				case 1269951075:
					InEffectWorldOnly = (bool) p_Value;
					break;

				case 3769890534:
					SpawnExplosionOnFirstImpactOnly = (bool) p_Value;
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
				case 3314270712:
					return PushVelocityMul;

				case 2525151328:
					return PushVelocityRndMul;

				case 2277112647:
					return InitRotationRndMul;

				case 250402940:
					return ClusterLifetime;

				case 2088783990:
					return Mesh;

				case 3195612804:
					return CompositePartCount;

				case 2283606746:
					return MaxActivePartsCount;

				case 3544065669:
					return PartHierarchy;

				case 4184797926:
					return ActivationPushForceMul;

				case 501994258:
					return ProjectileForceTransferMul;

				case 1743842718:
					return PhysicsData;

				case 2222171184:
					return Explosion;

				case 2134350406:
					return ActivationEffect;

				case 2332983090:
					return Effect;

				case 322306461:
					return OnPartCollisionSpeedThreshold;

				case 2157329736:
					return PartialDestruction;

				case 3628043763:
					return ClientSideOnly;

				case 1786102988:
					return OnPartCollisionEnable;

				case 3513186074:
					return NoCollision;

				case 1968153084:
					return KillPartsOnCollision;

				case 4098365303:
					return DeactivatePartsOnSleep;

				case 471103942:
					return ActivateOnSpawn;

				case 1269951075:
					return InEffectWorldOnly;

				case 3769890534:
					return SpawnExplosionOnFirstImpactOnly;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 3314270712:
					return typeof(DebrisClusterData).GetProperty(nameof(PushVelocityMul));

				case 2525151328:
					return typeof(DebrisClusterData).GetProperty(nameof(PushVelocityRndMul));

				case 2277112647:
					return typeof(DebrisClusterData).GetProperty(nameof(InitRotationRndMul));

				case 250402940:
					return typeof(DebrisClusterData).GetProperty(nameof(ClusterLifetime));

				case 2088783990:
					return typeof(DebrisClusterData).GetProperty(nameof(Mesh));

				case 3195612804:
					return typeof(DebrisClusterData).GetProperty(nameof(CompositePartCount));

				case 2283606746:
					return typeof(DebrisClusterData).GetProperty(nameof(MaxActivePartsCount));

				case 3544065669:
					return typeof(DebrisClusterData).GetProperty(nameof(PartHierarchy));

				case 4184797926:
					return typeof(DebrisClusterData).GetProperty(nameof(ActivationPushForceMul));

				case 501994258:
					return typeof(DebrisClusterData).GetProperty(nameof(ProjectileForceTransferMul));

				case 1743842718:
					return typeof(DebrisClusterData).GetProperty(nameof(PhysicsData));

				case 2222171184:
					return typeof(DebrisClusterData).GetProperty(nameof(Explosion));

				case 2134350406:
					return typeof(DebrisClusterData).GetProperty(nameof(ActivationEffect));

				case 2332983090:
					return typeof(DebrisClusterData).GetProperty(nameof(Effect));

				case 322306461:
					return typeof(DebrisClusterData).GetProperty(nameof(OnPartCollisionSpeedThreshold));

				case 2157329736:
					return typeof(DebrisClusterData).GetProperty(nameof(PartialDestruction));

				case 3628043763:
					return typeof(DebrisClusterData).GetProperty(nameof(ClientSideOnly));

				case 1786102988:
					return typeof(DebrisClusterData).GetProperty(nameof(OnPartCollisionEnable));

				case 3513186074:
					return typeof(DebrisClusterData).GetProperty(nameof(NoCollision));

				case 1968153084:
					return typeof(DebrisClusterData).GetProperty(nameof(KillPartsOnCollision));

				case 4098365303:
					return typeof(DebrisClusterData).GetProperty(nameof(DeactivatePartsOnSleep));

				case 471103942:
					return typeof(DebrisClusterData).GetProperty(nameof(ActivateOnSpawn));

				case 1269951075:
					return typeof(DebrisClusterData).GetProperty(nameof(InEffectWorldOnly));

				case 3769890534:
					return typeof(DebrisClusterData).GetProperty(nameof(SpawnExplosionOnFirstImpactOnly));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
