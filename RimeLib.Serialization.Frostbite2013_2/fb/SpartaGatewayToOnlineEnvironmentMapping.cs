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


namespace fb.SpartaShared;

[ContainerType(8, 32)]
public class SpartaGatewayToOnlineEnvironmentMapping
	: EbxSerializable
{
	[ContainerField(0x0), LayoutImmutable, Blittable, JsonProperty(Order = 0)]
	public SpartaOnlineEnvironment SpartaOnlineEnvironment { get; set; } = fb.SpartaShared.SpartaOnlineEnvironment.SpartaOnlineEnvironment_Development;
	
	[ContainerField(0x8), JsonProperty(Order = 8)]
	public SpartaGatewayHostSettings SpartaGatewayHostSettings { get; set; } = new();
	
}

