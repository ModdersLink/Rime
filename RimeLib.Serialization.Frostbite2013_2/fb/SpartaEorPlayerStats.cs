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

[ContainerType(8, 48)]
public class SpartaEorPlayerStats
	: EbxSerializable
{
	[ContainerField(0x0), LayoutImmutable, Blittable, JsonProperty(Order = 0)]
	public string Name { get; set; } = string.Empty;
	
	[ContainerField(0x8), LayoutImmutable, Blittable, JsonProperty(Order = 8)]
	public string Platoon { get; set; } = string.Empty;
	
	[ContainerField(0x10), LayoutImmutable, Blittable, JsonProperty(Order = 16)]
	public float Score { get; set; } = 0.000f;
	
	[ContainerField(0x18), LayoutImmutable, Blittable, JsonProperty(Order = 24)]
	public string PlayerId { get; set; } = string.Empty;
	
	[ContainerField(0x20), LayoutImmutable, Blittable, JsonProperty(Order = 32)]
	public ushort Rank { get; set; } = 0;
	
	[ContainerField(0x22), LayoutImmutable, Blittable, JsonProperty(Order = 34)]
	public ushort Kills { get; set; } = 0;
	
	[ContainerField(0x24), LayoutImmutable, Blittable, JsonProperty(Order = 36)]
	public ushort Deaths { get; set; } = 0;
	
	[ContainerField(0x26), LayoutImmutable, Blittable, JsonProperty(Order = 38)]
	public ushort SquadId { get; set; } = 0;
	
	[ContainerField(0x28), LayoutImmutable, Blittable, JsonProperty(Order = 40)]
	public ushort TeamId { get; set; } = 0;
	
	[ContainerField(0x2a), LayoutImmutable, Blittable, JsonProperty(Order = 42)]
	public bool IsMe { get; set; } = false;
	
	[ContainerField(0x2b), LayoutImmutable, Blittable, JsonProperty(Order = 43)]
	public bool IsSquadLeader { get; set; } = false;
	
}

