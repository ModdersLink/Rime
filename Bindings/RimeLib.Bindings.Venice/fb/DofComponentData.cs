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
	[ContainerType(16, 144)]
	public class DofComponentData : 
		ComponentData
	{
		[ContainerField(96)]
		public Realm Realm { get; set; } = new();

		[ContainerField(100), LayoutImmutable, Blittable]
		public float NearDistanceScale { get; set; }

		[ContainerField(104), LayoutImmutable, Blittable]
		public float FocusDistance { get; set; }

		[ContainerField(108)]
		public BlurFilter BlurFilter { get; set; } = new();

		[ContainerField(112), LayoutImmutable, Blittable]
		public float BlurFilterDeviation { get; set; }

		[ContainerField(116), LayoutImmutable, Blittable]
		public float FarDistanceScale { get; set; }

		[ContainerField(120), LayoutImmutable, Blittable]
		public float BlurAdd { get; set; }

		[ContainerField(124), LayoutImmutable, Blittable]
		public float Scale { get; set; }

		[ContainerField(128), LayoutImmutable, Blittable]
		public float DiffusionDofFocalLength { get; set; }

		[ContainerField(132), LayoutImmutable, Blittable]
		public float DiffusionDofAperture { get; set; }

		[ContainerField(136), LayoutImmutable, Blittable]
		public bool DiffusionDofEnable { get; set; }

		[ContainerField(137), LayoutImmutable, Blittable]
		public bool Enable { get; set; }

	}
}
