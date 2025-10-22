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

using fb.GameShared;

namespace fb.Venice;

[ContainerType(4, 16)]
public class TabletCommanderNetworkBombState
	: EbxSerializable
{
	[ContainerField(0x0), JsonProperty(Order = 0)]
	public TabletCommanderNetworkState NetworkState { get; set; } = new();
	
	[ContainerField(0xc), LayoutImmutable, Blittable, JsonProperty(Order = 12)]
	public TeamId TeamId { get; set; } = fb.GameShared.TeamId.TeamNeutral;
	
}

