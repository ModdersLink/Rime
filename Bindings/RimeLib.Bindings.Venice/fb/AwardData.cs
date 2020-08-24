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
	[ContainerType(4), MemberInfoFlag(53), ContainerClass]
	public class AwardData : 
		AbstractAwardData
	{
		protected RefArray<AwardData> m_FilteredChildAwards = new RefArray<AwardData>();
		[ContainerField(12), MemberInfoFlag(65), ContainerFieldNameHash(202729244), ContainerRefArray]
		public RefArray<AwardData> FilteredChildAwards { get { return m_FilteredChildAwards; } set { if (OnPropertyChanging("AwardData." + nameof(FilteredChildAwards), this, m_FilteredChildAwards, value)) m_FilteredChildAwards = value; } } // 0xC (12)
		
		protected RefArray<CriteriaData> m_Criteria = new RefArray<CriteriaData>();
		[ContainerField(16), MemberInfoFlag(65), ContainerFieldNameHash(335452726), ContainerRefArray]
		public RefArray<CriteriaData> Criteria { get { return m_Criteria; } set { if (OnPropertyChanging("AwardData." + nameof(Criteria), this, m_Criteria, value)) m_Criteria = value; } } // 0x10 (16)
		
		protected string m_Code = string.Empty;
		[ContainerField(20), LayoutImmutable, MemberInfoFlag(16509), ContainerFieldNameHash(2088844616)]
		public string Code { get { return m_Code; } set { if (OnPropertyChanging("AwardData." + nameof(Code), this, m_Code, value)) m_Code = value; } } // 0x14 (20)
		
		protected string m_Description = string.Empty;
		[ContainerField(24), LayoutImmutable, MemberInfoFlag(16509), ContainerFieldNameHash(1636673251)]
		public string Description { get { return m_Description; } set { if (OnPropertyChanging("AwardData." + nameof(Description), this, m_Description, value)) m_Description = value; } } // 0x18 (24)
		
		protected string m_NameSid = string.Empty;
		[ContainerField(28), LayoutImmutable, MemberInfoFlag(16509), ContainerFieldNameHash(3153745340)]
		public string NameSid { get { return m_NameSid; } set { if (OnPropertyChanging("AwardData." + nameof(NameSid), this, m_NameSid, value)) m_NameSid = value; } } // 0x1C (28)
		
		protected AwardKitAssociation m_KitAssociation = new AwardKitAssociation();
		[ContainerField(32), MemberInfoFlag(137), ContainerFieldNameHash(2364156266)]
		public AwardKitAssociation KitAssociation { get { return m_KitAssociation; } set { if (OnPropertyChanging("AwardData." + nameof(KitAssociation), this, m_KitAssociation, value)) m_KitAssociation = value; } } // 0x20 (32)
		
		protected string m_ImageName = string.Empty;
		[ContainerField(36), LayoutImmutable, MemberInfoFlag(16509), ContainerFieldNameHash(2678981541)]
		public string ImageName { get { return m_ImageName; } set { if (OnPropertyChanging("AwardData." + nameof(ImageName), this, m_ImageName, value)) m_ImageName = value; } } // 0x24 (36)
		
		protected string m_ImageSmallName = string.Empty;
		[ContainerField(40), LayoutImmutable, MemberInfoFlag(16509), ContainerFieldNameHash(4018906010)]
		public string ImageSmallName { get { return m_ImageSmallName; } set { if (OnPropertyChanging("AwardData." + nameof(ImageSmallName), this, m_ImageSmallName, value)) m_ImageSmallName = value; } } // 0x28 (40)
		
		protected string m_ImageFancyName = string.Empty;
		[ContainerField(44), LayoutImmutable, MemberInfoFlag(16509), ContainerFieldNameHash(2958929910)]
		public string ImageFancyName { get { return m_ImageFancyName; } set { if (OnPropertyChanging("AwardData." + nameof(ImageFancyName), this, m_ImageFancyName, value)) m_ImageFancyName = value; } } // 0x2C (44)
		
		protected string m_SoundName = string.Empty;
		[ContainerField(48), LayoutImmutable, MemberInfoFlag(16509), ContainerFieldNameHash(523979073)]
		public string SoundName { get { return m_SoundName; } set { if (OnPropertyChanging("AwardData." + nameof(SoundName), this, m_SoundName, value)) m_SoundName = value; } } // 0x30 (48)
		
		protected AwardType m_Repeat = new AwardType();
		[ContainerField(52), MemberInfoFlag(137), ContainerFieldNameHash(3293228242)]
		public AwardType Repeat { get { return m_Repeat; } set { if (OnPropertyChanging("AwardData." + nameof(Repeat), this, m_Repeat, value)) m_Repeat = value; } } // 0x34 (52)
		
		protected List<string> m_Licenses = new List<string>();
		[ContainerField(56), MemberInfoFlag(65), ContainerFieldNameHash(2259172461), ContainerArray]
		public List<string> Licenses { get { return m_Licenses; } set { if (OnPropertyChanging("AwardData." + nameof(Licenses), this, m_Licenses, value)) m_Licenses = value; } } // 0x38 (56)
		
		protected uint m_MaxRepetitions = new uint();
		[ContainerField(60), LayoutImmutable, Blittable, MemberInfoFlag(49421), ContainerFieldNameHash(295376865)]
		public uint MaxRepetitions { get { return m_MaxRepetitions; } set { if (OnPropertyChanging("AwardData." + nameof(MaxRepetitions), this, m_MaxRepetitions, value)) m_MaxRepetitions = value; } } // 0x3C (60)
		
		protected List<CriteriaAward> m_Dependencies = new List<CriteriaAward>();
		[ContainerField(64), MemberInfoFlag(65), ContainerFieldNameHash(195928908), ContainerArray]
		public List<CriteriaAward> Dependencies { get { return m_Dependencies; } set { if (OnPropertyChanging("AwardData." + nameof(Dependencies), this, m_Dependencies, value)) m_Dependencies = value; } } // 0x40 (64)
		
		protected AwardGroup m_Group = new AwardGroup();
		[ContainerField(68), MemberInfoFlag(137), ContainerFieldNameHash(208130522)]
		public AwardGroup Group { get { return m_Group; } set { if (OnPropertyChanging("AwardData." + nameof(Group), this, m_Group, value)) m_Group = value; } } // 0x44 (68)
		
		protected StatsMultiplicity m_Multiplicity = new StatsMultiplicity();
		[ContainerField(72), MemberInfoFlag(137), ContainerFieldNameHash(2648087582)]
		public StatsMultiplicity Multiplicity { get { return m_Multiplicity; } set { if (OnPropertyChanging("AwardData." + nameof(Multiplicity), this, m_Multiplicity, value)) m_Multiplicity = value; } } // 0x48 (72)
		
		protected CtrRef<CriteriaGateList> m_UnlockGates = new CtrRef<CriteriaGateList>();
		[ContainerField(76), MemberInfoFlag(53), ContainerFieldNameHash(4138223185), ContainerCtrRef]
		public CtrRef<CriteriaGateList> UnlockGates { get { return m_UnlockGates; } set { if (OnPropertyChanging("AwardData." + nameof(UnlockGates), this, m_UnlockGates, value)) m_UnlockGates = value; } } // 0x4C (76)
		
		protected CtrRef<AwardData> m_ParentAward = new CtrRef<AwardData>();
		[ContainerField(80), MemberInfoFlag(53), ContainerFieldNameHash(2646544440), ContainerCtrRef]
		public CtrRef<AwardData> ParentAward { get { return m_ParentAward; } set { if (OnPropertyChanging("AwardData." + nameof(ParentAward), this, m_ParentAward, value)) m_ParentAward = value; } } // 0x50 (80)
		
		protected float m_Score = new float();
		[ContainerField(84), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(231225165)]
		public float Score { get { return m_Score; } set { if (OnPropertyChanging("AwardData." + nameof(Score), this, m_Score, value)) m_Score = value; } } // 0x54 (84)
		
		protected ScoringBucket m_Bucket = new ScoringBucket();
		[ContainerField(88), MemberInfoFlag(137), ContainerFieldNameHash(2686649899)]
		public ScoringBucket Bucket { get { return m_Bucket; } set { if (OnPropertyChanging("AwardData." + nameof(Bucket), this, m_Bucket, value)) m_Bucket = value; } } // 0x58 (88)
		
		protected List<BasicUnlockInfo> m_UnlockInfos = new List<BasicUnlockInfo>();
		[ContainerField(92), MemberInfoFlag(65), ContainerFieldNameHash(4145033000), ContainerArray]
		public List<BasicUnlockInfo> UnlockInfos { get { return m_UnlockInfos; } set { if (OnPropertyChanging("AwardData." + nameof(UnlockInfos), this, m_UnlockInfos, value)) m_UnlockInfos = value; } } // 0x5C (92)
		
		protected bool m_ActiveOnCreation = new bool();
		[ContainerField(96), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(3093839489)]
		public bool ActiveOnCreation { get { return m_ActiveOnCreation; } set { if (OnPropertyChanging("AwardData." + nameof(ActiveOnCreation), this, m_ActiveOnCreation, value)) m_ActiveOnCreation = value; } } // 0x60 (96)
		
		protected bool m_Visible = new bool();
		[ContainerField(97), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(901540267)]
		public bool Visible { get { return m_Visible; } set { if (OnPropertyChanging("AwardData." + nameof(Visible), this, m_Visible, value)) m_Visible = value; } } // 0x61 (97)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 202729244:
					FilteredChildAwards = (RefArray<AwardData>) p_Value;
					break;

				case 335452726:
					Criteria = (RefArray<CriteriaData>) p_Value;
					break;

				case 2088844616:
					Code = (string) p_Value;
					break;

				case 1636673251:
					Description = (string) p_Value;
					break;

				case 3153745340:
					NameSid = (string) p_Value;
					break;

				case 2364156266:
					KitAssociation = (AwardKitAssociation) Enum.ToObject(typeof(AwardKitAssociation), p_Value);
					break;

				case 2678981541:
					ImageName = (string) p_Value;
					break;

				case 4018906010:
					ImageSmallName = (string) p_Value;
					break;

				case 2958929910:
					ImageFancyName = (string) p_Value;
					break;

				case 523979073:
					SoundName = (string) p_Value;
					break;

				case 3293228242:
					Repeat = (AwardType) Enum.ToObject(typeof(AwardType), p_Value);
					break;

				case 2259172461:
					Licenses = (List<string>) p_Value;
					break;

				case 295376865:
					MaxRepetitions = (uint) p_Value;
					break;

				case 195928908:
					Dependencies = (List<CriteriaAward>) p_Value;
					break;

				case 208130522:
					Group = (AwardGroup) Enum.ToObject(typeof(AwardGroup), p_Value);
					break;

				case 2648087582:
					Multiplicity = (StatsMultiplicity) Enum.ToObject(typeof(StatsMultiplicity), p_Value);
					break;

				case 4138223185:
					UnlockGates = (CtrRef<CriteriaGateList>) p_Value;
					break;

				case 2646544440:
					ParentAward = (CtrRef<AwardData>) p_Value;
					break;

				case 231225165:
					Score = (float) p_Value;
					break;

				case 2686649899:
					Bucket = (ScoringBucket) Enum.ToObject(typeof(ScoringBucket), p_Value);
					break;

				case 4145033000:
					UnlockInfos = (List<BasicUnlockInfo>) p_Value;
					break;

				case 3093839489:
					ActiveOnCreation = (bool) p_Value;
					break;

				case 901540267:
					Visible = (bool) p_Value;
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
				case 202729244:
					return FilteredChildAwards;

				case 335452726:
					return Criteria;

				case 2088844616:
					return Code;

				case 1636673251:
					return Description;

				case 3153745340:
					return NameSid;

				case 2364156266:
					return KitAssociation;

				case 2678981541:
					return ImageName;

				case 4018906010:
					return ImageSmallName;

				case 2958929910:
					return ImageFancyName;

				case 523979073:
					return SoundName;

				case 3293228242:
					return Repeat;

				case 2259172461:
					return Licenses;

				case 295376865:
					return MaxRepetitions;

				case 195928908:
					return Dependencies;

				case 208130522:
					return Group;

				case 2648087582:
					return Multiplicity;

				case 4138223185:
					return UnlockGates;

				case 2646544440:
					return ParentAward;

				case 231225165:
					return Score;

				case 2686649899:
					return Bucket;

				case 4145033000:
					return UnlockInfos;

				case 3093839489:
					return ActiveOnCreation;

				case 901540267:
					return Visible;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 202729244:
					return typeof(AwardData).GetProperty(nameof(FilteredChildAwards));

				case 335452726:
					return typeof(AwardData).GetProperty(nameof(Criteria));

				case 2088844616:
					return typeof(AwardData).GetProperty(nameof(Code));

				case 1636673251:
					return typeof(AwardData).GetProperty(nameof(Description));

				case 3153745340:
					return typeof(AwardData).GetProperty(nameof(NameSid));

				case 2364156266:
					return typeof(AwardData).GetProperty(nameof(KitAssociation));

				case 2678981541:
					return typeof(AwardData).GetProperty(nameof(ImageName));

				case 4018906010:
					return typeof(AwardData).GetProperty(nameof(ImageSmallName));

				case 2958929910:
					return typeof(AwardData).GetProperty(nameof(ImageFancyName));

				case 523979073:
					return typeof(AwardData).GetProperty(nameof(SoundName));

				case 3293228242:
					return typeof(AwardData).GetProperty(nameof(Repeat));

				case 2259172461:
					return typeof(AwardData).GetProperty(nameof(Licenses));

				case 295376865:
					return typeof(AwardData).GetProperty(nameof(MaxRepetitions));

				case 195928908:
					return typeof(AwardData).GetProperty(nameof(Dependencies));

				case 208130522:
					return typeof(AwardData).GetProperty(nameof(Group));

				case 2648087582:
					return typeof(AwardData).GetProperty(nameof(Multiplicity));

				case 4138223185:
					return typeof(AwardData).GetProperty(nameof(UnlockGates));

				case 2646544440:
					return typeof(AwardData).GetProperty(nameof(ParentAward));

				case 231225165:
					return typeof(AwardData).GetProperty(nameof(Score));

				case 2686649899:
					return typeof(AwardData).GetProperty(nameof(Bucket));

				case 4145033000:
					return typeof(AwardData).GetProperty(nameof(UnlockInfos));

				case 3093839489:
					return typeof(AwardData).GetProperty(nameof(ActiveOnCreation));

				case 901540267:
					return typeof(AwardData).GetProperty(nameof(Visible));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
