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

[ContainerType(4, 20)]
public class SmokeJammingData
	: EbxSerializable
{
	[ContainerField(0x0), LayoutImmutable, Blittable, JsonProperty(Order = 0)]
	public float MaxRadius { get; set; } = 15.000f;
	
	[ContainerField(0x4), LayoutImmutable, Blittable, JsonProperty(Order = 4)]
	public float MinRadius { get; set; } = 4.000f;
	
	[ContainerField(0x8), LayoutImmutable, Blittable, JsonProperty(Order = 8)]
	public float JammingTime { get; set; } = 5.000f;
	
	[ContainerField(0xc), LayoutImmutable, Blittable, JsonProperty(Order = 12)]
	public float TargetUpdateTime { get; set; } = 0.500f;
	
	[ContainerField(0x10), LayoutImmutable, Blittable, JsonProperty(Order = 16)]
	public bool EnableSmokeJamming { get; set; } = true;
	
	[ContainerField(0x11), LayoutImmutable, Blittable, JsonProperty(Order = 17)]
	public bool JammingPositionIsLocationDependent { get; set; } = false;
	
	[ContainerField(0x12), LayoutImmutable, Blittable, JsonProperty(Order = 18)]
	public bool ReportJammedBasedOnStartPosition { get; set; } = true;
	
}

