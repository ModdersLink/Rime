///////////////////////////////////////////////////////////////
//                                                           //
// This is an automatically generated file.                  //
// Do *NOT* modify unless you really know what you're doing. //
//                                                           //
///////////////////////////////////////////////////////////////

using RimeLib.IO;
using RimeLib.Frostbite.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel;
using System.Reflection;
using RimeLib.Serialization.Attributes;
using RimeLib.Serialization.Containers;
using RimeLib.Serialization.Ebx;

namespace fb
{
	[ContainerType(4)]
	public class ScoringBucketData : 
		DataContainer
	{
		protected ScoringBucket m_DestinationBucket = new ScoringBucket();
		[ContainerField(8), ContainerFieldNameHash(73096151)]
		public ScoringBucket DestinationBucket { get { return m_DestinationBucket; } set { if (OnPropertyChanging("ScoringBucketData." + nameof(DestinationBucket), this, m_DestinationBucket, value)) m_DestinationBucket = value; } } // 0x8 (8)
		
		protected ScoringBucketType m_BucketType = new ScoringBucketType();
		[ContainerField(12), ContainerFieldNameHash(1768841171)]
		public ScoringBucketType BucketType { get { return m_BucketType; } set { if (OnPropertyChanging("ScoringBucketData." + nameof(BucketType), this, m_BucketType, value)) m_BucketType = value; } } // 0xC (12)
		
		protected string m_Name = new string();
		[ContainerField(16), LayoutImmutable, ContainerFieldNameHash(2088949890)]
		public string Name { get { return m_Name; } set { if (OnPropertyChanging("ScoringBucketData." + nameof(Name), this, m_Name, value)) m_Name = value; } } // 0x10 (16)
		
		protected CtrRef<ScoringBucketData> m_TeamTotalBucket = new CtrRef<ScoringBucketData>();
		[ContainerField(20), ContainerFieldNameHash(2559512116)]
		public CtrRef<ScoringBucketData> TeamTotalBucket { get { return m_TeamTotalBucket; } set { if (OnPropertyChanging("ScoringBucketData." + nameof(TeamTotalBucket), this, m_TeamTotalBucket, value)) m_TeamTotalBucket = value; } } // 0x14 (20)
		
		protected List<ScoringBucketUnlockData> m_Unlocks = new List<ScoringBucketUnlockData>();
		[ContainerField(24), ContainerFieldNameHash(3464375270)]
		public List<ScoringBucketUnlockData> Unlocks { get { return m_Unlocks; } set { if (OnPropertyChanging("ScoringBucketData." + nameof(Unlocks), this, m_Unlocks, value)) m_Unlocks = value; } } // 0x18 (24)
		
		protected RefArray<StatsCategoryBaseData> m_ConnectedCategories = new RefArray<StatsCategoryBaseData>();
		[ContainerField(28), ContainerFieldNameHash(3286145740)]
		public RefArray<StatsCategoryBaseData> ConnectedCategories { get { return m_ConnectedCategories; } set { if (OnPropertyChanging("ScoringBucketData." + nameof(ConnectedCategories), this, m_ConnectedCategories, value)) m_ConnectedCategories = value; } } // 0x1C (28)
		
		protected bool m_AddToEntry = new bool();
		[ContainerField(32), LayoutImmutable, Blittable, ContainerFieldNameHash(3429484907)]
		public bool AddToEntry { get { return m_AddToEntry; } set { if (OnPropertyChanging("ScoringBucketData." + nameof(AddToEntry), this, m_AddToEntry, value)) m_AddToEntry = value; } } // 0x20 (32)
		
		protected bool m_RoundScore = new bool();
		[ContainerField(33), LayoutImmutable, Blittable, ContainerFieldNameHash(228996879)]
		public bool RoundScore { get { return m_RoundScore; } set { if (OnPropertyChanging("ScoringBucketData." + nameof(RoundScore), this, m_RoundScore, value)) m_RoundScore = value; } } // 0x21 (33)
		
		protected bool m_GlobalScore = new bool();
		[ContainerField(34), LayoutImmutable, Blittable, ContainerFieldNameHash(3863459110)]
		public bool GlobalScore { get { return m_GlobalScore; } set { if (OnPropertyChanging("ScoringBucketData." + nameof(GlobalScore), this, m_GlobalScore, value)) m_GlobalScore = value; } } // 0x22 (34)
		
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
