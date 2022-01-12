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
	[ContainerType(8, 56)]
	public class PerformanceProfileState : 
		MetricState
	{
		[ContainerField(24), LayoutImmutable, Blittable]
		public uint ProcessorCount { get; set; }

		[ContainerField(28), LayoutImmutable, Blittable]
		public uint ProcessorCoreCount { get; set; }

		[ContainerField(32), LayoutImmutable, Blittable]
		public uint ProcessorClock { get; set; }

		[ContainerField(36), LayoutImmutable, Blittable]
		public uint TotalMemMB { get; set; }

		[ContainerField(40), LayoutImmutable, Blittable]
		public uint GpuMemMB { get; set; }

		[ContainerField(44), LayoutImmutable]
		public string GraphicAdapterName { get; set; } = string.Empty;

		[ContainerField(48), LayoutImmutable]
		public string Platform { get; set; } = string.Empty;

	}
}
