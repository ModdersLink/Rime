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

namespace fb.GameShared;

[ContainerType(8, 192)]
public class MemoryLevelDescriptionComponent
	: fb.GameShared.LevelDescriptionComponent
{
	[ContainerField(0x10), LayoutImmutable, Blittable, JsonProperty(Order = 16)]
	public int TexturePoolSize { get; set; } = -1;
	
	[ContainerField(0x14), LayoutImmutable, Blittable, JsonProperty(Order = 20)]
	public int TexturePoolSizeXenon { get; set; } = -1;
	
	[ContainerField(0x18), LayoutImmutable, Blittable, JsonProperty(Order = 24)]
	public int TexturePoolSizePs3 { get; set; } = -1;
	
	[ContainerField(0x1c), LayoutImmutable, Blittable, JsonProperty(Order = 28)]
	public int TexturePoolSizeGen4a { get; set; } = -1;
	
	[ContainerField(0x20), LayoutImmutable, Blittable, JsonProperty(Order = 32)]
	public int TexturePoolSizeGen4b { get; set; } = -1;
	
	[ContainerField(0x24), LayoutImmutable, Blittable, JsonProperty(Order = 36)]
	public int MeshPoolSizePs3 { get; set; } = -1;
	
	[ContainerField(0x28), LayoutImmutable, Blittable, JsonProperty(Order = 40)]
	public int MeshPoolSizePs3Cell { get; set; } = -1;
	
	[ContainerField(0x2c), LayoutImmutable, Blittable, JsonProperty(Order = 44)]
	public int MeshPoolSizeXenon { get; set; } = -1;
	
	[ContainerField(0x30), JsonProperty(Order = 48)]
	public QualityScalableInt MeshPoolSizePC { get; set; } = new()
	{
		Ultra = -1,
		High = -1,
		Medium = -1,
		Low = -1,
	};
	
	[ContainerField(0x40), LayoutImmutable, Blittable, JsonProperty(Order = 64)]
	public int MeshPoolSizeGen4a { get; set; } = -1;
	
	[ContainerField(0x44), LayoutImmutable, Blittable, JsonProperty(Order = 68)]
	public int MeshPoolSizeGen4b { get; set; } = -1;
	
	[ContainerField(0x48), JsonProperty(Order = 72)]
	public PlatformScalableInt EmitterBaseAtlasWidth { get; set; } = new()
	{
		Gen4b = -1,
		Gen4a = -1,
		Ps3 = -1,
		Xenon = -1,
		Default = -1,
	};
	
	[ContainerField(0x5c), JsonProperty(Order = 92)]
	public PlatformScalableInt EmitterBaseAtlasHeight { get; set; } = new()
	{
		Gen4b = -1,
		Gen4a = -1,
		Ps3 = -1,
		Xenon = -1,
		Default = -1,
	};
	
	[ContainerField(0x70), JsonProperty(Order = 112)]
	public PlatformScalableInt EmitterBaseAtlasMipmapCount { get; set; } = new()
	{
		Gen4b = -1,
		Gen4a = -1,
		Ps3 = -1,
		Xenon = -1,
		Default = -1,
	};
	
	[ContainerField(0x84), JsonProperty(Order = 132)]
	public PlatformScalableInt EmitterNormalAtlasWidth { get; set; } = new()
	{
		Gen4b = -1,
		Gen4a = -1,
		Ps3 = -1,
		Xenon = -1,
		Default = -1,
	};
	
	[ContainerField(0x98), JsonProperty(Order = 152)]
	public PlatformScalableInt EmitterNormalAtlasHeight { get; set; } = new()
	{
		Gen4b = -1,
		Gen4a = -1,
		Ps3 = -1,
		Xenon = -1,
		Default = -1,
	};
	
	[ContainerField(0xac), JsonProperty(Order = 172)]
	public PlatformScalableInt EmitterNormalAtlasMipmapCount { get; set; } = new()
	{
		Gen4b = -1,
		Gen4a = -1,
		Ps3 = -1,
		Xenon = -1,
		Default = -1,
	};
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(TexturePoolSize);
		p_Writer.Write(TexturePoolSizeXenon);
		p_Writer.Write(TexturePoolSizePs3);
		p_Writer.Write(TexturePoolSizeGen4a);
		p_Writer.Write(TexturePoolSizeGen4b);
		p_Writer.Write(MeshPoolSizePs3);
		p_Writer.Write(MeshPoolSizePs3Cell);
		p_Writer.Write(MeshPoolSizeXenon);
		MeshPoolSizePC.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(MeshPoolSizeGen4a);
		p_Writer.Write(MeshPoolSizeGen4b);
		EmitterBaseAtlasWidth.Serialize(p_Writer, p_EbxWriter);
		EmitterBaseAtlasHeight.Serialize(p_Writer, p_EbxWriter);
		EmitterBaseAtlasMipmapCount.Serialize(p_Writer, p_EbxWriter);
		EmitterNormalAtlasWidth.Serialize(p_Writer, p_EbxWriter);
		EmitterNormalAtlasHeight.Serialize(p_Writer, p_EbxWriter);
		EmitterNormalAtlasMipmapCount.Serialize(p_Writer, p_EbxWriter);
	}
}

