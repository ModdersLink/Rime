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

namespace fb.Physics;

[ContainerType(4, 80)]
public class VehicleInputData
	: EbxSerializable
{
	[ContainerField(0x0), LayoutImmutable, Blittable, JsonProperty(Order = 0)]
	public float ThrottleDeadzone { get; set; } = 0.000f;
	
	[ContainerField(0x4), LayoutImmutable, Blittable, JsonProperty(Order = 4)]
	public float BrakeDeadzone { get; set; } = 0.000f;
	
	[ContainerField(0x8), LayoutImmutable, Blittable, JsonProperty(Order = 8)]
	public float YawDeadzone { get; set; } = 0.000f;
	
	[ContainerField(0xc), LayoutImmutable, Blittable, JsonProperty(Order = 12)]
	public float PitchDeadzone { get; set; } = 0.000f;
	
	[ContainerField(0x10), LayoutImmutable, Blittable, JsonProperty(Order = 16)]
	public float RollDeadzone { get; set; } = 0.000f;
	
	[ContainerField(0x14), LayoutImmutable, Blittable, JsonProperty(Order = 20)]
	public float ThrottleInertiaOutDuration { get; set; } = 0.000f;
	
	[ContainerField(0x18), LayoutImmutable, Blittable, JsonProperty(Order = 24)]
	public float ThrottleInertiaInDuration { get; set; } = 0.000f;
	
	[ContainerField(0x1c), LayoutImmutable, Blittable, JsonProperty(Order = 28)]
	public float ThrottleInertiaMinRatio { get; set; } = 0.200f;
	
	[ContainerField(0x20), LayoutImmutable, Blittable, JsonProperty(Order = 32)]
	public float BrakeInertiaOutDuration { get; set; } = 0.000f;
	
	[ContainerField(0x24), LayoutImmutable, Blittable, JsonProperty(Order = 36)]
	public float BrakeInertiaInDuration { get; set; } = 0.000f;
	
	[ContainerField(0x28), LayoutImmutable, Blittable, JsonProperty(Order = 40)]
	public float BrakeInertiaMinRatio { get; set; } = 0.200f;
	
	[ContainerField(0x2c), LayoutImmutable, Blittable, JsonProperty(Order = 44)]
	public float YawInertiaOutDuration { get; set; } = 0.000f;
	
	[ContainerField(0x30), LayoutImmutable, Blittable, JsonProperty(Order = 48)]
	public float YawInertiaInDuration { get; set; } = 0.000f;
	
	[ContainerField(0x34), LayoutImmutable, Blittable, JsonProperty(Order = 52)]
	public float YawInertiaMinRatio { get; set; } = 0.200f;
	
	[ContainerField(0x38), LayoutImmutable, Blittable, JsonProperty(Order = 56)]
	public float PitchInertiaOutDuration { get; set; } = 0.000f;
	
	[ContainerField(0x3c), LayoutImmutable, Blittable, JsonProperty(Order = 60)]
	public float PitchInertiaInDuration { get; set; } = 0.000f;
	
	[ContainerField(0x40), LayoutImmutable, Blittable, JsonProperty(Order = 64)]
	public float PitchInertiaMinRatio { get; set; } = 0.200f;
	
	[ContainerField(0x44), LayoutImmutable, Blittable, JsonProperty(Order = 68)]
	public float RollInertiaOutDuration { get; set; } = 0.000f;
	
	[ContainerField(0x48), LayoutImmutable, Blittable, JsonProperty(Order = 72)]
	public float RollInertiaInDuration { get; set; } = 0.000f;
	
	[ContainerField(0x4c), LayoutImmutable, Blittable, JsonProperty(Order = 76)]
	public float RollInertiaMinRatio { get; set; } = 0.200f;
	
}

