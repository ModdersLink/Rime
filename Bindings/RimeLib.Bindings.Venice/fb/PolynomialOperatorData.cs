///////////////////////////////////////////////////////////////
//                                                           //
// This is an automatically generated file.                  //
// Do *NOT* modify unless you really know what you're doing. //
//                                                           //
///////////////////////////////////////////////////////////////

using System;
using System.IO;
using System.Collections.Generic;
using Newtonsoft.Json;
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
		[ContainerField(16), JsonProperty(Order = 16)]
		public PolynomialTempData FirstOperand { get; set; } = new();

		[ContainerField(48), JsonProperty(Order = 48)]
		public PolynomialTempData SecondOperand { get; set; } = new();

		[ContainerField(80), JsonProperty(Order = 80)]
		public PolynomialOperation Operation { get; set; } = new();

		[ContainerField(84), LayoutImmutable, Blittable, JsonProperty(Order = 84)]
		public float MinClampResult { get; set; }

		[ContainerField(88), LayoutImmutable, Blittable, JsonProperty(Order = 88)]
		public float MaxClampResult { get; set; }

	}
}
