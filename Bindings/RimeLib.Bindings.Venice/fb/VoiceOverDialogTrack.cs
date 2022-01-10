///////////////////////////////////////////////////////////////
//                                                           //
// This is an automatically generated file.                  //
// Do *NOT* modify unless you really know what you're doing. //
//                                                           //
///////////////////////////////////////////////////////////////

using System;
using System.IO;
using System.Collections.Generic;
using RimeLib.IO;
using RimeLib.Frostbite.Core;
using RimeLib.Serialization.Attributes;
using RimeLib.Serialization;
using RimeLib.Serialization.Ebx;

namespace fb
{
	[ContainerType(4, 44)]
	public class VoiceOverDialogTrack : 
		DataContainer
	{
		[ContainerField(8)]
		public CtrRef<VoiceOverValueConnection> Source { get; set; } = new();

		[ContainerField(12)]
		public CtrRef<VoiceOverValueConnection> TakeControl { get; set; } = new();

		[ContainerField(16)]
		public List<VoiceOverDialogTakeMapping> TakeIndexMapping { get; set; } = new();

		[ContainerField(20)]
		public VoiceOverDialogTakeBehavior TakeSwitching { get; set; } = new();

		[ContainerField(24)]
		public List<CtrRef<VoiceOverDialogClip>> Clips { get; set; } = new();

		[ContainerField(28)]
		public CtrRef<AudioGraphNodeData> SamplerNode { get; set; } = new();

		[ContainerField(32)]
		public CtrRef<AudioGraphNodeData> Output { get; set; } = new();

		[ContainerField(36)]
		public CtrRef<VoiceOverConversationQueueGroup> QueueGroup { get; set; } = new();

		[ContainerField(40), LayoutImmutable, Blittable]
		public sbyte ParentTrackIndex { get; set; }

		[ContainerField(41), LayoutImmutable, Blittable]
		public bool TakeSwitchingOnResume { get; set; }

		public static void Deserialize(VoiceOverDialogTrack p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.Source.SetValue(p_Parser.GetImportAtIndex(p_Reader.ReadUInt32()));
			p_Instance.TakeControl.SetValue(p_Parser.GetImportAtIndex(p_Reader.ReadUInt32()));
			p_Instance.TakeIndexMapping.Clear();
			(RimeReader Reader, uint Count) s_TakeIndexMapping = p_Parser.GetArrayReaderAndElementCount(p_Reader.ReadUInt32());
			for (uint i = 0; i < s_TakeIndexMapping.Count; ++i)
			{
				var s_Value = new VoiceOverDialogTakeMapping();
				fb.VoiceOverDialogTakeMapping.Deserialize(s_Value, s_TakeIndexMapping.Reader, p_Parser);
				p_Instance.TakeIndexMapping.Add(s_Value);
			}
			
			s_TakeIndexMapping.Reader.Dispose();
			p_Instance.TakeSwitching = (VoiceOverDialogTakeBehavior) p_Reader.ReadInt32();
			p_Instance.Clips.Clear();
			(RimeReader Reader, uint Count) s_Clips = p_Parser.GetArrayReaderAndElementCount(p_Reader.ReadUInt32());
			for (uint i = 0; i < s_Clips.Count; ++i)
			{
				var s_CtrRef = new CtrRef<VoiceOverDialogClip>();
				s_CtrRef.SetValue(p_Parser.GetImportAtIndex(s_Clips.Reader.ReadUInt32()));
				p_Instance.Clips.Add(s_CtrRef);
			}
			
			s_Clips.Reader.Dispose();
			p_Instance.SamplerNode.SetValue(p_Parser.GetImportAtIndex(p_Reader.ReadUInt32()));
			p_Instance.Output.SetValue(p_Parser.GetImportAtIndex(p_Reader.ReadUInt32()));
			p_Instance.QueueGroup.SetValue(p_Parser.GetImportAtIndex(p_Reader.ReadUInt32()));
			p_Instance.ParentTrackIndex = p_Reader.ReadSByte();
			p_Instance.TakeSwitchingOnResume = p_Reader.ReadBool();
			p_Reader.Seek(2, SeekOrigin.Current);
		}

	}
}
