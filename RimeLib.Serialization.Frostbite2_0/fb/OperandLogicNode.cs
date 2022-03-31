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

namespace fb
{
	[ContainerType(8, 80)]
	public class OperandLogicNode :
		UINodeData
	{
		[ContainerField(20), JsonProperty(Order = 20)]
		public UIDataSourceInfo LeftDataSourceInfo { get; set; } = new();

		[ContainerField(36), JsonProperty(Order = 36)]
		public UILogicOperator Operator { get; set; } = new();

		[ContainerField(40), JsonProperty(Order = 40)]
		public UIDataSourceInfo RightDataSourceInfo { get; set; } = new();

		[ContainerField(56), LayoutImmutable, Blittable, JsonProperty(Order = 56)]
		public double RightLiteralOperand { get; set; }

		[ContainerField(64), JsonProperty(Order = 64)]
		public CtrRef<UINodePort> In { get; set; } = new();

		[ContainerField(68), JsonProperty(Order = 68)]
		public CtrRef<UINodePort> True { get; set; } = new();

		[ContainerField(72), JsonProperty(Order = 72)]
		public CtrRef<UINodePort> False { get; set; } = new();

		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			LeftDataSourceInfo.Serialize(p_Writer, p_EbxWriter);
			p_Writer.Write((int) Operator);
			RightDataSourceInfo.Serialize(p_Writer, p_EbxWriter);
			p_Writer.Write(RightLiteralOperand);
			p_Writer.Write(p_EbxWriter.WriteImport(In));
			p_Writer.Write(p_EbxWriter.WriteImport(True));
			p_Writer.Write(p_EbxWriter.WriteImport(False));
			p_Writer.WriteNullBytes(4);
		}
	}
}
