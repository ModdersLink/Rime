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


namespace fb.VeniceShared;

[ContainerType(4, 32)]
public class UIWorldIconFadeConfiguration
	: EbxSerializable
{
	[ContainerField(0x0), JsonProperty(Order = 0)]
	public UIWorldIconZoneFloats ZoneFadeValues { get; set; } = new();
	
	[ContainerField(0x10), JsonProperty(Order = 16)]
	public UIWorldIconZoneFloats ZoneLookAtFadeValues { get; set; } = new();
	
}

