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
	[ContainerType(4, 52)]
	public class WaveSwitcherNodeData : 
		AudioGraphNodeData
	{
		[ContainerField(8)]
		public AudioGraphNodePort Index { get; set; } = new();

		[ContainerField(16)]
		public AudioGraphNodePort Advance { get; set; } = new();

		[ContainerField(24)]
		public AudioGraphNodePort Wave { get; set; } = new();

		[ContainerField(32)]
		public AudioGraphNodePort IndexChanged { get; set; } = new();

		[ContainerField(40)]
		public RefArray<SoundWaveAsset> Waves { get; set; } = new();

		[ContainerField(44), LayoutImmutable, Blittable]
		public float DefaultIndex { get; set; }

		[ContainerField(48), LayoutImmutable, Blittable]
		public bool IsRandom { get; set; }

		[ContainerField(49), LayoutImmutable, Blittable]
		public bool RandomStartIndex { get; set; }

	}
}
