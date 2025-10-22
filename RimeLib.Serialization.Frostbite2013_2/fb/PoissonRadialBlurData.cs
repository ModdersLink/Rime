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

namespace fb.Render;

[ContainerType(4, 20)]
public class PoissonRadialBlurData
	: EbxSerializable
{
	[ContainerField(0x0), LayoutImmutable, Blittable, JsonProperty(Order = 0)]
	public float BlendFactor { get; set; } = 1.000f;
	
	[ContainerField(0x4), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 4)]
	public Vec2 PoissonDiscScale { get; set; } = new()
	{
		y = 0.010f,
		x = 0.040f,
	};
	
	[ContainerField(0xc), LayoutImmutable, Blittable, JsonProperty(Order = 12)]
	public float RadialScale { get; set; } = 1.000f;
	
	[ContainerField(0x10), LayoutImmutable, Blittable, JsonProperty(Order = 16)]
	public float RadialExponent { get; set; } = 2.000f;
	
}

