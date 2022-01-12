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
	[ContainerType(16, 64)]
	public class SpawnRateData : 
		ProcessorData
	{
		[ContainerField(48), LayoutImmutable, Blittable]
		public float SpawnRate { get; set; }

		[ContainerField(52), LayoutImmutable, Blittable]
		public float TrailSegmentLength { get; set; }

		[ContainerField(56), LayoutImmutable, Blittable]
		public bool DistributeOverTime { get; set; }

		[ContainerField(57), LayoutImmutable, Blittable]
		public bool DistributeOverDistance { get; set; }

	}
}
