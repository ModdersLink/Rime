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

namespace fb.WorldRender;

[ContainerType(8, 48)]
public class DestructionVolumeSettings
	: fb.Core.DataContainer
{
	[ContainerField(0x10), LayoutImmutable, Blittable, JsonProperty(Order = 16)]
	public float PixelsPerMeter { get; set; } = 1.000f;
	
	[ContainerField(0x14), LayoutImmutable, Blittable, JsonProperty(Order = 20)]
	public float DistanceFieldMultiplier { get; set; } = 0.200f;
	
	[ContainerField(0x18), LayoutImmutable, Blittable, JsonProperty(Order = 24)]
	public int TexturePoolSize { get; set; } = 262208;
	
	[ContainerField(0x1c), LayoutImmutable, Blittable, JsonProperty(Order = 28)]
	public int TexturePoolHeadroomSize { get; set; } = 16384;
	
	[ContainerField(0x20), LayoutImmutable, Blittable, JsonProperty(Order = 32)]
	public int TexturePoolDefragTransferLimit { get; set; } = 64;
	
	[ContainerField(0x24), LayoutImmutable, Blittable, JsonProperty(Order = 36)]
	public bool JobsEnable { get; set; } = true;
	
	[ContainerField(0x25), LayoutImmutable, Blittable, JsonProperty(Order = 37)]
	public bool ForceUpdateEnable { get; set; } = false;
	
	[ContainerField(0x26), LayoutImmutable, Blittable, JsonProperty(Order = 38)]
	public bool DrawDebugVolumes { get; set; } = false;
	
	[ContainerField(0x27), LayoutImmutable, Blittable, JsonProperty(Order = 39)]
	public bool DrawDebugImpacts { get; set; } = false;
	
	[ContainerField(0x28), LayoutImmutable, Blittable, JsonProperty(Order = 40)]
	public bool DrawDebugTexturePool { get; set; } = false;
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(PixelsPerMeter);
		p_Writer.Write(DistanceFieldMultiplier);
		p_Writer.Write(TexturePoolSize);
		p_Writer.Write(TexturePoolHeadroomSize);
		p_Writer.Write(TexturePoolDefragTransferLimit);
		p_Writer.Write(JobsEnable);
		p_Writer.Write(ForceUpdateEnable);
		p_Writer.Write(DrawDebugVolumes);
		p_Writer.Write(DrawDebugImpacts);
		p_Writer.Write(DrawDebugTexturePool);
		p_Writer.WriteNullBytes(7);
	}
}

