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
	[ContainerType(4, 52)]
	public class DemoSettings : 
		DataContainer
	{
		[ContainerField(8), LayoutImmutable]
		public string RecordDemoFileName { get; set; } = string.Empty;

		[ContainerField(12), LayoutImmutable]
		public string PlaybackDemoFileName { get; set; } = string.Empty;

		[ContainerField(16), LayoutImmutable]
		public string TimeDemo { get; set; } = string.Empty;

		[ContainerField(20), LayoutImmutable]
		public string LockToPlayerName { get; set; } = string.Empty;

		[ContainerField(24), LayoutImmutable, Blittable]
		public uint ChangePlayerInterval { get; set; }

		[ContainerField(28), LayoutImmutable, Blittable]
		public uint ForcedDeltaTickCount { get; set; }

		[ContainerField(32), LayoutImmutable, Blittable]
		public uint StartProfilingOnFrame { get; set; }

		[ContainerField(36), LayoutImmutable, Blittable]
		public uint StopProfilingOnFrame { get; set; }

		[ContainerField(40), LayoutImmutable, Blittable]
		public uint TakeScreenshotOnFrame { get; set; }

		[ContainerField(44), LayoutImmutable, Blittable]
		public bool AllowOverwrite { get; set; }

		[ContainerField(45), LayoutImmutable, Blittable]
		public bool LogPerformance { get; set; }

		[ContainerField(46), LayoutImmutable, Blittable]
		public bool SuppressDebugLog { get; set; }

		[ContainerField(47), LayoutImmutable, Blittable]
		public bool ShutdownOnDemoComplete { get; set; }

		[ContainerField(48), LayoutImmutable, Blittable]
		public bool LoopingDemo { get; set; }

		[ContainerField(49), LayoutImmutable, Blittable]
		public bool LockToRandomPlayer { get; set; }

		[ContainerField(50), LayoutImmutable, Blittable]
		public bool PauseOnStartup { get; set; }

	}
}
