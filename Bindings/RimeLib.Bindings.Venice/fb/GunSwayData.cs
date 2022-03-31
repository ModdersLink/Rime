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
	[ContainerType(4, 808)]
	public class GunSwayData : 
		WeaponSwayData
	{
		[ContainerField(8), JsonProperty(Order = 8)]
		public GunSwayStandData Stand { get; set; } = new();

		[ContainerField(288), JsonProperty(Order = 288)]
		public GunSwayCrouchProneData Crouch { get; set; } = new();

		[ContainerField(440), JsonProperty(Order = 440)]
		public GunSwayCrouchProneData Prone { get; set; } = new();

		[ContainerField(592), JsonProperty(Order = 592)]
		public GunSwayStanceTransition ProneToCrouch { get; set; } = new();

		[ContainerField(612), JsonProperty(Order = 612)]
		public GunSwayStanceTransition ProneToStand { get; set; } = new();

		[ContainerField(632), JsonProperty(Order = 632)]
		public GunSwayStanceTransition CrouchToProne { get; set; } = new();

		[ContainerField(652), JsonProperty(Order = 652)]
		public GunSwayStanceTransition CrouchToStand { get; set; } = new();

		[ContainerField(672), JsonProperty(Order = 672)]
		public GunSwayStanceTransition StandToProne { get; set; } = new();

		[ContainerField(692), JsonProperty(Order = 692)]
		public GunSwayStanceTransition StandToCrouch { get; set; } = new();

		[ContainerField(712), JsonProperty(Order = 712)]
		public GunSwayStanceZoomModifierData SuppressionModifierUnzoomed { get; set; } = new();

		[ContainerField(744), JsonProperty(Order = 744)]
		public GunSwayStanceZoomModifierData SuppressionModifierZoomed { get; set; } = new();

		[ContainerField(776), JsonProperty(Order = 776)]
		public RefArray<GunSwayModifierData> Modifiers { get; set; } = new();

		[ContainerField(780), LayoutImmutable, Blittable, JsonProperty(Order = 780)]
		public float DeviationScaleFactorZoom { get; set; }

		[ContainerField(784), LayoutImmutable, Blittable, JsonProperty(Order = 784)]
		public float GameplayDeviationScaleFactorZoom { get; set; }

		[ContainerField(788), LayoutImmutable, Blittable, JsonProperty(Order = 788)]
		public float DeviationScaleFactorNoZoom { get; set; }

		[ContainerField(792), LayoutImmutable, Blittable, JsonProperty(Order = 792)]
		public float GameplayDeviationScaleFactorNoZoom { get; set; }

		[ContainerField(796), LayoutImmutable, Blittable, JsonProperty(Order = 796)]
		public float ShootingRecoilDecreaseScale { get; set; }

		[ContainerField(800), LayoutImmutable, Blittable, JsonProperty(Order = 800)]
		public float FirstShotRecoilMultiplier { get; set; }

		[ContainerField(804), JsonProperty(Order = 804)]
		public CtrRef<CameraRecoilData> CameraRecoil { get; set; } = new();

	}
}
