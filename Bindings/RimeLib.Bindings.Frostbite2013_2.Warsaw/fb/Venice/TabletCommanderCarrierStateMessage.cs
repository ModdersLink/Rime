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

namespace fb.Venice;

[ContainerType(1, 4)]
public class TabletCommanderCarrierStateMessage
	: EbxSerializable
{
	[ContainerField(0x0), LayoutImmutable, Blittable, JsonProperty(Order = 0)]
	public byte Team1CarrierHealth { get; set; } = 0;
	
	[ContainerField(0x1), LayoutImmutable, Blittable, JsonProperty(Order = 1)]
	public byte Team2CarrierHealth { get; set; } = 0;
	
	[ContainerField(0x2), LayoutImmutable, Blittable, JsonProperty(Order = 2)]
	public byte Team1CarrierState { get; set; } = 0;
	
	[ContainerField(0x3), LayoutImmutable, Blittable, JsonProperty(Order = 3)]
	public byte Team2CarrierState { get; set; } = 0;
	
}

