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
	[ContainerType(4, 64)]
	public class GameTimeSettings : 
		SystemSettings
	{
		[ContainerField(12), LayoutImmutable, Blittable]
		public float VSyncSubtractTime { get; set; }

		[ContainerField(16), LayoutImmutable, Blittable]
		public float JoinJobsTimeLimit { get; set; }

		[ContainerField(20), LayoutImmutable, Blittable]
		public float YieldTimeLimit { get; set; }

		[ContainerField(24), LayoutImmutable, Blittable]
		public int YieldTime { get; set; }

		[ContainerField(28), LayoutImmutable, Blittable]
		public float MaxInactiveVariableFps { get; set; }

		[ContainerField(32), LayoutImmutable, Blittable]
		public float MaxSimFps { get; set; }

		[ContainerField(36), LayoutImmutable, Blittable]
		public float MaxVariableFps { get; set; }

		[ContainerField(40), LayoutImmutable, Blittable]
		public int ClampTicks { get; set; }

		[ContainerField(44), LayoutImmutable, Blittable]
		public float ForceDeltaTime { get; set; }

		[ContainerField(48), LayoutImmutable, Blittable]
		public int ForceDeltaTickCount { get; set; }

		[ContainerField(52), LayoutImmutable, Blittable]
		public float TimeScale { get; set; }

		[ContainerField(56), LayoutImmutable, Blittable]
		public bool UseWaitableTimers { get; set; }

		[ContainerField(57), LayoutImmutable, Blittable]
		public bool ForceUseSleepTimer { get; set; }

		[ContainerField(58), LayoutImmutable, Blittable]
		public bool ForceSinglePlayerFixedTick { get; set; }

		[ContainerField(59), LayoutImmutable, Blittable]
		public bool ForceMultiplayerOneTickMin { get; set; }

		[ContainerField(60), LayoutImmutable, Blittable]
		public bool VariableSimTickTimeEnable { get; set; }

	}
}
