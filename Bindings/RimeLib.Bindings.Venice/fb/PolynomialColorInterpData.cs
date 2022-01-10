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
	public class PolynomialColorInterpData : 
		EvaluatorData
	{
		[ContainerField(16), Homogeneous, LayoutImmutable, Blittable]
		public Vec3 Color0 { get; set; } = new();

		[ContainerField(32), Homogeneous, LayoutImmutable, Blittable]
		public Vec3 Color1 { get; set; } = new();

		[ContainerField(48), Homogeneous, LayoutImmutable, Blittable]
		public Vec4 Coefficients { get; set; } = new();

		public static void Deserialize(PolynomialColorInterpData p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Reader.Seek(4, SeekOrigin.Current);
			fb.Vec3.Deserialize(p_Instance.Color0, p_Reader, p_Parser);
			p_Reader.Seek(4, SeekOrigin.Current);
			fb.Vec3.Deserialize(p_Instance.Color1, p_Reader, p_Parser);
			p_Reader.Seek(4, SeekOrigin.Current);
			fb.Vec4.Deserialize(p_Instance.Coefficients, p_Reader, p_Parser);
			p_Reader.Seek(4, SeekOrigin.Current);
		}

	}
}
