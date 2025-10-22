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

using fb.GameShared;
using fb.Core;

namespace fb.TireTrails;

[ContainerType(8, 40)]
public class TireTrailConfiguration
	: EbxSerializable
{
	[ContainerField(0x0), LayoutImmutable, Blittable, JsonProperty(Order = 0)]
	public float SectionWidth { get; set; } = 500.000f;
	
	[ContainerField(0x4), LayoutImmutable, Blittable, JsonProperty(Order = 4)]
	public float TrailOffset { get; set; } = 0.000f;
	
	[ContainerField(0x8), JsonProperty(Order = 8)]
	public CtrRef<TireTrailVehicleSkidMarkConfigData> SkidMarkData { get; set; } = new();
	
	[ContainerField(0x10), JsonProperty(Order = 16)]
	public CtrRef<WheelComponentData> LeftWheelComponent { get; set; } = new();
	
	[ContainerField(0x18), JsonProperty(Order = 24)]
	public CtrRef<WheelComponentData> RightWheelComponent { get; set; } = new();
	
	[ContainerField(0x20), LayoutImmutable, Blittable, JsonProperty(Order = 32)]
	public bool MirrorUVs { get; set; } = false;
	
	[ContainerField(0x21), LayoutImmutable, Blittable, JsonProperty(Order = 33)]
	public bool FadeBasedOnSlip { get; set; } = false;
	
}

