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
	[ContainerType(4, 36)]
	public class ScoringBucketData : 
		DataContainer
	{
		[ContainerField(8)]
		public ScoringBucket DestinationBucket { get; set; } = new();

		[ContainerField(12)]
		public ScoringBucketType BucketType { get; set; } = new();

		[ContainerField(16), LayoutImmutable]
		public string Name { get; set; } = string.Empty;

		[ContainerField(20)]
		public CtrRef<ScoringBucketData> TeamTotalBucket { get; set; } = new();

		[ContainerField(24)]
		public List<ScoringBucketUnlockData> Unlocks { get; set; } = new();

		[ContainerField(28)]
		public List<CtrRef<StatsCategoryBaseData>> ConnectedCategories { get; set; } = new();

		[ContainerField(32), LayoutImmutable, Blittable]
		public bool AddToEntry { get; set; }

		[ContainerField(33), LayoutImmutable, Blittable]
		public bool RoundScore { get; set; }

		[ContainerField(34), LayoutImmutable, Blittable]
		public bool GlobalScore { get; set; }

		public static void Deserialize(ScoringBucketData p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.DestinationBucket = (ScoringBucket) p_Reader.ReadInt32();
			p_Instance.BucketType = (ScoringBucketType) p_Reader.ReadInt32();
			p_Instance.Name = p_Parser.GetStringAtOffset(p_Reader.ReadUInt32());
			p_Instance.TeamTotalBucket.SetValue(p_Parser.GetImportAtIndex(p_Reader.ReadUInt32()));
			p_Instance.Unlocks.Clear();
			(RimeReader Reader, uint Count) s_Unlocks = p_Parser.GetArrayReaderAndElementCount(p_Reader.ReadUInt32());
			for (uint i = 0; i < s_Unlocks.Count; ++i)
			{
				var s_Value = new ScoringBucketUnlockData();
				fb.ScoringBucketUnlockData.Deserialize(s_Value, s_Unlocks.Reader, p_Parser);
				p_Instance.Unlocks.Add(s_Value);
			}
			
			s_Unlocks.Reader.Dispose();
			p_Instance.ConnectedCategories.Clear();
			(RimeReader Reader, uint Count) s_ConnectedCategories = p_Parser.GetArrayReaderAndElementCount(p_Reader.ReadUInt32());
			for (uint i = 0; i < s_ConnectedCategories.Count; ++i)
			{
				var s_CtrRef = new CtrRef<StatsCategoryBaseData>();
				s_CtrRef.SetValue(p_Parser.GetImportAtIndex(s_ConnectedCategories.Reader.ReadUInt32()));
				p_Instance.ConnectedCategories.Add(s_CtrRef);
			}
			
			s_ConnectedCategories.Reader.Dispose();
			p_Instance.AddToEntry = p_Reader.ReadBool();
			p_Instance.RoundScore = p_Reader.ReadBool();
			p_Instance.GlobalScore = p_Reader.ReadBool();
			p_Reader.Seek(1, SeekOrigin.Current);
		}

	}
}
