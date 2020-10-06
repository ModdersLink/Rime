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
	[ContainerType(4), MemberInfoFlag(53), ContainerSize(64), ContainerClass]
	public class GameTimeSettings : 
		SystemSettings
	{
		protected float m_VSyncSubtractTime = new float();
		[ContainerField(12), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(1408568021)]
		public float VSyncSubtractTime { get { return m_VSyncSubtractTime; } set { if (OnPropertyChanging("GameTimeSettings." + nameof(VSyncSubtractTime), this, m_VSyncSubtractTime, value)) m_VSyncSubtractTime = value; } } // 0xC (12)
		
		protected float m_JoinJobsTimeLimit = new float();
		[ContainerField(16), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(4179044787)]
		public float JoinJobsTimeLimit { get { return m_JoinJobsTimeLimit; } set { if (OnPropertyChanging("GameTimeSettings." + nameof(JoinJobsTimeLimit), this, m_JoinJobsTimeLimit, value)) m_JoinJobsTimeLimit = value; } } // 0x10 (16)
		
		protected float m_YieldTimeLimit = new float();
		[ContainerField(20), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(4058424504)]
		public float YieldTimeLimit { get { return m_YieldTimeLimit; } set { if (OnPropertyChanging("GameTimeSettings." + nameof(YieldTimeLimit), this, m_YieldTimeLimit, value)) m_YieldTimeLimit = value; } } // 0x14 (20)
		
		protected int m_YieldTime = new int();
		[ContainerField(24), LayoutImmutable, Blittable, MemberInfoFlag(49405), ContainerFieldNameHash(1803161485)]
		public int YieldTime { get { return m_YieldTime; } set { if (OnPropertyChanging("GameTimeSettings." + nameof(YieldTime), this, m_YieldTime, value)) m_YieldTime = value; } } // 0x18 (24)
		
		protected float m_MaxInactiveVariableFps = new float();
		[ContainerField(28), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(2767785209)]
		public float MaxInactiveVariableFps { get { return m_MaxInactiveVariableFps; } set { if (OnPropertyChanging("GameTimeSettings." + nameof(MaxInactiveVariableFps), this, m_MaxInactiveVariableFps, value)) m_MaxInactiveVariableFps = value; } } // 0x1C (28)
		
		protected float m_MaxSimFps = new float();
		[ContainerField(32), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(179519747)]
		public float MaxSimFps { get { return m_MaxSimFps; } set { if (OnPropertyChanging("GameTimeSettings." + nameof(MaxSimFps), this, m_MaxSimFps, value)) m_MaxSimFps = value; } } // 0x20 (32)
		
		protected float m_MaxVariableFps = new float();
		[ContainerField(36), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(3499862514)]
		public float MaxVariableFps { get { return m_MaxVariableFps; } set { if (OnPropertyChanging("GameTimeSettings." + nameof(MaxVariableFps), this, m_MaxVariableFps, value)) m_MaxVariableFps = value; } } // 0x24 (36)
		
		protected int m_ClampTicks = new int();
		[ContainerField(40), LayoutImmutable, Blittable, MemberInfoFlag(49405), ContainerFieldNameHash(1108058896)]
		public int ClampTicks { get { return m_ClampTicks; } set { if (OnPropertyChanging("GameTimeSettings." + nameof(ClampTicks), this, m_ClampTicks, value)) m_ClampTicks = value; } } // 0x28 (40)
		
		protected float m_ForceDeltaTime = new float();
		[ContainerField(44), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(989222869)]
		public float ForceDeltaTime { get { return m_ForceDeltaTime; } set { if (OnPropertyChanging("GameTimeSettings." + nameof(ForceDeltaTime), this, m_ForceDeltaTime, value)) m_ForceDeltaTime = value; } } // 0x2C (44)
		
		protected int m_ForceDeltaTickCount = new int();
		[ContainerField(48), LayoutImmutable, Blittable, MemberInfoFlag(49405), ContainerFieldNameHash(1434186710)]
		public int ForceDeltaTickCount { get { return m_ForceDeltaTickCount; } set { if (OnPropertyChanging("GameTimeSettings." + nameof(ForceDeltaTickCount), this, m_ForceDeltaTickCount, value)) m_ForceDeltaTickCount = value; } } // 0x30 (48)
		
		protected float m_TimeScale = new float();
		[ContainerField(52), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(169511528)]
		public float TimeScale { get { return m_TimeScale; } set { if (OnPropertyChanging("GameTimeSettings." + nameof(TimeScale), this, m_TimeScale, value)) m_TimeScale = value; } } // 0x34 (52)
		
		protected bool m_UseWaitableTimers = new bool();
		[ContainerField(56), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(1210114003)]
		public bool UseWaitableTimers { get { return m_UseWaitableTimers; } set { if (OnPropertyChanging("GameTimeSettings." + nameof(UseWaitableTimers), this, m_UseWaitableTimers, value)) m_UseWaitableTimers = value; } } // 0x38 (56)
		
		protected bool m_ForceUseSleepTimer = new bool();
		[ContainerField(57), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(21790035)]
		public bool ForceUseSleepTimer { get { return m_ForceUseSleepTimer; } set { if (OnPropertyChanging("GameTimeSettings." + nameof(ForceUseSleepTimer), this, m_ForceUseSleepTimer, value)) m_ForceUseSleepTimer = value; } } // 0x39 (57)
		
		protected bool m_ForceSinglePlayerFixedTick = new bool();
		[ContainerField(58), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(3127258354)]
		public bool ForceSinglePlayerFixedTick { get { return m_ForceSinglePlayerFixedTick; } set { if (OnPropertyChanging("GameTimeSettings." + nameof(ForceSinglePlayerFixedTick), this, m_ForceSinglePlayerFixedTick, value)) m_ForceSinglePlayerFixedTick = value; } } // 0x3A (58)
		
		protected bool m_ForceMultiplayerOneTickMin = new bool();
		[ContainerField(59), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(2557938009)]
		public bool ForceMultiplayerOneTickMin { get { return m_ForceMultiplayerOneTickMin; } set { if (OnPropertyChanging("GameTimeSettings." + nameof(ForceMultiplayerOneTickMin), this, m_ForceMultiplayerOneTickMin, value)) m_ForceMultiplayerOneTickMin = value; } } // 0x3B (59)
		
		protected bool m_VariableSimTickTimeEnable = new bool();
		[ContainerField(60), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(2832549493)]
		public bool VariableSimTickTimeEnable { get { return m_VariableSimTickTimeEnable; } set { if (OnPropertyChanging("GameTimeSettings." + nameof(VariableSimTickTimeEnable), this, m_VariableSimTickTimeEnable, value)) m_VariableSimTickTimeEnable = value; } } // 0x3C (60)
		
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
