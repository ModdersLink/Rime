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

namespace fb.GameCommon;

[ContainerType(8, 72)]
public class LoadLevelInfo
	: EbxSerializable
{
	[ContainerField(0x0), JsonProperty(Order = 0)]
	public LevelSetup Setup { get; set; } = new();
	
	[ContainerField(0x38), JsonProperty(Order = 56)]
	public List<BlueprintBundlePreloadInfo> BlueprintBundlePreloads { get; set; } = new();
	
	[ContainerField(0x40), LayoutImmutable, Blittable, JsonProperty(Order = 64)]
	public uint LevelSequenceNumber { get; set; } = 0;
	
}

