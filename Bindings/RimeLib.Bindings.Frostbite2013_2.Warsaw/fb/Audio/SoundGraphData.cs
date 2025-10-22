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

[ContainerType(8, 128)]
public class SoundGraphData
	: fb.Audio.AudioGraphData
{
	[ContainerField(0x38), JsonProperty(Order = 56)]
	public SoundGraphInfo Info { get; set; } = new();
	
	[ContainerField(0x60), JsonProperty(Order = 96)]
	public RefArray<AudioGraphParameter> InputParameters { get; set; } = new();
	
	[ContainerField(0x68), JsonProperty(Order = 104)]
	public RefArray<AudioGraphParameter> OutputParameters { get; set; } = new();
	
	[ContainerField(0x70), JsonProperty(Order = 112)]
	public RefArray<AudioGraphEvent> InputEvents { get; set; } = new();
	
	[ContainerField(0x78), JsonProperty(Order = 120)]
	public RefArray<AudioGraphEvent> OutputEvents { get; set; } = new();
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		Info.Serialize(p_Writer, p_EbxWriter);
		(RimeWriter Writer, uint ArrayIndex) s_InputParameters = p_EbxWriter.GetArrayWriter(InputParameters.GetType(), InputParameters.Count);
		p_Writer.Write(s_InputParameters.ArrayIndex);
		foreach (var s_Entry in InputParameters)
		{
			s_InputParameters.Writer.Write(p_EbxWriter.WriteImport(s_Entry));
		}
		p_Writer.WriteNullBytes(4);
		(RimeWriter Writer, uint ArrayIndex) s_OutputParameters = p_EbxWriter.GetArrayWriter(OutputParameters.GetType(), OutputParameters.Count);
		p_Writer.Write(s_OutputParameters.ArrayIndex);
		foreach (var s_Entry in OutputParameters)
		{
			s_OutputParameters.Writer.Write(p_EbxWriter.WriteImport(s_Entry));
		}
		p_Writer.WriteNullBytes(4);
		(RimeWriter Writer, uint ArrayIndex) s_InputEvents = p_EbxWriter.GetArrayWriter(InputEvents.GetType(), InputEvents.Count);
		p_Writer.Write(s_InputEvents.ArrayIndex);
		foreach (var s_Entry in InputEvents)
		{
			s_InputEvents.Writer.Write(p_EbxWriter.WriteImport(s_Entry));
		}
		p_Writer.WriteNullBytes(4);
		(RimeWriter Writer, uint ArrayIndex) s_OutputEvents = p_EbxWriter.GetArrayWriter(OutputEvents.GetType(), OutputEvents.Count);
		p_Writer.Write(s_OutputEvents.ArrayIndex);
		foreach (var s_Entry in OutputEvents)
		{
			s_OutputEvents.Writer.Write(p_EbxWriter.WriteImport(s_Entry));
		}
		p_Writer.WriteNullBytes(4);
	}
}

