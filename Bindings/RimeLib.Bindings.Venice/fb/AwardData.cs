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
using RimeLib.Frostbite.Containers;
using RimeLib.Serialization.Ebx;

namespace fb
{
	[ContainerType(Alignment: 4,  Flags: 53, Size: 100)]
	public class AwardData : 
		AbstractAwardData
	{
		protected RefArray<AwardData> m_FilteredChildAwards = new RefArray<AwardData>();
		[ContainerField(Name: "FilteredChildAwards", Offset: 12, NameHash: 202729244, Flags: 65)]
		public RefArray<AwardData> FilteredChildAwards { get { return m_FilteredChildAwards; } set { if (OnPropertyChanging("AwardData." + nameof(FilteredChildAwards), this, m_FilteredChildAwards, value)) m_FilteredChildAwards = value; } } // 0xC (12)
		
		protected RefArray<CriteriaData> m_Criteria = new RefArray<CriteriaData>();
		[ContainerField(Name: "Criteria", Offset: 16, NameHash: 335452726, Flags: 65)]
		public RefArray<CriteriaData> Criteria { get { return m_Criteria; } set { if (OnPropertyChanging("AwardData." + nameof(Criteria), this, m_Criteria, value)) m_Criteria = value; } } // 0x10 (16)
		
		protected string m_Code = string.Empty;
		[ContainerField(Name: "Code", Offset: 20, NameHash: 2088844616, Flags: 16509), LayoutImmutable]
		public string Code { get { return m_Code; } set { if (OnPropertyChanging("AwardData." + nameof(Code), this, m_Code, value)) m_Code = value; } } // 0x14 (20)
		
		protected string m_Description = string.Empty;
		[ContainerField(Name: "Description", Offset: 24, NameHash: 1636673251, Flags: 16509), LayoutImmutable]
		public string Description { get { return m_Description; } set { if (OnPropertyChanging("AwardData." + nameof(Description), this, m_Description, value)) m_Description = value; } } // 0x18 (24)
		
		protected string m_NameSid = string.Empty;
		[ContainerField(Name: "NameSid", Offset: 28, NameHash: 3153745340, Flags: 16509), LayoutImmutable]
		public string NameSid { get { return m_NameSid; } set { if (OnPropertyChanging("AwardData." + nameof(NameSid), this, m_NameSid, value)) m_NameSid = value; } } // 0x1C (28)
		
		protected AwardKitAssociation m_KitAssociation = new AwardKitAssociation();
		[ContainerField(Name: "KitAssociation", Offset: 32, NameHash: 2364156266, Flags: 137)]
		public AwardKitAssociation KitAssociation { get { return m_KitAssociation; } set { if (OnPropertyChanging("AwardData." + nameof(KitAssociation), this, m_KitAssociation, value)) m_KitAssociation = value; } } // 0x20 (32)
		
		protected string m_ImageName = string.Empty;
		[ContainerField(Name: "ImageName", Offset: 36, NameHash: 2678981541, Flags: 16509), LayoutImmutable]
		public string ImageName { get { return m_ImageName; } set { if (OnPropertyChanging("AwardData." + nameof(ImageName), this, m_ImageName, value)) m_ImageName = value; } } // 0x24 (36)
		
		protected string m_ImageSmallName = string.Empty;
		[ContainerField(Name: "ImageSmallName", Offset: 40, NameHash: 4018906010, Flags: 16509), LayoutImmutable]
		public string ImageSmallName { get { return m_ImageSmallName; } set { if (OnPropertyChanging("AwardData." + nameof(ImageSmallName), this, m_ImageSmallName, value)) m_ImageSmallName = value; } } // 0x28 (40)
		
		protected string m_ImageFancyName = string.Empty;
		[ContainerField(Name: "ImageFancyName", Offset: 44, NameHash: 2958929910, Flags: 16509), LayoutImmutable]
		public string ImageFancyName { get { return m_ImageFancyName; } set { if (OnPropertyChanging("AwardData." + nameof(ImageFancyName), this, m_ImageFancyName, value)) m_ImageFancyName = value; } } // 0x2C (44)
		
		protected string m_SoundName = string.Empty;
		[ContainerField(Name: "SoundName", Offset: 48, NameHash: 523979073, Flags: 16509), LayoutImmutable]
		public string SoundName { get { return m_SoundName; } set { if (OnPropertyChanging("AwardData." + nameof(SoundName), this, m_SoundName, value)) m_SoundName = value; } } // 0x30 (48)
		
		protected AwardType m_Repeat = new AwardType();
		[ContainerField(Name: "Repeat", Offset: 52, NameHash: 3293228242, Flags: 137)]
		public AwardType Repeat { get { return m_Repeat; } set { if (OnPropertyChanging("AwardData." + nameof(Repeat), this, m_Repeat, value)) m_Repeat = value; } } // 0x34 (52)
		
		protected List<string> m_Licenses = new List<string>();
		[ContainerField(Name: "Licenses", Offset: 56, NameHash: 2259172461, Flags: 65)]
		public List<string> Licenses { get { return m_Licenses; } set { if (OnPropertyChanging("AwardData." + nameof(Licenses), this, m_Licenses, value)) m_Licenses = value; } } // 0x38 (56)
		
		protected uint m_MaxRepetitions = new uint();
		[ContainerField(Name: "MaxRepetitions", Offset: 60, NameHash: 295376865, Flags: 49421), LayoutImmutable, Blittable]
		public uint MaxRepetitions { get { return m_MaxRepetitions; } set { if (OnPropertyChanging("AwardData." + nameof(MaxRepetitions), this, m_MaxRepetitions, value)) m_MaxRepetitions = value; } } // 0x3C (60)
		
		protected List<CriteriaAward> m_Dependencies = new List<CriteriaAward>();
		[ContainerField(Name: "Dependencies", Offset: 64, NameHash: 195928908, Flags: 65)]
		public List<CriteriaAward> Dependencies { get { return m_Dependencies; } set { if (OnPropertyChanging("AwardData." + nameof(Dependencies), this, m_Dependencies, value)) m_Dependencies = value; } } // 0x40 (64)
		
		protected AwardGroup m_Group = new AwardGroup();
		[ContainerField(Name: "Group", Offset: 68, NameHash: 208130522, Flags: 137)]
		public AwardGroup Group { get { return m_Group; } set { if (OnPropertyChanging("AwardData." + nameof(Group), this, m_Group, value)) m_Group = value; } } // 0x44 (68)
		
		protected StatsMultiplicity m_Multiplicity = new StatsMultiplicity();
		[ContainerField(Name: "Multiplicity", Offset: 72, NameHash: 2648087582, Flags: 137)]
		public StatsMultiplicity Multiplicity { get { return m_Multiplicity; } set { if (OnPropertyChanging("AwardData." + nameof(Multiplicity), this, m_Multiplicity, value)) m_Multiplicity = value; } } // 0x48 (72)
		
		protected CtrRef<CriteriaGateList> m_UnlockGates = new CtrRef<CriteriaGateList>();
		[ContainerField(Name: "UnlockGates", Offset: 76, NameHash: 4138223185, Flags: 53)]
		public CtrRef<CriteriaGateList> UnlockGates { get { return m_UnlockGates; } set { if (OnPropertyChanging("AwardData." + nameof(UnlockGates), this, m_UnlockGates, value)) m_UnlockGates = value; } } // 0x4C (76)
		
		protected CtrRef<AwardData> m_ParentAward = new CtrRef<AwardData>();
		[ContainerField(Name: "ParentAward", Offset: 80, NameHash: 2646544440, Flags: 53)]
		public CtrRef<AwardData> ParentAward { get { return m_ParentAward; } set { if (OnPropertyChanging("AwardData." + nameof(ParentAward), this, m_ParentAward, value)) m_ParentAward = value; } } // 0x50 (80)
		
		protected float m_Score = new float();
		[ContainerField(Name: "Score", Offset: 84, NameHash: 231225165, Flags: 49469), LayoutImmutable, Blittable]
		public float Score { get { return m_Score; } set { if (OnPropertyChanging("AwardData." + nameof(Score), this, m_Score, value)) m_Score = value; } } // 0x54 (84)
		
		protected ScoringBucket m_Bucket = new ScoringBucket();
		[ContainerField(Name: "Bucket", Offset: 88, NameHash: 2686649899, Flags: 137)]
		public ScoringBucket Bucket { get { return m_Bucket; } set { if (OnPropertyChanging("AwardData." + nameof(Bucket), this, m_Bucket, value)) m_Bucket = value; } } // 0x58 (88)
		
		protected List<BasicUnlockInfo> m_UnlockInfos = new List<BasicUnlockInfo>();
		[ContainerField(Name: "UnlockInfos", Offset: 92, NameHash: 4145033000, Flags: 65)]
		public List<BasicUnlockInfo> UnlockInfos { get { return m_UnlockInfos; } set { if (OnPropertyChanging("AwardData." + nameof(UnlockInfos), this, m_UnlockInfos, value)) m_UnlockInfos = value; } } // 0x5C (92)
		
		protected bool m_ActiveOnCreation = new bool();
		[ContainerField(Name: "ActiveOnCreation", Offset: 96, NameHash: 3093839489, Flags: 49325), LayoutImmutable, Blittable]
		public bool ActiveOnCreation { get { return m_ActiveOnCreation; } set { if (OnPropertyChanging("AwardData." + nameof(ActiveOnCreation), this, m_ActiveOnCreation, value)) m_ActiveOnCreation = value; } } // 0x60 (96)
		
		protected bool m_Visible = new bool();
		[ContainerField(Name: "Visible", Offset: 97, NameHash: 901540267, Flags: 49325), LayoutImmutable, Blittable]
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
