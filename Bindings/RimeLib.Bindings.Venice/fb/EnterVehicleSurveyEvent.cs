///////////////////////////////////////////////////////////////
//                                                           //
// This is an automatically generated file.                  //
// Do *NOT* modify unless you really know what you're doing. //
//                                                           //
///////////////////////////////////////////////////////////////

using System;
using System.IO;
using System.Collections.Generic;
using RimeLib.IO;
using RimeLib.Frostbite.Core;
using RimeLib.Serialization.Attributes;
using RimeLib.Serialization;
using RimeLib.Serialization.Ebx;

namespace fb
{
	[ContainerType(8, 40)]
	public class EnterVehicleSurveyEvent : 
		MetricEvent
	{
		[ContainerField(16), LayoutImmutable]
		public string VehicleName { get; set; } = string.Empty;

		[ContainerField(20), LayoutImmutable, Blittable]
		public GUID SurveyMetricLink { get; set; }

	}
}
