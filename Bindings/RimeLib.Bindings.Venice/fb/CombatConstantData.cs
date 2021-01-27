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
	[ContainerType(Alignment: 4,  Flags: 53, Size: 120)]
	public class CombatConstantData : 
		Asset
	{
		protected float m_PoseTransitionFireDelay = new float();
		[ContainerField(Name: "PoseTransitionFireDelay", Offset: 12, NameHash: 1389063054, Flags: 49469), LayoutImmutable, Blittable]
		public float PoseTransitionFireDelay { get { return m_PoseTransitionFireDelay; } set { if (OnPropertyChanging("CombatConstantData." + nameof(PoseTransitionFireDelay), this, m_PoseTransitionFireDelay, value)) m_PoseTransitionFireDelay = value; } } // 0xC (12)
		
		protected float m_ChangePoseStopDelay = new float();
		[ContainerField(Name: "ChangePoseStopDelay", Offset: 16, NameHash: 1131204007, Flags: 49469), LayoutImmutable, Blittable]
		public float ChangePoseStopDelay { get { return m_ChangePoseStopDelay; } set { if (OnPropertyChanging("CombatConstantData." + nameof(ChangePoseStopDelay), this, m_ChangePoseStopDelay, value)) m_ChangePoseStopDelay = value; } } // 0x10 (16)
		
		protected float m_AllowCrouchFiringWaterLevel = new float();
		[ContainerField(Name: "AllowCrouchFiringWaterLevel", Offset: 20, NameHash: 255588098, Flags: 49469), LayoutImmutable, Blittable]
		public float AllowCrouchFiringWaterLevel { get { return m_AllowCrouchFiringWaterLevel; } set { if (OnPropertyChanging("CombatConstantData." + nameof(AllowCrouchFiringWaterLevel), this, m_AllowCrouchFiringWaterLevel, value)) m_AllowCrouchFiringWaterLevel = value; } } // 0x14 (20)
		
		protected float m_PoseChangeLockoutTime = new float();
		[ContainerField(Name: "PoseChangeLockoutTime", Offset: 24, NameHash: 3713665594, Flags: 49469), LayoutImmutable, Blittable]
		public float PoseChangeLockoutTime { get { return m_PoseChangeLockoutTime; } set { if (OnPropertyChanging("CombatConstantData." + nameof(PoseChangeLockoutTime), this, m_PoseChangeLockoutTime, value)) m_PoseChangeLockoutTime = value; } } // 0x18 (24)
		
		protected float m_ExplosionInterestRange = new float();
		[ContainerField(Name: "ExplosionInterestRange", Offset: 28, NameHash: 93209033, Flags: 49469), LayoutImmutable, Blittable]
		public float ExplosionInterestRange { get { return m_ExplosionInterestRange; } set { if (OnPropertyChanging("CombatConstantData." + nameof(ExplosionInterestRange), this, m_ExplosionInterestRange, value)) m_ExplosionInterestRange = value; } } // 0x1C (28)
		
		protected float m_ExplosiveObjectSearchRadius = new float();
		[ContainerField(Name: "ExplosiveObjectSearchRadius", Offset: 32, NameHash: 998458977, Flags: 49469), LayoutImmutable, Blittable]
		public float ExplosiveObjectSearchRadius { get { return m_ExplosiveObjectSearchRadius; } set { if (OnPropertyChanging("CombatConstantData." + nameof(ExplosiveObjectSearchRadius), this, m_ExplosiveObjectSearchRadius, value)) m_ExplosiveObjectSearchRadius = value; } } // 0x20 (32)
		
		protected float m_ExplosiveBlastMultiplier = new float();
		[ContainerField(Name: "ExplosiveBlastMultiplier", Offset: 36, NameHash: 1067074529, Flags: 49469), LayoutImmutable, Blittable]
		public float ExplosiveBlastMultiplier { get { return m_ExplosiveBlastMultiplier; } set { if (OnPropertyChanging("CombatConstantData." + nameof(ExplosiveBlastMultiplier), this, m_ExplosiveBlastMultiplier, value)) m_ExplosiveBlastMultiplier = value; } } // 0x24 (36)
		
		protected float m_MaxSuppressDistance = new float();
		[ContainerField(Name: "MaxSuppressDistance", Offset: 40, NameHash: 305591139, Flags: 49469), LayoutImmutable, Blittable]
		public float MaxSuppressDistance { get { return m_MaxSuppressDistance; } set { if (OnPropertyChanging("CombatConstantData." + nameof(MaxSuppressDistance), this, m_MaxSuppressDistance, value)) m_MaxSuppressDistance = value; } } // 0x28 (40)
		
		protected float m_MaxSuppressorsRatio = new float();
		[ContainerField(Name: "MaxSuppressorsRatio", Offset: 44, NameHash: 2648235343, Flags: 49469), LayoutImmutable, Blittable]
		public float MaxSuppressorsRatio { get { return m_MaxSuppressorsRatio; } set { if (OnPropertyChanging("CombatConstantData." + nameof(MaxSuppressorsRatio), this, m_MaxSuppressorsRatio, value)) m_MaxSuppressorsRatio = value; } } // 0x2C (44)
		
		protected float m_SuppressOffsetXz = new float();
		[ContainerField(Name: "SuppressOffsetXz", Offset: 48, NameHash: 827702331, Flags: 49469), LayoutImmutable, Blittable]
		public float SuppressOffsetXz { get { return m_SuppressOffsetXz; } set { if (OnPropertyChanging("CombatConstantData." + nameof(SuppressOffsetXz), this, m_SuppressOffsetXz, value)) m_SuppressOffsetXz = value; } } // 0x30 (48)
		
		protected float m_SuppressOffsetY = new float();
		[ContainerField(Name: "SuppressOffsetY", Offset: 52, NameHash: 25081888, Flags: 49469), LayoutImmutable, Blittable]
		public float SuppressOffsetY { get { return m_SuppressOffsetY; } set { if (OnPropertyChanging("CombatConstantData." + nameof(SuppressOffsetY), this, m_SuppressOffsetY, value)) m_SuppressOffsetY = value; } } // 0x34 (52)
		
		protected float m_SuppressMinLOFDistance = new float();
		[ContainerField(Name: "SuppressMinLOFDistance", Offset: 56, NameHash: 4131068152, Flags: 49469), LayoutImmutable, Blittable]
		public float SuppressMinLOFDistance { get { return m_SuppressMinLOFDistance; } set { if (OnPropertyChanging("CombatConstantData." + nameof(SuppressMinLOFDistance), this, m_SuppressMinLOFDistance, value)) m_SuppressMinLOFDistance = value; } } // 0x38 (56)
		
		protected float m_SuppressMinLOFOffsetDistance = new float();
		[ContainerField(Name: "SuppressMinLOFOffsetDistance", Offset: 60, NameHash: 2750141589, Flags: 49469), LayoutImmutable, Blittable]
		public float SuppressMinLOFOffsetDistance { get { return m_SuppressMinLOFOffsetDistance; } set { if (OnPropertyChanging("CombatConstantData." + nameof(SuppressMinLOFOffsetDistance), this, m_SuppressMinLOFOffsetDistance, value)) m_SuppressMinLOFOffsetDistance = value; } } // 0x3C (60)
		
		protected float m_InvestigateCoverSearchWidth = new float();
		[ContainerField(Name: "InvestigateCoverSearchWidth", Offset: 64, NameHash: 675451181, Flags: 49469), LayoutImmutable, Blittable]
		public float InvestigateCoverSearchWidth { get { return m_InvestigateCoverSearchWidth; } set { if (OnPropertyChanging("CombatConstantData." + nameof(InvestigateCoverSearchWidth), this, m_InvestigateCoverSearchWidth, value)) m_InvestigateCoverSearchWidth = value; } } // 0x40 (64)
		
		protected float m_InvestigateAroundTargetRadius = new float();
		[ContainerField(Name: "InvestigateAroundTargetRadius", Offset: 68, NameHash: 1642795970, Flags: 49469), LayoutImmutable, Blittable]
		public float InvestigateAroundTargetRadius { get { return m_InvestigateAroundTargetRadius; } set { if (OnPropertyChanging("CombatConstantData." + nameof(InvestigateAroundTargetRadius), this, m_InvestigateAroundTargetRadius, value)) m_InvestigateAroundTargetRadius = value; } } // 0x44 (68)
		
		protected float m_InvestigateFreeLookRadius = new float();
		[ContainerField(Name: "InvestigateFreeLookRadius", Offset: 72, NameHash: 1749973155, Flags: 49469), LayoutImmutable, Blittable]
		public float InvestigateFreeLookRadius { get { return m_InvestigateFreeLookRadius; } set { if (OnPropertyChanging("CombatConstantData." + nameof(InvestigateFreeLookRadius), this, m_InvestigateFreeLookRadius, value)) m_InvestigateFreeLookRadius = value; } } // 0x48 (72)
		
		protected float m_InvestigatePauseTimeMin = new float();
		[ContainerField(Name: "InvestigatePauseTimeMin", Offset: 76, NameHash: 1935358117, Flags: 49469), LayoutImmutable, Blittable]
		public float InvestigatePauseTimeMin { get { return m_InvestigatePauseTimeMin; } set { if (OnPropertyChanging("CombatConstantData." + nameof(InvestigatePauseTimeMin), this, m_InvestigatePauseTimeMin, value)) m_InvestigatePauseTimeMin = value; } } // 0x4C (76)
		
		protected float m_InvestigatePauseTimeMax = new float();
		[ContainerField(Name: "InvestigatePauseTimeMax", Offset: 80, NameHash: 1935357883, Flags: 49469), LayoutImmutable, Blittable]
		public float InvestigatePauseTimeMax { get { return m_InvestigatePauseTimeMax; } set { if (OnPropertyChanging("CombatConstantData." + nameof(InvestigatePauseTimeMax), this, m_InvestigatePauseTimeMax, value)) m_InvestigatePauseTimeMax = value; } } // 0x50 (80)
		
		protected float m_AvoidC4Time = new float();
		[ContainerField(Name: "AvoidC4Time", Offset: 84, NameHash: 3879239442, Flags: 49469), LayoutImmutable, Blittable]
		public float AvoidC4Time { get { return m_AvoidC4Time; } set { if (OnPropertyChanging("CombatConstantData." + nameof(AvoidC4Time), this, m_AvoidC4Time, value)) m_AvoidC4Time = value; } } // 0x54 (84)
		
		protected float m_StandStillMinTime = new float();
		[ContainerField(Name: "StandStillMinTime", Offset: 88, NameHash: 549291608, Flags: 49469), LayoutImmutable, Blittable]
		public float StandStillMinTime { get { return m_StandStillMinTime; } set { if (OnPropertyChanging("CombatConstantData." + nameof(StandStillMinTime), this, m_StandStillMinTime, value)) m_StandStillMinTime = value; } } // 0x58 (88)
		
		protected float m_StationaryBailDistance = new float();
		[ContainerField(Name: "StationaryBailDistance", Offset: 92, NameHash: 481697168, Flags: 49469), LayoutImmutable, Blittable]
		public float StationaryBailDistance { get { return m_StationaryBailDistance; } set { if (OnPropertyChanging("CombatConstantData." + nameof(StationaryBailDistance), this, m_StationaryBailDistance, value)) m_StationaryBailDistance = value; } } // 0x5C (92)
		
		protected float m_PrecisionTimeout = new float();
		[ContainerField(Name: "PrecisionTimeout", Offset: 96, NameHash: 471987080, Flags: 49469), LayoutImmutable, Blittable]
		public float PrecisionTimeout { get { return m_PrecisionTimeout; } set { if (OnPropertyChanging("CombatConstantData." + nameof(PrecisionTimeout), this, m_PrecisionTimeout, value)) m_PrecisionTimeout = value; } } // 0x60 (96)
		
		protected float m_CloseRangeAccuracyDistance = new float();
		[ContainerField(Name: "CloseRangeAccuracyDistance", Offset: 100, NameHash: 2796687794, Flags: 49469), LayoutImmutable, Blittable]
		public float CloseRangeAccuracyDistance { get { return m_CloseRangeAccuracyDistance; } set { if (OnPropertyChanging("CombatConstantData." + nameof(CloseRangeAccuracyDistance), this, m_CloseRangeAccuracyDistance, value)) m_CloseRangeAccuracyDistance = value; } } // 0x64 (100)
		
		protected float m_FightFromPathRadius = new float();
		[ContainerField(Name: "FightFromPathRadius", Offset: 104, NameHash: 2003526898, Flags: 49469), LayoutImmutable, Blittable]
		public float FightFromPathRadius { get { return m_FightFromPathRadius; } set { if (OnPropertyChanging("CombatConstantData." + nameof(FightFromPathRadius), this, m_FightFromPathRadius, value)) m_FightFromPathRadius = value; } } // 0x68 (104)
		
		protected float m_SmokeRadius = new float();
		[ContainerField(Name: "SmokeRadius", Offset: 108, NameHash: 1940031714, Flags: 49469), LayoutImmutable, Blittable]
		public float SmokeRadius { get { return m_SmokeRadius; } set { if (OnPropertyChanging("CombatConstantData." + nameof(SmokeRadius), this, m_SmokeRadius, value)) m_SmokeRadius = value; } } // 0x6C (108)
		
		protected float m_SmokeLifeTime = new float();
		[ContainerField(Name: "SmokeLifeTime", Offset: 112, NameHash: 2689736265, Flags: 49469), LayoutImmutable, Blittable]
		public float SmokeLifeTime { get { return m_SmokeLifeTime; } set { if (OnPropertyChanging("CombatConstantData." + nameof(SmokeLifeTime), this, m_SmokeLifeTime, value)) m_SmokeLifeTime = value; } } // 0x70 (112)
		
		protected float m_MeleeCooldown = new float();
		[ContainerField(Name: "MeleeCooldown", Offset: 116, NameHash: 64560700, Flags: 49469), LayoutImmutable, Blittable]
		public float MeleeCooldown { get { return m_MeleeCooldown; } set { if (OnPropertyChanging("CombatConstantData." + nameof(MeleeCooldown), this, m_MeleeCooldown, value)) m_MeleeCooldown = value; } } // 0x74 (116)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 1389063054:
					PoseTransitionFireDelay = (float) p_Value;
					break;

				case 1131204007:
					ChangePoseStopDelay = (float) p_Value;
					break;

				case 255588098:
					AllowCrouchFiringWaterLevel = (float) p_Value;
					break;

				case 3713665594:
					PoseChangeLockoutTime = (float) p_Value;
					break;

				case 93209033:
					ExplosionInterestRange = (float) p_Value;
					break;

				case 998458977:
					ExplosiveObjectSearchRadius = (float) p_Value;
					break;

				case 1067074529:
					ExplosiveBlastMultiplier = (float) p_Value;
					break;

				case 305591139:
					MaxSuppressDistance = (float) p_Value;
					break;

				case 2648235343:
					MaxSuppressorsRatio = (float) p_Value;
					break;

				case 827702331:
					SuppressOffsetXz = (float) p_Value;
					break;

				case 25081888:
					SuppressOffsetY = (float) p_Value;
					break;

				case 4131068152:
					SuppressMinLOFDistance = (float) p_Value;
					break;

				case 2750141589:
					SuppressMinLOFOffsetDistance = (float) p_Value;
					break;

				case 675451181:
					InvestigateCoverSearchWidth = (float) p_Value;
					break;

				case 1642795970:
					InvestigateAroundTargetRadius = (float) p_Value;
					break;

				case 1749973155:
					InvestigateFreeLookRadius = (float) p_Value;
					break;

				case 1935358117:
					InvestigatePauseTimeMin = (float) p_Value;
					break;

				case 1935357883:
					InvestigatePauseTimeMax = (float) p_Value;
					break;

				case 3879239442:
					AvoidC4Time = (float) p_Value;
					break;

				case 549291608:
					StandStillMinTime = (float) p_Value;
					break;

				case 481697168:
					StationaryBailDistance = (float) p_Value;
					break;

				case 471987080:
					PrecisionTimeout = (float) p_Value;
					break;

				case 2796687794:
					CloseRangeAccuracyDistance = (float) p_Value;
					break;

				case 2003526898:
					FightFromPathRadius = (float) p_Value;
					break;

				case 1940031714:
					SmokeRadius = (float) p_Value;
					break;

				case 2689736265:
					SmokeLifeTime = (float) p_Value;
					break;

				case 64560700:
					MeleeCooldown = (float) p_Value;
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
				case 1389063054:
					return PoseTransitionFireDelay;

				case 1131204007:
					return ChangePoseStopDelay;

				case 255588098:
					return AllowCrouchFiringWaterLevel;

				case 3713665594:
					return PoseChangeLockoutTime;

				case 93209033:
					return ExplosionInterestRange;

				case 998458977:
					return ExplosiveObjectSearchRadius;

				case 1067074529:
					return ExplosiveBlastMultiplier;

				case 305591139:
					return MaxSuppressDistance;

				case 2648235343:
					return MaxSuppressorsRatio;

				case 827702331:
					return SuppressOffsetXz;

				case 25081888:
					return SuppressOffsetY;

				case 4131068152:
					return SuppressMinLOFDistance;

				case 2750141589:
					return SuppressMinLOFOffsetDistance;

				case 675451181:
					return InvestigateCoverSearchWidth;

				case 1642795970:
					return InvestigateAroundTargetRadius;

				case 1749973155:
					return InvestigateFreeLookRadius;

				case 1935358117:
					return InvestigatePauseTimeMin;

				case 1935357883:
					return InvestigatePauseTimeMax;

				case 3879239442:
					return AvoidC4Time;

				case 549291608:
					return StandStillMinTime;

				case 481697168:
					return StationaryBailDistance;

				case 471987080:
					return PrecisionTimeout;

				case 2796687794:
					return CloseRangeAccuracyDistance;

				case 2003526898:
					return FightFromPathRadius;

				case 1940031714:
					return SmokeRadius;

				case 2689736265:
					return SmokeLifeTime;

				case 64560700:
					return MeleeCooldown;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 1389063054:
					return typeof(CombatConstantData).GetProperty(nameof(PoseTransitionFireDelay));

				case 1131204007:
					return typeof(CombatConstantData).GetProperty(nameof(ChangePoseStopDelay));

				case 255588098:
					return typeof(CombatConstantData).GetProperty(nameof(AllowCrouchFiringWaterLevel));

				case 3713665594:
					return typeof(CombatConstantData).GetProperty(nameof(PoseChangeLockoutTime));

				case 93209033:
					return typeof(CombatConstantData).GetProperty(nameof(ExplosionInterestRange));

				case 998458977:
					return typeof(CombatConstantData).GetProperty(nameof(ExplosiveObjectSearchRadius));

				case 1067074529:
					return typeof(CombatConstantData).GetProperty(nameof(ExplosiveBlastMultiplier));

				case 305591139:
					return typeof(CombatConstantData).GetProperty(nameof(MaxSuppressDistance));

				case 2648235343:
					return typeof(CombatConstantData).GetProperty(nameof(MaxSuppressorsRatio));

				case 827702331:
					return typeof(CombatConstantData).GetProperty(nameof(SuppressOffsetXz));

				case 25081888:
					return typeof(CombatConstantData).GetProperty(nameof(SuppressOffsetY));

				case 4131068152:
					return typeof(CombatConstantData).GetProperty(nameof(SuppressMinLOFDistance));

				case 2750141589:
					return typeof(CombatConstantData).GetProperty(nameof(SuppressMinLOFOffsetDistance));

				case 675451181:
					return typeof(CombatConstantData).GetProperty(nameof(InvestigateCoverSearchWidth));

				case 1642795970:
					return typeof(CombatConstantData).GetProperty(nameof(InvestigateAroundTargetRadius));

				case 1749973155:
					return typeof(CombatConstantData).GetProperty(nameof(InvestigateFreeLookRadius));

				case 1935358117:
					return typeof(CombatConstantData).GetProperty(nameof(InvestigatePauseTimeMin));

				case 1935357883:
					return typeof(CombatConstantData).GetProperty(nameof(InvestigatePauseTimeMax));

				case 3879239442:
					return typeof(CombatConstantData).GetProperty(nameof(AvoidC4Time));

				case 549291608:
					return typeof(CombatConstantData).GetProperty(nameof(StandStillMinTime));

				case 481697168:
					return typeof(CombatConstantData).GetProperty(nameof(StationaryBailDistance));

				case 471987080:
					return typeof(CombatConstantData).GetProperty(nameof(PrecisionTimeout));

				case 2796687794:
					return typeof(CombatConstantData).GetProperty(nameof(CloseRangeAccuracyDistance));

				case 2003526898:
					return typeof(CombatConstantData).GetProperty(nameof(FightFromPathRadius));

				case 1940031714:
					return typeof(CombatConstantData).GetProperty(nameof(SmokeRadius));

				case 2689736265:
					return typeof(CombatConstantData).GetProperty(nameof(SmokeLifeTime));

				case 64560700:
					return typeof(CombatConstantData).GetProperty(nameof(MeleeCooldown));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
