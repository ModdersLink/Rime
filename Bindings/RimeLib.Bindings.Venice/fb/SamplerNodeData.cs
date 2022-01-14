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
	[ContainerType(4, 148)]
	public class SamplerNodeData : 
		AudioGraphNodeData
	{
		[ContainerField(8), JsonProperty(Order = 8)]
		public AudioGraphNodePort ExternalWave { get; set; } = new();

		[ContainerField(16), JsonProperty(Order = 16)]
		public AudioGraphNodePort Variation { get; set; } = new();

		[ContainerField(24), JsonProperty(Order = 24)]
		public AudioGraphNodePort Offset { get; set; } = new();

		[ContainerField(32), JsonProperty(Order = 32)]
		public AudioGraphNodePort Delay { get; set; } = new();

		[ContainerField(40), JsonProperty(Order = 40)]
		public AudioGraphNodePort Pitch { get; set; } = new();

		[ContainerField(48), JsonProperty(Order = 48)]
		public AudioGraphNodePort Amplitude { get; set; } = new();

		[ContainerField(56), JsonProperty(Order = 56)]
		public AudioGraphNodePort EnableStep { get; set; } = new();

		[ContainerField(64), JsonProperty(Order = 64)]
		public AudioGraphNodePort Buffer { get; set; } = new();

		[ContainerField(72), JsonProperty(Order = 72)]
		public AudioGraphNodePort Trigger { get; set; } = new();

		[ContainerField(80), JsonProperty(Order = 80)]
		public AudioGraphNodePort Release { get; set; } = new();

		[ContainerField(88), JsonProperty(Order = 88)]
		public AudioGraphNodePort Step { get; set; } = new();

		[ContainerField(96), JsonProperty(Order = 96)]
		public AudioGraphNodePort Output { get; set; } = new();

		[ContainerField(104), JsonProperty(Order = 104)]
		public AudioGraphNodePort Finished { get; set; } = new();

		[ContainerField(112), JsonProperty(Order = 112)]
		public AudioGraphNodePort Buffered { get; set; } = new();

		[ContainerField(120), JsonProperty(Order = 120)]
		public AudioGraphNodePort Position { get; set; } = new();

		[ContainerField(128), JsonProperty(Order = 128)]
		public CtrRef<SoundWaveAsset> Wave { get; set; } = new();

		[ContainerField(132), LayoutImmutable, Blittable, JsonProperty(Order = 132)]
		public float BasePitch { get; set; }

		[ContainerField(136), JsonProperty(Order = 136)]
		public LoopType Loop { get; set; } = new();

		[ContainerField(140), JsonProperty(Order = 140)]
		public List<SamplerPlugins> Plugins { get; set; } = new();

		[ContainerField(144), LayoutImmutable, Blittable, JsonProperty(Order = 144)]
		public bool ShuffleSegments { get; set; }

	}
}
