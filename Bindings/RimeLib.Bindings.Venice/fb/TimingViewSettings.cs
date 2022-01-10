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
	[ContainerType(8, 112)]
	public class TimingViewSettings : 
		DataContainer
	{
		[ContainerField(8), LayoutImmutable, Blittable]
		public uint MaxFrameEventCount { get; set; }

		[ContainerField(12), LayoutImmutable, Blittable]
		public uint FrameCount { get; set; }

		[ContainerField(16), LayoutImmutable, Blittable]
		public uint FrameDelayCount { get; set; }

		[ContainerField(20), LayoutImmutable, Blittable]
		public float TimeRange { get; set; }

		[ContainerField(24), LayoutImmutable, Blittable]
		public float TimeOffset { get; set; }

		[ContainerField(28), LayoutImmutable, Blittable]
		public float AutolockThreshold { get; set; }

		[ContainerField(32), LayoutImmutable]
		public string AutolockNameFilter { get; set; } = string.Empty;

		[ContainerField(36), LayoutImmutable, Blittable]
		public int LegendScreenOffset { get; set; }

		[ContainerField(40), LayoutImmutable, Blittable]
		public int LegendColumnWidth { get; set; }

		[ContainerField(44), LayoutImmutable, Blittable]
		public int LegendDisplayMode { get; set; }

		[ContainerField(48), LayoutImmutable, Blittable]
		public int AverageFrameCount { get; set; }

		[ContainerField(52), LayoutImmutable, Blittable]
		public int MaxGpuLegendColumnCount { get; set; }

		[ContainerField(56), LayoutImmutable]
		public string SnoopEventName { get; set; } = string.Empty;

		[ContainerField(60), LayoutImmutable, Blittable]
		public int GpuBarFrameOffset { get; set; }

		[ContainerField(64), LayoutImmutable, Blittable]
		public int MaxCpuLegendColumnCount { get; set; }

		[ContainerField(68), LayoutImmutable, Blittable]
		public uint BarPad { get; set; }

		[ContainerField(72), LayoutImmutable, Blittable]
		public int MaxSpuLegendColumnCount { get; set; }

		[ContainerField(76), LayoutImmutable, Blittable]
		public int BarSyncProcessor { get; set; }

		[ContainerField(80), LayoutImmutable, Blittable]
		public double BarMinTime { get; set; }

		[ContainerField(88), LayoutImmutable, Blittable]
		public uint BarHeight { get; set; }

		[ContainerField(92), LayoutImmutable]
		public string FilterEventName { get; set; } = string.Empty;

		[ContainerField(96), LayoutImmutable, Blittable]
		public bool SnoopOnly { get; set; }

		[ContainerField(97), LayoutImmutable, Blittable]
		public bool DrawEnable { get; set; }

		[ContainerField(98), LayoutImmutable, Blittable]
		public bool DrawSpuLegendEnable { get; set; }

		[ContainerField(99), LayoutImmutable, Blittable]
		public bool SnoopEnable { get; set; }

		[ContainerField(100), LayoutImmutable, Blittable]
		public bool FilterEnable { get; set; }

		[ContainerField(101), LayoutImmutable, Blittable]
		public bool DrawBarsEnable { get; set; }

		[ContainerField(102), LayoutImmutable, Blittable]
		public bool DrawLegendEnable { get; set; }

		[ContainerField(103), LayoutImmutable, Blittable]
		public bool DrawOnlySummaryEnable { get; set; }

		[ContainerField(104), LayoutImmutable, Blittable]
		public bool SortByTime { get; set; }

		[ContainerField(105), LayoutImmutable, Blittable]
		public bool DrawCpuLegendEnable { get; set; }

		[ContainerField(106), LayoutImmutable, Blittable]
		public bool DrawGpuLegendEnable { get; set; }

		[ContainerField(107), LayoutImmutable, Blittable]
		public bool Enable { get; set; }

		public static void Deserialize(TimingViewSettings p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.MaxFrameEventCount = p_Reader.ReadUInt32();
			p_Instance.FrameCount = p_Reader.ReadUInt32();
			p_Instance.FrameDelayCount = p_Reader.ReadUInt32();
			p_Instance.TimeRange = p_Reader.ReadSingle();
			p_Instance.TimeOffset = p_Reader.ReadSingle();
			p_Instance.AutolockThreshold = p_Reader.ReadSingle();
			p_Instance.AutolockNameFilter = p_Parser.GetStringAtOffset(p_Reader.ReadUInt32());
			p_Instance.LegendScreenOffset = p_Reader.ReadInt32();
			p_Instance.LegendColumnWidth = p_Reader.ReadInt32();
			p_Instance.LegendDisplayMode = p_Reader.ReadInt32();
			p_Instance.AverageFrameCount = p_Reader.ReadInt32();
			p_Instance.MaxGpuLegendColumnCount = p_Reader.ReadInt32();
			p_Instance.SnoopEventName = p_Parser.GetStringAtOffset(p_Reader.ReadUInt32());
			p_Instance.GpuBarFrameOffset = p_Reader.ReadInt32();
			p_Instance.MaxCpuLegendColumnCount = p_Reader.ReadInt32();
			p_Instance.BarPad = p_Reader.ReadUInt32();
			p_Instance.MaxSpuLegendColumnCount = p_Reader.ReadInt32();
			p_Instance.BarSyncProcessor = p_Reader.ReadInt32();
			p_Instance.BarMinTime = p_Reader.ReadDouble();
			p_Instance.BarHeight = p_Reader.ReadUInt32();
			p_Instance.FilterEventName = p_Parser.GetStringAtOffset(p_Reader.ReadUInt32());
			p_Instance.SnoopOnly = p_Reader.ReadBool();
			p_Instance.DrawEnable = p_Reader.ReadBool();
			p_Instance.DrawSpuLegendEnable = p_Reader.ReadBool();
			p_Instance.SnoopEnable = p_Reader.ReadBool();
			p_Instance.FilterEnable = p_Reader.ReadBool();
			p_Instance.DrawBarsEnable = p_Reader.ReadBool();
			p_Instance.DrawLegendEnable = p_Reader.ReadBool();
			p_Instance.DrawOnlySummaryEnable = p_Reader.ReadBool();
			p_Instance.SortByTime = p_Reader.ReadBool();
			p_Instance.DrawCpuLegendEnable = p_Reader.ReadBool();
			p_Instance.DrawGpuLegendEnable = p_Reader.ReadBool();
			p_Instance.Enable = p_Reader.ReadBool();
			p_Reader.Seek(4, SeekOrigin.Current);
		}

	}
}
