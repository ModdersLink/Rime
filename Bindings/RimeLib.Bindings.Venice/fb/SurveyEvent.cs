///////////////////////////////////////////////////////////////
//                                                           //
// This is an automatically generated file.                  //
// Do *NOT* modify unless you really know what you're doing. //
//                                                           //
///////////////////////////////////////////////////////////////

using System.Reflection;using RimeLib.Serialization.Attributes;using RimeLib.Serialization.Ebx;using RimeLib.Serialization.Containers;using RimeLib.Frostbite.Core;

namespace fb
{
    [ContainerType(8)]
	public class SurveyEvent : 
		MetricEvent
	{
		[ContainerField(16), LayoutImmutable]
		public string SurveyName { get; set; } // 0x10 (16)
		
		[ContainerField(20), LayoutImmutable, Blittable]
		public int AnswerQuestion1 { get; set; } // 0x14 (20)
		
		[ContainerField(24), LayoutImmutable, Blittable]
		public int AnswerQuestion2 { get; set; } // 0x18 (24)
		
		[ContainerField(28), LayoutImmutable, Blittable]
		public int AnswerQuestion3 { get; set; } // 0x1C (28)
		
		[ContainerField(32), LayoutImmutable, Blittable]
		public int AnswerQuestion4 { get; set; } // 0x20 (32)
		
		[ContainerField(36), LayoutImmutable, Blittable]
		public int AnswerQuestion5 { get; set; } // 0x24 (36)
		
		[ContainerField(40), LayoutImmutable]
		public string FreeTextField { get; set; } // 0x28 (40)
		
		[ContainerField(44), LayoutImmutable, Blittable]
		public GUID SurveyMetricLink { get; set; } // 0x2C (44)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 261434364:
					SurveyName = (string) p_Value;
					break;

				case 2144258310:
					AnswerQuestion1 = (int) p_Value;
					break;

				case 2144258309:
					AnswerQuestion2 = (int) p_Value;
					break;

				case 2144258308:
					AnswerQuestion3 = (int) p_Value;
					break;

				case 2144258307:
					AnswerQuestion4 = (int) p_Value;
					break;

				case 2144258306:
					AnswerQuestion5 = (int) p_Value;
					break;

				case 1219116622:
					FreeTextField = (string) p_Value;
					break;

				case 1497575487:
					SurveyMetricLink = (GUID) p_Value;
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
				case 261434364:
					return SurveyName;

				case 2144258310:
					return AnswerQuestion1;

				case 2144258309:
					return AnswerQuestion2;

				case 2144258308:
					return AnswerQuestion3;

				case 2144258307:
					return AnswerQuestion4;

				case 2144258306:
					return AnswerQuestion5;

				case 1219116622:
					return FreeTextField;

				case 1497575487:
					return SurveyMetricLink;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 261434364:
					return typeof(SurveyEvent).GetProperty(nameof(SurveyName));

				case 2144258310:
					return typeof(SurveyEvent).GetProperty(nameof(AnswerQuestion1));

				case 2144258309:
					return typeof(SurveyEvent).GetProperty(nameof(AnswerQuestion2));

				case 2144258308:
					return typeof(SurveyEvent).GetProperty(nameof(AnswerQuestion3));

				case 2144258307:
					return typeof(SurveyEvent).GetProperty(nameof(AnswerQuestion4));

				case 2144258306:
					return typeof(SurveyEvent).GetProperty(nameof(AnswerQuestion5));

				case 1219116622:
					return typeof(SurveyEvent).GetProperty(nameof(FreeTextField));

				case 1497575487:
					return typeof(SurveyEvent).GetProperty(nameof(SurveyMetricLink));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
