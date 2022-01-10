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
	[ContainerType(4, 40)]
	public class IrReverbControllerNodeData : 
		AudioGraphNodeData
	{
		[ContainerField(8)]
		public AudioGraphNodePort Reverb0 { get; set; } = new();

		[ContainerField(16)]
		public AudioGraphNodePort Amplitude0 { get; set; } = new();

		[ContainerField(24)]
		public AudioGraphNodePort Reverb1 { get; set; } = new();

		[ContainerField(32)]
		public AudioGraphNodePort Amplitude1 { get; set; } = new();

		public static void Deserialize(IrReverbControllerNodeData p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			fb.AudioGraphNodePort.Deserialize(p_Instance.Reverb0, p_Reader, p_Parser);
			fb.AudioGraphNodePort.Deserialize(p_Instance.Amplitude0, p_Reader, p_Parser);
			fb.AudioGraphNodePort.Deserialize(p_Instance.Reverb1, p_Reader, p_Parser);
			fb.AudioGraphNodePort.Deserialize(p_Instance.Amplitude1, p_Reader, p_Parser);
		}

	}
}
