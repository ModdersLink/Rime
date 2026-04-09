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
using CommunityToolkit.Mvvm.ComponentModel;

namespace fb
{
	[ContainerType(4, 64)]
	public partial class PlayerTypeProfile :
		Asset
	{
		[ObservableProperty]
		[property: ContainerField(12), JsonProperty(Order = 12)]
		private CtrRef<PersistenceData> _Values = new();

		[ObservableProperty]
		[property: ContainerField(16), JsonProperty(Order = 16)]
		private CtrRef<AwardDataTree> _Awards = new();

		[ObservableProperty]
		[property: ContainerField(20), JsonProperty(Order = 20)]
		private CtrRef<RankParamsAsset> _RankParams = new();

		[ObservableProperty]
		[property: ContainerField(24), JsonProperty(Order = 24)]
		private CtrRef<ScoringData> _Scoring = new();

		[ObservableProperty]
		[property: ContainerField(28), JsonProperty(Order = 28)]
		private CtrRef<DogTagsAsset> _DogTags = new();

		[ObservableProperty]
		[property: ContainerField(32), JsonProperty(Order = 32)]
		private EloParameters _EloParams = new();

		[ObservableProperty]
		[property: ContainerField(52), JsonProperty(Order = 52)]
		private CtrRef<StaticUnlockList> _StaticUnlocks = new();

		[ObservableProperty]
		[property: ContainerField(56), JsonProperty(Order = 56)]
		private CtrRef<StatSpamSettings> _SpamSettings = new();

		[ObservableProperty]
		[property: ContainerField(60), JsonProperty(Order = 60)]
		private List<string> _OrderedUnlockNames = new();

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
