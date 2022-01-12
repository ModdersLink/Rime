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
	public class ChildComponentData : 
		PartComponentData
	{
		[ContainerField(112), Homogeneous, LayoutImmutable, Blittable]
		public LinearTransform AlignTransform { get; set; } = new();

		[ContainerField(176)]
		public CtrRef<MovingBodyData> MovingBody { get; set; } = new();

		[ContainerField(180)]
		public VehicleHealthZoneData HealthZone { get; set; } = new();

		[ContainerField(200), LayoutImmutable, Blittable]
		public float SoundEffectStartRpm { get; set; }

		[ContainerField(204), LayoutImmutable, Blittable]
		public float SoundEffectStopRpm { get; set; }

		[ContainerField(208)]
		public CtrRef<AlignmentData> AlignmentSettings { get; set; } = new();

		[ContainerField(212)]
		public CtrRef<SoundAsset> SoundEffect { get; set; } = new();

		[ContainerField(216), LayoutImmutable, Blittable]
		public bool EnableAlignToCamera { get; set; }

		[ContainerField(217), LayoutImmutable, Blittable]
		public bool WorldSpacePositionLock { get; set; }

	}
}
