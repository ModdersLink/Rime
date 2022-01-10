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
	public class MinMaxNodeData : 
		AudioGraphNodeData
	{
		[ContainerField(8)]
		public AudioGraphNodePort X { get; set; } = new();

		[ContainerField(16)]
		public AudioGraphNodePort Y { get; set; } = new();

		[ContainerField(24)]
		public AudioGraphNodePort Max { get; set; } = new();

		[ContainerField(32)]
		public AudioGraphNodePort Min { get; set; } = new();

		public static void Deserialize(MinMaxNodeData p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			fb.AudioGraphNodePort.Deserialize(p_Instance.X, p_Reader, p_Parser);
			fb.AudioGraphNodePort.Deserialize(p_Instance.Y, p_Reader, p_Parser);
			fb.AudioGraphNodePort.Deserialize(p_Instance.Max, p_Reader, p_Parser);
			fb.AudioGraphNodePort.Deserialize(p_Instance.Min, p_Reader, p_Parser);
		}

	}
}
