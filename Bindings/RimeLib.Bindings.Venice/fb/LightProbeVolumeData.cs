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
	[ContainerType(16, 112)]
	public class LightProbeVolumeData : 
		SpatialEntityData
	{
		[ContainerField(80), LayoutImmutable, Blittable]
		public uint Xres { get; set; }

		[ContainerField(84), LayoutImmutable, Blittable]
		public uint Yres { get; set; }

		[ContainerField(88), LayoutImmutable, Blittable]
		public uint Zres { get; set; }

		[ContainerField(92), LayoutImmutable, Blittable]
		public float BlendDistance { get; set; }

		[ContainerField(96), LayoutImmutable, Blittable]
		public int Priority { get; set; }

	}
}
