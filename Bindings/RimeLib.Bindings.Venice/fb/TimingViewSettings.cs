///////////////////////////////////////////////////////////////
//                                                           //
// This is an automatically generated file.                  //
// Do *NOT* modify unless you really know what you're doing. //
//                                                           //
///////////////////////////////////////////////////////////////

using System.Reflection;using RimeLib.Serialization.Attributes;using RimeLib.Serialization.Ebx;using RimeLib.Serialization.Containers;using RimeLib.Frostbite.Core;

namespace fb
{
    [ContainerType(8)]
	public class TimingViewSettings : 
		DataContainer
	{
		[ContainerField(8), LayoutImmutable, Blittable]
		public uint MaxFrameEventCount { get; set; } // 0x8 (8)
		
		[ContainerField(12), LayoutImmutable, Blittable]
		public uint FrameCount { get; set; } // 0xC (12)
		
		[ContainerField(16), LayoutImmutable, Blittable]
		public uint FrameDelayCount { get; set; } // 0x10 (16)
		
		[ContainerField(20), LayoutImmutable, Blittable]
		public float TimeRange { get; set; } // 0x14 (20)
		
		[ContainerField(24), LayoutImmutable, Blittable]
		public float TimeOffset { get; set; } // 0x18 (24)
		
		[ContainerField(28), LayoutImmutable, Blittable]
		public float AutolockThreshold { get; set; } // 0x1C (28)
		
		[ContainerField(32), LayoutImmutable]
		public string AutolockNameFilter { get; set; } // 0x20 (32)
		
		[ContainerField(36), LayoutImmutable, Blittable]
		public int LegendScreenOffset { get; set; } // 0x24 (36)
		
		[ContainerField(40), LayoutImmutable, Blittable]
		public int LegendColumnWidth { get; set; } // 0x28 (40)
		
		[ContainerField(44), LayoutImmutable, Blittable]
		public int LegendDisplayMode { get; set; } // 0x2C (44)
		
		[ContainerField(48), LayoutImmutable, Blittable]
		public int AverageFrameCount { get; set; } // 0x30 (48)
		
		[ContainerField(52), LayoutImmutable, Blittable]
		public int MaxGpuLegendColumnCount { get; set; } // 0x34 (52)
		
		[ContainerField(56), LayoutImmutable]
		public string SnoopEventName { get; set; } // 0x38 (56)
		
		[ContainerField(60), LayoutImmutable, Blittable]
		public int GpuBarFrameOffset { get; set; } // 0x3C (60)
		
		[ContainerField(64), LayoutImmutable, Blittable]
		public int MaxCpuLegendColumnCount { get; set; } // 0x40 (64)
		
		[ContainerField(68), LayoutImmutable, Blittable]
		public uint BarPad { get; set; } // 0x44 (68)
		
		[ContainerField(72), LayoutImmutable, Blittable]
		public int MaxSpuLegendColumnCount { get; set; } // 0x48 (72)
		
		[ContainerField(76), LayoutImmutable, Blittable]
		public int BarSyncProcessor { get; set; } // 0x4C (76)
		
		[ContainerField(80), LayoutImmutable, Blittable]
		public double BarMinTime { get; set; } // 0x50 (80)
		
		[ContainerField(88), LayoutImmutable, Blittable]
		public uint BarHeight { get; set; } // 0x58 (88)
		
		[ContainerField(92), LayoutImmutable]
		public string FilterEventName { get; set; } // 0x5C (92)
		
		[ContainerField(96), LayoutImmutable, Blittable]
		public bool SnoopOnly { get; set; } // 0x60 (96)
		
		[ContainerField(97), LayoutImmutable, Blittable]
		public bool DrawEnable { get; set; } // 0x61 (97)
		
		[ContainerField(98), LayoutImmutable, Blittable]
		public bool DrawSpuLegendEnable { get; set; } // 0x62 (98)
		
		[ContainerField(99), LayoutImmutable, Blittable]
		public bool SnoopEnable { get; set; } // 0x63 (99)
		
		[ContainerField(100), LayoutImmutable, Blittable]
		public bool FilterEnable { get; set; } // 0x64 (100)
		
		[ContainerField(101), LayoutImmutable, Blittable]
		public bool DrawBarsEnable { get; set; } // 0x65 (101)
		
		[ContainerField(102), LayoutImmutable, Blittable]
		public bool DrawLegendEnable { get; set; } // 0x66 (102)
		
		[ContainerField(103), LayoutImmutable, Blittable]
		public bool DrawOnlySummaryEnable { get; set; } // 0x67 (103)
		
		[ContainerField(104), LayoutImmutable, Blittable]
		public bool SortByTime { get; set; } // 0x68 (104)
		
		[ContainerField(105), LayoutImmutable, Blittable]
		public bool DrawCpuLegendEnable { get; set; } // 0x69 (105)
		
		[ContainerField(106), LayoutImmutable, Blittable]
		public bool DrawGpuLegendEnable { get; set; } // 0x6A (106)
		
		[ContainerField(107), LayoutImmutable, Blittable]
		public bool Enable { get; set; } // 0x6B (107)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 3847876579:
					MaxFrameEventCount = (uint) p_Value;
					break;

				case 741182715:
					FrameCount = (uint) p_Value;
					break;

				case 4056595598:
					FrameDelayCount = (uint) p_Value;
					break;

				case 170778575:
					TimeRange = (float) p_Value;
					break;

				case 2388918461:
					TimeOffset = (float) p_Value;
					break;

				case 2834654070:
					AutolockThreshold = (float) p_Value;
					break;

				case 700307558:
					AutolockNameFilter = (string) p_Value;
					break;

				case 2099355397:
					LegendScreenOffset = (int) p_Value;
					break;

				case 4015483860:
					LegendColumnWidth = (int) p_Value;
					break;

				case 3524433245:
					LegendDisplayMode = (int) p_Value;
					break;

				case 4155437432:
					AverageFrameCount = (int) p_Value;
					break;

				case 1835173031:
					MaxGpuLegendColumnCount = (int) p_Value;
					break;

				case 570566851:
					SnoopEventName = (string) p_Value;
					break;

				case 3381491878:
					GpuBarFrameOffset = (int) p_Value;
					break;

				case 3144102947:
					MaxCpuLegendColumnCount = (int) p_Value;
					break;

				case 2672961185:
					BarPad = (uint) p_Value;
					break;

				case 3652642355:
					MaxSpuLegendColumnCount = (int) p_Value;
					break;

				case 2518052805:
					BarSyncProcessor = (int) p_Value;
					break;

				case 1638553323:
					BarMinTime = (double) p_Value;
					break;

				case 2196900171:
					BarHeight = (uint) p_Value;
					break;

				case 1452602030:
					FilterEventName = (string) p_Value;
					break;

				case 477460828:
					SnoopOnly = (bool) p_Value;
					break;

				case 1347356004:
					DrawEnable = (bool) p_Value;
					break;

				case 3543221203:
					DrawSpuLegendEnable = (bool) p_Value;
					break;

				case 332594601:
					SnoopEnable = (bool) p_Value;
					break;

				case 3231420132:
					FilterEnable = (bool) p_Value;
					break;

				case 3694545030:
					DrawBarsEnable = (bool) p_Value;
					break;

				case 1644114661:
					DrawLegendEnable = (bool) p_Value;
					break;

				case 720557660:
					DrawOnlySummaryEnable = (bool) p_Value;
					break;

				case 1839336369:
					SortByTime = (bool) p_Value;
					break;

				case 450915267:
					DrawCpuLegendEnable = (bool) p_Value;
					break;

				case 591363015:
					DrawGpuLegendEnable = (bool) p_Value;
					break;

				case 2342790116:
					Enable = (bool) p_Value;
					break;

				default:
					base.Bind(p_Descriptor, p_Value);
					break;
			}
		}

		public override object GetFieldValueByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 3847876579:
					return MaxFrameEventCount;

				case 741182715:
					return FrameCount;

				case 4056595598:
					return FrameDelayCount;

				case 170778575:
					return TimeRange;

				case 2388918461:
					return TimeOffset;

				case 2834654070:
					return AutolockThreshold;

				case 700307558:
					return AutolockNameFilter;

				case 2099355397:
					return LegendScreenOffset;

				case 4015483860:
					return LegendColumnWidth;

				case 3524433245:
					return LegendDisplayMode;

				case 4155437432:
					return AverageFrameCount;

				case 1835173031:
					return MaxGpuLegendColumnCount;

				case 570566851:
					return SnoopEventName;

				case 3381491878:
					return GpuBarFrameOffset;

				case 3144102947:
					return MaxCpuLegendColumnCount;

				case 2672961185:
					return BarPad;

				case 3652642355:
					return MaxSpuLegendColumnCount;

				case 2518052805:
					return BarSyncProcessor;

				case 1638553323:
					return BarMinTime;

				case 2196900171:
					return BarHeight;

				case 1452602030:
					return FilterEventName;

				case 477460828:
					return SnoopOnly;

				case 1347356004:
					return DrawEnable;

				case 3543221203:
					return DrawSpuLegendEnable;

				case 332594601:
					return SnoopEnable;

				case 3231420132:
					return FilterEnable;

				case 3694545030:
					return DrawBarsEnable;

				case 1644114661:
					return DrawLegendEnable;

				case 720557660:
					return DrawOnlySummaryEnable;

				case 1839336369:
					return SortByTime;

				case 450915267:
					return DrawCpuLegendEnable;

				case 591363015:
					return DrawGpuLegendEnable;

				case 2342790116:
					return Enable;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 3847876579:
					return typeof(TimingViewSettings).GetProperty(nameof(MaxFrameEventCount));

				case 741182715:
					return typeof(TimingViewSettings).GetProperty(nameof(FrameCount));

				case 4056595598:
					return typeof(TimingViewSettings).GetProperty(nameof(FrameDelayCount));

				case 170778575:
					return typeof(TimingViewSettings).GetProperty(nameof(TimeRange));

				case 2388918461:
					return typeof(TimingViewSettings).GetProperty(nameof(TimeOffset));

				case 2834654070:
					return typeof(TimingViewSettings).GetProperty(nameof(AutolockThreshold));

				case 700307558:
					return typeof(TimingViewSettings).GetProperty(nameof(AutolockNameFilter));

				case 2099355397:
					return typeof(TimingViewSettings).GetProperty(nameof(LegendScreenOffset));

				case 4015483860:
					return typeof(TimingViewSettings).GetProperty(nameof(LegendColumnWidth));

				case 3524433245:
					return typeof(TimingViewSettings).GetProperty(nameof(LegendDisplayMode));

				case 4155437432:
					return typeof(TimingViewSettings).GetProperty(nameof(AverageFrameCount));

				case 1835173031:
					return typeof(TimingViewSettings).GetProperty(nameof(MaxGpuLegendColumnCount));

				case 570566851:
					return typeof(TimingViewSettings).GetProperty(nameof(SnoopEventName));

				case 3381491878:
					return typeof(TimingViewSettings).GetProperty(nameof(GpuBarFrameOffset));

				case 3144102947:
					return typeof(TimingViewSettings).GetProperty(nameof(MaxCpuLegendColumnCount));

				case 2672961185:
					return typeof(TimingViewSettings).GetProperty(nameof(BarPad));

				case 3652642355:
					return typeof(TimingViewSettings).GetProperty(nameof(MaxSpuLegendColumnCount));

				case 2518052805:
					return typeof(TimingViewSettings).GetProperty(nameof(BarSyncProcessor));

				case 1638553323:
					return typeof(TimingViewSettings).GetProperty(nameof(BarMinTime));

				case 2196900171:
					return typeof(TimingViewSettings).GetProperty(nameof(BarHeight));

				case 1452602030:
					return typeof(TimingViewSettings).GetProperty(nameof(FilterEventName));

				case 477460828:
					return typeof(TimingViewSettings).GetProperty(nameof(SnoopOnly));

				case 1347356004:
					return typeof(TimingViewSettings).GetProperty(nameof(DrawEnable));

				case 3543221203:
					return typeof(TimingViewSettings).GetProperty(nameof(DrawSpuLegendEnable));

				case 332594601:
					return typeof(TimingViewSettings).GetProperty(nameof(SnoopEnable));

				case 3231420132:
					return typeof(TimingViewSettings).GetProperty(nameof(FilterEnable));

				case 3694545030:
					return typeof(TimingViewSettings).GetProperty(nameof(DrawBarsEnable));

				case 1644114661:
					return typeof(TimingViewSettings).GetProperty(nameof(DrawLegendEnable));

				case 720557660:
					return typeof(TimingViewSettings).GetProperty(nameof(DrawOnlySummaryEnable));

				case 1839336369:
					return typeof(TimingViewSettings).GetProperty(nameof(SortByTime));

				case 450915267:
					return typeof(TimingViewSettings).GetProperty(nameof(DrawCpuLegendEnable));

				case 591363015:
					return typeof(TimingViewSettings).GetProperty(nameof(DrawGpuLegendEnable));

				case 2342790116:
					return typeof(TimingViewSettings).GetProperty(nameof(Enable));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
