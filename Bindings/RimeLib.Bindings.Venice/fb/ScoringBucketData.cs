///////////////////////////////////////////////////////////////
//                                                           //
// This is an automatically generated file.                  //
// Do *NOT* modify unless you really know what you're doing. //
//                                                           //
///////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Reflection;using RimeLib.Serialization.Attributes;using RimeLib.Serialization.Ebx;using RimeLib.Serialization.Containers;using RimeLib.Frostbite.Core;

namespace fb
{
    [ContainerType(4)]
	public class ScoringBucketData : 
		DataContainer
	{
		[ContainerField(8)]
		public ScoringBucket DestinationBucket { get; set; } = new ScoringBucket(); // 0x8 (8)
		
		[ContainerField(12)]
		public ScoringBucketType BucketType { get; set; } = new ScoringBucketType(); // 0xC (12)
		
		[ContainerField(16), LayoutImmutable]
		public string Name { get; set; } // 0x10 (16)
		
		[ContainerField(20)]
		public CtrRef<ScoringBucketData> TeamTotalBucket { get; set; } = new CtrRef<ScoringBucketData>(); // 0x14 (20)
		
		[ContainerField(24)]
		public List<ScoringBucketUnlockData> Unlocks { get; set; } = new List<ScoringBucketUnlockData>(); // 0x18 (24)
		
		[ContainerField(28)]
		public RefArray<StatsCategoryBaseData> ConnectedCategories { get; set; } = new RefArray<StatsCategoryBaseData>(); // 0x1C (28)
		
		[ContainerField(32), LayoutImmutable, Blittable]
		public bool AddToEntry { get; set; } // 0x20 (32)
		
		[ContainerField(33), LayoutImmutable, Blittable]
		public bool RoundScore { get; set; } // 0x21 (33)
		
		[ContainerField(34), LayoutImmutable, Blittable]
		public bool GlobalScore { get; set; } // 0x22 (34)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 73096151:
					DestinationBucket = (ScoringBucket) Enum.ToObject(typeof(ScoringBucket), p_Value);
					break;

				case 1768841171:
					BucketType = (ScoringBucketType) Enum.ToObject(typeof(ScoringBucketType), p_Value);
					break;

				case 2088949890:
					Name = (string) p_Value;
					break;

				case 2559512116:
					TeamTotalBucket = (CtrRef<ScoringBucketData>) p_Value;
					break;

				case 3464375270:
					Unlocks = (List<ScoringBucketUnlockData>) p_Value;
					break;

				case 3286145740:
					ConnectedCategories = (RefArray<StatsCategoryBaseData>) p_Value;
					break;

				case 3429484907:
					AddToEntry = (bool) p_Value;
					break;

				case 228996879:
					RoundScore = (bool) p_Value;
					break;

				case 3863459110:
					GlobalScore = (bool) p_Value;
					break;

				default:
					base.Bind(p_Descriptor, p_Value);
					break;
			}
		}

		public override object GetFieldValueByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 73096151:
					return DestinationBucket;

				case 1768841171:
					return BucketType;

				case 2088949890:
					return Name;

				case 2559512116:
					return TeamTotalBucket;

				case 3464375270:
					return Unlocks;

				case 3286145740:
					return ConnectedCategories;

				case 3429484907:
					return AddToEntry;

				case 228996879:
					return RoundScore;

				case 3863459110:
					return GlobalScore;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 73096151:
					return typeof(ScoringBucketData).GetProperty(nameof(DestinationBucket));

				case 1768841171:
					return typeof(ScoringBucketData).GetProperty(nameof(BucketType));

				case 2088949890:
					return typeof(ScoringBucketData).GetProperty(nameof(Name));

				case 2559512116:
					return typeof(ScoringBucketData).GetProperty(nameof(TeamTotalBucket));

				case 3464375270:
					return typeof(ScoringBucketData).GetProperty(nameof(Unlocks));

				case 3286145740:
					return typeof(ScoringBucketData).GetProperty(nameof(ConnectedCategories));

				case 3429484907:
					return typeof(ScoringBucketData).GetProperty(nameof(AddToEntry));

				case 228996879:
					return typeof(ScoringBucketData).GetProperty(nameof(RoundScore));

				case 3863459110:
					return typeof(ScoringBucketData).GetProperty(nameof(GlobalScore));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
