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
	public class LfoNodeData : 
		AudioGraphNodeData
	{
		[ContainerField(8)]
		public AudioGraphNodePort Hz { get; set; } = new();

		[ContainerField(16)]
		public AudioGraphNodePort Amplitude { get; set; } = new();

		[ContainerField(24)]
		public AudioGraphNodePort Out { get; set; } = new();

		[ContainerField(32), LayoutImmutable, Blittable]
		public float Min { get; set; }

		[ContainerField(36), LayoutImmutable, Blittable]
		public float Max { get; set; }

		[ContainerField(40), LayoutImmutable, Blittable]
		public bool StartAtRandomValue { get; set; }

		public static void Deserialize(LfoNodeData p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			fb.AudioGraphNodePort.Deserialize(p_Instance.Hz, p_Reader, p_Parser);
			fb.AudioGraphNodePort.Deserialize(p_Instance.Amplitude, p_Reader, p_Parser);
			fb.AudioGraphNodePort.Deserialize(p_Instance.Out, p_Reader, p_Parser);
			p_Instance.Min = p_Reader.ReadSingle();
			p_Instance.Max = p_Reader.ReadSingle();
			p_Instance.StartAtRandomValue = p_Reader.ReadBool();
			p_Reader.Seek(3, SeekOrigin.Current);
		}

	}
}
