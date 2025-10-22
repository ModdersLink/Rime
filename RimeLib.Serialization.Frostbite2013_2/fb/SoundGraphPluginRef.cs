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

[ContainerType(1, 3)]
public class SoundGraphPluginRef
	: EbxSerializable
{
	[ContainerField(0x0), LayoutImmutable, Blittable, JsonProperty(Order = 0)]
	public bool IsValid { get; set; } = false;
	
	[ContainerField(0x1), LayoutImmutable, Blittable, JsonProperty(Order = 1)]
	public byte VoiceIndex { get; set; } = 0;
	
	[ContainerField(0x2), LayoutImmutable, Blittable, JsonProperty(Order = 2)]
	public byte PluginIndex { get; set; } = 0;
	
}

