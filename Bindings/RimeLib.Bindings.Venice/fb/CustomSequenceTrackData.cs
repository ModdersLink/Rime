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
	public class CustomSequenceTrackData : 
		EntityData
	{
		[ContainerField(12), LayoutImmutable]
		public string TrackName { get; set; } = string.Empty;

		[ContainerField(16)]
		public List<CtrRef<CustomSequenceTrackLinkMapping>> InputLinkMap { get; set; } = new();

		[ContainerField(20)]
		public List<CtrRef<CustomSequenceTrackLinkMapping>> OutputLinkMap { get; set; } = new();

		[ContainerField(24)]
		public List<CtrRef<CustomSequenceTrackEventMapping>> EventMap { get; set; } = new();

		[ContainerField(28)]
		public List<CtrRef<CustomSequenceTrackPropertyMapping>> SourcePropertyMap { get; set; } = new();

		[ContainerField(32)]
		public List<CtrRef<CustomSequenceTrackPropertyMapping>> TargetPropertyMap { get; set; } = new();

		[ContainerField(36)]
		public List<CtrRef<CustomSequenceTrackPropertyMapping>> SourceAndTargetPropertyMap { get; set; } = new();

		public static void Deserialize(CustomSequenceTrackData p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.TrackName = p_Parser.GetStringAtOffset(p_Reader.ReadUInt32());
			p_Instance.InputLinkMap.Clear();
			(RimeReader Reader, uint Count) s_InputLinkMap = p_Parser.GetArrayReaderAndElementCount(p_Reader.ReadUInt32());
			for (uint i = 0; i < s_InputLinkMap.Count; ++i)
			{
				var s_CtrRef = new CtrRef<CustomSequenceTrackLinkMapping>();
				s_CtrRef.SetValue(p_Parser.GetImportAtIndex(s_InputLinkMap.Reader.ReadUInt32()));
				p_Instance.InputLinkMap.Add(s_CtrRef);
			}
			
			s_InputLinkMap.Reader.Dispose();
			p_Instance.OutputLinkMap.Clear();
			(RimeReader Reader, uint Count) s_OutputLinkMap = p_Parser.GetArrayReaderAndElementCount(p_Reader.ReadUInt32());
			for (uint i = 0; i < s_OutputLinkMap.Count; ++i)
			{
				var s_CtrRef = new CtrRef<CustomSequenceTrackLinkMapping>();
				s_CtrRef.SetValue(p_Parser.GetImportAtIndex(s_OutputLinkMap.Reader.ReadUInt32()));
				p_Instance.OutputLinkMap.Add(s_CtrRef);
			}
			
			s_OutputLinkMap.Reader.Dispose();
			p_Instance.EventMap.Clear();
			(RimeReader Reader, uint Count) s_EventMap = p_Parser.GetArrayReaderAndElementCount(p_Reader.ReadUInt32());
			for (uint i = 0; i < s_EventMap.Count; ++i)
			{
				var s_CtrRef = new CtrRef<CustomSequenceTrackEventMapping>();
				s_CtrRef.SetValue(p_Parser.GetImportAtIndex(s_EventMap.Reader.ReadUInt32()));
				p_Instance.EventMap.Add(s_CtrRef);
			}
			
			s_EventMap.Reader.Dispose();
			p_Instance.SourcePropertyMap.Clear();
			(RimeReader Reader, uint Count) s_SourcePropertyMap = p_Parser.GetArrayReaderAndElementCount(p_Reader.ReadUInt32());
			for (uint i = 0; i < s_SourcePropertyMap.Count; ++i)
			{
				var s_CtrRef = new CtrRef<CustomSequenceTrackPropertyMapping>();
				s_CtrRef.SetValue(p_Parser.GetImportAtIndex(s_SourcePropertyMap.Reader.ReadUInt32()));
				p_Instance.SourcePropertyMap.Add(s_CtrRef);
			}
			
			s_SourcePropertyMap.Reader.Dispose();
			p_Instance.TargetPropertyMap.Clear();
			(RimeReader Reader, uint Count) s_TargetPropertyMap = p_Parser.GetArrayReaderAndElementCount(p_Reader.ReadUInt32());
			for (uint i = 0; i < s_TargetPropertyMap.Count; ++i)
			{
				var s_CtrRef = new CtrRef<CustomSequenceTrackPropertyMapping>();
				s_CtrRef.SetValue(p_Parser.GetImportAtIndex(s_TargetPropertyMap.Reader.ReadUInt32()));
				p_Instance.TargetPropertyMap.Add(s_CtrRef);
			}
			
			s_TargetPropertyMap.Reader.Dispose();
			p_Instance.SourceAndTargetPropertyMap.Clear();
			(RimeReader Reader, uint Count) s_SourceAndTargetPropertyMap = p_Parser.GetArrayReaderAndElementCount(p_Reader.ReadUInt32());
			for (uint i = 0; i < s_SourceAndTargetPropertyMap.Count; ++i)
			{
				var s_CtrRef = new CtrRef<CustomSequenceTrackPropertyMapping>();
				s_CtrRef.SetValue(p_Parser.GetImportAtIndex(s_SourceAndTargetPropertyMap.Reader.ReadUInt32()));
				p_Instance.SourceAndTargetPropertyMap.Add(s_CtrRef);
			}
			
			s_SourceAndTargetPropertyMap.Reader.Dispose();
		}

	}
}
