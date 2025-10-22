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

using fb.Core;
using fb.GameShared;
using fb.Render;
using fb.Entity;
using fb.Physics;

namespace fb.SoldierShared;

[ContainerType(16, 400)]
public class ExplosionPackEntityData
	: fb.GameShared.GhostedProjectileEntityData
{
	public ExplosionPackEntityData()
	{
		//ProjectileEntityData
		InitialSpeed = 0.000f;
		//MeshProjectileEntityData
		IsAttachable = true;
		//GhostedProjectileEntityData
		ForceProxyConvergence = true;
	}
	
	[ContainerField(0x130), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 304)]
	public Vec3 WorldIconOffset { get; set; } = new()
	{
		z = 0.000f,
		y = 0.350f,
		x = 0.000f,
	};
	
	[ContainerField(0x140), JsonProperty(Order = 320)]
	public SoldierDetonationData SoldierDetonationData { get; set; } = new();
	
	[ContainerField(0x158), JsonProperty(Order = 344)]
	public RefArray<ExplosionPackTrigger> ExplosionPackTriggers { get; set; } = new();
	
	[ContainerField(0x160), LayoutImmutable, Blittable, JsonProperty(Order = 352)]
	public float GravityScale { get; set; } = 1.000f;
	
	[ContainerField(0x164), LayoutImmutable, Blittable, JsonProperty(Order = 356)]
	public float TimeToLiveOnPlayerDeath { get; set; } = 0.000f;
	
	[ContainerField(0x168), LayoutImmutable, Blittable, JsonProperty(Order = 360)]
	public float Health { get; set; } = 0.000f;
	
	[ContainerField(0x16c), LayoutImmutable, Blittable, JsonProperty(Order = 364)]
	public float SpottedTime { get; set; } = 30.000f;
	
	[ContainerField(0x170), LayoutImmutable, Blittable, JsonProperty(Order = 368)]
	public float DefuseRadius { get; set; } = 2.000f;
	
	[ContainerField(0x178), LayoutImmutable, Blittable, JsonProperty(Order = 376)]
	public string IconName { get; set; } = string.Empty;
	
	[ContainerField(0x180), LayoutImmutable, Blittable, JsonProperty(Order = 384)]
	public bool IsDestructible { get; set; } = false;
	
	[ContainerField(0x181), LayoutImmutable, Blittable, JsonProperty(Order = 385)]
	public bool ReceivesExplosionDamage { get; set; } = false;
	
	[ContainerField(0x182), LayoutImmutable, Blittable, JsonProperty(Order = 386)]
	public bool ShowInSpectatorUI { get; set; } = true;
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		WorldIconOffset.Serialize(p_Writer, p_EbxWriter);
		SoldierDetonationData.Serialize(p_Writer, p_EbxWriter);
		p_Writer.WriteNullBytes(4);
		(RimeWriter Writer, uint ArrayIndex) s_ExplosionPackTriggers = p_EbxWriter.GetArrayWriter(ExplosionPackTriggers.GetType(), ExplosionPackTriggers.Count);
		p_Writer.Write(s_ExplosionPackTriggers.ArrayIndex);
		foreach (var s_Entry in ExplosionPackTriggers)
		{
			s_ExplosionPackTriggers.Writer.Write(p_EbxWriter.WriteImport(s_Entry));
		}
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(GravityScale);
		p_Writer.Write(TimeToLiveOnPlayerDeath);
		p_Writer.Write(Health);
		p_Writer.Write(SpottedTime);
		p_Writer.Write(DefuseRadius);
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(p_EbxWriter.WriteString(IconName));
		p_Writer.Write(IsDestructible);
		p_Writer.Write(ReceivesExplosionDamage);
		p_Writer.Write(ShowInSpectatorUI);
		p_Writer.WriteNullBytes(13);
	}
}

