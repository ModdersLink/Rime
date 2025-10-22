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

[ContainerType(8, 80)]
public class DemoSettings
	: fb.Core.DataContainer
{
	[ContainerField(0x10), LayoutImmutable, Blittable, JsonProperty(Order = 16)]
	public string RecordDemoFileName { get; set; } = string.Empty;
	
	[ContainerField(0x18), LayoutImmutable, Blittable, JsonProperty(Order = 24)]
	public string PlaybackDemoFileName { get; set; } = string.Empty;
	
	[ContainerField(0x20), LayoutImmutable, Blittable, JsonProperty(Order = 32)]
	public string TimeDemo { get; set; } = string.Empty;
	
	[ContainerField(0x28), LayoutImmutable, Blittable, JsonProperty(Order = 40)]
	public string LockToPlayerName { get; set; } = string.Empty;
	
	[ContainerField(0x30), LayoutImmutable, Blittable, JsonProperty(Order = 48)]
	public uint ChangePlayerInterval { get; set; } = 0;
	
	[ContainerField(0x34), LayoutImmutable, Blittable, JsonProperty(Order = 52)]
	public uint ForcedDeltaTickCount { get; set; } = 0;
	
	[ContainerField(0x38), LayoutImmutable, Blittable, JsonProperty(Order = 56)]
	public uint StartProfilingOnFrame { get; set; } = 0;
	
	[ContainerField(0x3c), LayoutImmutable, Blittable, JsonProperty(Order = 60)]
	public uint StopProfilingOnFrame { get; set; } = 0;
	
	[ContainerField(0x40), LayoutImmutable, Blittable, JsonProperty(Order = 64)]
	public uint TakeScreenshotOnFrame { get; set; } = 0;
	
	[ContainerField(0x44), LayoutImmutable, Blittable, JsonProperty(Order = 68)]
	public bool PauseOnStartup { get; set; } = false;
	
	[ContainerField(0x45), LayoutImmutable, Blittable, JsonProperty(Order = 69)]
	public bool AllowOverwrite { get; set; } = true;
	
	[ContainerField(0x46), LayoutImmutable, Blittable, JsonProperty(Order = 70)]
	public bool LogPerformance { get; set; } = true;
	
	[ContainerField(0x47), LayoutImmutable, Blittable, JsonProperty(Order = 71)]
	public bool SuppressDebugLog { get; set; } = false;
	
	[ContainerField(0x48), LayoutImmutable, Blittable, JsonProperty(Order = 72)]
	public bool ShutdownOnDemoComplete { get; set; } = false;
	
	[ContainerField(0x49), LayoutImmutable, Blittable, JsonProperty(Order = 73)]
	public bool LoopingDemo { get; set; } = true;
	
	[ContainerField(0x4a), LayoutImmutable, Blittable, JsonProperty(Order = 74)]
	public bool LockToRandomPlayer { get; set; } = false;
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(p_EbxWriter.WriteString(RecordDemoFileName));
		p_Writer.Write(p_EbxWriter.WriteString(PlaybackDemoFileName));
		p_Writer.Write(p_EbxWriter.WriteString(TimeDemo));
		p_Writer.Write(p_EbxWriter.WriteString(LockToPlayerName));
		p_Writer.Write(ChangePlayerInterval);
		p_Writer.Write(ForcedDeltaTickCount);
		p_Writer.Write(StartProfilingOnFrame);
		p_Writer.Write(StopProfilingOnFrame);
		p_Writer.Write(TakeScreenshotOnFrame);
		p_Writer.Write(PauseOnStartup);
		p_Writer.Write(AllowOverwrite);
		p_Writer.Write(LogPerformance);
		p_Writer.Write(SuppressDebugLog);
		p_Writer.Write(ShutdownOnDemoComplete);
		p_Writer.Write(LoopingDemo);
		p_Writer.Write(LockToRandomPlayer);
		p_Writer.WriteNullBytes(5);
	}
}

