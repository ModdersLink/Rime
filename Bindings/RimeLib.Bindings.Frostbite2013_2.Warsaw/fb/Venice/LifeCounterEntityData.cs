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

[ContainerType(8, 112)]
public class LifeCounterEntityData
	: fb.Entity.EntityData
{
	[ContainerField(0x18), LayoutImmutable, Blittable, JsonProperty(Order = 24)]
	public TeamId TeamId { get; set; } = fb.GameShared.TeamId.Team1;
	
	[ContainerField(0x20), JsonProperty(Order = 32)]
	public List<int> LifeTresholdValues { get; set; } = new();
	
	[ContainerField(0x28), LayoutImmutable, Blittable, JsonProperty(Order = 40)]
	public int UiShowCountLowerThreshold { get; set; } = 10;
	
	[ContainerField(0x2c), LayoutImmutable, Blittable, JsonProperty(Order = 44)]
	public int UiShowCountUpperThreshold { get; set; } = 20;
	
	[ContainerField(0x30), LayoutImmutable, Blittable, JsonProperty(Order = 48)]
	public int StartingLifeCount { get; set; } = 100;
	
	[ContainerField(0x34), LayoutImmutable, Blittable, JsonProperty(Order = 52)]
	public int BaseCount { get; set; } = 0;
	
	[ContainerField(0x38), LayoutImmutable, Blittable, JsonProperty(Order = 56)]
	public int ReinforceThreshold { get; set; } = 0;
	
	[ContainerField(0x40), JsonProperty(Order = 64)]
	public List<float> ReinforceTable { get; set; } = new();
	
	[ContainerField(0x48), LayoutImmutable, Blittable, JsonProperty(Order = 72)]
	public float DefensiveKillRadius { get; set; } = 10.000f;
	
	[ContainerField(0x4c), LayoutImmutable, Blittable, JsonProperty(Order = 76)]
	public float FallbackTime { get; set; } = 20.000f;
	
	[ContainerField(0x50), LayoutImmutable, Blittable, JsonProperty(Order = 80)]
	public string FightHarderMessageSid { get; set; } = string.Empty;
	
	[ContainerField(0x58), LayoutImmutable, Blittable, JsonProperty(Order = 88)]
	public float FightHarderTreshold { get; set; } = 20.000f;
	
	[ContainerField(0x60), LayoutImmutable, Blittable, JsonProperty(Order = 96)]
	public string ReinforceMessageSid { get; set; } = string.Empty;
	
	[ContainerField(0x68), LayoutImmutable, Blittable, JsonProperty(Order = 104)]
	public float DisplayTime { get; set; } = 5.000f;
	
	[ContainerField(0x6c), LayoutImmutable, Blittable, JsonProperty(Order = 108)]
	public bool Attacker { get; set; } = false;
	
	[ContainerField(0x6d), LayoutImmutable, Blittable, JsonProperty(Order = 109)]
	public bool SimpleReinforce { get; set; } = true;
	
	[ContainerField(0x6e), LayoutImmutable, Blittable, JsonProperty(Order = 110)]
	public bool SetBestSquadSpawner { get; set; } = true;
	
	[ContainerField(0x6f), LayoutImmutable, Blittable, JsonProperty(Order = 111)]
	public bool Enabled { get; set; } = true;
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write((int) TeamId);
		p_Writer.WriteNullBytes(4);
		(RimeWriter Writer, uint ArrayIndex) s_LifeTresholdValues = p_EbxWriter.GetArrayWriter(LifeTresholdValues.GetType(), LifeTresholdValues.Count);
		p_Writer.Write(s_LifeTresholdValues.ArrayIndex);
		foreach (var s_Entry in LifeTresholdValues)
		{
			s_LifeTresholdValues.Writer.Write(s_Entry);
		}
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(UiShowCountLowerThreshold);
		p_Writer.Write(UiShowCountUpperThreshold);
		p_Writer.Write(StartingLifeCount);
		p_Writer.Write(BaseCount);
		p_Writer.Write(ReinforceThreshold);
		p_Writer.WriteNullBytes(4);
		(RimeWriter Writer, uint ArrayIndex) s_ReinforceTable = p_EbxWriter.GetArrayWriter(ReinforceTable.GetType(), ReinforceTable.Count);
		p_Writer.Write(s_ReinforceTable.ArrayIndex);
		foreach (var s_Entry in ReinforceTable)
		{
			s_ReinforceTable.Writer.Write(s_Entry);
		}
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(DefensiveKillRadius);
		p_Writer.Write(FallbackTime);
		p_Writer.Write(p_EbxWriter.WriteString(FightHarderMessageSid));
		p_Writer.Write(FightHarderTreshold);
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(p_EbxWriter.WriteString(ReinforceMessageSid));
		p_Writer.Write(DisplayTime);
		p_Writer.Write(Attacker);
		p_Writer.Write(SimpleReinforce);
		p_Writer.Write(SetBestSquadSpawner);
		p_Writer.Write(Enabled);
	}
}

