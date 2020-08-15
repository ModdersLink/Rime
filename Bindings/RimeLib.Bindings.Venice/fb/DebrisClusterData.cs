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
	[ContainerType(16)]
	public class DebrisClusterData : 
		GameEntityData
	{
		protected Vec3 m_PushVelocityMul = new Vec3();
		[ContainerField(96), Homogeneous, LayoutImmutable, Blittable, ContainerFieldNameHash(3314270712)]
		public Vec3 PushVelocityMul { get { return m_PushVelocityMul; } set { if (OnPropertyChanging("DebrisClusterData." + nameof(PushVelocityMul), this, m_PushVelocityMul, value)) m_PushVelocityMul = value; } } // 0x60 (96)
		
		protected Vec3 m_PushVelocityRndMul = new Vec3();
		[ContainerField(112), Homogeneous, LayoutImmutable, Blittable, ContainerFieldNameHash(2525151328)]
		public Vec3 PushVelocityRndMul { get { return m_PushVelocityRndMul; } set { if (OnPropertyChanging("DebrisClusterData." + nameof(PushVelocityRndMul), this, m_PushVelocityRndMul, value)) m_PushVelocityRndMul = value; } } // 0x70 (112)
		
		protected Vec3 m_InitRotationRndMul = new Vec3();
		[ContainerField(128), Homogeneous, LayoutImmutable, Blittable, ContainerFieldNameHash(2277112647)]
		public Vec3 InitRotationRndMul { get { return m_InitRotationRndMul; } set { if (OnPropertyChanging("DebrisClusterData." + nameof(InitRotationRndMul), this, m_InitRotationRndMul, value)) m_InitRotationRndMul = value; } } // 0x80 (128)
		
		protected float m_ClusterLifetime = new float();
		[ContainerField(144), LayoutImmutable, Blittable, ContainerFieldNameHash(250402940)]
		public float ClusterLifetime { get { return m_ClusterLifetime; } set { if (OnPropertyChanging("DebrisClusterData." + nameof(ClusterLifetime), this, m_ClusterLifetime, value)) m_ClusterLifetime = value; } } // 0x90 (144)
		
		protected CtrRef<MeshAsset> m_Mesh = new CtrRef<MeshAsset>();
		[ContainerField(148), ContainerFieldNameHash(2088783990)]
		public CtrRef<MeshAsset> Mesh { get { return m_Mesh; } set { if (OnPropertyChanging("DebrisClusterData." + nameof(Mesh), this, m_Mesh, value)) m_Mesh = value; } } // 0x94 (148)
		
		protected uint m_CompositePartCount = new uint();
		[ContainerField(152), LayoutImmutable, Blittable, ContainerFieldNameHash(3195612804)]
		public uint CompositePartCount { get { return m_CompositePartCount; } set { if (OnPropertyChanging("DebrisClusterData." + nameof(CompositePartCount), this, m_CompositePartCount, value)) m_CompositePartCount = value; } } // 0x98 (152)
		
		protected uint m_MaxActivePartsCount = new uint();
		[ContainerField(156), LayoutImmutable, Blittable, ContainerFieldNameHash(2283606746)]
		public uint MaxActivePartsCount { get { return m_MaxActivePartsCount; } set { if (OnPropertyChanging("DebrisClusterData." + nameof(MaxActivePartsCount), this, m_MaxActivePartsCount, value)) m_MaxActivePartsCount = value; } } // 0x9C (156)
		
		protected List<DebrisClusterPartInfoData> m_PartHierarchy = new List<DebrisClusterPartInfoData>();
		[ContainerField(160), ContainerFieldNameHash(3544065669)]
		public List<DebrisClusterPartInfoData> PartHierarchy { get { return m_PartHierarchy; } set { if (OnPropertyChanging("DebrisClusterData." + nameof(PartHierarchy), this, m_PartHierarchy, value)) m_PartHierarchy = value; } } // 0xA0 (160)
		
		protected float m_ActivationPushForceMul = new float();
		[ContainerField(164), LayoutImmutable, Blittable, ContainerFieldNameHash(4184797926)]
		public float ActivationPushForceMul { get { return m_ActivationPushForceMul; } set { if (OnPropertyChanging("DebrisClusterData." + nameof(ActivationPushForceMul), this, m_ActivationPushForceMul, value)) m_ActivationPushForceMul = value; } } // 0xA4 (164)
		
		protected float m_ProjectileForceTransferMul = new float();
		[ContainerField(168), LayoutImmutable, Blittable, ContainerFieldNameHash(501994258)]
		public float ProjectileForceTransferMul { get { return m_ProjectileForceTransferMul; } set { if (OnPropertyChanging("DebrisClusterData." + nameof(ProjectileForceTransferMul), this, m_ProjectileForceTransferMul, value)) m_ProjectileForceTransferMul = value; } } // 0xA8 (168)
		
		protected CtrRef<PhysicsEntityData> m_PhysicsData = new CtrRef<PhysicsEntityData>();
		[ContainerField(172), ContainerFieldNameHash(1743842718)]
		public CtrRef<PhysicsEntityData> PhysicsData { get { return m_PhysicsData; } set { if (OnPropertyChanging("DebrisClusterData." + nameof(PhysicsData), this, m_PhysicsData, value)) m_PhysicsData = value; } } // 0xAC (172)
		
		protected CtrRef<GameEntityData> m_Explosion = new CtrRef<GameEntityData>();
		[ContainerField(176), ContainerFieldNameHash(2222171184)]
		public CtrRef<GameEntityData> Explosion { get { return m_Explosion; } set { if (OnPropertyChanging("DebrisClusterData." + nameof(Explosion), this, m_Explosion, value)) m_Explosion = value; } } // 0xB0 (176)
		
		protected CtrRef<EffectBlueprint> m_ActivationEffect = new CtrRef<EffectBlueprint>();
		[ContainerField(180), ContainerFieldNameHash(2134350406)]
		public CtrRef<EffectBlueprint> ActivationEffect { get { return m_ActivationEffect; } set { if (OnPropertyChanging("DebrisClusterData." + nameof(ActivationEffect), this, m_ActivationEffect, value)) m_ActivationEffect = value; } } // 0xB4 (180)
		
		protected CtrRef<EffectBlueprint> m_Effect = new CtrRef<EffectBlueprint>();
		[ContainerField(184), ContainerFieldNameHash(2332983090)]
		public CtrRef<EffectBlueprint> Effect { get { return m_Effect; } set { if (OnPropertyChanging("DebrisClusterData." + nameof(Effect), this, m_Effect, value)) m_Effect = value; } } // 0xB8 (184)
		
		protected float m_OnPartCollisionSpeedThreshold = new float();
		[ContainerField(188), LayoutImmutable, Blittable, ContainerFieldNameHash(322306461)]
		public float OnPartCollisionSpeedThreshold { get { return m_OnPartCollisionSpeedThreshold; } set { if (OnPropertyChanging("DebrisClusterData." + nameof(OnPartCollisionSpeedThreshold), this, m_OnPartCollisionSpeedThreshold, value)) m_OnPartCollisionSpeedThreshold = value; } } // 0xBC (188)
		
		protected bool m_PartialDestruction = new bool();
		[ContainerField(192), LayoutImmutable, Blittable, ContainerFieldNameHash(2157329736)]
		public bool PartialDestruction { get { return m_PartialDestruction; } set { if (OnPropertyChanging("DebrisClusterData." + nameof(PartialDestruction), this, m_PartialDestruction, value)) m_PartialDestruction = value; } } // 0xC0 (192)
		
		protected bool m_ClientSideOnly = new bool();
		[ContainerField(193), LayoutImmutable, Blittable, ContainerFieldNameHash(3628043763)]
		public bool ClientSideOnly { get { return m_ClientSideOnly; } set { if (OnPropertyChanging("DebrisClusterData." + nameof(ClientSideOnly), this, m_ClientSideOnly, value)) m_ClientSideOnly = value; } } // 0xC1 (193)
		
		protected bool m_OnPartCollisionEnable = new bool();
		[ContainerField(194), LayoutImmutable, Blittable, ContainerFieldNameHash(1786102988)]
		public bool OnPartCollisionEnable { get { return m_OnPartCollisionEnable; } set { if (OnPropertyChanging("DebrisClusterData." + nameof(OnPartCollisionEnable), this, m_OnPartCollisionEnable, value)) m_OnPartCollisionEnable = value; } } // 0xC2 (194)
		
		protected bool m_NoCollision = new bool();
		[ContainerField(195), LayoutImmutable, Blittable, ContainerFieldNameHash(3513186074)]
		public bool NoCollision { get { return m_NoCollision; } set { if (OnPropertyChanging("DebrisClusterData." + nameof(NoCollision), this, m_NoCollision, value)) m_NoCollision = value; } } // 0xC3 (195)
		
		protected bool m_KillPartsOnCollision = new bool();
		[ContainerField(196), LayoutImmutable, Blittable, ContainerFieldNameHash(1968153084)]
		public bool KillPartsOnCollision { get { return m_KillPartsOnCollision; } set { if (OnPropertyChanging("DebrisClusterData." + nameof(KillPartsOnCollision), this, m_KillPartsOnCollision, value)) m_KillPartsOnCollision = value; } } // 0xC4 (196)
		
		protected bool m_DeactivatePartsOnSleep = new bool();
		[ContainerField(197), LayoutImmutable, Blittable, ContainerFieldNameHash(4098365303)]
		public bool DeactivatePartsOnSleep { get { return m_DeactivatePartsOnSleep; } set { if (OnPropertyChanging("DebrisClusterData." + nameof(DeactivatePartsOnSleep), this, m_DeactivatePartsOnSleep, value)) m_DeactivatePartsOnSleep = value; } } // 0xC5 (197)
		
		protected bool m_ActivateOnSpawn = new bool();
		[ContainerField(198), LayoutImmutable, Blittable, ContainerFieldNameHash(471103942)]
		public bool ActivateOnSpawn { get { return m_ActivateOnSpawn; } set { if (OnPropertyChanging("DebrisClusterData." + nameof(ActivateOnSpawn), this, m_ActivateOnSpawn, value)) m_ActivateOnSpawn = value; } } // 0xC6 (198)
		
		protected bool m_InEffectWorldOnly = new bool();
		[ContainerField(199), LayoutImmutable, Blittable, ContainerFieldNameHash(1269951075)]
		public bool InEffectWorldOnly { get { return m_InEffectWorldOnly; } set { if (OnPropertyChanging("DebrisClusterData." + nameof(InEffectWorldOnly), this, m_InEffectWorldOnly, value)) m_InEffectWorldOnly = value; } } // 0xC7 (199)
		
		protected bool m_SpawnExplosionOnFirstImpactOnly = new bool();
		[ContainerField(200), LayoutImmutable, Blittable, ContainerFieldNameHash(3769890534)]
		public bool SpawnExplosionOnFirstImpactOnly { get { return m_SpawnExplosionOnFirstImpactOnly; } set { if (OnPropertyChanging("DebrisClusterData." + nameof(SpawnExplosionOnFirstImpactOnly), this, m_SpawnExplosionOnFirstImpactOnly, value)) m_SpawnExplosionOnFirstImpactOnly = value; } } // 0xC8 (200)
		
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
