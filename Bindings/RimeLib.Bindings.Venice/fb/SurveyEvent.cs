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
	[ContainerType(8)]
	public class SurveyEvent : 
		MetricEvent
	{
		protected string m_SurveyName = string.Empty;
		[ContainerField(16), LayoutImmutable, ContainerFieldNameHash(261434364)]
		public string SurveyName { get { return m_SurveyName; } set { if (OnPropertyChanging("SurveyEvent." + nameof(SurveyName), this, m_SurveyName, value)) m_SurveyName = value; } } // 0x10 (16)
		
		protected int m_AnswerQuestion1 = new int();
		[ContainerField(20), LayoutImmutable, Blittable, ContainerFieldNameHash(2144258310)]
		public int AnswerQuestion1 { get { return m_AnswerQuestion1; } set { if (OnPropertyChanging("SurveyEvent." + nameof(AnswerQuestion1), this, m_AnswerQuestion1, value)) m_AnswerQuestion1 = value; } } // 0x14 (20)
		
		protected int m_AnswerQuestion2 = new int();
		[ContainerField(24), LayoutImmutable, Blittable, ContainerFieldNameHash(2144258309)]
		public int AnswerQuestion2 { get { return m_AnswerQuestion2; } set { if (OnPropertyChanging("SurveyEvent." + nameof(AnswerQuestion2), this, m_AnswerQuestion2, value)) m_AnswerQuestion2 = value; } } // 0x18 (24)
		
		protected int m_AnswerQuestion3 = new int();
		[ContainerField(28), LayoutImmutable, Blittable, ContainerFieldNameHash(2144258308)]
		public int AnswerQuestion3 { get { return m_AnswerQuestion3; } set { if (OnPropertyChanging("SurveyEvent." + nameof(AnswerQuestion3), this, m_AnswerQuestion3, value)) m_AnswerQuestion3 = value; } } // 0x1C (28)
		
		protected int m_AnswerQuestion4 = new int();
		[ContainerField(32), LayoutImmutable, Blittable, ContainerFieldNameHash(2144258307)]
		public int AnswerQuestion4 { get { return m_AnswerQuestion4; } set { if (OnPropertyChanging("SurveyEvent." + nameof(AnswerQuestion4), this, m_AnswerQuestion4, value)) m_AnswerQuestion4 = value; } } // 0x20 (32)
		
		protected int m_AnswerQuestion5 = new int();
		[ContainerField(36), LayoutImmutable, Blittable, ContainerFieldNameHash(2144258306)]
		public int AnswerQuestion5 { get { return m_AnswerQuestion5; } set { if (OnPropertyChanging("SurveyEvent." + nameof(AnswerQuestion5), this, m_AnswerQuestion5, value)) m_AnswerQuestion5 = value; } } // 0x24 (36)
		
		protected string m_FreeTextField = string.Empty;
		[ContainerField(40), LayoutImmutable, ContainerFieldNameHash(1219116622)]
		public string FreeTextField { get { return m_FreeTextField; } set { if (OnPropertyChanging("SurveyEvent." + nameof(FreeTextField), this, m_FreeTextField, value)) m_FreeTextField = value; } } // 0x28 (40)
		
		protected GUID m_SurveyMetricLink = new GUID();
		[ContainerField(44), LayoutImmutable, Blittable, ContainerFieldNameHash(1497575487)]
		public GUID SurveyMetricLink { get { return m_SurveyMetricLink; } set { if (OnPropertyChanging("SurveyEvent." + nameof(SurveyMetricLink), this, m_SurveyMetricLink, value)) m_SurveyMetricLink = value; } } // 0x2C (44)
		
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
