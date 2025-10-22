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
using fb.Entity;

namespace fb.Venice;

[ContainerType(16, 176)]
public class DOTGiverComponentData
	: fb.Entity.GameComponentData
{
	[ContainerField(0x70), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 112)]
	public Vec3 AoEOcclusionRaycastStartOffset { get; set; } = new()
	{
		z = 0.000f,
		y = 0.000f,
		x = 0.000f,
	};
	
	[ContainerField(0x80), LayoutImmutable, Blittable, JsonProperty(Order = 128)]
	public float AoERadius { get; set; } = 1.000f;
	
	[ContainerField(0x84), LayoutImmutable, Blittable, JsonProperty(Order = 132)]
	public float AoEDuration { get; set; } = 5.000f;
	
	[ContainerField(0x88), LayoutImmutable, Blittable, JsonProperty(Order = 136)]
	public float AoEMaxOcclusionRaycastRadius { get; set; } = 0.500f;
	
	[ContainerField(0x8c), LayoutImmutable, Blittable, JsonProperty(Order = 140)]
	public float DoTDuration { get; set; } = 5.000f;
	
	[ContainerField(0x90), LayoutImmutable, Blittable, JsonProperty(Order = 144)]
	public float DoTTickDuration { get; set; } = 0.500f;
	
	[ContainerField(0x94), LayoutImmutable, Blittable, JsonProperty(Order = 148)]
	public int DoTTickDamage { get; set; } = 10;
	
	[ContainerField(0x98), LayoutImmutable, Blittable, JsonProperty(Order = 152)]
	public float DoTSuppressionValue { get; set; } = 0.000f;
	
	[ContainerField(0x9c), LayoutImmutable, Blittable, JsonProperty(Order = 156)]
	public bool AoEInfiniteDuration { get; set; } = false;
	
	[ContainerField(0x9d), LayoutImmutable, Blittable, JsonProperty(Order = 157)]
	public bool AoEIgnoreObstructed { get; set; } = false;
	
	[ContainerField(0x9e), LayoutImmutable, Blittable, JsonProperty(Order = 158)]
	public bool DoTDontDamageShielded { get; set; } = false;
	
	[ContainerField(0x9f), LayoutImmutable, Blittable, JsonProperty(Order = 159)]
	public bool DamageAll { get; set; } = false;
	
	[ContainerField(0xa0), LayoutImmutable, Blittable, JsonProperty(Order = 160)]
	public bool DamageVehicles { get; set; } = false;
	
	[ContainerField(0xa1), LayoutImmutable, Blittable, JsonProperty(Order = 161)]
	public bool DamageCharacters { get; set; } = true;
	
	[ContainerField(0xa2), LayoutImmutable, Blittable, JsonProperty(Order = 162)]
	public bool DamageBangers { get; set; } = false;
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		AoEOcclusionRaycastStartOffset.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(AoERadius);
		p_Writer.Write(AoEDuration);
		p_Writer.Write(AoEMaxOcclusionRaycastRadius);
		p_Writer.Write(DoTDuration);
		p_Writer.Write(DoTTickDuration);
		p_Writer.Write(DoTTickDamage);
		p_Writer.Write(DoTSuppressionValue);
		p_Writer.Write(AoEInfiniteDuration);
		p_Writer.Write(AoEIgnoreObstructed);
		p_Writer.Write(DoTDontDamageShielded);
		p_Writer.Write(DamageAll);
		p_Writer.Write(DamageVehicles);
		p_Writer.Write(DamageCharacters);
		p_Writer.Write(DamageBangers);
		p_Writer.WriteNullBytes(13);
	}
}

