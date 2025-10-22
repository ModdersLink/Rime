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

[ContainerType(8, 96)]
public class DataSetNode
	: fb.UI.UINodeData
{
	[ContainerField(0x28), JsonProperty(Order = 40)]
	public CtrRef<UINodePort> In { get; set; } = new();
	
	[ContainerField(0x30), JsonProperty(Order = 48)]
	public CtrRef<UINodePort> Out { get; set; } = new();
	
	[ContainerField(0x38), LayoutImmutable, Blittable, JsonProperty(Order = 56)]
	public string Param { get; set; } = string.Empty;
	
	[ContainerField(0x40), LayoutImmutable, Blittable, JsonProperty(Order = 64)]
	public DataSetParamType ParamType { get; set; } = DataSetParamType.DSPT_Default;
	
	[ContainerField(0x48), JsonProperty(Order = 72)]
	public UISimpleDataSource DataSource { get; set; } = new();
	
	[ContainerField(0x58), LayoutImmutable, Blittable, JsonProperty(Order = 88)]
	public bool SetToEmptyString { get; set; } = false;
	
	[ContainerField(0x59), LayoutImmutable, Blittable, JsonProperty(Order = 89)]
	public bool ForceUpdate { get; set; } = false;
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(p_EbxWriter.WriteImport(In));
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(p_EbxWriter.WriteImport(Out));
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(p_EbxWriter.WriteString(Param));
		p_Writer.Write((int) ParamType);
		p_Writer.WriteNullBytes(4);
		DataSource.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(SetToEmptyString);
		p_Writer.Write(ForceUpdate);
		p_Writer.WriteNullBytes(6);
	}
}

