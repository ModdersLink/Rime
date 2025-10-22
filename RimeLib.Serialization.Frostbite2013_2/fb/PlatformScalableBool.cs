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


namespace fb.Core;

[ContainerType(1, 5)]
public class PlatformScalableBool
	: EbxSerializable
{
	[ContainerField(0x0), LayoutImmutable, Blittable, JsonProperty(Order = 0)]
	public bool Default { get; set; } = false;
	
	[ContainerField(0x1), LayoutImmutable, Blittable, JsonProperty(Order = 1)]
	public bool Xenon { get; set; } = false;
	
	[ContainerField(0x2), LayoutImmutable, Blittable, JsonProperty(Order = 2)]
	public bool Ps3 { get; set; } = false;
	
	[ContainerField(0x3), LayoutImmutable, Blittable, JsonProperty(Order = 3)]
	public bool Gen4a { get; set; } = false;
	
	[ContainerField(0x4), LayoutImmutable, Blittable, JsonProperty(Order = 4)]
	public bool Gen4b { get; set; } = false;
	
}

