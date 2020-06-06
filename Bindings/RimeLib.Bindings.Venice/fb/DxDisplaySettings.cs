///////////////////////////////////////////////////////////////
//                                                           //
// This is an automatically generated file.                  //
// Do *NOT* modify unless you really know what you're doing. //
//                                                           //
///////////////////////////////////////////////////////////////

using System.Collections.Generic;
using System.Reflection;using RimeLib.Serialization.Attributes;using RimeLib.Serialization.Ebx;using RimeLib.Serialization.Containers;using RimeLib.Frostbite.Core;

namespace fb
{
    [ContainerType(4)]
	public class DxDisplaySettings : 
		SystemSettings
	{
		[ContainerField(12), LayoutImmutable, Blittable]
		public uint FullscreenWidth { get; set; } // 0xC (12)
		
		[ContainerField(16), LayoutImmutable, Blittable]
		public uint FullscreenHeight { get; set; } // 0x10 (16)
		
		[ContainerField(20), LayoutImmutable]
		public string AmdMinDriverVersion { get; set; } // 0x14 (20)
		
		[ContainerField(24), LayoutImmutable, Blittable]
		public uint NvidiaMinDriverVersion { get; set; } // 0x18 (24)
		
		[ContainerField(28), LayoutImmutable, Blittable]
		public float FullscreenRefreshRate { get; set; } // 0x1C (28)
		
		[ContainerField(32), LayoutImmutable, Blittable]
		public float StereoSeparationScale { get; set; } // 0x20 (32)
		
		[ContainerField(36), LayoutImmutable, Blittable]
		public float StereoDepth { get; set; } // 0x24 (36)
		
		[ContainerField(40), LayoutImmutable, Blittable]
		public int FullscreenOutputIndex { get; set; } // 0x28 (40)
		
		[ContainerField(44)]
		public List<int> DebugBreakIgnoredIDs { get; set; } = new List<int>(); // 0x2C (44)
		
		[ContainerField(48), LayoutImmutable, Blittable]
		public float StereoConvergenceScale { get; set; } // 0x30 (48)
		
		[ContainerField(52), LayoutImmutable, Blittable]
		public float StereoSoldierZoomConvergenceScale { get; set; } // 0x34 (52)
		
		[ContainerField(56), LayoutImmutable, Blittable]
		public int ForceRenderAheadLimit { get; set; } // 0x38 (56)
		
		[ContainerField(60), LayoutImmutable, Blittable]
		public int PresentInterval { get; set; } // 0x3C (60)
		
		[ContainerField(64), LayoutImmutable, Blittable]
		public bool DebugBreakOnWarningEnable { get; set; } // 0x40 (64)
		
		[ContainerField(65), LayoutImmutable, Blittable]
		public bool DebugInfoEnable { get; set; } // 0x41 (65)
		
		[ContainerField(66), LayoutImmutable, Blittable]
		public bool Fullscreen { get; set; } // 0x42 (66)
		
		[ContainerField(67), LayoutImmutable, Blittable]
		public bool DebugBreakOnErrorEnable { get; set; } // 0x43 (67)
		
		[ContainerField(68), LayoutImmutable, Blittable]
		public bool CreateMinimalWindow { get; set; } // 0x44 (68)
		
		[ContainerField(69), LayoutImmutable, Blittable]
		public bool DriverInternalThreadingEnable { get; set; } // 0x45 (69)
		
		[ContainerField(70), LayoutImmutable, Blittable]
		public bool DebugBreakOnInfoEnable { get; set; } // 0x46 (70)
		
		[ContainerField(71), LayoutImmutable, Blittable]
		public bool FullscreenModeEnable { get; set; } // 0x47 (71)
		
		[ContainerField(72), LayoutImmutable, Blittable]
		public bool VSyncEnable { get; set; } // 0x48 (72)
		
		[ContainerField(73), LayoutImmutable, Blittable]
		public bool TripleBufferingEnable { get; set; } // 0x49 (73)
		
		[ContainerField(74), LayoutImmutable, Blittable]
		public bool Dx10PlusEnable { get; set; } // 0x4A (74)
		
		[ContainerField(75), LayoutImmutable, Blittable]
		public bool NvApiEnable { get; set; } // 0x4B (75)
		
		[ContainerField(76), LayoutImmutable, Blittable]
		public bool NvPerfHudEnable { get; set; } // 0x4C (76)
		
		[ContainerField(77), LayoutImmutable, Blittable]
		public bool StereoEnable { get; set; } // 0x4D (77)
		
		[ContainerField(78), LayoutImmutable, Blittable]
		public bool Dx11Enable { get; set; } // 0x4E (78)
		
		[ContainerField(79), LayoutImmutable, Blittable]
		public bool Dx10Dot0Enable { get; set; } // 0x4F (79)
		
		[ContainerField(80), LayoutImmutable, Blittable]
		public bool RefDriverEnable { get; set; } // 0x50 (80)
		
		[ContainerField(81), LayoutImmutable, Blittable]
		public bool Dx10Dot1Enable { get; set; } // 0x51 (81)
		
		[ContainerField(82), LayoutImmutable, Blittable]
		public bool MinDriverRequired { get; set; } // 0x52 (82)
		
		[ContainerField(83), LayoutImmutable, Blittable]
		public bool WarpDriverEnable { get; set; } // 0x53 (83)
		
		[ContainerField(84), LayoutImmutable, Blittable]
		public bool NullDriverEnable { get; set; } // 0x54 (84)
		
		[ContainerField(85), LayoutImmutable, Blittable]
		public bool MultiGpuValidationEnable { get; set; } // 0x55 (85)
		
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
