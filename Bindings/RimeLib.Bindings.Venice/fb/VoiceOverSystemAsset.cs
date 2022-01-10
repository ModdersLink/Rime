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
	[ContainerType(4, 56)]
	public class VoiceOverSystemAsset : 
		Asset
	{
		[ContainerField(12)]
		public List<CtrRef<VoiceOverInterval>> Intervals { get; set; } = new();

		[ContainerField(16)]
		public List<CtrRef<VoiceOverLabel>> Labels { get; set; } = new();

		[ContainerField(20)]
		public List<CtrRef<VoiceOverObject>> Types { get; set; } = new();

		[ContainerField(24)]
		public List<CtrRef<VoiceOverObject>> Objects { get; set; } = new();

		[ContainerField(28)]
		public List<CtrRef<VoiceOverGlobalConstantValue>> Constants { get; set; } = new();

		[ContainerField(32)]
		public CtrRef<AudioLanguage> MasterLanguage { get; set; } = new();

		[ContainerField(36)]
		public CtrRef<VoiceOverPronunciation> DefaultPronunciation { get; set; } = new();

		[ContainerField(40)]
		public List<CtrRef<VoiceOverPronunciation>> Pronunciations { get; set; } = new();

		[ContainerField(44)]
		public List<CtrRef<VoiceOverConversationQueueGroup>> QueueGroups { get; set; } = new();

		[ContainerField(48)]
		public CtrRef<VoiceOverConversationQueueGroup> DefaultPositionedQueueGroup { get; set; } = new();

		[ContainerField(52)]
		public CtrRef<VoiceOverConversationQueueGroup> DefaultUnpositionedQueueGroup { get; set; } = new();

		public static void Deserialize(VoiceOverSystemAsset p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.Intervals.Clear();
			(RimeReader Reader, uint Count) s_Intervals = p_Parser.GetArrayReaderAndElementCount(p_Reader.ReadUInt32());
			for (uint i = 0; i < s_Intervals.Count; ++i)
			{
				var s_CtrRef = new CtrRef<VoiceOverInterval>();
				s_CtrRef.SetValue(p_Parser.GetImportAtIndex(s_Intervals.Reader.ReadUInt32()));
				p_Instance.Intervals.Add(s_CtrRef);
			}
			
			s_Intervals.Reader.Dispose();
			p_Instance.Labels.Clear();
			(RimeReader Reader, uint Count) s_Labels = p_Parser.GetArrayReaderAndElementCount(p_Reader.ReadUInt32());
			for (uint i = 0; i < s_Labels.Count; ++i)
			{
				var s_CtrRef = new CtrRef<VoiceOverLabel>();
				s_CtrRef.SetValue(p_Parser.GetImportAtIndex(s_Labels.Reader.ReadUInt32()));
				p_Instance.Labels.Add(s_CtrRef);
			}
			
			s_Labels.Reader.Dispose();
			p_Instance.Types.Clear();
			(RimeReader Reader, uint Count) s_Types = p_Parser.GetArrayReaderAndElementCount(p_Reader.ReadUInt32());
			for (uint i = 0; i < s_Types.Count; ++i)
			{
				var s_CtrRef = new CtrRef<VoiceOverObject>();
				s_CtrRef.SetValue(p_Parser.GetImportAtIndex(s_Types.Reader.ReadUInt32()));
				p_Instance.Types.Add(s_CtrRef);
			}
			
			s_Types.Reader.Dispose();
			p_Instance.Objects.Clear();
			(RimeReader Reader, uint Count) s_Objects = p_Parser.GetArrayReaderAndElementCount(p_Reader.ReadUInt32());
			for (uint i = 0; i < s_Objects.Count; ++i)
			{
				var s_CtrRef = new CtrRef<VoiceOverObject>();
				s_CtrRef.SetValue(p_Parser.GetImportAtIndex(s_Objects.Reader.ReadUInt32()));
				p_Instance.Objects.Add(s_CtrRef);
			}
			
			s_Objects.Reader.Dispose();
			p_Instance.Constants.Clear();
			(RimeReader Reader, uint Count) s_Constants = p_Parser.GetArrayReaderAndElementCount(p_Reader.ReadUInt32());
			for (uint i = 0; i < s_Constants.Count; ++i)
			{
				var s_CtrRef = new CtrRef<VoiceOverGlobalConstantValue>();
				s_CtrRef.SetValue(p_Parser.GetImportAtIndex(s_Constants.Reader.ReadUInt32()));
				p_Instance.Constants.Add(s_CtrRef);
			}
			
			s_Constants.Reader.Dispose();
			p_Instance.MasterLanguage.SetValue(p_Parser.GetImportAtIndex(p_Reader.ReadUInt32()));
			p_Instance.DefaultPronunciation.SetValue(p_Parser.GetImportAtIndex(p_Reader.ReadUInt32()));
			p_Instance.Pronunciations.Clear();
			(RimeReader Reader, uint Count) s_Pronunciations = p_Parser.GetArrayReaderAndElementCount(p_Reader.ReadUInt32());
			for (uint i = 0; i < s_Pronunciations.Count; ++i)
			{
				var s_CtrRef = new CtrRef<VoiceOverPronunciation>();
				s_CtrRef.SetValue(p_Parser.GetImportAtIndex(s_Pronunciations.Reader.ReadUInt32()));
				p_Instance.Pronunciations.Add(s_CtrRef);
			}
			
			s_Pronunciations.Reader.Dispose();
			p_Instance.QueueGroups.Clear();
			(RimeReader Reader, uint Count) s_QueueGroups = p_Parser.GetArrayReaderAndElementCount(p_Reader.ReadUInt32());
			for (uint i = 0; i < s_QueueGroups.Count; ++i)
			{
				var s_CtrRef = new CtrRef<VoiceOverConversationQueueGroup>();
				s_CtrRef.SetValue(p_Parser.GetImportAtIndex(s_QueueGroups.Reader.ReadUInt32()));
				p_Instance.QueueGroups.Add(s_CtrRef);
			}
			
			s_QueueGroups.Reader.Dispose();
			p_Instance.DefaultPositionedQueueGroup.SetValue(p_Parser.GetImportAtIndex(p_Reader.ReadUInt32()));
			p_Instance.DefaultUnpositionedQueueGroup.SetValue(p_Parser.GetImportAtIndex(p_Reader.ReadUInt32()));
		}

	}
}
