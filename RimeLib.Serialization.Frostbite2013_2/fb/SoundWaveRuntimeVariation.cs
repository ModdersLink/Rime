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
public class SoundWaveRuntimeVariation
	: EbxSerializable
{
	[ContainerField(0x0), LayoutImmutable, Blittable, JsonProperty(Order = 0)]
	public uint PersistentDataSize { get; set; } = 0;
	
	[ContainerField(0x4), LayoutImmutable, Blittable, JsonProperty(Order = 4)]
	public ushort FirstSegmentIndex { get; set; } = 0;
	
	[ContainerField(0x6), LayoutImmutable, Blittable, JsonProperty(Order = 6)]
	public byte FirstSubtitleIndex { get; set; } = 0;
	
	[ContainerField(0x7), LayoutImmutable, Blittable, JsonProperty(Order = 7)]
	public byte SubtitleCount { get; set; } = 0;
	
	[ContainerField(0x8), LayoutImmutable, Blittable, JsonProperty(Order = 8)]
	public byte SegmentCount { get; set; } = 0;
	
	[ContainerField(0x9), LayoutImmutable, Blittable, JsonProperty(Order = 9)]
	public byte ChunkIndex { get; set; } = 0;
	
	[ContainerField(0xa), LayoutImmutable, Blittable, JsonProperty(Order = 10)]
	public byte FirstLoopSegmentIndex { get; set; } = 0;
	
	[ContainerField(0xb), LayoutImmutable, Blittable, JsonProperty(Order = 11)]
	public byte LastLoopSegmentIndex { get; set; } = 0;
	
}

