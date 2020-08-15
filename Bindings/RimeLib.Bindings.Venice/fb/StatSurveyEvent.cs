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
	public class StatSurveyEvent : 
		MetricEvent
	{
		protected GUID m_SurveyMetricLink = new GUID();
		[ContainerField(16), LayoutImmutable, Blittable, ContainerFieldNameHash(1497575487)]
		public GUID SurveyMetricLink { get { return m_SurveyMetricLink; } set { if (OnPropertyChanging("StatSurveyEvent." + nameof(SurveyMetricLink), this, m_SurveyMetricLink, value)) m_SurveyMetricLink = value; } } // 0x10 (16)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
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
				case 1497575487:
					return typeof(StatSurveyEvent).GetProperty(nameof(SurveyMetricLink));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
