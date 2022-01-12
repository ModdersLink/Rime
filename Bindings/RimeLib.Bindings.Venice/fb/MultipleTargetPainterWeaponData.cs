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
	[ContainerType(4, 40)]
	public class MultipleTargetPainterWeaponData : 
		WeaponData
	{
		[ContainerField(16)]
		public SpottingType SpottingBehavior { get; set; } = new();

		[ContainerField(20), LayoutImmutable, Blittable]
		public float TimeObjectIsPainted { get; set; }

		[ContainerField(24), LayoutImmutable, Blittable]
		public float Angle { get; set; }

		[ContainerField(28), LayoutImmutable, Blittable]
		public float TimeObjectIsSpotted { get; set; }

		[ContainerField(32), LayoutImmutable, Blittable]
		public float Range { get; set; }

		[ContainerField(36), LayoutImmutable, Blittable]
		public bool UseSpotting { get; set; }

		[ContainerField(37), LayoutImmutable, Blittable]
		public bool UseLaserPainting { get; set; }

	}
}
