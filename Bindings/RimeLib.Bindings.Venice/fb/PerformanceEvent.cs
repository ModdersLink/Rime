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
	[ContainerType(16, 96)]
	public class PerformanceEvent : 
		MetricEvent
	{
		[ContainerField(16), Homogeneous, LayoutImmutable, Blittable]
		public Vec3 Position { get; set; } = new();

		[ContainerField(32), LayoutImmutable, Blittable]
		public float FreeCPUMemory { get; set; }

		[ContainerField(36), LayoutImmutable, Blittable]
		public float CPUAverage { get; set; }

		[ContainerField(40), LayoutImmutable, Blittable]
		public float AllocCPUMemory { get; set; }

		[ContainerField(44), LayoutImmutable, Blittable]
		public float FreeGPUMemory { get; set; }

		[ContainerField(48), LayoutImmutable, Blittable]
		public float GPUAverage { get; set; }

		[ContainerField(52), LayoutImmutable, Blittable]
		public int DrawCallCount { get; set; }

		[ContainerField(56), LayoutImmutable, Blittable]
		public int PrimitiveCount { get; set; }

		[ContainerField(60), LayoutImmutable, Blittable]
		public float AllocGPUMemory { get; set; }

		[ContainerField(64), LayoutImmutable]
		public string PerformanceLocation { get; set; } = string.Empty;

		[ContainerField(68), LayoutImmutable, Blittable]
		public GUID PerformanceLink { get; set; }

	}
}
