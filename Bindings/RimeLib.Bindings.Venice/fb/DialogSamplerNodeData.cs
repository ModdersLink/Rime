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
	[ContainerType(4, 72)]
	public class DialogSamplerNodeData : 
		AudioGraphNodeData
	{
		[ContainerField(8)]
		public AudioGraphNodePort Pitch { get; set; } = new();

		[ContainerField(16)]
		public AudioGraphNodePort Amplitude { get; set; } = new();

		[ContainerField(24)]
		public AudioGraphNodePort Continue { get; set; } = new();

		[ContainerField(32)]
		public AudioGraphNodePort Output { get; set; } = new();

		[ContainerField(40)]
		public AudioGraphNodePort Triggered { get; set; } = new();

		[ContainerField(48)]
		public AudioGraphNodePort Finished { get; set; } = new();

		[ContainerField(56)]
		public SoundGraphPluginRef SndPlayerPlugin { get; set; } = new();

		[ContainerField(59)]
		public SoundGraphPluginRef ResamplePlugin { get; set; } = new();

		[ContainerField(62)]
		public SoundGraphPluginRef PausePlugin { get; set; } = new();

		[ContainerField(65)]
		public SoundGraphPluginRef GainPlugin { get; set; } = new();

		[ContainerField(68), LayoutImmutable, Blittable]
		public float TailLength { get; set; }

	}
}
