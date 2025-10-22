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

[ContainerType(16, 224)]
public class CommanderEntityData
	: fb.Entity.GameComponentEntityData
{
	[ContainerField(0x80), LayoutImmutable, Blittable, JsonProperty(Order = 128)]
	public TeamId Team { get; set; } = TeamId.TeamNeutral;
	
	[ContainerField(0x88), JsonProperty(Order = 136)]
	public CtrRef<CharacterCustomizationAsset> Kit { get; set; } = new();
	
	[ContainerField(0x90), LayoutImmutable, Blittable, JsonProperty(Order = 144)]
	public int CommanderActionDisplayTime { get; set; } = 3;
	
	[ContainerField(0x94), LayoutImmutable, Blittable, JsonProperty(Order = 148)]
	public float CommanderViewWidth { get; set; } = 200.000f;
	
	[ContainerField(0x98), LayoutImmutable, Blittable, JsonProperty(Order = 152)]
	public float TopDownCameraSpeed { get; set; } = 100.000f;
	
	[ContainerField(0x9c), LayoutImmutable, Blittable, JsonProperty(Order = 156)]
	public float SquadRequestDuration { get; set; } = 60.000f;
	
	[ContainerField(0xa0), LayoutImmutable, Blittable, JsonProperty(Order = 160)]
	public float InitialMutinyDisabledDuration { get; set; } = 10.000f;
	
	[ContainerField(0xa4), LayoutImmutable, Blittable, JsonProperty(Order = 164)]
	public float MutinyThreshold { get; set; } = 0.500f;
	
	[ContainerField(0xa8), LayoutImmutable, Blittable, JsonProperty(Order = 168)]
	public float MutinyDuration { get; set; } = 60.000f;
	
	[ContainerField(0xac), LayoutImmutable, Blittable, JsonProperty(Order = 172)]
	public float RatingCooldown { get; set; } = 30.000f;
	
	[ContainerField(0xb0), LayoutImmutable, Blittable, JsonProperty(Order = 176)]
	public float LocalEMPPulseDuration { get; set; } = 2.000f;
	
	[ContainerField(0xb4), LayoutImmutable, Blittable, JsonProperty(Order = 180)]
	public float GlobalEMPDuration { get; set; } = 20.000f;
	
	[ContainerField(0xb8), LayoutImmutable, Blittable, JsonProperty(Order = 184)]
	public int SquadBarPointsPerSegment { get; set; } = 1000;
	
	[ContainerField(0xc0), JsonProperty(Order = 192)]
	public List<CommanderActionType> SquadBarActions { get; set; } = new();
	
	[ContainerField(0xc8), JsonProperty(Order = 200)]
	public List<CommanderActionType> GlobalActions { get; set; } = new();
	
	[ContainerField(0xd0), LayoutImmutable, Blittable, JsonProperty(Order = 208)]
	public bool AdjustCameraToTerrain { get; set; } = true;
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write((int) Team);
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(p_EbxWriter.WriteImport(Kit));
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(CommanderActionDisplayTime);
		p_Writer.Write(CommanderViewWidth);
		p_Writer.Write(TopDownCameraSpeed);
		p_Writer.Write(SquadRequestDuration);
		p_Writer.Write(InitialMutinyDisabledDuration);
		p_Writer.Write(MutinyThreshold);
		p_Writer.Write(MutinyDuration);
		p_Writer.Write(RatingCooldown);
		p_Writer.Write(LocalEMPPulseDuration);
		p_Writer.Write(GlobalEMPDuration);
		p_Writer.Write(SquadBarPointsPerSegment);
		p_Writer.WriteNullBytes(4);
		(RimeWriter Writer, uint ArrayIndex) s_SquadBarActions = p_EbxWriter.GetArrayWriter(SquadBarActions.GetType(), SquadBarActions.Count);
		p_Writer.Write(s_SquadBarActions.ArrayIndex);
		foreach (var s_Entry in SquadBarActions)
		{
			s_SquadBarActions.Writer.Write((int) s_Entry);
		}
		p_Writer.WriteNullBytes(4);
		(RimeWriter Writer, uint ArrayIndex) s_GlobalActions = p_EbxWriter.GetArrayWriter(GlobalActions.GetType(), GlobalActions.Count);
		p_Writer.Write(s_GlobalActions.ArrayIndex);
		foreach (var s_Entry in GlobalActions)
		{
			s_GlobalActions.Writer.Write((int) s_Entry);
		}
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(AdjustCameraToTerrain);
		p_Writer.WriteNullBytes(15);
	}
}

