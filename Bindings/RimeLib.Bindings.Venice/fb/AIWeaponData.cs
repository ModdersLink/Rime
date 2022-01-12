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
	[ContainerType(4, 156)]
	public class AIWeaponData : 
		GameAIWeaponData
	{
		[ContainerField(12)]
		public Strengths Strengths { get; set; } = new();

		[ContainerField(28), LayoutImmutable, Blittable]
		public float MaxBurstCoolDownTime { get; set; }

		[ContainerField(32), LayoutImmutable, Blittable]
		public float LostTargetBurstCoolDownModifier { get; set; }

		[ContainerField(36), LayoutImmutable, Blittable]
		public float FinalAccuracyPercentage { get; set; }

		[ContainerField(40), LayoutImmutable, Blittable]
		public float AimTransitionFireDelay { get; set; }

		[ContainerField(44), LayoutImmutable, Blittable]
		public float MinRange { get; set; }

		[ContainerField(48), LayoutImmutable, Blittable]
		public float MaxRange { get; set; }

		[ContainerField(52), LayoutImmutable, Blittable]
		public float OptimalRangePercentage { get; set; }

		[ContainerField(56)]
		public ReloadBehavior ReloadBehavior { get; set; } = new();

		[ContainerField(60), LayoutImmutable, Blittable]
		public float MinExtraReloadTime { get; set; }

		[ContainerField(64), LayoutImmutable, Blittable]
		public float MaxExtraReloadTime { get; set; }

		[ContainerField(68), LayoutImmutable, Blittable]
		public float MinBurstCoolDownTime { get; set; }

		[ContainerField(72), LayoutImmutable, Blittable]
		public float AimAngularVelocity { get; set; }

		[ContainerField(76), LayoutImmutable, Blittable]
		public float InnerInaccurateDistance { get; set; }

		[ContainerField(80), LayoutImmutable, Blittable]
		public float AngleToTargetSnap { get; set; }

		[ContainerField(84), LayoutImmutable, Blittable]
		public float SweepDistance { get; set; }

		[ContainerField(88), LayoutImmutable, Blittable]
		public float SweepTime { get; set; }

		[ContainerField(92), LayoutImmutable, Blittable]
		public float WaitTimeBeforeFire { get; set; }

		[ContainerField(96)]
		public BurstLimit BurstLimitNear { get; set; } = new();

		[ContainerField(104)]
		public BurstLimit BurstLimitFar { get; set; } = new();

		[ContainerField(112), LayoutImmutable, Blittable]
		public float StartAccuracyPercentage { get; set; }

		[ContainerField(116), LayoutImmutable, Blittable]
		public float MinimumAccuracyBeforeFiring { get; set; }

		[ContainerField(120), LayoutImmutable, Blittable]
		public float OuterInaccurateDistance { get; set; }

		[ContainerField(124), LayoutImmutable, Blittable]
		public float AdditionalMinimumAccuracyAtMinRange { get; set; }

		[ContainerField(128), LayoutImmutable, Blittable]
		public float GravityModifier { get; set; }

		[ContainerField(132)]
		public SweepSelectionType SweepType { get; set; } = new();

		[ContainerField(136)]
		public AimOrigin AimOrigin { get; set; } = new();

		[ContainerField(140), LayoutImmutable, Blittable]
		public bool UseZoom { get; set; }

		[ContainerField(141), LayoutImmutable, Blittable]
		public bool AllowedAgainstImmortals { get; set; }

		[ContainerField(142), LayoutImmutable, Blittable]
		public bool AimWhileReloading { get; set; }

		[ContainerField(143), LayoutImmutable, Blittable]
		public bool AimHighIndirectPath { get; set; }

		[ContainerField(144), LayoutImmutable, Blittable]
		public bool Indirect { get; set; }

		[ContainerField(145), LayoutImmutable, Blittable]
		public bool IsMelee { get; set; }

		[ContainerField(146), LayoutImmutable, Blittable]
		public bool SweepFirstAttack { get; set; }

		[ContainerField(147), LayoutImmutable, Blittable]
		public bool IsBlindFireAllowed { get; set; }

		[ContainerField(148), LayoutImmutable, Blittable]
		public bool CanAltAttack { get; set; }

		[ContainerField(149), LayoutImmutable, Blittable]
		public bool IsStandStill { get; set; }

		[ContainerField(150), LayoutImmutable, Blittable]
		public bool CanSuppress { get; set; }

		[ContainerField(151), LayoutImmutable, Blittable]
		public bool UseFromCover { get; set; }

		[ContainerField(152), LayoutImmutable, Blittable]
		public bool InaccuracyFollowsTarget { get; set; }

		[ContainerField(153), LayoutImmutable, Blittable]
		public bool UseInaccuracyAtCloseRange { get; set; }

		[ContainerField(154), LayoutImmutable, Blittable]
		public bool DisableWeaponSway { get; set; }

		[ContainerField(155), LayoutImmutable, Blittable]
		public bool IsAiAllowed { get; set; }

	}
}
