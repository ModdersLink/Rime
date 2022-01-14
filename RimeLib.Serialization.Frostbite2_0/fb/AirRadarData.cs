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
	[ContainerType(16, 128)]
	public class AirRadarData : 
		UIPartData
	{
		[ContainerField(8), LayoutImmutable, Blittable, JsonProperty(Order = 8)]
		public float RadarRange { get; set; }

		[ContainerField(12), LayoutImmutable, Blittable, JsonProperty(Order = 12)]
		public float RadarSensitivity { get; set; }

		[ContainerField(16), LayoutImmutable, Blittable, JsonProperty(Order = 16)]
		public float HeatSensitivity { get; set; }

		[ContainerField(20), JsonProperty(Order = 20)]
		public UIHudIcon MissileIcon { get; set; } = new();

		[ContainerField(24), JsonProperty(Order = 24)]
		public UIHudIcon CenterIcon { get; set; } = new();

		[ContainerField(28), JsonProperty(Order = 28)]
		public UIHudIcon FriendlyIcon { get; set; } = new();

		[ContainerField(32), JsonProperty(Order = 32)]
		public UIHudIcon EnemyIcon { get; set; } = new();

		[ContainerField(36), JsonProperty(Order = 36)]
		public UIHudIcon LaserPaintedIcon { get; set; } = new();

		[ContainerField(40), JsonProperty(Order = 40)]
		public UIHudIcon NorthIcon { get; set; } = new();

		[ContainerField(48), JsonProperty(Order = 48)]
		public SubScreenData SubScreen { get; set; } = new();

		[ContainerField(112), JsonProperty(Order = 112)]
		public UIHudIcon WestIcon { get; set; } = new();

		[ContainerField(116), JsonProperty(Order = 116)]
		public UIHudIcon SouthIcon { get; set; } = new();

		[ContainerField(120), JsonProperty(Order = 120)]
		public UIHudIcon EastIcon { get; set; } = new();

		[ContainerField(124), LayoutImmutable, Blittable, JsonProperty(Order = 124)]
		public bool TrackLaserPaintedObjects { get; set; }

		[ContainerField(125), LayoutImmutable, Blittable, JsonProperty(Order = 125)]
		public bool TrackOnlyUsedVehicles { get; set; }

		[ContainerField(126), LayoutImmutable, Blittable, JsonProperty(Order = 126)]
		public bool UseCameraComponentTransform { get; set; }

	}
}
