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
using RimeLib.Serialization.Frostbite2_0.Ebx;
using CommunityToolkit.Mvvm.ComponentModel;

namespace fb
{
	[ContainerType(16, 96)]
	public partial class PolynomialOperatorData :
		EvaluatorData
	{
		[ObservableProperty]
		[property: ContainerField(16), JsonProperty(Order = 16)]
		private PolynomialTempData _FirstOperand = new();

		[ObservableProperty]
		[property: ContainerField(48), JsonProperty(Order = 48)]
		private PolynomialTempData _SecondOperand = new();

		[ObservableProperty]
		[property: ContainerField(80), JsonProperty(Order = 80)]
		private PolynomialOperation _Operation = new();

		[ObservableProperty]
		[property: ContainerField(84), LayoutImmutable, Blittable, JsonProperty(Order = 84)]
		private float _MinClampResult;

		[ObservableProperty]
		[property: ContainerField(88), LayoutImmutable, Blittable, JsonProperty(Order = 88)]
		private float _MaxClampResult;

		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			p_Writer.WriteNullBytes(4);
			FirstOperand.Serialize(p_Writer, p_EbxWriter);
			SecondOperand.Serialize(p_Writer, p_EbxWriter);
			p_Writer.Write((int) Operation);
			p_Writer.Write(MinClampResult);
			p_Writer.Write(MaxClampResult);
			p_Writer.WriteNullBytes(4);
		}
	}
}
