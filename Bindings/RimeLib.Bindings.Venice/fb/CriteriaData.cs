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
	[ContainerType(Alignment: 4,  Flags: 53, Size: 52)]
	public class CriteriaData : 
		DataContainer
	{
		protected float m_CompletionValue = new float();
		[ContainerField(Name: "CompletionValue", Offset: 8, NameHash: 1987114858, Flags: 49469), LayoutImmutable, Blittable]
		public float CompletionValue { get { return m_CompletionValue; } set { if (OnPropertyChanging("CriteriaData." + nameof(CompletionValue), this, m_CompletionValue, value)) m_CompletionValue = value; } } // 0x8 (8)
		
		protected CtrRef<CriteriaGateList> m_GateList = new CtrRef<CriteriaGateList>();
		[ContainerField(Name: "GateList", Offset: 12, NameHash: 788844496, Flags: 53)]
		public CtrRef<CriteriaGateList> GateList { get { return m_GateList; } set { if (OnPropertyChanging("CriteriaData." + nameof(GateList), this, m_GateList, value)) m_GateList = value; } } // 0xC (12)
		
		protected StatEvent m_Measuring = new StatEvent();
		[ContainerField(Name: "Measuring", Offset: 16, NameHash: 2896657528, Flags: 137)]
		public StatEvent Measuring { get { return m_Measuring; } set { if (OnPropertyChanging("CriteriaData." + nameof(Measuring), this, m_Measuring, value)) m_Measuring = value; } } // 0x10 (16)
		
		protected CtrRef<StatsCategoryBaseData> m_ParamX = new CtrRef<StatsCategoryBaseData>();
		[ContainerField(Name: "ParamX", Offset: 20, NameHash: 3371566706, Flags: 53)]
		public CtrRef<StatsCategoryBaseData> ParamX { get { return m_ParamX; } set { if (OnPropertyChanging("CriteriaData." + nameof(ParamX), this, m_ParamX, value)) m_ParamX = value; } } // 0x14 (20)
		
		protected CtrRef<StatsCategoryBaseData> m_ParamY = new CtrRef<StatsCategoryBaseData>();
		[ContainerField(Name: "ParamY", Offset: 24, NameHash: 3371566707, Flags: 53)]
		public CtrRef<StatsCategoryBaseData> ParamY { get { return m_ParamY; } set { if (OnPropertyChanging("CriteriaData." + nameof(ParamY), this, m_ParamY, value)) m_ParamY = value; } } // 0x18 (24)
		
		protected RefArray<StatsCategoryBaseData> m_OrParamsX = new RefArray<StatsCategoryBaseData>();
		[ContainerField(Name: "OrParamsX", Offset: 28, NameHash: 2810693212, Flags: 65)]
		public RefArray<StatsCategoryBaseData> OrParamsX { get { return m_OrParamsX; } set { if (OnPropertyChanging("CriteriaData." + nameof(OrParamsX), this, m_OrParamsX, value)) m_OrParamsX = value; } } // 0x1C (28)
		
		protected CriteriaType m_CriteriaType = new CriteriaType();
		[ContainerField(Name: "CriteriaType", Offset: 32, NameHash: 3378346126, Flags: 137)]
		public CriteriaType CriteriaType { get { return m_CriteriaType; } set { if (OnPropertyChanging("CriteriaData." + nameof(CriteriaType), this, m_CriteriaType, value)) m_CriteriaType = value; } } // 0x20 (32)
		
		protected string m_DescriptionSid = string.Empty;
		[ContainerField(Name: "DescriptionSid", Offset: 36, NameHash: 1844417789, Flags: 16509), LayoutImmutable]
		public string DescriptionSid { get { return m_DescriptionSid; } set { if (OnPropertyChanging("CriteriaData." + nameof(DescriptionSid), this, m_DescriptionSid, value)) m_DescriptionSid = value; } } // 0x24 (36)
		
		protected float m_ScaleFactor = new float();
		[ContainerField(Name: "ScaleFactor", Offset: 40, NameHash: 4072224560, Flags: 49469), LayoutImmutable, Blittable]
		public float ScaleFactor { get { return m_ScaleFactor; } set { if (OnPropertyChanging("CriteriaData." + nameof(ScaleFactor), this, m_ScaleFactor, value)) m_ScaleFactor = value; } } // 0x28 (40)
		
		protected float m_Scale = new float();
		[ContainerField(Name: "Scale", Offset: 44, NameHash: 231223453, Flags: 49469), LayoutImmutable, Blittable]
		public float Scale { get { return m_Scale; } set { if (OnPropertyChanging("CriteriaData." + nameof(Scale), this, m_Scale, value)) m_Scale = value; } } // 0x2C (44)
		
		protected bool m_ShouldSummarize = new bool();
		[ContainerField(Name: "ShouldSummarize", Offset: 48, NameHash: 2491844207, Flags: 49325), LayoutImmutable, Blittable]
		public bool ShouldSummarize { get { return m_ShouldSummarize; } set { if (OnPropertyChanging("CriteriaData." + nameof(ShouldSummarize), this, m_ShouldSummarize, value)) m_ShouldSummarize = value; } } // 0x30 (48)
		
		protected bool m_ShouldHide = new bool();
		[ContainerField(Name: "ShouldHide", Offset: 49, NameHash: 1866549580, Flags: 49325), LayoutImmutable, Blittable]
		public bool ShouldHide { get { return m_ShouldHide; } set { if (OnPropertyChanging("CriteriaData." + nameof(ShouldHide), this, m_ShouldHide, value)) m_ShouldHide = value; } } // 0x31 (49)
		
		protected bool m_CountEvents = new bool();
		[ContainerField(Name: "CountEvents", Offset: 50, NameHash: 1061148025, Flags: 49325), LayoutImmutable, Blittable]
		public bool CountEvents { get { return m_CountEvents; } set { if (OnPropertyChanging("CriteriaData." + nameof(CountEvents), this, m_CountEvents, value)) m_CountEvents = value; } } // 0x32 (50)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 1987114858:
					CompletionValue = (float) p_Value;
					break;

				case 788844496:
					GateList = (CtrRef<CriteriaGateList>) p_Value;
					break;

				case 2896657528:
					Measuring = (StatEvent) Enum.ToObject(typeof(StatEvent), p_Value);
					break;

				case 3371566706:
					ParamX = (CtrRef<StatsCategoryBaseData>) p_Value;
					break;

				case 3371566707:
					ParamY = (CtrRef<StatsCategoryBaseData>) p_Value;
					break;

				case 2810693212:
					OrParamsX = (RefArray<StatsCategoryBaseData>) p_Value;
					break;

				case 3378346126:
					CriteriaType = (CriteriaType) Enum.ToObject(typeof(CriteriaType), p_Value);
					break;

				case 1844417789:
					DescriptionSid = (string) p_Value;
					break;

				case 4072224560:
					ScaleFactor = (float) p_Value;
					break;

				case 231223453:
					Scale = (float) p_Value;
					break;

				case 2491844207:
					ShouldSummarize = (bool) p_Value;
					break;

				case 1866549580:
					ShouldHide = (bool) p_Value;
					break;

				case 1061148025:
					CountEvents = (bool) p_Value;
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
				case 1987114858:
					return CompletionValue;

				case 788844496:
					return GateList;

				case 2896657528:
					return Measuring;

				case 3371566706:
					return ParamX;

				case 3371566707:
					return ParamY;

				case 2810693212:
					return OrParamsX;

				case 3378346126:
					return CriteriaType;

				case 1844417789:
					return DescriptionSid;

				case 4072224560:
					return ScaleFactor;

				case 231223453:
					return Scale;

				case 2491844207:
					return ShouldSummarize;

				case 1866549580:
					return ShouldHide;

				case 1061148025:
					return CountEvents;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 1987114858:
					return typeof(CriteriaData).GetProperty(nameof(CompletionValue));

				case 788844496:
					return typeof(CriteriaData).GetProperty(nameof(GateList));

				case 2896657528:
					return typeof(CriteriaData).GetProperty(nameof(Measuring));

				case 3371566706:
					return typeof(CriteriaData).GetProperty(nameof(ParamX));

				case 3371566707:
					return typeof(CriteriaData).GetProperty(nameof(ParamY));

				case 2810693212:
					return typeof(CriteriaData).GetProperty(nameof(OrParamsX));

				case 3378346126:
					return typeof(CriteriaData).GetProperty(nameof(CriteriaType));

				case 1844417789:
					return typeof(CriteriaData).GetProperty(nameof(DescriptionSid));

				case 4072224560:
					return typeof(CriteriaData).GetProperty(nameof(ScaleFactor));

				case 231223453:
					return typeof(CriteriaData).GetProperty(nameof(Scale));

				case 2491844207:
					return typeof(CriteriaData).GetProperty(nameof(ShouldSummarize));

				case 1866549580:
					return typeof(CriteriaData).GetProperty(nameof(ShouldHide));

				case 1061148025:
					return typeof(CriteriaData).GetProperty(nameof(CountEvents));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
