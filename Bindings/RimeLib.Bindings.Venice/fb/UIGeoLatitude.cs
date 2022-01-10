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
	public class UIGeoLatitude
	{
		[ContainerField(0), LayoutImmutable, Blittable]
		public int Degrees { get; set; }
		
		[ContainerField(4), LayoutImmutable, Blittable]
		public int Minuites { get; set; }
		
		[ContainerField(8), LayoutImmutable, Blittable]
		public int Seconds { get; set; }
		
		public static void Deserialize(UIGeoLatitude p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.Degrees = p_Reader.ReadInt32();
			p_Instance.Minuites = p_Reader.ReadInt32();
			p_Instance.Seconds = p_Reader.ReadInt32();
		}
	}
}
