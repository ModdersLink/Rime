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

[ContainerType(8, 112)]
public class VoiceOverSystemAsset
	: fb.Core.Asset
{
	[ContainerField(0x18), JsonProperty(Order = 24)]
	public RefArray<VoiceOverInterval> Intervals { get; set; } = new();
	
	[ContainerField(0x20), JsonProperty(Order = 32)]
	public RefArray<VoiceOverLabel> Labels { get; set; } = new();
	
	[ContainerField(0x28), JsonProperty(Order = 40)]
	public RefArray<VoiceOverObject> Types { get; set; } = new();
	
	[ContainerField(0x30), JsonProperty(Order = 48)]
	public RefArray<VoiceOverObject> Objects { get; set; } = new();
	
	[ContainerField(0x38), JsonProperty(Order = 56)]
	public RefArray<VoiceOverGlobalConstantValue> Constants { get; set; } = new();
	
	[ContainerField(0x40), JsonProperty(Order = 64)]
	public CtrRef<AudioLanguage> MasterLanguage { get; set; } = new();
	
	[ContainerField(0x48), JsonProperty(Order = 72)]
	public CtrRef<VoiceOverPronunciation> DefaultPronunciation { get; set; } = new();
	
	[ContainerField(0x50), JsonProperty(Order = 80)]
	public RefArray<VoiceOverPronunciation> Pronunciations { get; set; } = new();
	
	[ContainerField(0x58), JsonProperty(Order = 88)]
	public RefArray<VoiceOverConversationQueueGroup> QueueGroups { get; set; } = new();
	
	[ContainerField(0x60), JsonProperty(Order = 96)]
	public CtrRef<VoiceOverConversationQueueGroup> DefaultPositionedQueueGroup { get; set; } = new();
	
	[ContainerField(0x68), JsonProperty(Order = 104)]
	public CtrRef<VoiceOverConversationQueueGroup> DefaultUnpositionedQueueGroup { get; set; } = new();
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		(RimeWriter Writer, uint ArrayIndex) s_Intervals = p_EbxWriter.GetArrayWriter(Intervals.GetType(), Intervals.Count);
		p_Writer.Write(s_Intervals.ArrayIndex);
		foreach (var s_Entry in Intervals)
		{
			s_Intervals.Writer.Write(p_EbxWriter.WriteImport(s_Entry));
		}
		p_Writer.WriteNullBytes(4);
		(RimeWriter Writer, uint ArrayIndex) s_Labels = p_EbxWriter.GetArrayWriter(Labels.GetType(), Labels.Count);
		p_Writer.Write(s_Labels.ArrayIndex);
		foreach (var s_Entry in Labels)
		{
			s_Labels.Writer.Write(p_EbxWriter.WriteImport(s_Entry));
		}
		p_Writer.WriteNullBytes(4);
		(RimeWriter Writer, uint ArrayIndex) s_Types = p_EbxWriter.GetArrayWriter(Types.GetType(), Types.Count);
		p_Writer.Write(s_Types.ArrayIndex);
		foreach (var s_Entry in Types)
		{
			s_Types.Writer.Write(p_EbxWriter.WriteImport(s_Entry));
		}
		p_Writer.WriteNullBytes(4);
		(RimeWriter Writer, uint ArrayIndex) s_Objects = p_EbxWriter.GetArrayWriter(Objects.GetType(), Objects.Count);
		p_Writer.Write(s_Objects.ArrayIndex);
		foreach (var s_Entry in Objects)
		{
			s_Objects.Writer.Write(p_EbxWriter.WriteImport(s_Entry));
		}
		p_Writer.WriteNullBytes(4);
		(RimeWriter Writer, uint ArrayIndex) s_Constants = p_EbxWriter.GetArrayWriter(Constants.GetType(), Constants.Count);
		p_Writer.Write(s_Constants.ArrayIndex);
		foreach (var s_Entry in Constants)
		{
			s_Constants.Writer.Write(p_EbxWriter.WriteImport(s_Entry));
		}
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(p_EbxWriter.WriteImport(MasterLanguage));
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(p_EbxWriter.WriteImport(DefaultPronunciation));
		p_Writer.WriteNullBytes(4);
		(RimeWriter Writer, uint ArrayIndex) s_Pronunciations = p_EbxWriter.GetArrayWriter(Pronunciations.GetType(), Pronunciations.Count);
		p_Writer.Write(s_Pronunciations.ArrayIndex);
		foreach (var s_Entry in Pronunciations)
		{
			s_Pronunciations.Writer.Write(p_EbxWriter.WriteImport(s_Entry));
		}
		p_Writer.WriteNullBytes(4);
		(RimeWriter Writer, uint ArrayIndex) s_QueueGroups = p_EbxWriter.GetArrayWriter(QueueGroups.GetType(), QueueGroups.Count);
		p_Writer.Write(s_QueueGroups.ArrayIndex);
		foreach (var s_Entry in QueueGroups)
		{
			s_QueueGroups.Writer.Write(p_EbxWriter.WriteImport(s_Entry));
		}
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(p_EbxWriter.WriteImport(DefaultPositionedQueueGroup));
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(p_EbxWriter.WriteImport(DefaultUnpositionedQueueGroup));
		p_Writer.WriteNullBytes(4);
	}
}

