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
	[ContainerType(16, 96)]
	public class PolynomialOperatorData : 
		EvaluatorData
	{
		[ContainerField(16)]
		public PolynomialTempData FirstOperand { get; set; } = new();

		[ContainerField(48)]
		public PolynomialTempData SecondOperand { get; set; } = new();

		[ContainerField(80)]
		public PolynomialOperation Operation { get; set; } = new();

		[ContainerField(84), LayoutImmutable, Blittable]
		public float MinClampResult { get; set; }

		[ContainerField(88), LayoutImmutable, Blittable]
		public float MaxClampResult { get; set; }

		public static void Deserialize(PolynomialOperatorData p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Reader.Seek(4, SeekOrigin.Current);
			fb.PolynomialTempData.Deserialize(p_Instance.FirstOperand, p_Reader, p_Parser);
			p_Reader.Seek(4, SeekOrigin.Current);
			fb.PolynomialTempData.Deserialize(p_Instance.SecondOperand, p_Reader, p_Parser);
			p_Reader.Seek(4, SeekOrigin.Current);
			p_Instance.Operation = (PolynomialOperation) p_Reader.ReadInt32();
			p_Reader.Seek(4, SeekOrigin.Current);
			p_Instance.MinClampResult = p_Reader.ReadSingle();
			p_Reader.Seek(4, SeekOrigin.Current);
			p_Instance.MaxClampResult = p_Reader.ReadSingle();
			p_Reader.Seek(8, SeekOrigin.Current);
		}

	}
}
