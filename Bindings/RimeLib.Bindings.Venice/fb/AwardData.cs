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

namespace fb
{
	[ContainerType(4, 100)]
	public class AwardData : 
		AbstractAwardData
	{
		[ContainerField(12), JsonProperty(Order = 12)]
		public RefArray<AwardData> FilteredChildAwards { get; set; } = new();

		[ContainerField(16), JsonProperty(Order = 16)]
		public RefArray<CriteriaData> Criteria { get; set; } = new();

		[ContainerField(20), LayoutImmutable, JsonProperty(Order = 20)]
		public string Code { get; set; } = string.Empty;

		[ContainerField(24), LayoutImmutable, JsonProperty(Order = 24)]
		public string Description { get; set; } = string.Empty;

		[ContainerField(28), LayoutImmutable, JsonProperty(Order = 28)]
		public string NameSid { get; set; } = string.Empty;

		[ContainerField(32), JsonProperty(Order = 32)]
		public AwardKitAssociation KitAssociation { get; set; } = new();

		[ContainerField(36), LayoutImmutable, JsonProperty(Order = 36)]
		public string ImageName { get; set; } = string.Empty;

		[ContainerField(40), LayoutImmutable, JsonProperty(Order = 40)]
		public string ImageSmallName { get; set; } = string.Empty;

		[ContainerField(44), LayoutImmutable, JsonProperty(Order = 44)]
		public string ImageFancyName { get; set; } = string.Empty;

		[ContainerField(48), LayoutImmutable, JsonProperty(Order = 48)]
		public string SoundName { get; set; } = string.Empty;

		[ContainerField(52), JsonProperty(Order = 52)]
		public AwardType Repeat { get; set; } = new();

		[ContainerField(56), JsonProperty(Order = 56)]
		public List<string> Licenses { get; set; } = new();

		[ContainerField(60), LayoutImmutable, Blittable, JsonProperty(Order = 60)]
		public uint MaxRepetitions { get; set; }

		[ContainerField(64), JsonProperty(Order = 64)]
		public List<CriteriaAward> Dependencies { get; set; } = new();

		[ContainerField(68), JsonProperty(Order = 68)]
		public AwardGroup Group { get; set; } = new();

		[ContainerField(72), JsonProperty(Order = 72)]
		public StatsMultiplicity Multiplicity { get; set; } = new();

		[ContainerField(76), JsonProperty(Order = 76)]
		public CtrRef<CriteriaGateList> UnlockGates { get; set; } = new();

		[ContainerField(80), JsonProperty(Order = 80)]
		public CtrRef<AwardData> ParentAward { get; set; } = new();

		[ContainerField(84), LayoutImmutable, Blittable, JsonProperty(Order = 84)]
		public float Score { get; set; }

		[ContainerField(88), JsonProperty(Order = 88)]
		public ScoringBucket Bucket { get; set; } = new();

		[ContainerField(92), JsonProperty(Order = 92)]
		public List<BasicUnlockInfo> UnlockInfos { get; set; } = new();

		[ContainerField(96), LayoutImmutable, Blittable, JsonProperty(Order = 96)]
		public bool ActiveOnCreation { get; set; }

		[ContainerField(97), LayoutImmutable, Blittable, JsonProperty(Order = 97)]
		public bool Visible { get; set; }

	}
}
