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
	public class AudioGraphData : 
		DataContainer
	{
		[ContainerField(8)]
		public List<CtrRef<AudioGraphNodeData>> Nodes { get; set; } = new();

		[ContainerField(12)]
		public List<CtrRef<AudioGraphParameter>> PublicParameters { get; set; } = new();

		[ContainerField(16)]
		public List<CtrRef<AudioGraphEvent>> PublicEvents { get; set; } = new();

		[ContainerField(20)]
		public List<CtrRef<AudioGraphAssetParameter>> PublicAssetParameters { get; set; } = new();

		[ContainerField(24), LayoutImmutable, Blittable]
		public ushort PublicValueCount { get; set; }

		[ContainerField(26), LayoutImmutable, Blittable]
		public ushort ValueCount { get; set; }

		public static void Deserialize(AudioGraphData p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.Nodes.Clear();
			(RimeReader Reader, uint Count) s_Nodes = p_Parser.GetArrayReaderAndElementCount(p_Reader.ReadUInt32());
			for (uint i = 0; i < s_Nodes.Count; ++i)
			{
				var s_CtrRef = new CtrRef<AudioGraphNodeData>();
				s_CtrRef.SetValue(p_Parser.GetImportAtIndex(s_Nodes.Reader.ReadUInt32()));
				p_Instance.Nodes.Add(s_CtrRef);
			}
			
			s_Nodes.Reader.Dispose();
			p_Instance.PublicParameters.Clear();
			(RimeReader Reader, uint Count) s_PublicParameters = p_Parser.GetArrayReaderAndElementCount(p_Reader.ReadUInt32());
			for (uint i = 0; i < s_PublicParameters.Count; ++i)
			{
				var s_CtrRef = new CtrRef<AudioGraphParameter>();
				s_CtrRef.SetValue(p_Parser.GetImportAtIndex(s_PublicParameters.Reader.ReadUInt32()));
				p_Instance.PublicParameters.Add(s_CtrRef);
			}
			
			s_PublicParameters.Reader.Dispose();
			p_Instance.PublicEvents.Clear();
			(RimeReader Reader, uint Count) s_PublicEvents = p_Parser.GetArrayReaderAndElementCount(p_Reader.ReadUInt32());
			for (uint i = 0; i < s_PublicEvents.Count; ++i)
			{
				var s_CtrRef = new CtrRef<AudioGraphEvent>();
				s_CtrRef.SetValue(p_Parser.GetImportAtIndex(s_PublicEvents.Reader.ReadUInt32()));
				p_Instance.PublicEvents.Add(s_CtrRef);
			}
			
			s_PublicEvents.Reader.Dispose();
			p_Instance.PublicAssetParameters.Clear();
			(RimeReader Reader, uint Count) s_PublicAssetParameters = p_Parser.GetArrayReaderAndElementCount(p_Reader.ReadUInt32());
			for (uint i = 0; i < s_PublicAssetParameters.Count; ++i)
			{
				var s_CtrRef = new CtrRef<AudioGraphAssetParameter>();
				s_CtrRef.SetValue(p_Parser.GetImportAtIndex(s_PublicAssetParameters.Reader.ReadUInt32()));
				p_Instance.PublicAssetParameters.Add(s_CtrRef);
			}
			
			s_PublicAssetParameters.Reader.Dispose();
			p_Instance.PublicValueCount = p_Reader.ReadUInt16();
			p_Instance.ValueCount = p_Reader.ReadUInt16();
		}

	}
}
