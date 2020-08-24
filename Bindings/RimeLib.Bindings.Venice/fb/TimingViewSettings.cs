///////////////////////////////////////////////////////////////
//                                                           //
// This is an automatically generated file.                  //
// Do *NOT* modify unless you really know what you're doing. //
//                                                           //
///////////////////////////////////////////////////////////////

using RimeLib.IO;
using RimeLib.Frostbite.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel;
using System.Reflection;
using RimeLib.Serialization.Attributes;
using RimeLib.Serialization.Containers;
using RimeLib.Serialization.Ebx;

namespace fb
{
	[ContainerType(8), MemberInfoFlag(53), ContainerClass]
	public class TimingViewSettings : 
		DataContainer
	{
		protected uint m_MaxFrameEventCount = new uint();
		[ContainerField(8), LayoutImmutable, Blittable, MemberInfoFlag(49421), ContainerFieldNameHash(3847876579)]
		public uint MaxFrameEventCount { get { return m_MaxFrameEventCount; } set { if (OnPropertyChanging("TimingViewSettings." + nameof(MaxFrameEventCount), this, m_MaxFrameEventCount, value)) m_MaxFrameEventCount = value; } } // 0x8 (8)
		
		protected uint m_FrameCount = new uint();
		[ContainerField(12), LayoutImmutable, Blittable, MemberInfoFlag(49421), ContainerFieldNameHash(741182715)]
		public uint FrameCount { get { return m_FrameCount; } set { if (OnPropertyChanging("TimingViewSettings." + nameof(FrameCount), this, m_FrameCount, value)) m_FrameCount = value; } } // 0xC (12)
		
		protected uint m_FrameDelayCount = new uint();
		[ContainerField(16), LayoutImmutable, Blittable, MemberInfoFlag(49421), ContainerFieldNameHash(4056595598)]
		public uint FrameDelayCount { get { return m_FrameDelayCount; } set { if (OnPropertyChanging("TimingViewSettings." + nameof(FrameDelayCount), this, m_FrameDelayCount, value)) m_FrameDelayCount = value; } } // 0x10 (16)
		
		protected float m_TimeRange = new float();
		[ContainerField(20), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(170778575)]
		public float TimeRange { get { return m_TimeRange; } set { if (OnPropertyChanging("TimingViewSettings." + nameof(TimeRange), this, m_TimeRange, value)) m_TimeRange = value; } } // 0x14 (20)
		
		protected float m_TimeOffset = new float();
		[ContainerField(24), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(2388918461)]
		public float TimeOffset { get { return m_TimeOffset; } set { if (OnPropertyChanging("TimingViewSettings." + nameof(TimeOffset), this, m_TimeOffset, value)) m_TimeOffset = value; } } // 0x18 (24)
		
		protected float m_AutolockThreshold = new float();
		[ContainerField(28), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(2834654070)]
		public float AutolockThreshold { get { return m_AutolockThreshold; } set { if (OnPropertyChanging("TimingViewSettings." + nameof(AutolockThreshold), this, m_AutolockThreshold, value)) m_AutolockThreshold = value; } } // 0x1C (28)
		
		protected string m_AutolockNameFilter = string.Empty;
		[ContainerField(32), LayoutImmutable, MemberInfoFlag(16509), ContainerFieldNameHash(700307558)]
		public string AutolockNameFilter { get { return m_AutolockNameFilter; } set { if (OnPropertyChanging("TimingViewSettings." + nameof(AutolockNameFilter), this, m_AutolockNameFilter, value)) m_AutolockNameFilter = value; } } // 0x20 (32)
		
		protected int m_LegendScreenOffset = new int();
		[ContainerField(36), LayoutImmutable, Blittable, MemberInfoFlag(49405), ContainerFieldNameHash(2099355397)]
		public int LegendScreenOffset { get { return m_LegendScreenOffset; } set { if (OnPropertyChanging("TimingViewSettings." + nameof(LegendScreenOffset), this, m_LegendScreenOffset, value)) m_LegendScreenOffset = value; } } // 0x24 (36)
		
		protected int m_LegendColumnWidth = new int();
		[ContainerField(40), LayoutImmutable, Blittable, MemberInfoFlag(49405), ContainerFieldNameHash(4015483860)]
		public int LegendColumnWidth { get { return m_LegendColumnWidth; } set { if (OnPropertyChanging("TimingViewSettings." + nameof(LegendColumnWidth), this, m_LegendColumnWidth, value)) m_LegendColumnWidth = value; } } // 0x28 (40)
		
		protected int m_LegendDisplayMode = new int();
		[ContainerField(44), LayoutImmutable, Blittable, MemberInfoFlag(49405), ContainerFieldNameHash(3524433245)]
		public int LegendDisplayMode { get { return m_LegendDisplayMode; } set { if (OnPropertyChanging("TimingViewSettings." + nameof(LegendDisplayMode), this, m_LegendDisplayMode, value)) m_LegendDisplayMode = value; } } // 0x2C (44)
		
		protected int m_AverageFrameCount = new int();
		[ContainerField(48), LayoutImmutable, Blittable, MemberInfoFlag(49405), ContainerFieldNameHash(4155437432)]
		public int AverageFrameCount { get { return m_AverageFrameCount; } set { if (OnPropertyChanging("TimingViewSettings." + nameof(AverageFrameCount), this, m_AverageFrameCount, value)) m_AverageFrameCount = value; } } // 0x30 (48)
		
		protected int m_MaxGpuLegendColumnCount = new int();
		[ContainerField(52), LayoutImmutable, Blittable, MemberInfoFlag(49405), ContainerFieldNameHash(1835173031)]
		public int MaxGpuLegendColumnCount { get { return m_MaxGpuLegendColumnCount; } set { if (OnPropertyChanging("TimingViewSettings." + nameof(MaxGpuLegendColumnCount), this, m_MaxGpuLegendColumnCount, value)) m_MaxGpuLegendColumnCount = value; } } // 0x34 (52)
		
		protected string m_SnoopEventName = string.Empty;
		[ContainerField(56), LayoutImmutable, MemberInfoFlag(16509), ContainerFieldNameHash(570566851)]
		public string SnoopEventName { get { return m_SnoopEventName; } set { if (OnPropertyChanging("TimingViewSettings." + nameof(SnoopEventName), this, m_SnoopEventName, value)) m_SnoopEventName = value; } } // 0x38 (56)
		
		protected int m_GpuBarFrameOffset = new int();
		[ContainerField(60), LayoutImmutable, Blittable, MemberInfoFlag(49405), ContainerFieldNameHash(3381491878)]
		public int GpuBarFrameOffset { get { return m_GpuBarFrameOffset; } set { if (OnPropertyChanging("TimingViewSettings." + nameof(GpuBarFrameOffset), this, m_GpuBarFrameOffset, value)) m_GpuBarFrameOffset = value; } } // 0x3C (60)
		
		protected int m_MaxCpuLegendColumnCount = new int();
		[ContainerField(64), LayoutImmutable, Blittable, MemberInfoFlag(49405), ContainerFieldNameHash(3144102947)]
		public int MaxCpuLegendColumnCount { get { return m_MaxCpuLegendColumnCount; } set { if (OnPropertyChanging("TimingViewSettings." + nameof(MaxCpuLegendColumnCount), this, m_MaxCpuLegendColumnCount, value)) m_MaxCpuLegendColumnCount = value; } } // 0x40 (64)
		
		protected uint m_BarPad = new uint();
		[ContainerField(68), LayoutImmutable, Blittable, MemberInfoFlag(49421), ContainerFieldNameHash(2672961185)]
		public uint BarPad { get { return m_BarPad; } set { if (OnPropertyChanging("TimingViewSettings." + nameof(BarPad), this, m_BarPad, value)) m_BarPad = value; } } // 0x44 (68)
		
		protected int m_MaxSpuLegendColumnCount = new int();
		[ContainerField(72), LayoutImmutable, Blittable, MemberInfoFlag(49405), ContainerFieldNameHash(3652642355)]
		public int MaxSpuLegendColumnCount { get { return m_MaxSpuLegendColumnCount; } set { if (OnPropertyChanging("TimingViewSettings." + nameof(MaxSpuLegendColumnCount), this, m_MaxSpuLegendColumnCount, value)) m_MaxSpuLegendColumnCount = value; } } // 0x48 (72)
		
		protected int m_BarSyncProcessor = new int();
		[ContainerField(76), LayoutImmutable, Blittable, MemberInfoFlag(49405), ContainerFieldNameHash(2518052805)]
		public int BarSyncProcessor { get { return m_BarSyncProcessor; } set { if (OnPropertyChanging("TimingViewSettings." + nameof(BarSyncProcessor), this, m_BarSyncProcessor, value)) m_BarSyncProcessor = value; } } // 0x4C (76)
		
		protected double m_BarMinTime = new double();
		[ContainerField(80), LayoutImmutable, Blittable, MemberInfoFlag(49485), ContainerFieldNameHash(1638553323)]
		public double BarMinTime { get { return m_BarMinTime; } set { if (OnPropertyChanging("TimingViewSettings." + nameof(BarMinTime), this, m_BarMinTime, value)) m_BarMinTime = value; } } // 0x50 (80)
		
		protected uint m_BarHeight = new uint();
		[ContainerField(88), LayoutImmutable, Blittable, MemberInfoFlag(49421), ContainerFieldNameHash(2196900171)]
		public uint BarHeight { get { return m_BarHeight; } set { if (OnPropertyChanging("TimingViewSettings." + nameof(BarHeight), this, m_BarHeight, value)) m_BarHeight = value; } } // 0x58 (88)
		
		protected string m_FilterEventName = string.Empty;
		[ContainerField(92), LayoutImmutable, MemberInfoFlag(16509), ContainerFieldNameHash(1452602030)]
		public string FilterEventName { get { return m_FilterEventName; } set { if (OnPropertyChanging("TimingViewSettings." + nameof(FilterEventName), this, m_FilterEventName, value)) m_FilterEventName = value; } } // 0x5C (92)
		
		protected bool m_SnoopOnly = new bool();
		[ContainerField(96), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(477460828)]
		public bool SnoopOnly { get { return m_SnoopOnly; } set { if (OnPropertyChanging("TimingViewSettings." + nameof(SnoopOnly), this, m_SnoopOnly, value)) m_SnoopOnly = value; } } // 0x60 (96)
		
		protected bool m_DrawEnable = new bool();
		[ContainerField(97), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(1347356004)]
		public bool DrawEnable { get { return m_DrawEnable; } set { if (OnPropertyChanging("TimingViewSettings." + nameof(DrawEnable), this, m_DrawEnable, value)) m_DrawEnable = value; } } // 0x61 (97)
		
		protected bool m_DrawSpuLegendEnable = new bool();
		[ContainerField(98), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(3543221203)]
		public bool DrawSpuLegendEnable { get { return m_DrawSpuLegendEnable; } set { if (OnPropertyChanging("TimingViewSettings." + nameof(DrawSpuLegendEnable), this, m_DrawSpuLegendEnable, value)) m_DrawSpuLegendEnable = value; } } // 0x62 (98)
		
		protected bool m_SnoopEnable = new bool();
		[ContainerField(99), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(332594601)]
		public bool SnoopEnable { get { return m_SnoopEnable; } set { if (OnPropertyChanging("TimingViewSettings." + nameof(SnoopEnable), this, m_SnoopEnable, value)) m_SnoopEnable = value; } } // 0x63 (99)
		
		protected bool m_FilterEnable = new bool();
		[ContainerField(100), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(3231420132)]
		public bool FilterEnable { get { return m_FilterEnable; } set { if (OnPropertyChanging("TimingViewSettings." + nameof(FilterEnable), this, m_FilterEnable, value)) m_FilterEnable = value; } } // 0x64 (100)
		
		protected bool m_DrawBarsEnable = new bool();
		[ContainerField(101), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(3694545030)]
		public bool DrawBarsEnable { get { return m_DrawBarsEnable; } set { if (OnPropertyChanging("TimingViewSettings." + nameof(DrawBarsEnable), this, m_DrawBarsEnable, value)) m_DrawBarsEnable = value; } } // 0x65 (101)
		
		protected bool m_DrawLegendEnable = new bool();
		[ContainerField(102), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(1644114661)]
		public bool DrawLegendEnable { get { return m_DrawLegendEnable; } set { if (OnPropertyChanging("TimingViewSettings." + nameof(DrawLegendEnable), this, m_DrawLegendEnable, value)) m_DrawLegendEnable = value; } } // 0x66 (102)
		
		protected bool m_DrawOnlySummaryEnable = new bool();
		[ContainerField(103), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(720557660)]
		public bool DrawOnlySummaryEnable { get { return m_DrawOnlySummaryEnable; } set { if (OnPropertyChanging("TimingViewSettings." + nameof(DrawOnlySummaryEnable), this, m_DrawOnlySummaryEnable, value)) m_DrawOnlySummaryEnable = value; } } // 0x67 (103)
		
		protected bool m_SortByTime = new bool();
		[ContainerField(104), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(1839336369)]
		public bool SortByTime { get { return m_SortByTime; } set { if (OnPropertyChanging("TimingViewSettings." + nameof(SortByTime), this, m_SortByTime, value)) m_SortByTime = value; } } // 0x68 (104)
		
		protected bool m_DrawCpuLegendEnable = new bool();
		[ContainerField(105), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(450915267)]
		public bool DrawCpuLegendEnable { get { return m_DrawCpuLegendEnable; } set { if (OnPropertyChanging("TimingViewSettings." + nameof(DrawCpuLegendEnable), this, m_DrawCpuLegendEnable, value)) m_DrawCpuLegendEnable = value; } } // 0x69 (105)
		
		protected bool m_DrawGpuLegendEnable = new bool();
		[ContainerField(106), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(591363015)]
		public bool DrawGpuLegendEnable { get { return m_DrawGpuLegendEnable; } set { if (OnPropertyChanging("TimingViewSettings." + nameof(DrawGpuLegendEnable), this, m_DrawGpuLegendEnable, value)) m_DrawGpuLegendEnable = value; } } // 0x6A (106)
		
		protected bool m_Enable = new bool();
		[ContainerField(107), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(2342790116)]
		public bool Enable { get { return m_Enable; } set { if (OnPropertyChanging("TimingViewSettings." + nameof(Enable), this, m_Enable, value)) m_Enable = value; } } // 0x6B (107)
		
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
