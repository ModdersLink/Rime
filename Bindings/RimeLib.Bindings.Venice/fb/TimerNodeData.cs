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
	public class TimerNodeData : 
		AudioGraphNodeData
	{
		[ContainerField(8)]
		public AudioGraphNodePort Start { get; set; } = new();

		[ContainerField(16)]
		public AudioGraphNodePort Stop { get; set; } = new();

		[ContainerField(24)]
		public AudioGraphNodePort Period { get; set; } = new();

		[ContainerField(32)]
		public AudioGraphNodePort Tick { get; set; } = new();

		[ContainerField(40)]
		public AudioGraphNodePort Progress { get; set; } = new();

		[ContainerField(48)]
		public TimerMode Mode { get; set; } = new();

		public static void Deserialize(TimerNodeData p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			fb.AudioGraphNodePort.Deserialize(p_Instance.Start, p_Reader, p_Parser);
			fb.AudioGraphNodePort.Deserialize(p_Instance.Stop, p_Reader, p_Parser);
			fb.AudioGraphNodePort.Deserialize(p_Instance.Period, p_Reader, p_Parser);
			fb.AudioGraphNodePort.Deserialize(p_Instance.Tick, p_Reader, p_Parser);
			fb.AudioGraphNodePort.Deserialize(p_Instance.Progress, p_Reader, p_Parser);
			p_Instance.Mode = (TimerMode) p_Reader.ReadInt32();
		}

	}
}
