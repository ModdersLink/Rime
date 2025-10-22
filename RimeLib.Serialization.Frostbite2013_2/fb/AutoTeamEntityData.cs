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

namespace fb.VeniceShared;

[ContainerType(8, 40)]
public class AutoTeamEntityData
	: fb.Entity.EntityData
{
	[ContainerField(0x18), LayoutImmutable, Blittable, JsonProperty(Order = 24)]
	public TeamAssignMode TeamAssignMode { get; set; } = fb.VeniceShared.TeamAssignMode.TamEqualTeams;
	
	[ContainerField(0x1c), LayoutImmutable, Blittable, JsonProperty(Order = 28)]
	public uint PlayerCountNeededToAutoBalance { get; set; } = 8;
	
	[ContainerField(0x20), LayoutImmutable, Blittable, JsonProperty(Order = 32)]
	public uint TeamDifferenceToAutoBalance { get; set; } = 3;
	
	[ContainerField(0x24), LayoutImmutable, Blittable, JsonProperty(Order = 36)]
	public bool ForceIntoSquad { get; set; } = false;
	
	[ContainerField(0x25), LayoutImmutable, Blittable, JsonProperty(Order = 37)]
	public bool EnableSquads { get; set; } = true;
	
	[ContainerField(0x26), LayoutImmutable, Blittable, JsonProperty(Order = 38)]
	public bool RotateTeamOnNewRound { get; set; } = true;
	
	[ContainerField(0x27), LayoutImmutable, Blittable, JsonProperty(Order = 39)]
	public bool AutoBalance { get; set; } = true;
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write((int) TeamAssignMode);
		p_Writer.Write(PlayerCountNeededToAutoBalance);
		p_Writer.Write(TeamDifferenceToAutoBalance);
		p_Writer.Write(ForceIntoSquad);
		p_Writer.Write(EnableSquads);
		p_Writer.Write(RotateTeamOnNewRound);
		p_Writer.Write(AutoBalance);
	}
}

