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
	public class CombatConstantData : 
		Asset
	{
		[ContainerField(12), LayoutImmutable, Blittable]
		public float PoseTransitionFireDelay { get; set; } // 0xC (12)
		
		[ContainerField(16), LayoutImmutable, Blittable]
		public float ChangePoseStopDelay { get; set; } // 0x10 (16)
		
		[ContainerField(20), LayoutImmutable, Blittable]
		public float AllowCrouchFiringWaterLevel { get; set; } // 0x14 (20)
		
		[ContainerField(24), LayoutImmutable, Blittable]
		public float PoseChangeLockoutTime { get; set; } // 0x18 (24)
		
		[ContainerField(28), LayoutImmutable, Blittable]
		public float ExplosionInterestRange { get; set; } // 0x1C (28)
		
		[ContainerField(32), LayoutImmutable, Blittable]
		public float ExplosiveObjectSearchRadius { get; set; } // 0x20 (32)
		
		[ContainerField(36), LayoutImmutable, Blittable]
		public float ExplosiveBlastMultiplier { get; set; } // 0x24 (36)
		
		[ContainerField(40), LayoutImmutable, Blittable]
		public float MaxSuppressDistance { get; set; } // 0x28 (40)
		
		[ContainerField(44), LayoutImmutable, Blittable]
		public float MaxSuppressorsRatio { get; set; } // 0x2C (44)
		
		[ContainerField(48), LayoutImmutable, Blittable]
		public float SuppressOffsetXz { get; set; } // 0x30 (48)
		
		[ContainerField(52), LayoutImmutable, Blittable]
		public float SuppressOffsetY { get; set; } // 0x34 (52)
		
		[ContainerField(56), LayoutImmutable, Blittable]
		public float SuppressMinLOFDistance { get; set; } // 0x38 (56)
		
		[ContainerField(60), LayoutImmutable, Blittable]
		public float SuppressMinLOFOffsetDistance { get; set; } // 0x3C (60)
		
		[ContainerField(64), LayoutImmutable, Blittable]
		public float InvestigateCoverSearchWidth { get; set; } // 0x40 (64)
		
		[ContainerField(68), LayoutImmutable, Blittable]
		public float InvestigateAroundTargetRadius { get; set; } // 0x44 (68)
		
		[ContainerField(72), LayoutImmutable, Blittable]
		public float InvestigateFreeLookRadius { get; set; } // 0x48 (72)
		
		[ContainerField(76), LayoutImmutable, Blittable]
		public float InvestigatePauseTimeMin { get; set; } // 0x4C (76)
		
		[ContainerField(80), LayoutImmutable, Blittable]
		public float InvestigatePauseTimeMax { get; set; } // 0x50 (80)
		
		[ContainerField(84), LayoutImmutable, Blittable]
		public float AvoidC4Time { get; set; } // 0x54 (84)
		
		[ContainerField(88), LayoutImmutable, Blittable]
		public float StandStillMinTime { get; set; } // 0x58 (88)
		
		[ContainerField(92), LayoutImmutable, Blittable]
		public float StationaryBailDistance { get; set; } // 0x5C (92)
		
		[ContainerField(96), LayoutImmutable, Blittable]
		public float PrecisionTimeout { get; set; } // 0x60 (96)
		
		[ContainerField(100), LayoutImmutable, Blittable]
		public float CloseRangeAccuracyDistance { get; set; } // 0x64 (100)
		
		[ContainerField(104), LayoutImmutable, Blittable]
		public float FightFromPathRadius { get; set; } // 0x68 (104)
		
		[ContainerField(108), LayoutImmutable, Blittable]
		public float SmokeRadius { get; set; } // 0x6C (108)
		
		[ContainerField(112), LayoutImmutable, Blittable]
		public float SmokeLifeTime { get; set; } // 0x70 (112)
		
		[ContainerField(116), LayoutImmutable, Blittable]
		public float MeleeCooldown { get; set; } // 0x74 (116)
		
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
