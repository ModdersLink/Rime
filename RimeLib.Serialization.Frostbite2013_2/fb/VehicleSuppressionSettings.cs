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

namespace fb.BFAI2Data;

[ContainerType(4, 8)]
public class VehicleSuppressionSettings
	: EbxSerializable
{
	[ContainerField(0x0), LayoutImmutable, Blittable, JsonProperty(Order = 0)]
	public float SuppressionDistance { get; set; } = 15.000f;
	
	[ContainerField(0x4), LayoutImmutable, Blittable, JsonProperty(Order = 4)]
	public float ReevaluateCoverDistance { get; set; } = 15.000f;
	
}

