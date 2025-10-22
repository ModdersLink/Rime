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

using fb.Core;

namespace fb.UI;

[ContainerType(8, 112)]
public class OperandLogicNode
	: fb.UI.UINodeData
{
	[ContainerField(0x28), JsonProperty(Order = 40)]
	public UISimpleDataSource LeftDataSourceInfo { get; set; } = new();
	
	[ContainerField(0x38), LayoutImmutable, Blittable, JsonProperty(Order = 56)]
	public UILogicOperator Operator { get; set; } = UILogicOperator.UILogicOperator_None;
	
	[ContainerField(0x40), JsonProperty(Order = 64)]
	public UISimpleDataSource RightDataSourceInfo { get; set; } = new();
	
	[ContainerField(0x50), LayoutImmutable, Blittable, JsonProperty(Order = 80)]
	public double RightLiteralOperand { get; set; } = 0.000;
	
	[ContainerField(0x58), JsonProperty(Order = 88)]
	public CtrRef<UINodePort> In { get; set; } = new();
	
	[ContainerField(0x60), JsonProperty(Order = 96)]
	public CtrRef<UINodePort> True { get; set; } = new();
	
	[ContainerField(0x68), JsonProperty(Order = 104)]
	public CtrRef<UINodePort> False { get; set; } = new();
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		LeftDataSourceInfo.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write((int) Operator);
		p_Writer.WriteNullBytes(4);
		RightDataSourceInfo.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(RightLiteralOperand);
		p_Writer.Write(p_EbxWriter.WriteImport(In));
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(p_EbxWriter.WriteImport(True));
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(p_EbxWriter.WriteImport(False));
		p_Writer.WriteNullBytes(4);
	}
}

