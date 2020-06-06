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
	public class CriteriaData : 
		DataContainer
	{
		[ContainerField(8), LayoutImmutable, Blittable]
		public float CompletionValue { get; set; } // 0x8 (8)
		
		[ContainerField(12)]
		public CtrRef<CriteriaGateList> GateList { get; set; } = new CtrRef<CriteriaGateList>(); // 0xC (12)
		
		[ContainerField(16)]
		public StatEvent Measuring { get; set; } = new StatEvent(); // 0x10 (16)
		
		[ContainerField(20)]
		public CtrRef<StatsCategoryBaseData> ParamX { get; set; } = new CtrRef<StatsCategoryBaseData>(); // 0x14 (20)
		
		[ContainerField(24)]
		public CtrRef<StatsCategoryBaseData> ParamY { get; set; } = new CtrRef<StatsCategoryBaseData>(); // 0x18 (24)
		
		[ContainerField(28)]
		public RefArray<StatsCategoryBaseData> OrParamsX { get; set; } = new RefArray<StatsCategoryBaseData>(); // 0x1C (28)
		
		[ContainerField(32)]
		public CriteriaType CriteriaType { get; set; } = new CriteriaType(); // 0x20 (32)
		
		[ContainerField(36), LayoutImmutable]
		public string DescriptionSid { get; set; } // 0x24 (36)
		
		[ContainerField(40), LayoutImmutable, Blittable]
		public float ScaleFactor { get; set; } // 0x28 (40)
		
		[ContainerField(44), LayoutImmutable, Blittable]
		public float Scale { get; set; } // 0x2C (44)
		
		[ContainerField(48), LayoutImmutable, Blittable]
		public bool ShouldSummarize { get; set; } // 0x30 (48)
		
		[ContainerField(49), LayoutImmutable, Blittable]
		public bool ShouldHide { get; set; } // 0x31 (49)
		
		[ContainerField(50), LayoutImmutable, Blittable]
		public bool CountEvents { get; set; } // 0x32 (50)
		
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
