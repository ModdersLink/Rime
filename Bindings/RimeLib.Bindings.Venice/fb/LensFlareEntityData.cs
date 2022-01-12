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
	public class LensFlareEntityData : 
		SpatialEntityData
	{
		[ContainerField(80)]
		public List<LensFlareElement> Elements { get; set; } = new();

		[ContainerField(84), LayoutImmutable, Blittable]
		public float OccluderSize { get; set; }

		[ContainerField(88), LayoutImmutable, Blittable]
		public bool Visible { get; set; }

		[ContainerField(89), LayoutImmutable, Blittable]
		public bool HalfRes { get; set; }

		[ContainerField(90), LayoutImmutable, Blittable]
		public bool DebugDrawOccluder { get; set; }

	}
}
