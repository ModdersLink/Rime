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


namespace fb.Online;

[ContainerType(8, 8)]
public class OnlineEnvironmentConsoleUrl
	: EbxSerializable
{
	[ContainerField(0x0), JsonProperty(Order = 0)]
	public List<OnlineEnvironmentConsoleUrlData> Urls { get; set; } = new();
	
}

