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

namespace fb.VeniceShared;

[ContainerType(8, 32)]
public class PerfHudSettings
	: fb.Core.DataContainer
{
	[ContainerField(0x10), LayoutImmutable, Blittable, JsonProperty(Order = 16)]
	public string TimerCategorySetName { get; set; } = string.Empty;
	
	[ContainerField(0x18), LayoutImmutable, Blittable, JsonProperty(Order = 24)]
	public bool Enable { get; set; } = false;
	
	[ContainerField(0x19), LayoutImmutable, Blittable, JsonProperty(Order = 25)]
	public bool DrawCpuEnable { get; set; } = true;
	
	[ContainerField(0x1a), LayoutImmutable, Blittable, JsonProperty(Order = 26)]
	public bool DrawGpuEnable { get; set; } = true;
	
	[ContainerField(0x1b), LayoutImmutable, Blittable, JsonProperty(Order = 27)]
	public bool DrawSpuEnable { get; set; } = true;
	
	[ContainerField(0x1c), LayoutImmutable, Blittable, JsonProperty(Order = 28)]
	public bool SimpleSummaryMode { get; set; } = false;
	
	[ContainerField(0x1d), LayoutImmutable, Blittable, JsonProperty(Order = 29)]
	public bool TimerCategorySetsEnable { get; set; } = false;
	
	[ContainerField(0x1e), LayoutImmutable, Blittable, JsonProperty(Order = 30)]
	public bool DrawUngroupedTimings { get; set; } = false;
	
	[ContainerField(0x1f), LayoutImmutable, Blittable, JsonProperty(Order = 31)]
	public bool DrawConfigFile { get; set; } = false;
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(p_EbxWriter.WriteString(TimerCategorySetName));
		p_Writer.Write(Enable);
		p_Writer.Write(DrawCpuEnable);
		p_Writer.Write(DrawGpuEnable);
		p_Writer.Write(DrawSpuEnable);
		p_Writer.Write(SimpleSummaryMode);
		p_Writer.Write(TimerCategorySetsEnable);
		p_Writer.Write(DrawUngroupedTimings);
		p_Writer.Write(DrawConfigFile);
	}
}

