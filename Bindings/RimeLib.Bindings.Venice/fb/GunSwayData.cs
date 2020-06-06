///////////////////////////////////////////////////////////////
//                                                           //
// This is an automatically generated file.                  //
// Do *NOT* modify unless you really know what you're doing. //
//                                                           //
///////////////////////////////////////////////////////////////

using System.Reflection;using RimeLib.Serialization.Attributes;using RimeLib.Serialization.Ebx;using RimeLib.Serialization.Containers;using RimeLib.Frostbite.Core;

namespace fb
{
    [ContainerType(4)]
	public class GunSwayData : 
		WeaponSwayData
	{
		[ContainerField(8)]
		public GunSwayStandData Stand { get; set; } = new GunSwayStandData(); // 0x8 (8)
		
		[ContainerField(288)]
		public GunSwayCrouchProneData Crouch { get; set; } = new GunSwayCrouchProneData(); // 0x120 (288)
		
		[ContainerField(440)]
		public GunSwayCrouchProneData Prone { get; set; } = new GunSwayCrouchProneData(); // 0x1B8 (440)
		
		[ContainerField(592)]
		public GunSwayStanceTransition ProneToCrouch { get; set; } = new GunSwayStanceTransition(); // 0x250 (592)
		
		[ContainerField(612)]
		public GunSwayStanceTransition ProneToStand { get; set; } = new GunSwayStanceTransition(); // 0x264 (612)
		
		[ContainerField(632)]
		public GunSwayStanceTransition CrouchToProne { get; set; } = new GunSwayStanceTransition(); // 0x278 (632)
		
		[ContainerField(652)]
		public GunSwayStanceTransition CrouchToStand { get; set; } = new GunSwayStanceTransition(); // 0x28C (652)
		
		[ContainerField(672)]
		public GunSwayStanceTransition StandToProne { get; set; } = new GunSwayStanceTransition(); // 0x2A0 (672)
		
		[ContainerField(692)]
		public GunSwayStanceTransition StandToCrouch { get; set; } = new GunSwayStanceTransition(); // 0x2B4 (692)
		
		[ContainerField(712)]
		public GunSwayStanceZoomModifierData SuppressionModifierUnzoomed { get; set; } = new GunSwayStanceZoomModifierData(); // 0x2C8 (712)
		
		[ContainerField(744)]
		public GunSwayStanceZoomModifierData SuppressionModifierZoomed { get; set; } = new GunSwayStanceZoomModifierData(); // 0x2E8 (744)
		
		[ContainerField(776)]
		public RefArray<GunSwayModifierData> Modifiers { get; set; } = new RefArray<GunSwayModifierData>(); // 0x308 (776)
		
		[ContainerField(780), LayoutImmutable, Blittable]
		public float DeviationScaleFactorZoom { get; set; } // 0x30C (780)
		
		[ContainerField(784), LayoutImmutable, Blittable]
		public float GameplayDeviationScaleFactorZoom { get; set; } // 0x310 (784)
		
		[ContainerField(788), LayoutImmutable, Blittable]
		public float DeviationScaleFactorNoZoom { get; set; } // 0x314 (788)
		
		[ContainerField(792), LayoutImmutable, Blittable]
		public float GameplayDeviationScaleFactorNoZoom { get; set; } // 0x318 (792)
		
		[ContainerField(796), LayoutImmutable, Blittable]
		public float ShootingRecoilDecreaseScale { get; set; } // 0x31C (796)
		
		[ContainerField(800), LayoutImmutable, Blittable]
		public float FirstShotRecoilMultiplier { get; set; } // 0x320 (800)
		
		[ContainerField(804)]
		public CtrRef<CameraRecoilData> CameraRecoil { get; set; } = new CtrRef<CameraRecoilData>(); // 0x324 (804)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 230747945:
					Stand = (GunSwayStandData) p_Value;
					break;

				case 2729602053:
					Crouch = (GunSwayCrouchProneData) p_Value;
					break;

				case 231940067:
					Prone = (GunSwayCrouchProneData) p_Value;
					break;

				case 4257061656:
					ProneToCrouch = (GunSwayStanceTransition) p_Value;
					break;

				case 1152741652:
					ProneToStand = (GunSwayStanceTransition) p_Value;
					break;

				case 2777914232:
					CrouchToProne = (GunSwayStanceTransition) p_Value;
					break;

				case 2779097650:
					CrouchToStand = (GunSwayStanceTransition) p_Value;
					break;

				case 1537379924:
					StandToProne = (GunSwayStanceTransition) p_Value;
					break;

				case 3815050450:
					StandToCrouch = (GunSwayStanceTransition) p_Value;
					break;

				case 3116538310:
					SuppressionModifierUnzoomed = (GunSwayStanceZoomModifierData) p_Value;
					break;

				case 4158044605:
					SuppressionModifierZoomed = (GunSwayStanceZoomModifierData) p_Value;
					break;

				case 105828545:
					Modifiers = (RefArray<GunSwayModifierData>) p_Value;
					break;

				case 384176132:
					DeviationScaleFactorZoom = (float) p_Value;
					break;

				case 1053702158:
					GameplayDeviationScaleFactorZoom = (float) p_Value;
					break;

				case 2529884645:
					DeviationScaleFactorNoZoom = (float) p_Value;
					break;

				case 1499286127:
					GameplayDeviationScaleFactorNoZoom = (float) p_Value;
					break;

				case 754056878:
					ShootingRecoilDecreaseScale = (float) p_Value;
					break;

				case 3947940458:
					FirstShotRecoilMultiplier = (float) p_Value;
					break;

				case 1741067714:
					CameraRecoil = (CtrRef<CameraRecoilData>) p_Value;
					break;

				default:
					base.Bind(p_Descriptor, p_Value);
					break;
			}
		}

		public override object GetFieldValueByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 230747945:
					return Stand;

				case 2729602053:
					return Crouch;

				case 231940067:
					return Prone;

				case 4257061656:
					return ProneToCrouch;

				case 1152741652:
					return ProneToStand;

				case 2777914232:
					return CrouchToProne;

				case 2779097650:
					return CrouchToStand;

				case 1537379924:
					return StandToProne;

				case 3815050450:
					return StandToCrouch;

				case 3116538310:
					return SuppressionModifierUnzoomed;

				case 4158044605:
					return SuppressionModifierZoomed;

				case 105828545:
					return Modifiers;

				case 384176132:
					return DeviationScaleFactorZoom;

				case 1053702158:
					return GameplayDeviationScaleFactorZoom;

				case 2529884645:
					return DeviationScaleFactorNoZoom;

				case 1499286127:
					return GameplayDeviationScaleFactorNoZoom;

				case 754056878:
					return ShootingRecoilDecreaseScale;

				case 3947940458:
					return FirstShotRecoilMultiplier;

				case 1741067714:
					return CameraRecoil;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 230747945:
					return typeof(GunSwayData).GetProperty(nameof(Stand));

				case 2729602053:
					return typeof(GunSwayData).GetProperty(nameof(Crouch));

				case 231940067:
					return typeof(GunSwayData).GetProperty(nameof(Prone));

				case 4257061656:
					return typeof(GunSwayData).GetProperty(nameof(ProneToCrouch));

				case 1152741652:
					return typeof(GunSwayData).GetProperty(nameof(ProneToStand));

				case 2777914232:
					return typeof(GunSwayData).GetProperty(nameof(CrouchToProne));

				case 2779097650:
					return typeof(GunSwayData).GetProperty(nameof(CrouchToStand));

				case 1537379924:
					return typeof(GunSwayData).GetProperty(nameof(StandToProne));

				case 3815050450:
					return typeof(GunSwayData).GetProperty(nameof(StandToCrouch));

				case 3116538310:
					return typeof(GunSwayData).GetProperty(nameof(SuppressionModifierUnzoomed));

				case 4158044605:
					return typeof(GunSwayData).GetProperty(nameof(SuppressionModifierZoomed));

				case 105828545:
					return typeof(GunSwayData).GetProperty(nameof(Modifiers));

				case 384176132:
					return typeof(GunSwayData).GetProperty(nameof(DeviationScaleFactorZoom));

				case 1053702158:
					return typeof(GunSwayData).GetProperty(nameof(GameplayDeviationScaleFactorZoom));

				case 2529884645:
					return typeof(GunSwayData).GetProperty(nameof(DeviationScaleFactorNoZoom));

				case 1499286127:
					return typeof(GunSwayData).GetProperty(nameof(GameplayDeviationScaleFactorNoZoom));

				case 754056878:
					return typeof(GunSwayData).GetProperty(nameof(ShootingRecoilDecreaseScale));

				case 3947940458:
					return typeof(GunSwayData).GetProperty(nameof(FirstShotRecoilMultiplier));

				case 1741067714:
					return typeof(GunSwayData).GetProperty(nameof(CameraRecoil));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
