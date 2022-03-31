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
	[ContainerType(4, 68)]
	public class SoundGraphData : 
		AudioGraphData
	{
		[ContainerField(28), JsonProperty(Order = 28)]
		public SoundGraphInfo Info { get; set; } = new();

		[ContainerField(52), JsonProperty(Order = 52)]
		public RefArray<AudioGraphParameter> InputParameters { get; set; } = new();

		[ContainerField(56), JsonProperty(Order = 56)]
		public RefArray<AudioGraphParameter> OutputParameters { get; set; } = new();

		[ContainerField(60), JsonProperty(Order = 60)]
		public RefArray<AudioGraphEvent> InputEvents { get; set; } = new();

		[ContainerField(64), JsonProperty(Order = 64)]
		public RefArray<AudioGraphEvent> OutputEvents { get; set; } = new();

	}
}
