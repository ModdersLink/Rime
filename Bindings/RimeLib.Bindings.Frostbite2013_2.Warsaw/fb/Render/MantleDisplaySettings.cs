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

[ContainerType(8, 112)]
public class MantleDisplaySettings
	: fb.Core.DataContainer
{
	[ContainerField(0x10), LayoutImmutable, Blittable, JsonProperty(Order = 16)]
	public uint MaxValidationLevel { get; set; } = 0;
	
	[ContainerField(0x14), LayoutImmutable, Blittable, JsonProperty(Order = 20)]
	public uint ValidationLevel { get; set; } = 0;
	
	[ContainerField(0x18), LayoutImmutable, Blittable, JsonProperty(Order = 24)]
	public uint FullscreenHeight { get; set; } = 0;
	
	[ContainerField(0x1c), LayoutImmutable, Blittable, JsonProperty(Order = 28)]
	public uint FullscreenWidth { get; set; } = 0;
	
	[ContainerField(0x20), LayoutImmutable, Blittable, JsonProperty(Order = 32)]
	public float FullscreenRefreshRate { get; set; } = 0.000f;
	
	[ContainerField(0x24), LayoutImmutable, Blittable, JsonProperty(Order = 36)]
	public int FullscreenOutputIndex { get; set; } = -1;
	
	[ContainerField(0x28), LayoutImmutable, Blittable, JsonProperty(Order = 40)]
	public int PresentInterval { get; set; } = 1;
	
	[ContainerField(0x2c), LayoutImmutable, Blittable, JsonProperty(Order = 44)]
	public int RenderAheadLimit { get; set; } = -1;
	
	[ContainerField(0x30), LayoutImmutable, Blittable, JsonProperty(Order = 48)]
	public int GpuIndex { get; set; } = -1;
	
	[ContainerField(0x34), LayoutImmutable, Blittable, JsonProperty(Order = 52)]
	public uint MultiGpuMaxCount { get; set; } = 4;
	
	[ContainerField(0x38), LayoutImmutable, Blittable, JsonProperty(Order = 56)]
	public int CrossDisplayPresent { get; set; } = -1;
	
	[ContainerField(0x3c), LayoutImmutable, Blittable, JsonProperty(Order = 60)]
	public uint SimulateMultiGpuCount { get; set; } = 0;
	
	[ContainerField(0x40), LayoutImmutable, Blittable, JsonProperty(Order = 64)]
	public uint FramePacingMethod { get; set; } = 2;
	
	[ContainerField(0x44), LayoutImmutable, Blittable, JsonProperty(Order = 68)]
	public float FramePacingDampeningFactor { get; set; } = 0.850f;
	
	[ContainerField(0x48), LayoutImmutable, Blittable, JsonProperty(Order = 72)]
	public float FramePacingSpikeFilterThreshold { get; set; } = 1.000f;
	
	[ContainerField(0x4c), LayoutImmutable, Blittable, JsonProperty(Order = 76)]
	public uint FramePacingHistorySize { get; set; } = 32;
	
	[ContainerField(0x50), LayoutImmutable, Blittable, JsonProperty(Order = 80)]
	public bool BreakOnError { get; set; } = true;
	
	[ContainerField(0x51), LayoutImmutable, Blittable, JsonProperty(Order = 81)]
	public bool BreakOnWarning { get; set; } = false;
	
	[ContainerField(0x52), LayoutImmutable, Blittable, JsonProperty(Order = 82)]
	public bool Fullscreen { get; set; } = false;
	
	[ContainerField(0x53), LayoutImmutable, Blittable, JsonProperty(Order = 83)]
	public bool WindowBordersEnable { get; set; } = true;
	
	[ContainerField(0x54), LayoutImmutable, Blittable, JsonProperty(Order = 84)]
	public bool VSyncEnable { get; set; } = false;
	
	[ContainerField(0x55), LayoutImmutable, Blittable, JsonProperty(Order = 85)]
	public bool MemoryPoolingEnable { get; set; } = true;
	
	[ContainerField(0x56), LayoutImmutable, Blittable, JsonProperty(Order = 86)]
	public bool GpuProfilerEnable { get; set; } = true;
	
	[ContainerField(0x57), LayoutImmutable, Blittable, JsonProperty(Order = 87)]
	public bool MultiGpuEnable { get; set; } = true;
	
	[ContainerField(0x58), LayoutImmutable, Blittable, JsonProperty(Order = 88)]
	public bool ComputeQueueEnable { get; set; } = true;
	
	[ContainerField(0x59), LayoutImmutable, Blittable, JsonProperty(Order = 89)]
	public bool DmaQueueEnable { get; set; } = true;
	
	[ContainerField(0x5a), LayoutImmutable, Blittable, JsonProperty(Order = 90)]
	public bool TimerQueueEnable { get; set; } = true;
	
	[ContainerField(0x5b), LayoutImmutable, Blittable, JsonProperty(Order = 91)]
	public bool AdvancedMsaaEnable { get; set; } = true;
	
	[ContainerField(0x5c), LayoutImmutable, Blittable, JsonProperty(Order = 92)]
	public bool FmaskEnable { get; set; } = true;
	
	[ContainerField(0x5d), LayoutImmutable, Blittable, JsonProperty(Order = 93)]
	public bool TimestampQueriesEnable { get; set; } = true;
	
	[ContainerField(0x5e), LayoutImmutable, Blittable, JsonProperty(Order = 94)]
	public bool DepthBoundsEnable { get; set; } = true;
	
	[ContainerField(0x5f), LayoutImmutable, Blittable, JsonProperty(Order = 95)]
	public bool QuadListEnable { get; set; } = false;
	
	[ContainerField(0x60), LayoutImmutable, Blittable, JsonProperty(Order = 96)]
	public bool RectListEnable { get; set; } = true;
	
	[ContainerField(0x61), LayoutImmutable, Blittable, JsonProperty(Order = 97)]
	public bool CmdBufferOptimizePipelineSwitch { get; set; } = true;
	
	[ContainerField(0x62), LayoutImmutable, Blittable, JsonProperty(Order = 98)]
	public bool CmdBufferOptimizeDescriptorSetSwitch { get; set; } = false;
	
	[ContainerField(0x63), LayoutImmutable, Blittable, JsonProperty(Order = 99)]
	public bool CmdBufferOptimizeGpuSmallBatch { get; set; } = false;
	
	[ContainerField(0x64), LayoutImmutable, Blittable, JsonProperty(Order = 100)]
	public bool CmdBufferOptimizeOneTimeEnable { get; set; } = true;
	
	[ContainerField(0x65), LayoutImmutable, Blittable, JsonProperty(Order = 101)]
	public bool RenderAccessOptimalEnable { get; set; } = true;
	
	[ContainerField(0x66), LayoutImmutable, Blittable, JsonProperty(Order = 102)]
	public bool UseReservedJobThreads { get; set; } = true;
	
	[ContainerField(0x67), LayoutImmutable, Blittable, JsonProperty(Order = 103)]
	public bool ForceDriverPreferredMemoryLocations { get; set; } = false;
	
	[ContainerField(0x68), LayoutImmutable, Blittable, JsonProperty(Order = 104)]
	public bool VideoSharedAsSystemSharedOnIntegrated { get; set; } = true;
	
	[ContainerField(0x69), LayoutImmutable, Blittable, JsonProperty(Order = 105)]
	public bool SubmitJobEnable { get; set; } = true;
	
	[ContainerField(0x6a), LayoutImmutable, Blittable, JsonProperty(Order = 106)]
	public bool DrawStats { get; set; } = false;
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(MaxValidationLevel);
		p_Writer.Write(ValidationLevel);
		p_Writer.Write(FullscreenHeight);
		p_Writer.Write(FullscreenWidth);
		p_Writer.Write(FullscreenRefreshRate);
		p_Writer.Write(FullscreenOutputIndex);
		p_Writer.Write(PresentInterval);
		p_Writer.Write(RenderAheadLimit);
		p_Writer.Write(GpuIndex);
		p_Writer.Write(MultiGpuMaxCount);
		p_Writer.Write(CrossDisplayPresent);
		p_Writer.Write(SimulateMultiGpuCount);
		p_Writer.Write(FramePacingMethod);
		p_Writer.Write(FramePacingDampeningFactor);
		p_Writer.Write(FramePacingSpikeFilterThreshold);
		p_Writer.Write(FramePacingHistorySize);
		p_Writer.Write(BreakOnError);
		p_Writer.Write(BreakOnWarning);
		p_Writer.Write(Fullscreen);
		p_Writer.Write(WindowBordersEnable);
		p_Writer.Write(VSyncEnable);
		p_Writer.Write(MemoryPoolingEnable);
		p_Writer.Write(GpuProfilerEnable);
		p_Writer.Write(MultiGpuEnable);
		p_Writer.Write(ComputeQueueEnable);
		p_Writer.Write(DmaQueueEnable);
		p_Writer.Write(TimerQueueEnable);
		p_Writer.Write(AdvancedMsaaEnable);
		p_Writer.Write(FmaskEnable);
		p_Writer.Write(TimestampQueriesEnable);
		p_Writer.Write(DepthBoundsEnable);
		p_Writer.Write(QuadListEnable);
		p_Writer.Write(RectListEnable);
		p_Writer.Write(CmdBufferOptimizePipelineSwitch);
		p_Writer.Write(CmdBufferOptimizeDescriptorSetSwitch);
		p_Writer.Write(CmdBufferOptimizeGpuSmallBatch);
		p_Writer.Write(CmdBufferOptimizeOneTimeEnable);
		p_Writer.Write(RenderAccessOptimalEnable);
		p_Writer.Write(UseReservedJobThreads);
		p_Writer.Write(ForceDriverPreferredMemoryLocations);
		p_Writer.Write(VideoSharedAsSystemSharedOnIntegrated);
		p_Writer.Write(SubmitJobEnable);
		p_Writer.Write(DrawStats);
		p_Writer.WriteNullBytes(5);
	}
}

