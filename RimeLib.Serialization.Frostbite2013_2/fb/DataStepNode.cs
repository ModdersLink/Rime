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
public class DataStepNode
	: fb.UI.UINodeData
{
	[ContainerField(0x28), JsonProperty(Order = 40)]
	public CtrRef<UINodePort> In { get; set; } = new();
	
	[ContainerField(0x30), JsonProperty(Order = 48)]
	public CtrRef<UINodePort> Out { get; set; } = new();
	
	[ContainerField(0x38), JsonProperty(Order = 56)]
	public List<float> Steps { get; set; } = new();
	
	[ContainerField(0x40), JsonProperty(Order = 64)]
	public UISimpleDataSource CurrentStepDataSource { get; set; } = new();
	
	[ContainerField(0x50), JsonProperty(Order = 80)]
	public UISimpleDataSource DataSource { get; set; } = new();
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(p_EbxWriter.WriteImport(In));
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(p_EbxWriter.WriteImport(Out));
		p_Writer.WriteNullBytes(4);
		(RimeWriter Writer, uint ArrayIndex) s_Steps = p_EbxWriter.GetArrayWriter(Steps.GetType(), Steps.Count);
		p_Writer.Write(s_Steps.ArrayIndex);
		foreach (var s_Entry in Steps)
		{
			s_Steps.Writer.Write(s_Entry);
		}
		p_Writer.WriteNullBytes(4);
		CurrentStepDataSource.Serialize(p_Writer, p_EbxWriter);
		DataSource.Serialize(p_Writer, p_EbxWriter);
	}
}

