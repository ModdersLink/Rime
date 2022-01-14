///////////////////////////////////////////////////////////////
//                                                           //
// This is an automatically generated file.                  //
// Do *NOT* modify unless you really know what you're doing. //
//                                                           //
///////////////////////////////////////////////////////////////

using System;
using System.IO;
using System.Collections.Generic;
using Newtonsoft.Json;
using RimeLib.IO;
using RimeLib.Frostbite.Core;
using RimeLib.Serialization.Attributes;
using RimeLib.Serialization;
using RimeLib.Serialization.Ebx;
using RimeLib.Serialization.Frostbite2_0.Ebx;

namespace fb
{
	[ContainerType(4, 64)]
	public class GameTimeSettings :
		SystemSettings
	{
		[ContainerField(12), LayoutImmutable, Blittable, JsonProperty(Order = 12)]
		public float VSyncSubtractTime { get; set; }

		[ContainerField(16), LayoutImmutable, Blittable, JsonProperty(Order = 16)]
		public float JoinJobsTimeLimit { get; set; }

		[ContainerField(20), LayoutImmutable, Blittable, JsonProperty(Order = 20)]
		public float YieldTimeLimit { get; set; }

		[ContainerField(24), LayoutImmutable, Blittable, JsonProperty(Order = 24)]
		public int YieldTime { get; set; }

		[ContainerField(28), LayoutImmutable, Blittable, JsonProperty(Order = 28)]
		public float MaxInactiveVariableFps { get; set; }

		[ContainerField(32), LayoutImmutable, Blittable, JsonProperty(Order = 32)]
		public float MaxSimFps { get; set; }

		[ContainerField(36), LayoutImmutable, Blittable, JsonProperty(Order = 36)]
		public float MaxVariableFps { get; set; }

		[ContainerField(40), LayoutImmutable, Blittable, JsonProperty(Order = 40)]
		public int ClampTicks { get; set; }

		[ContainerField(44), LayoutImmutable, Blittable, JsonProperty(Order = 44)]
		public float ForceDeltaTime { get; set; }

		[ContainerField(48), LayoutImmutable, Blittable, JsonProperty(Order = 48)]
		public int ForceDeltaTickCount { get; set; }

		[ContainerField(52), LayoutImmutable, Blittable, JsonProperty(Order = 52)]
		public float TimeScale { get; set; }

		[ContainerField(56), LayoutImmutable, Blittable, JsonProperty(Order = 56)]
		public bool UseWaitableTimers { get; set; }

		[ContainerField(57), LayoutImmutable, Blittable, JsonProperty(Order = 57)]
		public bool ForceUseSleepTimer { get; set; }

		[ContainerField(58), LayoutImmutable, Blittable, JsonProperty(Order = 58)]
		public bool ForceSinglePlayerFixedTick { get; set; }

		[ContainerField(59), LayoutImmutable, Blittable, JsonProperty(Order = 59)]
		public bool ForceMultiplayerOneTickMin { get; set; }

		[ContainerField(60), LayoutImmutable, Blittable, JsonProperty(Order = 60)]
		public bool VariableSimTickTimeEnable { get; set; }

		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			p_Writer.Write(VSyncSubtractTime);
			p_Writer.Write(JoinJobsTimeLimit);
			p_Writer.Write(YieldTimeLimit);
			p_Writer.Write(YieldTime);
			p_Writer.Write(MaxInactiveVariableFps);
			p_Writer.Write(MaxSimFps);
			p_Writer.Write(MaxVariableFps);
			p_Writer.Write(ClampTicks);
			p_Writer.Write(ForceDeltaTime);
			p_Writer.Write(ForceDeltaTickCount);
			p_Writer.Write(TimeScale);
			p_Writer.Write(UseWaitableTimers);
			p_Writer.Write(ForceUseSleepTimer);
			p_Writer.Write(ForceSinglePlayerFixedTick);
			p_Writer.Write(ForceMultiplayerOneTickMin);
			p_Writer.Write(VariableSimTickTimeEnable);
			p_Writer.WriteNullBytes(3);
		}
	}
}
