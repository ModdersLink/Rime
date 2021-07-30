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
	[ContainerType(Alignment: 4,  Flags: 53, Size: 88)]
	public class DxDisplaySettings : 
		SystemSettings
	{
		protected uint m_FullscreenWidth = new uint();
		[ContainerField(Name: "FullscreenWidth", Offset: 12, NameHash: 1430980188, Flags: 49421), LayoutImmutable, Blittable]
		public uint FullscreenWidth { get { return m_FullscreenWidth; } set { if (OnPropertyChanging("DxDisplaySettings." + nameof(FullscreenWidth), this, m_FullscreenWidth, value)) m_FullscreenWidth = value; } } // 0xC (12)
		
		protected uint m_FullscreenHeight = new uint();
		[ContainerField(Name: "FullscreenHeight", Offset: 16, NameHash: 109852325, Flags: 49421), LayoutImmutable, Blittable]
		public uint FullscreenHeight { get { return m_FullscreenHeight; } set { if (OnPropertyChanging("DxDisplaySettings." + nameof(FullscreenHeight), this, m_FullscreenHeight, value)) m_FullscreenHeight = value; } } // 0x10 (16)
		
		protected string m_AmdMinDriverVersion = string.Empty;
		[ContainerField(Name: "AmdMinDriverVersion", Offset: 20, NameHash: 2479381411, Flags: 16509), LayoutImmutable]
		public string AmdMinDriverVersion { get { return m_AmdMinDriverVersion; } set { if (OnPropertyChanging("DxDisplaySettings." + nameof(AmdMinDriverVersion), this, m_AmdMinDriverVersion, value)) m_AmdMinDriverVersion = value; } } // 0x14 (20)
		
		protected uint m_NvidiaMinDriverVersion = new uint();
		[ContainerField(Name: "NvidiaMinDriverVersion", Offset: 24, NameHash: 3704079510, Flags: 49421), LayoutImmutable, Blittable]
		public uint NvidiaMinDriverVersion { get { return m_NvidiaMinDriverVersion; } set { if (OnPropertyChanging("DxDisplaySettings." + nameof(NvidiaMinDriverVersion), this, m_NvidiaMinDriverVersion, value)) m_NvidiaMinDriverVersion = value; } } // 0x18 (24)
		
		protected float m_FullscreenRefreshRate = new float();
		[ContainerField(Name: "FullscreenRefreshRate", Offset: 28, NameHash: 911237061, Flags: 49469), LayoutImmutable, Blittable]
		public float FullscreenRefreshRate { get { return m_FullscreenRefreshRate; } set { if (OnPropertyChanging("DxDisplaySettings." + nameof(FullscreenRefreshRate), this, m_FullscreenRefreshRate, value)) m_FullscreenRefreshRate = value; } } // 0x1C (28)
		
		protected float m_StereoSeparationScale = new float();
		[ContainerField(Name: "StereoSeparationScale", Offset: 32, NameHash: 2101591727, Flags: 49469), LayoutImmutable, Blittable]
		public float StereoSeparationScale { get { return m_StereoSeparationScale; } set { if (OnPropertyChanging("DxDisplaySettings." + nameof(StereoSeparationScale), this, m_StereoSeparationScale, value)) m_StereoSeparationScale = value; } } // 0x20 (32)
		
		protected float m_StereoDepth = new float();
		[ContainerField(Name: "StereoDepth", Offset: 36, NameHash: 4166595090, Flags: 49469), LayoutImmutable, Blittable]
		public float StereoDepth { get { return m_StereoDepth; } set { if (OnPropertyChanging("DxDisplaySettings." + nameof(StereoDepth), this, m_StereoDepth, value)) m_StereoDepth = value; } } // 0x24 (36)
		
		protected int m_FullscreenOutputIndex = new int();
		[ContainerField(Name: "FullscreenOutputIndex", Offset: 40, NameHash: 2675250075, Flags: 49405), LayoutImmutable, Blittable]
		public int FullscreenOutputIndex { get { return m_FullscreenOutputIndex; } set { if (OnPropertyChanging("DxDisplaySettings." + nameof(FullscreenOutputIndex), this, m_FullscreenOutputIndex, value)) m_FullscreenOutputIndex = value; } } // 0x28 (40)
		
		protected List<int> m_DebugBreakIgnoredIDs = new List<int>();
		[ContainerField(Name: "DebugBreakIgnoredIDs", Offset: 44, NameHash: 4052915337, Flags: 65)]
		public List<int> DebugBreakIgnoredIDs { get { return m_DebugBreakIgnoredIDs; } set { if (OnPropertyChanging("DxDisplaySettings." + nameof(DebugBreakIgnoredIDs), this, m_DebugBreakIgnoredIDs, value)) m_DebugBreakIgnoredIDs = value; } } // 0x2C (44)
		
		protected float m_StereoConvergenceScale = new float();
		[ContainerField(Name: "StereoConvergenceScale", Offset: 48, NameHash: 4196419630, Flags: 49469), LayoutImmutable, Blittable]
		public float StereoConvergenceScale { get { return m_StereoConvergenceScale; } set { if (OnPropertyChanging("DxDisplaySettings." + nameof(StereoConvergenceScale), this, m_StereoConvergenceScale, value)) m_StereoConvergenceScale = value; } } // 0x30 (48)
		
		protected float m_StereoSoldierZoomConvergenceScale = new float();
		[ContainerField(Name: "StereoSoldierZoomConvergenceScale", Offset: 52, NameHash: 522462419, Flags: 49469), LayoutImmutable, Blittable]
		public float StereoSoldierZoomConvergenceScale { get { return m_StereoSoldierZoomConvergenceScale; } set { if (OnPropertyChanging("DxDisplaySettings." + nameof(StereoSoldierZoomConvergenceScale), this, m_StereoSoldierZoomConvergenceScale, value)) m_StereoSoldierZoomConvergenceScale = value; } } // 0x34 (52)
		
		protected int m_ForceRenderAheadLimit = new int();
		[ContainerField(Name: "ForceRenderAheadLimit", Offset: 56, NameHash: 1880889646, Flags: 49405), LayoutImmutable, Blittable]
		public int ForceRenderAheadLimit { get { return m_ForceRenderAheadLimit; } set { if (OnPropertyChanging("DxDisplaySettings." + nameof(ForceRenderAheadLimit), this, m_ForceRenderAheadLimit, value)) m_ForceRenderAheadLimit = value; } } // 0x38 (56)
		
		protected int m_PresentInterval = new int();
		[ContainerField(Name: "PresentInterval", Offset: 60, NameHash: 4204358449, Flags: 49405), LayoutImmutable, Blittable]
		public int PresentInterval { get { return m_PresentInterval; } set { if (OnPropertyChanging("DxDisplaySettings." + nameof(PresentInterval), this, m_PresentInterval, value)) m_PresentInterval = value; } } // 0x3C (60)
		
		protected bool m_DebugBreakOnWarningEnable = new bool();
		[ContainerField(Name: "DebugBreakOnWarningEnable", Offset: 64, NameHash: 2632000193, Flags: 49325), LayoutImmutable, Blittable]
		public bool DebugBreakOnWarningEnable { get { return m_DebugBreakOnWarningEnable; } set { if (OnPropertyChanging("DxDisplaySettings." + nameof(DebugBreakOnWarningEnable), this, m_DebugBreakOnWarningEnable, value)) m_DebugBreakOnWarningEnable = value; } } // 0x40 (64)
		
		protected bool m_DebugInfoEnable = new bool();
		[ContainerField(Name: "DebugInfoEnable", Offset: 65, NameHash: 4223944539, Flags: 49325), LayoutImmutable, Blittable]
		public bool DebugInfoEnable { get { return m_DebugInfoEnable; } set { if (OnPropertyChanging("DxDisplaySettings." + nameof(DebugInfoEnable), this, m_DebugInfoEnable, value)) m_DebugInfoEnable = value; } } // 0x41 (65)
		
		protected bool m_Fullscreen = new bool();
		[ContainerField(Name: "Fullscreen", Offset: 66, NameHash: 2248877754, Flags: 49325), LayoutImmutable, Blittable]
		public bool Fullscreen { get { return m_Fullscreen; } set { if (OnPropertyChanging("DxDisplaySettings." + nameof(Fullscreen), this, m_Fullscreen, value)) m_Fullscreen = value; } } // 0x42 (66)
		
		protected bool m_DebugBreakOnErrorEnable = new bool();
		[ContainerField(Name: "DebugBreakOnErrorEnable", Offset: 67, NameHash: 814125011, Flags: 49325), LayoutImmutable, Blittable]
		public bool DebugBreakOnErrorEnable { get { return m_DebugBreakOnErrorEnable; } set { if (OnPropertyChanging("DxDisplaySettings." + nameof(DebugBreakOnErrorEnable), this, m_DebugBreakOnErrorEnable, value)) m_DebugBreakOnErrorEnable = value; } } // 0x43 (67)
		
		protected bool m_CreateMinimalWindow = new bool();
		[ContainerField(Name: "CreateMinimalWindow", Offset: 68, NameHash: 140168974, Flags: 49325), LayoutImmutable, Blittable]
		public bool CreateMinimalWindow { get { return m_CreateMinimalWindow; } set { if (OnPropertyChanging("DxDisplaySettings." + nameof(CreateMinimalWindow), this, m_CreateMinimalWindow, value)) m_CreateMinimalWindow = value; } } // 0x44 (68)
		
		protected bool m_DriverInternalThreadingEnable = new bool();
		[ContainerField(Name: "DriverInternalThreadingEnable", Offset: 69, NameHash: 3689386451, Flags: 49325), LayoutImmutable, Blittable]
		public bool DriverInternalThreadingEnable { get { return m_DriverInternalThreadingEnable; } set { if (OnPropertyChanging("DxDisplaySettings." + nameof(DriverInternalThreadingEnable), this, m_DriverInternalThreadingEnable, value)) m_DriverInternalThreadingEnable = value; } } // 0x45 (69)
		
		protected bool m_DebugBreakOnInfoEnable = new bool();
		[ContainerField(Name: "DebugBreakOnInfoEnable", Offset: 70, NameHash: 4085063333, Flags: 49325), LayoutImmutable, Blittable]
		public bool DebugBreakOnInfoEnable { get { return m_DebugBreakOnInfoEnable; } set { if (OnPropertyChanging("DxDisplaySettings." + nameof(DebugBreakOnInfoEnable), this, m_DebugBreakOnInfoEnable, value)) m_DebugBreakOnInfoEnable = value; } } // 0x46 (70)
		
		protected bool m_FullscreenModeEnable = new bool();
		[ContainerField(Name: "FullscreenModeEnable", Offset: 71, NameHash: 885827480, Flags: 49325), LayoutImmutable, Blittable]
		public bool FullscreenModeEnable { get { return m_FullscreenModeEnable; } set { if (OnPropertyChanging("DxDisplaySettings." + nameof(FullscreenModeEnable), this, m_FullscreenModeEnable, value)) m_FullscreenModeEnable = value; } } // 0x47 (71)
		
		protected bool m_VSyncEnable = new bool();
		[ContainerField(Name: "VSyncEnable", Offset: 72, NameHash: 486588565, Flags: 49325), LayoutImmutable, Blittable]
		public bool VSyncEnable { get { return m_VSyncEnable; } set { if (OnPropertyChanging("DxDisplaySettings." + nameof(VSyncEnable), this, m_VSyncEnable, value)) m_VSyncEnable = value; } } // 0x48 (72)
		
		protected bool m_TripleBufferingEnable = new bool();
		[ContainerField(Name: "TripleBufferingEnable", Offset: 73, NameHash: 2513610482, Flags: 49325), LayoutImmutable, Blittable]
		public bool TripleBufferingEnable { get { return m_TripleBufferingEnable; } set { if (OnPropertyChanging("DxDisplaySettings." + nameof(TripleBufferingEnable), this, m_TripleBufferingEnable, value)) m_TripleBufferingEnable = value; } } // 0x49 (73)
		
		protected bool m_Dx10PlusEnable = new bool();
		[ContainerField(Name: "Dx10PlusEnable", Offset: 74, NameHash: 2748289315, Flags: 49325), LayoutImmutable, Blittable]
		public bool Dx10PlusEnable { get { return m_Dx10PlusEnable; } set { if (OnPropertyChanging("DxDisplaySettings." + nameof(Dx10PlusEnable), this, m_Dx10PlusEnable, value)) m_Dx10PlusEnable = value; } } // 0x4A (74)
		
		protected bool m_NvApiEnable = new bool();
		[ContainerField(Name: "NvApiEnable", Offset: 75, NameHash: 4131383908, Flags: 49325), LayoutImmutable, Blittable]
		public bool NvApiEnable { get { return m_NvApiEnable; } set { if (OnPropertyChanging("DxDisplaySettings." + nameof(NvApiEnable), this, m_NvApiEnable, value)) m_NvApiEnable = value; } } // 0x4B (75)
		
		protected bool m_NvPerfHudEnable = new bool();
		[ContainerField(Name: "NvPerfHudEnable", Offset: 76, NameHash: 4224746564, Flags: 49325), LayoutImmutable, Blittable]
		public bool NvPerfHudEnable { get { return m_NvPerfHudEnable; } set { if (OnPropertyChanging("DxDisplaySettings." + nameof(NvPerfHudEnable), this, m_NvPerfHudEnable, value)) m_NvPerfHudEnable = value; } } // 0x4C (76)
		
		protected bool m_StereoEnable = new bool();
		[ContainerField(Name: "StereoEnable", Offset: 77, NameHash: 87681470, Flags: 49325), LayoutImmutable, Blittable]
		public bool StereoEnable { get { return m_StereoEnable; } set { if (OnPropertyChanging("DxDisplaySettings." + nameof(StereoEnable), this, m_StereoEnable, value)) m_StereoEnable = value; } } // 0x4D (77)
		
		protected bool m_Dx11Enable = new bool();
		[ContainerField(Name: "Dx11Enable", Offset: 78, NameHash: 2892685432, Flags: 49325), LayoutImmutable, Blittable]
		public bool Dx11Enable { get { return m_Dx11Enable; } set { if (OnPropertyChanging("DxDisplaySettings." + nameof(Dx11Enable), this, m_Dx11Enable, value)) m_Dx11Enable = value; } } // 0x4E (78)
		
		protected bool m_Dx10Dot0Enable = new bool();
		[ContainerField(Name: "Dx10Dot0Enable", Offset: 79, NameHash: 1768632854, Flags: 49325), LayoutImmutable, Blittable]
		public bool Dx10Dot0Enable { get { return m_Dx10Dot0Enable; } set { if (OnPropertyChanging("DxDisplaySettings." + nameof(Dx10Dot0Enable), this, m_Dx10Dot0Enable, value)) m_Dx10Dot0Enable = value; } } // 0x4F (79)
		
		protected bool m_RefDriverEnable = new bool();
		[ContainerField(Name: "RefDriverEnable", Offset: 80, NameHash: 1745920907, Flags: 49325), LayoutImmutable, Blittable]
		public bool RefDriverEnable { get { return m_RefDriverEnable; } set { if (OnPropertyChanging("DxDisplaySettings." + nameof(RefDriverEnable), this, m_RefDriverEnable, value)) m_RefDriverEnable = value; } } // 0x50 (80)
		
		protected bool m_Dx10Dot1Enable = new bool();
		[ContainerField(Name: "Dx10Dot1Enable", Offset: 81, NameHash: 1267572695, Flags: 49325), LayoutImmutable, Blittable]
		public bool Dx10Dot1Enable { get { return m_Dx10Dot1Enable; } set { if (OnPropertyChanging("DxDisplaySettings." + nameof(Dx10Dot1Enable), this, m_Dx10Dot1Enable, value)) m_Dx10Dot1Enable = value; } } // 0x51 (81)
		
		protected bool m_MinDriverRequired = new bool();
		[ContainerField(Name: "MinDriverRequired", Offset: 82, NameHash: 2006470392, Flags: 49325), LayoutImmutable, Blittable]
		public bool MinDriverRequired { get { return m_MinDriverRequired; } set { if (OnPropertyChanging("DxDisplaySettings." + nameof(MinDriverRequired), this, m_MinDriverRequired, value)) m_MinDriverRequired = value; } } // 0x52 (82)
		
		protected bool m_WarpDriverEnable = new bool();
		[ContainerField(Name: "WarpDriverEnable", Offset: 83, NameHash: 1373325966, Flags: 49325), LayoutImmutable, Blittable]
		public bool WarpDriverEnable { get { return m_WarpDriverEnable; } set { if (OnPropertyChanging("DxDisplaySettings." + nameof(WarpDriverEnable), this, m_WarpDriverEnable, value)) m_WarpDriverEnable = value; } } // 0x53 (83)
		
		protected bool m_NullDriverEnable = new bool();
		[ContainerField(Name: "NullDriverEnable", Offset: 84, NameHash: 2042103201, Flags: 49325), LayoutImmutable, Blittable]
		public bool NullDriverEnable { get { return m_NullDriverEnable; } set { if (OnPropertyChanging("DxDisplaySettings." + nameof(NullDriverEnable), this, m_NullDriverEnable, value)) m_NullDriverEnable = value; } } // 0x54 (84)
		
		protected bool m_MultiGpuValidationEnable = new bool();
		[ContainerField(Name: "MultiGpuValidationEnable", Offset: 85, NameHash: 1890184548, Flags: 49325), LayoutImmutable, Blittable]
		public bool MultiGpuValidationEnable { get { return m_MultiGpuValidationEnable; } set { if (OnPropertyChanging("DxDisplaySettings." + nameof(MultiGpuValidationEnable), this, m_MultiGpuValidationEnable, value)) m_MultiGpuValidationEnable = value; } } // 0x55 (85)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 1430980188:
					FullscreenWidth = (uint) p_Value;
					break;

				case 109852325:
					FullscreenHeight = (uint) p_Value;
					break;

				case 2479381411:
					AmdMinDriverVersion = (string) p_Value;
					break;

				case 3704079510:
					NvidiaMinDriverVersion = (uint) p_Value;
					break;

				case 911237061:
					FullscreenRefreshRate = (float) p_Value;
					break;

				case 2101591727:
					StereoSeparationScale = (float) p_Value;
					break;

				case 4166595090:
					StereoDepth = (float) p_Value;
					break;

				case 2675250075:
					FullscreenOutputIndex = (int) p_Value;
					break;

				case 4052915337:
					DebugBreakIgnoredIDs = (List<int>) p_Value;
					break;

				case 4196419630:
					StereoConvergenceScale = (float) p_Value;
					break;

				case 522462419:
					StereoSoldierZoomConvergenceScale = (float) p_Value;
					break;

				case 1880889646:
					ForceRenderAheadLimit = (int) p_Value;
					break;

				case 4204358449:
					PresentInterval = (int) p_Value;
					break;

				case 2632000193:
					DebugBreakOnWarningEnable = (bool) p_Value;
					break;

				case 4223944539:
					DebugInfoEnable = (bool) p_Value;
					break;

				case 2248877754:
					Fullscreen = (bool) p_Value;
					break;

				case 814125011:
					DebugBreakOnErrorEnable = (bool) p_Value;
					break;

				case 140168974:
					CreateMinimalWindow = (bool) p_Value;
					break;

				case 3689386451:
					DriverInternalThreadingEnable = (bool) p_Value;
					break;

				case 4085063333:
					DebugBreakOnInfoEnable = (bool) p_Value;
					break;

				case 885827480:
					FullscreenModeEnable = (bool) p_Value;
					break;

				case 486588565:
					VSyncEnable = (bool) p_Value;
					break;

				case 2513610482:
					TripleBufferingEnable = (bool) p_Value;
					break;

				case 2748289315:
					Dx10PlusEnable = (bool) p_Value;
					break;

				case 4131383908:
					NvApiEnable = (bool) p_Value;
					break;

				case 4224746564:
					NvPerfHudEnable = (bool) p_Value;
					break;

				case 87681470:
					StereoEnable = (bool) p_Value;
					break;

				case 2892685432:
					Dx11Enable = (bool) p_Value;
					break;

				case 1768632854:
					Dx10Dot0Enable = (bool) p_Value;
					break;

				case 1745920907:
					RefDriverEnable = (bool) p_Value;
					break;

				case 1267572695:
					Dx10Dot1Enable = (bool) p_Value;
					break;

				case 2006470392:
					MinDriverRequired = (bool) p_Value;
					break;

				case 1373325966:
					WarpDriverEnable = (bool) p_Value;
					break;

				case 2042103201:
					NullDriverEnable = (bool) p_Value;
					break;

				case 1890184548:
					MultiGpuValidationEnable = (bool) p_Value;
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
				case 1430980188:
					return FullscreenWidth;

				case 109852325:
					return FullscreenHeight;

				case 2479381411:
					return AmdMinDriverVersion;

				case 3704079510:
					return NvidiaMinDriverVersion;

				case 911237061:
					return FullscreenRefreshRate;

				case 2101591727:
					return StereoSeparationScale;

				case 4166595090:
					return StereoDepth;

				case 2675250075:
					return FullscreenOutputIndex;

				case 4052915337:
					return DebugBreakIgnoredIDs;

				case 4196419630:
					return StereoConvergenceScale;

				case 522462419:
					return StereoSoldierZoomConvergenceScale;

				case 1880889646:
					return ForceRenderAheadLimit;

				case 4204358449:
					return PresentInterval;

				case 2632000193:
					return DebugBreakOnWarningEnable;

				case 4223944539:
					return DebugInfoEnable;

				case 2248877754:
					return Fullscreen;

				case 814125011:
					return DebugBreakOnErrorEnable;

				case 140168974:
					return CreateMinimalWindow;

				case 3689386451:
					return DriverInternalThreadingEnable;

				case 4085063333:
					return DebugBreakOnInfoEnable;

				case 885827480:
					return FullscreenModeEnable;

				case 486588565:
					return VSyncEnable;

				case 2513610482:
					return TripleBufferingEnable;

				case 2748289315:
					return Dx10PlusEnable;

				case 4131383908:
					return NvApiEnable;

				case 4224746564:
					return NvPerfHudEnable;

				case 87681470:
					return StereoEnable;

				case 2892685432:
					return Dx11Enable;

				case 1768632854:
					return Dx10Dot0Enable;

				case 1745920907:
					return RefDriverEnable;

				case 1267572695:
					return Dx10Dot1Enable;

				case 2006470392:
					return MinDriverRequired;

				case 1373325966:
					return WarpDriverEnable;

				case 2042103201:
					return NullDriverEnable;

				case 1890184548:
					return MultiGpuValidationEnable;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 1430980188:
					return typeof(DxDisplaySettings).GetProperty(nameof(FullscreenWidth));

				case 109852325:
					return typeof(DxDisplaySettings).GetProperty(nameof(FullscreenHeight));

				case 2479381411:
					return typeof(DxDisplaySettings).GetProperty(nameof(AmdMinDriverVersion));

				case 3704079510:
					return typeof(DxDisplaySettings).GetProperty(nameof(NvidiaMinDriverVersion));

				case 911237061:
					return typeof(DxDisplaySettings).GetProperty(nameof(FullscreenRefreshRate));

				case 2101591727:
					return typeof(DxDisplaySettings).GetProperty(nameof(StereoSeparationScale));

				case 4166595090:
					return typeof(DxDisplaySettings).GetProperty(nameof(StereoDepth));

				case 2675250075:
					return typeof(DxDisplaySettings).GetProperty(nameof(FullscreenOutputIndex));

				case 4052915337:
					return typeof(DxDisplaySettings).GetProperty(nameof(DebugBreakIgnoredIDs));

				case 4196419630:
					return typeof(DxDisplaySettings).GetProperty(nameof(StereoConvergenceScale));

				case 522462419:
					return typeof(DxDisplaySettings).GetProperty(nameof(StereoSoldierZoomConvergenceScale));

				case 1880889646:
					return typeof(DxDisplaySettings).GetProperty(nameof(ForceRenderAheadLimit));

				case 4204358449:
					return typeof(DxDisplaySettings).GetProperty(nameof(PresentInterval));

				case 2632000193:
					return typeof(DxDisplaySettings).GetProperty(nameof(DebugBreakOnWarningEnable));

				case 4223944539:
					return typeof(DxDisplaySettings).GetProperty(nameof(DebugInfoEnable));

				case 2248877754:
					return typeof(DxDisplaySettings).GetProperty(nameof(Fullscreen));

				case 814125011:
					return typeof(DxDisplaySettings).GetProperty(nameof(DebugBreakOnErrorEnable));

				case 140168974:
					return typeof(DxDisplaySettings).GetProperty(nameof(CreateMinimalWindow));

				case 3689386451:
					return typeof(DxDisplaySettings).GetProperty(nameof(DriverInternalThreadingEnable));

				case 4085063333:
					return typeof(DxDisplaySettings).GetProperty(nameof(DebugBreakOnInfoEnable));

				case 885827480:
					return typeof(DxDisplaySettings).GetProperty(nameof(FullscreenModeEnable));

				case 486588565:
					return typeof(DxDisplaySettings).GetProperty(nameof(VSyncEnable));

				case 2513610482:
					return typeof(DxDisplaySettings).GetProperty(nameof(TripleBufferingEnable));

				case 2748289315:
					return typeof(DxDisplaySettings).GetProperty(nameof(Dx10PlusEnable));

				case 4131383908:
					return typeof(DxDisplaySettings).GetProperty(nameof(NvApiEnable));

				case 4224746564:
					return typeof(DxDisplaySettings).GetProperty(nameof(NvPerfHudEnable));

				case 87681470:
					return typeof(DxDisplaySettings).GetProperty(nameof(StereoEnable));

				case 2892685432:
					return typeof(DxDisplaySettings).GetProperty(nameof(Dx11Enable));

				case 1768632854:
					return typeof(DxDisplaySettings).GetProperty(nameof(Dx10Dot0Enable));

				case 1745920907:
					return typeof(DxDisplaySettings).GetProperty(nameof(RefDriverEnable));

				case 1267572695:
					return typeof(DxDisplaySettings).GetProperty(nameof(Dx10Dot1Enable));

				case 2006470392:
					return typeof(DxDisplaySettings).GetProperty(nameof(MinDriverRequired));

				case 1373325966:
					return typeof(DxDisplaySettings).GetProperty(nameof(WarpDriverEnable));

				case 2042103201:
					return typeof(DxDisplaySettings).GetProperty(nameof(NullDriverEnable));

				case 1890184548:
					return typeof(DxDisplaySettings).GetProperty(nameof(MultiGpuValidationEnable));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
