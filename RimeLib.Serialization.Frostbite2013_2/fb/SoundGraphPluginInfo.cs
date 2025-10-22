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

namespace fb.Audio;

[ContainerType(4, 12)]
public class SoundGraphPluginInfo
	: EbxSerializable
{
	[ContainerField(0x0), LayoutImmutable, Blittable, JsonProperty(Order = 0)]
	public uint Id { get; set; } = 0;
	
	[ContainerField(0x4), LayoutImmutable, Blittable, JsonProperty(Order = 4)]
	public uint EnableAttributeReadMask { get; set; } = 0;
	
	[ContainerField(0x8), LayoutImmutable, Blittable, JsonProperty(Order = 8)]
	public byte ConnectionIndex { get; set; } = 0;
	
	[ContainerField(0x9), LayoutImmutable, Blittable, JsonProperty(Order = 9)]
	public byte OutputChannelCount { get; set; } = 0;
	
	[ContainerField(0xa), LayoutImmutable, Blittable, JsonProperty(Order = 10)]
	public byte ConstructParamsIndex { get; set; } = 0;
	
	[ContainerField(0xb), LayoutImmutable, Blittable, JsonProperty(Order = 11)]
	public byte ConstructParamCount { get; set; } = 0;
	
}

