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
	public class OcclusionSettings : 
		DataContainer
	{
		[ContainerField(8), LayoutImmutable, Blittable]
		public bool Enable { get; set; }

		[ContainerField(9), LayoutImmutable, Blittable]
		public bool DrawZbuffer { get; set; }

		[ContainerField(10), LayoutImmutable, Blittable]
		public bool DrawBinaryBuffer { get; set; }

		public static void Deserialize(OcclusionSettings p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.Enable = p_Reader.ReadBool();
			p_Instance.DrawZbuffer = p_Reader.ReadBool();
			p_Instance.DrawBinaryBuffer = p_Reader.ReadBool();
			p_Reader.Seek(1, SeekOrigin.Current);
		}

	}
}
