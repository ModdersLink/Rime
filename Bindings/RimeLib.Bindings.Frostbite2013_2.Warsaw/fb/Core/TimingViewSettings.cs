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

[ContainerType(8, 136)]
public class TimingViewSettings
	: fb.Core.DataContainer
{
	[ContainerField(0x10), LayoutImmutable, Blittable, JsonProperty(Order = 16)]
	public uint FrameCount { get; set; } = 3;
	
	[ContainerField(0x14), LayoutImmutable, Blittable, JsonProperty(Order = 20)]
	public uint FrameDelayCount { get; set; } = 2;
	
	[ContainerField(0x18), LayoutImmutable, Blittable, JsonProperty(Order = 24)]
	public float TimeRange { get; set; } = 100.000f;
	
	[ContainerField(0x1c), LayoutImmutable, Blittable, JsonProperty(Order = 28)]
	public float TimeOffset { get; set; } = 0.000f;
	
	[ContainerField(0x20), LayoutImmutable, Blittable, JsonProperty(Order = 32)]
	public float AutolockThreshold { get; set; } = 0.000f;
	
	[ContainerField(0x28), LayoutImmutable, Blittable, JsonProperty(Order = 40)]
	public string AutolockNameFilter { get; set; } = string.Empty;
	
	[ContainerField(0x30), LayoutImmutable, Blittable, JsonProperty(Order = 48)]
	public int LegendScreenOffset { get; set; } = 450;
	
	[ContainerField(0x34), LayoutImmutable, Blittable, JsonProperty(Order = 52)]
	public int LegendColumnWidth { get; set; } = 210;
	
	[ContainerField(0x38), LayoutImmutable, Blittable, JsonProperty(Order = 56)]
	public int LegendDisplayMode { get; set; } = 0;
	
	[ContainerField(0x3c), LayoutImmutable, Blittable, JsonProperty(Order = 60)]
	public int AverageFrameCount { get; set; } = 500;
	
	[ContainerField(0x40), LayoutImmutable, Blittable, JsonProperty(Order = 64)]
	public string SnoopEventName { get; set; } = string.Empty;
	
	[ContainerField(0x48), LayoutImmutable, Blittable, JsonProperty(Order = 72)]
	public string FilterEventName { get; set; } = string.Empty;
	
	[ContainerField(0x50), LayoutImmutable, Blittable, JsonProperty(Order = 80)]
	public double BarMinTime { get; set; } = 0.000;
	
	[ContainerField(0x58), LayoutImmutable, Blittable, JsonProperty(Order = 88)]
	public uint BarHeight { get; set; } = 18;
	
	[ContainerField(0x5c), LayoutImmutable, Blittable, JsonProperty(Order = 92)]
	public uint BarPad { get; set; } = 6;
	
	[ContainerField(0x60), LayoutImmutable, Blittable, JsonProperty(Order = 96)]
	public int BarSyncProcessor { get; set; } = -1;
	
	[ContainerField(0x64), LayoutImmutable, Blittable, JsonProperty(Order = 100)]
	public int GpuBarFrameOffset { get; set; } = 1;
	
	[ContainerField(0x68), LayoutImmutable, Blittable, JsonProperty(Order = 104)]
	public int MaxCpuLegendColumnCount { get; set; } = -1;
	
	[ContainerField(0x6c), LayoutImmutable, Blittable, JsonProperty(Order = 108)]
	public int MaxGpuLegendColumnCount { get; set; } = -1;
	
	[ContainerField(0x70), LayoutImmutable, Blittable, JsonProperty(Order = 112)]
	public int MaxSpuLegendColumnCount { get; set; } = -1;
	
	[ContainerField(0x74), LayoutImmutable, Blittable, JsonProperty(Order = 116)]
	public uint MaxFrameEventCount { get; set; } = 10000;
	
	[ContainerField(0x78), LayoutImmutable, Blittable, JsonProperty(Order = 120)]
	public bool Enable { get; set; } = false;
	
	[ContainerField(0x79), LayoutImmutable, Blittable, JsonProperty(Order = 121)]
	public bool DrawEnable { get; set; } = true;
	
	[ContainerField(0x7a), LayoutImmutable, Blittable, JsonProperty(Order = 122)]
	public bool DrawBarsEnable { get; set; } = true;
	
	[ContainerField(0x7b), LayoutImmutable, Blittable, JsonProperty(Order = 123)]
	public bool DrawLegendEnable { get; set; } = true;
	
	[ContainerField(0x7c), LayoutImmutable, Blittable, JsonProperty(Order = 124)]
	public bool DrawCpuLegendEnable { get; set; } = true;
	
	[ContainerField(0x7d), LayoutImmutable, Blittable, JsonProperty(Order = 125)]
	public bool DrawGpuLegendEnable { get; set; } = true;
	
	[ContainerField(0x7e), LayoutImmutable, Blittable, JsonProperty(Order = 126)]
	public bool DrawSpuLegendEnable { get; set; } = true;
	
	[ContainerField(0x7f), LayoutImmutable, Blittable, JsonProperty(Order = 127)]
	public bool SnoopEnable { get; set; } = false;
	
	[ContainerField(0x80), LayoutImmutable, Blittable, JsonProperty(Order = 128)]
	public bool SnoopOnly { get; set; } = false;
	
	[ContainerField(0x81), LayoutImmutable, Blittable, JsonProperty(Order = 129)]
	public bool SortByTime { get; set; } = false;
	
	[ContainerField(0x82), LayoutImmutable, Blittable, JsonProperty(Order = 130)]
	public bool FilterEnable { get; set; } = false;
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(FrameCount);
		p_Writer.Write(FrameDelayCount);
		p_Writer.Write(TimeRange);
		p_Writer.Write(TimeOffset);
		p_Writer.Write(AutolockThreshold);
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(p_EbxWriter.WriteString(AutolockNameFilter));
		p_Writer.Write(LegendScreenOffset);
		p_Writer.Write(LegendColumnWidth);
		p_Writer.Write(LegendDisplayMode);
		p_Writer.Write(AverageFrameCount);
		p_Writer.Write(p_EbxWriter.WriteString(SnoopEventName));
		p_Writer.Write(p_EbxWriter.WriteString(FilterEventName));
		p_Writer.Write(BarMinTime);
		p_Writer.Write(BarHeight);
		p_Writer.Write(BarPad);
		p_Writer.Write(BarSyncProcessor);
		p_Writer.Write(GpuBarFrameOffset);
		p_Writer.Write(MaxCpuLegendColumnCount);
		p_Writer.Write(MaxGpuLegendColumnCount);
		p_Writer.Write(MaxSpuLegendColumnCount);
		p_Writer.Write(MaxFrameEventCount);
		p_Writer.Write(Enable);
		p_Writer.Write(DrawEnable);
		p_Writer.Write(DrawBarsEnable);
		p_Writer.Write(DrawLegendEnable);
		p_Writer.Write(DrawCpuLegendEnable);
		p_Writer.Write(DrawGpuLegendEnable);
		p_Writer.Write(DrawSpuLegendEnable);
		p_Writer.Write(SnoopEnable);
		p_Writer.Write(SnoopOnly);
		p_Writer.Write(SortByTime);
		p_Writer.Write(FilterEnable);
		p_Writer.WriteNullBytes(5);
	}
}

