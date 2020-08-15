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
	public class DebugSurveyEvent : 
		MetricEvent
	{
		protected string m_PlayerName = new string();
		[ContainerField(16), LayoutImmutable, ContainerFieldNameHash(775476977)]
		public string PlayerName { get { return m_PlayerName; } set { if (OnPropertyChanging("DebugSurveyEvent." + nameof(PlayerName), this, m_PlayerName, value)) m_PlayerName = value; } } // 0x10 (16)
		
		protected GUID m_SurveyMetricLink = new GUID();
		[ContainerField(20), LayoutImmutable, Blittable, ContainerFieldNameHash(1497575487)]
		public GUID SurveyMetricLink { get { return m_SurveyMetricLink; } set { if (OnPropertyChanging("DebugSurveyEvent." + nameof(SurveyMetricLink), this, m_SurveyMetricLink, value)) m_SurveyMetricLink = value; } } // 0x14 (20)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 775476977:
					PlayerName = (string) p_Value;
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
				case 775476977:
					return PlayerName;

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
				case 775476977:
					return typeof(DebugSurveyEvent).GetProperty(nameof(PlayerName));

				case 1497575487:
					return typeof(DebugSurveyEvent).GetProperty(nameof(SurveyMetricLink));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
