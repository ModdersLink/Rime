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
	public class GameTimeSettings : 
		SystemSettings
	{
		[ContainerField(12), LayoutImmutable, Blittable]
		public float VSyncSubtractTime { get; set; } // 0xC (12)
		
		[ContainerField(16), LayoutImmutable, Blittable]
		public float JoinJobsTimeLimit { get; set; } // 0x10 (16)
		
		[ContainerField(20), LayoutImmutable, Blittable]
		public float YieldTimeLimit { get; set; } // 0x14 (20)
		
		[ContainerField(24), LayoutImmutable, Blittable]
		public int YieldTime { get; set; } // 0x18 (24)
		
		[ContainerField(28), LayoutImmutable, Blittable]
		public float MaxInactiveVariableFps { get; set; } // 0x1C (28)
		
		[ContainerField(32), LayoutImmutable, Blittable]
		public float MaxSimFps { get; set; } // 0x20 (32)
		
		[ContainerField(36), LayoutImmutable, Blittable]
		public float MaxVariableFps { get; set; } // 0x24 (36)
		
		[ContainerField(40), LayoutImmutable, Blittable]
		public int ClampTicks { get; set; } // 0x28 (40)
		
		[ContainerField(44), LayoutImmutable, Blittable]
		public float ForceDeltaTime { get; set; } // 0x2C (44)
		
		[ContainerField(48), LayoutImmutable, Blittable]
		public int ForceDeltaTickCount { get; set; } // 0x30 (48)
		
		[ContainerField(52), LayoutImmutable, Blittable]
		public float TimeScale { get; set; } // 0x34 (52)
		
		[ContainerField(56), LayoutImmutable, Blittable]
		public bool UseWaitableTimers { get; set; } // 0x38 (56)
		
		[ContainerField(57), LayoutImmutable, Blittable]
		public bool ForceUseSleepTimer { get; set; } // 0x39 (57)
		
		[ContainerField(58), LayoutImmutable, Blittable]
		public bool ForceSinglePlayerFixedTick { get; set; } // 0x3A (58)
		
		[ContainerField(59), LayoutImmutable, Blittable]
		public bool ForceMultiplayerOneTickMin { get; set; } // 0x3B (59)
		
		[ContainerField(60), LayoutImmutable, Blittable]
		public bool VariableSimTickTimeEnable { get; set; } // 0x3C (60)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 1408568021:
					VSyncSubtractTime = (float) p_Value;
					break;

				case 4179044787:
					JoinJobsTimeLimit = (float) p_Value;
					break;

				case 4058424504:
					YieldTimeLimit = (float) p_Value;
					break;

				case 1803161485:
					YieldTime = (int) p_Value;
					break;

				case 2767785209:
					MaxInactiveVariableFps = (float) p_Value;
					break;

				case 179519747:
					MaxSimFps = (float) p_Value;
					break;

				case 3499862514:
					MaxVariableFps = (float) p_Value;
					break;

				case 1108058896:
					ClampTicks = (int) p_Value;
					break;

				case 989222869:
					ForceDeltaTime = (float) p_Value;
					break;

				case 1434186710:
					ForceDeltaTickCount = (int) p_Value;
					break;

				case 169511528:
					TimeScale = (float) p_Value;
					break;

				case 1210114003:
					UseWaitableTimers = (bool) p_Value;
					break;

				case 21790035:
					ForceUseSleepTimer = (bool) p_Value;
					break;

				case 3127258354:
					ForceSinglePlayerFixedTick = (bool) p_Value;
					break;

				case 2557938009:
					ForceMultiplayerOneTickMin = (bool) p_Value;
					break;

				case 2832549493:
					VariableSimTickTimeEnable = (bool) p_Value;
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
				case 1408568021:
					return VSyncSubtractTime;

				case 4179044787:
					return JoinJobsTimeLimit;

				case 4058424504:
					return YieldTimeLimit;

				case 1803161485:
					return YieldTime;

				case 2767785209:
					return MaxInactiveVariableFps;

				case 179519747:
					return MaxSimFps;

				case 3499862514:
					return MaxVariableFps;

				case 1108058896:
					return ClampTicks;

				case 989222869:
					return ForceDeltaTime;

				case 1434186710:
					return ForceDeltaTickCount;

				case 169511528:
					return TimeScale;

				case 1210114003:
					return UseWaitableTimers;

				case 21790035:
					return ForceUseSleepTimer;

				case 3127258354:
					return ForceSinglePlayerFixedTick;

				case 2557938009:
					return ForceMultiplayerOneTickMin;

				case 2832549493:
					return VariableSimTickTimeEnable;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 1408568021:
					return typeof(GameTimeSettings).GetProperty(nameof(VSyncSubtractTime));

				case 4179044787:
					return typeof(GameTimeSettings).GetProperty(nameof(JoinJobsTimeLimit));

				case 4058424504:
					return typeof(GameTimeSettings).GetProperty(nameof(YieldTimeLimit));

				case 1803161485:
					return typeof(GameTimeSettings).GetProperty(nameof(YieldTime));

				case 2767785209:
					return typeof(GameTimeSettings).GetProperty(nameof(MaxInactiveVariableFps));

				case 179519747:
					return typeof(GameTimeSettings).GetProperty(nameof(MaxSimFps));

				case 3499862514:
					return typeof(GameTimeSettings).GetProperty(nameof(MaxVariableFps));

				case 1108058896:
					return typeof(GameTimeSettings).GetProperty(nameof(ClampTicks));

				case 989222869:
					return typeof(GameTimeSettings).GetProperty(nameof(ForceDeltaTime));

				case 1434186710:
					return typeof(GameTimeSettings).GetProperty(nameof(ForceDeltaTickCount));

				case 169511528:
					return typeof(GameTimeSettings).GetProperty(nameof(TimeScale));

				case 1210114003:
					return typeof(GameTimeSettings).GetProperty(nameof(UseWaitableTimers));

				case 21790035:
					return typeof(GameTimeSettings).GetProperty(nameof(ForceUseSleepTimer));

				case 3127258354:
					return typeof(GameTimeSettings).GetProperty(nameof(ForceSinglePlayerFixedTick));

				case 2557938009:
					return typeof(GameTimeSettings).GetProperty(nameof(ForceMultiplayerOneTickMin));

				case 2832549493:
					return typeof(GameTimeSettings).GetProperty(nameof(VariableSimTickTimeEnable));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
