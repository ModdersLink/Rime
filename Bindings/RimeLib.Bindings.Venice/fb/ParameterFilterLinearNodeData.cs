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
	public class ParameterFilterLinearNodeData : 
		AudioGraphNodeData
	{
		[ContainerField(8)]
		public AudioGraphNodePort In { get; set; } = new();

		[ContainerField(16)]
		public AudioGraphNodePort Out { get; set; } = new();

		[ContainerField(24)]
		public AudioGraphNodePort AttackSpeed { get; set; } = new();

		[ContainerField(32)]
		public AudioGraphNodePort ReleaseSpeed { get; set; } = new();

		public static void Deserialize(ParameterFilterLinearNodeData p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			fb.AudioGraphNodePort.Deserialize(p_Instance.In, p_Reader, p_Parser);
			fb.AudioGraphNodePort.Deserialize(p_Instance.Out, p_Reader, p_Parser);
			fb.AudioGraphNodePort.Deserialize(p_Instance.AttackSpeed, p_Reader, p_Parser);
			fb.AudioGraphNodePort.Deserialize(p_Instance.ReleaseSpeed, p_Reader, p_Parser);
		}

	}
}
