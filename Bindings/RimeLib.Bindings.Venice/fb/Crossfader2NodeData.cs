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
	[ContainerType(4, 32)]
	public class Crossfader2NodeData : 
		AudioGraphNodeData
	{
		[ContainerField(8)]
		public AudioGraphNodePort Ctrl { get; set; } = new();

		[ContainerField(16)]
		public AudioGraphNodePort CtrlOut1 { get; set; } = new();

		[ContainerField(24)]
		public AudioGraphNodePort CtrlOut2 { get; set; } = new();

		public static void Deserialize(Crossfader2NodeData p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			fb.AudioGraphNodePort.Deserialize(p_Instance.Ctrl, p_Reader, p_Parser);
			fb.AudioGraphNodePort.Deserialize(p_Instance.CtrlOut1, p_Reader, p_Parser);
			fb.AudioGraphNodePort.Deserialize(p_Instance.CtrlOut2, p_Reader, p_Parser);
		}

	}
}
