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
	[ContainerType(4, 72)]
	public class DivisibleLoopPlayerNodeData : 
		AudioGraphNodeData
	{
		[ContainerField(8), JsonProperty(Order = 8)]
		public AudioGraphNodePort Start { get; set; } = new();

		[ContainerField(16), JsonProperty(Order = 16)]
		public AudioGraphNodePort Stop { get; set; } = new();

		[ContainerField(24), JsonProperty(Order = 24)]
		public AudioGraphNodePort Amplitude { get; set; } = new();

		[ContainerField(32), JsonProperty(Order = 32)]
		public AudioGraphNodePort FreezeSegment { get; set; } = new();

		[ContainerField(40), JsonProperty(Order = 40)]
		public AudioGraphNodePort Output { get; set; } = new();

		[ContainerField(48), JsonProperty(Order = 48)]
		public CtrRef<SoundWaveAsset> Wave { get; set; } = new();

		[ContainerField(52), JsonProperty(Order = 52)]
		public AudioGraphNodePort ExternalWave { get; set; } = new();

		[ContainerField(60), JsonProperty(Order = 60)]
		public List<DivisibleLoopPlayerPlugins> Plugins { get; set; } = new();

		[ContainerField(64), LayoutImmutable, Blittable, JsonProperty(Order = 64)]
		public float CrossFadeLength { get; set; }

		[ContainerField(68), LayoutImmutable, Blittable, JsonProperty(Order = 68)]
		public bool StartAtRandomPosition { get; set; }

	}
}
