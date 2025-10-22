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

namespace fb.Audio;

[ContainerType(8, 80)]
public class MixerGraphData
	: fb.Audio.AudioGraphData
{
	[ContainerField(0x38), JsonProperty(Order = 56)]
	public RefArray<AudioGraphParameter> Inputs { get; set; } = new();
	
	[ContainerField(0x40), JsonProperty(Order = 64)]
	public List<MixerInputInfo> MixerInputInfos { get; set; } = new();
	
	[ContainerField(0x48), JsonProperty(Order = 72)]
	public RefArray<AudioGraphParameter> Outputs { get; set; } = new();
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		(RimeWriter Writer, uint ArrayIndex) s_Inputs = p_EbxWriter.GetArrayWriter(Inputs.GetType(), Inputs.Count);
		p_Writer.Write(s_Inputs.ArrayIndex);
		foreach (var s_Entry in Inputs)
		{
			s_Inputs.Writer.Write(p_EbxWriter.WriteImport(s_Entry));
		}
		p_Writer.WriteNullBytes(4);
		(RimeWriter Writer, uint ArrayIndex) s_MixerInputInfos = p_EbxWriter.GetArrayWriter(MixerInputInfos.GetType(), MixerInputInfos.Count);
		p_Writer.Write(s_MixerInputInfos.ArrayIndex);
		foreach (var s_Entry in MixerInputInfos)
		{
			s_Entry.Serialize(s_MixerInputInfos.Writer, p_EbxWriter);
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

