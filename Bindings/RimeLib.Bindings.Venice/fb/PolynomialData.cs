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
	[ContainerType(16, 48)]
	public class PolynomialData : 
		EvaluatorData
	{
		[ContainerField(16), Homogeneous, LayoutImmutable, Blittable]
		public Vec4 Coefficients { get; set; } = new();

		[ContainerField(32), LayoutImmutable, Blittable]
		public float ScaleValue { get; set; }

		[ContainerField(36), LayoutImmutable, Blittable]
		public float MinClamp { get; set; }

		[ContainerField(40), LayoutImmutable, Blittable]
		public float MaxClamp { get; set; }

		public static void Deserialize(PolynomialData p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Reader.Seek(4, SeekOrigin.Current);
			fb.Vec4.Deserialize(p_Instance.Coefficients, p_Reader, p_Parser);
			p_Reader.Seek(4, SeekOrigin.Current);
			p_Instance.ScaleValue = p_Reader.ReadSingle();
			p_Reader.Seek(4, SeekOrigin.Current);
			p_Instance.MinClamp = p_Reader.ReadSingle();
			p_Reader.Seek(4, SeekOrigin.Current);
			p_Instance.MaxClamp = p_Reader.ReadSingle();
			p_Reader.Seek(8, SeekOrigin.Current);
		}

	}
}
