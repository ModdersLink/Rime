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

[ContainerType(8, 32)]
public class SoundGraphPluginConnection
	: EbxSerializable
{
	[ContainerField(0x0), LayoutImmutable, Blittable, JsonProperty(Order = 0)]
	public SoundGraphPluginConnectionType ConnectionType { get; set; } = SoundGraphPluginConnectionType.SoundGraphPluginConnectionType_Unconnected;
	
	[ContainerField(0x8), JsonProperty(Order = 8)]
	public CtrRef<SoundBusData> Bus { get; set; } = new();
	
	[ContainerField(0x10), JsonProperty(Order = 16)]
	public List<SoundGraphPluginConnectionParam> Parameters { get; set; } = new();
	
	[ContainerField(0x18), LayoutImmutable, Blittable, JsonProperty(Order = 24)]
	public byte VoiceIndex { get; set; } = 0;
	
	[ContainerField(0x19), LayoutImmutable, Blittable, JsonProperty(Order = 25)]
	public byte PluginIndex { get; set; } = 0;
	
	[ContainerField(0x1a), LayoutImmutable, Blittable, JsonProperty(Order = 26)]
	public byte SignalIndex { get; set; } = 0;
	
}

