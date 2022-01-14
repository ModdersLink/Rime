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
using RimeLib.Serialization.Frostbite2_0.Ebx;

namespace fb
{
	[ContainerType(4, 20)]
	public class PerformanceTrackerSettings :
		SystemSettings
	{
		[ContainerField(12), LayoutImmutable, Blittable, JsonProperty(Order = 12)]
		public float Interval { get; set; }

		[ContainerField(16), LayoutImmutable, Blittable, JsonProperty(Order = 16)]
		public bool Enabled { get; set; }

		[ContainerField(17), LayoutImmutable, Blittable, JsonProperty(Order = 17)]
		public bool SupressPerformanceStatsOnIdle { get; set; }

		[ContainerField(18), LayoutImmutable, Blittable, JsonProperty(Order = 18)]
		public bool SupressPerformanceStatsUntilSpawned { get; set; }

		[ContainerField(19), LayoutImmutable, Blittable, JsonProperty(Order = 19)]
		public bool JuiceLogPerformance { get; set; }

		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			p_Writer.Write(Interval);
			p_Writer.Write(Enabled);
			p_Writer.Write(SupressPerformanceStatsOnIdle);
			p_Writer.Write(SupressPerformanceStatsUntilSpawned);
			p_Writer.Write(JuiceLogPerformance);
		}
	}
}
