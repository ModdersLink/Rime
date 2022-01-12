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
	[ContainerType(16, 224)]
	public class CameraComponentData : 
		ComponentData
	{
		[ContainerField(96), Homogeneous, LayoutImmutable, Blittable]
		public Vec3 CameraTransitionPos { get; set; } = new();

		[ContainerField(112), LayoutImmutable, Blittable]
		public float FieldOfView { get; set; }

		[ContainerField(116), LayoutImmutable, Blittable]
		public float ForceFieldOfView { get; set; }

		[ContainerField(120)]
		public CtrRef<TargetCameraData> Camera { get; set; } = new();

		[ContainerField(124)]
		public CtrRef<AlternateCameraViewData> AlternateView { get; set; } = new();

		[ContainerField(128)]
		public RegularCameraViewData RegularView { get; set; } = new();

		[ContainerField(176), LayoutImmutable, Blittable]
		public float FreezeHeight { get; set; }

		[ContainerField(180)]
		public StanceCameraData StanceData { get; set; } = new();

		[ContainerField(188)]
		public CtrRef<CameraComponentSoundData> CameraSoundData { get; set; } = new();

		[ContainerField(192)]
		public SoldierAnimatedCameraData SoldierAnimatedCamera { get; set; } = new();

		[ContainerField(200), LayoutImmutable, Blittable]
		public float CameraTransitionTime { get; set; }

		[ContainerField(204), LayoutImmutable, Blittable]
		public uint MeshParentComponentNumber { get; set; }

		[ContainerField(208), LayoutImmutable, Blittable]
		public bool EnableCameraMesh { get; set; }

		[ContainerField(209), LayoutImmutable, Blittable]
		public bool ReceiveImpulsesAsThirdPerson { get; set; }

		[ContainerField(210), LayoutImmutable, Blittable]
		public bool UseCameraTransition { get; set; }

		[ContainerField(211), LayoutImmutable, Blittable]
		public bool AlternateViewEnabled { get; set; }

		[ContainerField(212), LayoutImmutable, Blittable]
		public bool IsFirstPerson { get; set; }

		[ContainerField(213), LayoutImmutable, Blittable]
		public bool IgnoreOwnerOrientation { get; set; }

	}
}
