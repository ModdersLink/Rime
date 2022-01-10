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
	public class LinearTransformNodeData : 
		AudioGraphNodeData
	{
		[ContainerField(8)]
		public AudioGraphNodePort X { get; set; } = new();

		[ContainerField(16)]
		public AudioGraphNodePort K { get; set; } = new();

		[ContainerField(24)]
		public AudioGraphNodePort M { get; set; } = new();

		[ContainerField(32)]
		public AudioGraphNodePort Y { get; set; } = new();

		public static void Deserialize(LinearTransformNodeData p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			fb.AudioGraphNodePort.Deserialize(p_Instance.X, p_Reader, p_Parser);
			fb.AudioGraphNodePort.Deserialize(p_Instance.K, p_Reader, p_Parser);
			fb.AudioGraphNodePort.Deserialize(p_Instance.M, p_Reader, p_Parser);
			fb.AudioGraphNodePort.Deserialize(p_Instance.Y, p_Reader, p_Parser);
		}

	}
}
