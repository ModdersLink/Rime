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
	[ContainerType(16, 80)]
	public class FakeSpringData : 
		FakePhysicsData
	{
		[ContainerField(48), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 48)]
		public Vec3 Direction { get; set; } = new();

		[ContainerField(64), LayoutImmutable, Blittable, JsonProperty(Order = 64)]
		public float Length { get; set; }

		[ContainerField(68), LayoutImmutable, Blittable, JsonProperty(Order = 68)]
		public float Acceleration { get; set; }

		[ContainerField(72), LayoutImmutable, Blittable, JsonProperty(Order = 72)]
		public float ProgressiveExponent { get; set; }

		[ContainerField(76), LayoutImmutable, Blittable, JsonProperty(Order = 76)]
		public float Damping { get; set; }

	}
}
