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
	[ContainerType(4, 24)]
	public class PadRumbleNodeData : 
		AudioGraphNodeData
	{
		[ContainerField(8)]
		public AudioGraphNodePort RumbleHigh { get; set; } = new();

		[ContainerField(16)]
		public AudioGraphNodePort RumbleLow { get; set; } = new();

		public static void Deserialize(PadRumbleNodeData p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			fb.AudioGraphNodePort.Deserialize(p_Instance.RumbleHigh, p_Reader, p_Parser);
			fb.AudioGraphNodePort.Deserialize(p_Instance.RumbleLow, p_Reader, p_Parser);
		}

	}
}
