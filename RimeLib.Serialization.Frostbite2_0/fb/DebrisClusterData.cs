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
using RimeLib.Serialization.Frostbite2_0.Ebx;

namespace fb
{
	[ContainerType(16, 208)]
	public class DebrisClusterData :
		GameEntityData
	{
		[ContainerField(96), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 96)]
		public Vec3 PushVelocityMul { get; set; } = new();

		[ContainerField(112), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 112)]
		public Vec3 PushVelocityRndMul { get; set; } = new();

		[ContainerField(128), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 128)]
		public Vec3 InitRotationRndMul { get; set; } = new();

		[ContainerField(144), LayoutImmutable, Blittable, JsonProperty(Order = 144)]
		public float ClusterLifetime { get; set; }

		[ContainerField(148), JsonProperty(Order = 148)]
		public CtrRef<MeshAsset> Mesh { get; set; } = new();

		[ContainerField(152), LayoutImmutable, Blittable, JsonProperty(Order = 152)]
		public uint CompositePartCount { get; set; }

		[ContainerField(156), LayoutImmutable, Blittable, JsonProperty(Order = 156)]
		public uint MaxActivePartsCount { get; set; }

		[ContainerField(160), JsonProperty(Order = 160)]
		public List<DebrisClusterPartInfoData> PartHierarchy { get; set; } = new();

		[ContainerField(164), LayoutImmutable, Blittable, JsonProperty(Order = 164)]
		public float ActivationPushForceMul { get; set; }

		[ContainerField(168), LayoutImmutable, Blittable, JsonProperty(Order = 168)]
		public float ProjectileForceTransferMul { get; set; }

		[ContainerField(172), JsonProperty(Order = 172)]
		public CtrRef<PhysicsEntityData> PhysicsData { get; set; } = new();

		[ContainerField(176), JsonProperty(Order = 176)]
		public CtrRef<GameEntityData> Explosion { get; set; } = new();

		[ContainerField(180), JsonProperty(Order = 180)]
		public CtrRef<EffectBlueprint> ActivationEffect { get; set; } = new();

		[ContainerField(184), JsonProperty(Order = 184)]
		public CtrRef<EffectBlueprint> Effect { get; set; } = new();

		[ContainerField(188), LayoutImmutable, Blittable, JsonProperty(Order = 188)]
		public float OnPartCollisionSpeedThreshold { get; set; }

		[ContainerField(192), LayoutImmutable, Blittable, JsonProperty(Order = 192)]
		public bool PartialDestruction { get; set; }

		[ContainerField(193), LayoutImmutable, Blittable, JsonProperty(Order = 193)]
		public bool ClientSideOnly { get; set; }

		[ContainerField(194), LayoutImmutable, Blittable, JsonProperty(Order = 194)]
		public bool OnPartCollisionEnable { get; set; }

		[ContainerField(195), LayoutImmutable, Blittable, JsonProperty(Order = 195)]
		public bool NoCollision { get; set; }

		[ContainerField(196), LayoutImmutable, Blittable, JsonProperty(Order = 196)]
		public bool KillPartsOnCollision { get; set; }

		[ContainerField(197), LayoutImmutable, Blittable, JsonProperty(Order = 197)]
		public bool DeactivatePartsOnSleep { get; set; }

		[ContainerField(198), LayoutImmutable, Blittable, JsonProperty(Order = 198)]
		public bool ActivateOnSpawn { get; set; }

		[ContainerField(199), LayoutImmutable, Blittable, JsonProperty(Order = 199)]
		public bool InEffectWorldOnly { get; set; }

		[ContainerField(200), LayoutImmutable, Blittable, JsonProperty(Order = 200)]
		public bool SpawnExplosionOnFirstImpactOnly { get; set; }

		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			PushVelocityMul.Serialize(p_Writer, p_EbxWriter);
			PushVelocityRndMul.Serialize(p_Writer, p_EbxWriter);
			InitRotationRndMul.Serialize(p_Writer, p_EbxWriter);
			p_Writer.Write(ClusterLifetime);
			p_Writer.Write(p_EbxWriter.WriteImport(Mesh));
			p_Writer.Write(CompositePartCount);
			p_Writer.Write(MaxActivePartsCount);
			(RimeWriter Writer, uint ArrayIndex) s_PartHierarchy = p_EbxWriter.GetArrayWriter(PartHierarchy.GetType(), PartHierarchy.Count);
			p_Writer.Write(s_PartHierarchy.ArrayIndex);
			foreach (var s_Entry in PartHierarchy)
			{
				s_Entry.Serialize(s_PartHierarchy.Writer, p_EbxWriter);
			}
			p_Writer.Write(ActivationPushForceMul);
			p_Writer.Write(ProjectileForceTransferMul);
			p_Writer.Write(p_EbxWriter.WriteImport(PhysicsData));
			p_Writer.Write(p_EbxWriter.WriteImport(Explosion));
			p_Writer.Write(p_EbxWriter.WriteImport(ActivationEffect));
			p_Writer.Write(p_EbxWriter.WriteImport(Effect));
			p_Writer.Write(OnPartCollisionSpeedThreshold);
			p_Writer.Write(PartialDestruction);
			p_Writer.Write(ClientSideOnly);
			p_Writer.Write(OnPartCollisionEnable);
			p_Writer.Write(NoCollision);
			p_Writer.Write(KillPartsOnCollision);
			p_Writer.Write(DeactivatePartsOnSleep);
			p_Writer.Write(ActivateOnSpawn);
			p_Writer.Write(InEffectWorldOnly);
			p_Writer.Write(SpawnExplosionOnFirstImpactOnly);
			p_Writer.WriteNullBytes(7);
		}
	}
}
