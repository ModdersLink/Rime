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
	[ContainerType(Alignment: 8,  Flags: 53, Size: 40)]
	public class ReceivedAwardSurveyEvent : 
		MetricEvent
	{
		protected string m_AwardName = string.Empty;
		[ContainerField(Name: "AwardName", Offset: 16, NameHash: 1054881347, Flags: 16509), LayoutImmutable]
		public string AwardName { get { return m_AwardName; } set { if (OnPropertyChanging("ReceivedAwardSurveyEvent." + nameof(AwardName), this, m_AwardName, value)) m_AwardName = value; } } // 0x10 (16)
		
		protected GUID m_SurveyMetricLink = new GUID();
		[ContainerField(Name: "SurveyMetricLink", Offset: 20, NameHash: 1497575487, Flags: 49501), LayoutImmutable, Blittable]
		public GUID SurveyMetricLink { get { return m_SurveyMetricLink; } set { if (OnPropertyChanging("ReceivedAwardSurveyEvent." + nameof(SurveyMetricLink), this, m_SurveyMetricLink, value)) m_SurveyMetricLink = value; } } // 0x14 (20)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 1054881347:
					AwardName = (string) p_Value;
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
				case 1054881347:
					return AwardName;

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
				case 1054881347:
					return typeof(ReceivedAwardSurveyEvent).GetProperty(nameof(AwardName));

				case 1497575487:
					return typeof(ReceivedAwardSurveyEvent).GetProperty(nameof(SurveyMetricLink));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
