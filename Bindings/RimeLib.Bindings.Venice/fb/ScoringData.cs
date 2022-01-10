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
	[ContainerType(4, 24)]
	public class ScoringData : 
		Asset
	{
		[ContainerField(12)]
		public List<CtrRef<ScoringTypeData>> ScoringTypes { get; set; } = new();

		[ContainerField(16)]
		public List<CtrRef<ScoringHandlerData>> ScoringHandlers { get; set; } = new();

		[ContainerField(20)]
		public List<CtrRef<ScoringBucketData>> Buckets { get; set; } = new();

		public static void Deserialize(ScoringData p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.ScoringTypes.Clear();
			(RimeReader Reader, uint Count) s_ScoringTypes = p_Parser.GetArrayReaderAndElementCount(p_Reader.ReadUInt32());
			for (uint i = 0; i < s_ScoringTypes.Count; ++i)
			{
				var s_CtrRef = new CtrRef<ScoringTypeData>();
				s_CtrRef.SetValue(p_Parser.GetImportAtIndex(s_ScoringTypes.Reader.ReadUInt32()));
				p_Instance.ScoringTypes.Add(s_CtrRef);
			}
			
			s_ScoringTypes.Reader.Dispose();
			p_Instance.ScoringHandlers.Clear();
			(RimeReader Reader, uint Count) s_ScoringHandlers = p_Parser.GetArrayReaderAndElementCount(p_Reader.ReadUInt32());
			for (uint i = 0; i < s_ScoringHandlers.Count; ++i)
			{
				var s_CtrRef = new CtrRef<ScoringHandlerData>();
				s_CtrRef.SetValue(p_Parser.GetImportAtIndex(s_ScoringHandlers.Reader.ReadUInt32()));
				p_Instance.ScoringHandlers.Add(s_CtrRef);
			}
			
			s_ScoringHandlers.Reader.Dispose();
			p_Instance.Buckets.Clear();
			(RimeReader Reader, uint Count) s_Buckets = p_Parser.GetArrayReaderAndElementCount(p_Reader.ReadUInt32());
			for (uint i = 0; i < s_Buckets.Count; ++i)
			{
				var s_CtrRef = new CtrRef<ScoringBucketData>();
				s_CtrRef.SetValue(p_Parser.GetImportAtIndex(s_Buckets.Reader.ReadUInt32()));
				p_Instance.Buckets.Add(s_CtrRef);
			}
			
			s_Buckets.Reader.Dispose();
		}

	}
}
