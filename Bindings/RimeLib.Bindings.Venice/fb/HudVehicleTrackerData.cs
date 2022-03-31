///////////////////////////////////////////////////////////////
//                                                           //
// This is an automatically generated file.                  //
// Do *NOT* modify unless you really know what you're doing. //
//                                                           //
///////////////////////////////////////////////////////////////

using System;
using System.IO;
using System.Collections.Generic;
using Newtonsoft.Json;
using RimeLib.IO;
using RimeLib.Frostbite.Core;
using RimeLib.Serialization.Attributes;
using RimeLib.Serialization;
using RimeLib.Serialization.Ebx;

namespace fb
{
	[ContainerType(4, 100)]
	public class HudVehicleTrackerData : 
		UIPartData
	{
		[ContainerField(8), JsonProperty(Order = 8)]
		public EdgePointerData EdgePointer { get; set; } = new();

		[ContainerField(24), JsonProperty(Order = 24)]
		public UIHudIcon EnemyTrackerIcon { get; set; } = new();

		[ContainerField(28), JsonProperty(Order = 28)]
		public UIHudIcon OutsideScreenTrackerIcon { get; set; } = new();

		[ContainerField(32), JsonProperty(Order = 32)]
		public VehicleTrackerRenderTargetData RenderTargetData { get; set; } = new();

		[ContainerField(56), JsonProperty(Order = 56)]
		public UIHudIcon MissileTrackerIcon { get; set; } = new();

		[ContainerField(60), LayoutImmutable, Blittable, JsonProperty(Order = 60)]
		public float IconSize { get; set; }

		[ContainerField(64), LayoutImmutable, Blittable, JsonProperty(Order = 64)]
		public float RadarSensitivity { get; set; }

		[ContainerField(68), LayoutImmutable, Blittable, JsonProperty(Order = 68)]
		public float HeatSensitivity { get; set; }

		[ContainerField(72), JsonProperty(Order = 72)]
		public UIHudIcon FriendlyTrackerIcon { get; set; } = new();

		[ContainerField(76), JsonProperty(Order = 76)]
		public UIHudIcon LaserPaintedVehicleTrackerIcon { get; set; } = new();

		[ContainerField(80), LayoutImmutable, Blittable, JsonProperty(Order = 80)]
		public float MaxDistance { get; set; }

		[ContainerField(84), LayoutImmutable, Blittable, JsonProperty(Order = 84)]
		public float DistanceIconShrinkFactor { get; set; }

		[ContainerField(88), JsonProperty(Order = 88)]
		public UIHudIcon MissileLockTrackerIcon { get; set; } = new();

		[ContainerField(92), LayoutImmutable, Blittable, JsonProperty(Order = 92)]
		public bool TrackOnlyUsedVehicles { get; set; }

		[ContainerField(93), LayoutImmutable, Blittable, JsonProperty(Order = 93)]
		public bool UseTrackerSignatures { get; set; }

		[ContainerField(94), LayoutImmutable, Blittable, JsonProperty(Order = 94)]
		public bool EnableEdgePointers { get; set; }

		[ContainerField(95), LayoutImmutable, Blittable, JsonProperty(Order = 95)]
		public bool TrackLaserPaintedObjects { get; set; }

		[ContainerField(96), LayoutImmutable, Blittable, JsonProperty(Order = 96)]
		public bool UseCameraComponentTransform { get; set; }

		[ContainerField(97), LayoutImmutable, Blittable, JsonProperty(Order = 97)]
		public bool ShowTracker { get; set; }

	}
}
