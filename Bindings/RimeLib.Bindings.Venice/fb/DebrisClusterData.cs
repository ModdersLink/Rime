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

		public static void Deserialize(DebrisClusterData p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			fb.Vec3.Deserialize(p_Instance.PushVelocityMul, p_Reader, p_Parser);
			fb.Vec3.Deserialize(p_Instance.PushVelocityRndMul, p_Reader, p_Parser);
			fb.Vec3.Deserialize(p_Instance.InitRotationRndMul, p_Reader, p_Parser);
			p_Instance.ClusterLifetime = p_Reader.ReadSingle();
			p_Instance.Mesh.SetValue(p_Parser.GetImportAtIndex(p_Reader.ReadUInt32()));
			p_Instance.CompositePartCount = p_Reader.ReadUInt32();
			p_Instance.MaxActivePartsCount = p_Reader.ReadUInt32();
			p_Instance.PartHierarchy.Clear();
			(RimeReader Reader, uint Count) s_PartHierarchy = p_Parser.GetArrayReaderAndElementCount(p_Reader.ReadUInt32());
			for (uint i = 0; i < s_PartHierarchy.Count; ++i)
			{
				var s_Value = new DebrisClusterPartInfoData();
				fb.DebrisClusterPartInfoData.Deserialize(s_Value, s_PartHierarchy.Reader, p_Parser);
				p_Instance.PartHierarchy.Add(s_Value);
			}
			
			s_PartHierarchy.Reader.Dispose();
			p_Instance.ActivationPushForceMul = p_Reader.ReadSingle();
			p_Instance.ProjectileForceTransferMul = p_Reader.ReadSingle();
			p_Instance.PhysicsData.SetValue(p_Parser.GetImportAtIndex(p_Reader.ReadUInt32()));
			p_Instance.Explosion.SetValue(p_Parser.GetImportAtIndex(p_Reader.ReadUInt32()));
			p_Instance.ActivationEffect.SetValue(p_Parser.GetImportAtIndex(p_Reader.ReadUInt32()));
			p_Instance.Effect.SetValue(p_Parser.GetImportAtIndex(p_Reader.ReadUInt32()));
			p_Instance.OnPartCollisionSpeedThreshold = p_Reader.ReadSingle();
			p_Instance.PartialDestruction = p_Reader.ReadBool();
			p_Instance.ClientSideOnly = p_Reader.ReadBool();
			p_Instance.OnPartCollisionEnable = p_Reader.ReadBool();
			p_Instance.NoCollision = p_Reader.ReadBool();
			p_Instance.KillPartsOnCollision = p_Reader.ReadBool();
			p_Instance.DeactivatePartsOnSleep = p_Reader.ReadBool();
			p_Instance.ActivateOnSpawn = p_Reader.ReadBool();
			p_Instance.InEffectWorldOnly = p_Reader.ReadBool();
			p_Instance.SpawnExplosionOnFirstImpactOnly = p_Reader.ReadBool();
			p_Reader.Seek(7, SeekOrigin.Current);
		}

	}
}
