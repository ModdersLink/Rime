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
	[ContainerType(4, 56)]
	public class SequenceGeneratorNodeData : 
		AudioGraphNodeData
	{
		[ContainerField(8)]
		public AudioGraphNodePort Trigger { get; set; } = new();

		[ContainerField(16)]
		public AudioGraphNodePort Reset { get; set; } = new();

		[ContainerField(24)]
		public AudioGraphNodePort Min { get; set; } = new();

		[ContainerField(32)]
		public AudioGraphNodePort Max { get; set; } = new();

		[ContainerField(40)]
		public AudioGraphNodePort Step { get; set; } = new();

		[ContainerField(48)]
		public AudioGraphNodePort Value { get; set; } = new();

		public static void Deserialize(SequenceGeneratorNodeData p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			fb.AudioGraphNodePort.Deserialize(p_Instance.Trigger, p_Reader, p_Parser);
			fb.AudioGraphNodePort.Deserialize(p_Instance.Reset, p_Reader, p_Parser);
			fb.AudioGraphNodePort.Deserialize(p_Instance.Min, p_Reader, p_Parser);
			fb.AudioGraphNodePort.Deserialize(p_Instance.Max, p_Reader, p_Parser);
			fb.AudioGraphNodePort.Deserialize(p_Instance.Step, p_Reader, p_Parser);
			fb.AudioGraphNodePort.Deserialize(p_Instance.Value, p_Reader, p_Parser);
		}

	}
}
