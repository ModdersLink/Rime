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

namespace fb.Venice;

[ContainerType(8, 112)]
public class TabletCommanderLowFrequencyPacket
	: EbxSerializable
{
	[ContainerField(0x0), JsonProperty(Order = 0)]
	public TabletCommanderPacketBase PacketBase { get; set; } = new();
	
	[ContainerField(0x10), JsonProperty(Order = 16)]
	public List<TabletCommanderNetworkSoldierState> FriendlyDeadSoldierList { get; set; } = new();
	
	[ContainerField(0x18), JsonProperty(Order = 24)]
	public List<TabletCommanderObjective> ObjectiveList { get; set; } = new();
	
	[ContainerField(0x20), JsonProperty(Order = 32)]
	public List<TabletCommanderOrder> OrderList { get; set; } = new();
	
	[ContainerField(0x28), JsonProperty(Order = 40)]
	public List<TabletCommanderSquadRequest> SquadRequestList { get; set; } = new();
	
	[ContainerField(0x30), JsonProperty(Order = 48)]
	public List<TabletCommanderMapMarker> MapMarkerList { get; set; } = new();
	
	[ContainerField(0x38), JsonProperty(Order = 56)]
	public TabletCommanderTickets Tickets { get; set; } = new();
	
	[ContainerField(0x48), JsonProperty(Order = 72)]
	public TabletCommanderMutinyState MutinyState { get; set; } = new();
	
	[ContainerField(0x54), LayoutImmutable, Blittable, JsonProperty(Order = 84)]
	public uint RoundTimeSeconds { get; set; } = 0;
	
	[ContainerField(0x58), LayoutImmutable, Blittable, JsonProperty(Order = 88)]
	public uint SquadPoints { get; set; } = 0;
	
	[ContainerField(0x5c), LayoutImmutable, Blittable, JsonProperty(Order = 92)]
	public uint PreRoundPlayerReadyCount { get; set; } = 0;
	
	[ContainerField(0x60), LayoutImmutable, Blittable, JsonProperty(Order = 96)]
	public uint PreRoundRestartTime { get; set; } = 0;
	
	[ContainerField(0x64), LayoutImmutable, Blittable, JsonProperty(Order = 100)]
	public int ObliterationTargetsArmedBitmask { get; set; } = 0;
	
	[ContainerField(0x68), LayoutImmutable, Blittable, JsonProperty(Order = 104)]
	public int ObliterationTargetsDestroyedBitmask { get; set; } = 0;
	
	[ContainerField(0x6c), LayoutImmutable, Blittable, JsonProperty(Order = 108)]
	public byte CurrentCratesCount { get; set; } = 0;
	
}

