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

namespace fb.Venice;

[ContainerType(8, 24)]
public class TabletCommanderHighFrequencyFriendlySquad
	: EbxSerializable
{
	[ContainerField(0x0), LayoutImmutable, Blittable, JsonProperty(Order = 0)]
	public SquadId SquadId { get; set; } = fb.GameShared.SquadId.SquadNone;
	
	[ContainerField(0x4), LayoutImmutable, Blittable, JsonProperty(Order = 4)]
	public float NormalizedSquadScore { get; set; } = 0.000f;
	
	[ContainerField(0x8), LayoutImmutable, Blittable, JsonProperty(Order = 8)]
	public bool IsSquadWipeProtected { get; set; } = false;
	
	[ContainerField(0x9), LayoutImmutable, Blittable, JsonProperty(Order = 9)]
	public bool IsSquadReinforced { get; set; } = false;
	
	[ContainerField(0x10), JsonProperty(Order = 16)]
	public List<TabletCommanderNetworkSoldierState> Soldiers { get; set; } = new();
	
}

