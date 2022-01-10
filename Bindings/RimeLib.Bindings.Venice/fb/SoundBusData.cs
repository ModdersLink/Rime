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
	[ContainerType(4, 16)]
	public class SoundBusData : 
		AudioGraphNodeData
	{
		[ContainerField(8), LayoutImmutable]
		public string BusName { get; set; } = string.Empty;

		[ContainerField(12)]
		public SoundGraphPluginRef SubmixPlugin { get; set; } = new();

		[ContainerField(15), LayoutImmutable, Blittable]
		public sbyte ChannelCount { get; set; }

		public static void Deserialize(SoundBusData p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.BusName = p_Parser.GetStringAtOffset(p_Reader.ReadUInt32());
			fb.SoundGraphPluginRef.Deserialize(p_Instance.SubmixPlugin, p_Reader, p_Parser);
			p_Instance.ChannelCount = p_Reader.ReadSByte();
		}

	}
}
