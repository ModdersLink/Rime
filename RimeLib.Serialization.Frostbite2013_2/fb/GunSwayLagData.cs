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

namespace fb.SoldierShared;

[ContainerType(4, 20)]
public class GunSwayLagData
	: EbxSerializable
{
	[ContainerField(0x0), LayoutImmutable, Blittable, JsonProperty(Order = 0)]
	public float MoveStrafeModifier { get; set; } = 0.000f;
	
	[ContainerField(0x4), LayoutImmutable, Blittable, JsonProperty(Order = 4)]
	public float MoveForwardModifier { get; set; } = 0.000f;
	
	[ContainerField(0x8), LayoutImmutable, Blittable, JsonProperty(Order = 8)]
	public float RotateYawModifier { get; set; } = 0.000f;
	
	[ContainerField(0xc), LayoutImmutable, Blittable, JsonProperty(Order = 12)]
	public float RotatePitchModifier { get; set; } = 0.000f;
	
	[ContainerField(0x10), LayoutImmutable, Blittable, JsonProperty(Order = 16)]
	public float ReleaseModifier { get; set; } = 0.000f;
	
}

