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
using RimeLib.Serialization.Ebx;
using RimeLib.Serialization.Frostbite2_0.Ebx;

namespace fb
{
	[ContainerType(4, 64)]
	public class PlayerTypeProfile :
		Asset
	{
		[ContainerField(12), JsonProperty(Order = 12)]
		public CtrRef<PersistenceData> Values { get; set; } = new();

		[ContainerField(16), JsonProperty(Order = 16)]
		public CtrRef<AwardDataTree> Awards { get; set; } = new();

		[ContainerField(20), JsonProperty(Order = 20)]
		public CtrRef<RankParamsAsset> RankParams { get; set; } = new();

		[ContainerField(24), JsonProperty(Order = 24)]
		public CtrRef<ScoringData> Scoring { get; set; } = new();

		[ContainerField(28), JsonProperty(Order = 28)]
		public CtrRef<DogTagsAsset> DogTags { get; set; } = new();

		[ContainerField(32), JsonProperty(Order = 32)]
		public EloParameters EloParams { get; set; } = new();

		[ContainerField(52), JsonProperty(Order = 52)]
		public CtrRef<StaticUnlockList> StaticUnlocks { get; set; } = new();

		[ContainerField(56), JsonProperty(Order = 56)]
		public CtrRef<StatSpamSettings> SpamSettings { get; set; } = new();

		[ContainerField(60), JsonProperty(Order = 60)]
		public List<string> OrderedUnlockNames { get; set; } = new();

		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			p_Writer.Write(p_EbxWriter.WriteImport(Values));
			p_Writer.Write(p_EbxWriter.WriteImport(Awards));
			p_Writer.Write(p_EbxWriter.WriteImport(RankParams));
			p_Writer.Write(p_EbxWriter.WriteImport(Scoring));
			p_Writer.Write(p_EbxWriter.WriteImport(DogTags));
			EloParams.Serialize(p_Writer, p_EbxWriter);
			p_Writer.Write(p_EbxWriter.WriteImport(StaticUnlocks));
			p_Writer.Write(p_EbxWriter.WriteImport(SpamSettings));
			(RimeWriter Writer, uint ArrayIndex) s_OrderedUnlockNames = p_EbxWriter.GetArrayWriter(OrderedUnlockNames.GetType(), OrderedUnlockNames.Count);
			p_Writer.Write(s_OrderedUnlockNames.ArrayIndex);
			foreach (var s_Entry in OrderedUnlockNames)
			{
				s_OrderedUnlockNames.Writer.Write(p_EbxWriter.WriteString(s_Entry));
			}
		}
	}
}
