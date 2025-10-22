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

using fb.Core;

namespace fb.GameShared;

[ContainerType(8, 88)]
public class GameTimeSettings
	: fb.Core.SystemSettings
{
	public GameTimeSettings()
	{
		//SystemSettings
		Name = @"GameTime";
	}
	
	[ContainerField(0x20), LayoutImmutable, Blittable, JsonProperty(Order = 32)]
	public float JoinJobsTimeLimit { get; set; } = 2.000f;
	
	[ContainerField(0x24), LayoutImmutable, Blittable, JsonProperty(Order = 36)]
	public float YieldTimeLimit { get; set; } = 1.500f;
	
	[ContainerField(0x28), LayoutImmutable, Blittable, JsonProperty(Order = 40)]
	public int YieldTime { get; set; } = 1;
	
	[ContainerField(0x2c), LayoutImmutable, Blittable, JsonProperty(Order = 44)]
	public float MaxSimFps { get; set; } = 30.000f;
	
	[ContainerField(0x30), LayoutImmutable, Blittable, JsonProperty(Order = 48)]
	public uint ForceSimRate { get; set; } = 30;
	
	[ContainerField(0x34), LayoutImmutable, Blittable, JsonProperty(Order = 52)]
	public float MaxVariableFps { get; set; } = 200.000f;
	
	[ContainerField(0x38), LayoutImmutable, Blittable, JsonProperty(Order = 56)]
	public float MaxInactiveVariableFps { get; set; } = 10.000f;
	
	[ContainerField(0x3c), LayoutImmutable, Blittable, JsonProperty(Order = 60)]
	public float ForceDeltaTime { get; set; } = -1.000f;
	
	[ContainerField(0x40), LayoutImmutable, Blittable, JsonProperty(Order = 64)]
	public int ForceDeltaTickCount { get; set; } = -1;
	
	[ContainerField(0x44), LayoutImmutable, Blittable, JsonProperty(Order = 68)]
	public int ClampTicks { get; set; } = 2;
	
	[ContainerField(0x48), LayoutImmutable, Blittable, JsonProperty(Order = 72)]
	public float TimeScale { get; set; } = 1.000f;
	
	[ContainerField(0x4c), LayoutImmutable, Blittable, JsonProperty(Order = 76)]
	public float DebugFrameDelay { get; set; } = 0.000f;
	
	[ContainerField(0x50), LayoutImmutable, Blittable, JsonProperty(Order = 80)]
	public bool UseWaitableTimers { get; set; } = false;
	
	[ContainerField(0x51), LayoutImmutable, Blittable, JsonProperty(Order = 81)]
	public bool DoubleNoTickWait { get; set; } = false;
	
	[ContainerField(0x52), LayoutImmutable, Blittable, JsonProperty(Order = 82)]
	public bool VariableSimTickTimeEnable { get; set; } = false;
	
	[ContainerField(0x53), LayoutImmutable, Blittable, JsonProperty(Order = 83)]
	public bool ForceUseSleepTimer { get; set; } = false;
	
	[ContainerField(0x54), LayoutImmutable, Blittable, JsonProperty(Order = 84)]
	public bool ForceSinglePlayerFixedTick { get; set; } = false;
	
	[ContainerField(0x55), LayoutImmutable, Blittable, JsonProperty(Order = 85)]
	public bool ForceMultiplayerOneTickMin { get; set; } = false;
	
	[ContainerField(0x56), LayoutImmutable, Blittable, JsonProperty(Order = 86)]
	public bool EnableSinglePlayerFixedTick { get; set; } = true;
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(JoinJobsTimeLimit);
		p_Writer.Write(YieldTimeLimit);
		p_Writer.Write(YieldTime);
		p_Writer.Write(MaxSimFps);
		p_Writer.Write(ForceSimRate);
		p_Writer.Write(MaxVariableFps);
		p_Writer.Write(MaxInactiveVariableFps);
		p_Writer.Write(ForceDeltaTime);
		p_Writer.Write(ForceDeltaTickCount);
		p_Writer.Write(ClampTicks);
		p_Writer.Write(TimeScale);
		p_Writer.Write(DebugFrameDelay);
		p_Writer.Write(UseWaitableTimers);
		p_Writer.Write(DoubleNoTickWait);
		p_Writer.Write(VariableSimTickTimeEnable);
		p_Writer.Write(ForceUseSleepTimer);
		p_Writer.Write(ForceSinglePlayerFixedTick);
		p_Writer.Write(ForceMultiplayerOneTickMin);
		p_Writer.Write(EnableSinglePlayerFixedTick);
		p_Writer.WriteNullBytes(1);
	}
}

