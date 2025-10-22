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

namespace fb.WaterInteract;

[ContainerType(8, 160)]
public class WaterInteractSettings
	: fb.Core.SystemSettings
{
	public WaterInteractSettings()
	{
		//SystemSettings
		Name = @"WaterInteract";
	}
	
	[ContainerField(0x20), LayoutImmutable, Blittable, JsonProperty(Order = 32)]
	public uint SimulationJobCount { get; set; } = 6;
	
	[ContainerField(0x24), LayoutImmutable, Blittable, JsonProperty(Order = 36)]
	public QualityLevel WaterQualityLevel { get; set; } = QualityLevel.QualityLevel_High;
	
	[ContainerField(0x28), LayoutImmutable, Blittable, JsonProperty(Order = 40)]
	public uint MaxSimulationCount { get; set; } = 1;
	
	[ContainerField(0x2c), LayoutImmutable, Blittable, JsonProperty(Order = 44)]
	public uint MaxLiveEditingSimulationCount { get; set; } = 8;
	
	[ContainerField(0x30), LayoutImmutable, Blittable, JsonProperty(Order = 48)]
	public float MaxGridScale { get; set; } = 16.000f;
	
	[ContainerField(0x34), LayoutImmutable, Blittable, JsonProperty(Order = 52)]
	public float MinGridScale { get; set; } = 4.000f;
	
	[ContainerField(0x38), LayoutImmutable, Blittable, JsonProperty(Order = 56)]
	public float InteractInjectNoiseStrength { get; set; } = 0.000f;
	
	[ContainerField(0x3c), LayoutImmutable, Blittable, JsonProperty(Order = 60)]
	public float InteractMaxSlope { get; set; } = 2.000f;
	
	[ContainerField(0x40), LayoutImmutable, Blittable, JsonProperty(Order = 64)]
	public float InteractUpdateFrequency { get; set; } = 60.000f;
	
	[ContainerField(0x44), LayoutImmutable, Blittable, JsonProperty(Order = 68)]
	public uint MinAmbientSimulationResolution { get; set; } = 32;
	
	[ContainerField(0x48), LayoutImmutable, Blittable, JsonProperty(Order = 72)]
	public uint MaxAmbientSimulationResolution { get; set; } = 128;
	
	[ContainerField(0x4c), LayoutImmutable, Blittable, JsonProperty(Order = 76)]
	public uint RenderGridWidth { get; set; } = 256;
	
	[ContainerField(0x50), LayoutImmutable, Blittable, JsonProperty(Order = 80)]
	public uint RenderGridHeight { get; set; } = 128;
	
	[ContainerField(0x54), LayoutImmutable, Blittable, JsonProperty(Order = 84)]
	public float RenderFixedAimDistance { get; set; } = 30.000f;
	
	[ContainerField(0x58), LayoutImmutable, Blittable, JsonProperty(Order = 88)]
	public float RenderProjectorFarPlane { get; set; } = 5000.000f;
	
	[ContainerField(0x5c), LayoutImmutable, Blittable, JsonProperty(Order = 92)]
	public uint MaxVisibleWaterSurfaceCount { get; set; } = 1;
	
	[ContainerField(0x60), LayoutImmutable, Blittable, JsonProperty(Order = 96)]
	public uint MaxLiveEditingVisibleWaterSurfaceCount { get; set; } = 8;
	
	[ContainerField(0x64), JsonProperty(Order = 100)]
	public QualityScalableFloat PcGridResolutionMultiplier { get; set; } = new()
	{
		Ultra = 2.000f,
		High = 1.000f,
		Medium = 1.000f,
		Low = 0.500f,
	};
	
	[ContainerField(0x74), LayoutImmutable, Blittable, JsonProperty(Order = 116)]
	public uint RenderOcclusionCullJobCount { get; set; } = 6;
	
	[ContainerField(0x78), LayoutImmutable, Blittable, JsonProperty(Order = 120)]
	public uint RenderOcclusionGridWidth { get; set; } = 8;
	
	[ContainerField(0x7c), LayoutImmutable, Blittable, JsonProperty(Order = 124)]
	public uint RenderOcclusionGridHeight { get; set; } = 8;
	
	[ContainerField(0x80), LayoutImmutable, Blittable, JsonProperty(Order = 128)]
	public int VirtualHeightfieldAtlasSize { get; set; } = 256;
	
	[ContainerField(0x84), LayoutImmutable, Blittable, JsonProperty(Order = 132)]
	public int VirtualHeightfieldIndirectionSize { get; set; } = 128;
	
	[ContainerField(0x88), LayoutImmutable, Blittable, JsonProperty(Order = 136)]
	public float VirtualHeightfieldQuantizationRange { get; set; } = 1.000f;
	
	[ContainerField(0x8c), LayoutImmutable, Blittable, JsonProperty(Order = 140)]
	public bool Enable { get; set; } = true;
	
	[ContainerField(0x8d), LayoutImmutable, Blittable, JsonProperty(Order = 141)]
	public bool DrawEnable { get; set; } = true;
	
	[ContainerField(0x8e), LayoutImmutable, Blittable, JsonProperty(Order = 142)]
	public bool EnableJobs { get; set; } = true;
	
	[ContainerField(0x8f), LayoutImmutable, Blittable, JsonProperty(Order = 143)]
	public bool EnableSPUJobs { get; set; } = true;
	
	[ContainerField(0x90), LayoutImmutable, Blittable, JsonProperty(Order = 144)]
	public bool UsePS3CellMemoryBuffers { get; set; } = false;
	
	[ContainerField(0x91), LayoutImmutable, Blittable, JsonProperty(Order = 145)]
	public bool EnableSimulation { get; set; } = true;
	
	[ContainerField(0x92), LayoutImmutable, Blittable, JsonProperty(Order = 146)]
	public bool EnableDisturbs { get; set; } = true;
	
	[ContainerField(0x93), LayoutImmutable, Blittable, JsonProperty(Order = 147)]
	public bool EnableLOD { get; set; } = true;
	
	[ContainerField(0x94), LayoutImmutable, Blittable, JsonProperty(Order = 148)]
	public bool RenderOcclusionCullEnable { get; set; } = true;
	
	[ContainerField(0x95), LayoutImmutable, Blittable, JsonProperty(Order = 149)]
	public bool RenderGenerateDisplacementMipmaps { get; set; } = true;
	
	[ContainerField(0x96), LayoutImmutable, Blittable, JsonProperty(Order = 150)]
	public bool RenderGenerateGradientMipmaps { get; set; } = true;
	
	[ContainerField(0x97), LayoutImmutable, Blittable, JsonProperty(Order = 151)]
	public bool RenderDebugEnable { get; set; } = false;
	
	[ContainerField(0x98), LayoutImmutable, Blittable, JsonProperty(Order = 152)]
	public bool RenderDebugTexturesEnable { get; set; } = true;
	
	[ContainerField(0x99), LayoutImmutable, Blittable, JsonProperty(Order = 153)]
	public bool RenderDebugFreezeViewEnable { get; set; } = false;
	
	[ContainerField(0x9a), LayoutImmutable, Blittable, JsonProperty(Order = 154)]
	public bool DrawGridEnable { get; set; } = true;
	
	[ContainerField(0x9b), LayoutImmutable, Blittable, JsonProperty(Order = 155)]
	public bool DrawUpdateEnable { get; set; } = true;
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(SimulationJobCount);
		p_Writer.Write((int) WaterQualityLevel);
		p_Writer.Write(MaxSimulationCount);
		p_Writer.Write(MaxLiveEditingSimulationCount);
		p_Writer.Write(MaxGridScale);
		p_Writer.Write(MinGridScale);
		p_Writer.Write(InteractInjectNoiseStrength);
		p_Writer.Write(InteractMaxSlope);
		p_Writer.Write(InteractUpdateFrequency);
		p_Writer.Write(MinAmbientSimulationResolution);
		p_Writer.Write(MaxAmbientSimulationResolution);
		p_Writer.Write(RenderGridWidth);
		p_Writer.Write(RenderGridHeight);
		p_Writer.Write(RenderFixedAimDistance);
		p_Writer.Write(RenderProjectorFarPlane);
		p_Writer.Write(MaxVisibleWaterSurfaceCount);
		p_Writer.Write(MaxLiveEditingVisibleWaterSurfaceCount);
		PcGridResolutionMultiplier.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(RenderOcclusionCullJobCount);
		p_Writer.Write(RenderOcclusionGridWidth);
		p_Writer.Write(RenderOcclusionGridHeight);
		p_Writer.Write(VirtualHeightfieldAtlasSize);
		p_Writer.Write(VirtualHeightfieldIndirectionSize);
		p_Writer.Write(VirtualHeightfieldQuantizationRange);
		p_Writer.Write(Enable);
		p_Writer.Write(DrawEnable);
		p_Writer.Write(EnableJobs);
		p_Writer.Write(EnableSPUJobs);
		p_Writer.Write(UsePS3CellMemoryBuffers);
		p_Writer.Write(EnableSimulation);
		p_Writer.Write(EnableDisturbs);
		p_Writer.Write(EnableLOD);
		p_Writer.Write(RenderOcclusionCullEnable);
		p_Writer.Write(RenderGenerateDisplacementMipmaps);
		p_Writer.Write(RenderGenerateGradientMipmaps);
		p_Writer.Write(RenderDebugEnable);
		p_Writer.Write(RenderDebugTexturesEnable);
		p_Writer.Write(RenderDebugFreezeViewEnable);
		p_Writer.Write(DrawGridEnable);
		p_Writer.Write(DrawUpdateEnable);
		p_Writer.WriteNullBytes(4);
	}
}

