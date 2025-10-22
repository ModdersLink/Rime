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


namespace fb.Core;

[ContainerType(8, 40)]
public class PerfJournalSettings
	: fb.Core.DataContainer
{
	[ContainerField(0x10), LayoutImmutable, Blittable, JsonProperty(Order = 16)]
	public int JournalSampleInterval { get; set; } = 1;
	
	[ContainerField(0x14), LayoutImmutable, Blittable, JsonProperty(Order = 20)]
	public int JournalFrameCount { get; set; } = 0;
	
	[ContainerField(0x18), LayoutImmutable, Blittable, JsonProperty(Order = 24)]
	public float AutoJournalThresholdMs { get; set; } = 33.500f;
	
	[ContainerField(0x1c), LayoutImmutable, Blittable, JsonProperty(Order = 28)]
	public int AutoJournalMinFrames { get; set; } = 60;
	
	[ContainerField(0x20), LayoutImmutable, Blittable, JsonProperty(Order = 32)]
	public bool Enable { get; set; } = false;
	
	[ContainerField(0x21), LayoutImmutable, Blittable, JsonProperty(Order = 33)]
	public bool JournalExpensiveStats { get; set; } = false;
	
	[ContainerField(0x22), LayoutImmutable, Blittable, JsonProperty(Order = 34)]
	public bool JournalAllSPU { get; set; } = false;
	
	[ContainerField(0x23), LayoutImmutable, Blittable, JsonProperty(Order = 35)]
	public bool JournalReportAverage { get; set; } = false;
	
	[ContainerField(0x24), LayoutImmutable, Blittable, JsonProperty(Order = 36)]
	public bool AutoJournalEnable { get; set; } = false;
	
	[ContainerField(0x25), LayoutImmutable, Blittable, JsonProperty(Order = 37)]
	public bool AutoJournalScreenshot { get; set; } = false;
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(JournalSampleInterval);
		p_Writer.Write(JournalFrameCount);
		p_Writer.Write(AutoJournalThresholdMs);
		p_Writer.Write(AutoJournalMinFrames);
		p_Writer.Write(Enable);
		p_Writer.Write(JournalExpensiveStats);
		p_Writer.Write(JournalAllSPU);
		p_Writer.Write(JournalReportAverage);
		p_Writer.Write(AutoJournalEnable);
		p_Writer.Write(AutoJournalScreenshot);
		p_Writer.WriteNullBytes(2);
	}
}

