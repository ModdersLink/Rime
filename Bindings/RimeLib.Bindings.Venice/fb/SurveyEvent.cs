///////////////////////////////////////////////////////////////
//                                                           //
// This is an automatically generated file.                  //
// Do *NOT* modify unless you really know what you're doing. //
//                                                           //
///////////////////////////////////////////////////////////////

using System;
using System.IO;
using System.Collections.Generic;
using Newtonsoft.Json;
using RimeLib.IO;
using RimeLib.Frostbite.Core;
using RimeLib.Serialization.Attributes;
using RimeLib.Serialization;
using RimeLib.Serialization.Ebx;

namespace fb
{
	[ContainerType(8, 64)]
	public class SurveyEvent : 
		MetricEvent
	{
		[ContainerField(16), LayoutImmutable, JsonProperty(Order = 16)]
		public string SurveyName { get; set; } = string.Empty;

		[ContainerField(20), LayoutImmutable, Blittable, JsonProperty(Order = 20)]
		public int AnswerQuestion1 { get; set; }

		[ContainerField(24), LayoutImmutable, Blittable, JsonProperty(Order = 24)]
		public int AnswerQuestion2 { get; set; }

		[ContainerField(28), LayoutImmutable, Blittable, JsonProperty(Order = 28)]
		public int AnswerQuestion3 { get; set; }

		[ContainerField(32), LayoutImmutable, Blittable, JsonProperty(Order = 32)]
		public int AnswerQuestion4 { get; set; }

		[ContainerField(36), LayoutImmutable, Blittable, JsonProperty(Order = 36)]
		public int AnswerQuestion5 { get; set; }

		[ContainerField(40), LayoutImmutable, JsonProperty(Order = 40)]
		public string FreeTextField { get; set; } = string.Empty;

		[ContainerField(44), LayoutImmutable, Blittable, JsonProperty(Order = 44)]
		public GUID SurveyMetricLink { get; set; }

	}
}
