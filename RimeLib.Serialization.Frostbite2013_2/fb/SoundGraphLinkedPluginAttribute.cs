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
public class SoundGraphLinkedPluginAttribute
	: EbxSerializable
{
	[ContainerField(0x0), LayoutImmutable, Blittable, JsonProperty(Order = 0)]
	public float UnconnectedValue { get; set; } = 0.000f;
	
	[ContainerField(0x4), LayoutImmutable, Blittable, JsonProperty(Order = 4)]
	public ushort ValueIndex { get; set; } = 0;
	
	[ContainerField(0x6), LayoutImmutable, Blittable, JsonProperty(Order = 6)]
	public ushort NodeIndexAndFlags { get; set; } = 0;
	
	[ContainerField(0x8), LayoutImmutable, Blittable, JsonProperty(Order = 8)]
	public byte VoiceIndex { get; set; } = 0;
	
	[ContainerField(0x9), LayoutImmutable, Blittable, JsonProperty(Order = 9)]
	public byte PluginIndex { get; set; } = 0;
	
	[ContainerField(0xa), LayoutImmutable, Blittable, JsonProperty(Order = 10)]
	public byte AttributeIndex { get; set; } = 0;
	
}

