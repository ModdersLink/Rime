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

[ContainerType(8, 24)]
public class TabletCommanderRankProgression
	: EbxSerializable
{
	[ContainerField(0x0), JsonProperty(Order = 0)]
	public List<TabletCommanderRankLevelData> RankLevelData { get; set; } = new();
	
	[ContainerField(0x8), LayoutImmutable, Blittable, JsonProperty(Order = 8)]
	public uint OriginalGlobalScore { get; set; } = 0;
	
	[ContainerField(0xc), LayoutImmutable, Blittable, JsonProperty(Order = 12)]
	public uint CurrentGlobalScore { get; set; } = 0;
	
	[ContainerField(0x10), LayoutImmutable, Blittable, JsonProperty(Order = 16)]
	public float ScoreMultiplier { get; set; } = 0.000f;
	
}

