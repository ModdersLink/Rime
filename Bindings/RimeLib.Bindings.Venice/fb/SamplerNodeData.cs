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
	[ContainerType(4, 148)]
	public class SamplerNodeData : 
		AudioGraphNodeData
	{
		[ContainerField(8)]
		public AudioGraphNodePort ExternalWave { get; set; } = new();

		[ContainerField(16)]
		public AudioGraphNodePort Variation { get; set; } = new();

		[ContainerField(24)]
		public AudioGraphNodePort Offset { get; set; } = new();

		[ContainerField(32)]
		public AudioGraphNodePort Delay { get; set; } = new();

		[ContainerField(40)]
		public AudioGraphNodePort Pitch { get; set; } = new();

		[ContainerField(48)]
		public AudioGraphNodePort Amplitude { get; set; } = new();

		[ContainerField(56)]
		public AudioGraphNodePort EnableStep { get; set; } = new();

		[ContainerField(64)]
		public AudioGraphNodePort Buffer { get; set; } = new();

		[ContainerField(72)]
		public AudioGraphNodePort Trigger { get; set; } = new();

		[ContainerField(80)]
		public AudioGraphNodePort Release { get; set; } = new();

		[ContainerField(88)]
		public AudioGraphNodePort Step { get; set; } = new();

		[ContainerField(96)]
		public AudioGraphNodePort Output { get; set; } = new();

		[ContainerField(104)]
		public AudioGraphNodePort Finished { get; set; } = new();

		[ContainerField(112)]
		public AudioGraphNodePort Buffered { get; set; } = new();

		[ContainerField(120)]
		public AudioGraphNodePort Position { get; set; } = new();

		[ContainerField(128)]
		public CtrRef<SoundWaveAsset> Wave { get; set; } = new();

		[ContainerField(132), LayoutImmutable, Blittable]
		public float BasePitch { get; set; }

		[ContainerField(136)]
		public LoopType Loop { get; set; } = new();

		[ContainerField(140)]
		public List<SamplerPlugins> Plugins { get; set; } = new();

		[ContainerField(144), LayoutImmutable, Blittable]
		public bool ShuffleSegments { get; set; }

	}
}
