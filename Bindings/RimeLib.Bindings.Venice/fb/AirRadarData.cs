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
	public class AirRadarData : 
		UIPartData
	{
		[ContainerField(8), LayoutImmutable, Blittable]
		public float RadarRange { get; set; }

		[ContainerField(12), LayoutImmutable, Blittable]
		public float RadarSensitivity { get; set; }

		[ContainerField(16), LayoutImmutable, Blittable]
		public float HeatSensitivity { get; set; }

		[ContainerField(20)]
		public UIHudIcon MissileIcon { get; set; } = new();

		[ContainerField(24)]
		public UIHudIcon CenterIcon { get; set; } = new();

		[ContainerField(28)]
		public UIHudIcon FriendlyIcon { get; set; } = new();

		[ContainerField(32)]
		public UIHudIcon EnemyIcon { get; set; } = new();

		[ContainerField(36)]
		public UIHudIcon LaserPaintedIcon { get; set; } = new();

		[ContainerField(40)]
		public UIHudIcon NorthIcon { get; set; } = new();

		[ContainerField(48)]
		public SubScreenData SubScreen { get; set; } = new();

		[ContainerField(112)]
		public UIHudIcon WestIcon { get; set; } = new();

		[ContainerField(116)]
		public UIHudIcon SouthIcon { get; set; } = new();

		[ContainerField(120)]
		public UIHudIcon EastIcon { get; set; } = new();

		[ContainerField(124), LayoutImmutable, Blittable]
		public bool TrackLaserPaintedObjects { get; set; }

		[ContainerField(125), LayoutImmutable, Blittable]
		public bool TrackOnlyUsedVehicles { get; set; }

		[ContainerField(126), LayoutImmutable, Blittable]
		public bool UseCameraComponentTransform { get; set; }

	}
}
