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

[ContainerType(8, 24)]
public class UIElementInclusionSettings
	: EbxSerializable
{
	[ContainerField(0x0), JsonProperty(Order = 0)]
	public List<string> CustomInclusionCritera { get; set; } = new();
	
	[ContainerField(0x8), LayoutImmutable, Blittable, JsonProperty(Order = 8)]
	public bool IsSingleplayerLayer { get; set; } = true;
	
	[ContainerField(0x9), LayoutImmutable, Blittable, JsonProperty(Order = 9)]
	public bool IsMultiplayerLayer { get; set; } = true;
	
	[ContainerField(0xa), LayoutImmutable, Blittable, JsonProperty(Order = 10)]
	public bool IsWin32Layer { get; set; } = true;
	
	[ContainerField(0xb), LayoutImmutable, Blittable, JsonProperty(Order = 11)]
	public bool IsXenonLayer { get; set; } = true;
	
	[ContainerField(0xc), LayoutImmutable, Blittable, JsonProperty(Order = 12)]
	public bool IsPs3Layer { get; set; } = true;
	
	[ContainerField(0xd), LayoutImmutable, Blittable, JsonProperty(Order = 13)]
	public bool IsGen4aLayer { get; set; } = true;
	
	[ContainerField(0xe), LayoutImmutable, Blittable, JsonProperty(Order = 14)]
	public bool IsGen4bLayer { get; set; } = true;
	
	[ContainerField(0xf), LayoutImmutable, Blittable, JsonProperty(Order = 15)]
	public bool IsSDLayer { get; set; } = true;
	
	[ContainerField(0x10), LayoutImmutable, Blittable, JsonProperty(Order = 16)]
	public bool IsHDLayer { get; set; } = true;
	
	[ContainerField(0x11), LayoutImmutable, Blittable, JsonProperty(Order = 17)]
	public bool IsAdvanced { get; set; } = false;
	
}

