///////////////////////////////////////////////////////////////
//                                                           //
// This is an automatically generated file.                  //
// Do *NOT* modify unless you really know what you're doing. //
//                                                           //
///////////////////////////////////////////////////////////////

using System.Collections.Generic;
using System.Reflection;using RimeLib.Serialization.Attributes;using RimeLib.Serialization.Ebx;using RimeLib.Serialization.Containers;using RimeLib.Frostbite.Core;

namespace fb
{
    [ContainerType(4)]
	public class PlayerTypeProfile : 
		Asset
	{
		[ContainerField(12)]
		public CtrRef<PersistenceData> Values { get; set; } = new CtrRef<PersistenceData>(); // 0xC (12)
		
		[ContainerField(16)]
		public CtrRef<AwardDataTree> Awards { get; set; } = new CtrRef<AwardDataTree>(); // 0x10 (16)
		
		[ContainerField(20)]
		public CtrRef<RankParamsAsset> RankParams { get; set; } = new CtrRef<RankParamsAsset>(); // 0x14 (20)
		
		[ContainerField(24)]
		public CtrRef<ScoringData> Scoring { get; set; } = new CtrRef<ScoringData>(); // 0x18 (24)
		
		[ContainerField(28)]
		public CtrRef<DogTagsAsset> DogTags { get; set; } = new CtrRef<DogTagsAsset>(); // 0x1C (28)
		
		[ContainerField(32)]
		public EloParameters EloParams { get; set; } = new EloParameters(); // 0x20 (32)
		
		[ContainerField(52)]
		public CtrRef<StaticUnlockList> StaticUnlocks { get; set; } = new CtrRef<StaticUnlockList>(); // 0x34 (52)
		
		[ContainerField(56)]
		public CtrRef<StatSpamSettings> SpamSettings { get; set; } = new CtrRef<StatSpamSettings>(); // 0x38 (56)
		
		[ContainerField(60)]
		public List<string> OrderedUnlockNames { get; set; } = new List<string>(); // 0x3C (60)
		
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
