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

namespace fb.BFAI2Data;

[ContainerType(8, 16)]
public class SquadTargettingData
	: EbxSerializable
{
	[ContainerField(0x0), LayoutImmutable, Blittable, JsonProperty(Order = 0)]
	public float VisibleTargetLimit { get; set; } = 1.000f;
	
	[ContainerField(0x4), LayoutImmutable, Blittable, JsonProperty(Order = 4)]
	public float TargetLostTimer { get; set; } = 10.000f;
	
	[ContainerField(0x8), JsonProperty(Order = 8)]
	public List<float> TargetImportanceThresholds { get; set; } = new();
	
}

