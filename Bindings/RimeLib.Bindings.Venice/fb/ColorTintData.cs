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
	[ContainerType(16, 64)]
	public class ColorTintData
	{
		[ContainerField(0), Homogeneous, LayoutImmutable, Blittable]
		public Vec3 Contrast { get; set; } = new();
		
		[ContainerField(16), Homogeneous, LayoutImmutable, Blittable]
		public Vec3 Brightness { get; set; } = new();
		
		[ContainerField(32), Homogeneous, LayoutImmutable, Blittable]
		public Vec3 Saturation { get; set; } = new();
		
		[ContainerField(48), LayoutImmutable, Blittable]
		public float Hue { get; set; }
		
		public static void Deserialize(ColorTintData p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			fb.Vec3.Deserialize(p_Instance.Contrast, p_Reader, p_Parser);
			fb.Vec3.Deserialize(p_Instance.Brightness, p_Reader, p_Parser);
			fb.Vec3.Deserialize(p_Instance.Saturation, p_Reader, p_Parser);
			p_Instance.Hue = p_Reader.ReadSingle();
			p_Reader.Seek(12, SeekOrigin.Current);
		}
	}
}
