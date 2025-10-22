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

namespace fb.CrossGameLauncherShared;

[ContainerType(8, 56)]
public class StartGameArgs
	: EbxSerializable
{
	[ContainerField(0x0), LayoutImmutable, Blittable, JsonProperty(Order = 0)]
	public string GameArguments { get; set; } = string.Empty;
	
	[ContainerField(0x8), JsonProperty(Order = 8)]
	public CrossLaunchIds Ids { get; set; } = new();
	
}

