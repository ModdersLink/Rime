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

namespace fb.SpartaShared;

[ContainerType(8, 40)]
public class SpartaEorSquadStats
	: EbxSerializable
{
	[ContainerField(0x0), LayoutImmutable, Blittable, JsonProperty(Order = 0)]
	public string Name { get; set; } = string.Empty;
	
	[ContainerField(0x8), LayoutImmutable, Blittable, JsonProperty(Order = 8)]
	public float Score { get; set; } = 0.000f;
	
	[ContainerField(0xc), LayoutImmutable, Blittable, JsonProperty(Order = 12)]
	public ushort SquadRank { get; set; } = 0;
	
	[ContainerField(0xe), LayoutImmutable, Blittable, JsonProperty(Order = 14)]
	public ushort MemberCount { get; set; } = 0;
	
	[ContainerField(0x10), LayoutImmutable, Blittable, JsonProperty(Order = 16)]
	public ushort Kills { get; set; } = 0;
	
	[ContainerField(0x12), LayoutImmutable, Blittable, JsonProperty(Order = 18)]
	public ushort Deaths { get; set; } = 0;
	
	[ContainerField(0x14), LayoutImmutable, Blittable, JsonProperty(Order = 20)]
	public ushort CompletedOrders { get; set; } = 0;
	
	[ContainerField(0x16), LayoutImmutable, Blittable, JsonProperty(Order = 22)]
	public ushort Heals { get; set; } = 0;
	
	[ContainerField(0x18), LayoutImmutable, Blittable, JsonProperty(Order = 24)]
	public ushort Revives { get; set; } = 0;
	
	[ContainerField(0x1a), LayoutImmutable, Blittable, JsonProperty(Order = 26)]
	public ushort Resupplies { get; set; } = 0;
	
	[ContainerField(0x1c), LayoutImmutable, Blittable, JsonProperty(Order = 28)]
	public ushort Repairs { get; set; } = 0;
	
	[ContainerField(0x1e), LayoutImmutable, Blittable, JsonProperty(Order = 30)]
	public ushort ReconSpots { get; set; } = 0;
	
	[ContainerField(0x20), LayoutImmutable, Blittable, JsonProperty(Order = 32)]
	public ushort TeamId { get; set; } = 0;
	
	[ContainerField(0x22), LayoutImmutable, Blittable, JsonProperty(Order = 34)]
	public ushort SquadId { get; set; } = 0;
	
}

