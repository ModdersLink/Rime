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
	[ContainerType(16, 240)]
	public class StaticCameraData : 
		TargetCameraData
	{
		[ContainerField(160)]
		public List<Vec3> LeftCurve { get; set; } = new();

		[ContainerField(164)]
		public List<Vec3> RightCurve { get; set; } = new();

		[ContainerField(168)]
		public List<Vec3> UpCurve { get; set; } = new();

		[ContainerField(172)]
		public List<Vec3> DownCurve { get; set; } = new();

		[ContainerField(176), LayoutImmutable, Blittable]
		public float UpPitchAngle { get; set; }

		[ContainerField(180)]
		public EntryInputActionEnum YawInputAction { get; set; } = new();

		[ContainerField(184)]
		public RefArray<CameraLoosePartPhysicsData> LoosePartPhysics { get; set; } = new();

		[ContainerField(188), LayoutImmutable, Blittable]
		public float LeftYawAngle { get; set; }

		[ContainerField(192), LayoutImmutable, Blittable]
		public float RightYawAngle { get; set; }

		[ContainerField(196), LayoutImmutable, Blittable]
		public float PitchSensitivityZoomed { get; set; }

		[ContainerField(200), LayoutImmutable, Blittable]
		public float DownPitchAngle { get; set; }

		[ContainerField(204), LayoutImmutable, Blittable]
		public int AverageFilterFrames { get; set; }

		[ContainerField(208)]
		public EntryInputActionEnum PitchInputAction { get; set; } = new();

		[ContainerField(212), LayoutImmutable, Blittable]
		public float YawSensitivityZoomed { get; set; }

		[ContainerField(216), LayoutImmutable, Blittable]
		public float PitchSensitivityNonZoomed { get; set; }

		[ContainerField(220), LayoutImmutable, Blittable]
		public float YawSensitivityNonZoomed { get; set; }

		[ContainerField(224), LayoutImmutable, Blittable]
		public bool ResetAccumulatedInputOnViewChange { get; set; }

		[ContainerField(225), LayoutImmutable, Blittable]
		public bool MirrorHorizontalCurves { get; set; }

		[ContainerField(226), LayoutImmutable, Blittable]
		public bool AccumulateInput { get; set; }

		[ContainerField(227), LayoutImmutable, Blittable]
		public bool MirrorVerticalCurves { get; set; }

	}
}
