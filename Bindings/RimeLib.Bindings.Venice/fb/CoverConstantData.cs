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
	public class CoverConstantData : 
		Asset
	{
		[ContainerField(12), LayoutImmutable, Blittable]
		public float SlotSize { get; set; } // 0xC (12)
		
		[ContainerField(16), LayoutImmutable, Blittable]
		public float SlotSpacing { get; set; } // 0x10 (16)
		
		[ContainerField(20), LayoutImmutable, Blittable]
		public float SlotEdgeDistance { get; set; } // 0x14 (20)
		
		[ContainerField(24), LayoutImmutable, Blittable]
		public float SlotBlockedEdgeDistance { get; set; } // 0x18 (24)
		
		[ContainerField(28), LayoutImmutable, Blittable]
		public float MinimumOpenCoverWidth { get; set; } // 0x1C (28)
		
		[ContainerField(32), LayoutImmutable, Blittable]
		public float ProneHeight { get; set; } // 0x20 (32)
		
		[ContainerField(36), LayoutImmutable, Blittable]
		public float CrouchHeight { get; set; } // 0x24 (36)
		
		[ContainerField(40), LayoutImmutable, Blittable]
		public float MediumHeight { get; set; } // 0x28 (40)
		
		[ContainerField(44), LayoutImmutable, Blittable]
		public float StandHeight { get; set; } // 0x2C (44)
		
		[ContainerField(48), LayoutImmutable, Blittable]
		public int MaxCoversInMemory { get; set; } // 0x30 (48)
		
		[ContainerField(52), LayoutImmutable, Blittable]
		public float SearchRadius { get; set; } // 0x34 (52)
		
		[ContainerField(56), LayoutImmutable, Blittable]
		public float ProneCoverModifier { get; set; } // 0x38 (56)
		
		[ContainerField(60), LayoutImmutable, Blittable]
		public float CrouchCoverModifier { get; set; } // 0x3C (60)
		
		[ContainerField(64), LayoutImmutable, Blittable]
		public float MediumCoverModifier { get; set; } // 0x40 (64)
		
		[ContainerField(68), LayoutImmutable, Blittable]
		public float StandCoverModifier { get; set; } // 0x44 (68)
		
		[ContainerField(72), LayoutImmutable, Blittable]
		public float IntermediateCoverSlotModifier { get; set; } // 0x48 (72)
		
		[ContainerField(76), LayoutImmutable, Blittable]
		public float DistanceEvaluationWeight { get; set; } // 0x4C (76)
		
		[ContainerField(80), LayoutImmutable, Blittable]
		public float EnemiesEvaluationWeight { get; set; } // 0x50 (80)
		
		[ContainerField(84), LayoutImmutable, Blittable]
		public float AttackPositionEvaluationWeight { get; set; } // 0x54 (84)
		
		[ContainerField(88), LayoutImmutable, Blittable]
		public float OptimalWeaponDistanceEvaluationWeight { get; set; } // 0x58 (88)
		
		[ContainerField(92), LayoutImmutable, Blittable]
		public float DislikePreviousCoverWeight { get; set; } // 0x5C (92)
		
		[ContainerField(96), LayoutImmutable, Blittable]
		public float MaxHeightDifference { get; set; } // 0x60 (96)
		
		[ContainerField(100), LayoutImmutable, Blittable]
		public float SwitchCoverUrgencyThreshold { get; set; } // 0x64 (100)
		
		[ContainerField(104), LayoutImmutable, Blittable]
		public float ExtraCoverSize { get; set; } // 0x68 (104)
		
		[ContainerField(108), LayoutImmutable, Blittable]
		public float ReevaluationTime { get; set; } // 0x6C (108)
		
		[ContainerField(112)]
		public CoverSelectionMethod CoverSelectionMethod { get; set; } = new CoverSelectionMethod(); // 0x70 (112)
		
		[ContainerField(116), LayoutImmutable, Blittable]
		public float ThreatRadius { get; set; } // 0x74 (116)
		
		[ContainerField(120), LayoutImmutable, Blittable]
		public float InCoverDistance { get; set; } // 0x78 (120)
		
		[ContainerField(124), LayoutImmutable, Blittable]
		public float MinAttackableEnemyDistance { get; set; } // 0x7C (124)
		
		[ContainerField(128), LayoutImmutable, Blittable]
		public float CoverFailIgnoreTime { get; set; } // 0x80 (128)
		
		[ContainerField(132), LayoutImmutable, Blittable]
		public float StartMeleeFromCoverDistance { get; set; } // 0x84 (132)
		
		[ContainerField(136), LayoutImmutable, Blittable]
		public float ContinueMeleeFromCoverDistance { get; set; } // 0x88 (136)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 3918203300:
					SlotSize = (float) p_Value;
					break;

				case 1395752288:
					SlotSpacing = (float) p_Value;
					break;

				case 1319913345:
					SlotEdgeDistance = (float) p_Value;
					break;

				case 2628846825:
					SlotBlockedEdgeDistance = (float) p_Value;
					break;

				case 2822304300:
					MinimumOpenCoverWidth = (float) p_Value;
					break;

				case 3859448060:
					ProneHeight = (float) p_Value;
					break;

				case 551612122:
					CrouchHeight = (float) p_Value;
					break;

				case 2211706215:
					MediumHeight = (float) p_Value;
					break;

				case 2869204790:
					StandHeight = (float) p_Value;
					break;

				case 3818626601:
					MaxCoversInMemory = (int) p_Value;
					break;

				case 729979603:
					SearchRadius = (float) p_Value;
					break;

				case 2720606585:
					ProneCoverModifier = (float) p_Value;
					break;

				case 742208031:
					CrouchCoverModifier = (float) p_Value;
					break;

				case 2282089730:
					MediumCoverModifier = (float) p_Value;
					break;

				case 3932458611:
					StandCoverModifier = (float) p_Value;
					break;

				case 4285224010:
					IntermediateCoverSlotModifier = (float) p_Value;
					break;

				case 1617683600:
					DistanceEvaluationWeight = (float) p_Value;
					break;

				case 4035572399:
					EnemiesEvaluationWeight = (float) p_Value;
					break;

				case 2635444034:
					AttackPositionEvaluationWeight = (float) p_Value;
					break;

				case 3699191984:
					OptimalWeaponDistanceEvaluationWeight = (float) p_Value;
					break;

				case 3204472556:
					DislikePreviousCoverWeight = (float) p_Value;
					break;

				case 3246697817:
					MaxHeightDifference = (float) p_Value;
					break;

				case 806481724:
					SwitchCoverUrgencyThreshold = (float) p_Value;
					break;

				case 3013994903:
					ExtraCoverSize = (float) p_Value;
					break;

				case 1715847281:
					ReevaluationTime = (float) p_Value;
					break;

				case 4037794423:
					CoverSelectionMethod = (CoverSelectionMethod) Enum.ToObject(typeof(CoverSelectionMethod), p_Value);
					break;

				case 2009254211:
					ThreatRadius = (float) p_Value;
					break;

				case 369290380:
					InCoverDistance = (float) p_Value;
					break;

				case 4027066708:
					MinAttackableEnemyDistance = (float) p_Value;
					break;

				case 2922326055:
					CoverFailIgnoreTime = (float) p_Value;
					break;

				case 3501080569:
					StartMeleeFromCoverDistance = (float) p_Value;
					break;

				case 2566230616:
					ContinueMeleeFromCoverDistance = (float) p_Value;
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
				case 3918203300:
					return SlotSize;

				case 1395752288:
					return SlotSpacing;

				case 1319913345:
					return SlotEdgeDistance;

				case 2628846825:
					return SlotBlockedEdgeDistance;

				case 2822304300:
					return MinimumOpenCoverWidth;

				case 3859448060:
					return ProneHeight;

				case 551612122:
					return CrouchHeight;

				case 2211706215:
					return MediumHeight;

				case 2869204790:
					return StandHeight;

				case 3818626601:
					return MaxCoversInMemory;

				case 729979603:
					return SearchRadius;

				case 2720606585:
					return ProneCoverModifier;

				case 742208031:
					return CrouchCoverModifier;

				case 2282089730:
					return MediumCoverModifier;

				case 3932458611:
					return StandCoverModifier;

				case 4285224010:
					return IntermediateCoverSlotModifier;

				case 1617683600:
					return DistanceEvaluationWeight;

				case 4035572399:
					return EnemiesEvaluationWeight;

				case 2635444034:
					return AttackPositionEvaluationWeight;

				case 3699191984:
					return OptimalWeaponDistanceEvaluationWeight;

				case 3204472556:
					return DislikePreviousCoverWeight;

				case 3246697817:
					return MaxHeightDifference;

				case 806481724:
					return SwitchCoverUrgencyThreshold;

				case 3013994903:
					return ExtraCoverSize;

				case 1715847281:
					return ReevaluationTime;

				case 4037794423:
					return CoverSelectionMethod;

				case 2009254211:
					return ThreatRadius;

				case 369290380:
					return InCoverDistance;

				case 4027066708:
					return MinAttackableEnemyDistance;

				case 2922326055:
					return CoverFailIgnoreTime;

				case 3501080569:
					return StartMeleeFromCoverDistance;

				case 2566230616:
					return ContinueMeleeFromCoverDistance;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 3918203300:
					return typeof(CoverConstantData).GetProperty(nameof(SlotSize));

				case 1395752288:
					return typeof(CoverConstantData).GetProperty(nameof(SlotSpacing));

				case 1319913345:
					return typeof(CoverConstantData).GetProperty(nameof(SlotEdgeDistance));

				case 2628846825:
					return typeof(CoverConstantData).GetProperty(nameof(SlotBlockedEdgeDistance));

				case 2822304300:
					return typeof(CoverConstantData).GetProperty(nameof(MinimumOpenCoverWidth));

				case 3859448060:
					return typeof(CoverConstantData).GetProperty(nameof(ProneHeight));

				case 551612122:
					return typeof(CoverConstantData).GetProperty(nameof(CrouchHeight));

				case 2211706215:
					return typeof(CoverConstantData).GetProperty(nameof(MediumHeight));

				case 2869204790:
					return typeof(CoverConstantData).GetProperty(nameof(StandHeight));

				case 3818626601:
					return typeof(CoverConstantData).GetProperty(nameof(MaxCoversInMemory));

				case 729979603:
					return typeof(CoverConstantData).GetProperty(nameof(SearchRadius));

				case 2720606585:
					return typeof(CoverConstantData).GetProperty(nameof(ProneCoverModifier));

				case 742208031:
					return typeof(CoverConstantData).GetProperty(nameof(CrouchCoverModifier));

				case 2282089730:
					return typeof(CoverConstantData).GetProperty(nameof(MediumCoverModifier));

				case 3932458611:
					return typeof(CoverConstantData).GetProperty(nameof(StandCoverModifier));

				case 4285224010:
					return typeof(CoverConstantData).GetProperty(nameof(IntermediateCoverSlotModifier));

				case 1617683600:
					return typeof(CoverConstantData).GetProperty(nameof(DistanceEvaluationWeight));

				case 4035572399:
					return typeof(CoverConstantData).GetProperty(nameof(EnemiesEvaluationWeight));

				case 2635444034:
					return typeof(CoverConstantData).GetProperty(nameof(AttackPositionEvaluationWeight));

				case 3699191984:
					return typeof(CoverConstantData).GetProperty(nameof(OptimalWeaponDistanceEvaluationWeight));

				case 3204472556:
					return typeof(CoverConstantData).GetProperty(nameof(DislikePreviousCoverWeight));

				case 3246697817:
					return typeof(CoverConstantData).GetProperty(nameof(MaxHeightDifference));

				case 806481724:
					return typeof(CoverConstantData).GetProperty(nameof(SwitchCoverUrgencyThreshold));

				case 3013994903:
					return typeof(CoverConstantData).GetProperty(nameof(ExtraCoverSize));

				case 1715847281:
					return typeof(CoverConstantData).GetProperty(nameof(ReevaluationTime));

				case 4037794423:
					return typeof(CoverConstantData).GetProperty(nameof(CoverSelectionMethod));

				case 2009254211:
					return typeof(CoverConstantData).GetProperty(nameof(ThreatRadius));

				case 369290380:
					return typeof(CoverConstantData).GetProperty(nameof(InCoverDistance));

				case 4027066708:
					return typeof(CoverConstantData).GetProperty(nameof(MinAttackableEnemyDistance));

				case 2922326055:
					return typeof(CoverConstantData).GetProperty(nameof(CoverFailIgnoreTime));

				case 3501080569:
					return typeof(CoverConstantData).GetProperty(nameof(StartMeleeFromCoverDistance));

				case 2566230616:
					return typeof(CoverConstantData).GetProperty(nameof(ContinueMeleeFromCoverDistance));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
