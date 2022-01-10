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
	public class Ps3AgeLevels
	{
		[ContainerField(0), LayoutImmutable, Blittable]
		public int AgeLevel7 { get; set; }
		
		[ContainerField(4), LayoutImmutable, Blittable]
		public int AgeLevel8 { get; set; }
		
		[ContainerField(8), LayoutImmutable, Blittable]
		public int AgeLevel9 { get; set; }
		
		[ContainerField(12), LayoutImmutable, Blittable]
		public int AgeLevel10 { get; set; }
		
		public static void Deserialize(Ps3AgeLevels p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.AgeLevel7 = p_Reader.ReadInt32();
			p_Instance.AgeLevel8 = p_Reader.ReadInt32();
			p_Instance.AgeLevel9 = p_Reader.ReadInt32();
			p_Instance.AgeLevel10 = p_Reader.ReadInt32();
		}
	}
}
