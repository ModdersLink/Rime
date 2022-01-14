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
	[ContainerType(16, 144)]
	public class DofComponentData : 
		ComponentData
	{
		[ContainerField(96), JsonProperty(Order = 96)]
		public Realm Realm { get; set; } = new();

		[ContainerField(100), LayoutImmutable, Blittable, JsonProperty(Order = 100)]
		public float NearDistanceScale { get; set; }

		[ContainerField(104), LayoutImmutable, Blittable, JsonProperty(Order = 104)]
		public float FocusDistance { get; set; }

		[ContainerField(108), JsonProperty(Order = 108)]
		public BlurFilter BlurFilter { get; set; } = new();

		[ContainerField(112), LayoutImmutable, Blittable, JsonProperty(Order = 112)]
		public float BlurFilterDeviation { get; set; }

		[ContainerField(116), LayoutImmutable, Blittable, JsonProperty(Order = 116)]
		public float FarDistanceScale { get; set; }

		[ContainerField(120), LayoutImmutable, Blittable, JsonProperty(Order = 120)]
		public float BlurAdd { get; set; }

		[ContainerField(124), LayoutImmutable, Blittable, JsonProperty(Order = 124)]
		public float Scale { get; set; }

		[ContainerField(128), LayoutImmutable, Blittable, JsonProperty(Order = 128)]
		public float DiffusionDofFocalLength { get; set; }

		[ContainerField(132), LayoutImmutable, Blittable, JsonProperty(Order = 132)]
		public float DiffusionDofAperture { get; set; }

		[ContainerField(136), LayoutImmutable, Blittable, JsonProperty(Order = 136)]
		public bool DiffusionDofEnable { get; set; }

		[ContainerField(137), LayoutImmutable, Blittable, JsonProperty(Order = 137)]
		public bool Enable { get; set; }

	}
}
