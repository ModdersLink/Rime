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
	[ContainerType(8, 72)]
	public class FramerateHistogramPerformanceEvent : 
		MetricEvent
	{
		[ContainerField(16), LayoutImmutable, Blittable]
		public float SpikeAverage { get; set; }

		[ContainerField(20), LayoutImmutable, Blittable]
		public float Below5 { get; set; }

		[ContainerField(24), LayoutImmutable, Blittable]
		public float Below10 { get; set; }

		[ContainerField(28), LayoutImmutable, Blittable]
		public float Below15 { get; set; }

		[ContainerField(32), LayoutImmutable, Blittable]
		public float Below20 { get; set; }

		[ContainerField(36), LayoutImmutable, Blittable]
		public float Below25 { get; set; }

		[ContainerField(40), LayoutImmutable, Blittable]
		public float Below30 { get; set; }

		[ContainerField(44), LayoutImmutable, Blittable]
		public float Below60 { get; set; }

		[ContainerField(48), LayoutImmutable, Blittable]
		public float Above60 { get; set; }

		[ContainerField(52), LayoutImmutable, Blittable]
		public GUID PerformanceLink { get; set; }

	}
}
