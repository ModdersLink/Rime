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

[ContainerType(8, 48)]
public class EvasiveBucketTimeSettings
	: EbxSerializable
{
	[ContainerField(0x0), JsonProperty(Order = 0)]
	public List<float> SprintDamageBucketTimes { get; set; } = new();
	
	[ContainerField(0x8), JsonProperty(Order = 8)]
	public List<float> CrouchDamageBucketTimes { get; set; } = new();
	
	[ContainerField(0x10), JsonProperty(Order = 16)]
	public List<float> ProneDamageBucketTimes { get; set; } = new();
	
	[ContainerField(0x18), JsonProperty(Order = 24)]
	public List<float> MovingVehicleDamageBucketTimes { get; set; } = new();
	
	[ContainerField(0x20), JsonProperty(Order = 32)]
	public List<float> VehicleStillDamageBucketTimes { get; set; } = new();
	
	[ContainerField(0x28), LayoutImmutable, Blittable, JsonProperty(Order = 40)]
	public float SprintSpeed { get; set; } = 5.000f;
	
	[ContainerField(0x2c), LayoutImmutable, Blittable, JsonProperty(Order = 44)]
	public float MovingVehicleSpeed { get; set; } = 5.000f;
	
}

