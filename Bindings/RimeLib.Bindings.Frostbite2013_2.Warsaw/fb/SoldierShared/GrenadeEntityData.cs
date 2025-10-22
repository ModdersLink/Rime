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

[ContainerType(16, 352)]
public class GrenadeEntityData
	: fb.GameShared.GhostedProjectileEntityData
{
	public GrenadeEntityData()
	{
		//ProjectileEntityData
		DetonateOnTimeout = true;
	}
	
	[ContainerField(0x130), LayoutImmutable, Blittable, JsonProperty(Order = 304)]
	public float Gravity { get; set; } = -9.800f;
	
	[ContainerField(0x134), LayoutImmutable, Blittable, JsonProperty(Order = 308)]
	public float CollisionSpeedMultiplier { get; set; } = 0.300f;
	
	[ContainerField(0x138), LayoutImmutable, Blittable, JsonProperty(Order = 312)]
	public float MinBounceSpeed { get; set; } = 2.000f;
	
	[ContainerField(0x13c), LayoutImmutable, Blittable, JsonProperty(Order = 316)]
	public float CollisionDamage { get; set; } = 0.000f;
	
	[ContainerField(0x140), LayoutImmutable, Blittable, JsonProperty(Order = 320)]
	public GrenadeType GrenadeType { get; set; } = fb.SoldierShared.GrenadeType.GrenadeType_NotSet;
	
	[ContainerField(0x148), LayoutImmutable, Blittable, JsonProperty(Order = 328)]
	public string HudIndicatorIcon { get; set; } = @"grenade";
	
	[ContainerField(0x150), LayoutImmutable, Blittable, JsonProperty(Order = 336)]
	public bool UseGrenadeCollisionMessage { get; set; } = true;
	
	[ContainerField(0x151), LayoutImmutable, Blittable, JsonProperty(Order = 337)]
	public bool ShowHudIndicator { get; set; } = true;
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(Gravity);
		p_Writer.Write(CollisionSpeedMultiplier);
		p_Writer.Write(MinBounceSpeed);
		p_Writer.Write(CollisionDamage);
		p_Writer.Write((int) GrenadeType);
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(p_EbxWriter.WriteString(HudIndicatorIcon));
		p_Writer.Write(UseGrenadeCollisionMessage);
		p_Writer.Write(ShowHudIndicator);
		p_Writer.WriteNullBytes(14);
	}
}

