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
	public class DivisibleLoopPlayerNodeData : 
		AudioGraphNodeData
	{
		[ContainerField(8)]
		public AudioGraphNodePort Start { get; set; } = new();

		[ContainerField(16)]
		public AudioGraphNodePort Stop { get; set; } = new();

		[ContainerField(24)]
		public AudioGraphNodePort Amplitude { get; set; } = new();

		[ContainerField(32)]
		public AudioGraphNodePort FreezeSegment { get; set; } = new();

		[ContainerField(40)]
		public AudioGraphNodePort Output { get; set; } = new();

		[ContainerField(48)]
		public CtrRef<SoundWaveAsset> Wave { get; set; } = new();

		[ContainerField(52)]
		public AudioGraphNodePort ExternalWave { get; set; } = new();

		[ContainerField(60)]
		public List<DivisibleLoopPlayerPlugins> Plugins { get; set; } = new();

		[ContainerField(64), LayoutImmutable, Blittable]
		public float CrossFadeLength { get; set; }

		[ContainerField(68), LayoutImmutable, Blittable]
		public bool StartAtRandomPosition { get; set; }

	}
}
