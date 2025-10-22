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

[ContainerType(8, 40)]
public class PerformanceTrackerSettings
	: fb.Core.SystemSettings
{
	public PerformanceTrackerSettings()
	{
		//SystemSettings
		Name = @"PerformanceTracker";
	}
	
	[ContainerField(0x20), LayoutImmutable, Blittable, JsonProperty(Order = 32)]
	public float Interval { get; set; } = 10.000f;
	
	[ContainerField(0x24), LayoutImmutable, Blittable, JsonProperty(Order = 36)]
	public bool Enabled { get; set; } = true;
	
	[ContainerField(0x25), LayoutImmutable, Blittable, JsonProperty(Order = 37)]
	public bool SupressPerformanceStatsOnIdle { get; set; } = false;
	
	[ContainerField(0x26), LayoutImmutable, Blittable, JsonProperty(Order = 38)]
	public bool SupressPerformanceStatsUntilSpawned { get; set; } = true;
	
	[ContainerField(0x27), LayoutImmutable, Blittable, JsonProperty(Order = 39)]
	public bool JuiceLogPerformance { get; set; } = true;
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(Interval);
		p_Writer.Write(Enabled);
		p_Writer.Write(SupressPerformanceStatsOnIdle);
		p_Writer.Write(SupressPerformanceStatsUntilSpawned);
		p_Writer.Write(JuiceLogPerformance);
	}
}

