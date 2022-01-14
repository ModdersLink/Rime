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
	[ContainerType(4, 36)]
	public class RandomXYZEvaluatorData : 
		EvaluatorData
	{
		[ContainerField(12), LayoutImmutable, Blittable, JsonProperty(Order = 12)]
		public float MaxX { get; set; }

		[ContainerField(16), LayoutImmutable, Blittable, JsonProperty(Order = 16)]
		public float MinX { get; set; }

		[ContainerField(20), LayoutImmutable, Blittable, JsonProperty(Order = 20)]
		public float MaxY { get; set; }

		[ContainerField(24), LayoutImmutable, Blittable, JsonProperty(Order = 24)]
		public float MinY { get; set; }

		[ContainerField(28), LayoutImmutable, Blittable, JsonProperty(Order = 28)]
		public float MaxZ { get; set; }

		[ContainerField(32), LayoutImmutable, Blittable, JsonProperty(Order = 32)]
		public float MinZ { get; set; }

	}
}
