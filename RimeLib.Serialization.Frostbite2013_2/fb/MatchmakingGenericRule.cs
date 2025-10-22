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

namespace fb.Online;

[ContainerType(8, 40)]
public class MatchmakingGenericRule
	: EbxSerializable
{
	[ContainerField(0x0), LayoutImmutable, Blittable, JsonProperty(Order = 0)]
	public string Rule { get; set; } = string.Empty;
	
	[ContainerField(0x8), LayoutImmutable, Blittable, JsonProperty(Order = 8)]
	public string MinFitThresHold { get; set; } = string.Empty;
	
	[ContainerField(0x10), LayoutImmutable, Blittable, JsonProperty(Order = 16)]
	public string Setting { get; set; } = string.Empty;
	
	[ContainerField(0x18), JsonProperty(Order = 24)]
	public List<MatchmakingRuleString> DesiredValues { get; set; } = new();
	
	[ContainerField(0x20), LayoutImmutable, Blittable, JsonProperty(Order = 32)]
	public bool IgnoreIfDefault { get; set; } = false;
	
	[ContainerField(0x21), LayoutImmutable, Blittable, JsonProperty(Order = 33)]
	public bool MergeValues { get; set; } = false;
	
	[ContainerField(0x22), LayoutImmutable, Blittable, JsonProperty(Order = 34)]
	public bool SortValues { get; set; } = false;
	
}

