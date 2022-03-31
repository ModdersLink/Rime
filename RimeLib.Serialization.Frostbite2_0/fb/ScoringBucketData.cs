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
using RimeLib.Serialization.Frostbite2_0.Ebx;

namespace fb
{
	[ContainerType(4, 36)]
	public class ScoringBucketData :
		DataContainer
	{
		[ContainerField(8), JsonProperty(Order = 8)]
		public ScoringBucket DestinationBucket { get; set; } = new();

		[ContainerField(12), JsonProperty(Order = 12)]
		public ScoringBucketType BucketType { get; set; } = new();

		[ContainerField(16), LayoutImmutable, JsonProperty(Order = 16)]
		public string Name { get; set; } = string.Empty;

		[ContainerField(20), JsonProperty(Order = 20)]
		public CtrRef<ScoringBucketData> TeamTotalBucket { get; set; } = new();

		[ContainerField(24), JsonProperty(Order = 24)]
		public List<ScoringBucketUnlockData> Unlocks { get; set; } = new();

		[ContainerField(28), JsonProperty(Order = 28)]
		public RefArray<StatsCategoryBaseData> ConnectedCategories { get; set; } = new();

		[ContainerField(32), LayoutImmutable, Blittable, JsonProperty(Order = 32)]
		public bool AddToEntry { get; set; }

		[ContainerField(33), LayoutImmutable, Blittable, JsonProperty(Order = 33)]
		public bool RoundScore { get; set; }

		[ContainerField(34), LayoutImmutable, Blittable, JsonProperty(Order = 34)]
		public bool GlobalScore { get; set; }

		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			p_Writer.Write((int) DestinationBucket);
			p_Writer.Write((int) BucketType);
			p_Writer.Write(p_EbxWriter.WriteString(Name));
			p_Writer.Write(p_EbxWriter.WriteImport(TeamTotalBucket));
			(RimeWriter Writer, uint ArrayIndex) s_Unlocks = p_EbxWriter.GetArrayWriter(Unlocks.GetType(), Unlocks.Count);
			p_Writer.Write(s_Unlocks.ArrayIndex);
			foreach (var s_Entry in Unlocks)
			{
				s_Entry.Serialize(s_Unlocks.Writer, p_EbxWriter);
			}
			(RimeWriter Writer, uint ArrayIndex) s_ConnectedCategories = p_EbxWriter.GetArrayWriter(ConnectedCategories.GetType(), ConnectedCategories.Count);
			p_Writer.Write(s_ConnectedCategories.ArrayIndex);
			foreach (var s_Entry in ConnectedCategories)
			{
				s_ConnectedCategories.Writer.Write(p_EbxWriter.WriteImport(s_Entry));
			}
			p_Writer.Write(AddToEntry);
			p_Writer.Write(RoundScore);
			p_Writer.Write(GlobalScore);
			p_Writer.WriteNullBytes(1);
		}
	}
}
