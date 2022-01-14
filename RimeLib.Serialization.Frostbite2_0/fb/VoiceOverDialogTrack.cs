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
using RimeLib.Serialization.Ebx;
using RimeLib.Serialization.Frostbite2_0.Ebx;

namespace fb
{
	[ContainerType(4, 44)]
	public class VoiceOverDialogTrack :
		DataContainer
	{
		[ContainerField(8), JsonProperty(Order = 8)]
		public CtrRef<VoiceOverValueConnection> Source { get; set; } = new();

		[ContainerField(12), JsonProperty(Order = 12)]
		public CtrRef<VoiceOverValueConnection> TakeControl { get; set; } = new();

		[ContainerField(16), JsonProperty(Order = 16)]
		public List<VoiceOverDialogTakeMapping> TakeIndexMapping { get; set; } = new();

		[ContainerField(20), JsonProperty(Order = 20)]
		public VoiceOverDialogTakeBehavior TakeSwitching { get; set; } = new();

		[ContainerField(24), JsonProperty(Order = 24)]
		public RefArray<VoiceOverDialogClip> Clips { get; set; } = new();

		[ContainerField(28), JsonProperty(Order = 28)]
		public CtrRef<AudioGraphNodeData> SamplerNode { get; set; } = new();

		[ContainerField(32), JsonProperty(Order = 32)]
		public CtrRef<AudioGraphNodeData> Output { get; set; } = new();

		[ContainerField(36), JsonProperty(Order = 36)]
		public CtrRef<VoiceOverConversationQueueGroup> QueueGroup { get; set; } = new();

		[ContainerField(40), LayoutImmutable, Blittable, JsonProperty(Order = 40)]
		public sbyte ParentTrackIndex { get; set; }

		[ContainerField(41), LayoutImmutable, Blittable, JsonProperty(Order = 41)]
		public bool TakeSwitchingOnResume { get; set; }

		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
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
