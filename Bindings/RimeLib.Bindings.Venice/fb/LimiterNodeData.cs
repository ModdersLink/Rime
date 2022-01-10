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
	public class LimiterNodeData : 
		AudioGraphNodeData
	{
		[ContainerField(8)]
		public AudioGraphNodePort In { get; set; } = new();

		[ContainerField(16)]
		public AudioGraphNodePort Threshold { get; set; } = new();

		[ContainerField(24)]
		public AudioGraphNodePort ReleaseTime { get; set; } = new();

		[ContainerField(32)]
		public AudioGraphNodePort Out { get; set; } = new();

		[ContainerField(40)]
		public LimiterChannelMode ChannelMode { get; set; } = new();

		[ContainerField(44)]
		public SoundGraphPluginRef Plugin { get; set; } = new();

		public static void Deserialize(LimiterNodeData p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			fb.AudioGraphNodePort.Deserialize(p_Instance.In, p_Reader, p_Parser);
			fb.AudioGraphNodePort.Deserialize(p_Instance.Threshold, p_Reader, p_Parser);
			fb.AudioGraphNodePort.Deserialize(p_Instance.ReleaseTime, p_Reader, p_Parser);
			fb.AudioGraphNodePort.Deserialize(p_Instance.Out, p_Reader, p_Parser);
			p_Instance.ChannelMode = (LimiterChannelMode) p_Reader.ReadInt32();
			fb.SoundGraphPluginRef.Deserialize(p_Instance.Plugin, p_Reader, p_Parser);
			p_Reader.Seek(1, SeekOrigin.Current);
		}

	}
}
