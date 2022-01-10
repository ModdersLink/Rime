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

		public static void Deserialize(MultiCrossfaderGroup p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			fb.AudioGraphNodePort.Deserialize(p_Instance.Amplitude, p_Reader, p_Parser);
			fb.AudioGraphNodePort.Deserialize(p_Instance.Start, p_Reader, p_Parser);
			fb.AudioGraphNodePort.Deserialize(p_Instance.Stop, p_Reader, p_Parser);
			p_Instance.FadeAmplitude = p_Reader.ReadSingle();
			p_Instance.FadeBegin = p_Reader.ReadSingle();
			p_Instance.FadeEnd = p_Reader.ReadSingle();
			p_Instance.FadeType = (FaderType) p_Reader.ReadInt32();
		}

	}
}
