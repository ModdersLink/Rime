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
	[ContainerType(4, 8)]
	public class SoundWaveSubtitle
	{
		[ContainerField(0), LayoutImmutable, Blittable]
		public float Time { get; set; }
		
		[ContainerField(4), LayoutImmutable, Blittable]
		public sbyte StringIndex { get; set; }
		
		public static void Deserialize(SoundWaveSubtitle p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.Time = p_Reader.ReadSingle();
			p_Instance.StringIndex = p_Reader.ReadSByte();
			p_Reader.Seek(3, SeekOrigin.Current);
		}
	}
}
