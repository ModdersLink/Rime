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
	[ContainerType(1, 12)]
	public class DivisibleLoopPlayerPlugins
	{
		[ContainerField(0), JsonProperty(Order = 0)]
		public SoundGraphPluginRef SndPlayer { get; set; } = new();
		
		[ContainerField(3), JsonProperty(Order = 3)]
		public SoundGraphPluginRef Pause { get; set; } = new();
		
		[ContainerField(6), JsonProperty(Order = 6)]
		public SoundGraphPluginRef Gain { get; set; } = new();
		
		[ContainerField(9), JsonProperty(Order = 9)]
		public SoundGraphPluginRef GainFader { get; set; } = new();
		
	}
}
