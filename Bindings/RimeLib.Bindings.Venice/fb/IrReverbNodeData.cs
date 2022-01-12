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
	[ContainerType(4, 64)]
	public class IrReverbNodeData : 
		AudioGraphNodeData
	{
		[ContainerField(8)]
		public AudioGraphNodePort In { get; set; } = new();

		[ContainerField(16)]
		public AudioGraphNodePort Out { get; set; } = new();

		[ContainerField(24)]
		public AudioGraphNodePort Reverb0 { get; set; } = new();

		[ContainerField(32)]
		public AudioGraphNodePort Amplitude0 { get; set; } = new();

		[ContainerField(40)]
		public AudioGraphNodePort Reverb1 { get; set; } = new();

		[ContainerField(48)]
		public AudioGraphNodePort Amplitude1 { get; set; } = new();

		[ContainerField(56), LayoutImmutable, Blittable]
		public float MaxReverbLength { get; set; }

		[ContainerField(60)]
		public SoundGraphPluginRef ReverbPlugin { get; set; } = new();

	}
}
