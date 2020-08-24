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
	public class AIWeaponData : 
		GameAIWeaponData
	{
		protected Strengths m_Strengths = new Strengths();
		[ContainerField(12), MemberInfoFlag(41), ContainerFieldNameHash(580112819)]
		public Strengths Strengths { get { return m_Strengths; } set { if (OnPropertyChanging("AIWeaponData." + nameof(Strengths), this, m_Strengths, value)) m_Strengths = value; } } // 0xC (12)
		
		protected float m_MaxBurstCoolDownTime = new float();
		[ContainerField(28), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(285598747)]
		public float MaxBurstCoolDownTime { get { return m_MaxBurstCoolDownTime; } set { if (OnPropertyChanging("AIWeaponData." + nameof(MaxBurstCoolDownTime), this, m_MaxBurstCoolDownTime, value)) m_MaxBurstCoolDownTime = value; } } // 0x1C (28)
		
		protected float m_LostTargetBurstCoolDownModifier = new float();
		[ContainerField(32), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(3652724376)]
		public float LostTargetBurstCoolDownModifier { get { return m_LostTargetBurstCoolDownModifier; } set { if (OnPropertyChanging("AIWeaponData." + nameof(LostTargetBurstCoolDownModifier), this, m_LostTargetBurstCoolDownModifier, value)) m_LostTargetBurstCoolDownModifier = value; } } // 0x20 (32)
		
		protected float m_FinalAccuracyPercentage = new float();
		[ContainerField(36), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(3907857804)]
		public float FinalAccuracyPercentage { get { return m_FinalAccuracyPercentage; } set { if (OnPropertyChanging("AIWeaponData." + nameof(FinalAccuracyPercentage), this, m_FinalAccuracyPercentage, value)) m_FinalAccuracyPercentage = value; } } // 0x24 (36)
		
		protected float m_AimTransitionFireDelay = new float();
		[ContainerField(40), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(1482171970)]
		public float AimTransitionFireDelay { get { return m_AimTransitionFireDelay; } set { if (OnPropertyChanging("AIWeaponData." + nameof(AimTransitionFireDelay), this, m_AimTransitionFireDelay, value)) m_AimTransitionFireDelay = value; } } // 0x28 (40)
		
		protected float m_MinRange = new float();
		[ContainerField(44), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(3376587952)]
		public float MinRange { get { return m_MinRange; } set { if (OnPropertyChanging("AIWeaponData." + nameof(MinRange), this, m_MinRange, value)) m_MinRange = value; } } // 0x2C (44)
		
		protected float m_MaxRange = new float();
		[ContainerField(48), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(403774958)]
		public float MaxRange { get { return m_MaxRange; } set { if (OnPropertyChanging("AIWeaponData." + nameof(MaxRange), this, m_MaxRange, value)) m_MaxRange = value; } } // 0x30 (48)
		
		protected float m_OptimalRangePercentage = new float();
		[ContainerField(52), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(3315261152)]
		public float OptimalRangePercentage { get { return m_OptimalRangePercentage; } set { if (OnPropertyChanging("AIWeaponData." + nameof(OptimalRangePercentage), this, m_OptimalRangePercentage, value)) m_OptimalRangePercentage = value; } } // 0x34 (52)
		
		protected ReloadBehavior m_ReloadBehavior = new ReloadBehavior();
		[ContainerField(56), MemberInfoFlag(137), ContainerFieldNameHash(454651992)]
		public ReloadBehavior ReloadBehavior { get { return m_ReloadBehavior; } set { if (OnPropertyChanging("AIWeaponData." + nameof(ReloadBehavior), this, m_ReloadBehavior, value)) m_ReloadBehavior = value; } } // 0x38 (56)
		
		protected float m_MinExtraReloadTime = new float();
		[ContainerField(60), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(956338353)]
		public float MinExtraReloadTime { get { return m_MinExtraReloadTime; } set { if (OnPropertyChanging("AIWeaponData." + nameof(MinExtraReloadTime), this, m_MinExtraReloadTime, value)) m_MinExtraReloadTime = value; } } // 0x3C (60)
		
		protected float m_MaxExtraReloadTime = new float();
		[ContainerField(64), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(2084005999)]
		public float MaxExtraReloadTime { get { return m_MaxExtraReloadTime; } set { if (OnPropertyChanging("AIWeaponData." + nameof(MaxExtraReloadTime), this, m_MaxExtraReloadTime, value)) m_MaxExtraReloadTime = value; } } // 0x40 (64)
		
		protected float m_MinBurstCoolDownTime = new float();
		[ContainerField(68), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(2068337477)]
		public float MinBurstCoolDownTime { get { return m_MinBurstCoolDownTime; } set { if (OnPropertyChanging("AIWeaponData." + nameof(MinBurstCoolDownTime), this, m_MinBurstCoolDownTime, value)) m_MinBurstCoolDownTime = value; } } // 0x44 (68)
		
		protected float m_AimAngularVelocity = new float();
		[ContainerField(72), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(3342277461)]
		public float AimAngularVelocity { get { return m_AimAngularVelocity; } set { if (OnPropertyChanging("AIWeaponData." + nameof(AimAngularVelocity), this, m_AimAngularVelocity, value)) m_AimAngularVelocity = value; } } // 0x48 (72)
		
		protected float m_InnerInaccurateDistance = new float();
		[ContainerField(76), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(2665555465)]
		public float InnerInaccurateDistance { get { return m_InnerInaccurateDistance; } set { if (OnPropertyChanging("AIWeaponData." + nameof(InnerInaccurateDistance), this, m_InnerInaccurateDistance, value)) m_InnerInaccurateDistance = value; } } // 0x4C (76)
		
		protected float m_AngleToTargetSnap = new float();
		[ContainerField(80), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(2787320226)]
		public float AngleToTargetSnap { get { return m_AngleToTargetSnap; } set { if (OnPropertyChanging("AIWeaponData." + nameof(AngleToTargetSnap), this, m_AngleToTargetSnap, value)) m_AngleToTargetSnap = value; } } // 0x50 (80)
		
		protected float m_SweepDistance = new float();
		[ContainerField(84), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(1593892082)]
		public float SweepDistance { get { return m_SweepDistance; } set { if (OnPropertyChanging("AIWeaponData." + nameof(SweepDistance), this, m_SweepDistance, value)) m_SweepDistance = value; } } // 0x54 (84)
		
		protected float m_SweepTime = new float();
		[ContainerField(88), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(3730697956)]
		public float SweepTime { get { return m_SweepTime; } set { if (OnPropertyChanging("AIWeaponData." + nameof(SweepTime), this, m_SweepTime, value)) m_SweepTime = value; } } // 0x58 (88)
		
		protected float m_WaitTimeBeforeFire = new float();
		[ContainerField(92), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(2863734138)]
		public float WaitTimeBeforeFire { get { return m_WaitTimeBeforeFire; } set { if (OnPropertyChanging("AIWeaponData." + nameof(WaitTimeBeforeFire), this, m_WaitTimeBeforeFire, value)) m_WaitTimeBeforeFire = value; } } // 0x5C (92)
		
		protected BurstLimit m_BurstLimitNear = new BurstLimit();
		[ContainerField(96), MemberInfoFlag(41), ContainerFieldNameHash(3329385610)]
		public BurstLimit BurstLimitNear { get { return m_BurstLimitNear; } set { if (OnPropertyChanging("AIWeaponData." + nameof(BurstLimitNear), this, m_BurstLimitNear, value)) m_BurstLimitNear = value; } } // 0x60 (96)
		
		protected BurstLimit m_BurstLimitFar = new BurstLimit();
		[ContainerField(104), MemberInfoFlag(41), ContainerFieldNameHash(4005397607)]
		public BurstLimit BurstLimitFar { get { return m_BurstLimitFar; } set { if (OnPropertyChanging("AIWeaponData." + nameof(BurstLimitFar), this, m_BurstLimitFar, value)) m_BurstLimitFar = value; } } // 0x68 (104)
		
		protected float m_StartAccuracyPercentage = new float();
		[ContainerField(112), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(2579263552)]
		public float StartAccuracyPercentage { get { return m_StartAccuracyPercentage; } set { if (OnPropertyChanging("AIWeaponData." + nameof(StartAccuracyPercentage), this, m_StartAccuracyPercentage, value)) m_StartAccuracyPercentage = value; } } // 0x70 (112)
		
		protected float m_MinimumAccuracyBeforeFiring = new float();
		[ContainerField(116), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(2922918922)]
		public float MinimumAccuracyBeforeFiring { get { return m_MinimumAccuracyBeforeFiring; } set { if (OnPropertyChanging("AIWeaponData." + nameof(MinimumAccuracyBeforeFiring), this, m_MinimumAccuracyBeforeFiring, value)) m_MinimumAccuracyBeforeFiring = value; } } // 0x74 (116)
		
		protected float m_OuterInaccurateDistance = new float();
		[ContainerField(120), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(519690862)]
		public float OuterInaccurateDistance { get { return m_OuterInaccurateDistance; } set { if (OnPropertyChanging("AIWeaponData." + nameof(OuterInaccurateDistance), this, m_OuterInaccurateDistance, value)) m_OuterInaccurateDistance = value; } } // 0x78 (120)
		
		protected float m_AdditionalMinimumAccuracyAtMinRange = new float();
		[ContainerField(124), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(2681805527)]
		public float AdditionalMinimumAccuracyAtMinRange { get { return m_AdditionalMinimumAccuracyAtMinRange; } set { if (OnPropertyChanging("AIWeaponData." + nameof(AdditionalMinimumAccuracyAtMinRange), this, m_AdditionalMinimumAccuracyAtMinRange, value)) m_AdditionalMinimumAccuracyAtMinRange = value; } } // 0x7C (124)
		
		protected float m_GravityModifier = new float();
		[ContainerField(128), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(1597941524)]
		public float GravityModifier { get { return m_GravityModifier; } set { if (OnPropertyChanging("AIWeaponData." + nameof(GravityModifier), this, m_GravityModifier, value)) m_GravityModifier = value; } } // 0x80 (128)
		
		protected SweepSelectionType m_SweepType = new SweepSelectionType();
		[ContainerField(132), MemberInfoFlag(137), ContainerFieldNameHash(3730715017)]
		public SweepSelectionType SweepType { get { return m_SweepType; } set { if (OnPropertyChanging("AIWeaponData." + nameof(SweepType), this, m_SweepType, value)) m_SweepType = value; } } // 0x84 (132)
		
		protected AimOrigin m_AimOrigin = new AimOrigin();
		[ContainerField(136), MemberInfoFlag(137), ContainerFieldNameHash(2430796116)]
		public AimOrigin AimOrigin { get { return m_AimOrigin; } set { if (OnPropertyChanging("AIWeaponData." + nameof(AimOrigin), this, m_AimOrigin, value)) m_AimOrigin = value; } } // 0x88 (136)
		
		protected bool m_UseZoom = new bool();
		[ContainerField(140), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(2351209937)]
		public bool UseZoom { get { return m_UseZoom; } set { if (OnPropertyChanging("AIWeaponData." + nameof(UseZoom), this, m_UseZoom, value)) m_UseZoom = value; } } // 0x8C (140)
		
		protected bool m_AllowedAgainstImmortals = new bool();
		[ContainerField(141), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(1661149220)]
		public bool AllowedAgainstImmortals { get { return m_AllowedAgainstImmortals; } set { if (OnPropertyChanging("AIWeaponData." + nameof(AllowedAgainstImmortals), this, m_AllowedAgainstImmortals, value)) m_AllowedAgainstImmortals = value; } } // 0x8D (141)
		
		protected bool m_AimWhileReloading = new bool();
		[ContainerField(142), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(1978011822)]
		public bool AimWhileReloading { get { return m_AimWhileReloading; } set { if (OnPropertyChanging("AIWeaponData." + nameof(AimWhileReloading), this, m_AimWhileReloading, value)) m_AimWhileReloading = value; } } // 0x8E (142)
		
		protected bool m_AimHighIndirectPath = new bool();
		[ContainerField(143), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(2747696201)]
		public bool AimHighIndirectPath { get { return m_AimHighIndirectPath; } set { if (OnPropertyChanging("AIWeaponData." + nameof(AimHighIndirectPath), this, m_AimHighIndirectPath, value)) m_AimHighIndirectPath = value; } } // 0x8F (143)
		
		protected bool m_Indirect = new bool();
		[ContainerField(144), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(3669286767)]
		public bool Indirect { get { return m_Indirect; } set { if (OnPropertyChanging("AIWeaponData." + nameof(Indirect), this, m_Indirect, value)) m_Indirect = value; } } // 0x90 (144)
		
		protected bool m_IsMelee = new bool();
		[ContainerField(145), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(2749654459)]
		public bool IsMelee { get { return m_IsMelee; } set { if (OnPropertyChanging("AIWeaponData." + nameof(IsMelee), this, m_IsMelee, value)) m_IsMelee = value; } } // 0x91 (145)
		
		protected bool m_SweepFirstAttack = new bool();
		[ContainerField(146), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(1558929635)]
		public bool SweepFirstAttack { get { return m_SweepFirstAttack; } set { if (OnPropertyChanging("AIWeaponData." + nameof(SweepFirstAttack), this, m_SweepFirstAttack, value)) m_SweepFirstAttack = value; } } // 0x92 (146)
		
		protected bool m_IsBlindFireAllowed = new bool();
		[ContainerField(147), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(235787346)]
		public bool IsBlindFireAllowed { get { return m_IsBlindFireAllowed; } set { if (OnPropertyChanging("AIWeaponData." + nameof(IsBlindFireAllowed), this, m_IsBlindFireAllowed, value)) m_IsBlindFireAllowed = value; } } // 0x93 (147)
		
		protected bool m_CanAltAttack = new bool();
		[ContainerField(148), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(1587679768)]
		public bool CanAltAttack { get { return m_CanAltAttack; } set { if (OnPropertyChanging("AIWeaponData." + nameof(CanAltAttack), this, m_CanAltAttack, value)) m_CanAltAttack = value; } } // 0x94 (148)
		
		protected bool m_IsStandStill = new bool();
		[ContainerField(149), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(2163965853)]
		public bool IsStandStill { get { return m_IsStandStill; } set { if (OnPropertyChanging("AIWeaponData." + nameof(IsStandStill), this, m_IsStandStill, value)) m_IsStandStill = value; } } // 0x95 (149)
		
		protected bool m_CanSuppress = new bool();
		[ContainerField(150), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(1987450488)]
		public bool CanSuppress { get { return m_CanSuppress; } set { if (OnPropertyChanging("AIWeaponData." + nameof(CanSuppress), this, m_CanSuppress, value)) m_CanSuppress = value; } } // 0x96 (150)
		
		protected bool m_UseFromCover = new bool();
		[ContainerField(151), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(3212905629)]
		public bool UseFromCover { get { return m_UseFromCover; } set { if (OnPropertyChanging("AIWeaponData." + nameof(UseFromCover), this, m_UseFromCover, value)) m_UseFromCover = value; } } // 0x97 (151)
		
		protected bool m_InaccuracyFollowsTarget = new bool();
		[ContainerField(152), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(2089483980)]
		public bool InaccuracyFollowsTarget { get { return m_InaccuracyFollowsTarget; } set { if (OnPropertyChanging("AIWeaponData." + nameof(InaccuracyFollowsTarget), this, m_InaccuracyFollowsTarget, value)) m_InaccuracyFollowsTarget = value; } } // 0x98 (152)
		
		protected bool m_UseInaccuracyAtCloseRange = new bool();
		[ContainerField(153), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(3668434240)]
		public bool UseInaccuracyAtCloseRange { get { return m_UseInaccuracyAtCloseRange; } set { if (OnPropertyChanging("AIWeaponData." + nameof(UseInaccuracyAtCloseRange), this, m_UseInaccuracyAtCloseRange, value)) m_UseInaccuracyAtCloseRange = value; } } // 0x99 (153)
		
		protected bool m_DisableWeaponSway = new bool();
		[ContainerField(154), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(3471637647)]
		public bool DisableWeaponSway { get { return m_DisableWeaponSway; } set { if (OnPropertyChanging("AIWeaponData." + nameof(DisableWeaponSway), this, m_DisableWeaponSway, value)) m_DisableWeaponSway = value; } } // 0x9A (154)
		
		protected bool m_IsAiAllowed = new bool();
		[ContainerField(155), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(2851797807)]
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
