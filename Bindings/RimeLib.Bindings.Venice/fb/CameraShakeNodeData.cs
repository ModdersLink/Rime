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
	public class CameraShakeNodeData : 
		AudioGraphNodeData
	{
		[ContainerField(8)]
		public AudioGraphNodePort Pitch { get; set; } = new();

		[ContainerField(16)]
		public AudioGraphNodePort Yaw { get; set; } = new();

		[ContainerField(24)]
		public AudioGraphNodePort Roll { get; set; } = new();

		public static void Deserialize(CameraShakeNodeData p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			fb.AudioGraphNodePort.Deserialize(p_Instance.Pitch, p_Reader, p_Parser);
			fb.AudioGraphNodePort.Deserialize(p_Instance.Yaw, p_Reader, p_Parser);
			fb.AudioGraphNodePort.Deserialize(p_Instance.Roll, p_Reader, p_Parser);
		}

	}
}
