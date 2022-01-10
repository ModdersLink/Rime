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
	[ContainerType(4, 28)]
	public class VoiceOverEventNode : 
		VoiceOverStructureNode
	{
		[ContainerField(12)]
		public CtrRef<VoiceOverIntervalNode> Interval { get; set; } = new();

		[ContainerField(16)]
		public List<CtrRef<VoiceOverStructureNode>> Relationship { get; set; } = new();

		[ContainerField(20)]
		public List<CtrRef<VoiceOverValueRedirect>> Redirects { get; set; } = new();

		[ContainerField(24)]
		public CtrRef<VoiceOverEvent> Event { get; set; } = new();

		public static void Deserialize(VoiceOverEventNode p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.Interval.SetValue(p_Parser.GetImportAtIndex(p_Reader.ReadUInt32()));
			p_Instance.Relationship.Clear();
			(RimeReader Reader, uint Count) s_Relationship = p_Parser.GetArrayReaderAndElementCount(p_Reader.ReadUInt32());
			for (uint i = 0; i < s_Relationship.Count; ++i)
			{
				var s_CtrRef = new CtrRef<VoiceOverStructureNode>();
				s_CtrRef.SetValue(p_Parser.GetImportAtIndex(s_Relationship.Reader.ReadUInt32()));
				p_Instance.Relationship.Add(s_CtrRef);
			}
			
			s_Relationship.Reader.Dispose();
			p_Instance.Redirects.Clear();
			(RimeReader Reader, uint Count) s_Redirects = p_Parser.GetArrayReaderAndElementCount(p_Reader.ReadUInt32());
			for (uint i = 0; i < s_Redirects.Count; ++i)
			{
				var s_CtrRef = new CtrRef<VoiceOverValueRedirect>();
				s_CtrRef.SetValue(p_Parser.GetImportAtIndex(s_Redirects.Reader.ReadUInt32()));
				p_Instance.Redirects.Add(s_CtrRef);
			}
			
			s_Redirects.Reader.Dispose();
			p_Instance.Event.SetValue(p_Parser.GetImportAtIndex(p_Reader.ReadUInt32()));
		}

	}
}
