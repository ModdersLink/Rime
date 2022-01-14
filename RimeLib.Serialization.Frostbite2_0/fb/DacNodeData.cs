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
using RimeLib.Serialization.Ebx;

namespace fb
{
	[ContainerType(4, 44)]
	public class DacNodeData : 
		AudioGraphNodeData
	{
		[ContainerField(8), JsonProperty(Order = 8)]
		public AudioGraphNodePort In { get; set; } = new();

		[ContainerField(16), JsonProperty(Order = 16)]
		public AudioGraphNodePort SpeakerCount { get; set; } = new();

		[ContainerField(24), JsonProperty(Order = 24)]
		public AudioGraphNodePort SampleRate { get; set; } = new();

		[ContainerField(32), JsonProperty(Order = 32)]
		public SoundGraphPluginRef VuPlugin { get; set; } = new();

		[ContainerField(35), JsonProperty(Order = 35)]
		public SoundGraphPluginRef GainPlugin { get; set; } = new();

		[ContainerField(38), JsonProperty(Order = 38)]
		public SoundGraphPluginRef DacPlugin { get; set; } = new();

	}
}
