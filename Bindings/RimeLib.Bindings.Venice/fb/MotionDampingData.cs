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
	[ContainerType(16, 48)]
	public class MotionDampingData : 
		DataContainer
	{
		[ContainerField(16), Homogeneous, LayoutImmutable, Blittable]
		public Vec3 LinearModifier { get; set; } = new();

		[ContainerField(32), LayoutImmutable, Blittable]
		public float Pitch { get; set; }

		[ContainerField(36), LayoutImmutable, Blittable]
		public float Yaw { get; set; }

		[ContainerField(40), LayoutImmutable, Blittable]
		public float Roll { get; set; }

		[ContainerField(44), LayoutImmutable, Blittable]
		public float Linear { get; set; }

	}
}
