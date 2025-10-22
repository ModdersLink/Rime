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

[ContainerType(4, 16)]
public class StabilizerSettings
	: EbxSerializable
{
	[ContainerField(0x0), LayoutImmutable, Blittable, JsonProperty(Order = 0)]
	public StabilizerProperty Property { get; set; } = StabilizerProperty.SPPitchAngle;
	
	[ContainerField(0x4), LayoutImmutable, Blittable, JsonProperty(Order = 4)]
	public float Strength { get; set; } = 0.000f;
	
	[ContainerField(0x8), LayoutImmutable, Blittable, JsonProperty(Order = 8)]
	public float Radius { get; set; } = -1.000f;
	
	[ContainerField(0xc), LayoutImmutable, Blittable, JsonProperty(Order = 12)]
	public bool Advanced { get; set; } = false;
	
	[ContainerField(0xd), LayoutImmutable, Blittable, JsonProperty(Order = 13)]
	public bool Use2DRadiusTest { get; set; } = true;
	
	[ContainerField(0xe), LayoutImmutable, Blittable, JsonProperty(Order = 14)]
	public bool UseInputOverride { get; set; } = true;
	
}

