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
using fb.Render;

namespace fb.GameShared;

[ContainerType(8, 40)]
public class UITextureMappingOutputEntry
	: EbxSerializable
{
	[ContainerField(0x0), LayoutImmutable, Blittable, JsonProperty(Order = 0)]
	public string Id { get; set; } = string.Empty;
	
	[ContainerField(0x8), JsonProperty(Order = 8)]
	public CtrRef<TextureAsset> Texture { get; set; } = new();
	
	[ContainerField(0x10), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 16)]
	public Vec2 Min { get; set; } = new()
	{
		y = 0.000f,
		x = 0.000f,
	};
	
	[ContainerField(0x18), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 24)]
	public Vec2 Max { get; set; } = new()
	{
		y = 0.000f,
		x = 0.000f,
	};
	
	[ContainerField(0x20), LayoutImmutable, Blittable, JsonProperty(Order = 32)]
	public bool Streaming { get; set; } = false;
	
}

