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
	[ContainerType(4, 56)]
	public class VoiceOverSystemAsset :
		Asset
	{
		[ContainerField(12), JsonProperty(Order = 12)]
		public RefArray<VoiceOverInterval> Intervals { get; set; } = new();

		[ContainerField(16), JsonProperty(Order = 16)]
		public RefArray<VoiceOverLabel> Labels { get; set; } = new();

		[ContainerField(20), JsonProperty(Order = 20)]
		public RefArray<VoiceOverObject> Types { get; set; } = new();

		[ContainerField(24), JsonProperty(Order = 24)]
		public RefArray<VoiceOverObject> Objects { get; set; } = new();

		[ContainerField(28), JsonProperty(Order = 28)]
		public RefArray<VoiceOverGlobalConstantValue> Constants { get; set; } = new();

		[ContainerField(32), JsonProperty(Order = 32)]
		public CtrRef<AudioLanguage> MasterLanguage { get; set; } = new();

		[ContainerField(36), JsonProperty(Order = 36)]
		public CtrRef<VoiceOverPronunciation> DefaultPronunciation { get; set; } = new();

		[ContainerField(40), JsonProperty(Order = 40)]
		public RefArray<VoiceOverPronunciation> Pronunciations { get; set; } = new();

		[ContainerField(44), JsonProperty(Order = 44)]
		public RefArray<VoiceOverConversationQueueGroup> QueueGroups { get; set; } = new();

		[ContainerField(48), JsonProperty(Order = 48)]
		public CtrRef<VoiceOverConversationQueueGroup> DefaultPositionedQueueGroup { get; set; } = new();

		[ContainerField(52), JsonProperty(Order = 52)]
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
			(RimeWriter Writer, uint ArrayIndex) s_Labels = p_EbxWriter.GetArrayWriter(Labels.GetType(), Labels.Count);
			p_Writer.Write(s_Labels.ArrayIndex);
			foreach (var s_Entry in Labels)
			{
				s_Labels.Writer.Write(p_EbxWriter.WriteImport(s_Entry));
			}
			(RimeWriter Writer, uint ArrayIndex) s_Types = p_EbxWriter.GetArrayWriter(Types.GetType(), Types.Count);
			p_Writer.Write(s_Types.ArrayIndex);
			foreach (var s_Entry in Types)
			{
				s_Types.Writer.Write(p_EbxWriter.WriteImport(s_Entry));
			}
			(RimeWriter Writer, uint ArrayIndex) s_Objects = p_EbxWriter.GetArrayWriter(Objects.GetType(), Objects.Count);
			p_Writer.Write(s_Objects.ArrayIndex);
			foreach (var s_Entry in Objects)
			{
				s_Objects.Writer.Write(p_EbxWriter.WriteImport(s_Entry));
			}
			(RimeWriter Writer, uint ArrayIndex) s_Constants = p_EbxWriter.GetArrayWriter(Constants.GetType(), Constants.Count);
			p_Writer.Write(s_Constants.ArrayIndex);
			foreach (var s_Entry in Constants)
			{
				s_Constants.Writer.Write(p_EbxWriter.WriteImport(s_Entry));
			}
			p_Writer.Write(p_EbxWriter.WriteImport(MasterLanguage));
			p_Writer.Write(p_EbxWriter.WriteImport(DefaultPronunciation));
			(RimeWriter Writer, uint ArrayIndex) s_Pronunciations = p_EbxWriter.GetArrayWriter(Pronunciations.GetType(), Pronunciations.Count);
			p_Writer.Write(s_Pronunciations.ArrayIndex);
			foreach (var s_Entry in Pronunciations)
			{
				s_Pronunciations.Writer.Write(p_EbxWriter.WriteImport(s_Entry));
			}
			(RimeWriter Writer, uint ArrayIndex) s_QueueGroups = p_EbxWriter.GetArrayWriter(QueueGroups.GetType(), QueueGroups.Count);
			p_Writer.Write(s_QueueGroups.ArrayIndex);
			foreach (var s_Entry in QueueGroups)
			{
				s_QueueGroups.Writer.Write(p_EbxWriter.WriteImport(s_Entry));
			}
			p_Writer.Write(p_EbxWriter.WriteImport(DefaultPositionedQueueGroup));
			p_Writer.Write(p_EbxWriter.WriteImport(DefaultUnpositionedQueueGroup));
		}
	}
}
