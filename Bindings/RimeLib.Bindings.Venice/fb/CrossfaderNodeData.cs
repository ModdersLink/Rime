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
	public class CrossfaderNodeData : 
		AudioGraphNodeData
	{
		[ContainerField(8)]
		public AudioGraphNodePort In1 { get; set; } = new();

		[ContainerField(16)]
		public AudioGraphNodePort In2 { get; set; } = new();

		[ContainerField(24)]
		public AudioGraphNodePort Ctrl { get; set; } = new();

		[ContainerField(32)]
		public AudioGraphNodePort Out { get; set; } = new();

		[ContainerField(40)]
		public SoundGraphPluginRef Plugin1 { get; set; } = new();

		[ContainerField(43)]
		public SoundGraphPluginRef Plugin2 { get; set; } = new();

		public static void Deserialize(CrossfaderNodeData p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			fb.AudioGraphNodePort.Deserialize(p_Instance.In1, p_Reader, p_Parser);
			fb.AudioGraphNodePort.Deserialize(p_Instance.In2, p_Reader, p_Parser);
			fb.AudioGraphNodePort.Deserialize(p_Instance.Ctrl, p_Reader, p_Parser);
			fb.AudioGraphNodePort.Deserialize(p_Instance.Out, p_Reader, p_Parser);
			fb.SoundGraphPluginRef.Deserialize(p_Instance.Plugin1, p_Reader, p_Parser);
			fb.SoundGraphPluginRef.Deserialize(p_Instance.Plugin2, p_Reader, p_Parser);
			p_Reader.Seek(2, SeekOrigin.Current);
		}

	}
}
