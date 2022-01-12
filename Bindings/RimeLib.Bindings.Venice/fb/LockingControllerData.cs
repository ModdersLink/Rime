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
	[ContainerType(4, 64)]
	public class LockingControllerData : 
		DataContainer
	{
		[ContainerField(8)]
		public List<ZoomLevelLockData> ZoomLevelLock { get; set; } = new();

		[ContainerField(12), LayoutImmutable, Blittable]
		public float LockTime { get; set; }

		[ContainerField(16), LayoutImmutable, Blittable]
		public float ReleaseTime { get; set; }

		[ContainerField(20), LayoutImmutable, Blittable]
		public float ReleaseOnNewTargetTime { get; set; }

		[ContainerField(24), LayoutImmutable, Blittable]
		public float SampleRate { get; set; }

		[ContainerField(28), LayoutImmutable, Blittable]
		public float HoldStillThreshold { get; set; }

		[ContainerField(32), LayoutImmutable, Blittable]
		public float RayLength { get; set; }

		[ContainerField(36), LayoutImmutable, Blittable]
		public float AcceptanceAngle { get; set; }

		[ContainerField(40), LayoutImmutable, Blittable]
		public float MinimumLockTime { get; set; }

		[ContainerField(44), LayoutImmutable, Blittable]
		public float Sensitivity { get; set; }

		[ContainerField(48), LayoutImmutable, Blittable]
		public float AngleConstant { get; set; }

		[ContainerField(52), LayoutImmutable, Blittable]
		public float DistanceConstant { get; set; }

		[ContainerField(56), LayoutImmutable, Blittable]
		public bool LockOnWorldSpacePos { get; set; }

		[ContainerField(57), LayoutImmutable, Blittable]
		public bool LockOnVisibleTargetsOnly { get; set; }

		[ContainerField(58), LayoutImmutable, Blittable]
		public bool PositionOnly { get; set; }

		[ContainerField(59), LayoutImmutable, Blittable]
		public bool LockOnEmptyVehicles { get; set; }

		[ContainerField(60), LayoutImmutable, Blittable]
		public bool IgnoreHeigthLockDistance { get; set; }

	}
}
