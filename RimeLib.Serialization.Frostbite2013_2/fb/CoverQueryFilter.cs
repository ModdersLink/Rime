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

[ContainerType(1, 12)]
public class CoverQueryFilter
	: EbxSerializable
{
	[ContainerField(0x0), LayoutImmutable, Blittable, JsonProperty(Order = 0)]
	public bool LeftBlocked { get; set; } = false;
	
	[ContainerField(0x1), LayoutImmutable, Blittable, JsonProperty(Order = 1)]
	public bool LeftNotBlocked { get; set; } = false;
	
	[ContainerField(0x2), LayoutImmutable, Blittable, JsonProperty(Order = 2)]
	public bool RightBlocked { get; set; } = false;
	
	[ContainerField(0x3), LayoutImmutable, Blittable, JsonProperty(Order = 3)]
	public bool RightNotBlocked { get; set; } = false;
	
	[ContainerField(0x4), LayoutImmutable, Blittable, JsonProperty(Order = 4)]
	public bool TopBlocked { get; set; } = false;
	
	[ContainerField(0x5), LayoutImmutable, Blittable, JsonProperty(Order = 5)]
	public bool TopNotBlocked { get; set; } = false;
	
	[ContainerField(0x6), LayoutImmutable, Blittable, JsonProperty(Order = 6)]
	public bool StandCovers { get; set; } = true;
	
	[ContainerField(0x7), LayoutImmutable, Blittable, JsonProperty(Order = 7)]
	public bool MediumCovers { get; set; } = true;
	
	[ContainerField(0x8), LayoutImmutable, Blittable, JsonProperty(Order = 8)]
	public bool CrouchCovers { get; set; } = true;
	
	[ContainerField(0x9), LayoutImmutable, Blittable, JsonProperty(Order = 9)]
	public bool ProneCovers { get; set; } = true;
	
	[ContainerField(0xa), LayoutImmutable, Blittable, JsonProperty(Order = 10)]
	public bool OpenCovers { get; set; } = true;
	
	[ContainerField(0xb), LayoutImmutable, Blittable, JsonProperty(Order = 11)]
	public bool OpenDirectionalCovers { get; set; } = true;
	
}

