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

[ContainerType(4, 24)]
public class TabletCommanderNetworkSoldierState
	: EbxSerializable
{
	[ContainerField(0x0), JsonProperty(Order = 0)]
	public TabletCommanderNetworkState NetworkState { get; set; } = new();
	
	[ContainerField(0xc), LayoutImmutable, Blittable, JsonProperty(Order = 12)]
	public uint InVehicleId { get; set; } = 0;
	
	[ContainerField(0x10), LayoutImmutable, Blittable, JsonProperty(Order = 16)]
	public byte SoldierKit { get; set; } = 0;
	
	[ContainerField(0x11), LayoutImmutable, Blittable, JsonProperty(Order = 17)]
	public bool IsSquadLeader { get; set; } = false;
	
	[ContainerField(0x12), LayoutImmutable, Blittable, JsonProperty(Order = 18)]
	public bool IsOnKillStreak { get; set; } = false;
	
	[ContainerField(0x13), LayoutImmutable, Blittable, JsonProperty(Order = 19)]
	public bool IsHighValueTarget { get; set; } = false;
	
	[ContainerField(0x14), LayoutImmutable, Blittable, JsonProperty(Order = 20)]
	public bool IsFiring { get; set; } = false;
	
}

