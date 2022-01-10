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
	[ContainerType(4, 40)]
	public class VoiceOverLabelNode : 
		VoiceOverExpressionNode
	{
		[ContainerField(8)]
		public List<CtrRef<VoiceOverLabelSource>> Sources { get; set; } = new();

		[ContainerField(12)]
		public CtrRef<VoiceOverValue> False { get; set; } = new();

		[ContainerField(16)]
		public CtrRef<VoiceOverValue> True { get; set; } = new();

		[ContainerField(20)]
		public List<CtrRef<VoiceOverLabel>> WantedLabels { get; set; } = new();

		[ContainerField(24)]
		public List<CtrRef<VoiceOverLabel>> UnwantedLabels { get; set; } = new();

		[ContainerField(28)]
		public VoiceOverLabelSourceMode SourceMode { get; set; } = new();

		[ContainerField(32)]
		public VoiceOverLabelCompareMode WantedCompareMode { get; set; } = new();

		[ContainerField(36)]
		public VoiceOverLabelCompareMode UnwantedCompareMode { get; set; } = new();

		public static void Deserialize(VoiceOverLabelNode p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.Sources.Clear();
			(RimeReader Reader, uint Count) s_Sources = p_Parser.GetArrayReaderAndElementCount(p_Reader.ReadUInt32());
			for (uint i = 0; i < s_Sources.Count; ++i)
			{
				var s_CtrRef = new CtrRef<VoiceOverLabelSource>();
				s_CtrRef.SetValue(p_Parser.GetImportAtIndex(s_Sources.Reader.ReadUInt32()));
				p_Instance.Sources.Add(s_CtrRef);
			}
			
			s_Sources.Reader.Dispose();
			p_Instance.False.SetValue(p_Parser.GetImportAtIndex(p_Reader.ReadUInt32()));
			p_Instance.True.SetValue(p_Parser.GetImportAtIndex(p_Reader.ReadUInt32()));
			p_Instance.WantedLabels.Clear();
			(RimeReader Reader, uint Count) s_WantedLabels = p_Parser.GetArrayReaderAndElementCount(p_Reader.ReadUInt32());
			for (uint i = 0; i < s_WantedLabels.Count; ++i)
			{
				var s_CtrRef = new CtrRef<VoiceOverLabel>();
				s_CtrRef.SetValue(p_Parser.GetImportAtIndex(s_WantedLabels.Reader.ReadUInt32()));
				p_Instance.WantedLabels.Add(s_CtrRef);
			}
			
			s_WantedLabels.Reader.Dispose();
			p_Instance.UnwantedLabels.Clear();
			(RimeReader Reader, uint Count) s_UnwantedLabels = p_Parser.GetArrayReaderAndElementCount(p_Reader.ReadUInt32());
			for (uint i = 0; i < s_UnwantedLabels.Count; ++i)
			{
				var s_CtrRef = new CtrRef<VoiceOverLabel>();
				s_CtrRef.SetValue(p_Parser.GetImportAtIndex(s_UnwantedLabels.Reader.ReadUInt32()));
				p_Instance.UnwantedLabels.Add(s_CtrRef);
			}
			
			s_UnwantedLabels.Reader.Dispose();
			p_Instance.SourceMode = (VoiceOverLabelSourceMode) p_Reader.ReadInt32();
			p_Instance.WantedCompareMode = (VoiceOverLabelCompareMode) p_Reader.ReadInt32();
			p_Instance.UnwantedCompareMode = (VoiceOverLabelCompareMode) p_Reader.ReadInt32();
		}

	}
}
