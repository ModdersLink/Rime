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
		public RefArray<StatsCategoryBaseData> ConnectedCategories { get; set; } = new();

		[ContainerField(32), LayoutImmutable, Blittable]
		public bool AddToEntry { get; set; }

		[ContainerField(33), LayoutImmutable, Blittable]
		public bool RoundScore { get; set; }

		[ContainerField(34), LayoutImmutable, Blittable]
		public bool GlobalScore { get; set; }

	}
}
