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

[ContainerType(8, 64)]
public class InstanceNode
	: fb.UI.UINodeData
{
	[ContainerField(0x28), JsonProperty(Order = 40)]
	public CtrRef<UIGraphAsset> UIGraph { get; set; } = new();
	
	[ContainerField(0x30), JsonProperty(Order = 48)]
	public RefArray<UINodePort> Inputs { get; set; } = new();
	
	[ContainerField(0x38), JsonProperty(Order = 56)]
	public RefArray<UINodePort> Outputs { get; set; } = new();
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(p_EbxWriter.WriteImport(UIGraph));
		p_Writer.WriteNullBytes(4);
		(RimeWriter Writer, uint ArrayIndex) s_Inputs = p_EbxWriter.GetArrayWriter(Inputs.GetType(), Inputs.Count);
		p_Writer.Write(s_Inputs.ArrayIndex);
		foreach (var s_Entry in Inputs)
		{
			s_Inputs.Writer.Write(p_EbxWriter.WriteImport(s_Entry));
		}
		p_Writer.WriteNullBytes(4);
		(RimeWriter Writer, uint ArrayIndex) s_Outputs = p_EbxWriter.GetArrayWriter(Outputs.GetType(), Outputs.Count);
		p_Writer.Write(s_Outputs.ArrayIndex);
		foreach (var s_Entry in Outputs)
		{
			s_Outputs.Writer.Write(p_EbxWriter.WriteImport(s_Entry));
		}
		p_Writer.WriteNullBytes(4);
	}
}

