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
	public class ScoringTypeData : 
		DataContainer
	{
		protected StatEvent m_Measuring = new StatEvent();
		[ContainerField(8), ContainerFieldNameHash(2896657528)]
		public StatEvent Measuring { get { return m_Measuring; } set { if (OnPropertyChanging("ScoringTypeData." + nameof(Measuring), this, m_Measuring, value)) m_Measuring = value; } } // 0x8 (8)
		
		protected CtrRef<StatsCategoryBaseData> m_ParamX = new CtrRef<StatsCategoryBaseData>();
		[ContainerField(12), ContainerFieldNameHash(3371566706)]
		public CtrRef<StatsCategoryBaseData> ParamX { get { return m_ParamX; } set { if (OnPropertyChanging("ScoringTypeData." + nameof(ParamX), this, m_ParamX, value)) m_ParamX = value; } } // 0xC (12)
		
		protected CtrRef<StatsCategoryBaseData> m_ParamY = new CtrRef<StatsCategoryBaseData>();
		[ContainerField(16), ContainerFieldNameHash(3371566707)]
		public CtrRef<StatsCategoryBaseData> ParamY { get { return m_ParamY; } set { if (OnPropertyChanging("ScoringTypeData." + nameof(ParamY), this, m_ParamY, value)) m_ParamY = value; } } // 0x10 (16)
		
		protected float m_Limit = new float();
		[ContainerField(20), LayoutImmutable, Blittable, ContainerFieldNameHash(217831728)]
		public float Limit { get { return m_Limit; } set { if (OnPropertyChanging("ScoringTypeData." + nameof(Limit), this, m_Limit, value)) m_Limit = value; } } // 0x14 (20)
		
		protected string m_DescriptionSid = string.Empty;
		[ContainerField(24), LayoutImmutable, ContainerFieldNameHash(1844417789)]
		public string DescriptionSid { get { return m_DescriptionSid; } set { if (OnPropertyChanging("ScoringTypeData." + nameof(DescriptionSid), this, m_DescriptionSid, value)) m_DescriptionSid = value; } } // 0x18 (24)
		
		protected ScoringVisibilityType m_VisibilityType = new ScoringVisibilityType();
		[ContainerField(28), ContainerFieldNameHash(1714602875)]
		public ScoringVisibilityType VisibilityType { get { return m_VisibilityType; } set { if (OnPropertyChanging("ScoringTypeData." + nameof(VisibilityType), this, m_VisibilityType, value)) m_VisibilityType = value; } } // 0x1C (28)
		
		protected ScoringBucket m_Bucket = new ScoringBucket();
		[ContainerField(32), ContainerFieldNameHash(2686649899)]
		public ScoringBucket Bucket { get { return m_Bucket; } set { if (OnPropertyChanging("ScoringTypeData." + nameof(Bucket), this, m_Bucket, value)) m_Bucket = value; } } // 0x20 (32)
		
		protected float m_Score = new float();
		[ContainerField(36), LayoutImmutable, Blittable, ContainerFieldNameHash(231225165)]
		public float Score { get { return m_Score; } set { if (OnPropertyChanging("ScoringTypeData." + nameof(Score), this, m_Score, value)) m_Score = value; } } // 0x24 (36)
		
		protected float m_AdditionalValueMultiplier = new float();
		[ContainerField(40), LayoutImmutable, Blittable, ContainerFieldNameHash(1815918684)]
		public float AdditionalValueMultiplier { get { return m_AdditionalValueMultiplier; } set { if (OnPropertyChanging("ScoringTypeData." + nameof(AdditionalValueMultiplier), this, m_AdditionalValueMultiplier, value)) m_AdditionalValueMultiplier = value; } } // 0x28 (40)
		
		protected bool m_ShowForTeam = new bool();
		[ContainerField(44), LayoutImmutable, Blittable, ContainerFieldNameHash(2745690560)]
		public bool ShowForTeam { get { return m_ShowForTeam; } set { if (OnPropertyChanging("ScoringTypeData." + nameof(ShowForTeam), this, m_ShowForTeam, value)) m_ShowForTeam = value; } } // 0x2C (44)
		
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
