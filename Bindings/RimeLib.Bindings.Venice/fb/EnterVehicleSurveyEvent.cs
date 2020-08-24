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
	[ContainerType(8), MemberInfoFlag(53), ContainerClass]
	public class EnterVehicleSurveyEvent : 
		MetricEvent
	{
		protected string m_VehicleName = string.Empty;
		[ContainerField(16), LayoutImmutable, MemberInfoFlag(16509), ContainerFieldNameHash(926391226)]
		public string VehicleName { get { return m_VehicleName; } set { if (OnPropertyChanging("EnterVehicleSurveyEvent." + nameof(VehicleName), this, m_VehicleName, value)) m_VehicleName = value; } } // 0x10 (16)
		
		protected GUID m_SurveyMetricLink = new GUID();
		[ContainerField(20), LayoutImmutable, Blittable, MemberInfoFlag(49501), ContainerFieldNameHash(1497575487)]
		public GUID SurveyMetricLink { get { return m_SurveyMetricLink; } set { if (OnPropertyChanging("EnterVehicleSurveyEvent." + nameof(SurveyMetricLink), this, m_SurveyMetricLink, value)) m_SurveyMetricLink = value; } } // 0x14 (20)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 926391226:
					VehicleName = (string) p_Value;
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
				case 926391226:
					return VehicleName;

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
				case 926391226:
					return typeof(EnterVehicleSurveyEvent).GetProperty(nameof(VehicleName));

				case 1497575487:
					return typeof(EnterVehicleSurveyEvent).GetProperty(nameof(SurveyMetricLink));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
