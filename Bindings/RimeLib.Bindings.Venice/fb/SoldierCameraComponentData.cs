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
	public class SoldierCameraComponentData : 
		ComponentData
	{
		[ContainerField(96), LayoutImmutable, Blittable]
		public float ExplosionImpulseMultiplier { get; set; }

		[ContainerField(100), LayoutImmutable, Blittable]
		public float StrafeTiltStrength { get; set; }

		[ContainerField(104), LayoutImmutable, Blittable]
		public float PitchTiltStrength { get; set; }

		[ContainerField(108)]
		public RefArray<TargetCameraData> Cameras { get; set; } = new();

		[ContainerField(112)]
		public CameraBinding CameraBinding { get; set; } = new();

		[ContainerField(120), LayoutImmutable, Blittable]
		public float ForceFieldOfView { get; set; }

		[ContainerField(124), LayoutImmutable, Blittable]
		public bool AuthoritativeEyePosition { get; set; }

		[ContainerField(125), LayoutImmutable, Blittable]
		public bool DisableAiming { get; set; }

	}
}
