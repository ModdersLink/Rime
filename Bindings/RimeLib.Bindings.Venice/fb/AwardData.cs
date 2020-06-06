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
	public class AwardData : 
		AbstractAwardData
	{
		[ContainerField(12)]
		public RefArray<AwardData> FilteredChildAwards { get; set; } = new RefArray<AwardData>(); // 0xC (12)
		
		[ContainerField(16)]
		public RefArray<CriteriaData> Criteria { get; set; } = new RefArray<CriteriaData>(); // 0x10 (16)
		
		[ContainerField(20), LayoutImmutable]
		public string Code { get; set; } // 0x14 (20)
		
		[ContainerField(24), LayoutImmutable]
		public string Description { get; set; } // 0x18 (24)
		
		[ContainerField(28), LayoutImmutable]
		public string NameSid { get; set; } // 0x1C (28)
		
		[ContainerField(32)]
		public AwardKitAssociation KitAssociation { get; set; } = new AwardKitAssociation(); // 0x20 (32)
		
		[ContainerField(36), LayoutImmutable]
		public string ImageName { get; set; } // 0x24 (36)
		
		[ContainerField(40), LayoutImmutable]
		public string ImageSmallName { get; set; } // 0x28 (40)
		
		[ContainerField(44), LayoutImmutable]
		public string ImageFancyName { get; set; } // 0x2C (44)
		
		[ContainerField(48), LayoutImmutable]
		public string SoundName { get; set; } // 0x30 (48)
		
		[ContainerField(52)]
		public AwardType Repeat { get; set; } = new AwardType(); // 0x34 (52)
		
		[ContainerField(56)]
		public List<string> Licenses { get; set; } = new List<string>(); // 0x38 (56)
		
		[ContainerField(60), LayoutImmutable, Blittable]
		public uint MaxRepetitions { get; set; } // 0x3C (60)
		
		[ContainerField(64)]
		public List<CriteriaAward> Dependencies { get; set; } = new List<CriteriaAward>(); // 0x40 (64)
		
		[ContainerField(68)]
		public AwardGroup Group { get; set; } = new AwardGroup(); // 0x44 (68)
		
		[ContainerField(72)]
		public StatsMultiplicity Multiplicity { get; set; } = new StatsMultiplicity(); // 0x48 (72)
		
		[ContainerField(76)]
		public CtrRef<CriteriaGateList> UnlockGates { get; set; } = new CtrRef<CriteriaGateList>(); // 0x4C (76)
		
		[ContainerField(80)]
		public CtrRef<AwardData> ParentAward { get; set; } = new CtrRef<AwardData>(); // 0x50 (80)
		
		[ContainerField(84), LayoutImmutable, Blittable]
		public float Score { get; set; } // 0x54 (84)
		
		[ContainerField(88)]
		public ScoringBucket Bucket { get; set; } = new ScoringBucket(); // 0x58 (88)
		
		[ContainerField(92)]
		public List<BasicUnlockInfo> UnlockInfos { get; set; } = new List<BasicUnlockInfo>(); // 0x5C (92)
		
		[ContainerField(96), LayoutImmutable, Blittable]
		public bool ActiveOnCreation { get; set; } // 0x60 (96)
		
		[ContainerField(97), LayoutImmutable, Blittable]
		public bool Visible { get; set; } // 0x61 (97)
		
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
