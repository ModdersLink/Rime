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

namespace fb.WorldRender;

[ContainerType(8, 24)]
public class GroundHeightData
	: EbxSerializable
{
	[ContainerField(0x0), LayoutImmutable, Blittable, JsonProperty(Order = 0)]
	public float WorldSize { get; set; } = 1024.000f;
	
	[ContainerField(0x4), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 4)]
	public Vec2 HeightSpan { get; set; } = new()
	{
		y = 0.000f,
		x = 0.000f,
	};
	
	[ContainerField(0x10), JsonProperty(Order = 16)]
	public List<ushort> Data { get; set; } = new();
	
}

