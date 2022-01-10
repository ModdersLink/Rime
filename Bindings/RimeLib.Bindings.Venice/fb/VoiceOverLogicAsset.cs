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
	public class VoiceOverLogicAsset : 
		Asset
	{
		[ContainerField(12)]
		public List<CtrRef<VoiceOverEvent>> Events { get; set; } = new();

		[ContainerField(16)]
		public List<CtrRef<VoiceOverGroup>> Groups { get; set; } = new();

		[ContainerField(20)]
		public List<CtrRef<VoiceOverLogicFlow>> Flows { get; set; } = new();

		[ContainerField(24)]
		public CtrRef<VoiceOverSystemAsset> System { get; set; } = new();

		public static void Deserialize(VoiceOverLogicAsset p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.Events.Clear();
			(RimeReader Reader, uint Count) s_Events = p_Parser.GetArrayReaderAndElementCount(p_Reader.ReadUInt32());
			for (uint i = 0; i < s_Events.Count; ++i)
			{
				var s_CtrRef = new CtrRef<VoiceOverEvent>();
				s_CtrRef.SetValue(p_Parser.GetImportAtIndex(s_Events.Reader.ReadUInt32()));
				p_Instance.Events.Add(s_CtrRef);
			}
			
			s_Events.Reader.Dispose();
			p_Instance.Groups.Clear();
			(RimeReader Reader, uint Count) s_Groups = p_Parser.GetArrayReaderAndElementCount(p_Reader.ReadUInt32());
			for (uint i = 0; i < s_Groups.Count; ++i)
			{
				var s_CtrRef = new CtrRef<VoiceOverGroup>();
				s_CtrRef.SetValue(p_Parser.GetImportAtIndex(s_Groups.Reader.ReadUInt32()));
				p_Instance.Groups.Add(s_CtrRef);
			}
			
			s_Groups.Reader.Dispose();
			p_Instance.Flows.Clear();
			(RimeReader Reader, uint Count) s_Flows = p_Parser.GetArrayReaderAndElementCount(p_Reader.ReadUInt32());
			for (uint i = 0; i < s_Flows.Count; ++i)
			{
				var s_CtrRef = new CtrRef<VoiceOverLogicFlow>();
				s_CtrRef.SetValue(p_Parser.GetImportAtIndex(s_Flows.Reader.ReadUInt32()));
				p_Instance.Flows.Add(s_CtrRef);
			}
			
			s_Flows.Reader.Dispose();
			p_Instance.System.SetValue(p_Parser.GetImportAtIndex(p_Reader.ReadUInt32()));
		}

	}
}
