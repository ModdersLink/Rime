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
	[ContainerType(16, 128)]
	public class DriverStaticObjectComponentData : 
		DriverComponentData
	{
		[ContainerField(112), LayoutImmutable, Blittable]
		public float Acceleration { get; set; }

		[ContainerField(116), LayoutImmutable, Blittable]
		public float Deceleration { get; set; }

		[ContainerField(120), LayoutImmutable, Blittable]
		public float TurningRadius { get; set; }

		[ContainerField(124), LayoutImmutable, Blittable]
		public bool TurnWhileStill { get; set; }

		[ContainerField(125), LayoutImmutable, Blittable]
		public bool AlignWithGroundNormal { get; set; }

	}
}
