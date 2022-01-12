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
	[ContainerType(4, 100)]
	public class AwardData : 
		AbstractAwardData
	{
		[ContainerField(12)]
		public RefArray<AwardData> FilteredChildAwards { get; set; } = new();

		[ContainerField(16)]
		public RefArray<CriteriaData> Criteria { get; set; } = new();

		[ContainerField(20), LayoutImmutable]
		public string Code { get; set; } = string.Empty;

		[ContainerField(24), LayoutImmutable]
		public string Description { get; set; } = string.Empty;

		[ContainerField(28), LayoutImmutable]
		public string NameSid { get; set; } = string.Empty;

		[ContainerField(32)]
		public AwardKitAssociation KitAssociation { get; set; } = new();

		[ContainerField(36), LayoutImmutable]
		public string ImageName { get; set; } = string.Empty;

		[ContainerField(40), LayoutImmutable]
		public string ImageSmallName { get; set; } = string.Empty;

		[ContainerField(44), LayoutImmutable]
		public string ImageFancyName { get; set; } = string.Empty;

		[ContainerField(48), LayoutImmutable]
		public string SoundName { get; set; } = string.Empty;

		[ContainerField(52)]
		public AwardType Repeat { get; set; } = new();

		[ContainerField(56)]
		public List<string> Licenses { get; set; } = new();

		[ContainerField(60), LayoutImmutable, Blittable]
		public uint MaxRepetitions { get; set; }

		[ContainerField(64)]
		public List<CriteriaAward> Dependencies { get; set; } = new();

		[ContainerField(68)]
		public AwardGroup Group { get; set; } = new();

		[ContainerField(72)]
		public StatsMultiplicity Multiplicity { get; set; } = new();

		[ContainerField(76)]
		public CtrRef<CriteriaGateList> UnlockGates { get; set; } = new();

		[ContainerField(80)]
		public CtrRef<AwardData> ParentAward { get; set; } = new();

		[ContainerField(84), LayoutImmutable, Blittable]
		public float Score { get; set; }

		[ContainerField(88)]
		public ScoringBucket Bucket { get; set; } = new();

		[ContainerField(92)]
		public List<BasicUnlockInfo> UnlockInfos { get; set; } = new();

		[ContainerField(96), LayoutImmutable, Blittable]
		public bool ActiveOnCreation { get; set; }

		[ContainerField(97), LayoutImmutable, Blittable]
		public bool Visible { get; set; }

	}
}
