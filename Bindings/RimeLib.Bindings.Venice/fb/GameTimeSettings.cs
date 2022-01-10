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

		public static void Deserialize(GameTimeSettings p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.VSyncSubtractTime = p_Reader.ReadSingle();
			p_Instance.JoinJobsTimeLimit = p_Reader.ReadSingle();
			p_Instance.YieldTimeLimit = p_Reader.ReadSingle();
			p_Instance.YieldTime = p_Reader.ReadInt32();
			p_Instance.MaxInactiveVariableFps = p_Reader.ReadSingle();
			p_Instance.MaxSimFps = p_Reader.ReadSingle();
			p_Instance.MaxVariableFps = p_Reader.ReadSingle();
			p_Instance.ClampTicks = p_Reader.ReadInt32();
			p_Instance.ForceDeltaTime = p_Reader.ReadSingle();
			p_Instance.ForceDeltaTickCount = p_Reader.ReadInt32();
			p_Instance.TimeScale = p_Reader.ReadSingle();
			p_Instance.UseWaitableTimers = p_Reader.ReadBool();
			p_Instance.ForceUseSleepTimer = p_Reader.ReadBool();
			p_Instance.ForceSinglePlayerFixedTick = p_Reader.ReadBool();
			p_Instance.ForceMultiplayerOneTickMin = p_Reader.ReadBool();
			p_Instance.VariableSimTickTimeEnable = p_Reader.ReadBool();
			p_Reader.Seek(3, SeekOrigin.Current);
		}

	}
}
