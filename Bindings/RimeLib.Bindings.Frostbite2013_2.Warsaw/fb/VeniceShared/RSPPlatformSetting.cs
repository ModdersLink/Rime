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

[ContainerType(8, 16)]
public class RSPPlatformSetting
	: EbxSerializable
{
	[ContainerField(0x0), JsonProperty(Order = 0)]
	public List<GamePlatform> Platforms { get; set; } = new();
	
	[ContainerField(0x8), JsonProperty(Order = 8)]
	public List<LockedSettingConfig> LockedSettings { get; set; } = new();
	
}

