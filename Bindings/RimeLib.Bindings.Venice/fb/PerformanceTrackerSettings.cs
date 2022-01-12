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
	[ContainerType(4, 20)]
	public class PerformanceTrackerSettings : 
		SystemSettings
	{
		[ContainerField(12), LayoutImmutable, Blittable]
		public float Interval { get; set; }

		[ContainerField(16), LayoutImmutable, Blittable]
		public bool Enabled { get; set; }

		[ContainerField(17), LayoutImmutable, Blittable]
		public bool SupressPerformanceStatsOnIdle { get; set; }

		[ContainerField(18), LayoutImmutable, Blittable]
		public bool SupressPerformanceStatsUntilSpawned { get; set; }

		[ContainerField(19), LayoutImmutable, Blittable]
		public bool JuiceLogPerformance { get; set; }

	}
}
