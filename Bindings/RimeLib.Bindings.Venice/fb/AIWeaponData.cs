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
using RimeLib.Frostbite.Containers;
using RimeLib.Serialization.Ebx;

namespace fb
{
	[ContainerType(Alignment: 4,  Flags: 53, Size: 156)]
	public class AIWeaponData : 
		GameAIWeaponData
	{
		protected Strengths m_Strengths = new Strengths();
		[ContainerField(Name: "Strengths", Offset: 12, NameHash: 580112819, Flags: 41)]
		public Strengths Strengths { get { return m_Strengths; } set { if (OnPropertyChanging("AIWeaponData." + nameof(Strengths), this, m_Strengths, value)) m_Strengths = value; } } // 0xC (12)
		
		protected float m_MaxBurstCoolDownTime = new float();
		[ContainerField(Name: "MaxBurstCoolDownTime", Offset: 28, NameHash: 285598747, Flags: 49469), LayoutImmutable, Blittable]
		public float MaxBurstCoolDownTime { get { return m_MaxBurstCoolDownTime; } set { if (OnPropertyChanging("AIWeaponData." + nameof(MaxBurstCoolDownTime), this, m_MaxBurstCoolDownTime, value)) m_MaxBurstCoolDownTime = value; } } // 0x1C (28)
		
		protected float m_LostTargetBurstCoolDownModifier = new float();
		[ContainerField(Name: "LostTargetBurstCoolDownModifier", Offset: 32, NameHash: 3652724376, Flags: 49469), LayoutImmutable, Blittable]
		public float LostTargetBurstCoolDownModifier { get { return m_LostTargetBurstCoolDownModifier; } set { if (OnPropertyChanging("AIWeaponData." + nameof(LostTargetBurstCoolDownModifier), this, m_LostTargetBurstCoolDownModifier, value)) m_LostTargetBurstCoolDownModifier = value; } } // 0x20 (32)
		
		protected float m_FinalAccuracyPercentage = new float();
		[ContainerField(Name: "FinalAccuracyPercentage", Offset: 36, NameHash: 3907857804, Flags: 49469), LayoutImmutable, Blittable]
		public float FinalAccuracyPercentage { get { return m_FinalAccuracyPercentage; } set { if (OnPropertyChanging("AIWeaponData." + nameof(FinalAccuracyPercentage), this, m_FinalAccuracyPercentage, value)) m_FinalAccuracyPercentage = value; } } // 0x24 (36)
		
		protected float m_AimTransitionFireDelay = new float();
		[ContainerField(Name: "AimTransitionFireDelay", Offset: 40, NameHash: 1482171970, Flags: 49469), LayoutImmutable, Blittable]
		public float AimTransitionFireDelay { get { return m_AimTransitionFireDelay; } set { if (OnPropertyChanging("AIWeaponData." + nameof(AimTransitionFireDelay), this, m_AimTransitionFireDelay, value)) m_AimTransitionFireDelay = value; } } // 0x28 (40)
		
		protected float m_MinRange = new float();
		[ContainerField(Name: "MinRange", Offset: 44, NameHash: 3376587952, Flags: 49469), LayoutImmutable, Blittable]
		public float MinRange { get { return m_MinRange; } set { if (OnPropertyChanging("AIWeaponData." + nameof(MinRange), this, m_MinRange, value)) m_MinRange = value; } } // 0x2C (44)
		
		protected float m_MaxRange = new float();
		[ContainerField(Name: "MaxRange", Offset: 48, NameHash: 403774958, Flags: 49469), LayoutImmutable, Blittable]
		public float MaxRange { get { return m_MaxRange; } set { if (OnPropertyChanging("AIWeaponData." + nameof(MaxRange), this, m_MaxRange, value)) m_MaxRange = value; } } // 0x30 (48)
		
		protected float m_OptimalRangePercentage = new float();
		[ContainerField(Name: "OptimalRangePercentage", Offset: 52, NameHash: 3315261152, Flags: 49469), LayoutImmutable, Blittable]
		public float OptimalRangePercentage { get { return m_OptimalRangePercentage; } set { if (OnPropertyChanging("AIWeaponData." + nameof(OptimalRangePercentage), this, m_OptimalRangePercentage, value)) m_OptimalRangePercentage = value; } } // 0x34 (52)
		
		protected ReloadBehavior m_ReloadBehavior = new ReloadBehavior();
		[ContainerField(Name: "ReloadBehavior", Offset: 56, NameHash: 454651992, Flags: 137)]
		public ReloadBehavior ReloadBehavior { get { return m_ReloadBehavior; } set { if (OnPropertyChanging("AIWeaponData." + nameof(ReloadBehavior), this, m_ReloadBehavior, value)) m_ReloadBehavior = value; } } // 0x38 (56)
		
		protected float m_MinExtraReloadTime = new float();
		[ContainerField(Name: "MinExtraReloadTime", Offset: 60, NameHash: 956338353, Flags: 49469), LayoutImmutable, Blittable]
		public float MinExtraReloadTime { get { return m_MinExtraReloadTime; } set { if (OnPropertyChanging("AIWeaponData." + nameof(MinExtraReloadTime), this, m_MinExtraReloadTime, value)) m_MinExtraReloadTime = value; } } // 0x3C (60)
		
		protected float m_MaxExtraReloadTime = new float();
		[ContainerField(Name: "MaxExtraReloadTime", Offset: 64, NameHash: 2084005999, Flags: 49469), LayoutImmutable, Blittable]
		public float MaxExtraReloadTime { get { return m_MaxExtraReloadTime; } set { if (OnPropertyChanging("AIWeaponData." + nameof(MaxExtraReloadTime), this, m_MaxExtraReloadTime, value)) m_MaxExtraReloadTime = value; } } // 0x40 (64)
		
		protected float m_MinBurstCoolDownTime = new float();
		[ContainerField(Name: "MinBurstCoolDownTime", Offset: 68, NameHash: 2068337477, Flags: 49469), LayoutImmutable, Blittable]
		public float MinBurstCoolDownTime { get { return m_MinBurstCoolDownTime; } set { if (OnPropertyChanging("AIWeaponData." + nameof(MinBurstCoolDownTime), this, m_MinBurstCoolDownTime, value)) m_MinBurstCoolDownTime = value; } } // 0x44 (68)
		
		protected float m_AimAngularVelocity = new float();
		[ContainerField(Name: "AimAngularVelocity", Offset: 72, NameHash: 3342277461, Flags: 49469), LayoutImmutable, Blittable]
		public float AimAngularVelocity { get { return m_AimAngularVelocity; } set { if (OnPropertyChanging("AIWeaponData." + nameof(AimAngularVelocity), this, m_AimAngularVelocity, value)) m_AimAngularVelocity = value; } } // 0x48 (72)
		
		protected float m_InnerInaccurateDistance = new float();
		[ContainerField(Name: "InnerInaccurateDistance", Offset: 76, NameHash: 2665555465, Flags: 49469), LayoutImmutable, Blittable]
		public float InnerInaccurateDistance { get { return m_InnerInaccurateDistance; } set { if (OnPropertyChanging("AIWeaponData." + nameof(InnerInaccurateDistance), this, m_InnerInaccurateDistance, value)) m_InnerInaccurateDistance = value; } } // 0x4C (76)
		
		protected float m_AngleToTargetSnap = new float();
		[ContainerField(Name: "AngleToTargetSnap", Offset: 80, NameHash: 2787320226, Flags: 49469), LayoutImmutable, Blittable]
		public float AngleToTargetSnap { get { return m_AngleToTargetSnap; } set { if (OnPropertyChanging("AIWeaponData." + nameof(AngleToTargetSnap), this, m_AngleToTargetSnap, value)) m_AngleToTargetSnap = value; } } // 0x50 (80)
		
		protected float m_SweepDistance = new float();
		[ContainerField(Name: "SweepDistance", Offset: 84, NameHash: 1593892082, Flags: 49469), LayoutImmutable, Blittable]
		public float SweepDistance { get { return m_SweepDistance; } set { if (OnPropertyChanging("AIWeaponData." + nameof(SweepDistance), this, m_SweepDistance, value)) m_SweepDistance = value; } } // 0x54 (84)
		
		protected float m_SweepTime = new float();
		[ContainerField(Name: "SweepTime", Offset: 88, NameHash: 3730697956, Flags: 49469), LayoutImmutable, Blittable]
		public float SweepTime { get { return m_SweepTime; } set { if (OnPropertyChanging("AIWeaponData." + nameof(SweepTime), this, m_SweepTime, value)) m_SweepTime = value; } } // 0x58 (88)
		
		protected float m_WaitTimeBeforeFire = new float();
		[ContainerField(Name: "WaitTimeBeforeFire", Offset: 92, NameHash: 2863734138, Flags: 49469), LayoutImmutable, Blittable]
		public float WaitTimeBeforeFire { get { return m_WaitTimeBeforeFire; } set { if (OnPropertyChanging("AIWeaponData." + nameof(WaitTimeBeforeFire), this, m_WaitTimeBeforeFire, value)) m_WaitTimeBeforeFire = value; } } // 0x5C (92)
		
		protected BurstLimit m_BurstLimitNear = new BurstLimit();
		[ContainerField(Name: "BurstLimitNear", Offset: 96, NameHash: 3329385610, Flags: 41)]
		public BurstLimit BurstLimitNear { get { return m_BurstLimitNear; } set { if (OnPropertyChanging("AIWeaponData." + nameof(BurstLimitNear), this, m_BurstLimitNear, value)) m_BurstLimitNear = value; } } // 0x60 (96)
		
		protected BurstLimit m_BurstLimitFar = new BurstLimit();
		[ContainerField(Name: "BurstLimitFar", Offset: 104, NameHash: 4005397607, Flags: 41)]
		public BurstLimit BurstLimitFar { get { return m_BurstLimitFar; } set { if (OnPropertyChanging("AIWeaponData." + nameof(BurstLimitFar), this, m_BurstLimitFar, value)) m_BurstLimitFar = value; } } // 0x68 (104)
		
		protected float m_StartAccuracyPercentage = new float();
		[ContainerField(Name: "StartAccuracyPercentage", Offset: 112, NameHash: 2579263552, Flags: 49469), LayoutImmutable, Blittable]
		public float StartAccuracyPercentage { get { return m_StartAccuracyPercentage; } set { if (OnPropertyChanging("AIWeaponData." + nameof(StartAccuracyPercentage), this, m_StartAccuracyPercentage, value)) m_StartAccuracyPercentage = value; } } // 0x70 (112)
		
		protected float m_MinimumAccuracyBeforeFiring = new float();
		[ContainerField(Name: "MinimumAccuracyBeforeFiring", Offset: 116, NameHash: 2922918922, Flags: 49469), LayoutImmutable, Blittable]
		public float MinimumAccuracyBeforeFiring { get { return m_MinimumAccuracyBeforeFiring; } set { if (OnPropertyChanging("AIWeaponData." + nameof(MinimumAccuracyBeforeFiring), this, m_MinimumAccuracyBeforeFiring, value)) m_MinimumAccuracyBeforeFiring = value; } } // 0x74 (116)
		
		protected float m_OuterInaccurateDistance = new float();
		[ContainerField(Name: "OuterInaccurateDistance", Offset: 120, NameHash: 519690862, Flags: 49469), LayoutImmutable, Blittable]
		public float OuterInaccurateDistance { get { return m_OuterInaccurateDistance; } set { if (OnPropertyChanging("AIWeaponData." + nameof(OuterInaccurateDistance), this, m_OuterInaccurateDistance, value)) m_OuterInaccurateDistance = value; } } // 0x78 (120)
		
		protected float m_AdditionalMinimumAccuracyAtMinRange = new float();
		[ContainerField(Name: "AdditionalMinimumAccuracyAtMinRange", Offset: 124, NameHash: 2681805527, Flags: 49469), LayoutImmutable, Blittable]
		public float AdditionalMinimumAccuracyAtMinRange { get { return m_AdditionalMinimumAccuracyAtMinRange; } set { if (OnPropertyChanging("AIWeaponData." + nameof(AdditionalMinimumAccuracyAtMinRange), this, m_AdditionalMinimumAccuracyAtMinRange, value)) m_AdditionalMinimumAccuracyAtMinRange = value; } } // 0x7C (124)
		
		protected float m_GravityModifier = new float();
		[ContainerField(Name: "GravityModifier", Offset: 128, NameHash: 1597941524, Flags: 49469), LayoutImmutable, Blittable]
		public float GravityModifier { get { return m_GravityModifier; } set { if (OnPropertyChanging("AIWeaponData." + nameof(GravityModifier), this, m_GravityModifier, value)) m_GravityModifier = value; } } // 0x80 (128)
		
		protected SweepSelectionType m_SweepType = new SweepSelectionType();
		[ContainerField(Name: "SweepType", Offset: 132, NameHash: 3730715017, Flags: 137)]
		public SweepSelectionType SweepType { get { return m_SweepType; } set { if (OnPropertyChanging("AIWeaponData." + nameof(SweepType), this, m_SweepType, value)) m_SweepType = value; } } // 0x84 (132)
		
		protected AimOrigin m_AimOrigin = new AimOrigin();
		[ContainerField(Name: "AimOrigin", Offset: 136, NameHash: 2430796116, Flags: 137)]
		public AimOrigin AimOrigin { get { return m_AimOrigin; } set { if (OnPropertyChanging("AIWeaponData." + nameof(AimOrigin), this, m_AimOrigin, value)) m_AimOrigin = value; } } // 0x88 (136)
		
		protected bool m_UseZoom = new bool();
		[ContainerField(Name: "UseZoom", Offset: 140, NameHash: 2351209937, Flags: 49325), LayoutImmutable, Blittable]
		public bool UseZoom { get { return m_UseZoom; } set { if (OnPropertyChanging("AIWeaponData." + nameof(UseZoom), this, m_UseZoom, value)) m_UseZoom = value; } } // 0x8C (140)
		
		protected bool m_AllowedAgainstImmortals = new bool();
		[ContainerField(Name: "AllowedAgainstImmortals", Offset: 141, NameHash: 1661149220, Flags: 49325), LayoutImmutable, Blittable]
		public bool AllowedAgainstImmortals { get { return m_AllowedAgainstImmortals; } set { if (OnPropertyChanging("AIWeaponData." + nameof(AllowedAgainstImmortals), this, m_AllowedAgainstImmortals, value)) m_AllowedAgainstImmortals = value; } } // 0x8D (141)
		
		protected bool m_AimWhileReloading = new bool();
		[ContainerField(Name: "AimWhileReloading", Offset: 142, NameHash: 1978011822, Flags: 49325), LayoutImmutable, Blittable]
		public bool AimWhileReloading { get { return m_AimWhileReloading; } set { if (OnPropertyChanging("AIWeaponData." + nameof(AimWhileReloading), this, m_AimWhileReloading, value)) m_AimWhileReloading = value; } } // 0x8E (142)
		
		protected bool m_AimHighIndirectPath = new bool();
		[ContainerField(Name: "AimHighIndirectPath", Offset: 143, NameHash: 2747696201, Flags: 49325), LayoutImmutable, Blittable]
		public bool AimHighIndirectPath { get { return m_AimHighIndirectPath; } set { if (OnPropertyChanging("AIWeaponData." + nameof(AimHighIndirectPath), this, m_AimHighIndirectPath, value)) m_AimHighIndirectPath = value; } } // 0x8F (143)
		
		protected bool m_Indirect = new bool();
		[ContainerField(Name: "Indirect", Offset: 144, NameHash: 3669286767, Flags: 49325), LayoutImmutable, Blittable]
		public bool Indirect { get { return m_Indirect; } set { if (OnPropertyChanging("AIWeaponData." + nameof(Indirect), this, m_Indirect, value)) m_Indirect = value; } } // 0x90 (144)
		
		protected bool m_IsMelee = new bool();
		[ContainerField(Name: "IsMelee", Offset: 145, NameHash: 2749654459, Flags: 49325), LayoutImmutable, Blittable]
		public bool IsMelee { get { return m_IsMelee; } set { if (OnPropertyChanging("AIWeaponData." + nameof(IsMelee), this, m_IsMelee, value)) m_IsMelee = value; } } // 0x91 (145)
		
		protected bool m_SweepFirstAttack = new bool();
		[ContainerField(Name: "SweepFirstAttack", Offset: 146, NameHash: 1558929635, Flags: 49325), LayoutImmutable, Blittable]
		public bool SweepFirstAttack { get { return m_SweepFirstAttack; } set { if (OnPropertyChanging("AIWeaponData." + nameof(SweepFirstAttack), this, m_SweepFirstAttack, value)) m_SweepFirstAttack = value; } } // 0x92 (146)
		
		protected bool m_IsBlindFireAllowed = new bool();
		[ContainerField(Name: "IsBlindFireAllowed", Offset: 147, NameHash: 235787346, Flags: 49325), LayoutImmutable, Blittable]
		public bool IsBlindFireAllowed { get { return m_IsBlindFireAllowed; } set { if (OnPropertyChanging("AIWeaponData." + nameof(IsBlindFireAllowed), this, m_IsBlindFireAllowed, value)) m_IsBlindFireAllowed = value; } } // 0x93 (147)
		
		protected bool m_CanAltAttack = new bool();
		[ContainerField(Name: "CanAltAttack", Offset: 148, NameHash: 1587679768, Flags: 49325), LayoutImmutable, Blittable]
		public bool CanAltAttack { get { return m_CanAltAttack; } set { if (OnPropertyChanging("AIWeaponData." + nameof(CanAltAttack), this, m_CanAltAttack, value)) m_CanAltAttack = value; } } // 0x94 (148)
		
		protected bool m_IsStandStill = new bool();
		[ContainerField(Name: "IsStandStill", Offset: 149, NameHash: 2163965853, Flags: 49325), LayoutImmutable, Blittable]
		public bool IsStandStill { get { return m_IsStandStill; } set { if (OnPropertyChanging("AIWeaponData." + nameof(IsStandStill), this, m_IsStandStill, value)) m_IsStandStill = value; } } // 0x95 (149)
		
		protected bool m_CanSuppress = new bool();
		[ContainerField(Name: "CanSuppress", Offset: 150, NameHash: 1987450488, Flags: 49325), LayoutImmutable, Blittable]
		public bool CanSuppress { get { return m_CanSuppress; } set { if (OnPropertyChanging("AIWeaponData." + nameof(CanSuppress), this, m_CanSuppress, value)) m_CanSuppress = value; } } // 0x96 (150)
		
		protected bool m_UseFromCover = new bool();
		[ContainerField(Name: "UseFromCover", Offset: 151, NameHash: 3212905629, Flags: 49325), LayoutImmutable, Blittable]
		public bool UseFromCover { get { return m_UseFromCover; } set { if (OnPropertyChanging("AIWeaponData." + nameof(UseFromCover), this, m_UseFromCover, value)) m_UseFromCover = value; } } // 0x97 (151)
		
		protected bool m_InaccuracyFollowsTarget = new bool();
		[ContainerField(Name: "InaccuracyFollowsTarget", Offset: 152, NameHash: 2089483980, Flags: 49325), LayoutImmutable, Blittable]
		public bool InaccuracyFollowsTarget { get { return m_InaccuracyFollowsTarget; } set { if (OnPropertyChanging("AIWeaponData." + nameof(InaccuracyFollowsTarget), this, m_InaccuracyFollowsTarget, value)) m_InaccuracyFollowsTarget = value; } } // 0x98 (152)
		
		protected bool m_UseInaccuracyAtCloseRange = new bool();
		[ContainerField(Name: "UseInaccuracyAtCloseRange", Offset: 153, NameHash: 3668434240, Flags: 49325), LayoutImmutable, Blittable]
		public bool UseInaccuracyAtCloseRange { get { return m_UseInaccuracyAtCloseRange; } set { if (OnPropertyChanging("AIWeaponData." + nameof(UseInaccuracyAtCloseRange), this, m_UseInaccuracyAtCloseRange, value)) m_UseInaccuracyAtCloseRange = value; } } // 0x99 (153)
		
		protected bool m_DisableWeaponSway = new bool();
		[ContainerField(Name: "DisableWeaponSway", Offset: 154, NameHash: 3471637647, Flags: 49325), LayoutImmutable, Blittable]
		public bool DisableWeaponSway { get { return m_DisableWeaponSway; } set { if (OnPropertyChanging("AIWeaponData." + nameof(DisableWeaponSway), this, m_DisableWeaponSway, value)) m_DisableWeaponSway = value; } } // 0x9A (154)
		
		protected bool m_IsAiAllowed = new bool();
		[ContainerField(Name: "IsAiAllowed", Offset: 155, NameHash: 2851797807, Flags: 49325), LayoutImmutable, Blittable]
		public bool IsAiAllowed { get { return m_IsAiAllowed; } set { if (OnPropertyChanging("AIWeaponData." + nameof(IsAiAllowed), this, m_IsAiAllowed, value)) m_IsAiAllowed = value; } } // 0x9B (155)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 580112819:
					Strengths = (Strengths) p_Value;
					break;

				case 285598747:
					MaxBurstCoolDownTime = (float) p_Value;
					break;

				case 3652724376:
					LostTargetBurstCoolDownModifier = (float) p_Value;
					break;

				case 3907857804:
					FinalAccuracyPercentage = (float) p_Value;
					break;

				case 1482171970:
					AimTransitionFireDelay = (float) p_Value;
					break;

				case 3376587952:
					MinRange = (float) p_Value;
					break;

				case 403774958:
					MaxRange = (float) p_Value;
					break;

				case 3315261152:
					OptimalRangePercentage = (float) p_Value;
					break;

				case 454651992:
					ReloadBehavior = (ReloadBehavior) Enum.ToObject(typeof(ReloadBehavior), p_Value);
					break;

				case 956338353:
					MinExtraReloadTime = (float) p_Value;
					break;

				case 2084005999:
					MaxExtraReloadTime = (float) p_Value;
					break;

				case 2068337477:
					MinBurstCoolDownTime = (float) p_Value;
					break;

				case 3342277461:
					AimAngularVelocity = (float) p_Value;
					break;

				case 2665555465:
					InnerInaccurateDistance = (float) p_Value;
					break;

				case 2787320226:
					AngleToTargetSnap = (float) p_Value;
					break;

				case 1593892082:
					SweepDistance = (float) p_Value;
					break;

				case 3730697956:
					SweepTime = (float) p_Value;
					break;

				case 2863734138:
					WaitTimeBeforeFire = (float) p_Value;
					break;

				case 3329385610:
					BurstLimitNear = (BurstLimit) p_Value;
					break;

				case 4005397607:
					BurstLimitFar = (BurstLimit) p_Value;
					break;

				case 2579263552:
					StartAccuracyPercentage = (float) p_Value;
					break;

				case 2922918922:
					MinimumAccuracyBeforeFiring = (float) p_Value;
					break;

				case 519690862:
					OuterInaccurateDistance = (float) p_Value;
					break;

				case 2681805527:
					AdditionalMinimumAccuracyAtMinRange = (float) p_Value;
					break;

				case 1597941524:
					GravityModifier = (float) p_Value;
					break;

				case 3730715017:
					SweepType = (SweepSelectionType) Enum.ToObject(typeof(SweepSelectionType), p_Value);
					break;

				case 2430796116:
					AimOrigin = (AimOrigin) Enum.ToObject(typeof(AimOrigin), p_Value);
					break;

				case 2351209937:
					UseZoom = (bool) p_Value;
					break;

				case 1661149220:
					AllowedAgainstImmortals = (bool) p_Value;
					break;

				case 1978011822:
					AimWhileReloading = (bool) p_Value;
					break;

				case 2747696201:
					AimHighIndirectPath = (bool) p_Value;
					break;

				case 3669286767:
					Indirect = (bool) p_Value;
					break;

				case 2749654459:
					IsMelee = (bool) p_Value;
					break;

				case 1558929635:
					SweepFirstAttack = (bool) p_Value;
					break;

				case 235787346:
					IsBlindFireAllowed = (bool) p_Value;
					break;

				case 1587679768:
					CanAltAttack = (bool) p_Value;
					break;

				case 2163965853:
					IsStandStill = (bool) p_Value;
					break;

				case 1987450488:
					CanSuppress = (bool) p_Value;
					break;

				case 3212905629:
					UseFromCover = (bool) p_Value;
					break;

				case 2089483980:
					InaccuracyFollowsTarget = (bool) p_Value;
					break;

				case 3668434240:
					UseInaccuracyAtCloseRange = (bool) p_Value;
					break;

				case 3471637647:
					DisableWeaponSway = (bool) p_Value;
					break;

				case 2851797807:
					IsAiAllowed = (bool) p_Value;
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
				case 580112819:
					return Strengths;

				case 285598747:
					return MaxBurstCoolDownTime;

				case 3652724376:
					return LostTargetBurstCoolDownModifier;

				case 3907857804:
					return FinalAccuracyPercentage;

				case 1482171970:
					return AimTransitionFireDelay;

				case 3376587952:
					return MinRange;

				case 403774958:
					return MaxRange;

				case 3315261152:
					return OptimalRangePercentage;

				case 454651992:
					return ReloadBehavior;

				case 956338353:
					return MinExtraReloadTime;

				case 2084005999:
					return MaxExtraReloadTime;

				case 2068337477:
					return MinBurstCoolDownTime;

				case 3342277461:
					return AimAngularVelocity;

				case 2665555465:
					return InnerInaccurateDistance;

				case 2787320226:
					return AngleToTargetSnap;

				case 1593892082:
					return SweepDistance;

				case 3730697956:
					return SweepTime;

				case 2863734138:
					return WaitTimeBeforeFire;

				case 3329385610:
					return BurstLimitNear;

				case 4005397607:
					return BurstLimitFar;

				case 2579263552:
					return StartAccuracyPercentage;

				case 2922918922:
					return MinimumAccuracyBeforeFiring;

				case 519690862:
					return OuterInaccurateDistance;

				case 2681805527:
					return AdditionalMinimumAccuracyAtMinRange;

				case 1597941524:
					return GravityModifier;

				case 3730715017:
					return SweepType;

				case 2430796116:
					return AimOrigin;

				case 2351209937:
					return UseZoom;

				case 1661149220:
					return AllowedAgainstImmortals;

				case 1978011822:
					return AimWhileReloading;

				case 2747696201:
					return AimHighIndirectPath;

				case 3669286767:
					return Indirect;

				case 2749654459:
					return IsMelee;

				case 1558929635:
					return SweepFirstAttack;

				case 235787346:
					return IsBlindFireAllowed;

				case 1587679768:
					return CanAltAttack;

				case 2163965853:
					return IsStandStill;

				case 1987450488:
					return CanSuppress;

				case 3212905629:
					return UseFromCover;

				case 2089483980:
					return InaccuracyFollowsTarget;

				case 3668434240:
					return UseInaccuracyAtCloseRange;

				case 3471637647:
					return DisableWeaponSway;

				case 2851797807:
					return IsAiAllowed;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 580112819:
					return typeof(AIWeaponData).GetProperty(nameof(Strengths));

				case 285598747:
					return typeof(AIWeaponData).GetProperty(nameof(MaxBurstCoolDownTime));

				case 3652724376:
					return typeof(AIWeaponData).GetProperty(nameof(LostTargetBurstCoolDownModifier));

				case 3907857804:
					return typeof(AIWeaponData).GetProperty(nameof(FinalAccuracyPercentage));

				case 1482171970:
					return typeof(AIWeaponData).GetProperty(nameof(AimTransitionFireDelay));

				case 3376587952:
					return typeof(AIWeaponData).GetProperty(nameof(MinRange));

				case 403774958:
					return typeof(AIWeaponData).GetProperty(nameof(MaxRange));

				case 3315261152:
					return typeof(AIWeaponData).GetProperty(nameof(OptimalRangePercentage));

				case 454651992:
					return typeof(AIWeaponData).GetProperty(nameof(ReloadBehavior));

				case 956338353:
					return typeof(AIWeaponData).GetProperty(nameof(MinExtraReloadTime));

				case 2084005999:
					return typeof(AIWeaponData).GetProperty(nameof(MaxExtraReloadTime));

				case 2068337477:
					return typeof(AIWeaponData).GetProperty(nameof(MinBurstCoolDownTime));

				case 3342277461:
					return typeof(AIWeaponData).GetProperty(nameof(AimAngularVelocity));

				case 2665555465:
					return typeof(AIWeaponData).GetProperty(nameof(InnerInaccurateDistance));

				case 2787320226:
					return typeof(AIWeaponData).GetProperty(nameof(AngleToTargetSnap));

				case 1593892082:
					return typeof(AIWeaponData).GetProperty(nameof(SweepDistance));

				case 3730697956:
					return typeof(AIWeaponData).GetProperty(nameof(SweepTime));

				case 2863734138:
					return typeof(AIWeaponData).GetProperty(nameof(WaitTimeBeforeFire));

				case 3329385610:
					return typeof(AIWeaponData).GetProperty(nameof(BurstLimitNear));

				case 4005397607:
					return typeof(AIWeaponData).GetProperty(nameof(BurstLimitFar));

				case 2579263552:
					return typeof(AIWeaponData).GetProperty(nameof(StartAccuracyPercentage));

				case 2922918922:
					return typeof(AIWeaponData).GetProperty(nameof(MinimumAccuracyBeforeFiring));

				case 519690862:
					return typeof(AIWeaponData).GetProperty(nameof(OuterInaccurateDistance));

				case 2681805527:
					return typeof(AIWeaponData).GetProperty(nameof(AdditionalMinimumAccuracyAtMinRange));

				case 1597941524:
					return typeof(AIWeaponData).GetProperty(nameof(GravityModifier));

				case 3730715017:
					return typeof(AIWeaponData).GetProperty(nameof(SweepType));

				case 2430796116:
					return typeof(AIWeaponData).GetProperty(nameof(AimOrigin));

				case 2351209937:
					return typeof(AIWeaponData).GetProperty(nameof(UseZoom));

				case 1661149220:
					return typeof(AIWeaponData).GetProperty(nameof(AllowedAgainstImmortals));

				case 1978011822:
					return typeof(AIWeaponData).GetProperty(nameof(AimWhileReloading));

				case 2747696201:
					return typeof(AIWeaponData).GetProperty(nameof(AimHighIndirectPath));

				case 3669286767:
					return typeof(AIWeaponData).GetProperty(nameof(Indirect));

				case 2749654459:
					return typeof(AIWeaponData).GetProperty(nameof(IsMelee));

				case 1558929635:
					return typeof(AIWeaponData).GetProperty(nameof(SweepFirstAttack));

				case 235787346:
					return typeof(AIWeaponData).GetProperty(nameof(IsBlindFireAllowed));

				case 1587679768:
					return typeof(AIWeaponData).GetProperty(nameof(CanAltAttack));

				case 2163965853:
					return typeof(AIWeaponData).GetProperty(nameof(IsStandStill));

				case 1987450488:
					return typeof(AIWeaponData).GetProperty(nameof(CanSuppress));

				case 3212905629:
					return typeof(AIWeaponData).GetProperty(nameof(UseFromCover));

				case 2089483980:
					return typeof(AIWeaponData).GetProperty(nameof(InaccuracyFollowsTarget));

				case 3668434240:
					return typeof(AIWeaponData).GetProperty(nameof(UseInaccuracyAtCloseRange));

				case 3471637647:
					return typeof(AIWeaponData).GetProperty(nameof(DisableWeaponSway));

				case 2851797807:
					return typeof(AIWeaponData).GetProperty(nameof(IsAiAllowed));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
