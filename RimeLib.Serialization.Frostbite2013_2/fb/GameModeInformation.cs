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

namespace fb.VeniceShared;

[ContainerType(8, 72)]
public class GameModeInformation
	: EbxSerializable
{
	[ContainerField(0x0), LayoutImmutable, Blittable, JsonProperty(Order = 0)]
	public GamePlatform Platform { get; set; } = GamePlatform.GamePlatform_Ps3;
	
	[ContainerField(0x8), JsonProperty(Order = 8)]
	public List<GameModeSize> Sizes { get; set; } = new();
	
	[ContainerField(0x10), JsonProperty(Order = 16)]
	public GameModeSize DefaultSize { get; set; } = new();
	
	[ContainerField(0x40), LayoutImmutable, Blittable, JsonProperty(Order = 64)]
	public bool AllowFallbackToDefault { get; set; } = false;
	
}

