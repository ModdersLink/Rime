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
	public class DataCopValueSetting
	{
		[ContainerField(0), LayoutImmutable, Blittable]
		public int DataKey { get; set; }
		
		[ContainerField(4), LayoutImmutable, Blittable]
		public int FrameSpacing { get; set; }
		
		[ContainerField(8), LayoutImmutable, Blittable]
		public int Offset { get; set; }
		
		public static void Deserialize(DataCopValueSetting p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.DataKey = p_Reader.ReadInt32();
			p_Instance.FrameSpacing = p_Reader.ReadInt32();
			p_Instance.Offset = p_Reader.ReadInt32();
		}
	}
}
