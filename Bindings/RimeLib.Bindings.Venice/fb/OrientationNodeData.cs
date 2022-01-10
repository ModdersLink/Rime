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
	public class OrientationNodeData : 
		AudioGraphNodeData
	{
		[ContainerField(8)]
		public AudioGraphNodePort ListenerRelativeYaw { get; set; } = new();

		[ContainerField(16)]
		public AudioGraphNodePort ListenerRelativePitch { get; set; } = new();

		[ContainerField(24)]
		public AudioGraphNodePort ListenerRelativeRoll { get; set; } = new();

		public static void Deserialize(OrientationNodeData p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			fb.AudioGraphNodePort.Deserialize(p_Instance.ListenerRelativeYaw, p_Reader, p_Parser);
			fb.AudioGraphNodePort.Deserialize(p_Instance.ListenerRelativePitch, p_Reader, p_Parser);
			fb.AudioGraphNodePort.Deserialize(p_Instance.ListenerRelativeRoll, p_Reader, p_Parser);
		}

	}
}
