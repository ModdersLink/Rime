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

[ContainerType(8, 16)]
public class SoundWaveLocalizationInfo
	: EbxSerializable
{
	[ContainerField(0x0), JsonProperty(Order = 0)]
	public CtrRef<AudioLanguage> Language { get; set; } = new();
	
	[ContainerField(0x8), LayoutImmutable, Blittable, JsonProperty(Order = 8)]
	public ushort FirstVariationIndex { get; set; } = 0;
	
	[ContainerField(0xa), LayoutImmutable, Blittable, JsonProperty(Order = 10)]
	public ushort VariationCount { get; set; } = 0;
	
}

