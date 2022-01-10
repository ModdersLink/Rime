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
	public class DacNodeData : 
		AudioGraphNodeData
	{
		[ContainerField(8)]
		public AudioGraphNodePort In { get; set; } = new();

		[ContainerField(16)]
		public AudioGraphNodePort SpeakerCount { get; set; } = new();

		[ContainerField(24)]
		public AudioGraphNodePort SampleRate { get; set; } = new();

		[ContainerField(32)]
		public SoundGraphPluginRef VuPlugin { get; set; } = new();

		[ContainerField(35)]
		public SoundGraphPluginRef GainPlugin { get; set; } = new();

		[ContainerField(38)]
		public SoundGraphPluginRef DacPlugin { get; set; } = new();

		public static void Deserialize(DacNodeData p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			fb.AudioGraphNodePort.Deserialize(p_Instance.In, p_Reader, p_Parser);
			fb.AudioGraphNodePort.Deserialize(p_Instance.SpeakerCount, p_Reader, p_Parser);
			fb.AudioGraphNodePort.Deserialize(p_Instance.SampleRate, p_Reader, p_Parser);
			fb.SoundGraphPluginRef.Deserialize(p_Instance.VuPlugin, p_Reader, p_Parser);
			fb.SoundGraphPluginRef.Deserialize(p_Instance.GainPlugin, p_Reader, p_Parser);
			fb.SoundGraphPluginRef.Deserialize(p_Instance.DacPlugin, p_Reader, p_Parser);
			p_Reader.Seek(3, SeekOrigin.Current);
		}

	}
}
