///////////////////////////////////////////////////////////////
//                                                           //
// This is an automatically generated file.                  //
// Do *NOT* modify unless you really know what you're doing. //
//                                                           //
///////////////////////////////////////////////////////////////

using System;
using System.Reflection;using RimeLib.Serialization.Attributes;using RimeLib.Serialization.Ebx;using RimeLib.Serialization.Containers;using RimeLib.Frostbite.Core;

namespace fb
{
    [ContainerType(4)]
	public class ScoringTypeData : 
		DataContainer
	{
		[ContainerField(8)]
		public StatEvent Measuring { get; set; } = new StatEvent(); // 0x8 (8)
		
		[ContainerField(12)]
		public CtrRef<StatsCategoryBaseData> ParamX { get; set; } = new CtrRef<StatsCategoryBaseData>(); // 0xC (12)
		
		[ContainerField(16)]
		public CtrRef<StatsCategoryBaseData> ParamY { get; set; } = new CtrRef<StatsCategoryBaseData>(); // 0x10 (16)
		
		[ContainerField(20), LayoutImmutable, Blittable]
		public float Limit { get; set; } // 0x14 (20)
		
		[ContainerField(24), LayoutImmutable]
		public string DescriptionSid { get; set; } // 0x18 (24)
		
		[ContainerField(28)]
		public ScoringVisibilityType VisibilityType { get; set; } = new ScoringVisibilityType(); // 0x1C (28)
		
		[ContainerField(32)]
		public ScoringBucket Bucket { get; set; } = new ScoringBucket(); // 0x20 (32)
		
		[ContainerField(36), LayoutImmutable, Blittable]
		public float Score { get; set; } // 0x24 (36)
		
		[ContainerField(40), LayoutImmutable, Blittable]
		public float AdditionalValueMultiplier { get; set; } // 0x28 (40)
		
		[ContainerField(44), LayoutImmutable, Blittable]
		public bool ShowForTeam { get; set; } // 0x2C (44)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 2896657528:
					Measuring = (StatEvent) Enum.ToObject(typeof(StatEvent), p_Value);
					break;

				case 3371566706:
					ParamX = (CtrRef<StatsCategoryBaseData>) p_Value;
					break;

				case 3371566707:
					ParamY = (CtrRef<StatsCategoryBaseData>) p_Value;
					break;

				case 217831728:
					Limit = (float) p_Value;
					break;

				case 1844417789:
					DescriptionSid = (string) p_Value;
					break;

				case 1714602875:
					VisibilityType = (ScoringVisibilityType) Enum.ToObject(typeof(ScoringVisibilityType), p_Value);
					break;

				case 2686649899:
					Bucket = (ScoringBucket) Enum.ToObject(typeof(ScoringBucket), p_Value);
					break;

				case 231225165:
					Score = (float) p_Value;
					break;

				case 1815918684:
					AdditionalValueMultiplier = (float) p_Value;
					break;

				case 2745690560:
					ShowForTeam = (bool) p_Value;
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
				case 2896657528:
					return Measuring;

				case 3371566706:
					return ParamX;

				case 3371566707:
					return ParamY;

				case 217831728:
					return Limit;

				case 1844417789:
					return DescriptionSid;

				case 1714602875:
					return VisibilityType;

				case 2686649899:
					return Bucket;

				case 231225165:
					return Score;

				case 1815918684:
					return AdditionalValueMultiplier;

				case 2745690560:
					return ShowForTeam;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 2896657528:
					return typeof(ScoringTypeData).GetProperty(nameof(Measuring));

				case 3371566706:
					return typeof(ScoringTypeData).GetProperty(nameof(ParamX));

				case 3371566707:
					return typeof(ScoringTypeData).GetProperty(nameof(ParamY));

				case 217831728:
					return typeof(ScoringTypeData).GetProperty(nameof(Limit));

				case 1844417789:
					return typeof(ScoringTypeData).GetProperty(nameof(DescriptionSid));

				case 1714602875:
					return typeof(ScoringTypeData).GetProperty(nameof(VisibilityType));

				case 2686649899:
					return typeof(ScoringTypeData).GetProperty(nameof(Bucket));

				case 231225165:
					return typeof(ScoringTypeData).GetProperty(nameof(Score));

				case 1815918684:
					return typeof(ScoringTypeData).GetProperty(nameof(AdditionalValueMultiplier));

				case 2745690560:
					return typeof(ScoringTypeData).GetProperty(nameof(ShowForTeam));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
