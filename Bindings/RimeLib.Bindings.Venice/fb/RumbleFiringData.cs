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
	public class RumbleFiringData
	{
		[ContainerField(0), LayoutImmutable, Blittable]
		public float LowRumble { get; set; }
		
		[ContainerField(4), LayoutImmutable, Blittable]
		public float HighRumble { get; set; }
		
		[ContainerField(8), LayoutImmutable, Blittable]
		public float RumbleDuration { get; set; }
		
		public static void Deserialize(RumbleFiringData p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.LowRumble = p_Reader.ReadSingle();
			p_Instance.HighRumble = p_Reader.ReadSingle();
			p_Instance.RumbleDuration = p_Reader.ReadSingle();
		}
	}
}
