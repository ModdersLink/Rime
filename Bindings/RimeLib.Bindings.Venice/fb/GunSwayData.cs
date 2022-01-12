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
	[ContainerType(4, 808)]
	public class GunSwayData : 
		WeaponSwayData
	{
		[ContainerField(8)]
		public GunSwayStandData Stand { get; set; } = new();

		[ContainerField(288)]
		public GunSwayCrouchProneData Crouch { get; set; } = new();

		[ContainerField(440)]
		public GunSwayCrouchProneData Prone { get; set; } = new();

		[ContainerField(592)]
		public GunSwayStanceTransition ProneToCrouch { get; set; } = new();

		[ContainerField(612)]
		public GunSwayStanceTransition ProneToStand { get; set; } = new();

		[ContainerField(632)]
		public GunSwayStanceTransition CrouchToProne { get; set; } = new();

		[ContainerField(652)]
		public GunSwayStanceTransition CrouchToStand { get; set; } = new();

		[ContainerField(672)]
		public GunSwayStanceTransition StandToProne { get; set; } = new();

		[ContainerField(692)]
		public GunSwayStanceTransition StandToCrouch { get; set; } = new();

		[ContainerField(712)]
		public GunSwayStanceZoomModifierData SuppressionModifierUnzoomed { get; set; } = new();

		[ContainerField(744)]
		public GunSwayStanceZoomModifierData SuppressionModifierZoomed { get; set; } = new();

		[ContainerField(776)]
		public RefArray<GunSwayModifierData> Modifiers { get; set; } = new();

		[ContainerField(780), LayoutImmutable, Blittable]
		public float DeviationScaleFactorZoom { get; set; }

		[ContainerField(784), LayoutImmutable, Blittable]
		public float GameplayDeviationScaleFactorZoom { get; set; }

		[ContainerField(788), LayoutImmutable, Blittable]
		public float DeviationScaleFactorNoZoom { get; set; }

		[ContainerField(792), LayoutImmutable, Blittable]
		public float GameplayDeviationScaleFactorNoZoom { get; set; }

		[ContainerField(796), LayoutImmutable, Blittable]
		public float ShootingRecoilDecreaseScale { get; set; }

		[ContainerField(800), LayoutImmutable, Blittable]
		public float FirstShotRecoilMultiplier { get; set; }

		[ContainerField(804)]
		public CtrRef<CameraRecoilData> CameraRecoil { get; set; } = new();

	}
}
