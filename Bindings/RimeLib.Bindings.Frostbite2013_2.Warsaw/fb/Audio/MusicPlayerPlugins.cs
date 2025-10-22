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


namespace fb.Audio;

[ContainerType(1, 15)]
public class MusicPlayerPlugins
	: EbxSerializable
{
	[ContainerField(0x0), JsonProperty(Order = 0)]
	public SoundGraphPluginRef SndPlayer { get; set; } = new();
	
	[ContainerField(0x3), JsonProperty(Order = 3)]
	public SoundGraphPluginRef Rechannel { get; set; } = new();
	
	[ContainerField(0x6), JsonProperty(Order = 6)]
	public SoundGraphPluginRef Resample { get; set; } = new();
	
	[ContainerField(0x9), JsonProperty(Order = 9)]
	public SoundGraphPluginRef Pause { get; set; } = new();
	
	[ContainerField(0xc), JsonProperty(Order = 12)]
	public SoundGraphPluginRef Gain { get; set; } = new();
	
}

