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
	public class VisionBoxSettings
	{
		[ContainerField(0), LayoutImmutable, Blittable]
		public float DecreaseXz { get; set; }
		
		[ContainerField(4), LayoutImmutable, Blittable]
		public float LowerTop { get; set; }
		
		[ContainerField(8), LayoutImmutable, Blittable]
		public float RaiseBottom { get; set; }
		
		[ContainerField(12), LayoutImmutable, Blittable]
		public float RaiseBottomHuman { get; set; }
		
		public static void Deserialize(VisionBoxSettings p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.DecreaseXz = p_Reader.ReadSingle();
			p_Instance.LowerTop = p_Reader.ReadSingle();
			p_Instance.RaiseBottom = p_Reader.ReadSingle();
			p_Instance.RaiseBottomHuman = p_Reader.ReadSingle();
		}
	}
}
