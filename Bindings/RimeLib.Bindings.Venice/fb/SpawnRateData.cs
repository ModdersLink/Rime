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
	[ContainerType(16, 64)]
	public class SpawnRateData : 
		ProcessorData
	{
		[ContainerField(48), LayoutImmutable, Blittable, JsonProperty(Order = 48)]
		public float SpawnRate { get; set; }

		[ContainerField(52), LayoutImmutable, Blittable, JsonProperty(Order = 52)]
		public float TrailSegmentLength { get; set; }

		[ContainerField(56), LayoutImmutable, Blittable, JsonProperty(Order = 56)]
		public bool DistributeOverTime { get; set; }

		[ContainerField(57), LayoutImmutable, Blittable, JsonProperty(Order = 57)]
		public bool DistributeOverDistance { get; set; }

	}
}
