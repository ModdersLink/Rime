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

namespace fb.VeniceShared;

[ContainerType(8, 80)]
public class TicketCounterEntityData
	: fb.Entity.EntityData
{
	[ContainerField(0x18), LayoutImmutable, Blittable, JsonProperty(Order = 24)]
	public TeamId TeamId { get; set; } = fb.GameShared.TeamId.Team1;
	
	[ContainerField(0x1c), LayoutImmutable, Blittable, JsonProperty(Order = 28)]
	public int TicketLossWhenLostAll { get; set; } = 9999;
	
	[ContainerField(0x20), LayoutImmutable, Blittable, JsonProperty(Order = 32)]
	public int TicketLossWhenLostAllControlsPoint { get; set; } = 9999;
	
	[ContainerField(0x24), LayoutImmutable, Blittable, JsonProperty(Order = 36)]
	public int TicketLossPerMin { get; set; } = 10;
	
	[ContainerField(0x28), LayoutImmutable, Blittable, JsonProperty(Order = 40)]
	public float NumberOfTicketsToDecrement { get; set; } = 1.000f;
	
	[ContainerField(0x30), JsonProperty(Order = 48)]
	public List<TicketCountPercentage> TicketPercentages { get; set; } = new();
	
	[ContainerField(0x38), LayoutImmutable, Blittable, JsonProperty(Order = 56)]
	public int TicketLossStart { get; set; } = 100;
	
	[ContainerField(0x3c), LayoutImmutable, Blittable, JsonProperty(Order = 60)]
	public int InitialTicketCount { get; set; } = 100;
	
	[ContainerField(0x40), LayoutImmutable, Blittable, JsonProperty(Order = 64)]
	public TicketDecreaseType DecreaseTickets { get; set; } = TicketDecreaseType.TDTOnKilled;
	
	[ContainerField(0x44), LayoutImmutable, Blittable, JsonProperty(Order = 68)]
	public bool SetBestSquadSpawner { get; set; } = true;
	
	[ContainerField(0x45), LayoutImmutable, Blittable, JsonProperty(Order = 69)]
	public bool HaltTicketLossOnEqualPointCount { get; set; } = false;
	
	[ContainerField(0x46), LayoutImmutable, Blittable, JsonProperty(Order = 70)]
	public bool ResetCapturePointsOnReset { get; set; } = false;
	
	[ContainerField(0x47), LayoutImmutable, Blittable, JsonProperty(Order = 71)]
	public bool SpawnAlwaysAllowed { get; set; } = false;
	
	[ContainerField(0x48), LayoutImmutable, Blittable, JsonProperty(Order = 72)]
	public bool GameModeCounterModifierAllowed { get; set; } = true;
	
	[ContainerField(0x49), LayoutImmutable, Blittable, JsonProperty(Order = 73)]
	public bool IsActive { get; set; } = true;
	
	[ContainerField(0x4a), LayoutImmutable, Blittable, JsonProperty(Order = 74)]
	public bool FastBleedWhenAllFlagsControlledByEnemy { get; set; } = false;
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write((int) TeamId);
		p_Writer.Write(TicketLossWhenLostAll);
		p_Writer.Write(TicketLossWhenLostAllControlsPoint);
		p_Writer.Write(TicketLossPerMin);
		p_Writer.Write(NumberOfTicketsToDecrement);
		p_Writer.WriteNullBytes(4);
		(RimeWriter Writer, uint ArrayIndex) s_TicketPercentages = p_EbxWriter.GetArrayWriter(TicketPercentages.GetType(), TicketPercentages.Count);
		p_Writer.Write(s_TicketPercentages.ArrayIndex);
		foreach (var s_Entry in TicketPercentages)
		{
			s_Entry.Serialize(s_TicketPercentages.Writer, p_EbxWriter);
		}
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(TicketLossStart);
		p_Writer.Write(InitialTicketCount);
		p_Writer.Write((int) DecreaseTickets);
		p_Writer.Write(SetBestSquadSpawner);
		p_Writer.Write(HaltTicketLossOnEqualPointCount);
		p_Writer.Write(ResetCapturePointsOnReset);
		p_Writer.Write(SpawnAlwaysAllowed);
		p_Writer.Write(GameModeCounterModifierAllowed);
		p_Writer.Write(IsActive);
		p_Writer.Write(FastBleedWhenAllFlagsControlledByEnemy);
		p_Writer.WriteNullBytes(5);
	}
}

