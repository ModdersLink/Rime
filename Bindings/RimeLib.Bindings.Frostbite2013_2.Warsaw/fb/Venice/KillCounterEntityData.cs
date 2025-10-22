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
using fb.Entity;

namespace fb.Venice;

[ContainerType(8, 64)]
public class KillCounterEntityData
	: fb.Entity.EntityData
{
	[ContainerField(0x18), LayoutImmutable, Blittable, JsonProperty(Order = 24)]
	public TeamId TeamId { get; set; } = fb.GameShared.TeamId.Team1;
	
	[ContainerField(0x1c), LayoutImmutable, Blittable, JsonProperty(Order = 28)]
	public int MaxKillCount { get; set; } = 50;
	
	[ContainerField(0x20), LayoutImmutable, Blittable, JsonProperty(Order = 32)]
	public float EnemyWeight { get; set; } = 1.000f;
	
	[ContainerField(0x24), JsonProperty(Order = 36)]
	public KillWeight NeutralTeamWeight { get; set; } = new();
	
	[ContainerField(0x30), JsonProperty(Order = 48)]
	public KillWeight TeamKillWeight { get; set; } = new();
	
	[ContainerField(0x3c), LayoutImmutable, Blittable, JsonProperty(Order = 60)]
	public bool IgnoreAI { get; set; } = false;
	
	[ContainerField(0x3d), LayoutImmutable, Blittable, JsonProperty(Order = 61)]
	public bool Enabled { get; set; } = true;
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write((int) TeamId);
		p_Writer.Write(MaxKillCount);
		p_Writer.Write(EnemyWeight);
		NeutralTeamWeight.Serialize(p_Writer, p_EbxWriter);
		TeamKillWeight.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(IgnoreAI);
		p_Writer.Write(Enabled);
		p_Writer.WriteNullBytes(2);
	}
}

