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
	[ContainerType(4, 64)]
	public class PlayerTypeProfile : 
		Asset
	{
		[ContainerField(12)]
		public CtrRef<PersistenceData> Values { get; set; } = new();

		[ContainerField(16)]
		public CtrRef<AwardDataTree> Awards { get; set; } = new();

		[ContainerField(20)]
		public CtrRef<RankParamsAsset> RankParams { get; set; } = new();

		[ContainerField(24)]
		public CtrRef<ScoringData> Scoring { get; set; } = new();

		[ContainerField(28)]
		public CtrRef<DogTagsAsset> DogTags { get; set; } = new();

		[ContainerField(32)]
		public EloParameters EloParams { get; set; } = new();

		[ContainerField(52)]
		public CtrRef<StaticUnlockList> StaticUnlocks { get; set; } = new();

		[ContainerField(56)]
		public CtrRef<StatSpamSettings> SpamSettings { get; set; } = new();

		[ContainerField(60)]
		public List<string> OrderedUnlockNames { get; set; } = new();

	}
}
