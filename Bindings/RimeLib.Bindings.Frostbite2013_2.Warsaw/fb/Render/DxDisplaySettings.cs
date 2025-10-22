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

using fb.Core;

namespace fb.Render;

[ContainerType(8, 144)]
public class DxDisplaySettings
	: fb.Core.SystemSettings
{
	public DxDisplaySettings()
	{
		//SystemSettings
		Name = @"RenderDevice";
	}
	
	[ContainerField(0x20), JsonProperty(Order = 32)]
	public List<int> DebugBreakIgnoredIDs { get; set; } = new();
	
	[ContainerField(0x28), LayoutImmutable, Blittable, JsonProperty(Order = 40)]
	public uint FullscreenHeight { get; set; } = 0;
	
	[ContainerField(0x2c), LayoutImmutable, Blittable, JsonProperty(Order = 44)]
	public uint FullscreenWidth { get; set; } = 0;
	
	[ContainerField(0x30), LayoutImmutable, Blittable, JsonProperty(Order = 48)]
	public float FullscreenRefreshRate { get; set; } = 0.000f;
	
	[ContainerField(0x34), LayoutImmutable, Blittable, JsonProperty(Order = 52)]
	public int FullscreenOutputIndex { get; set; } = 0;
	
	[ContainerField(0x38), LayoutImmutable, Blittable, JsonProperty(Order = 56)]
	public int PresentInterval { get; set; } = 1;
	
	[ContainerField(0x3c), LayoutImmutable, Blittable, JsonProperty(Order = 60)]
	public uint PresentImmediateThreshold { get; set; } = 0;
	
	[ContainerField(0x40), LayoutImmutable, Blittable, JsonProperty(Order = 64)]
	public int RenderAheadLimit { get; set; } = -1;
	
	[ContainerField(0x44), LayoutImmutable, Blittable, JsonProperty(Order = 68)]
	public float StereoDepth { get; set; } = 1.000f;
	
	[ContainerField(0x48), LayoutImmutable, Blittable, JsonProperty(Order = 72)]
	public float StereoConvergenceScale { get; set; } = 1.000f;
	
	[ContainerField(0x4c), LayoutImmutable, Blittable, JsonProperty(Order = 76)]
	public float StereoSeparationScale { get; set; } = 1.000f;
	
	[ContainerField(0x50), LayoutImmutable, Blittable, JsonProperty(Order = 80)]
	public float StereoSoldierZoomConvergenceScale { get; set; } = 1.000f;
	
	[ContainerField(0x54), LayoutImmutable, Blittable, JsonProperty(Order = 84)]
	public uint NvidiaMinDriverVersion { get; set; } = 34052;
	
	[ContainerField(0x58), LayoutImmutable, Blittable, JsonProperty(Order = 88)]
	public string AmdMinDriverVersion { get; set; } = @"13.12";
	
	[ContainerField(0x60), LayoutImmutable, Blittable, JsonProperty(Order = 96)]
	public float LowResDisplayPlaneScale { get; set; } = 0.667f;
	
	[ContainerField(0x64), LayoutImmutable, Blittable, JsonProperty(Order = 100)]
	public bool NullDriverEnable { get; set; } = false;
	
	[ContainerField(0x65), LayoutImmutable, Blittable, JsonProperty(Order = 101)]
	public bool RefDriverEnable { get; set; } = false;
	
	[ContainerField(0x66), LayoutImmutable, Blittable, JsonProperty(Order = 102)]
	public bool WarpDriverEnable { get; set; } = false;
	
	[ContainerField(0x67), LayoutImmutable, Blittable, JsonProperty(Order = 103)]
	public bool Dx10Dot0Enable { get; set; } = false;
	
	[ContainerField(0x68), LayoutImmutable, Blittable, JsonProperty(Order = 104)]
	public bool Dx10Dot1Enable { get; set; } = true;
	
	[ContainerField(0x69), LayoutImmutable, Blittable, JsonProperty(Order = 105)]
	public bool Dx10PlusEnable { get; set; } = true;
	
	[ContainerField(0x6a), LayoutImmutable, Blittable, JsonProperty(Order = 106)]
	public bool Dx11Enable { get; set; } = true;
	
	[ContainerField(0x6b), LayoutImmutable, Blittable, JsonProperty(Order = 107)]
	public bool Dx11Dot1Enable { get; set; } = true;
	
	[ContainerField(0x6c), LayoutImmutable, Blittable, JsonProperty(Order = 108)]
	public bool Dx11Dot1RuntimeEnable { get; set; } = true;
	
	[ContainerField(0x6d), LayoutImmutable, Blittable, JsonProperty(Order = 109)]
	public bool CreateMinimalWindow { get; set; } = false;
	
	[ContainerField(0x6e), LayoutImmutable, Blittable, JsonProperty(Order = 110)]
	public bool DriverInternalThreadingEnable { get; set; } = true;
	
	[ContainerField(0x6f), LayoutImmutable, Blittable, JsonProperty(Order = 111)]
	public bool DxDiagDriverDetectionEnable { get; set; } = true;
	
	[ContainerField(0x70), LayoutImmutable, Blittable, JsonProperty(Order = 112)]
	public bool DebugInfoEnable { get; set; } = false;
	
	[ContainerField(0x71), LayoutImmutable, Blittable, JsonProperty(Order = 113)]
	public bool DebugInfoOutputEnable { get; set; } = true;
	
	[ContainerField(0x72), LayoutImmutable, Blittable, JsonProperty(Order = 114)]
	public bool DebugBreakOnErrorEnable { get; set; } = false;
	
	[ContainerField(0x73), LayoutImmutable, Blittable, JsonProperty(Order = 115)]
	public bool DebugBreakOnWarningEnable { get; set; } = false;
	
	[ContainerField(0x74), LayoutImmutable, Blittable, JsonProperty(Order = 116)]
	public bool DebugBreakOnInfoEnable { get; set; } = false;
	
	[ContainerField(0x75), LayoutImmutable, Blittable, JsonProperty(Order = 117)]
	public bool FullscreenModeEnable { get; set; } = true;
	
	[ContainerField(0x76), LayoutImmutable, Blittable, JsonProperty(Order = 118)]
	public bool Fullscreen { get; set; } = false;
	
	[ContainerField(0x77), LayoutImmutable, Blittable, JsonProperty(Order = 119)]
	public bool WindowBordersEnable { get; set; } = true;
	
	[ContainerField(0x78), LayoutImmutable, Blittable, JsonProperty(Order = 120)]
	public bool VSyncEnable { get; set; } = false;
	
	[ContainerField(0x79), LayoutImmutable, Blittable, JsonProperty(Order = 121)]
	public bool TripleBufferingEnable { get; set; } = true;
	
	[ContainerField(0x7a), LayoutImmutable, Blittable, JsonProperty(Order = 122)]
	public bool NvApiEnable { get; set; } = true;
	
	[ContainerField(0x7b), LayoutImmutable, Blittable, JsonProperty(Order = 123)]
	public bool NvPerfHudEnable { get; set; } = false;
	
	[ContainerField(0x7c), LayoutImmutable, Blittable, JsonProperty(Order = 124)]
	public bool AnnotationInterfaceEnable { get; set; } = true;
	
	[ContainerField(0x7d), LayoutImmutable, Blittable, JsonProperty(Order = 125)]
	public bool StereoEnable { get; set; } = false;
	
	[ContainerField(0x7e), LayoutImmutable, Blittable, JsonProperty(Order = 126)]
	public bool StereoSplitScreenEnable { get; set; } = false;
	
	[ContainerField(0x7f), LayoutImmutable, Blittable, JsonProperty(Order = 127)]
	public bool MinDriverRequired { get; set; } = true;
	
	[ContainerField(0x80), LayoutImmutable, Blittable, JsonProperty(Order = 128)]
	public bool AmdQuadsEnable { get; set; } = false;
	
	[ContainerField(0x81), LayoutImmutable, Blittable, JsonProperty(Order = 129)]
	public bool DepthBoundsExtensionEnable { get; set; } = true;
	
	[ContainerField(0x82), LayoutImmutable, Blittable, JsonProperty(Order = 130)]
	public bool MultiGpuValidationEnable { get; set; } = false;
	
	[ContainerField(0x83), LayoutImmutable, Blittable, JsonProperty(Order = 131)]
	public bool DiscardFrameTempBuffersEnable { get; set; } = true;
	
	[ContainerField(0x84), LayoutImmutable, Blittable, JsonProperty(Order = 132)]
	public bool PixProfilingEnable { get; set; } = false;
	
	[ContainerField(0x85), LayoutImmutable, Blittable, JsonProperty(Order = 133)]
	public bool AsyncCmdListExecutionEnable { get; set; } = false;
	
	[ContainerField(0x86), LayoutImmutable, Blittable, JsonProperty(Order = 134)]
	public bool VideoOutSrgbFullEnable { get; set; } = true;
	
	[ContainerField(0x87), LayoutImmutable, Blittable, JsonProperty(Order = 135)]
	public bool VideoOutSrgbToRec709Enable { get; set; } = false;
	
	[ContainerField(0x88), LayoutImmutable, Blittable, JsonProperty(Order = 136)]
	public bool EndFrameJobEnable { get; set; } = false;
	
	[ContainerField(0x89), LayoutImmutable, Blittable, JsonProperty(Order = 137)]
	public bool LowResDisplayPlaneEnable { get; set; } = false;
	
	[ContainerField(0x8a), LayoutImmutable, Blittable, JsonProperty(Order = 138)]
	public bool ForceRenderTargetInEsramTest { get; set; } = false;
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		(RimeWriter Writer, uint ArrayIndex) s_DebugBreakIgnoredIDs = p_EbxWriter.GetArrayWriter(DebugBreakIgnoredIDs.GetType(), DebugBreakIgnoredIDs.Count);
		p_Writer.Write(s_DebugBreakIgnoredIDs.ArrayIndex);
		foreach (var s_Entry in DebugBreakIgnoredIDs)
		{
			s_DebugBreakIgnoredIDs.Writer.Write(s_Entry);
		}
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(FullscreenHeight);
		p_Writer.Write(FullscreenWidth);
		p_Writer.Write(FullscreenRefreshRate);
		p_Writer.Write(FullscreenOutputIndex);
		p_Writer.Write(PresentInterval);
		p_Writer.Write(PresentImmediateThreshold);
		p_Writer.Write(RenderAheadLimit);
		p_Writer.Write(StereoDepth);
		p_Writer.Write(StereoConvergenceScale);
		p_Writer.Write(StereoSeparationScale);
		p_Writer.Write(StereoSoldierZoomConvergenceScale);
		p_Writer.Write(NvidiaMinDriverVersion);
		p_Writer.Write(p_EbxWriter.WriteString(AmdMinDriverVersion));
		p_Writer.Write(LowResDisplayPlaneScale);
		p_Writer.Write(NullDriverEnable);
		p_Writer.Write(RefDriverEnable);
		p_Writer.Write(WarpDriverEnable);
		p_Writer.Write(Dx10Dot0Enable);
		p_Writer.Write(Dx10Dot1Enable);
		p_Writer.Write(Dx10PlusEnable);
		p_Writer.Write(Dx11Enable);
		p_Writer.Write(Dx11Dot1Enable);
		p_Writer.Write(Dx11Dot1RuntimeEnable);
		p_Writer.Write(CreateMinimalWindow);
		p_Writer.Write(DriverInternalThreadingEnable);
		p_Writer.Write(DxDiagDriverDetectionEnable);
		p_Writer.Write(DebugInfoEnable);
		p_Writer.Write(DebugInfoOutputEnable);
		p_Writer.Write(DebugBreakOnErrorEnable);
		p_Writer.Write(DebugBreakOnWarningEnable);
		p_Writer.Write(DebugBreakOnInfoEnable);
		p_Writer.Write(FullscreenModeEnable);
		p_Writer.Write(Fullscreen);
		p_Writer.Write(WindowBordersEnable);
		p_Writer.Write(VSyncEnable);
		p_Writer.Write(TripleBufferingEnable);
		p_Writer.Write(NvApiEnable);
		p_Writer.Write(NvPerfHudEnable);
		p_Writer.Write(AnnotationInterfaceEnable);
		p_Writer.Write(StereoEnable);
		p_Writer.Write(StereoSplitScreenEnable);
		p_Writer.Write(MinDriverRequired);
		p_Writer.Write(AmdQuadsEnable);
		p_Writer.Write(DepthBoundsExtensionEnable);
		p_Writer.Write(MultiGpuValidationEnable);
		p_Writer.Write(DiscardFrameTempBuffersEnable);
		p_Writer.Write(PixProfilingEnable);
		p_Writer.Write(AsyncCmdListExecutionEnable);
		p_Writer.Write(VideoOutSrgbFullEnable);
		p_Writer.Write(VideoOutSrgbToRec709Enable);
		p_Writer.Write(EndFrameJobEnable);
		p_Writer.Write(LowResDisplayPlaneEnable);
		p_Writer.Write(ForceRenderTargetInEsramTest);
		p_Writer.WriteNullBytes(5);
	}
}

