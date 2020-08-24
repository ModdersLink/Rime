///////////////////////////////////////////////////////////////
//                                                           //
// This is an automatically generated file.                  //
// Do *NOT* modify unless you really know what you're doing. //
//                                                           //
///////////////////////////////////////////////////////////////

using RimeLib.IO;
using RimeLib.Frostbite.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel;
using System.Reflection;
using RimeLib.Serialization.Attributes;
using RimeLib.Serialization.Containers;
using RimeLib.Serialization.Ebx;

namespace fb
{
	[ContainerType(4), MemberInfoFlag(53), ContainerClass]
	public class GunSwayData : 
		WeaponSwayData
	{
		protected GunSwayStandData m_Stand = new GunSwayStandData();
		[ContainerField(8), MemberInfoFlag(41), ContainerFieldNameHash(230747945)]
		public GunSwayStandData Stand { get { return m_Stand; } set { if (OnPropertyChanging("GunSwayData." + nameof(Stand), this, m_Stand, value)) m_Stand = value; } } // 0x8 (8)
		
		protected GunSwayCrouchProneData m_Crouch = new GunSwayCrouchProneData();
		[ContainerField(288), MemberInfoFlag(41), ContainerFieldNameHash(2729602053)]
		public GunSwayCrouchProneData Crouch { get { return m_Crouch; } set { if (OnPropertyChanging("GunSwayData." + nameof(Crouch), this, m_Crouch, value)) m_Crouch = value; } } // 0x120 (288)
		
		protected GunSwayCrouchProneData m_Prone = new GunSwayCrouchProneData();
		[ContainerField(440), MemberInfoFlag(41), ContainerFieldNameHash(231940067)]
		public GunSwayCrouchProneData Prone { get { return m_Prone; } set { if (OnPropertyChanging("GunSwayData." + nameof(Prone), this, m_Prone, value)) m_Prone = value; } } // 0x1B8 (440)
		
		protected GunSwayStanceTransition m_ProneToCrouch = new GunSwayStanceTransition();
		[ContainerField(592), MemberInfoFlag(41), ContainerFieldNameHash(4257061656)]
		public GunSwayStanceTransition ProneToCrouch { get { return m_ProneToCrouch; } set { if (OnPropertyChanging("GunSwayData." + nameof(ProneToCrouch), this, m_ProneToCrouch, value)) m_ProneToCrouch = value; } } // 0x250 (592)
		
		protected GunSwayStanceTransition m_ProneToStand = new GunSwayStanceTransition();
		[ContainerField(612), MemberInfoFlag(41), ContainerFieldNameHash(1152741652)]
		public GunSwayStanceTransition ProneToStand { get { return m_ProneToStand; } set { if (OnPropertyChanging("GunSwayData." + nameof(ProneToStand), this, m_ProneToStand, value)) m_ProneToStand = value; } } // 0x264 (612)
		
		protected GunSwayStanceTransition m_CrouchToProne = new GunSwayStanceTransition();
		[ContainerField(632), MemberInfoFlag(41), ContainerFieldNameHash(2777914232)]
		public GunSwayStanceTransition CrouchToProne { get { return m_CrouchToProne; } set { if (OnPropertyChanging("GunSwayData." + nameof(CrouchToProne), this, m_CrouchToProne, value)) m_CrouchToProne = value; } } // 0x278 (632)
		
		protected GunSwayStanceTransition m_CrouchToStand = new GunSwayStanceTransition();
		[ContainerField(652), MemberInfoFlag(41), ContainerFieldNameHash(2779097650)]
		public GunSwayStanceTransition CrouchToStand { get { return m_CrouchToStand; } set { if (OnPropertyChanging("GunSwayData." + nameof(CrouchToStand), this, m_CrouchToStand, value)) m_CrouchToStand = value; } } // 0x28C (652)
		
		protected GunSwayStanceTransition m_StandToProne = new GunSwayStanceTransition();
		[ContainerField(672), MemberInfoFlag(41), ContainerFieldNameHash(1537379924)]
		public GunSwayStanceTransition StandToProne { get { return m_StandToProne; } set { if (OnPropertyChanging("GunSwayData." + nameof(StandToProne), this, m_StandToProne, value)) m_StandToProne = value; } } // 0x2A0 (672)
		
		protected GunSwayStanceTransition m_StandToCrouch = new GunSwayStanceTransition();
		[ContainerField(692), MemberInfoFlag(41), ContainerFieldNameHash(3815050450)]
		public GunSwayStanceTransition StandToCrouch { get { return m_StandToCrouch; } set { if (OnPropertyChanging("GunSwayData." + nameof(StandToCrouch), this, m_StandToCrouch, value)) m_StandToCrouch = value; } } // 0x2B4 (692)
		
		protected GunSwayStanceZoomModifierData m_SuppressionModifierUnzoomed = new GunSwayStanceZoomModifierData();
		[ContainerField(712), MemberInfoFlag(41), ContainerFieldNameHash(3116538310)]
		public GunSwayStanceZoomModifierData SuppressionModifierUnzoomed { get { return m_SuppressionModifierUnzoomed; } set { if (OnPropertyChanging("GunSwayData." + nameof(SuppressionModifierUnzoomed), this, m_SuppressionModifierUnzoomed, value)) m_SuppressionModifierUnzoomed = value; } } // 0x2C8 (712)
		
		protected GunSwayStanceZoomModifierData m_SuppressionModifierZoomed = new GunSwayStanceZoomModifierData();
		[ContainerField(744), MemberInfoFlag(41), ContainerFieldNameHash(4158044605)]
		public GunSwayStanceZoomModifierData SuppressionModifierZoomed { get { return m_SuppressionModifierZoomed; } set { if (OnPropertyChanging("GunSwayData." + nameof(SuppressionModifierZoomed), this, m_SuppressionModifierZoomed, value)) m_SuppressionModifierZoomed = value; } } // 0x2E8 (744)
		
		protected RefArray<GunSwayModifierData> m_Modifiers = new RefArray<GunSwayModifierData>();
		[ContainerField(776), MemberInfoFlag(65), ContainerFieldNameHash(105828545), ContainerRefArray]
		public RefArray<GunSwayModifierData> Modifiers { get { return m_Modifiers; } set { if (OnPropertyChanging("GunSwayData." + nameof(Modifiers), this, m_Modifiers, value)) m_Modifiers = value; } } // 0x308 (776)
		
		protected float m_DeviationScaleFactorZoom = new float();
		[ContainerField(780), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(384176132)]
		public float DeviationScaleFactorZoom { get { return m_DeviationScaleFactorZoom; } set { if (OnPropertyChanging("GunSwayData." + nameof(DeviationScaleFactorZoom), this, m_DeviationScaleFactorZoom, value)) m_DeviationScaleFactorZoom = value; } } // 0x30C (780)
		
		protected float m_GameplayDeviationScaleFactorZoom = new float();
		[ContainerField(784), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(1053702158)]
		public float GameplayDeviationScaleFactorZoom { get { return m_GameplayDeviationScaleFactorZoom; } set { if (OnPropertyChanging("GunSwayData." + nameof(GameplayDeviationScaleFactorZoom), this, m_GameplayDeviationScaleFactorZoom, value)) m_GameplayDeviationScaleFactorZoom = value; } } // 0x310 (784)
		
		protected float m_DeviationScaleFactorNoZoom = new float();
		[ContainerField(788), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(2529884645)]
		public float DeviationScaleFactorNoZoom { get { return m_DeviationScaleFactorNoZoom; } set { if (OnPropertyChanging("GunSwayData." + nameof(DeviationScaleFactorNoZoom), this, m_DeviationScaleFactorNoZoom, value)) m_DeviationScaleFactorNoZoom = value; } } // 0x314 (788)
		
		protected float m_GameplayDeviationScaleFactorNoZoom = new float();
		[ContainerField(792), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(1499286127)]
		public float GameplayDeviationScaleFactorNoZoom { get { return m_GameplayDeviationScaleFactorNoZoom; } set { if (OnPropertyChanging("GunSwayData." + nameof(GameplayDeviationScaleFactorNoZoom), this, m_GameplayDeviationScaleFactorNoZoom, value)) m_GameplayDeviationScaleFactorNoZoom = value; } } // 0x318 (792)
		
		protected float m_ShootingRecoilDecreaseScale = new float();
		[ContainerField(796), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(754056878)]
		public float ShootingRecoilDecreaseScale { get { return m_ShootingRecoilDecreaseScale; } set { if (OnPropertyChanging("GunSwayData." + nameof(ShootingRecoilDecreaseScale), this, m_ShootingRecoilDecreaseScale, value)) m_ShootingRecoilDecreaseScale = value; } } // 0x31C (796)
		
		protected float m_FirstShotRecoilMultiplier = new float();
		[ContainerField(800), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(3947940458)]
		public float FirstShotRecoilMultiplier { get { return m_FirstShotRecoilMultiplier; } set { if (OnPropertyChanging("GunSwayData." + nameof(FirstShotRecoilMultiplier), this, m_FirstShotRecoilMultiplier, value)) m_FirstShotRecoilMultiplier = value; } } // 0x320 (800)
		
		protected CtrRef<CameraRecoilData> m_CameraRecoil = new CtrRef<CameraRecoilData>();
		[ContainerField(804), MemberInfoFlag(53), ContainerFieldNameHash(1741067714), ContainerCtrRef]
		public CtrRef<CameraRecoilData> CameraRecoil { get { return m_CameraRecoil; } set { if (OnPropertyChanging("GunSwayData." + nameof(CameraRecoil), this, m_CameraRecoil, value)) m_CameraRecoil = value; } } // 0x324 (804)
		
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
