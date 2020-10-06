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
	[ContainerType(4), MemberInfoFlag(53), ContainerSize(64), ContainerClass]
	public class PlayerTypeProfile : 
		Asset
	{
		protected CtrRef<PersistenceData> m_Values = new CtrRef<PersistenceData>();
		[ContainerField(12), MemberInfoFlag(53), ContainerFieldNameHash(3142410589), ContainerCtrRef]
		public CtrRef<PersistenceData> Values { get { return m_Values; } set { if (OnPropertyChanging("PlayerTypeProfile." + nameof(Values), this, m_Values, value)) m_Values = value; } } // 0xC (12)
		
		protected CtrRef<AwardDataTree> m_Awards = new CtrRef<AwardDataTree>();
		[ContainerField(16), MemberInfoFlag(53), ContainerFieldNameHash(2497987255), ContainerCtrRef]
		public CtrRef<AwardDataTree> Awards { get { return m_Awards; } set { if (OnPropertyChanging("PlayerTypeProfile." + nameof(Awards), this, m_Awards, value)) m_Awards = value; } } // 0x10 (16)
		
		protected CtrRef<RankParamsAsset> m_RankParams = new CtrRef<RankParamsAsset>();
		[ContainerField(20), MemberInfoFlag(53), ContainerFieldNameHash(1481367663), ContainerCtrRef]
		public CtrRef<RankParamsAsset> RankParams { get { return m_RankParams; } set { if (OnPropertyChanging("PlayerTypeProfile." + nameof(RankParams), this, m_RankParams, value)) m_RankParams = value; } } // 0x14 (20)
		
		protected CtrRef<ScoringData> m_Scoring = new CtrRef<ScoringData>();
		[ContainerField(24), MemberInfoFlag(53), ContainerFieldNameHash(2696085640), ContainerCtrRef]
		public CtrRef<ScoringData> Scoring { get { return m_Scoring; } set { if (OnPropertyChanging("PlayerTypeProfile." + nameof(Scoring), this, m_Scoring, value)) m_Scoring = value; } } // 0x18 (24)
		
		protected CtrRef<DogTagsAsset> m_DogTags = new CtrRef<DogTagsAsset>();
		[ContainerField(28), MemberInfoFlag(53), ContainerFieldNameHash(242750408), ContainerCtrRef]
		public CtrRef<DogTagsAsset> DogTags { get { return m_DogTags; } set { if (OnPropertyChanging("PlayerTypeProfile." + nameof(DogTags), this, m_DogTags, value)) m_DogTags = value; } } // 0x1C (28)
		
		protected EloParameters m_EloParams = new EloParameters();
		[ContainerField(32), MemberInfoFlag(41), ContainerFieldNameHash(4149055871)]
		public EloParameters EloParams { get { return m_EloParams; } set { if (OnPropertyChanging("PlayerTypeProfile." + nameof(EloParams), this, m_EloParams, value)) m_EloParams = value; } } // 0x20 (32)
		
		protected CtrRef<StaticUnlockList> m_StaticUnlocks = new CtrRef<StaticUnlockList>();
		[ContainerField(52), MemberInfoFlag(53), ContainerFieldNameHash(1696937534), ContainerCtrRef]
		public CtrRef<StaticUnlockList> StaticUnlocks { get { return m_StaticUnlocks; } set { if (OnPropertyChanging("PlayerTypeProfile." + nameof(StaticUnlocks), this, m_StaticUnlocks, value)) m_StaticUnlocks = value; } } // 0x34 (52)
		
		protected CtrRef<StatSpamSettings> m_SpamSettings = new CtrRef<StatSpamSettings>();
		[ContainerField(56), MemberInfoFlag(53), ContainerFieldNameHash(2878676975), ContainerCtrRef]
		public CtrRef<StatSpamSettings> SpamSettings { get { return m_SpamSettings; } set { if (OnPropertyChanging("PlayerTypeProfile." + nameof(SpamSettings), this, m_SpamSettings, value)) m_SpamSettings = value; } } // 0x38 (56)
		
		protected List<string> m_OrderedUnlockNames = new List<string>();
		[ContainerField(60), MemberInfoFlag(65), ContainerFieldNameHash(3883933262), ContainerArray]
		public List<string> OrderedUnlockNames { get { return m_OrderedUnlockNames; } set { if (OnPropertyChanging("PlayerTypeProfile." + nameof(OrderedUnlockNames), this, m_OrderedUnlockNames, value)) m_OrderedUnlockNames = value; } } // 0x3C (60)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 3142410589:
					Values = (CtrRef<PersistenceData>) p_Value;
					break;

				case 2497987255:
					Awards = (CtrRef<AwardDataTree>) p_Value;
					break;

				case 1481367663:
					RankParams = (CtrRef<RankParamsAsset>) p_Value;
					break;

				case 2696085640:
					Scoring = (CtrRef<ScoringData>) p_Value;
					break;

				case 242750408:
					DogTags = (CtrRef<DogTagsAsset>) p_Value;
					break;

				case 4149055871:
					EloParams = (EloParameters) p_Value;
					break;

				case 1696937534:
					StaticUnlocks = (CtrRef<StaticUnlockList>) p_Value;
					break;

				case 2878676975:
					SpamSettings = (CtrRef<StatSpamSettings>) p_Value;
					break;

				case 3883933262:
					OrderedUnlockNames = (List<string>) p_Value;
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
				case 3142410589:
					return Values;

				case 2497987255:
					return Awards;

				case 1481367663:
					return RankParams;

				case 2696085640:
					return Scoring;

				case 242750408:
					return DogTags;

				case 4149055871:
					return EloParams;

				case 1696937534:
					return StaticUnlocks;

				case 2878676975:
					return SpamSettings;

				case 3883933262:
					return OrderedUnlockNames;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 3142410589:
					return typeof(PlayerTypeProfile).GetProperty(nameof(Values));

				case 2497987255:
					return typeof(PlayerTypeProfile).GetProperty(nameof(Awards));

				case 1481367663:
					return typeof(PlayerTypeProfile).GetProperty(nameof(RankParams));

				case 2696085640:
					return typeof(PlayerTypeProfile).GetProperty(nameof(Scoring));

				case 242750408:
					return typeof(PlayerTypeProfile).GetProperty(nameof(DogTags));

				case 4149055871:
					return typeof(PlayerTypeProfile).GetProperty(nameof(EloParams));

				case 1696937534:
					return typeof(PlayerTypeProfile).GetProperty(nameof(StaticUnlocks));

				case 2878676975:
					return typeof(PlayerTypeProfile).GetProperty(nameof(SpamSettings));

				case 3883933262:
					return typeof(PlayerTypeProfile).GetProperty(nameof(OrderedUnlockNames));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
