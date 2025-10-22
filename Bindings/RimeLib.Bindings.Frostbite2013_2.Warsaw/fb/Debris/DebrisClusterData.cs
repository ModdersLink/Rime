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

using fb.Entity;
using fb.Core;
using fb.Physics;
using fb.Render;

namespace fb.Debris;

[ContainerType(16, 272)]
public class DebrisClusterData
	: fb.Entity.GameComponentEntityData
{
	[ContainerField(0x80), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 128)]
	public Vec3 InitRotationRndMul { get; set; } = new()
	{
		z = 0.000f,
		y = 0.000f,
		x = 0.000f,
	};
	
	[ContainerField(0x90), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 144)]
	public Vec3 PushVelocityRndMul { get; set; } = new()
	{
		z = 0.000f,
		y = 0.000f,
		x = 0.000f,
	};
	
	[ContainerField(0xa0), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 160)]
	public Vec3 PushVelocityMul { get; set; } = new()
	{
		z = 1.000f,
		y = 1.000f,
		x = 1.000f,
	};
	
	[ContainerField(0xb0), LayoutImmutable, Blittable, JsonProperty(Order = 176)]
	public uint MaxActivePartsCount { get; set; } = 50;
	
	[ContainerField(0xb4), LayoutImmutable, Blittable, JsonProperty(Order = 180)]
	public float RuntimeClusterLifetime { get; set; } = 0.000f;
	
	[ContainerField(0xb8), JsonProperty(Order = 184)]
	public CtrRef<MeshAsset> Mesh { get; set; } = new();
	
	[ContainerField(0xc0), LayoutImmutable, Blittable, JsonProperty(Order = 192)]
	public uint CompositePartCount { get; set; } = 0;
	
	[ContainerField(0xc8), JsonProperty(Order = 200)]
	public List<DebrisClusterPartInfoData> PartHierarchy { get; set; } = new();
	
	[ContainerField(0xd0), JsonProperty(Order = 208)]
	public CtrRef<PhysicsEntityData> PhysicsData { get; set; } = new();
	
	[ContainerField(0xd8), LayoutImmutable, Blittable, JsonProperty(Order = 216)]
	public float ActivationPushForceMul { get; set; } = 1.000f;
	
	[ContainerField(0xdc), LayoutImmutable, Blittable, JsonProperty(Order = 220)]
	public float ProjectileForceTransferMul { get; set; } = 0.000f;
	
	[ContainerField(0xe0), JsonProperty(Order = 224)]
	public CtrRef<EffectBlueprint> ActivationEffect { get; set; } = new();
	
	[ContainerField(0xe8), LayoutImmutable, Blittable, JsonProperty(Order = 232)]
	public float OnPartCollisionSpeedThreshold { get; set; } = 0.000f;
	
	[ContainerField(0xf0), JsonProperty(Order = 240)]
	public CtrRef<EffectBlueprint> Effect { get; set; } = new();
	
	[ContainerField(0xf8), JsonProperty(Order = 248)]
	public CtrRef<SpatialEntityData> Explosion { get; set; } = new();
	
	[ContainerField(0x100), LayoutImmutable, Blittable, JsonProperty(Order = 256)]
	public bool PartialDestruction { get; set; } = false;
	
	[ContainerField(0x101), LayoutImmutable, Blittable, JsonProperty(Order = 257)]
	public bool ClientSideOnly { get; set; } = true;
	
	[ContainerField(0x102), LayoutImmutable, Blittable, JsonProperty(Order = 258)]
	public bool ActivateOnSpawn { get; set; } = true;
	
	[ContainerField(0x103), LayoutImmutable, Blittable, JsonProperty(Order = 259)]
	public bool InEffectWorldOnly { get; set; } = false;
	
	[ContainerField(0x104), LayoutImmutable, Blittable, JsonProperty(Order = 260)]
	public bool NoCollision { get; set; } = false;
	
	[ContainerField(0x105), LayoutImmutable, Blittable, JsonProperty(Order = 261)]
	public bool OnPartCollisionEnable { get; set; } = false;
	
	[ContainerField(0x106), LayoutImmutable, Blittable, JsonProperty(Order = 262)]
	public bool KillPartsOnCollision { get; set; } = false;
	
	[ContainerField(0x107), LayoutImmutable, Blittable, JsonProperty(Order = 263)]
	public bool DeactivatePartsOnSleep { get; set; } = true;
	
	[ContainerField(0x108), LayoutImmutable, Blittable, JsonProperty(Order = 264)]
	public bool SpawnExplosionOnFirstImpactOnly { get; set; } = true;
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		InitRotationRndMul.Serialize(p_Writer, p_EbxWriter);
		PushVelocityRndMul.Serialize(p_Writer, p_EbxWriter);
		PushVelocityMul.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(MaxActivePartsCount);
		p_Writer.Write(RuntimeClusterLifetime);
		p_Writer.Write(p_EbxWriter.WriteImport(Mesh));
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(CompositePartCount);
		p_Writer.WriteNullBytes(4);
		(RimeWriter Writer, uint ArrayIndex) s_PartHierarchy = p_EbxWriter.GetArrayWriter(PartHierarchy.GetType(), PartHierarchy.Count);
		p_Writer.Write(s_PartHierarchy.ArrayIndex);
		foreach (var s_Entry in PartHierarchy)
		{
			s_Entry.Serialize(s_PartHierarchy.Writer, p_EbxWriter);
		}
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(p_EbxWriter.WriteImport(PhysicsData));
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(ActivationPushForceMul);
		p_Writer.Write(ProjectileForceTransferMul);
		p_Writer.Write(p_EbxWriter.WriteImport(ActivationEffect));
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(OnPartCollisionSpeedThreshold);
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(p_EbxWriter.WriteImport(Effect));
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(p_EbxWriter.WriteImport(Explosion));
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(PartialDestruction);
		p_Writer.Write(ClientSideOnly);
		p_Writer.Write(ActivateOnSpawn);
		p_Writer.Write(InEffectWorldOnly);
		p_Writer.Write(NoCollision);
		p_Writer.Write(OnPartCollisionEnable);
		p_Writer.Write(KillPartsOnCollision);
		p_Writer.Write(DeactivatePartsOnSleep);
		p_Writer.Write(SpawnExplosionOnFirstImpactOnly);
		p_Writer.WriteNullBytes(7);
	}
}

