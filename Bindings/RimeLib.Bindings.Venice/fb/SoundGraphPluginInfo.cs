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
	[ContainerType(4, 12)]
	public class SoundGraphPluginInfo
	{
		[ContainerField(0), LayoutImmutable, Blittable]
		public uint Id { get; set; }
		
		[ContainerField(4), LayoutImmutable, Blittable]
		public uint EnableAttributeReadMask { get; set; }
		
		[ContainerField(8), LayoutImmutable, Blittable]
		public sbyte ConnectionIndex { get; set; }
		
		[ContainerField(9), LayoutImmutable, Blittable]
		public sbyte OutputChannelCount { get; set; }
		
		[ContainerField(10), LayoutImmutable, Blittable]
		public sbyte ConstructParamsIndex { get; set; }
		
		[ContainerField(11), LayoutImmutable, Blittable]
		public sbyte ConstructParamCount { get; set; }
		
		public static void Deserialize(SoundGraphPluginInfo p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.Id = p_Reader.ReadUInt32();
			p_Instance.EnableAttributeReadMask = p_Reader.ReadUInt32();
			p_Instance.ConnectionIndex = p_Reader.ReadSByte();
			p_Instance.OutputChannelCount = p_Reader.ReadSByte();
			p_Instance.ConstructParamsIndex = p_Reader.ReadSByte();
			p_Instance.ConstructParamCount = p_Reader.ReadSByte();
		}
	}
}
