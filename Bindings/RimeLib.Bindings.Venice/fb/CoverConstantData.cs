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
	[ContainerType(4)]
	public class CoverConstantData : 
		Asset
	{
		protected float m_SlotSize = new float();
		[ContainerField(12), LayoutImmutable, Blittable, ContainerFieldNameHash(3918203300)]
		public float SlotSize { get { return m_SlotSize; } set { if (OnPropertyChanging("CoverConstantData." + nameof(SlotSize), this, m_SlotSize, value)) m_SlotSize = value; } } // 0xC (12)
		
		protected float m_SlotSpacing = new float();
		[ContainerField(16), LayoutImmutable, Blittable, ContainerFieldNameHash(1395752288)]
		public float SlotSpacing { get { return m_SlotSpacing; } set { if (OnPropertyChanging("CoverConstantData." + nameof(SlotSpacing), this, m_SlotSpacing, value)) m_SlotSpacing = value; } } // 0x10 (16)
		
		protected float m_SlotEdgeDistance = new float();
		[ContainerField(20), LayoutImmutable, Blittable, ContainerFieldNameHash(1319913345)]
		public float SlotEdgeDistance { get { return m_SlotEdgeDistance; } set { if (OnPropertyChanging("CoverConstantData." + nameof(SlotEdgeDistance), this, m_SlotEdgeDistance, value)) m_SlotEdgeDistance = value; } } // 0x14 (20)
		
		protected float m_SlotBlockedEdgeDistance = new float();
		[ContainerField(24), LayoutImmutable, Blittable, ContainerFieldNameHash(2628846825)]
		public float SlotBlockedEdgeDistance { get { return m_SlotBlockedEdgeDistance; } set { if (OnPropertyChanging("CoverConstantData." + nameof(SlotBlockedEdgeDistance), this, m_SlotBlockedEdgeDistance, value)) m_SlotBlockedEdgeDistance = value; } } // 0x18 (24)
		
		protected float m_MinimumOpenCoverWidth = new float();
		[ContainerField(28), LayoutImmutable, Blittable, ContainerFieldNameHash(2822304300)]
		public float MinimumOpenCoverWidth { get { return m_MinimumOpenCoverWidth; } set { if (OnPropertyChanging("CoverConstantData." + nameof(MinimumOpenCoverWidth), this, m_MinimumOpenCoverWidth, value)) m_MinimumOpenCoverWidth = value; } } // 0x1C (28)
		
		protected float m_ProneHeight = new float();
		[ContainerField(32), LayoutImmutable, Blittable, ContainerFieldNameHash(3859448060)]
		public float ProneHeight { get { return m_ProneHeight; } set { if (OnPropertyChanging("CoverConstantData." + nameof(ProneHeight), this, m_ProneHeight, value)) m_ProneHeight = value; } } // 0x20 (32)
		
		protected float m_CrouchHeight = new float();
		[ContainerField(36), LayoutImmutable, Blittable, ContainerFieldNameHash(551612122)]
		public float CrouchHeight { get { return m_CrouchHeight; } set { if (OnPropertyChanging("CoverConstantData." + nameof(CrouchHeight), this, m_CrouchHeight, value)) m_CrouchHeight = value; } } // 0x24 (36)
		
		protected float m_MediumHeight = new float();
		[ContainerField(40), LayoutImmutable, Blittable, ContainerFieldNameHash(2211706215)]
		public float MediumHeight { get { return m_MediumHeight; } set { if (OnPropertyChanging("CoverConstantData." + nameof(MediumHeight), this, m_MediumHeight, value)) m_MediumHeight = value; } } // 0x28 (40)
		
		protected float m_StandHeight = new float();
		[ContainerField(44), LayoutImmutable, Blittable, ContainerFieldNameHash(2869204790)]
		public float StandHeight { get { return m_StandHeight; } set { if (OnPropertyChanging("CoverConstantData." + nameof(StandHeight), this, m_StandHeight, value)) m_StandHeight = value; } } // 0x2C (44)
		
		protected int m_MaxCoversInMemory = new int();
		[ContainerField(48), LayoutImmutable, Blittable, ContainerFieldNameHash(3818626601)]
		public int MaxCoversInMemory { get { return m_MaxCoversInMemory; } set { if (OnPropertyChanging("CoverConstantData." + nameof(MaxCoversInMemory), this, m_MaxCoversInMemory, value)) m_MaxCoversInMemory = value; } } // 0x30 (48)
		
		protected float m_SearchRadius = new float();
		[ContainerField(52), LayoutImmutable, Blittable, ContainerFieldNameHash(729979603)]
		public float SearchRadius { get { return m_SearchRadius; } set { if (OnPropertyChanging("CoverConstantData." + nameof(SearchRadius), this, m_SearchRadius, value)) m_SearchRadius = value; } } // 0x34 (52)
		
		protected float m_ProneCoverModifier = new float();
		[ContainerField(56), LayoutImmutable, Blittable, ContainerFieldNameHash(2720606585)]
		public float ProneCoverModifier { get { return m_ProneCoverModifier; } set { if (OnPropertyChanging("CoverConstantData." + nameof(ProneCoverModifier), this, m_ProneCoverModifier, value)) m_ProneCoverModifier = value; } } // 0x38 (56)
		
		protected float m_CrouchCoverModifier = new float();
		[ContainerField(60), LayoutImmutable, Blittable, ContainerFieldNameHash(742208031)]
		public float CrouchCoverModifier { get { return m_CrouchCoverModifier; } set { if (OnPropertyChanging("CoverConstantData." + nameof(CrouchCoverModifier), this, m_CrouchCoverModifier, value)) m_CrouchCoverModifier = value; } } // 0x3C (60)
		
		protected float m_MediumCoverModifier = new float();
		[ContainerField(64), LayoutImmutable, Blittable, ContainerFieldNameHash(2282089730)]
		public float MediumCoverModifier { get { return m_MediumCoverModifier; } set { if (OnPropertyChanging("CoverConstantData." + nameof(MediumCoverModifier), this, m_MediumCoverModifier, value)) m_MediumCoverModifier = value; } } // 0x40 (64)
		
		protected float m_StandCoverModifier = new float();
		[ContainerField(68), LayoutImmutable, Blittable, ContainerFieldNameHash(3932458611)]
		public float StandCoverModifier { get { return m_StandCoverModifier; } set { if (OnPropertyChanging("CoverConstantData." + nameof(StandCoverModifier), this, m_StandCoverModifier, value)) m_StandCoverModifier = value; } } // 0x44 (68)
		
		protected float m_IntermediateCoverSlotModifier = new float();
		[ContainerField(72), LayoutImmutable, Blittable, ContainerFieldNameHash(4285224010)]
		public float IntermediateCoverSlotModifier { get { return m_IntermediateCoverSlotModifier; } set { if (OnPropertyChanging("CoverConstantData." + nameof(IntermediateCoverSlotModifier), this, m_IntermediateCoverSlotModifier, value)) m_IntermediateCoverSlotModifier = value; } } // 0x48 (72)
		
		protected float m_DistanceEvaluationWeight = new float();
		[ContainerField(76), LayoutImmutable, Blittable, ContainerFieldNameHash(1617683600)]
		public float DistanceEvaluationWeight { get { return m_DistanceEvaluationWeight; } set { if (OnPropertyChanging("CoverConstantData." + nameof(DistanceEvaluationWeight), this, m_DistanceEvaluationWeight, value)) m_DistanceEvaluationWeight = value; } } // 0x4C (76)
		
		protected float m_EnemiesEvaluationWeight = new float();
		[ContainerField(80), LayoutImmutable, Blittable, ContainerFieldNameHash(4035572399)]
		public float EnemiesEvaluationWeight { get { return m_EnemiesEvaluationWeight; } set { if (OnPropertyChanging("CoverConstantData." + nameof(EnemiesEvaluationWeight), this, m_EnemiesEvaluationWeight, value)) m_EnemiesEvaluationWeight = value; } } // 0x50 (80)
		
		protected float m_AttackPositionEvaluationWeight = new float();
		[ContainerField(84), LayoutImmutable, Blittable, ContainerFieldNameHash(2635444034)]
		public float AttackPositionEvaluationWeight { get { return m_AttackPositionEvaluationWeight; } set { if (OnPropertyChanging("CoverConstantData." + nameof(AttackPositionEvaluationWeight), this, m_AttackPositionEvaluationWeight, value)) m_AttackPositionEvaluationWeight = value; } } // 0x54 (84)
		
		protected float m_OptimalWeaponDistanceEvaluationWeight = new float();
		[ContainerField(88), LayoutImmutable, Blittable, ContainerFieldNameHash(3699191984)]
		public float OptimalWeaponDistanceEvaluationWeight { get { return m_OptimalWeaponDistanceEvaluationWeight; } set { if (OnPropertyChanging("CoverConstantData." + nameof(OptimalWeaponDistanceEvaluationWeight), this, m_OptimalWeaponDistanceEvaluationWeight, value)) m_OptimalWeaponDistanceEvaluationWeight = value; } } // 0x58 (88)
		
		protected float m_DislikePreviousCoverWeight = new float();
		[ContainerField(92), LayoutImmutable, Blittable, ContainerFieldNameHash(3204472556)]
		public float DislikePreviousCoverWeight { get { return m_DislikePreviousCoverWeight; } set { if (OnPropertyChanging("CoverConstantData." + nameof(DislikePreviousCoverWeight), this, m_DislikePreviousCoverWeight, value)) m_DislikePreviousCoverWeight = value; } } // 0x5C (92)
		
		protected float m_MaxHeightDifference = new float();
		[ContainerField(96), LayoutImmutable, Blittable, ContainerFieldNameHash(3246697817)]
		public float MaxHeightDifference { get { return m_MaxHeightDifference; } set { if (OnPropertyChanging("CoverConstantData." + nameof(MaxHeightDifference), this, m_MaxHeightDifference, value)) m_MaxHeightDifference = value; } } // 0x60 (96)
		
		protected float m_SwitchCoverUrgencyThreshold = new float();
		[ContainerField(100), LayoutImmutable, Blittable, ContainerFieldNameHash(806481724)]
		public float SwitchCoverUrgencyThreshold { get { return m_SwitchCoverUrgencyThreshold; } set { if (OnPropertyChanging("CoverConstantData." + nameof(SwitchCoverUrgencyThreshold), this, m_SwitchCoverUrgencyThreshold, value)) m_SwitchCoverUrgencyThreshold = value; } } // 0x64 (100)
		
		protected float m_ExtraCoverSize = new float();
		[ContainerField(104), LayoutImmutable, Blittable, ContainerFieldNameHash(3013994903)]
		public float ExtraCoverSize { get { return m_ExtraCoverSize; } set { if (OnPropertyChanging("CoverConstantData." + nameof(ExtraCoverSize), this, m_ExtraCoverSize, value)) m_ExtraCoverSize = value; } } // 0x68 (104)
		
		protected float m_ReevaluationTime = new float();
		[ContainerField(108), LayoutImmutable, Blittable, ContainerFieldNameHash(1715847281)]
		public float ReevaluationTime { get { return m_ReevaluationTime; } set { if (OnPropertyChanging("CoverConstantData." + nameof(ReevaluationTime), this, m_ReevaluationTime, value)) m_ReevaluationTime = value; } } // 0x6C (108)
		
		protected CoverSelectionMethod m_CoverSelectionMethod = new CoverSelectionMethod();
		[ContainerField(112), ContainerFieldNameHash(4037794423)]
		public CoverSelectionMethod CoverSelectionMethod { get { return m_CoverSelectionMethod; } set { if (OnPropertyChanging("CoverConstantData." + nameof(CoverSelectionMethod), this, m_CoverSelectionMethod, value)) m_CoverSelectionMethod = value; } } // 0x70 (112)
		
		protected float m_ThreatRadius = new float();
		[ContainerField(116), LayoutImmutable, Blittable, ContainerFieldNameHash(2009254211)]
		public float ThreatRadius { get { return m_ThreatRadius; } set { if (OnPropertyChanging("CoverConstantData." + nameof(ThreatRadius), this, m_ThreatRadius, value)) m_ThreatRadius = value; } } // 0x74 (116)
		
		protected float m_InCoverDistance = new float();
		[ContainerField(120), LayoutImmutable, Blittable, ContainerFieldNameHash(369290380)]
		public float InCoverDistance { get { return m_InCoverDistance; } set { if (OnPropertyChanging("CoverConstantData." + nameof(InCoverDistance), this, m_InCoverDistance, value)) m_InCoverDistance = value; } } // 0x78 (120)
		
		protected float m_MinAttackableEnemyDistance = new float();
		[ContainerField(124), LayoutImmutable, Blittable, ContainerFieldNameHash(4027066708)]
		public float MinAttackableEnemyDistance { get { return m_MinAttackableEnemyDistance; } set { if (OnPropertyChanging("CoverConstantData." + nameof(MinAttackableEnemyDistance), this, m_MinAttackableEnemyDistance, value)) m_MinAttackableEnemyDistance = value; } } // 0x7C (124)
		
		protected float m_CoverFailIgnoreTime = new float();
		[ContainerField(128), LayoutImmutable, Blittable, ContainerFieldNameHash(2922326055)]
		public float CoverFailIgnoreTime { get { return m_CoverFailIgnoreTime; } set { if (OnPropertyChanging("CoverConstantData." + nameof(CoverFailIgnoreTime), this, m_CoverFailIgnoreTime, value)) m_CoverFailIgnoreTime = value; } } // 0x80 (128)
		
		protected float m_StartMeleeFromCoverDistance = new float();
		[ContainerField(132), LayoutImmutable, Blittable, ContainerFieldNameHash(3501080569)]
		public float StartMeleeFromCoverDistance { get { return m_StartMeleeFromCoverDistance; } set { if (OnPropertyChanging("CoverConstantData." + nameof(StartMeleeFromCoverDistance), this, m_StartMeleeFromCoverDistance, value)) m_StartMeleeFromCoverDistance = value; } } // 0x84 (132)
		
		protected float m_ContinueMeleeFromCoverDistance = new float();
		[ContainerField(136), LayoutImmutable, Blittable, ContainerFieldNameHash(2566230616)]
		public float ContinueMeleeFromCoverDistance { get { return m_ContinueMeleeFromCoverDistance; } set { if (OnPropertyChanging("CoverConstantData." + nameof(ContinueMeleeFromCoverDistance), this, m_ContinueMeleeFromCoverDistance, value)) m_ContinueMeleeFromCoverDistance = value; } } // 0x88 (136)
		
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
