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
	[ContainerType(4, 36)]
	public class NumberGeneratorNodeData : 
		AudioGraphNodeData
	{
		[ContainerField(8)]
		public AudioGraphNodePort Trigger { get; set; } = new();

		[ContainerField(16), LayoutImmutable, Blittable]
		public float Min { get; set; }

		[ContainerField(20), LayoutImmutable, Blittable]
		public float Max { get; set; }

		[ContainerField(24)]
		public NumberGeneratorMode Mode { get; set; } = new();

		[ContainerField(28)]
		public AudioGraphNodePort Y { get; set; } = new();

		public static void Deserialize(NumberGeneratorNodeData p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			fb.AudioGraphNodePort.Deserialize(p_Instance.Trigger, p_Reader, p_Parser);
			p_Instance.Min = p_Reader.ReadSingle();
			p_Instance.Max = p_Reader.ReadSingle();
			p_Instance.Mode = (NumberGeneratorMode) p_Reader.ReadInt32();
			fb.AudioGraphNodePort.Deserialize(p_Instance.Y, p_Reader, p_Parser);
		}

	}
}
