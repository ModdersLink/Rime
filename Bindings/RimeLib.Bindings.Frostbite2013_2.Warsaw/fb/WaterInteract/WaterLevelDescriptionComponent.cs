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
using fb.GameShared;

namespace fb.WaterInteract;

[ContainerType(8, 144)]
public class WaterLevelDescriptionComponent
	: fb.GameShared.LevelDescriptionComponent
{
	[ContainerField(0x10), JsonProperty(Order = 16)]
	public PlatformScalableInt MaxSimulationCount { get; set; } = new()
	{
		Gen4b = 2,
		Gen4a = 2,
		Ps3 = 2,
		Xenon = 2,
		Default = 2,
	};
	
	[ContainerField(0x24), JsonProperty(Order = 36)]
	public PlatformScalableInt MaxVisibleWaterSurfaceCount { get; set; } = new()
	{
		Gen4b = 2,
		Gen4a = 2,
		Ps3 = 1,
		Xenon = 1,
		Default = 2,
	};
	
	[ContainerField(0x38), JsonProperty(Order = 56)]
	public PlatformScalableInt RenderGridWidth { get; set; } = new()
	{
		Gen4b = 256,
		Gen4a = 256,
		Ps3 = 256,
		Xenon = 256,
		Default = 256,
	};
	
	[ContainerField(0x4c), JsonProperty(Order = 76)]
	public PlatformScalableInt RenderGridHeight { get; set; } = new()
	{
		Gen4b = 128,
		Gen4a = 128,
		Ps3 = 128,
		Xenon = 128,
		Default = 128,
	};
	
	[ContainerField(0x60), JsonProperty(Order = 96)]
	public PlatformScalableInt MinAmbientSimulationResolution { get; set; } = new()
	{
		Gen4b = 32,
		Gen4a = 32,
		Ps3 = 32,
		Xenon = 32,
		Default = 32,
	};
	
	[ContainerField(0x74), JsonProperty(Order = 116)]
	public PlatformScalableInt MaxAmbientSimulationResolution { get; set; } = new()
	{
		Gen4b = 128,
		Gen4a = 128,
		Ps3 = 64,
		Xenon = 64,
		Default = 128,
	};
	
	[ContainerField(0x88), JsonProperty(Order = 136)]
	public PlatformScalableBool Enabled { get; set; } = new()
	{
		Gen4b = true,
		Gen4a = true,
		Ps3 = true,
		Xenon = true,
		Default = true,
	};
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		MaxSimulationCount.Serialize(p_Writer, p_EbxWriter);
		MaxVisibleWaterSurfaceCount.Serialize(p_Writer, p_EbxWriter);
		RenderGridWidth.Serialize(p_Writer, p_EbxWriter);
		RenderGridHeight.Serialize(p_Writer, p_EbxWriter);
		MinAmbientSimulationResolution.Serialize(p_Writer, p_EbxWriter);
		MaxAmbientSimulationResolution.Serialize(p_Writer, p_EbxWriter);
		Enabled.Serialize(p_Writer, p_EbxWriter);
		p_Writer.WriteNullBytes(3);
	}
}

