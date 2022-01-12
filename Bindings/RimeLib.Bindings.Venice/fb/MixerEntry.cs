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
	[ContainerType(4, 28)]
	public class MixerEntry : 
		AudioGraphNodePortGroup
	{
		[ContainerField(8)]
		public AudioGraphNodePort In { get; set; } = new();

		[ContainerField(16)]
		public AudioGraphNodePort Amplitude { get; set; } = new();

		[ContainerField(24)]
		public SoundGraphPluginRef Plugin { get; set; } = new();

	}
}
