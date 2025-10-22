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

namespace fb.Terrain;

[ContainerType(8, 72)]
public class TerrainStreamingSettings
	: fb.Core.DataContainer
{
	[ContainerField(0x10), LayoutImmutable, Blittable, JsonProperty(Order = 16)]
	public uint DataLoadJobCount { get; set; } = 128;
	
	[ContainerField(0x14), LayoutImmutable, Blittable, JsonProperty(Order = 20)]
	public uint ActiveFreeStreamingDataLoadJobCount { get; set; } = 2;
	
	[ContainerField(0x18), LayoutImmutable, Blittable, JsonProperty(Order = 24)]
	public uint AdditionalBlurriness { get; set; } = 0;
	
	[ContainerField(0x1c), LayoutImmutable, Blittable, JsonProperty(Order = 28)]
	public float InvisibleDetailReductionFactor { get; set; } = -1.000f;
	
	[ContainerField(0x20), LayoutImmutable, Blittable, JsonProperty(Order = 32)]
	public float OccludedDetailReductionFactor { get; set; } = -1.000f;
	
	[ContainerField(0x24), LayoutImmutable, Blittable, JsonProperty(Order = 36)]
	public uint HeightfieldAtlasSampleCountXFactor { get; set; } = 1;
	
	[ContainerField(0x28), LayoutImmutable, Blittable, JsonProperty(Order = 40)]
	public uint HeightfieldAtlasSampleCountYFactor { get; set; } = 1;
	
	[ContainerField(0x2c), LayoutImmutable, Blittable, JsonProperty(Order = 44)]
	public uint MaskAtlasSampleCountXFactor { get; set; } = 1;
	
	[ContainerField(0x30), LayoutImmutable, Blittable, JsonProperty(Order = 48)]
	public uint MaskAtlasSampleCountYFactor { get; set; } = 1;
	
	[ContainerField(0x34), LayoutImmutable, Blittable, JsonProperty(Order = 52)]
	public uint MaskAdditionalBlurriness { get; set; } = 0;
	
	[ContainerField(0x38), LayoutImmutable, Blittable, JsonProperty(Order = 56)]
	public uint ColorAtlasSampleCountXFactor { get; set; } = 1;
	
	[ContainerField(0x3c), LayoutImmutable, Blittable, JsonProperty(Order = 60)]
	public uint ColorAtlasSampleCountYFactor { get; set; } = 1;
	
	[ContainerField(0x40), LayoutImmutable, Blittable, JsonProperty(Order = 64)]
	public uint ColorAdditionalBlurriness { get; set; } = 0;
	
	[ContainerField(0x44), LayoutImmutable, Blittable, JsonProperty(Order = 68)]
	public bool LoadOccluderDataEnable { get; set; } = true;
	
	[ContainerField(0x45), LayoutImmutable, Blittable, JsonProperty(Order = 69)]
	public bool KeepPoolFullEnable { get; set; } = true;
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(DataLoadJobCount);
		p_Writer.Write(ActiveFreeStreamingDataLoadJobCount);
		p_Writer.Write(AdditionalBlurriness);
		p_Writer.Write(InvisibleDetailReductionFactor);
		p_Writer.Write(OccludedDetailReductionFactor);
		p_Writer.Write(HeightfieldAtlasSampleCountXFactor);
		p_Writer.Write(HeightfieldAtlasSampleCountYFactor);
		p_Writer.Write(MaskAtlasSampleCountXFactor);
		p_Writer.Write(MaskAtlasSampleCountYFactor);
		p_Writer.Write(MaskAdditionalBlurriness);
		p_Writer.Write(ColorAtlasSampleCountXFactor);
		p_Writer.Write(ColorAtlasSampleCountYFactor);
		p_Writer.Write(ColorAdditionalBlurriness);
		p_Writer.Write(LoadOccluderDataEnable);
		p_Writer.Write(KeepPoolFullEnable);
		p_Writer.WriteNullBytes(2);
	}
}

