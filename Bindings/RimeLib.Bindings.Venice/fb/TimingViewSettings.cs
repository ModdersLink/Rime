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

namespace fb
{
	[ContainerType(8, 112)]
	public class TimingViewSettings : 
		DataContainer
	{
		[ContainerField(8), LayoutImmutable, Blittable, JsonProperty(Order = 8)]
		public uint MaxFrameEventCount { get; set; }

		[ContainerField(12), LayoutImmutable, Blittable, JsonProperty(Order = 12)]
		public uint FrameCount { get; set; }

		[ContainerField(16), LayoutImmutable, Blittable, JsonProperty(Order = 16)]
		public uint FrameDelayCount { get; set; }

		[ContainerField(20), LayoutImmutable, Blittable, JsonProperty(Order = 20)]
		public float TimeRange { get; set; }

		[ContainerField(24), LayoutImmutable, Blittable, JsonProperty(Order = 24)]
		public float TimeOffset { get; set; }

		[ContainerField(28), LayoutImmutable, Blittable, JsonProperty(Order = 28)]
		public float AutolockThreshold { get; set; }

		[ContainerField(32), LayoutImmutable, JsonProperty(Order = 32)]
		public string AutolockNameFilter { get; set; } = string.Empty;

		[ContainerField(36), LayoutImmutable, Blittable, JsonProperty(Order = 36)]
		public int LegendScreenOffset { get; set; }

		[ContainerField(40), LayoutImmutable, Blittable, JsonProperty(Order = 40)]
		public int LegendColumnWidth { get; set; }

		[ContainerField(44), LayoutImmutable, Blittable, JsonProperty(Order = 44)]
		public int LegendDisplayMode { get; set; }

		[ContainerField(48), LayoutImmutable, Blittable, JsonProperty(Order = 48)]
		public int AverageFrameCount { get; set; }

		[ContainerField(52), LayoutImmutable, Blittable, JsonProperty(Order = 52)]
		public int MaxGpuLegendColumnCount { get; set; }

		[ContainerField(56), LayoutImmutable, JsonProperty(Order = 56)]
		public string SnoopEventName { get; set; } = string.Empty;

		[ContainerField(60), LayoutImmutable, Blittable, JsonProperty(Order = 60)]
		public int GpuBarFrameOffset { get; set; }

		[ContainerField(64), LayoutImmutable, Blittable, JsonProperty(Order = 64)]
		public int MaxCpuLegendColumnCount { get; set; }

		[ContainerField(68), LayoutImmutable, Blittable, JsonProperty(Order = 68)]
		public uint BarPad { get; set; }

		[ContainerField(72), LayoutImmutable, Blittable, JsonProperty(Order = 72)]
		public int MaxSpuLegendColumnCount { get; set; }

		[ContainerField(76), LayoutImmutable, Blittable, JsonProperty(Order = 76)]
		public int BarSyncProcessor { get; set; }

		[ContainerField(80), LayoutImmutable, Blittable, JsonProperty(Order = 80)]
		public double BarMinTime { get; set; }

		[ContainerField(88), LayoutImmutable, Blittable, JsonProperty(Order = 88)]
		public uint BarHeight { get; set; }

		[ContainerField(92), LayoutImmutable, JsonProperty(Order = 92)]
		public string FilterEventName { get; set; } = string.Empty;

		[ContainerField(96), LayoutImmutable, Blittable, JsonProperty(Order = 96)]
		public bool SnoopOnly { get; set; }

		[ContainerField(97), LayoutImmutable, Blittable, JsonProperty(Order = 97)]
		public bool DrawEnable { get; set; }

		[ContainerField(98), LayoutImmutable, Blittable, JsonProperty(Order = 98)]
		public bool DrawSpuLegendEnable { get; set; }

		[ContainerField(99), LayoutImmutable, Blittable, JsonProperty(Order = 99)]
		public bool SnoopEnable { get; set; }

		[ContainerField(100), LayoutImmutable, Blittable, JsonProperty(Order = 100)]
		public bool FilterEnable { get; set; }

		[ContainerField(101), LayoutImmutable, Blittable, JsonProperty(Order = 101)]
		public bool DrawBarsEnable { get; set; }

		[ContainerField(102), LayoutImmutable, Blittable, JsonProperty(Order = 102)]
		public bool DrawLegendEnable { get; set; }

		[ContainerField(103), LayoutImmutable, Blittable, JsonProperty(Order = 103)]
		public bool DrawOnlySummaryEnable { get; set; }

		[ContainerField(104), LayoutImmutable, Blittable, JsonProperty(Order = 104)]
		public bool SortByTime { get; set; }

		[ContainerField(105), LayoutImmutable, Blittable, JsonProperty(Order = 105)]
		public bool DrawCpuLegendEnable { get; set; }

		[ContainerField(106), LayoutImmutable, Blittable, JsonProperty(Order = 106)]
		public bool DrawGpuLegendEnable { get; set; }

		[ContainerField(107), LayoutImmutable, Blittable, JsonProperty(Order = 107)]
		public bool Enable { get; set; }

	}
}
