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

using fb.Core;

namespace fb.VeniceShared;

[ContainerType(8, 72)]
public class ScoringBucketData
	: fb.Core.DataContainer
{
	[ContainerField(0x10), LayoutImmutable, Blittable, JsonProperty(Order = 16)]
	public ScoringBucket DestinationBucket { get; set; } = ScoringBucket.ScoringBucket_General;
	
	[ContainerField(0x14), LayoutImmutable, Blittable, JsonProperty(Order = 20)]
	public ScoringBucketType BucketType { get; set; } = ScoringBucketType.ScoringBucketType_Disabled;
	
	[ContainerField(0x18), LayoutImmutable, Blittable, JsonProperty(Order = 24)]
	public string Name { get; set; } = string.Empty;
	
	[ContainerField(0x20), LayoutImmutable, Blittable, JsonProperty(Order = 32)]
	public string RawName { get; set; } = string.Empty;
	
	[ContainerField(0x28), JsonProperty(Order = 40)]
	public List<ScoringBucketUnlockData> Unlocks { get; set; } = new();
	
	[ContainerField(0x30), JsonProperty(Order = 48)]
	public RefArray<StatsCategoryBaseData> ConnectedCategories { get; set; } = new();
	
	[ContainerField(0x38), JsonProperty(Order = 56)]
	public CtrRef<ScoringBucketData> RankBucket { get; set; } = new();
	
	[ContainerField(0x40), LayoutImmutable, Blittable, JsonProperty(Order = 64)]
	public bool RoundScore { get; set; } = false;
	
	[ContainerField(0x41), LayoutImmutable, Blittable, JsonProperty(Order = 65)]
	public bool GlobalScore { get; set; } = false;
	
	[ContainerField(0x42), LayoutImmutable, Blittable, JsonProperty(Order = 66)]
	public bool AddToEntry { get; set; } = false;
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write((int) DestinationBucket);
		p_Writer.Write((int) BucketType);
		p_Writer.Write(p_EbxWriter.WriteString(Name));
		p_Writer.Write(p_EbxWriter.WriteString(RawName));
		(RimeWriter Writer, uint ArrayIndex) s_Unlocks = p_EbxWriter.GetArrayWriter(Unlocks.GetType(), Unlocks.Count);
		p_Writer.Write(s_Unlocks.ArrayIndex);
		foreach (var s_Entry in Unlocks)
		{
			s_Entry.Serialize(s_Unlocks.Writer, p_EbxWriter);
		}
		p_Writer.WriteNullBytes(4);
		(RimeWriter Writer, uint ArrayIndex) s_ConnectedCategories = p_EbxWriter.GetArrayWriter(ConnectedCategories.GetType(), ConnectedCategories.Count);
		p_Writer.Write(s_ConnectedCategories.ArrayIndex);
		foreach (var s_Entry in ConnectedCategories)
		{
			s_ConnectedCategories.Writer.Write(p_EbxWriter.WriteImport(s_Entry));
		}
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(p_EbxWriter.WriteImport(RankBucket));
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(RoundScore);
		p_Writer.Write(GlobalScore);
		p_Writer.Write(AddToEntry);
		p_Writer.WriteNullBytes(5);
	}
}

