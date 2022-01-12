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
	[ContainerType(4, 48)]
	public class MultiCrossfaderGroup : 
		AudioGraphNodePortGroup
	{
		[ContainerField(8)]
		public AudioGraphNodePort Amplitude { get; set; } = new();

		[ContainerField(16)]
		public AudioGraphNodePort Start { get; set; } = new();

		[ContainerField(24)]
		public AudioGraphNodePort Stop { get; set; } = new();

		[ContainerField(32), LayoutImmutable, Blittable]
		public float FadeAmplitude { get; set; }

		[ContainerField(36), LayoutImmutable, Blittable]
		public float FadeBegin { get; set; }

		[ContainerField(40), LayoutImmutable, Blittable]
		public float FadeEnd { get; set; }

		[ContainerField(44)]
		public FaderType FadeType { get; set; } = new();

	}
}
