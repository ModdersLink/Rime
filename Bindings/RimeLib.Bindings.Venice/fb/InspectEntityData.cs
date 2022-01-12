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
	[ContainerType(16, 160)]
	public class InspectEntityData : 
		GameEntityData
	{
		[ContainerField(96), Homogeneous, LayoutImmutable, Blittable]
		public Vec3 CenterOffset { get; set; } = new();

		[ContainerField(112), LayoutImmutable]
		public string UIName { get; set; } = string.Empty;

		[ContainerField(116), LayoutImmutable, Blittable]
		public float MaxLookAtHeight { get; set; }

		[ContainerField(120)]
		public List<InspectViewPointData> ViewPoints { get; set; } = new();

		[ContainerField(124)]
		public RefArray<TargetCameraData> Cameras { get; set; } = new();

		[ContainerField(128), LayoutImmutable, Blittable]
		public float MinLookAtHeight { get; set; }

		[ContainerField(132), LayoutImmutable, Blittable]
		public float MinDistance { get; set; }

		[ContainerField(136), LayoutImmutable, Blittable]
		public float ZoomScrollSpeed { get; set; }

		[ContainerField(140), LayoutImmutable, Blittable]
		public float MaxDistance { get; set; }

		[ContainerField(144)]
		public AntRef AnimationSignal { get; set; } = new();

		[ContainerField(148), LayoutImmutable, Blittable]
		public float ZoomScrollAcceleration { get; set; }

	}
}
