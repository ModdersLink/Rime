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
	[ContainerType(4, 100)]
	public class HudCameraShakeData : 
		UIComponentData
	{
		[ContainerField(28), LayoutImmutable, Blittable]
		public float WeaponDispersionMin { get; set; }

		[ContainerField(32), LayoutImmutable, Blittable]
		public float WeaponDispersionMax { get; set; }

		[ContainerField(36), LayoutImmutable, Blittable]
		public float WeaponDispersionOffsetScale { get; set; }

		[ContainerField(40), LayoutImmutable, Blittable]
		public float JumpEffectDurationMin { get; set; }

		[ContainerField(44), LayoutImmutable, Blittable]
		public float JumpEffectDurationMax { get; set; }

		[ContainerField(48), LayoutImmutable, Blittable]
		public float JumpEffectMin { get; set; }

		[ContainerField(52), LayoutImmutable, Blittable]
		public float JumpEffectMax { get; set; }

		[ContainerField(56), LayoutImmutable, Blittable]
		public float LandEffectDurationMin { get; set; }

		[ContainerField(60), LayoutImmutable, Blittable]
		public float LandEffectDurationMax { get; set; }

		[ContainerField(64), LayoutImmutable, Blittable]
		public float LandEffectMin { get; set; }

		[ContainerField(68), LayoutImmutable, Blittable]
		public float LandEffectMax { get; set; }

		[ContainerField(72), LayoutImmutable, Blittable]
		public float CameraShakeMinAngle { get; set; }

		[ContainerField(76), LayoutImmutable, Blittable]
		public float CameraShakeMaxAngle { get; set; }

		[ContainerField(80), LayoutImmutable, Blittable]
		public float CameraShakeScale { get; set; }

		[ContainerField(84), LayoutImmutable, Blittable]
		public float WeaponLagXScale { get; set; }

		[ContainerField(88), LayoutImmutable, Blittable]
		public float WeaponLagYScale { get; set; }

		[ContainerField(92), LayoutImmutable, Blittable]
		public uint FilterSize { get; set; }

		[ContainerField(96), LayoutImmutable, Blittable]
		public float MaxDisplacement { get; set; }

	}
}
