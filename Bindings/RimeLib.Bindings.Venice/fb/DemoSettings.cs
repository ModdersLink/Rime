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
	public class DemoSettings : 
		DataContainer
	{
		[ContainerField(8), LayoutImmutable]
		public string RecordDemoFileName { get; set; } // 0x8 (8)
		
		[ContainerField(12), LayoutImmutable]
		public string PlaybackDemoFileName { get; set; } // 0xC (12)
		
		[ContainerField(16), LayoutImmutable]
		public string TimeDemo { get; set; } // 0x10 (16)
		
		[ContainerField(20), LayoutImmutable]
		public string LockToPlayerName { get; set; } // 0x14 (20)
		
		[ContainerField(24), LayoutImmutable, Blittable]
		public uint ChangePlayerInterval { get; set; } // 0x18 (24)
		
		[ContainerField(28), LayoutImmutable, Blittable]
		public uint ForcedDeltaTickCount { get; set; } // 0x1C (28)
		
		[ContainerField(32), LayoutImmutable, Blittable]
		public uint StartProfilingOnFrame { get; set; } // 0x20 (32)
		
		[ContainerField(36), LayoutImmutable, Blittable]
		public uint StopProfilingOnFrame { get; set; } // 0x24 (36)
		
		[ContainerField(40), LayoutImmutable, Blittable]
		public uint TakeScreenshotOnFrame { get; set; } // 0x28 (40)
		
		[ContainerField(44), LayoutImmutable, Blittable]
		public bool AllowOverwrite { get; set; } // 0x2C (44)
		
		[ContainerField(45), LayoutImmutable, Blittable]
		public bool LogPerformance { get; set; } // 0x2D (45)
		
		[ContainerField(46), LayoutImmutable, Blittable]
		public bool SuppressDebugLog { get; set; } // 0x2E (46)
		
		[ContainerField(47), LayoutImmutable, Blittable]
		public bool ShutdownOnDemoComplete { get; set; } // 0x2F (47)
		
		[ContainerField(48), LayoutImmutable, Blittable]
		public bool LoopingDemo { get; set; } // 0x30 (48)
		
		[ContainerField(49), LayoutImmutable, Blittable]
		public bool LockToRandomPlayer { get; set; } // 0x31 (49)
		
		[ContainerField(50), LayoutImmutable, Blittable]
		public bool PauseOnStartup { get; set; } // 0x32 (50)
		
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
