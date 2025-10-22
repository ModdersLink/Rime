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

namespace fb.GameShared;

[ContainerType(4, 68)]
public class WeaponDispersion
	: EbxSerializable
{
	[ContainerField(0x0), JsonProperty(Order = 0)]
	public FiringDispersionData StandDispersion { get; set; } = new();
	
	[ContainerField(0x10), JsonProperty(Order = 16)]
	public FiringDispersionData CrouchDispersion { get; set; } = new();
	
	[ContainerField(0x20), JsonProperty(Order = 32)]
	public FiringDispersionData ProneDispersion { get; set; } = new();
	
	[ContainerField(0x30), LayoutImmutable, Blittable, JsonProperty(Order = 48)]
	public float JumpDispersionAngle { get; set; } = 0.000f;
	
	[ContainerField(0x34), LayoutImmutable, Blittable, JsonProperty(Order = 52)]
	public float ProneTransitionDispersionAngle { get; set; } = 0.000f;
	
	[ContainerField(0x38), LayoutImmutable, Blittable, JsonProperty(Order = 56)]
	public float MoveDispersionAngle { get; set; } = 0.000f;
	
	[ContainerField(0x3c), LayoutImmutable, Blittable, JsonProperty(Order = 60)]
	public float MoveZoomedDispersionAngle { get; set; } = 0.000f;
	
	[ContainerField(0x40), LayoutImmutable, Blittable, JsonProperty(Order = 64)]
	public float DecreasePerSecond { get; set; } = 5.000f;
	
}

