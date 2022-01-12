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
	[ContainerType(16, 96)]
	public class EngineConfigData : 
		DataContainer
	{
		[ContainerField(16), Homogeneous, LayoutImmutable, Blittable]
		public Vec3 Position { get; set; } = new();

		[ContainerField(32)]
		public List<float> RpmCurvePoints { get; set; } = new();

		[ContainerField(36)]
		public List<float> TorqueCurvePoints { get; set; } = new();

		[ContainerField(40), LayoutImmutable, Blittable]
		public float RpmMin { get; set; }

		[ContainerField(44), LayoutImmutable, Blittable]
		public float RpmMax { get; set; }

		[ContainerField(48), LayoutImmutable, Blittable]
		public float RpmCut { get; set; }

		[ContainerField(52), LayoutImmutable, Blittable]
		public float EnginePowerMultiplier { get; set; }

		[ContainerField(56), LayoutImmutable, Blittable]
		public float InternalAccelerationFactor { get; set; }

		[ContainerField(60), LayoutImmutable, Blittable]
		public float InternalDeaccelerationFactor { get; set; }

		[ContainerField(64)]
		public Boost Boost { get; set; } = new();

	}
}
