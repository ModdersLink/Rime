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
public class PreRoundEntityData
	: fb.Entity.EntityData
{
	[ContainerField(0x18), LayoutImmutable, Blittable, JsonProperty(Order = 24)]
	public int RoundMaxPlayerCount { get; set; } = 8;
	
	[ContainerField(0x1c), LayoutImmutable, Blittable, JsonProperty(Order = 28)]
	public int RoundMinPlayerCount { get; set; } = 4;
	
	[ContainerField(0x20), LayoutImmutable, Blittable, JsonProperty(Order = 32)]
	public int RoundRestartCountdown { get; set; } = 10;
	
	[ContainerField(0x24), LayoutImmutable, Blittable, JsonProperty(Order = 36)]
	public bool Enabled { get; set; } = true;
	
	[ContainerField(0x25), LayoutImmutable, Blittable, JsonProperty(Order = 37)]
	public bool Ready { get; set; } = true;
	
	[ContainerField(0x26), LayoutImmutable, Blittable, JsonProperty(Order = 38)]
	public bool NeededPlayersReadyCount_TwoTeams { get; set; } = true;
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(RoundMaxPlayerCount);
		p_Writer.Write(RoundMinPlayerCount);
		p_Writer.Write(RoundRestartCountdown);
		p_Writer.Write(Enabled);
		p_Writer.Write(Ready);
		p_Writer.Write(NeededPlayersReadyCount_TwoTeams);
		p_Writer.WriteNullBytes(1);
	}
}

