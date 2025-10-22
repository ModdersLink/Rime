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

namespace fb.WaterInteract;

[ContainerType(16, 256)]
public class AmbientWaveSettings
	: EbxSerializable
{
	[ContainerField(0x0), JsonProperty(Order = 0)]
	public SplineCurve WindDistribution { get; set; } = new();
	
	[ContainerField(0xe0), LayoutImmutable, Blittable, JsonProperty(Order = 224)]
	public float WaveAmplitude { get; set; } = 0.100f;
	
	[ContainerField(0xe4), LayoutImmutable, Blittable, JsonProperty(Order = 228)]
	public float WindSpeed { get; set; } = 15.000f;
	
	[ContainerField(0xe8), LayoutImmutable, Blittable, JsonProperty(Order = 232)]
	public float WindAngle { get; set; } = 10.000f;
	
	[ContainerField(0xec), LayoutImmutable, Blittable, JsonProperty(Order = 236)]
	public float MinWavelength { get; set; } = 0.000f;
	
	[ContainerField(0xf0), LayoutImmutable, Blittable, JsonProperty(Order = 240)]
	public float LargeWaveReduction { get; set; } = 8.000f;
	
	[ContainerField(0xf4), LayoutImmutable, Blittable, JsonProperty(Order = 244)]
	public float FoamHalfLife { get; set; } = 0.500f;
	
	[ContainerField(0xf8), LayoutImmutable, Blittable, JsonProperty(Order = 248)]
	public float FoamThreshold { get; set; } = 0.500f;
	
	[ContainerField(0xfc), LayoutImmutable, Blittable, JsonProperty(Order = 252)]
	public float FoamMaxValue { get; set; } = 1.000f;
	
}

