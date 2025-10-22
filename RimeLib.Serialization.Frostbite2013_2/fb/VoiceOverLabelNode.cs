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

[ContainerType(8, 72)]
public class VoiceOverLabelNode
	: fb.Audio.VoiceOverExpressionNode
{
	[ContainerField(0x10), JsonProperty(Order = 16)]
	public RefArray<VoiceOverLabelSource> Sources { get; set; } = new();
	
	[ContainerField(0x18), JsonProperty(Order = 24)]
	public CtrRef<VoiceOverValue> False { get; set; } = new();
	
	[ContainerField(0x20), JsonProperty(Order = 32)]
	public CtrRef<VoiceOverValue> True { get; set; } = new();
	
	[ContainerField(0x28), JsonProperty(Order = 40)]
	public RefArray<VoiceOverLabel> WantedLabels { get; set; } = new();
	
	[ContainerField(0x30), JsonProperty(Order = 48)]
	public RefArray<VoiceOverLabel> UnwantedLabels { get; set; } = new();
	
	[ContainerField(0x38), LayoutImmutable, Blittable, JsonProperty(Order = 56)]
	public VoiceOverLabelSourceMode SourceMode { get; set; } = VoiceOverLabelSourceMode.VoiceOverLabelSourceMode_Combined;
	
	[ContainerField(0x3c), LayoutImmutable, Blittable, JsonProperty(Order = 60)]
	public VoiceOverLabelCompareMode WantedCompareMode { get; set; } = VoiceOverLabelCompareMode.VoiceOverLabelCompareMode_Any;
	
	[ContainerField(0x40), LayoutImmutable, Blittable, JsonProperty(Order = 64)]
	public VoiceOverLabelCompareMode UnwantedCompareMode { get; set; } = VoiceOverLabelCompareMode.VoiceOverLabelCompareMode_Any;
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		(RimeWriter Writer, uint ArrayIndex) s_Sources = p_EbxWriter.GetArrayWriter(Sources.GetType(), Sources.Count);
		p_Writer.Write(s_Sources.ArrayIndex);
		foreach (var s_Entry in Sources)
		{
			s_Sources.Writer.Write(p_EbxWriter.WriteImport(s_Entry));
		}
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(p_EbxWriter.WriteImport(False));
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(p_EbxWriter.WriteImport(True));
		p_Writer.WriteNullBytes(4);
		(RimeWriter Writer, uint ArrayIndex) s_WantedLabels = p_EbxWriter.GetArrayWriter(WantedLabels.GetType(), WantedLabels.Count);
		p_Writer.Write(s_WantedLabels.ArrayIndex);
		foreach (var s_Entry in WantedLabels)
		{
			s_WantedLabels.Writer.Write(p_EbxWriter.WriteImport(s_Entry));
		}
		p_Writer.WriteNullBytes(4);
		(RimeWriter Writer, uint ArrayIndex) s_UnwantedLabels = p_EbxWriter.GetArrayWriter(UnwantedLabels.GetType(), UnwantedLabels.Count);
		p_Writer.Write(s_UnwantedLabels.ArrayIndex);
		foreach (var s_Entry in UnwantedLabels)
		{
			s_UnwantedLabels.Writer.Write(p_EbxWriter.WriteImport(s_Entry));
		}
		p_Writer.WriteNullBytes(4);
		p_Writer.Write((int) SourceMode);
		p_Writer.Write((int) WantedCompareMode);
		p_Writer.Write((int) UnwantedCompareMode);
		p_Writer.WriteNullBytes(4);
	}
}

