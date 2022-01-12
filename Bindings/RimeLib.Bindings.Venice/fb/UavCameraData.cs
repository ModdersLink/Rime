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
	public class UavCameraData : 
		TargetCameraData
	{
		[ContainerField(160), LayoutImmutable, Blittable]
		public float ViewDistance { get; set; }

		[ContainerField(164)]
		public List<CameraSineCurveData> ViewDistanceCurve { get; set; } = new();

		[ContainerField(168), LayoutImmutable, Blittable]
		public float ViewAngle { get; set; }

		[ContainerField(172)]
		public List<CameraSineCurveData> ViewAngleCurve { get; set; } = new();

		[ContainerField(176), LayoutImmutable, Blittable]
		public float RotationSpeed { get; set; }

		[ContainerField(180)]
		public List<CameraSineCurveData> RotationSpeedCurve { get; set; } = new();

		[ContainerField(184), LayoutImmutable, Blittable]
		public float ZoomFov { get; set; }

		[ContainerField(188), LayoutImmutable, Blittable]
		public float ZoomDelay { get; set; }

		[ContainerField(192), LayoutImmutable, Blittable]
		public float ZoomTransitionTime { get; set; }

		[ContainerField(196), LayoutImmutable, Blittable]
		public float Fov { get; set; }

		[ContainerField(200)]
		public UavCameraPointData FocusPoint { get; set; } = new();

		[ContainerField(216)]
		public UavCameraPointData CenterPoint { get; set; } = new();

		[ContainerField(232), LayoutImmutable, Blittable]
		public float UpWeightDistance { get; set; }

	}
}
