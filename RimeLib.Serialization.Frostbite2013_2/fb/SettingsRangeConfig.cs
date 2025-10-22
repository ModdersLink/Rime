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

[ContainerType(8, 24)]
public class SettingsRangeConfig
	: EbxSerializable
{
	[ContainerField(0x0), LayoutImmutable, Blittable, JsonProperty(Order = 0)]
	public string Key { get; set; } = string.Empty;
	
	[ContainerField(0x8), JsonProperty(Order = 8)]
	public List<SettingRange> Ranges { get; set; } = new();
	
	[ContainerField(0x10), JsonProperty(Order = 16)]
	public List<RSPPlatformSettingRange> PlatformRanges { get; set; } = new();
	
}

