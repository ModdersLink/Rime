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
using CommunityToolkit.Mvvm.ComponentModel;

namespace fb
{
	[ContainerType(4, 56)]
	public partial class VoiceOverSystemAsset :
		Asset
	{
		[ObservableProperty]
		[property: ContainerField(12), JsonProperty(Order = 12)]
		private RefArray<VoiceOverInterval> _Intervals = new();

		[ObservableProperty]
		[property: ContainerField(16), JsonProperty(Order = 16)]
		private RefArray<VoiceOverLabel> _Labels = new();

		[ObservableProperty]
		[property: ContainerField(20), JsonProperty(Order = 20)]
		private RefArray<VoiceOverObject> _Types = new();

		[ObservableProperty]
		[property: ContainerField(24), JsonProperty(Order = 24)]
		private RefArray<VoiceOverObject> _Objects = new();

		[ObservableProperty]
		[property: ContainerField(28), JsonProperty(Order = 28)]
		private RefArray<VoiceOverGlobalConstantValue> _Constants = new();

		[ObservableProperty]
		[property: ContainerField(32), JsonProperty(Order = 32)]
		private CtrRef<AudioLanguage> _MasterLanguage = new();

		[ObservableProperty]
		[property: ContainerField(36), JsonProperty(Order = 36)]
		private CtrRef<VoiceOverPronunciation> _DefaultPronunciation = new();

		[ObservableProperty]
		[property: ContainerField(40), JsonProperty(Order = 40)]
		private RefArray<VoiceOverPronunciation> _Pronunciations = new();

		[ObservableProperty]
		[property: ContainerField(44), JsonProperty(Order = 44)]
		private RefArray<VoiceOverConversationQueueGroup> _QueueGroups = new();

		[ObservableProperty]
		[property: ContainerField(48), JsonProperty(Order = 48)]
		private CtrRef<VoiceOverConversationQueueGroup> _DefaultPositionedQueueGroup = new();

		[ObservableProperty]
		[property: ContainerField(52), JsonProperty(Order = 52)]
		private CtrRef<VoiceOverConversationQueueGroup> _DefaultUnpositionedQueueGroup = new();

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
