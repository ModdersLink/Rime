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
	[ContainerType(8, 24)]
	public class SurveySuppressedEvent : 
		MetricEvent
	{
		[ContainerField(16), LayoutImmutable, JsonProperty(Order = 16)]
		public string SuppressReason { get; set; } = string.Empty;

	}
}
