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
	public class UICustomizationCompData : 
		UIComponentData
	{
		[ContainerField(32), Homogeneous, LayoutImmutable, Blittable]
		public Vec3 SoldierOffset { get; set; } = new();

		[ContainerField(48), Homogeneous, LayoutImmutable, Blittable]
		public Vec3 SoldierRotation { get; set; } = new();

		[ContainerField(64), Homogeneous, LayoutImmutable, Blittable]
		public Vec3 VehicleRotation { get; set; } = new();

		[ContainerField(80), LayoutImmutable, Blittable]
		public float NetworkThrottleTimer { get; set; }

	}
}
