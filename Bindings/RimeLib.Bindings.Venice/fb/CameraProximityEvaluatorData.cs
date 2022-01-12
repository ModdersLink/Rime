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
	public class CameraProximityEvaluatorData : 
		EvaluatorData
	{
		[ContainerField(16), Homogeneous, LayoutImmutable, Blittable]
		public Vec3 Size { get; set; } = new();

		[ContainerField(32), Homogeneous, LayoutImmutable, Blittable]
		public Vec3 Offset { get; set; } = new();

		[ContainerField(48), Homogeneous, LayoutImmutable, Blittable]
		public Vec3 InnerRadiusDirection { get; set; } = new();

		[ContainerField(64), LayoutImmutable, Blittable]
		public float InnerRadius { get; set; }

		[ContainerField(68), LayoutImmutable, Blittable]
		public float ForwardOffset { get; set; }

	}
}
