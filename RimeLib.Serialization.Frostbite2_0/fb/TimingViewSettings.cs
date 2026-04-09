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
using RimeLib.Serialization.Frostbite2_0.Ebx;
using CommunityToolkit.Mvvm.ComponentModel;

namespace fb
{
	[ContainerType(8, 112)]
	public partial class TimingViewSettings :
		DataContainer
	{
		[ObservableProperty]
		[property: ContainerField(8), LayoutImmutable, Blittable, JsonProperty(Order = 8)]
		private uint _MaxFrameEventCount;

		[ObservableProperty]
		[property: ContainerField(12), LayoutImmutable, Blittable, JsonProperty(Order = 12)]
		private uint _FrameCount;

		[ObservableProperty]
		[property: ContainerField(16), LayoutImmutable, Blittable, JsonProperty(Order = 16)]
		private uint _FrameDelayCount;

		[ObservableProperty]
		[property: ContainerField(20), LayoutImmutable, Blittable, JsonProperty(Order = 20)]
		private float _TimeRange;

		[ObservableProperty]
		[property: ContainerField(24), LayoutImmutable, Blittable, JsonProperty(Order = 24)]
		private float _TimeOffset;

		[ObservableProperty]
		[property: ContainerField(28), LayoutImmutable, Blittable, JsonProperty(Order = 28)]
		private float _AutolockThreshold;

		[ObservableProperty]
		[property: ContainerField(32), LayoutImmutable, JsonProperty(Order = 32)]
		private string _AutolockNameFilter = string.Empty;

		[ObservableProperty]
		[property: ContainerField(36), LayoutImmutable, Blittable, JsonProperty(Order = 36)]
		private int _LegendScreenOffset;

		[ObservableProperty]
		[property: ContainerField(40), LayoutImmutable, Blittable, JsonProperty(Order = 40)]
		private int _LegendColumnWidth;

		[ObservableProperty]
		[property: ContainerField(44), LayoutImmutable, Blittable, JsonProperty(Order = 44)]
		private int _LegendDisplayMode;

		[ObservableProperty]
		[property: ContainerField(48), LayoutImmutable, Blittable, JsonProperty(Order = 48)]
		private int _AverageFrameCount;

		[ObservableProperty]
		[property: ContainerField(52), LayoutImmutable, Blittable, JsonProperty(Order = 52)]
		private int _MaxGpuLegendColumnCount;

		[ObservableProperty]
		[property: ContainerField(56), LayoutImmutable, JsonProperty(Order = 56)]
		private string _SnoopEventName = string.Empty;

		[ObservableProperty]
		[property: ContainerField(60), LayoutImmutable, Blittable, JsonProperty(Order = 60)]
		private int _GpuBarFrameOffset;

		[ObservableProperty]
		[property: ContainerField(64), LayoutImmutable, Blittable, JsonProperty(Order = 64)]
		private int _MaxCpuLegendColumnCount;

		[ObservableProperty]
		[property: ContainerField(68), LayoutImmutable, Blittable, JsonProperty(Order = 68)]
		private uint _BarPad;

		[ObservableProperty]
		[property: ContainerField(72), LayoutImmutable, Blittable, JsonProperty(Order = 72)]
		private int _MaxSpuLegendColumnCount;

		[ObservableProperty]
		[property: ContainerField(76), LayoutImmutable, Blittable, JsonProperty(Order = 76)]
		private int _BarSyncProcessor;

		[ObservableProperty]
		[property: ContainerField(80), LayoutImmutable, Blittable, JsonProperty(Order = 80)]
		private double _BarMinTime;

		[ObservableProperty]
		[property: ContainerField(88), LayoutImmutable, Blittable, JsonProperty(Order = 88)]
		private uint _BarHeight;

		[ObservableProperty]
		[property: ContainerField(92), LayoutImmutable, JsonProperty(Order = 92)]
		private string _FilterEventName = string.Empty;

		[ObservableProperty]
		[property: ContainerField(96), LayoutImmutable, Blittable, JsonProperty(Order = 96)]
		private bool _SnoopOnly;

		[ObservableProperty]
		[property: ContainerField(97), LayoutImmutable, Blittable, JsonProperty(Order = 97)]
		private bool _DrawEnable;

		[ObservableProperty]
		[property: ContainerField(98), LayoutImmutable, Blittable, JsonProperty(Order = 98)]
		private bool _DrawSpuLegendEnable;

		[ObservableProperty]
		[property: ContainerField(99), LayoutImmutable, Blittable, JsonProperty(Order = 99)]
		private bool _SnoopEnable;

		[ObservableProperty]
		[property: ContainerField(100), LayoutImmutable, Blittable, JsonProperty(Order = 100)]
		private bool _FilterEnable;

		[ObservableProperty]
		[property: ContainerField(101), LayoutImmutable, Blittable, JsonProperty(Order = 101)]
		private bool _DrawBarsEnable;

		[ObservableProperty]
		[property: ContainerField(102), LayoutImmutable, Blittable, JsonProperty(Order = 102)]
		private bool _DrawLegendEnable;

		[ObservableProperty]
		[property: ContainerField(103), LayoutImmutable, Blittable, JsonProperty(Order = 103)]
		private bool _DrawOnlySummaryEnable;

		[ObservableProperty]
		[property: ContainerField(104), LayoutImmutable, Blittable, JsonProperty(Order = 104)]
		private bool _SortByTime;

		[ObservableProperty]
		[property: ContainerField(105), LayoutImmutable, Blittable, JsonProperty(Order = 105)]
		private bool _DrawCpuLegendEnable;

		[ObservableProperty]
		[property: ContainerField(106), LayoutImmutable, Blittable, JsonProperty(Order = 106)]
		private bool _DrawGpuLegendEnable;

		[ObservableProperty]
		[property: ContainerField(107), LayoutImmutable, Blittable, JsonProperty(Order = 107)]
		private bool _Enable;

		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			p_Writer.WriteNullBytes(8);
			p_Writer.Write(MaxFrameEventCount);
			p_Writer.Write(FrameCount);
			p_Writer.Write(FrameDelayCount);
			p_Writer.Write(TimeRange);
			p_Writer.Write(TimeOffset);
			p_Writer.Write(AutolockThreshold);
			p_Writer.Write(p_EbxWriter.WriteString(AutolockNameFilter));
			p_Writer.Write(LegendScreenOffset);
			p_Writer.Write(LegendColumnWidth);
			p_Writer.Write(LegendDisplayMode);
			p_Writer.Write(AverageFrameCount);
			p_Writer.Write(MaxGpuLegendColumnCount);
			p_Writer.Write(p_EbxWriter.WriteString(SnoopEventName));
			p_Writer.Write(GpuBarFrameOffset);
			p_Writer.Write(MaxCpuLegendColumnCount);
			p_Writer.Write(BarPad);
			p_Writer.Write(MaxSpuLegendColumnCount);
			p_Writer.Write(BarSyncProcessor);
			p_Writer.Write(BarMinTime);
			p_Writer.Write(BarHeight);
			p_Writer.Write(p_EbxWriter.WriteString(FilterEventName));
			p_Writer.Write(SnoopOnly);
			p_Writer.Write(DrawEnable);
			p_Writer.Write(DrawSpuLegendEnable);
			p_Writer.Write(SnoopEnable);
			p_Writer.Write(FilterEnable);
			p_Writer.Write(DrawBarsEnable);
			p_Writer.Write(DrawLegendEnable);
			p_Writer.Write(DrawOnlySummaryEnable);
			p_Writer.Write(SortByTime);
			p_Writer.Write(DrawCpuLegendEnable);
			p_Writer.Write(DrawGpuLegendEnable);
			p_Writer.Write(Enable);
			p_Writer.WriteNullBytes(4);
		}
	}
}
