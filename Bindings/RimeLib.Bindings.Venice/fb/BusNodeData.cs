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
	[ContainerType(4, 28)]
	public class BusNodeData : 
		SoundBusData
	{
		[ContainerField(16)]
		public AudioGraphNodePort Out { get; set; } = new();

		[ContainerField(24)]
		public SoundGraphPluginRef VuPlugin { get; set; } = new();

		public static void Deserialize(BusNodeData p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			fb.AudioGraphNodePort.Deserialize(p_Instance.Out, p_Reader, p_Parser);
			fb.SoundGraphPluginRef.Deserialize(p_Instance.VuPlugin, p_Reader, p_Parser);
			p_Reader.Seek(1, SeekOrigin.Current);
		}

	}
}
