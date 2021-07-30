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
	[ContainerType(Alignment: 4,  Flags: 53, Size: 52)]
	public class DemoSettings : 
		DataContainer
	{
		protected string m_RecordDemoFileName = string.Empty;
		[ContainerField(Name: "RecordDemoFileName", Offset: 8, NameHash: 3106827306, Flags: 16509), LayoutImmutable]
		public string RecordDemoFileName { get { return m_RecordDemoFileName; } set { if (OnPropertyChanging("DemoSettings." + nameof(RecordDemoFileName), this, m_RecordDemoFileName, value)) m_RecordDemoFileName = value; } } // 0x8 (8)
		
		protected string m_PlaybackDemoFileName = string.Empty;
		[ContainerField(Name: "PlaybackDemoFileName", Offset: 12, NameHash: 2477555912, Flags: 16509), LayoutImmutable]
		public string PlaybackDemoFileName { get { return m_PlaybackDemoFileName; } set { if (OnPropertyChanging("DemoSettings." + nameof(PlaybackDemoFileName), this, m_PlaybackDemoFileName, value)) m_PlaybackDemoFileName = value; } } // 0xC (12)
		
		protected string m_TimeDemo = string.Empty;
		[ContainerField(Name: "TimeDemo", Offset: 16, NameHash: 2999418899, Flags: 16509), LayoutImmutable]
		public string TimeDemo { get { return m_TimeDemo; } set { if (OnPropertyChanging("DemoSettings." + nameof(TimeDemo), this, m_TimeDemo, value)) m_TimeDemo = value; } } // 0x10 (16)
		
		protected string m_LockToPlayerName = string.Empty;
		[ContainerField(Name: "LockToPlayerName", Offset: 20, NameHash: 1399694977, Flags: 16509), LayoutImmutable]
		public string LockToPlayerName { get { return m_LockToPlayerName; } set { if (OnPropertyChanging("DemoSettings." + nameof(LockToPlayerName), this, m_LockToPlayerName, value)) m_LockToPlayerName = value; } } // 0x14 (20)
		
		protected uint m_ChangePlayerInterval = new uint();
		[ContainerField(Name: "ChangePlayerInterval", Offset: 24, NameHash: 4244661775, Flags: 49421), LayoutImmutable, Blittable]
		public uint ChangePlayerInterval { get { return m_ChangePlayerInterval; } set { if (OnPropertyChanging("DemoSettings." + nameof(ChangePlayerInterval), this, m_ChangePlayerInterval, value)) m_ChangePlayerInterval = value; } } // 0x18 (24)
		
		protected uint m_ForcedDeltaTickCount = new uint();
		[ContainerField(Name: "ForcedDeltaTickCount", Offset: 28, NameHash: 2341640882, Flags: 49421), LayoutImmutable, Blittable]
		public uint ForcedDeltaTickCount { get { return m_ForcedDeltaTickCount; } set { if (OnPropertyChanging("DemoSettings." + nameof(ForcedDeltaTickCount), this, m_ForcedDeltaTickCount, value)) m_ForcedDeltaTickCount = value; } } // 0x1C (28)
		
		protected uint m_StartProfilingOnFrame = new uint();
		[ContainerField(Name: "StartProfilingOnFrame", Offset: 32, NameHash: 37151863, Flags: 49421), LayoutImmutable, Blittable]
		public uint StartProfilingOnFrame { get { return m_StartProfilingOnFrame; } set { if (OnPropertyChanging("DemoSettings." + nameof(StartProfilingOnFrame), this, m_StartProfilingOnFrame, value)) m_StartProfilingOnFrame = value; } } // 0x20 (32)
		
		protected uint m_StopProfilingOnFrame = new uint();
		[ContainerField(Name: "StopProfilingOnFrame", Offset: 36, NameHash: 3237723695, Flags: 49421), LayoutImmutable, Blittable]
		public uint StopProfilingOnFrame { get { return m_StopProfilingOnFrame; } set { if (OnPropertyChanging("DemoSettings." + nameof(StopProfilingOnFrame), this, m_StopProfilingOnFrame, value)) m_StopProfilingOnFrame = value; } } // 0x24 (36)
		
		protected uint m_TakeScreenshotOnFrame = new uint();
		[ContainerField(Name: "TakeScreenshotOnFrame", Offset: 40, NameHash: 490968814, Flags: 49421), LayoutImmutable, Blittable]
		public uint TakeScreenshotOnFrame { get { return m_TakeScreenshotOnFrame; } set { if (OnPropertyChanging("DemoSettings." + nameof(TakeScreenshotOnFrame), this, m_TakeScreenshotOnFrame, value)) m_TakeScreenshotOnFrame = value; } } // 0x28 (40)
		
		protected bool m_AllowOverwrite = new bool();
		[ContainerField(Name: "AllowOverwrite", Offset: 44, NameHash: 1707043087, Flags: 49325), LayoutImmutable, Blittable]
		public bool AllowOverwrite { get { return m_AllowOverwrite; } set { if (OnPropertyChanging("DemoSettings." + nameof(AllowOverwrite), this, m_AllowOverwrite, value)) m_AllowOverwrite = value; } } // 0x2C (44)
		
		protected bool m_LogPerformance = new bool();
		[ContainerField(Name: "LogPerformance", Offset: 45, NameHash: 2026456601, Flags: 49325), LayoutImmutable, Blittable]
		public bool LogPerformance { get { return m_LogPerformance; } set { if (OnPropertyChanging("DemoSettings." + nameof(LogPerformance), this, m_LogPerformance, value)) m_LogPerformance = value; } } // 0x2D (45)
		
		protected bool m_SuppressDebugLog = new bool();
		[ContainerField(Name: "SuppressDebugLog", Offset: 46, NameHash: 1295919777, Flags: 49325), LayoutImmutable, Blittable]
		public bool SuppressDebugLog { get { return m_SuppressDebugLog; } set { if (OnPropertyChanging("DemoSettings." + nameof(SuppressDebugLog), this, m_SuppressDebugLog, value)) m_SuppressDebugLog = value; } } // 0x2E (46)
		
		protected bool m_ShutdownOnDemoComplete = new bool();
		[ContainerField(Name: "ShutdownOnDemoComplete", Offset: 47, NameHash: 296483878, Flags: 49325), LayoutImmutable, Blittable]
		public bool ShutdownOnDemoComplete { get { return m_ShutdownOnDemoComplete; } set { if (OnPropertyChanging("DemoSettings." + nameof(ShutdownOnDemoComplete), this, m_ShutdownOnDemoComplete, value)) m_ShutdownOnDemoComplete = value; } } // 0x2F (47)
		
		protected bool m_LoopingDemo = new bool();
		[ContainerField(Name: "LoopingDemo", Offset: 48, NameHash: 2714976858, Flags: 49325), LayoutImmutable, Blittable]
		public bool LoopingDemo { get { return m_LoopingDemo; } set { if (OnPropertyChanging("DemoSettings." + nameof(LoopingDemo), this, m_LoopingDemo, value)) m_LoopingDemo = value; } } // 0x30 (48)
		
		protected bool m_LockToRandomPlayer = new bool();
		[ContainerField(Name: "LockToRandomPlayer", Offset: 49, NameHash: 4183020829, Flags: 49325), LayoutImmutable, Blittable]
		public bool LockToRandomPlayer { get { return m_LockToRandomPlayer; } set { if (OnPropertyChanging("DemoSettings." + nameof(LockToRandomPlayer), this, m_LockToRandomPlayer, value)) m_LockToRandomPlayer = value; } } // 0x31 (49)
		
		protected bool m_PauseOnStartup = new bool();
		[ContainerField(Name: "PauseOnStartup", Offset: 50, NameHash: 1614327443, Flags: 49325), LayoutImmutable, Blittable]
		public bool PauseOnStartup { get { return m_PauseOnStartup; } set { if (OnPropertyChanging("DemoSettings." + nameof(PauseOnStartup), this, m_PauseOnStartup, value)) m_PauseOnStartup = value; } } // 0x32 (50)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 3106827306:
					RecordDemoFileName = (string) p_Value;
					break;

				case 2477555912:
					PlaybackDemoFileName = (string) p_Value;
					break;

				case 2999418899:
					TimeDemo = (string) p_Value;
					break;

				case 1399694977:
					LockToPlayerName = (string) p_Value;
					break;

				case 4244661775:
					ChangePlayerInterval = (uint) p_Value;
					break;

				case 2341640882:
					ForcedDeltaTickCount = (uint) p_Value;
					break;

				case 37151863:
					StartProfilingOnFrame = (uint) p_Value;
					break;

				case 3237723695:
					StopProfilingOnFrame = (uint) p_Value;
					break;

				case 490968814:
					TakeScreenshotOnFrame = (uint) p_Value;
					break;

				case 1707043087:
					AllowOverwrite = (bool) p_Value;
					break;

				case 2026456601:
					LogPerformance = (bool) p_Value;
					break;

				case 1295919777:
					SuppressDebugLog = (bool) p_Value;
					break;

				case 296483878:
					ShutdownOnDemoComplete = (bool) p_Value;
					break;

				case 2714976858:
					LoopingDemo = (bool) p_Value;
					break;

				case 4183020829:
					LockToRandomPlayer = (bool) p_Value;
					break;

				case 1614327443:
					PauseOnStartup = (bool) p_Value;
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
				case 3106827306:
					return RecordDemoFileName;

				case 2477555912:
					return PlaybackDemoFileName;

				case 2999418899:
					return TimeDemo;

				case 1399694977:
					return LockToPlayerName;

				case 4244661775:
					return ChangePlayerInterval;

				case 2341640882:
					return ForcedDeltaTickCount;

				case 37151863:
					return StartProfilingOnFrame;

				case 3237723695:
					return StopProfilingOnFrame;

				case 490968814:
					return TakeScreenshotOnFrame;

				case 1707043087:
					return AllowOverwrite;

				case 2026456601:
					return LogPerformance;

				case 1295919777:
					return SuppressDebugLog;

				case 296483878:
					return ShutdownOnDemoComplete;

				case 2714976858:
					return LoopingDemo;

				case 4183020829:
					return LockToRandomPlayer;

				case 1614327443:
					return PauseOnStartup;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 3106827306:
					return typeof(DemoSettings).GetProperty(nameof(RecordDemoFileName));

				case 2477555912:
					return typeof(DemoSettings).GetProperty(nameof(PlaybackDemoFileName));

				case 2999418899:
					return typeof(DemoSettings).GetProperty(nameof(TimeDemo));

				case 1399694977:
					return typeof(DemoSettings).GetProperty(nameof(LockToPlayerName));

				case 4244661775:
					return typeof(DemoSettings).GetProperty(nameof(ChangePlayerInterval));

				case 2341640882:
					return typeof(DemoSettings).GetProperty(nameof(ForcedDeltaTickCount));

				case 37151863:
					return typeof(DemoSettings).GetProperty(nameof(StartProfilingOnFrame));

				case 3237723695:
					return typeof(DemoSettings).GetProperty(nameof(StopProfilingOnFrame));

				case 490968814:
					return typeof(DemoSettings).GetProperty(nameof(TakeScreenshotOnFrame));

				case 1707043087:
					return typeof(DemoSettings).GetProperty(nameof(AllowOverwrite));

				case 2026456601:
					return typeof(DemoSettings).GetProperty(nameof(LogPerformance));

				case 1295919777:
					return typeof(DemoSettings).GetProperty(nameof(SuppressDebugLog));

				case 296483878:
					return typeof(DemoSettings).GetProperty(nameof(ShutdownOnDemoComplete));

				case 2714976858:
					return typeof(DemoSettings).GetProperty(nameof(LoopingDemo));

				case 4183020829:
					return typeof(DemoSettings).GetProperty(nameof(LockToRandomPlayer));

				case 1614327443:
					return typeof(DemoSettings).GetProperty(nameof(PauseOnStartup));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
