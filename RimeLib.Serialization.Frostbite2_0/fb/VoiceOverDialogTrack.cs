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
	[ContainerType(4, 44)]
	public partial class VoiceOverDialogTrack :
		DataContainer
	{
		[ObservableProperty]
		[property: ContainerField(8), JsonProperty(Order = 8)]
		private CtrRef<VoiceOverValueConnection> _Source = new();

		[ObservableProperty]
		[property: ContainerField(12), JsonProperty(Order = 12)]
		private CtrRef<VoiceOverValueConnection> _TakeControl = new();

		[ObservableProperty]
		[property: ContainerField(16), JsonProperty(Order = 16)]
		private List<VoiceOverDialogTakeMapping> _TakeIndexMapping = new();

		[ObservableProperty]
		[property: ContainerField(20), JsonProperty(Order = 20)]
		private VoiceOverDialogTakeBehavior _TakeSwitching = new();

		[ObservableProperty]
		[property: ContainerField(24), JsonProperty(Order = 24)]
		private RefArray<VoiceOverDialogClip> _Clips = new();

		[ObservableProperty]
		[property: ContainerField(28), JsonProperty(Order = 28)]
		private CtrRef<AudioGraphNodeData> _SamplerNode = new();

		[ObservableProperty]
		[property: ContainerField(32), JsonProperty(Order = 32)]
		private CtrRef<AudioGraphNodeData> _Output = new();

		[ObservableProperty]
		[property: ContainerField(36), JsonProperty(Order = 36)]
		private CtrRef<VoiceOverConversationQueueGroup> _QueueGroup = new();

		[ObservableProperty]
		[property: ContainerField(40), LayoutImmutable, Blittable, JsonProperty(Order = 40)]
		private sbyte _ParentTrackIndex;

		[ObservableProperty]
		[property: ContainerField(41), LayoutImmutable, Blittable, JsonProperty(Order = 41)]
		private bool _TakeSwitchingOnResume;

		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			p_Writer.WriteNullBytes(8);
			p_Writer.Write(p_EbxWriter.WriteImport(Source));
			p_Writer.Write(p_EbxWriter.WriteImport(TakeControl));
			(RimeWriter Writer, uint ArrayIndex) s_TakeIndexMapping = p_EbxWriter.GetArrayWriter(TakeIndexMapping.GetType(), TakeIndexMapping.Count);
			p_Writer.Write(s_TakeIndexMapping.ArrayIndex);
			foreach (var s_Entry in TakeIndexMapping)
			{
				s_Entry.Serialize(s_TakeIndexMapping.Writer, p_EbxWriter);
			}
			p_Writer.Write((int) TakeSwitching);
			(RimeWriter Writer, uint ArrayIndex) s_Clips = p_EbxWriter.GetArrayWriter(Clips.GetType(), Clips.Count);
			p_Writer.Write(s_Clips.ArrayIndex);
			foreach (var s_Entry in Clips)
			{
				s_Clips.Writer.Write(p_EbxWriter.WriteImport(s_Entry));
			}
			p_Writer.Write(p_EbxWriter.WriteImport(SamplerNode));
			p_Writer.Write(p_EbxWriter.WriteImport(Output));
			p_Writer.Write(p_EbxWriter.WriteImport(QueueGroup));
			p_Writer.Write(ParentTrackIndex);
			p_Writer.Write(TakeSwitchingOnResume);
			p_Writer.WriteNullBytes(2);
		}
	}
}
