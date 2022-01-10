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
	[ContainerType(16, 32)]
	public class PolynomialTempData
	{
		[ContainerField(0), Homogeneous, LayoutImmutable, Blittable]
		public Vec4 Coefficients { get; set; } = new();
		
		[ContainerField(16), LayoutImmutable, Blittable]
		public float ScaleValue { get; set; }
		
		[ContainerField(20), LayoutImmutable, Blittable]
		public float MinClamp { get; set; }
		
		[ContainerField(24), LayoutImmutable, Blittable]
		public float MaxClamp { get; set; }
		
		public static void Deserialize(PolynomialTempData p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			fb.Vec4.Deserialize(p_Instance.Coefficients, p_Reader, p_Parser);
			p_Instance.ScaleValue = p_Reader.ReadSingle();
			p_Instance.MinClamp = p_Reader.ReadSingle();
			p_Instance.MaxClamp = p_Reader.ReadSingle();
			p_Reader.Seek(4, SeekOrigin.Current);
		}
	}
}
