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
	[ContainerType(4, 88)]
	public class DxDisplaySettings : 
		SystemSettings
	{
		[ContainerField(12), LayoutImmutable, Blittable, JsonProperty(Order = 12)]
		public uint FullscreenWidth { get; set; }

		[ContainerField(16), LayoutImmutable, Blittable, JsonProperty(Order = 16)]
		public uint FullscreenHeight { get; set; }

		[ContainerField(20), LayoutImmutable, JsonProperty(Order = 20)]
		public string AmdMinDriverVersion { get; set; } = string.Empty;

		[ContainerField(24), LayoutImmutable, Blittable, JsonProperty(Order = 24)]
		public uint NvidiaMinDriverVersion { get; set; }

		[ContainerField(28), LayoutImmutable, Blittable, JsonProperty(Order = 28)]
		public float FullscreenRefreshRate { get; set; }

		[ContainerField(32), LayoutImmutable, Blittable, JsonProperty(Order = 32)]
		public float StereoSeparationScale { get; set; }

		[ContainerField(36), LayoutImmutable, Blittable, JsonProperty(Order = 36)]
		public float StereoDepth { get; set; }

		[ContainerField(40), LayoutImmutable, Blittable, JsonProperty(Order = 40)]
		public int FullscreenOutputIndex { get; set; }

		[ContainerField(44), JsonProperty(Order = 44)]
		public List<int> DebugBreakIgnoredIDs { get; set; } = new();

		[ContainerField(48), LayoutImmutable, Blittable, JsonProperty(Order = 48)]
		public float StereoConvergenceScale { get; set; }

		[ContainerField(52), LayoutImmutable, Blittable, JsonProperty(Order = 52)]
		public float StereoSoldierZoomConvergenceScale { get; set; }

		[ContainerField(56), LayoutImmutable, Blittable, JsonProperty(Order = 56)]
		public int ForceRenderAheadLimit { get; set; }

		[ContainerField(60), LayoutImmutable, Blittable, JsonProperty(Order = 60)]
		public int PresentInterval { get; set; }

		[ContainerField(64), LayoutImmutable, Blittable, JsonProperty(Order = 64)]
		public bool DebugBreakOnWarningEnable { get; set; }

		[ContainerField(65), LayoutImmutable, Blittable, JsonProperty(Order = 65)]
		public bool DebugInfoEnable { get; set; }

		[ContainerField(66), LayoutImmutable, Blittable, JsonProperty(Order = 66)]
		public bool Fullscreen { get; set; }

		[ContainerField(67), LayoutImmutable, Blittable, JsonProperty(Order = 67)]
		public bool DebugBreakOnErrorEnable { get; set; }

		[ContainerField(68), LayoutImmutable, Blittable, JsonProperty(Order = 68)]
		public bool CreateMinimalWindow { get; set; }

		[ContainerField(69), LayoutImmutable, Blittable, JsonProperty(Order = 69)]
		public bool DriverInternalThreadingEnable { get; set; }

		[ContainerField(70), LayoutImmutable, Blittable, JsonProperty(Order = 70)]
		public bool DebugBreakOnInfoEnable { get; set; }

		[ContainerField(71), LayoutImmutable, Blittable, JsonProperty(Order = 71)]
		public bool FullscreenModeEnable { get; set; }

		[ContainerField(72), LayoutImmutable, Blittable, JsonProperty(Order = 72)]
		public bool VSyncEnable { get; set; }

		[ContainerField(73), LayoutImmutable, Blittable, JsonProperty(Order = 73)]
		public bool TripleBufferingEnable { get; set; }

		[ContainerField(74), LayoutImmutable, Blittable, JsonProperty(Order = 74)]
		public bool Dx10PlusEnable { get; set; }

		[ContainerField(75), LayoutImmutable, Blittable, JsonProperty(Order = 75)]
		public bool NvApiEnable { get; set; }

		[ContainerField(76), LayoutImmutable, Blittable, JsonProperty(Order = 76)]
		public bool NvPerfHudEnable { get; set; }

		[ContainerField(77), LayoutImmutable, Blittable, JsonProperty(Order = 77)]
		public bool StereoEnable { get; set; }

		[ContainerField(78), LayoutImmutable, Blittable, JsonProperty(Order = 78)]
		public bool Dx11Enable { get; set; }

		[ContainerField(79), LayoutImmutable, Blittable, JsonProperty(Order = 79)]
		public bool Dx10Dot0Enable { get; set; }

		[ContainerField(80), LayoutImmutable, Blittable, JsonProperty(Order = 80)]
		public bool RefDriverEnable { get; set; }

		[ContainerField(81), LayoutImmutable, Blittable, JsonProperty(Order = 81)]
		public bool Dx10Dot1Enable { get; set; }

		[ContainerField(82), LayoutImmutable, Blittable, JsonProperty(Order = 82)]
		public bool MinDriverRequired { get; set; }

		[ContainerField(83), LayoutImmutable, Blittable, JsonProperty(Order = 83)]
		public bool WarpDriverEnable { get; set; }

		[ContainerField(84), LayoutImmutable, Blittable, JsonProperty(Order = 84)]
		public bool NullDriverEnable { get; set; }

		[ContainerField(85), LayoutImmutable, Blittable, JsonProperty(Order = 85)]
		public bool MultiGpuValidationEnable { get; set; }

	}
}
