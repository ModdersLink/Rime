///////////////////////////////////////////////////////////////
//                                                           //
// This is an automatically generated file.                  //
// Do *NOT* modify unless you really know what you're doing. //
//                                                           //
///////////////////////////////////////////////////////////////

using System;
using System.Reflection;using RimeLib.Serialization.Attributes;using RimeLib.Serialization.Ebx;using RimeLib.Serialization.Containers;using RimeLib.Frostbite.Core;

namespace fb
{
    [ContainerType(4)]
	public class AIWeaponData : 
		GameAIWeaponData
	{
		[ContainerField(12)]
		public Strengths Strengths { get; set; } = new Strengths(); // 0xC (12)
		
		[ContainerField(28), LayoutImmutable, Blittable]
		public float MaxBurstCoolDownTime { get; set; } // 0x1C (28)
		
		[ContainerField(32), LayoutImmutable, Blittable]
		public float LostTargetBurstCoolDownModifier { get; set; } // 0x20 (32)
		
		[ContainerField(36), LayoutImmutable, Blittable]
		public float FinalAccuracyPercentage { get; set; } // 0x24 (36)
		
		[ContainerField(40), LayoutImmutable, Blittable]
		public float AimTransitionFireDelay { get; set; } // 0x28 (40)
		
		[ContainerField(44), LayoutImmutable, Blittable]
		public float MinRange { get; set; } // 0x2C (44)
		
		[ContainerField(48), LayoutImmutable, Blittable]
		public float MaxRange { get; set; } // 0x30 (48)
		
		[ContainerField(52), LayoutImmutable, Blittable]
		public float OptimalRangePercentage { get; set; } // 0x34 (52)
		
		[ContainerField(56)]
		public ReloadBehavior ReloadBehavior { get; set; } = new ReloadBehavior(); // 0x38 (56)
		
		[ContainerField(60), LayoutImmutable, Blittable]
		public float MinExtraReloadTime { get; set; } // 0x3C (60)
		
		[ContainerField(64), LayoutImmutable, Blittable]
		public float MaxExtraReloadTime { get; set; } // 0x40 (64)
		
		[ContainerField(68), LayoutImmutable, Blittable]
		public float MinBurstCoolDownTime { get; set; } // 0x44 (68)
		
		[ContainerField(72), LayoutImmutable, Blittable]
		public float AimAngularVelocity { get; set; } // 0x48 (72)
		
		[ContainerField(76), LayoutImmutable, Blittable]
		public float InnerInaccurateDistance { get; set; } // 0x4C (76)
		
		[ContainerField(80), LayoutImmutable, Blittable]
		public float AngleToTargetSnap { get; set; } // 0x50 (80)
		
		[ContainerField(84), LayoutImmutable, Blittable]
		public float SweepDistance { get; set; } // 0x54 (84)
		
		[ContainerField(88), LayoutImmutable, Blittable]
		public float SweepTime { get; set; } // 0x58 (88)
		
		[ContainerField(92), LayoutImmutable, Blittable]
		public float WaitTimeBeforeFire { get; set; } // 0x5C (92)
		
		[ContainerField(96)]
		public BurstLimit BurstLimitNear { get; set; } = new BurstLimit(); // 0x60 (96)
		
		[ContainerField(104)]
		public BurstLimit BurstLimitFar { get; set; } = new BurstLimit(); // 0x68 (104)
		
		[ContainerField(112), LayoutImmutable, Blittable]
		public float StartAccuracyPercentage { get; set; } // 0x70 (112)
		
		[ContainerField(116), LayoutImmutable, Blittable]
		public float MinimumAccuracyBeforeFiring { get; set; } // 0x74 (116)
		
		[ContainerField(120), LayoutImmutable, Blittable]
		public float OuterInaccurateDistance { get; set; } // 0x78 (120)
		
		[ContainerField(124), LayoutImmutable, Blittable]
		public float AdditionalMinimumAccuracyAtMinRange { get; set; } // 0x7C (124)
		
		[ContainerField(128), LayoutImmutable, Blittable]
		public float GravityModifier { get; set; } // 0x80 (128)
		
		[ContainerField(132)]
		public SweepSelectionType SweepType { get; set; } = new SweepSelectionType(); // 0x84 (132)
		
		[ContainerField(136)]
		public AimOrigin AimOrigin { get; set; } = new AimOrigin(); // 0x88 (136)
		
		[ContainerField(140), LayoutImmutable, Blittable]
		public bool UseZoom { get; set; } // 0x8C (140)
		
		[ContainerField(141), LayoutImmutable, Blittable]
		public bool AllowedAgainstImmortals { get; set; } // 0x8D (141)
		
		[ContainerField(142), LayoutImmutable, Blittable]
		public bool AimWhileReloading { get; set; } // 0x8E (142)
		
		[ContainerField(143), LayoutImmutable, Blittable]
		public bool AimHighIndirectPath { get; set; } // 0x8F (143)
		
		[ContainerField(144), LayoutImmutable, Blittable]
		public bool Indirect { get; set; } // 0x90 (144)
		
		[ContainerField(145), LayoutImmutable, Blittable]
		public bool IsMelee { get; set; } // 0x91 (145)
		
		[ContainerField(146), LayoutImmutable, Blittable]
		public bool SweepFirstAttack { get; set; } // 0x92 (146)
		
		[ContainerField(147), LayoutImmutable, Blittable]
		public bool IsBlindFireAllowed { get; set; } // 0x93 (147)
		
		[ContainerField(148), LayoutImmutable, Blittable]
		public bool CanAltAttack { get; set; } // 0x94 (148)
		
		[ContainerField(149), LayoutImmutable, Blittable]
		public bool IsStandStill { get; set; } // 0x95 (149)
		
		[ContainerField(150), LayoutImmutable, Blittable]
		public bool CanSuppress { get; set; } // 0x96 (150)
		
		[ContainerField(151), LayoutImmutable, Blittable]
		public bool UseFromCover { get; set; } // 0x97 (151)
		
		[ContainerField(152), LayoutImmutable, Blittable]
		public bool InaccuracyFollowsTarget { get; set; } // 0x98 (152)
		
		[ContainerField(153), LayoutImmutable, Blittable]
		public bool UseInaccuracyAtCloseRange { get; set; } // 0x99 (153)
		
		[ContainerField(154), LayoutImmutable, Blittable]
		public bool DisableWeaponSway { get; set; } // 0x9A (154)
		
		[ContainerField(155), LayoutImmutable, Blittable]
		public bool IsAiAllowed { get; set; } // 0x9B (155)
		
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
