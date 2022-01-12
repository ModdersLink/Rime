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
	[ContainerType(16, 80)]
	public class UINametag : 
		DataContainer
	{
		[ContainerField(16), Homogeneous, LayoutImmutable, Blittable]
		public Vec3 TextColor { get; set; } = new();

		[ContainerField(32), LayoutImmutable, Blittable]
		public float IconFadeDistance { get; set; }

		[ContainerField(36), LayoutImmutable, Blittable]
		public float IconMaxDistance { get; set; }

		[ContainerField(40)]
		public UIHudIcon Icon { get; set; } = new();

		[ContainerField(44), LayoutImmutable, Blittable]
		public float TextFadeDistance { get; set; }

		[ContainerField(48), LayoutImmutable, Blittable]
		public float HealthFadeDistance { get; set; }

		[ContainerField(52), LayoutImmutable, Blittable]
		public float HealthMaxDistance { get; set; }

		[ContainerField(56), LayoutImmutable, Blittable]
		public float TextMaxDistance { get; set; }

		[ContainerField(60), LayoutImmutable, Blittable]
		public float TargetInTimer { get; set; }

		[ContainerField(64), LayoutImmutable, Blittable]
		public float TargetOutTimer { get; set; }

	}
}
