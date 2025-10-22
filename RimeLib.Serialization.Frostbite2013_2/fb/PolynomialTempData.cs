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

namespace fb.Emitter;

[ContainerType(16, 32)]
public class PolynomialTempData
	: EbxSerializable
{
	[ContainerField(0x0), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 0)]
	public Vec4 Coefficients { get; set; } = new()
	{
		w = 1.000f,
		z = 0.000f,
		y = 0.000f,
		x = 0.000f,
	};
	
	[ContainerField(0x10), LayoutImmutable, Blittable, JsonProperty(Order = 16)]
	public float ScaleValue { get; set; } = 1.000f;
	
	[ContainerField(0x14), LayoutImmutable, Blittable, JsonProperty(Order = 20)]
	public float MinClamp { get; set; } = 0.000f;
	
	[ContainerField(0x18), LayoutImmutable, Blittable, JsonProperty(Order = 24)]
	public float MaxClamp { get; set; } = 1.000f;
	
}

