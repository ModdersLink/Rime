///////////////////////////////////////////////////////////////
//                                                           //
// This is an automatically generated file.                  //
// Do *NOT* modify unless you really know what you're doing. //
//                                                           //
///////////////////////////////////////////////////////////////

using System;
using System.IO;
using System.Collections.Generic;
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
		[ContainerField(0)]
		public SoundGraphPluginRef SndPlayer { get; set; } = new();
		
		[ContainerField(3)]
		public SoundGraphPluginRef Pause { get; set; } = new();
		
		[ContainerField(6)]
		public SoundGraphPluginRef Gain { get; set; } = new();
		
		[ContainerField(9)]
		public SoundGraphPluginRef GainFader { get; set; } = new();
		
	}
}
