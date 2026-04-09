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
	[ContainerType(4, 88)]
	public partial class DxDisplaySettings :
		SystemSettings
	{
		[ObservableProperty]
		[property: ContainerField(12), LayoutImmutable, Blittable, JsonProperty(Order = 12)]
		private uint _FullscreenWidth;

		[ObservableProperty]
		[property: ContainerField(16), LayoutImmutable, Blittable, JsonProperty(Order = 16)]
		private uint _FullscreenHeight;

		[ObservableProperty]
		[property: ContainerField(20), LayoutImmutable, JsonProperty(Order = 20)]
		private string _AmdMinDriverVersion = string.Empty;

		[ObservableProperty]
		[property: ContainerField(24), LayoutImmutable, Blittable, JsonProperty(Order = 24)]
		private uint _NvidiaMinDriverVersion;

		[ObservableProperty]
		[property: ContainerField(28), LayoutImmutable, Blittable, JsonProperty(Order = 28)]
		private float _FullscreenRefreshRate;

		[ObservableProperty]
		[property: ContainerField(32), LayoutImmutable, Blittable, JsonProperty(Order = 32)]
		private float _StereoSeparationScale;

		[ObservableProperty]
		[property: ContainerField(36), LayoutImmutable, Blittable, JsonProperty(Order = 36)]
		private float _StereoDepth;

		[ObservableProperty]
		[property: ContainerField(40), LayoutImmutable, Blittable, JsonProperty(Order = 40)]
		private int _FullscreenOutputIndex;

		[ObservableProperty]
		[property: ContainerField(44), JsonProperty(Order = 44)]
		private List<int> _DebugBreakIgnoredIDs = new();

		[ObservableProperty]
		[property: ContainerField(48), LayoutImmutable, Blittable, JsonProperty(Order = 48)]
		private float _StereoConvergenceScale;

		[ObservableProperty]
		[property: ContainerField(52), LayoutImmutable, Blittable, JsonProperty(Order = 52)]
		private float _StereoSoldierZoomConvergenceScale;

		[ObservableProperty]
		[property: ContainerField(56), LayoutImmutable, Blittable, JsonProperty(Order = 56)]
		private int _ForceRenderAheadLimit;

		[ObservableProperty]
		[property: ContainerField(60), LayoutImmutable, Blittable, JsonProperty(Order = 60)]
		private int _PresentInterval;

		[ObservableProperty]
		[property: ContainerField(64), LayoutImmutable, Blittable, JsonProperty(Order = 64)]
		private bool _DebugBreakOnWarningEnable;

		[ObservableProperty]
		[property: ContainerField(65), LayoutImmutable, Blittable, JsonProperty(Order = 65)]
		private bool _DebugInfoEnable;

		[ObservableProperty]
		[property: ContainerField(66), LayoutImmutable, Blittable, JsonProperty(Order = 66)]
		private bool _Fullscreen;

		[ObservableProperty]
		[property: ContainerField(67), LayoutImmutable, Blittable, JsonProperty(Order = 67)]
		private bool _DebugBreakOnErrorEnable;

		[ObservableProperty]
		[property: ContainerField(68), LayoutImmutable, Blittable, JsonProperty(Order = 68)]
		private bool _CreateMinimalWindow;

		[ObservableProperty]
		[property: ContainerField(69), LayoutImmutable, Blittable, JsonProperty(Order = 69)]
		private bool _DriverInternalThreadingEnable;

		[ObservableProperty]
		[property: ContainerField(70), LayoutImmutable, Blittable, JsonProperty(Order = 70)]
		private bool _DebugBreakOnInfoEnable;

		[ObservableProperty]
		[property: ContainerField(71), LayoutImmutable, Blittable, JsonProperty(Order = 71)]
		private bool _FullscreenModeEnable;

		[ObservableProperty]
		[property: ContainerField(72), LayoutImmutable, Blittable, JsonProperty(Order = 72)]
		private bool _VSyncEnable;

		[ObservableProperty]
		[property: ContainerField(73), LayoutImmutable, Blittable, JsonProperty(Order = 73)]
		private bool _TripleBufferingEnable;

		[ObservableProperty]
		[property: ContainerField(74), LayoutImmutable, Blittable, JsonProperty(Order = 74)]
		private bool _Dx10PlusEnable;

		[ObservableProperty]
		[property: ContainerField(75), LayoutImmutable, Blittable, JsonProperty(Order = 75)]
		private bool _NvApiEnable;

		[ObservableProperty]
		[property: ContainerField(76), LayoutImmutable, Blittable, JsonProperty(Order = 76)]
		private bool _NvPerfHudEnable;

		[ObservableProperty]
		[property: ContainerField(77), LayoutImmutable, Blittable, JsonProperty(Order = 77)]
		private bool _StereoEnable;

		[ObservableProperty]
		[property: ContainerField(78), LayoutImmutable, Blittable, JsonProperty(Order = 78)]
		private bool _Dx11Enable;

		[ObservableProperty]
		[property: ContainerField(79), LayoutImmutable, Blittable, JsonProperty(Order = 79)]
		private bool _Dx10Dot0Enable;

		[ObservableProperty]
		[property: ContainerField(80), LayoutImmutable, Blittable, JsonProperty(Order = 80)]
		private bool _RefDriverEnable;

		[ObservableProperty]
		[property: ContainerField(81), LayoutImmutable, Blittable, JsonProperty(Order = 81)]
		private bool _Dx10Dot1Enable;

		[ObservableProperty]
		[property: ContainerField(82), LayoutImmutable, Blittable, JsonProperty(Order = 82)]
		private bool _MinDriverRequired;

		[ObservableProperty]
		[property: ContainerField(83), LayoutImmutable, Blittable, JsonProperty(Order = 83)]
		private bool _WarpDriverEnable;

		[ObservableProperty]
		[property: ContainerField(84), LayoutImmutable, Blittable, JsonProperty(Order = 84)]
		private bool _NullDriverEnable;

		[ObservableProperty]
		[property: ContainerField(85), LayoutImmutable, Blittable, JsonProperty(Order = 85)]
		private bool _MultiGpuValidationEnable;

		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			p_Writer.Write(FullscreenWidth);
			p_Writer.Write(FullscreenHeight);
			p_Writer.Write(p_EbxWriter.WriteString(AmdMinDriverVersion));
			p_Writer.Write(NvidiaMinDriverVersion);
			p_Writer.Write(FullscreenRefreshRate);
			p_Writer.Write(StereoSeparationScale);
			p_Writer.Write(StereoDepth);
			p_Writer.Write(FullscreenOutputIndex);
			(RimeWriter Writer, uint ArrayIndex) s_DebugBreakIgnoredIDs = p_EbxWriter.GetArrayWriter(DebugBreakIgnoredIDs.GetType(), DebugBreakIgnoredIDs.Count);
			p_Writer.Write(s_DebugBreakIgnoredIDs.ArrayIndex);
			foreach (var s_Entry in DebugBreakIgnoredIDs)
			{
				s_DebugBreakIgnoredIDs.Writer.Write(s_Entry);
			}
			p_Writer.Write(StereoConvergenceScale);
			p_Writer.Write(StereoSoldierZoomConvergenceScale);
			p_Writer.Write(ForceRenderAheadLimit);
			p_Writer.Write(PresentInterval);
			p_Writer.Write(DebugBreakOnWarningEnable);
			p_Writer.Write(DebugInfoEnable);
			p_Writer.Write(Fullscreen);
			p_Writer.Write(DebugBreakOnErrorEnable);
			p_Writer.Write(CreateMinimalWindow);
			p_Writer.Write(DriverInternalThreadingEnable);
			p_Writer.Write(DebugBreakOnInfoEnable);
			p_Writer.Write(FullscreenModeEnable);
			p_Writer.Write(VSyncEnable);
			p_Writer.Write(TripleBufferingEnable);
			p_Writer.Write(Dx10PlusEnable);
			p_Writer.Write(NvApiEnable);
			p_Writer.Write(NvPerfHudEnable);
			p_Writer.Write(StereoEnable);
			p_Writer.Write(Dx11Enable);
			p_Writer.Write(Dx10Dot0Enable);
			p_Writer.Write(RefDriverEnable);
			p_Writer.Write(Dx10Dot1Enable);
			p_Writer.Write(MinDriverRequired);
			p_Writer.Write(WarpDriverEnable);
			p_Writer.Write(NullDriverEnable);
			p_Writer.Write(MultiGpuValidationEnable);
			p_Writer.WriteNullBytes(2);
		}
	}
}
