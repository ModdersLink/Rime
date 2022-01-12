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
	[ContainerType(4, 44)]
	public class HighPassButterworthNodeData : 
		AudioGraphNodeData
	{
		[ContainerField(8)]
		public AudioGraphNodePort In { get; set; } = new();

		[ContainerField(16)]
		public AudioGraphNodePort Frequency { get; set; } = new();

		[ContainerField(24)]
		public AudioGraphNodePort Order { get; set; } = new();

		[ContainerField(32)]
		public AudioGraphNodePort Out { get; set; } = new();

		[ContainerField(40)]
		public SoundGraphPluginRef Plugin { get; set; } = new();

	}
}
