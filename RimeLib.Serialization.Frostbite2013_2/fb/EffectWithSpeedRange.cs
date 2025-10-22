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

namespace fb.GameShared;

[ContainerType(8, 16)]
public class EffectWithSpeedRange
	: EbxSerializable
{
	[ContainerField(0x0), JsonProperty(Order = 0)]
	public CtrRef<EffectBlueprint> Effect { get; set; } = new();
	
	[ContainerField(0x8), LayoutImmutable, Blittable, JsonProperty(Order = 8)]
	public float MinSpeed { get; set; } = 0.000f;
	
	[ContainerField(0xc), LayoutImmutable, Blittable, JsonProperty(Order = 12)]
	public float MaxSpeed { get; set; } = 10000.000f;
	
}

