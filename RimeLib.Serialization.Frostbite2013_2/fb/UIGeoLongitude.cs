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

[ContainerType(4, 12)]
public class UIGeoLongitude
	: EbxSerializable
{
	[ContainerField(0x0), LayoutImmutable, Blittable, JsonProperty(Order = 0)]
	public int Degrees { get; set; } = 0;
	
	[ContainerField(0x4), LayoutImmutable, Blittable, JsonProperty(Order = 4)]
	public int Minuites { get; set; } = 0;
	
	[ContainerField(0x8), LayoutImmutable, Blittable, JsonProperty(Order = 8)]
	public int Seconds { get; set; } = 0;
	
}

