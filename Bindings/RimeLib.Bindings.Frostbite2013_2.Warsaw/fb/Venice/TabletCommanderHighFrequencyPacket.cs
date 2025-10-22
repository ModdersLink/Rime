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


namespace fb.Venice;

[ContainerType(8, 72)]
public class TabletCommanderHighFrequencyPacket
	: EbxSerializable
{
	[ContainerField(0x0), JsonProperty(Order = 0)]
	public TabletCommanderPacketBase PacketBase { get; set; } = new();
	
	[ContainerField(0x10), JsonProperty(Order = 16)]
	public List<TabletCommanderHighFrequencyFriendlySquad> FriendlySquadList { get; set; } = new();
	
	[ContainerField(0x18), JsonProperty(Order = 24)]
	public List<TabletCommanderNetworkVehicleState> FriendlyVehicleList { get; set; } = new();
	
	[ContainerField(0x20), JsonProperty(Order = 32)]
	public List<TabletCommanderNetworkState> FriendlyTomahawkList { get; set; } = new();
	
	[ContainerField(0x28), JsonProperty(Order = 40)]
	public List<TabletCommanderNetworkSoldierState> SpottedEnemySoldierList { get; set; } = new();
	
	[ContainerField(0x30), JsonProperty(Order = 48)]
	public List<TabletCommanderNetworkVehicleState> SpottedEnemyVehicleList { get; set; } = new();
	
	[ContainerField(0x38), JsonProperty(Order = 56)]
	public List<TabletCommanderNetworkState> SpottedEnemyTomahawkList { get; set; } = new();
	
	[ContainerField(0x40), JsonProperty(Order = 64)]
	public List<TabletCommanderNetworkBombState> ObliterationBomb { get; set; } = new();
	
}

